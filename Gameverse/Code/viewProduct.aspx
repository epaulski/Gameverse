<%@ Page Title="Gameverse | Contact" Language="C#" MasterPageFile="~/Site.Master"  AutoEventWireup="true" CodeBehind="viewProduct.aspx.cs" Inherits="Gameverse.Code.viewProduct" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="mainContentPlaceHolder" runat="server">  
    <br/><br/>
    <div id="" class="container">
        <div class="row">
            <div class="col-md-3">
                <br/>
                <img height="300" src="/Assets/Images/StreetFighterV.jpg"/>
            </div>
            <div class="col-md-6">
                <h2>Street Fighter V</h2>
                <h4>Playstation 4</h4>
                <br/>
                <h2>59.99</h2>
            </div>
            <div class="col-md-3">
                <br/    >
                <asp:Button ID="btnAddToCart" runat="server" Text="Add to Cart" CssClass="btn btn-success" BorderStyle="Solid" Font-Size="Medium" Width="200"></asp:Button><br/><br/>
                <p style="display:inline">Quantity </p>
                <asp:DropDownList ID="drpQuantity" runat="server">
                    <asp:ListItem Text="1"/>
                    <asp:ListItem Text="2"/>
                    <asp:ListItem Text="3"/>
                    <asp:ListItem Text="4"/>
                    <asp:ListItem Text="5"/>
                </asp:DropDownList>
            </div>
        </div>
        <br/><br/>
        <div class="row">
            <h3>Details</h3>
            <br/>
            <div class="col-md-2">
                <p>Description</p>
            </div>
            <div class="col-md-10">
                <p>The legendary fighting franchise returns with Street Fighter V! Powered by Unreal Engine 4 technology, stunning visuals depict the next generation of World Warriors in unprecedented detail, while exciting and accessible battle mechanics deliver endless fighting fun that both beginners and veterans can enjoy. Challenge friends online, or compete for fame and glory on the Capcom Pro Tour</p>
            </div>
        </div>
        <div class="row">
            <div class="col-md-2">
                <p>Reselase Date</p>
                <p>Genre</p>
                <p>Rating</p>
            </div>
            <div class="col-md-10">
                <p>02/16/2016</p>
                <p>Fighting</p>
                <p>7</p>
            </div>
        </div>
    </div>

</asp:Content>

