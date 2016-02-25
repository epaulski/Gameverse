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
            LoadNewReleases();
            LoadFeaturedGames();
            LoadPs4Games();
            LoadXboxOneGames();
            LoadWiiUGames();
            
            //InsertData();
        }

        protected void LoadJumbotronGames()
        {
            try
            {
                using (GameverseContext context = new GameverseContext())
                {
                    var games = (from p in context.Products select p).ToList().GetRange(0,3);
                    var first_game = new List<Product>();
                    first_game.Add(games.First());
                    rptJumboFirst.DataSource = first_game;
                    rptJumboFirst.DataBind();
                    
                    rptJumboGames.DataSource = games.GetRange(1,2);
                    rptJumboGames.DataBind();
                }
            }
            catch (Exception)
            {}
        }
        private void LoadNewReleases()
        {
            try
            {
                using (GameverseContext context = new GameverseContext())
                {
                    var games = (from p in context.Products orderby p.ReleaseDate descending select p).ToList().GetRange(0, 6);
                    rptNewReleasesFirst.DataSource = games.GetRange(0, 3);
                    rptNewReleasesFirst.DataBind();
                    rptNewReleasesSecond.DataSource = games.GetRange(3, (games.Count - 3));
                    rptNewReleasesSecond.DataBind();
                }
            }
            catch (Exception)
            {}
        }

        protected void LoadFeaturedGames()
        {
            try
            {
                using (GameverseContext context = new GameverseContext())
                {
                    var games = (from p in context.Products orderby p.Rating descending select p).ToList().GetRange(0,6);
                    rptFeaturedFirst.DataSource = games.GetRange(0, 3);
                    rptFeaturedFirst.DataBind();
                    rptFeaturedSecond.DataSource = games.GetRange(3, (games.Count - 3));
                    rptFeaturedSecond.DataBind();
                }
            }
            catch (Exception)
            {}
        }
              
        protected void LoadXboxOneGames()
        {
            try
            {
                using (GameverseContext context = new GameverseContext())
                {
                    var games = (from p in context.Products where p.Platform == "Xbox One" select p).ToList();
                    rptXboxOneFirst.DataSource = games.GetRange(0, 3);
                    rptXboxOneFirst.DataBind();
                    rptXboxOneSecond.DataSource = games.GetRange(3, (games.Count - 3));
                    rptXboxOneSecond.DataBind();
                }
            }
            catch (Exception)
            {}
        }
        protected void LoadPs4Games()
        {
            try
            {
                using (GameverseContext context = new GameverseContext())
                {
                    var games = (from p in context.Products where p.Platform == "Playstation 4" select p).ToList();
                    rptPs4First.DataSource = games.GetRange(0, 3);
                    rptPs4First.DataBind();
                    rptPs4Second.DataSource = games.GetRange(3, (games.Count-3));
                    rptPs4Second.DataBind();
                }
            }
            catch (Exception)
            {}
        }
        protected void LoadWiiUGames()
        {
            try
            {
                using (GameverseContext context = new GameverseContext())
                {
                    var games = (from p in context.Products where p.Platform == "Nintendo Wii U" select p).ToList();
                    rptWiiUFirst.DataSource = games.GetRange(0, 3);
                    rptWiiUFirst.DataBind();
                    rptWiiUSecond.DataSource = games.GetRange(3, (games.Count-3));
                    rptWiiUSecond.DataBind();
                }
            }
            catch (Exception)
            {}
        }

        protected void InsertData()
        {
            /* TO INSERT DATA IN THE DATABSE (TO RUN ONLY ONCE) */
            using (GameverseContext context = new GameverseContext())
            {
                String local_path = "/Assets/Images/";
                Product product;
                /*
                // All Kinds of Genres
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
                
                // STREET FIGHTER V
                product = context.Products.Create();
                product.Name = "Street Fighter V";
                product.Description = "The legendary fighting franchise returns with Street Fighter V! Powered by Unreal Engine 4 technology, stunning visuals depict the next generation of World Warriors in unprecedented detail, while exciting and accessible battle mechanics deliver endless fighting fun that both beginners and veterans can enjoy. Challenge friends online, or compete for fame and glory on the Capcom Pro Tour";
                product.Details = "";
                product.Platform = "Playstation 4";
                product.Value = 59.99;
                product.ImageUrl = local_path + "StreetFighterV.jpg"; //File.ReadAllBytes(root_path + product.Name.Replace(" ", String.Empty) + ".jpg");
                product.ReleaseDate = new DateTime(2016, 02, 16);
                product.Rating = 7;
                product.GenreId = 2;
                context.Products.Add(product);
                context.SaveChanges();
                
                // FAR CRY PRIMAL
                product = context.Products.Create();
                product.Name = "Far Cry Primal";
                product.Description = "Welcome to the Stone Age, a time of extreme danger and limitless adventure, when giant mammoths and sabretooth tigers ruled the Earth, and humanity is at the bottom of the food chain. Learn to craft a deadly arsenal, fend off fierce predators, and outsmart enemy tribes to conquer the land of Oros and become the Apex Predator.";
                product.Details = "";
                product.Platform = "Xbox One";
                product.Value = 59.99;
                product.ImageUrl = local_path + "FarCryPrimal.jpg";
                product.ReleaseDate = new DateTime(2016, 02, 23);
                product.Rating = 8.3;
                product.GenreId = 1;
                context.Products.Add(product);
                context.SaveChanges();
                
                // Tom Clayncy's The Division
                product = context.Products.Create();
                product.Name = "Tom Clayncy's The Division";
                product.Description = "Tom Clancy’s The Division is a ground-breaking RPG experience that brings the genre into a modern military setting for the first time. In the wake of a devastating pandemic that sweeps through New York City, basic services fail one by one, and without access to food or water, the city quickly descends into chaos. As an agent of The Division, you’ll specialize, modify, and level up your gear, weapons, and skills to take back New York on your own terms. ";
                product.Details = "";
                product.Platform = "Playstation 4";
                product.Value = 59.99;
                product.ImageUrl = local_path + "TomClayncy'sTheDivision.jpg";
                product.ReleaseDate = new DateTime(2016, 03, 8);
                product.Rating = 8;
                product.GenreId = 1;
                context.Products.Add(product);
                context.SaveChanges();

                // Yoshi's Woolly World
                product = context.Products.Create();
                product.Name = "Yoshi's Woolly World";
                product.Description = "Set off with a friend* through a woolly world in this grand Yoshi™ adventure! Kamek, that mischievous magic-maker, has turned the Yoshi clan into wool! Now it’s up to you to explore a treasure trove of clever handicraft stages and unravel their secrets to save your fellow Yoshis.";
                product.Details = "";
                product.Platform = "Nintendo Wii U";
                product.Value = 49.99;
                product.ImageUrl = local_path + "Yoshi'sWoollyWorld.jpg";
                product.ReleaseDate = new DateTime(2015, 10, 16);
                product.Rating = 8.3;
                product.GenreId = 6;
                context.Products.Add(product);
                context.SaveChanges();

                //Mario Kart 8
                product = context.Products.Create();
                product.Name = "Mario Kart 8";
                product.Description = "Driving up a waterfall or across the ceiling can provide an intense adrenaline rush, but that’s not all anti-gravity is good for. It also provides a wild new gameplay mechanic: if you collide into other racers in zero-g, you’ll earn speed boosts worth bragging about. Luckily, you can upload and share your best moments and watch your friends’ using the all-new Mario Kart TV.* Returning features include 12-player online play*, gliders, underwater racing, motorbikes, and custom karts.";
                product.Details = "";
                product.Platform = "Nintendo Wii U";
                product.Value = 29.99;
                product.ImageUrl = local_path + "MarioKart8.jpg";
                product.ReleaseDate = new DateTime(2014, 5, 30);
                product.Rating = 8.6;
                product.GenreId = 3;
                context.Products.Add(product);
                context.SaveChanges();

                // Super Smash Bros
                product = context.Products.Create();
                product.Name = "Super Smash Bros";
                product.Description = "Get ready to play with all your favorite Nintendo characters again with the Super Smash Bros (Nintendo Wii U). No matter who this game is for, there are characters here that everyone loves. Link, Mario, Samus, Pikachu and more get together for some WII games that will blow your mind. This action packed game takes your characters and turns them into warriors heading into battle. Classic video games are the inspiration for what happens in this game, giving you a new war to wage yet familiar territory and characters to do it with. ";
                product.Details = "";
                product.Platform = "Nintendo Wii U";
                product.Value = 49.99;
                product.ImageUrl = local_path + "SuperSmashBros.jpg";
                product.ReleaseDate = new DateTime(2014, 11, 21);
                product.Rating = 8.8;
                product.GenreId = 2;
                context.Products.Add(product);
                context.SaveChanges();

                // Star Wars Battlefront
                product = context.Products.Create();
                product.Name = "Star Wars Battlefront";
                product.Description = " Lightsabers? Check. Jedis? Check. Millennium Falcon? Why not. It's Star Wars, of course, taking you to galaxies far, far away and onto the battlefront. Choose to be a member of the Rebel Alliance or the Empire as you battle your way across planets like Hoth, Endor, and Tatooine. Pilot speeder bikes in the air, X-wings out in space, or giant AT-ATs on the ground. Play as Darth Vader, Boba Fett, or other iconic characters in the Star Wars universe. With multiplayer matches for up to 40 players and online co-op, this is the massive Star Wars game you've been waiting for. So go ahead, reawaken the force inside you!";
                product.Details = "";
                product.Platform = "Playstation 4";
                product.Value = 39.99;
                product.ImageUrl = local_path + "StarWarsBattlefront.jpg";
                product.ReleaseDate = new DateTime(2014, 11, 21);
                product.Rating = 6;
                product.GenreId = 5;
                context.Products.Add(product);
                context.SaveChanges();

                // Splatoon
                product = context.Products.Create();
                product.Name = "Splatoon";
                product.Description = "Splatter enemies and claim your turf as the ink-spewing, squid-like characters called Inklings in Nintendo's new third-person action shooter game for the Wii U console. Challenge your friends in chaotic four-on-four matches, in which the goal is to get your ink on as many places as possible and claim your turf, all while strategically submerging yourself in your team's colors and blasting your enemies. This is a colorful and chaotic online third-person action shooter ";
                product.Details = "";
                product.Platform = "Nintendo Wii U";
                product.Value = 59.99;
                product.ImageUrl = local_path + "Splatoon.jpg";
                product.ReleaseDate = new DateTime(2015, 05, 29);
                product.Rating = 8;
                product.GenreId = 5;
                context.Products.Add(product);
                context.SaveChanges();

                // Fallout 4
                product = context.Products.Create();
                product.Name = "Fallout 4";
                product.Description = "This is the RPG you've been waiting for. Set in a vast open world destroyed by nuclear war, Fallout 4 features countless quests, a wide variety of game choices, extensive character customization, fast-paced combat, and an epic story. Plus, current-gen console power makes it the best-looking and smoothest-playing Fallout game ever. Set 200 years after the bombs fell in Boston, you are the sole survivor of Vault 111. With the aid of your trusty Pip-Boy wearable computer, you'll face the dangers of the endless wasteland.";
                product.Details = "";
                product.Platform = "Xbox One";
                product.Value = 49.99;
                product.ImageUrl = local_path + "Fallout4.jpg";
                product.ReleaseDate = new DateTime(2015, 11, 9);
                product.Rating = 9;
                product.GenreId = 4;
                context.Products.Add(product);
                context.SaveChanges();

                // The Witcher: 3 Wild Hunt
                product = context.Products.Create();
                product.Name = "The Witcher: 3 Wild Hunt";
                product.Description = "Playing The Witcher: Wild Hunt is like traveling to a different, more awesome universe. The setting is immersive, the characters are fully drawn, and the details are perfect - you'll lose yourself for days in this action-RPG's intricately crafted world of magic and combat. The game world is 30 times larger than in previous Witcher titles, so it's huge. You can fight on horseback or at sea, swim underwater, and use a crossbow - these mechanics and abilities are new to the Witcher world. Wild Hunt concludes the story of the witcher Geralt of Rivia, the protagonist from previous Witcher games.";
                product.Details = "";
                product.Platform = "Xbox One";
                product.Value = 39.99;
                product.ImageUrl = local_path + "TheWitcher3WildHunt.jpg";
                product.ReleaseDate = new DateTime(2015, 5, 18);
                product.Rating = 9.6;
                product.GenreId = 4;
                context.Products.Add(product);
                context.SaveChanges();

                // LEGO: Marvel's Avengers
                product = context.Products.Create();
                product.Name = "LEGO: Marvel's Avengers";
                product.Description = "This colorful action game features all your favorite Marvel heroes in LEGO form! There are over 100 characters to unlock and play as, including favorites like the Hulk, Iron Man, Captain America, and Thor, plus new characters from Avengers: Age of Ultron and more. Featuring storylines from both The Avengers and Age of Ultron movies, LEGO: Marvel's Avengers offers open-world gameplay, tons of crazy action, and the patented LEGO comedy that fans of the series crave. You can freely roam all over the huge game world, visiting iconic Marvel locations, stacking bricks, collecting studs, and saving the day.";
                product.Details = "";
                product.Platform = "Xbox One";
                product.Value = 59.99;
                product.ImageUrl = local_path + "LEGOMarvel'sAvengers.jpg";
                product.ReleaseDate = new DateTime(2015, 5, 18);
                product.Rating = 7.7;
                product.GenreId = 4;
                context.Products.Add(product);
                context.SaveChanges();

                // Forza Motorsport 6
                product = context.Products.Create();
                product.Name = "Forza Motorsport 6";
                product.Description = "The latest version of Forza promises to be the most beautiful and comprehensive racing game of this generation. It features more than 450 carefully re-created cars, all fully customizable with detailed, accurate cockpit views and full damage. Forza Motorsport 6 features 26 world-famous racing locales like Daytona and Le Mans, all presented in 1080p resolution at 60 frames per second. Whether you like 2-player split-screen racing, 24-player online races, or realistic AI opponents, the ForzaTech engine will deliver realistic physics at simulation speeds.";
                product.Details = "";
                product.Platform = "Xbox One";
                product.Value = 39.99;
                product.ImageUrl = local_path + "ForzaMotorsport6.jpg";
                product.ReleaseDate = new DateTime(2015, 9, 14);
                product.Rating = 8.5;
                product.GenreId = 3;
                context.Products.Add(product);
                context.SaveChanges();

                //Call of Duty: Black Ops III
                product = context.Products.Create();
                product.Name = "Call of Duty: Black Ops III";
                product.Description = "The battle rages on, so you better bring your A-Game. Call of Duty: Black Ops returns and it's bigger, badder, and bolder than ever. Step onto the battlefield with a new breed of biotech-enhanced soldier. Multiplayer brings the heat with the chance to play cooperatively on the PS4 with up to four players online. A new chain-based fluid movement system will allow players to thrust jump, slide, and make wall-runs through the environment. For more added fun, the new Specialist character system allows players to choose from an elite group of Black Ops soldiers and master each character's unique set of skills and abilities. And of course, who can forget the zombies.";
                product.Details = "";
                product.Platform = "Playstation 4";
                product.Value = 44.99;
                product.ImageUrl = local_path + "CallOfDutyBlackOpsIII.jpg";
                product.ReleaseDate = new DateTime(2015, 11, 5);
                product.Rating = 6.5;
                product.GenreId = 5;
                context.Products.Add(product);
                context.SaveChanges();
                */
            }
        }
    }  
}