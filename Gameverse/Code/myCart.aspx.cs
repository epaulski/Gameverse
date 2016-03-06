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
    public partial class myCart : System.Web.UI.Page
    {
        private int userId;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["LoggedInId"] == null)
            {
                Response.Redirect("login.aspx?error=1");
            }
            else if (!IsPostBack)
            {
                Session["update"] = Server.UrlEncode(System.DateTime.Now.ToString());
            }

            HyperLink linkSession = (HyperLink)Master.FindControl("linkSession");
            linkSession.Text = "Logout";

            HyperLink linkRegister = (HyperLink)Master.FindControl("linkRegister");
            linkRegister.Text = "Hello, " + Session["FirstName"];
            linkRegister.Enabled = false;

            userId = int.Parse(Session["LoggedInId"].ToString());

            LoadCart();
        }

        protected void LoadCart()
        {
            using (GameverseContext context = new GameverseContext())
            {
                var MyCartItems = from i in context.CartItems
                                  where i.UserId == userId
                                  orderby i.ProductId
                                  select i;

                foreach (CartItem i in MyCartItems)
                {
                    TableRow row = new TableRow();
                    TableCell cell;

                    cell = new TableCell();
                    cell.Text = i.Product.Name + " - " + i.Product.Platform;
                    row.Cells.Add(cell);

                    cell = new TableCell();
                    cell.Text = i.Quantity.ToString();
                    row.Cells.Add(cell);

                    cell = new TableCell();
                    Button link = new Button();
                    link.Text = "Remove";
                    link.CssClass = "btn btn-danger btn-sm";
                    link.Click +=
                         new EventHandler((s, e) => RemoveClick(s, e, i.Id));
                    cell.Controls.Add(link);
                    row.Cells.Add(cell);

                    TableCart.Rows.Add(row);
                }
            }
        }

        protected void RemoveClick(object s, EventArgs e, int item)
        {
            Message.Text = item.ToString();
            using (GameverseContext context = new GameverseContext())
            {
                var citem = (from ci in context.CartItems
                             where ci.UserId == userId && ci.Id == item
                             select ci).FirstOrDefault();
                if (citem != null)
                {
                    context.CartItems.Remove(citem);
                    context.SaveChanges();
                    Response.Redirect("myCart.aspx");
                }
                else
                {
                    Message.Text = "Sorry, the item can't be removed.";
                }
            }
        }

        protected void ClickNextToPayment(object sender, EventArgs e)
        {
            if (Session["LoggedInId"] == null)
            {
                Response.Redirect("Login.aspx");
            }

            using (GameverseContext context = new GameverseContext())
            {
                // Build new Order entry
                var neworder = new Order();
                neworder.UserId = userId;

                // TODO: check if the user wants to use the home address as shipping address or add a new one
                var shippingAddressId = (from a in context.Addresses
                                         where a.UserId == userId 
                                         select a.Id).FirstOrDefault();

                neworder.ShippingAddressId = shippingAddressId;
                // TODO: check if the user wants to use the home address as billing address or add a new one
                neworder.BillingAddressId = shippingAddressId;
                neworder.Date = DateTime.Now;
                neworder.Status = "Shipping";
     
                context.Orders.Add(neworder);
                context.SaveChanges();

                var MyCartItems = from i in context.CartItems
                                  where i.UserId == userId
                                  orderby i.ProductId
                                  select i;

                double amount = 0;
                foreach (CartItem i in MyCartItems)
                {
                    // Build new OrderProduct entry
                    var newOrderProduct = new OrderProduct();

                    newOrderProduct.OrderId = neworder.Id;
                    newOrderProduct.ProductId = i.ProductId;
                    newOrderProduct.Quantity = (int) i.Quantity;
                    amount = amount + (int) i.Quantity * i.Product.Value;

                    context.OrderProducts.Add(newOrderProduct);
                    context.CartItems.Remove(i);
                }

                neworder.Total = amount;

                context.SaveChanges();
                RedirectUser(neworder.Id.ToString(), amount.ToString());

                Session["update"] = Server.UrlEncode(System.DateTime.Now.ToString());
            }
        }

        private void RedirectUser(string v1, string v2)
        {
            //Assign the values for the properties we need to pass to the service
            String AppId = ConfigurationManager.AppSettings["CreditAppId"];
            String SharedKey = ConfigurationManager.AppSettings["CreditAppSharedKey"];
            String AppTransId = v1;
            String AppTransAmount = v2;

            // Hash the values so the server can verify the values are original
            String hash = HttpUtility.UrlEncode(CreditAuthorizationClient.GenerateClientRequestHash(SharedKey, AppId, AppTransId, AppTransAmount));

            //Create the URL and  concatenate  the Query String values
            String url = "http://ectweb2.cs.depaul.edu/ECTCreditGateway/Authorize.aspx";
            url = url + "?AppId=" + AppId;
            url = url + "&TransId=" + AppTransId;
            url = url + "&AppTransAmount=" + AppTransAmount;
            url = url + "&AppHash=" + hash;

            //Redirect the User to the Service
            Response.Redirect(url);
        }

        protected void ClickNextToAddress(object sender, EventArgs e)
        {
            Panel1.Visible = true;
        }

        protected override void OnPreRender(EventArgs e)
        {
            ViewState["update"] = Session["update"];
        }
    }
}