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
        int userId;
        Address newAddress;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["LoggedInId"] == null)
            {
                Response.Redirect("login.aspx?error=1");
            }

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
                Response.Redirect("login.aspx?error=1");
            }

            using (GameverseContext context = new GameverseContext())
            {
                // Build new Order entry
                var neworder = new Order();
                neworder.UserId = userId;
                neworder.Date = DateTime.Now;
                neworder.Status = "Not Approved";
                
                PanelAddAddress.Visible = false;
                BtnNexToToPayment.Visible = true;

                // Get the new Address value, if it exists
                if (Session["newAddress"] != null)
                    newAddress = (Address)Session["newAddress"];

                // If the address is new, ship to the last address added
                // If not, get the value from the dropdownlist
                if (newAddress != null)
                {
                    context.Addresses.Add(this.newAddress);
                    context.SaveChanges();
                    neworder.ShippingAddressId = this.newAddress.Id;
                }
                else
                {
                    neworder.ShippingAddressId = Int32.Parse(DropDownListAddress.SelectedItem.Value);
                }

                var MyCartItems = from i in context.CartItems
                                  where i.UserId == userId
                                  orderby i.ProductId
                                  select i;

                double amount = 0;
                foreach (CartItem i in MyCartItems)
                {
                    amount = amount + (int)i.Quantity * i.Product.Value;
                }

                neworder.Total = amount;

                context.Orders.Add(neworder);
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
                List<Address> addresses = (from a in context.Addresses orderby a.Id descending where a.UserId == userId select a).ToList();
                for (int i = 0; i < addresses.Count(); i++)
                {
                    ListItem item = new ListItem();
                    item.Text = addresses[i].Type + " - " + addresses[i].AddressLine1 + ", " + addresses[i].AddressLine2;
                    item.Value = addresses[i].Id.ToString();
                    DropDownListAddress.Items.Add(item);
                }
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
            else if (RadioButtonList.SelectedItem.Value == "2")
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
                newAddress = new Address();

                newAddress.AddressLine1 = TextBoxAddress1.Text;
                newAddress.AddressLine2 = TextBoxAddress2.Text;
                newAddress.City = TextBoxCity.Text;
                newAddress.State = TextBoxState.Text;
                newAddress.Zipcode = TextBoxZipCode.Text;
                newAddress.Type = TextBoxType.Text;
                newAddress.UserId = userId;

                AddressAdded.Visible = true;

                Type.Text = newAddress.Type;
                Address1.Text = newAddress.AddressLine1;
                Address2.Text = newAddress.AddressLine2;
                City.Text = newAddress.City;
                State.Text = newAddress.State;
                ZipCode.Text = newAddress.Zipcode;

                // Session to keep the value
                Session["newAddress"] = newAddress;

                PanelAddAddress.Visible = false;
                BtnNexToToPayment.Visible = true;                
            }
        }
    }
}