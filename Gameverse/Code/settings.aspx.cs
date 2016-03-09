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
        int userId;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["LoggedInId"] == null)
            {
                Response.Redirect("login.aspx?error=1");
            }
            else
            {
                HyperLink linkSession = (HyperLink)Master.FindControl("linkSession");
                linkSession.Text = "Logout";

                HyperLink linkRegister = (HyperLink)Master.FindControl("linkRegister");
                linkRegister.Text = "Hello, " + Session["FirstName"];
                linkRegister.Enabled = false;

                Label lblCartQuantity = (Label)Master.FindControl("lblCartQuantity");
                lblCartQuantity.Text = (Session["CartQuantity"]).ToString();

                userId = int.Parse(Session["LoggedInId"].ToString());

                using (GameverseContext context = new GameverseContext())
                {
                    var user = (from u in context.Users where u.Id == userId select u).FirstOrDefault();

                    if(user != null)
                    {
                        lblname.Text = user.Name;
                        lbluseremail.Text = user.Email;
                        lblemailoffer.Text = user.EmailOffer;

                        var user_address = (from a in context.Addresses where a.UserId == userId && a.Type == "Home" select a).FirstOrDefault();

                        if (user_address != null)
                        {
                            lbluseraddress1.Text = user_address.AddressLine1;
                            lbluseraddress2.Text = user_address.AddressLine2;
                            lblusercity.Text = user_address.City;
                            lbluserstate.Text = user_address.State;
                            lbluserzipcode.Text = user_address.Zipcode;
                        }
                    }
                }
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                userId = int.Parse(Session["LoggedInId"].ToString());
                
                using (GameverseContext context = new GameverseContext())
                {
                    var user = (from u in context.Users where u.Id == userId select u).FirstOrDefault();

                    if (user != null)
                    {
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

                        var user_address = (from a in context.Addresses where a.UserId == userId && a.Type == "Home" select a).FirstOrDefault();

                        if (user_address != null)
                        {
                            if (txtAddress1.Text != String.Empty)
                            {
                                user_address.AddressLine1 = txtAddress1.Text;
                            }
                            if (txtAddress2.Text != String.Empty)
                            {
                                user_address.AddressLine2 = txtAddress2.Text;
                            }
                            if (ddlState.SelectedValue != "")
                            {
                                user_address.State = ddlState.SelectedValue;
                            }
                            if (txtCity.Text != String.Empty)
                            {
                                user_address.City = txtCity.Text;
                            }
                            if (txtZipcode.Text != String.Empty)
                            {
                                user_address.Zipcode = txtZipcode.Text;
                            }
                            context.SaveChanges();

                            Response.Redirect("settings.aspx");
                        }
                        else
                        {
                            lblResults.Text = "Error - Changes have not been saved.";
                            pnlError.Visible = true;
                        }    
                    }
                    else
                    {
                        lblResults.Text = "Error - Changes have not been saved.";
                        pnlError.Visible = true;
                    }
                }
            }
        }
    }
}