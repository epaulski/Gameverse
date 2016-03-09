using Gameverse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gameverse.Code
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load()
        {
            if (Request.QueryString["error"] != null)
            {
                panelError.Visible = true;
                lblResults.Text = "You must log in to access that page.";
                panelLogin.Visible = true;
                panelLogout.Visible = false;
            }

            if (Session["LoggedInId"] == null)
            {
                panelLogin.Visible = true;
                panelLogout.Visible = false;
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

                panelLogin.Visible = false;
                panelLogout.Visible = true;
            }
        }

        protected void LogOut(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("login.aspx");            
        }

        protected void Login(object sender, EventArgs e)
        {
            using (GameverseContext context = new GameverseContext())
            {
                string hashedPassword = SecuredPassword.GenerateHash(txtPassword.Text);
                var user = (from u in context.Users
                            where u.Email == txtUserName.Text && u.Password == hashedPassword
                            select u).FirstOrDefault();

                if (user != null)
                {
                    Session["LoggedInId"] = user.Id.ToString();
                    Session["FirstName"] = user.Name.Split(' ')[0];

                    var cartQuantity = (from c in context.CartItems where c.UserId == user.Id select c.Quantity).ToList().Sum();
                    
                    Session["CartQuantity"] = cartQuantity == null ? 0 : cartQuantity;

                    Label lblCartQuantity = (Label)Master.FindControl("lblCartQuantity");
                    lblCartQuantity.Text = (Session["CartQuantity"]).ToString();

                    Response.Redirect("../index.aspx");
                }
                else
                {
                    panelError.Visible = true;
                    lblResults.Text = "User Name or Password are incorrect.";
                }
            }
        }
    }
}