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
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["product"] != null)
            {
                int id = Int32.Parse(Request.QueryString["product"].ToString());
                LoadProduct(id);
            }
            else
            {
                //lblMessage.Text = "No User ID Provided";
            }
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
    }
}