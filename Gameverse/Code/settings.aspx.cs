using Gameverse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gameverse.Code
{
    public partial class settings : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["LoggedInId"] == null)
            {
                Response.Redirect("login.aspx?error=1");
            }
            else
            {
                var currentId = int.Parse(Session["LoggedInId"].ToString());

                using (GameverseContext context = new GameverseContext())
                {
                    var user = (from u in context.Users where u.Id == currentId select u).FirstOrDefault();

                    lblname.Text = user.Name;
                    lbluseraddress1.Text = user.Address.AddressLine1;
                    lbluseraddress2.Text = user.Address.AddressLine2;
                    lblusercity.Text = user.Address.City;
                    lbluserstate.Text = user.Address.State;
                    lbluserzipcode.Text = user.Address.Zipcode;
                    lbluseremail.Text = user.Email;
                    lblemailoffer.Text = user.EmailOffer;
                }
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                var currentId = int.Parse(Session["LoggedInId"].ToString());

                using (GameverseContext context = new GameverseContext())
                {
                    var user = (from u in context.Users where u.Id == currentId select u).FirstOrDefault();
                    if (txtAddress1.Text != String.Empty)
                    {
                        user.Address.AddressLine1 = txtAddress1.Text;
                    }
                    if (txtAddress2.Text != String.Empty)
                    {
                        user.Address.AddressLine2 = txtAddress2.Text;
                    }
                    if (ddlState.SelectedValue != "")
                    {
                        user.Address.State = ddlState.SelectedValue;
                    }
                    if (txtCity.Text != String.Empty)
                    {
                        user.Address.City = txtCity.Text;
                    }
                    if (txtZipcode.Text != String.Empty)
                    {
                        user.Address.Zipcode = txtZipcode.Text;
                    }
                    if (txtEmail.Text != String.Empty)
                    {
                        user.Email = txtEmail.Text;
                    }
                    if (txtPassword2.Text != String.Empty)
                    {
                        user.Password = txtPassword2.Text;
                    }
                    if (lstEmailOffer.SelectedValue != "NoChange")
                    {
                        user.EmailOffer = lstEmailOffer.SelectedValue;
                    }
                    context.SaveChanges();
                }
                Response.Redirect("settings.aspx");
            }
        }
    }
}