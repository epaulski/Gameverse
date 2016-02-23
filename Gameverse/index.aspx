<%@ Page Title="Gameverse | Home" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Gameverse.index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="mainContentPlaceHolder" runat="server">
    <br/>
    <!-- START JUMBOTRON -->
    <div class="jumbotron">
        <div class="slideshow">
            <div id="carAdvertisementGames"class="carousel slide" data-ride="carousel" data-interval="4000">
                <div class="carousel-inner">
                    <div class="item active">
                        <div class="row">
                            <div class="col-lg-4">
                                <a href="#"><img height="300" src="Assets/Images/TomClayncysTheDivision.jpg"/></a>
                            </div>
                            <div class="col-lg-8">
                                <h2>Tom Clayncy's The Division</h2>
                                <h4>Playstation 4 & Xbox One</h4>
                                <h3>$59.99</h3>
                                <a href="#"> See Details</a>
                            </div>
                        </div>
                    </div>
                    <div class="item">
                        <div class="row">
                            <div class="col-lg-4">
                                <img height="300" src="Assets/Images/StreetFighterV.jpg"/>
                            </div>
                            <div class="col-lg-8">
                                <h2>Street Fighterer V</h2>
                                <h4>Playstation 4</h4>
                                <h3>$59.99</h3>
                                <a href="#"> See Details</a>
                            </div>
                        </div>
                    </div>
                    <div class="item">
                        <div class="row">
                            <div class="col-lg-4">
                                <img height="300" src="Assets/Images/FarCryPrimal.jpg"/>
                            </div>
                            <div class="col-lg-8">
                                <h2>Far Cry Primal</h2>
                                <h4>Playstation4 & Xbox One</h4>
                                <h3>$59.99</h3>
                                <a href="#"> See Details</a>
                            </div>
                        </div>
                    </div>
                </div>
                <ol class="carousel-indicators">
                    <li data-target="#carAdvertisementGames" data-slide-to="0" class="active"></li>
                    <li data-target="#carAdvertisementGames" data-slide-to="1"></li>
                    <li data-target="#carAdvertisementGames" data-slide-to="2"></li>
                </ol>
                <!--<div class="container">
                    <a class="left carousel-control" href="#carAdvertisementGames" data-slide="prev" style="background: transparent; color:grey;">
                        <span class="glyphicon glyphicon-chevron-left black"></span>
                    </a>
                    <a class="right carousel-control" href="#carAdvertisementGames" data-slide="next" style="background: transparent; color:grey;">
                        <span class="glyphicon glyphicon-chevron-right black"></span>
                    </a>
                </div> -->
             </div>
        </div>
        
    </div>

    <!-- END JUMBOTRON -->

    <h3>New Releases</h3>
    <!--START CAROUSEL SLIDE -->
    <div id="carNewReleasesGames"class="carousel slide" data-ride="carousel" data-interval="0">
        <div class="carousel-inner">
            <div class="item active">
                <div class="row">
                    <ul class="list-inline text-center">
                        <li><img width="150" src="Assets/Images/BatmanArkhamNight.jpg" class="block center-block"/></li>
                        <li class="games-list"><img height="200" src="Assets/Images/FarCryPrimal.jpg" class="block center-block"/></li>
                        <li class="games-list"><img height="200" src="Assets/Images/StreetFighterV.jpg" class="block center-block"/></li>
                        <li class="games-list"><img height="200" src="Assets/Images/StarWarsBattlefront.jpg" class="block center-block"/></li> 
                        <li class="games-list"><img height="200" src="Assets/Images/GearsOfWarUltimateEdition.jpg" class="block center-block"/></li>
                    </ul> 
                </div>
            </div>
            <div class="item">
                <div class="row">
                    <ul class="list-inline text-center">
                        <li class="games-list"><img height="200" src="Assets/Images/RiseOfTheTombRaider.jpg" class="block center-block"/></li>
                        <li class="games-list"><img height="200" src="Assets/Images/CallOfDutyBlackOps3.jpg" class="block center-block"/></li>
                        <li class="games-list"><img height="200" src="Assets/Images/DeadPool.jpg" class="block center-block"/></li>
                        <li class="games-list"><img height="200" src="Assets/Images/YoshisWoollyWorld.jpg" class="block center-block"/></li>
                        <li class="games-list"><img height="200" src="Assets/Images/TomClayncysTheDivision.jpg" class="block center-block"/></li>
                    </ul> 
                </div>
            </div>
        </div>
        <div class="container">
            <a class="left carousel-control" href="#carNewReleasesGames" data-slide="prev" style="background: transparent; color:grey;">
                <span class="glyphicon glyphicon-chevron-left black"></span>
            </a>
            <a class="right carousel-control" href="#carNewReleasesGames" data-slide="next" style="background: transparent; color:grey;">
                <span class="glyphicon glyphicon-chevron-right black"></span>
            </a>
        </div>
    </div>
    <!-- END CAROUSEL SLIDE -->
    <br/>
    <h3>Featured</h3>
    <!--START CAROUSEL SLIDE -->
    <div id="carFeaturedGames"class="carousel slide" data-ride="carousel" data-interval="0">
        <div class="carousel-inner">
            <div class="item active">
                <div class="row">
                    <ul class="list-inline text-center">
                        <li><img width="150" src="Assets/Images/BatmanArkhamNight.jpg" class="block center-block"/></li>
                        <li class="games-list"><img height="200"" src="Assets/Images/FarCryPrimal.jpg" class="block center-block"/></li>
                        <li class="games-list"><img height="200" src="Assets/Images/StreetFighterV.jpg" class="block center-block"/></li>
                        <li class="games-list"><img height="200" src="Assets/Images/StarWarsBattlefront.jpg" class="block center-block"/></li> 
                        <li class="games-list"><img height="200" src="Assets/Images/GearsOfWarUltimateEdition.jpg" class="block center-block"/></li>
                    </ul> 
                </div>
            </div>
            <div class="item">
                <div class="row">
                    <ul class="list-inline text-center">
                        <li class="games-list"><img height="200" src="Assets/Images/RiseOfTheTombRaider.jpg" class="block center-block"/></li>
                        <li class="games-list"><img height="200" src="Assets/Images/CallOfDutyBlackOps3.jpg" class="block center-block"/></li>
                        <li class="games-list"><img height="200" src="Assets/Images/DeadPool.jpg" class="block center-block"/></li>
                        <li class="games-list"><img height="200" src="Assets/Images/YoshisWoollyWorld.jpg" class="block center-block"/></li>
                        <li class="games-list"><img height="200" src="Assets/Images/TomClayncysTheDivision.jpg" class="block center-block"/></li>
                    </ul> 
                </div>
            </div>
        </div>
        <div class="container">
            <a class="left carousel-control" href="#carFeaturedGames" data-slide="prev" style="background: transparent; color:grey;">
                <span class="glyphicon glyphicon-chevron-left black"></span>
            </a>
            <a class="right carousel-control" href="#carFeaturedGames" data-slide="next" style="background: transparent; color:grey;">
                <span class="glyphicon glyphicon-chevron-right black"></span>
            </a>
        </div>
    </div>
    <!-- END CAROUSEL SLIDE -->
    <br/>
    <h3>Playstation 4</h3>
    <!--START CAROUSEL SLIDE -->
    <div id="carPs4Games"class="carousel slide" data-ride="carousel" data-interval="0">
        <div class="carousel-inner">

            <div class="item active">
                <div class="row">
                    <ul class="list-inline text-center">
                        <li><img width="150" src="Assets/Images/BatmanArkhamNight.jpg" class="block center-block"/></li>
                        <li class="games-list"><img height="200"" src="Assets/Images/FarCryPrimal.jpg" class="block center-block"/></li>
                        <li class="games-list"><img height="200" src="Assets/Images/StreetFighterV.jpg" class="block center-block"/></li>
                        <li class="games-list"><img height="200" src="Assets/Images/StarWarsBattlefront.jpg" class="block center-block"/></li> 
                        <li class="games-list"><img height="200" src="Assets/Images/GearsOfWarUltimateEdition.jpg" class="block center-block"/></li>
                    </ul> 
                </div>
            </div>

                <div class="item">
                <div class="row">
                    <ul class="list-inline text-center">
                        <li class="games-list"><img height="200" src="Assets/Images/RiseOfTheTombRaider.jpg" class="block center-block"/></li>
                        <li class="games-list"><img height="200" src="Assets/Images/CallOfDutyBlackOps3.jpg" class="block center-block"/></li>
                        <li class="games-list"><img height="200" src="Assets/Images/DeadPool.jpg" class="block center-block"/></li>
                        <li class="games-list"><img height="200" src="Assets/Images/YoshisWoollyWorld.jpg" class="block center-block"/></li>
                        <li class="games-list"><img height="200" src="Assets/Images/TomClayncysTheDivision.jpg" class="block center-block"/></li>
                    </ul> 
                </div>
            </div>
        </div>

        <div class="container">
            <a class="left carousel-control" href="#carPs4Games" data-slide="prev" style="background: transparent; color:grey;">
                <span class="glyphicon glyphicon-chevron-left black"></span>
            </a>
            <a class="right carousel-control" href="#carPs4Games" data-slide="next" style="background: transparent; color:grey;">
                <span class="glyphicon glyphicon-chevron-right black"></span>
            </a>
        </div>
    </div>
    <!-- END CAROUSEL SLIDE -->
    <br/>
    <h3>Xbox One</h3>
    <!--START CAROUSEL SLIDE -->
    <div id="carXoneGames"class="carousel slide" data-ride="carousel" data-interval="0">
        <div class="carousel-inner">

            <div class="item active">
                <div class="row">
                    <ul class="list-inline text-center">
                        <li><img width="150" src="Assets/Images/BatmanArkhamNight.jpg" class="block center-block"/></li>
                        <li class="games-list"><img height="200"" src="Assets/Images/FarCryPrimal.jpg" class="block center-block"/></li>
                        <li class="games-list"><img height="200" src="Assets/Images/StreetFighterV.jpg" class="block center-block"/></li>
                        <li class="games-list"><img height="200" src="Assets/Images/StarWarsBattlefront.jpg" class="block center-block"/></li> 
                        <li class="games-list"><img height="200" src="Assets/Images/GearsOfWarUltimateEdition.jpg" class="block center-block"/></li>
                    </ul> 
                </div>
            </div>

                <div class="item">
                <div class="row">
                    <ul class="list-inline text-center">
                        <li class="games-list"><img height="200" src="Assets/Images/RiseOfTheTombRaider.jpg" class="block center-block"/></li>
                        <li class="games-list"><img height="200" src="Assets/Images/CallOfDutyBlackOps3.jpg" class="block center-block"/></li>
                        <li dimgreclass="games-list"><img height="200" src="Assets/Images/DeadPool.jpg" class="block center-block"/></li>
                        <li class="games-list"><img height="200" src="Assets/Images/YoshisWoollyWorld.jpg" class="block center-block"/></li>
                        <li class="games-list"><img height="200" src="Assets/Images/TomClayncysTheDivision.jpg" class="block center-block"/></li>
                    </ul> 
                </div>
            </div>
        </div>

        <div class="container">
            <a class="left carousel-control" href="#carXoneGames" data-slide="prev" style="background: transparent; color:grey;">
                <span class="glyphicon glyphicon-chevron-left black"></span>
            </a>
            <a class="right carousel-control" href="#carXoneGames" data-slide="next" style="background: transparent; color:grey;">
                <span class="glyphicon glyphicon-chevron-right black"></span>
            </a>
        </div>
    </div>
    <!-- END CAROUSEL SLIDE -->
    <br/>
    <h3>Wii U</h3>
    <!--START CAROUSEL SLIDE -->
    <div id="carWiiUGames"class="carousel slide" data-ride="carousel" data-interval="0">
        <div class="carousel-inner">

            <div class="item active">
                <div class="row">
                    <ul class="list-inline text-center">
                        <li><img width="150" src="Assets/Images/BatmanArkhamNight.jpg" class="block center-block"/></li>
                        <li class="games-list"><img height="200"" src="Assets/Images/FarCryPrimal.jpg" class="block center-block"/></li>
                        <li class="games-list"><img height="200" src="Assets/Images/StreetFighterV.jpg" class="block center-block"/></li>
                        <li class="games-list"><img height="200" src="Assets/Images/StarWarsBattlefront.jpg" class="block center-block"/></li> 
                        <li class="games-list"><img height="200" src="Assets/Images/GearsOfWarUltimateEdition.jpg" class="block center-block"/></li>
                    </ul> 
                </div>
            </div>

                <div class="item">
                <div class="row">
                    <ul class="list-inline text-center">
                        <li class="games-list"><img height="200" src="Assets/Images/RiseOfTheTombRaider.jpg" class="block center-block"/></li>
                        <li class="games-list"><img height="200" src="Assets/Images/CallOfDutyBlackOps3.jpg" class="block center-block"/></li>
                        <li class="games-list"><img height="200" src="Assets/Images/DeadPool.jpg" class="block center-block"/></li>
                        <li class="games-list"><img height="200" src="Assets/Images/YoshisWoollyWorld.jpg" class="block center-block"/></li>
                        <li class="games-list"><img height="200" src="Assets/Images/TomClayncysTheDivision.jpg" class="block center-block"/></li>
                    </ul> 
                </div>
            </div>
        </div>

        <div class="container">
            <a class="left carousel-control" href="#carWiiUGames" data-slide="prev" style="background: transparent; color:grey;">
                <span class="glyphicon glyphicon-chevron-left black"></span>
            </a>
            <a class="right carousel-control" href="#carWiiUGames" data-slide="next" style="background: transparent; color:grey;">
                <span class="glyphicon glyphicon-chevron-right black"></span>
            </a>
        </div>
    </div>
    <!-- END CAROUSEL SLIDE -->
</asp:Content>
