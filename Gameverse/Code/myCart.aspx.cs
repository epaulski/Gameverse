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
        private bool isNewAddress;

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

            isNewAddress = false;

            HyperLink linkSession = (HyperLink)Master.FindControl("linkSession");
            linkSession.Text = "Logout";

            HyperLink linkRegister = (HyperLink)Master.FindControl("linkRegister");
            linkRegister.Text = "Hello, " + Session["FirstName"];
            linkRegister.Enabled = false;

            Label lblCartQuantity = (Label)Master.FindControl("lblCartQuantity");
            lblCartQuantity.Text = (Session["CartQuantity"]).ToString();

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

                if (MyCartItems.Count() == 0)
                {
                    Panel3.Visible = true;
                }
                else
                {
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
                    Panel1.Visible = true;
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

                    Session["CartQuantity"] = (int)Session["CartQuantity"] - citem.Quantity;

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

                // If the address is new, ship to the last address added
                // If not, get the value from the dropdownlist
                int shippingAddressId;
                if (isNewAddress)
                {
                    var shippingAddress = (from a in context.Addresses
                                             where a.UserId == userId
                                             select a.Id).FirstOrDefault();
                    neworder.ShippingAddressId = shippingAddress;
                }
                else
                {
                    shippingAddressId = Int32.Parse(DropDownListAddress.SelectedValue);
                    neworder.ShippingAddressId = shippingAddressId;
                }
              

                // TODO: check if the user wants to use the home address as billing address or add a new one
                //neworder.BillingAddressId = shippingAddressId;
                
                neworder.Date = DateTime.Now;
                neworder.Status = "Not Approved";
     
                context.Orders.Add(neworder);
                context.SaveChanges();

                var MyCartItems = from i in context.CartItems
                                  where i.UserId == userId
                                  orderby i.ProductId
                                  select i;

                double amount = 0;
                foreach (CartItem i in MyCartItems)
                {
                    amount = amount + (int) i.Quantity * i.Product.Value;
                }

                neworder.Total = amount;
                context.SaveChanges();
                
                RedirectUser(neworder.Id.ToString(), amount.ToString());
         
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
            using (GameverseContext context = new GameverseContext())
            {
                Panel2.Visible = true;
                List<Address> addresses = (from a in context.Addresses orderby a.Id descending select a).ToList();
                DropDownListAddress.DataTextField = "AddressLine1";
                DropDownListAddress.DataValueField = "Id";
                DropDownListAddress.DataSource = addresses;
                DropDownListAddress.DataBind();
            }
        }

        protected void RadioButtonList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RadioButtonList.SelectedItem.Value == "1")
            {
                PanelChooseAddress.Visible = true;
                PanelAddAddress.Visible = false;
                AddressAdded.Visible = false;
                BtnNexToToPayment.Visible = true;
            }
            if (RadioButtonList.SelectedItem.Value == "2")
            {
                PanelAddAddress.Visible = true;
                PanelChooseAddress.Visible = false;
                AddressAdded.Visible = false;
                BtnNexToToPayment.Visible = false;
            }
        }

        protected void ClickSaveAddress(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                using (GameverseContext context = new GameverseContext())
                {
                    Address newaddress = new Address();

                    newaddress.AddressLine1 = TextBoxAddress1.Text;
                    newaddress.AddressLine2 = TextBoxAddress2.Text;
                    newaddress.City = TextBoxCity.Text;
                    newaddress.State = TextBoxState.Text;
                    newaddress.Zipcode = TextBoxZipCode.Text;
                    newaddress.Type = "Other";

                    context.Addresses.Add(newaddress);
                    context.SaveChanges();

                    AddressAdded.Visible = true;
                    Address1.Text = newaddress.AddressLine1;
                    Address2.Text = newaddress.AddressLine2;
                    City.Text = newaddress.City;
                    State.Text = newaddress.State;
                    ZipCode.Text = newaddress.Zipcode;

                    PanelAddAddress.Visible = false;

                    isNewAddress = true;
                    BtnNexToToPayment.Visible = true;
                }
            }
        }
    }
}