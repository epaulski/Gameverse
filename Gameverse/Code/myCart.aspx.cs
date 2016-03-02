﻿using Gameverse.Models;
using System;
using System.Collections.Generic;
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
                    cell.Text = i.Product.Name;
                    row.Cells.Add(cell);

                    cell = new TableCell();
                    cell.Text = i.Quantity.ToString();
                    row.Cells.Add(cell);

                    cell = new TableCell();
                    Button link = new Button();
                    link.Text = "Remove";
                    link.Click +=
                         new EventHandler((s, e) => removeClick(s, e, i.Id));
                    cell.Controls.Add(link);
                    row.Cells.Add(cell);

                    TableCart.Rows.Add(row);
                }
            }
        }

        private void removeClick(object s, EventArgs e, int item)
        {//not today
        }
    }
}