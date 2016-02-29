using Gameverse.Models;
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
        private int UserID;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["LoggedInId"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else if (!IsPostBack)
            {
                Session["update"] = Server.UrlEncode(System.DateTime.Now.ToString());
            }

            UserID = int.Parse(Session["LoggedInId"].ToString());

            LoadCart();
        }

        protected void LoadCart()
        {
            using (GameverseContext context = new GameverseContext())
            {
                var MyCartItems = from i in context.CartItems
                                  where i.UserId == UserID
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

                    TableCart.Rows.Add(row);

                }
            }
        }
    }
}