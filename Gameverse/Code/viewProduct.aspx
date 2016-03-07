<%@ Page Title="Gameverse | Game" Language="C#" MasterPageFile="~/Site.Master"  AutoEventWireup="true" CodeBehind="viewProduct.aspx.cs" Inherits="Gameverse.Code.viewProduct" %>

<asp:Content ID="mainContent" ContentPlaceHolderID="mainContentPlaceHolder" runat="server">  
    <br/><br/>
    <asp:Panel ID="pnlError" Visible="false" runat="server">
        <div class="alert alert-danger" role="alert"><asp:Label runat="server" ID="lblMessage"></asp:Label></div>
    </asp:Panel>
    <asp:Panel ID="pnlSuccess" Visible="false" runat="server" CssClass="container">
        <div class="row">
            <div class="col-md-3">
                <br/>
                <asp:Image ID="imgCover" runat="server" height="300"></asp:Image>
            </div>
            <div class="col-md-6">
                <h2><asp:Label ID="lblName" runat="server"></asp:Label></h2>
                <h4><asp:Label ID="lblPlatform" runat="server"></asp:Label></h4>
                <br/>
                <h2><asp:Label ID="lblPrice" runat="server" ForeColor="Red"></asp:Label></h2>
            </div>
            <div class="col-md-3">
                <br/>
                <asp:Button ID="btnAddToCart" runat="server" Text="Add to Cart" CssClass="btn btn-success" BorderStyle="Solid" Font-Size="Medium" Width="200" OnClick="btnAddToCart_Click"></asp:Button><br/><br/>
                <p style="display:inline">Quantity </p>
                <asp:DropDownList ID="drpQuantity" runat="server">
                </asp:DropDownList>
                <asp:Label ID="Message" runat="server" CssClass="message"></asp:Label>
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
                <p><asp:Label ID="lblDescription" runat="server"></asp:Label></p>
            </div>
        </div>
        <div class="row">
            <div class="col-md-2">
                <p>Release Date</p>
                <p>Genre</p>
                <p>Rating</p>
            </div>
            <div class="col-md-10">
                <p><asp:Label ID="lblReleaseDate" runat="server"></asp:Label></p>
                <p><asp:Label ID="lblGenre" runat="server"></asp:Label></p>
                <p><asp:Label ID="lblRating" runat="server"></asp:Label></p>
            </div>
        </div>
    </asp:Panel>
</asp:Content>

