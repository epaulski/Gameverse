<%@ Page Title="Gameverse | Home" Language="C#" MasterPageFile="Site.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Gameverse.index" %>

<asp:Content ID="mainContent" ContentPlaceHolderID="mainContentPlaceHolder" runat="server" >
    <br/>
    <!-- START JUMBOTRON -->
    <div class="jumbotron">
        <div id="carAdvertisementGames"class="carousel slide" data-ride="carousel" data-interval="4000">
            <div class="carousel-inner">
                <div class="item active">
    	            <div class="row">
                        <div class="col-md-4">
                            <asp:Hyperlink ID="linkFirstGame" runat="server"><asp:Image ID="imgFirstGame" runat="server" Height="300"/></asp:Hyperlink>
                        </div>
                        <div class="col-md-8">
                            <h2><asp:Label ID="lblFirstGameName" runat="server"></asp:Label></h2>
                            <h4><asp:Label ID="lblFirstGamePlatform" runat="server"></asp:Label></h4>
                            <h3><asp:Label ID="lblFirstGamePrice" runat="server"></asp:Label></h3>
                            <asp:Hyperlink ID="linkFirstGameDetails" runat="server" Text="See Details"></asp:Hyperlink>
                        </div>
                    </div>
                </div>
    	        <asp:Repeater runat="server"  ID="rptJumboGames">
                    <ItemTemplate>
                        <div class="item">
    	                    <div class="row">
                                <div class="col-md-4">
                                   <a href="/Code/viewProduct.aspx?product=<%#Eval("Id")%>"><img height="300" src="<%#Eval("ImageUrl")%>"/></a>
                                </div>
                                <div class="col-md-8">
                                    <h2><%#Eval("Name")%></h2>
                                    <h4><%#Eval("Platform")%></h4>
                                    <h3>$<%#Eval("Value")%></h3>
                                    <a href="/Code/viewProduct.aspx?product=<%#Eval("Id")%>">See Details</a>
                                </div>
                            </div>
                        </div>
    	            </ItemTemplate>
                </asp:Repeater> 
            </div>
            <ol class="carousel-indicators">
                <li data-target="#carAdvertisementGames" data-slide-to="0" class="active"></li>
                <li data-target="#carAdvertisementGames" data-slide-to="1"></li>
                <li data-target="#carAdvertisementGames" data-slide-to="2"></li>
            </ol>
        </div>
    </div>
    <!-- END JUMBOTRON -->
    <h3>New Releases</h3>
    <!--START CAROUSEL SLIDE -->
    <div id="carNewReleasesGames"class="carousel slide" data-ride="carousel" data-interval="0">
        <div class="carousel-inner">
            <div class="item active">
                <div class="row">
                    <asp:Repeater runat="server"  ID="rptNewReleasesFirst">
                        <HeaderTemplate>
                            <ul class="list-inline text-center">
                        </HeaderTemplate>
                        <ItemTemplate>
                            <li class="games-list"><a href="/Code/viewProduct.aspx?product=<%#Eval("Id")%>"><img height="250" src="<%#Eval("ImageUrl")%>" class="block center-block"/></a></li>
                        </ItemTemplate>
                        <FooterTemplate>
                            </ul>
                        </FooterTemplate>
                    </asp:Repeater> 
                </div>
            </div>
            <div class="item">
                <div class="row">
                    <asp:Repeater runat="server"  ID="rptNewReleasesSecond">
                        <HeaderTemplate>
                            <ul class="list-inline text-center">
                        </HeaderTemplate>
                        <ItemTemplate>
                            <li class="games-list"><a href="/Code/viewProduct.aspx?product=<%#Eval("Id")%>"><img height="250" src="<%#Eval("ImageUrl")%>" class="block center-block"/></a></li>
                        </ItemTemplate>
                        <FooterTemplate>
                            </ul>
                        </FooterTemplate>
                    </asp:Repeater> 
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
                    <asp:Repeater runat="server"  ID="rptFeaturedFirst">
                        <HeaderTemplate>
                            <ul class="list-inline text-center">
                        </HeaderTemplate>
                        <ItemTemplate>
                            <li class="games-list"><a href="/Code/viewProduct.aspx?product=<%#Eval("Id")%>"><img height="250" src="<%#Eval("ImageUrl")%>" class="block center-block"/></a></li>
                        </ItemTemplate>
                        <FooterTemplate>
                            </ul>
                        </FooterTemplate>
                    </asp:Repeater> 
                </div>
            </div>
            <div class="item">
                <div class="row">
                    <asp:Repeater runat="server"  ID="rptFeaturedSecond">
                        <HeaderTemplate>
                            <ul class="list-inline text-center">
                        </HeaderTemplate>
                        <ItemTemplate>
                            <li class="games-list"><a href="/Code/viewProduct.aspx?product=<%#Eval("Id")%>"><img height="250" src="<%#Eval("ImageUrl")%>" class="block center-block"/></a></li>
                        </ItemTemplate>
                        <FooterTemplate>
                            </ul>
                        </FooterTemplate>
                    </asp:Repeater> 
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
    <h3>Xbox One</h3>
    <!--START CAROUSEL SLIDE -->
    <div id="carXboxOneGames"class="carousel slide" data-ride="carousel" data-interval="0">
        <div class="carousel-inner">
            <div class="item active">
                <div class="row">
                    <asp:Repeater runat="server"  ID="rptXboxOneFirst">
                        <HeaderTemplate>
                            <ul class="list-inline text-center">
                        </HeaderTemplate>
                        <ItemTemplate>
                            <li class="games-list"><a href="/Code/viewProduct.aspx?product=<%#Eval("Id")%>"><img height="250" src="<%#Eval("ImageUrl")%>" class="block center-block"/></a></li>
                        </ItemTemplate>
                        <FooterTemplate>
                            </ul>
                        </FooterTemplate>
                    </asp:Repeater> 
                </div>
            </div>
            <div class="item">
                <div class="row">
                    <asp:Repeater runat="server"  ID="rptXboxOneSecond">
                        <HeaderTemplate>
                            <ul class="list-inline text-center">
                        </HeaderTemplate>
                        <ItemTemplate>
                            <li class="games-list"><a href="/Code/viewProduct.aspx?product=<%#Eval("Id")%>"><img height="250" src="<%#Eval("ImageUrl")%>" class="block center-block"/></a></li>
                        </ItemTemplate>
                        <FooterTemplate>
                            </ul>
                        </FooterTemplate>
                    </asp:Repeater> 
                </div>
            </div> 
        </div>
        <div class="container">
            <a class="left carousel-control" href="#carXboxOneGames" data-slide="prev" style="background: transparent; color:grey;">
                <span class="glyphicon glyphicon-chevron-left black"></span>
            </a>
            <a class="right carousel-control" href="#carXboxOneGames" data-slide="next" style="background: transparent; color:grey;">
                <span class="glyphicon glyphicon-chevron-right black"></span>
            </a>
        </div>
    </div>
    <!-- END CAROUSEL SLIDE -->
    <br/>
    <h3>Playstation 4</h3>
    <!--START CAROUSEL SLIDE -->
    <div id="carPlaystation4"class="carousel slide" data-ride="carousel" data-interval="0">
        <div class="carousel-inner">
           <div class="item active">
                <div class="row">
                    <asp:Repeater runat="server"  ID="rptPs4First">
                        <HeaderTemplate>
                            <ul class="list-inline text-center">
                        </HeaderTemplate>
                        <ItemTemplate>
                            <li class="games-list"><a href="/Code/viewProduct.aspx?product=<%#Eval("Id")%>"><img height="250" src="<%#Eval("ImageUrl")%>" class="block center-block"/></a></li>
                        </ItemTemplate>
                        <FooterTemplate>
                            </ul>
                        </FooterTemplate>
                    </asp:Repeater> 
                </div>
            </div>
            <div class="item">
                <div class="row">
                    <asp:Repeater runat="server"  ID="rptPs4Second">
                        <HeaderTemplate>
                            <ul class="list-inline text-center">
                        </HeaderTemplate>
                        <ItemTemplate>
                            <li class="games-list"><a href="/Code/viewProduct.aspx?product=<%#Eval("Id")%>"><img height="250" src="<%#Eval("ImageUrl")%>" class="block center-block"/></a></li>
                        </ItemTemplate>
                        <FooterTemplate>
                            </ul>
                        </FooterTemplate>
                    </asp:Repeater> 
                </div>
            </div> 
        </div>
        <div class="container">
            <a class="left carousel-control" href="#carPlaystation4" data-slide="prev" style="background: transparent; color:grey;">
                <span class="glyphicon glyphicon-chevron-left black"></span>
            </a>
            <a class="right carousel-control" href="#carPlaystation4" data-slide="next" style="background: transparent; color:grey;">
                <span class="glyphicon glyphicon-chevron-right black"></span>
            </a>
        </div>
    </div>
    <!-- END CAROUSEL SLIDE -->
    <br/>
    <h3>Nintendo Wii U</h3>
    <!--START CAROUSEL SLIDE -->
    <div id="carWiiUGames"class="carousel slide" data-ride="carousel" data-interval="0">
        <div class="carousel-inner">
            <div class="item active">
                <div class="row">
                    <asp:Repeater runat="server"  ID="rptWiiUFirst">
                        <HeaderTemplate>
                            <ul class="list-inline text-center">
                        </HeaderTemplate>
                        <ItemTemplate>
                            <li class="games-list"><a href="/Code/viewProduct.aspx?product=<%#Eval("Id")%>"><img height="250" src="<%#Eval("ImageUrl")%>" class="block center-block"/></a></li>
                        </ItemTemplate>
                        <FooterTemplate>
                            </ul>
                        </FooterTemplate>
                    </asp:Repeater> 
                </div>
            </div>
            <div class="item">
                <div class="row">
                    <asp:Repeater runat="server"  ID="rptWiiUSecond">
                        <HeaderTemplate>
                            <ul class="list-inline text-center">
                        </HeaderTemplate>
                        <ItemTemplate>
                            <li class="games-list"><a href="/Code/viewProduct.aspx?product=<%#Eval("Id")%>"><img height="250" src="<%#Eval("ImageUrl")%>" class="block center-block"/></a></li>
                        </ItemTemplate>
                        <FooterTemplate>
                            </ul>
                        </FooterTemplate>
                    </asp:Repeater> 
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
