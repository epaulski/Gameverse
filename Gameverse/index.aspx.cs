using Gameverse.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gameverse
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadJumbotronGames();
            LoadFeaturedGames();
            LoadPs4Games();
            LoadXboxOneGames();
            LoadWiiUGames();
        }
        
        protected void LoadJumbotronGames()
        {
            try
            {
                using (GameverseContext context = new GameverseContext())
                {
                    var games = (from p in context.Products select p).ToList().GetRange(0,2);
                    var first_game = new List<Product>();
                    first_game.Add(games.First());
                    rptJumboFirst.DataSource = first_game;
                    rptJumboFirst.DataBind();
                    games.RemoveAt(0);
                    rptJumboGames.DataSource = games;
                    rptJumboGames.DataBind();
                }
            }
            catch (Exception)
            {
                //lblMessage.Text = "An error occurred. Please try again.";
            }
        }
        protected void LoadFeaturedGames()
        {
        }
        
        protected void LoadXboxOneGames()
        {
        }
        protected void LoadPs4Games()
        {
        }
        protected void LoadWiiUGames()
        {
        }
        
        protected void InsertData()
        {
            /* TO INSERT DATA IN THE DATABSE (TO RUN ONLY ONCE) */
            /*
            using (GameverseContext context = new GameverseContext())
            {
                //All Kinds of Genres
                Genre genre = context.Genres.Create();
                genre.Name = "Action Adventure";
                context.Genres.Add(genre);

                genre = context.Genres.Create();
                genre.Name = "Fighting";
                context.Genres.Add(genre);

                genre = context.Genres.Create();
                genre.Name = "Racing";
                context.Genres.Add(genre);

                genre = context.Genres.Create();
                genre.Name = "RPG";
                context.Genres.Add(genre);

                genre = context.Genres.Create();
                genre.Name = "Sports";
                context.Genres.Add(genre);

                genre = context.Genres.Create();
                genre.Name = "Family";
                context.Genres.Add(genre);

                context.SaveChanges();
                
                String local_path = "~/Assets/Images/";
                //String root_path = MapPath(local_path);

                // STREET FIGHTER V
                Product product = context.Products.Create();
                product.Name = "Street Fighter V";
                product.Description = "The legendary fighting franchise returns with Street Fighter V! Powered by Unreal Engine 4 technology, stunning visuals depict the next generation of World Warriors in unprecedented detail, while exciting and accessible battle mechanics deliver endless fighting fun that both beginners and veterans can enjoy. Challenge friends online, or compete for fame and glory on the Capcom Pro Tour";
                product.Details = "";
                product.Platform = "Playstation 4";
                product.Value = 59.99;
                product.ImageUrl = local_path + "StreetFighterV.jpg"; //File.ReadAllBytes(root_path + product.Name.Replace(" ", String.Empty) + ".jpg");
                product.ReleaseDate = new DateTime(2016, 02, 16);
                product.Rank = 0;
                product.GenreId = 2;
                context.Products.Add(product);
                context.SaveChanges();
                
                //FAR CRY PRIMAL
                product = context.Products.Create();
                product.Name = "Far Cry Primal";
                product.Description = "Welcome to the Stone Age, a time of extreme danger and limitless adventure, when giant mammoths and sabretooth tigers ruled the Earth, and humanity is at the bottom of the food chain. Learn to craft a deadly arsenal, fend off fierce predators, and outsmart enemy tribes to conquer the land of Oros and become the Apex Predator.";
                product.Details = "";
                product.Platform = "Xbox One";
                product.Value = 59.99;
                product.ImageUrl = local_path + "FarCryPrimal.jpg";
                product.ReleaseDate = new DateTime(2016, 02, 23);
                product.Rank = 0;
                product.GenreId = 1;
                context.Products.Add(product);
                context.SaveChanges();
                
                //Tom Clayncy's The Division
                product = context.Products.Create();
                product.Name = "Tom Clayncy's The Division";
                product.Description = "Tom Clancy’s The Division is a ground-breaking RPG experience that brings the genre into a modern military setting for the first time. In the wake of a devastating pandemic that sweeps through New York City, basic services fail one by one, and without access to food or water, the city quickly descends into chaos. As an agent of The Division, you’ll specialize, modify, and level up your gear, weapons, and skills to take back New York on your own terms. ";
                product.Details = "";
                product.Platform = "Playstation 4";
                product.Value = 59.99;
                String file_name = product.Name.Replace(" ", "");
                product.ImageUrl = local_path + "TomClayncy'sTheDivision.jpg";
                product.ReleaseDate = new DateTime(2016, 03, 8);
                product.Rank = 0;
                product.GenreId = 1;
                context.Products.Add(product);
                context.SaveChanges();
            
                /* HOW TO RETRIEVE THE DATA IMAGES
                var product = (from p in context.Products where p.Id==1 select p).FirstOrDefault();
                if(product != null)
                {
                    String file_name = product.Name.Replace(" ", String.Empty) + ".jpg";
                    File.WriteAllBytes(root_path + file_name, product.Image);
                    imgTest.ImageUrl = local_path + file_name;
                }
            }*/
        }
    }  
}