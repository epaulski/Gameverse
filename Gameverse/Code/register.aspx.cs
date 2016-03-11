using Gameverse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gameverse
{
    public partial class register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                using (GameverseContext context = new GameverseContext())
                {
                    var existingUsers = (from u in context.Users where u.Email == txtEmail.Text select u).FirstOrDefault();

                    if (existingUsers == null)
                    {
                        User user = context.Users.Create();
                        user.Email = txtEmail.Text;
                        user.Password = SecuredPassword.GenerateHash(txtPassword.Text);
                        user.Name = txtFirstName.Text + " " + txtLastName.Text;
                        user.EmailOffer = lstEmailOffer.SelectedValue;

                        context.Users.Add(user);
                        context.SaveChanges();

                        Address user_address = context.Addresses.Create();
                        user_address.AddressLine1 = txtAddress1.Text;
                        user_address.AddressLine2 = txtAddress2.Text;
                        user_address.City = txtCity.Text;
                        user_address.State = ddlState.SelectedValue;
                        user_address.Zipcode = txtZipcode.Text;
                        user_address.Type = "Home";
                        user_address.UserId = user.Id;

                        context.Addresses.Add(user_address);
                        context.SaveChanges();

                        lblMessage.Text = "Registration summary:";
                        lblID.Text = "Member ID: " + user.Id;
                        lblUserFirstName.Text = "First name: " + txtFirstName.Text;
                        lblUserLastName.Text = "Last name: " + txtLastName.Text;
                        lblUserAddress1.Text = "Address 1: " + txtAddress1.Text;
                        lblUserAddress2.Text = "Address 2: " + txtAddress2.Text;
                        lblUserCity.Text = "City: " + txtCity.Text;
                        lblUserState.Text = "State: " + ddlState.SelectedValue;
                        lblUserZipcode.Text = "Zipcode: " + txtZipcode.Text;
                        lblUserEmail.Text = "Email: " + txtEmail.Text;
                        lblUserEmailOffer.Text = "Subscribed?: " + lstEmailOffer.SelectedValue;
                        pnlEditing.Visible = false;
                        pnlSummary.Visible = true;
                        panelError.Visible = false;

                        Session["LoggedInId"] = user.Id.ToString();
                        Session["FirstName"] = user.Name.Split(' ')[0];
                        Session["CartQuantity"] = 0;

                        HyperLink linkSession = (HyperLink)Master.FindControl("linkSession");
                        linkSession.Text = "Logout";

                        HyperLink linkRegister = (HyperLink)Master.FindControl("linkRegister");
                        linkRegister.Text = "Hello, " + Session["FirstName"];
                        linkRegister.Enabled = false;
                    }
                    else
                    {
                        lblResults.Text = "Email already registered. Please use a different email or log in.";
                        panelError.Visible = true;
                    }
                }               
            }
        }
    }
}