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
        int productId;
        int UserID;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["LoggedInId"] != null)
            {
                UserID = int.Parse(Session["LoggedInId"].ToString());

                HyperLink linkSession = (HyperLink)Master.FindControl("linkSession");
                linkSession.Text = "Logout";

                HyperLink linkRegister = (HyperLink)Master.FindControl("linkRegister");
                linkRegister.Text = "Hello, " + Session["FirstName"];
                linkRegister.Enabled = false;

                Label lblCartQuantity = (Label)Master.FindControl("lblCartQuantity");
                lblCartQuantity.Text = (Session["CartQuantity"]).ToString();
            }
            

            if (Request.QueryString["product"] != null)
            {
                productId = Int32.Parse(Request.QueryString["product"].ToString());
                LoadProduct();
            }
            else
            {
                lblMessage.Text = "No Product ID Provided";
                pnlError.Visible = true;
            }
        }

        protected void LoadProduct()
        {
            try
            {
                using (GameverseContext context = new GameverseContext())
                {
                    var game = (from p in context.Products where p.Id == productId select p).FirstOrDefault();
                    if (game != null)
                    {
                        imgCover.ImageUrl = game.ImageUrl;
                        lblName.Text = game.Name;
                        lblPlatform.Text = game.Platform;
                        lblPrice.Text = "$" + game.Value.ToString();
                        lblDescription.Text = game.Description;
                        lblReleaseDate.Text = game.ReleaseDate.ToShortDateString();
                        lblGenre.Text = game.Genre.Name;
                        lblRating.Text = game.Rating.ToString();

                        if (!Page.IsPostBack)
                        {
                            if(game.Quantity == 0)
                            {
                                btnAddToCart.Enabled = false;
                                btnAddToCart.CssClass = "btn btn-default";
                                btnAddToCart.Text = "Not Available";
                            }
                            else
                            {
                                for (int i = 1; i <= game.Quantity; i++)
                                {
                                    ListItem item = new ListItem();
                                    item.Text = i.ToString();
                                    drpQuantity.Items.Add(item);
                                }
                            }               
                        }
                        pnlSuccess.Visible = true;
                    }
                    else
                    {
                        lblMessage.Text = "Sorry, that product doesn't exist.";
                        pnlError.Visible = true;
                    }
                }
            }
            catch (Exception){ }
        }

        protected void btnAddToCart_Click(object sender, EventArgs e)
        {

            if (Session["LoggedInId"] == null)
            {
                Response.Redirect("Login.aspx?error=1");
            }
            try
            {
                using (GameverseContext context = new GameverseContext())
                {
                    int quantity = Int32.Parse(drpQuantity.Text);

                    var oldCartItem = (from c in context.CartItems where c.ProductId == productId select c).FirstOrDefault();
                    
                    if(oldCartItem != null)
                    {
                        oldCartItem.Quantity = Math.Min(oldCartItem.Product.Quantity, (int)oldCartItem.Quantity + quantity); ;
                    }
                    else
                    {
                        CartItem newitem = new CartItem();

                        newitem.ProductId = productId;
                        newitem.Quantity = quantity;
                        newitem.UserId = UserID;

                        context.CartItems.Add(newitem);
                    }       
                    context.SaveChanges();

                    Session["CartQuantity"] = (int)Session["CartQuantity"] + quantity;

                    Response.Redirect("myCart.aspx");
                }
            }
            catch (Exception) { }            
        }
    }
}