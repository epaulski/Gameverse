using Gameverse.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gameverse.Code
{
    public partial class _return : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["LoggedInId"] == null)
            {
                Response.Redirect("login.aspx?error=1");
            }
            else
            {

                String AppId = ConfigurationManager.AppSettings["CreditAppId"];
                String SharedKey = ConfigurationManager.AppSettings["CreditAppSharedKey"];
                String AppTransId = Request.QueryString["TransId"].ToString();

                //To be safe, you should check the value from the DB as well.
                String AppTransAmount = Request.QueryString["TransAmount"].ToString();

                String status = Request.QueryString["StatusCode"].ToString();
                String hash = Request.QueryString["AppHash"].ToString();

                if (CreditAuthorizationClient.VerifyServerResponseHash(hash, SharedKey, AppId, AppTransId, AppTransAmount, status))
                {
                    int orderId = Int32.Parse(AppTransId);
                    switch (status)
                    {
                        case ("A"):
                            using (GameverseContext context = new GameverseContext())
                            {
                                foreach (CartItem i in context.CartItems)
                                {
                                    // Build new OrderProduct entry
                                    var newOrderProduct = new OrderProduct();

                                    newOrderProduct.OrderId = orderId;
                                    newOrderProduct.ProductId = i.ProductId;
                                    newOrderProduct.Quantity = (int)i.Quantity;

                                    i.Product.Quantity = Math.Max(0, i.Product.Quantity - (int)i.Quantity);
                                   
                                    context.OrderProducts.Add(newOrderProduct);
                                    context.CartItems.Remove(i);
                                }

                                var order = (from o in context.Orders where o.Id == orderId select o).FirstOrDefault();
                                order.Status = "Shipping";
                                
                                context.SaveChanges();
                            }
                               
                            Session["CartQuantity"] = 0;

                            LabelStatus.Text = "Thank You For Your Purchase!";
                            break;

                        case ("C"):
                            using (GameverseContext context = new GameverseContext())
                            {
                                var order = (from o in context.Orders where o.Id == orderId select o).FirstOrDefault();

                                context.Orders.Remove(order);
                                context.SaveChanges();
                            }
                              
                            LabelStatus.Text = "Transaction Denied!";
                            break;
                    }
                }
                else
                {
                    LabelStatus.Text = "Hash Verification failed... something went wrong.";
                }
            }
        }
    }
}