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
                int id = 0;
                using (RegistrationContext context = new RegistrationContext())
                {
                    Registration myReg = context.Registrations.Create();
                    myReg.FirstName = txtFirstName.Text;
                    myReg.LastName = txtLastName.Text;
                    myReg.Address1 = txtAddress1.Text;
                    myReg.Address2 = txtAddress2.Text;
                    myReg.City = txtCity.Text;
                    myReg.State = ddlState.SelectedValue;
                    myReg.Zipcode = txtZipcode.Text;
                    myReg.Email = txtEmail.Text;
                    myReg.EmailOffer = lstEmailOffer.SelectedValue;
                    context.Registrations.Add(myReg);
                    context.SaveChanges();
                    id = myReg.Id;
                }


                lblMessage.Text = "Registration summary:";
                lblID.Text = "Member ID: " + id;
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
            }

        }
    }
}