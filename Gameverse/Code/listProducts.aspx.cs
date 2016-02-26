using Gameverse.Models;
using System;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gameverse.Code
{
    public partial class listProducts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String filter = "";
            if (Request.QueryString["filter"] != null)
            {
               filter = Request.QueryString["filter"].ToString();
            }
            LoadProducts(filter);
        }
        protected void LoadProducts(String filter)
        {
            try
            {
                using (GameverseContext context = new GameverseContext())
                {
                    List<Product> games = (from p in context.Products orderby p.ReleaseDate descending select p).ToList();
                    switch (filter)
                    {
                        case "Ps4":
                            games = (from p in context.Products where p.Platform == "Playstation 4" select p).ToList();
                            break;
                        case "XboxOne":
                            games = (from p in context.Products where p.Platform == "Xbox One" select p).ToList();
                            break;
                        case "WiiU":
                            games = (from p in context.Products where p.Platform == "Nintendo Wii U" select p).ToList();
                            break;
                        case "Featured":
                            games = (from p in context.Products orderby p.Rating descending select p).ToList().GetRange(0,6);
                            break;
                        case "NewReleases":
                            games = (from p in context.Products orderby p.ReleaseDate descending select p).ToList().GetRange(0,6);
                            break;
                        default:
                            break;
                    }

                    rptListProducts.DataSource = games;
                    rptListProducts.DataBind();
                }
            }
            catch (Exception)
            { }
        }
    }
}