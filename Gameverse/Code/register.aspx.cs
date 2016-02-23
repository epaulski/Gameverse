﻿using Gameverse.Models;
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
                using (GameverseContext context = new GameverseContext())
                {
                    Address user_address = context.Addresses.Create();

                    user_address.FirstName = txtFirstName.Text;
                    user_address.LastName = txtLastName.Text;
                    user_address.AddressLine1 = txtAddress1.Text;
                    user_address.AddressLine2 = txtAddress2.Text;
                    user_address.City = txtCity.Text;
                    user_address.State = ddlState.SelectedValue;
                    user_address.Zipcode = txtZipcode.Text;

                    context.Addresses.Add(user_address);
                    context.SaveChanges();

                    User user = context.Users.Create();
                    user.Email = txtEmail.Text;
                    user.Password = txtPassword.Text;
                    user.Name = txtFirstName.Text + " " + txtLastName.Text;
                    user.EmailOffer = lstEmailOffer.SelectedValue;
                    user.AddressId = user_address.Id;

                    context.Users.Add(user);
                    context.SaveChanges();
                    id = user.Id;
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