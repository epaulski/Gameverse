using Gameverse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gameverse.Code
{
    public partial class viewProduct : System.Web.UI.Page
    {
        string pid;
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

            if (Request.QueryString["product"] != null)
            {
                int id = Int32.Parse(Request.QueryString["product"].ToString());
                LoadProduct(id);
            }
            else
            {
                //lblMessage.Text = "No User ID Provided";
            }

            UserID = int.Parse(Session["LoggedInId"].ToString());
            pid = Request.QueryString["product"];
        }

        protected void LoadProduct(int id)
        {
            try
            {
                using (GameverseContext context = new GameverseContext())
                {
                    var game = (from p in context.Products where p.Id == id select p).FirstOrDefault();
                    if (game != null)
                    {
                        imgCover.ImageUrl = game.ImageUrl;
                        lblName.Text = game.Name;
                        lblPlatform.Text = game.Platform;
                        lblPrice.Text = game.Value.ToString();
                        lblDescription.Text = game.Description;
                        lblReleaseDate.Text = game.ReleaseDate.ToShortDateString();
                        lblGenre.Text = game.Genre.Name;
                        lblRating.Text = game.Rating.ToString();

                        if (!Page.IsPostBack)
                        {
                            for (int i = 1; i <= game.Quantity; i++)
                            {
                                ListItem item = new ListItem();
                                item.Text = i.ToString();
                                drpQuantity.Items.Add(item);
                            }
                        }                      
                    }
                    else
                    {
                        // message
                    }
                }
            }
            catch (Exception)
            { }
        }

        protected void btnAddToCart_Click(object sender, EventArgs e)
        {
            using (GameverseContext context = new GameverseContext())
            {
                int productId = Int32.Parse(pid);
                int quant = Int32.Parse(drpQuantity.Text);

                CartItem newitem = new CartItem();

                newitem.ProductId = productId;
                newitem.Quantity = quant;
                newitem.UserId = UserID;

                if (newitem != null)
                {
                    context.CartItems.Add(newitem);
                    context.SaveChanges();
                    Response.Redirect("myCart.aspx");
                }
                else
                {
                    Message.Text = "Sorry, the item can't be added.";
                }
            }
        }
    }
}