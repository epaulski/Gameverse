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
            if (Session["LoggedInId"] == null)
            {
                panelLogin.Visible = true;
                panelLogout.Visible = false;
            }
            else
            {
                panelLogin.Visible = false;
                panelLogout.Visible = true;
            }

            if (Request.QueryString["error"] != null)
            {
                panelError.Visible = true;
                lblResults.Text = "You must log in to access that page.";
                panelLogin.Visible = true;
                panelLogout.Visible = false;
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
                var user = (from u in context.Users
                            where u.Email == txtUserName.Text && u.Password == txtPassword.Text
                            select u).FirstOrDefault();

                if (user != null)
                {
                    Session["LoggedInId"] = user.Id.ToString();

                    Response.Redirect("settings.aspx");
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