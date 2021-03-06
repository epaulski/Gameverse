﻿using Gameverse.Models;
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
            if(Session["LoggedInId"] != null)
            {
                HyperLink linkSession = (HyperLink)Master.FindControl("linkSession");
                linkSession.Text = "Logout";

                HyperLink linkRegister = (HyperLink)Master.FindControl("linkRegister");
                linkRegister.Text = "Hello, " + Session["FirstName"];
                linkRegister.Enabled = false;

                Label lblCartQuantity = (Label)Master.FindControl("lblCartQuantity");
                lblCartQuantity.Text = (Session["CartQuantity"]).ToString();
            }
        
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
                        case "Featured":
                            games = (from p in context.Products orderby p.Rating descending select p).ToList().GetRange(0,6);
                            break;

                        case "NewReleases":
                            games = (from p in context.Products orderby p.ReleaseDate descending select p).ToList().GetRange(0,6);
                            break;

                        default:
                            filter = filter.ToLower();
                            games = (from p in context.Products where p.Name.Contains(filter) 
                                     || p.Platform.Contains(filter) || p.Genre.Name.Contains(filter) 
                                     select p).ToList();
                            break;
                    }
                    
                    if(games.Count() == 0)
                    {
                        lblSearchKey.Text = "'"+ filter + "'";
                        Panel2.Visible = true;
                    }
                    else
                    {
                        rptListProducts.DataSource = games;
                        rptListProducts.DataBind();
                        Panel1.Visible = true;
                    }                    
                }
            }
            catch (Exception)
            { }
        }
    }
}