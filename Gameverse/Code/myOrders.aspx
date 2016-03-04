<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="myOrders.aspx.cs" Inherits="Gameverse.Code.myOrders" %>

<asp:Content ID="mainContent" ContentPlaceHolderID="mainContentPlaceHolder" runat="server">
    <h1 class="page-header">My Orders</h1>
    <div class="container">
        <div class="row">
            <h4><asp:Label ID="lblOrderNumber" runat="server" Text="Order number: 1"></asp:Label></h4>
            <div class="col-md-7">
                <div class="row">
                    <div class="col-md-2">
                        <asp:Image ID="imgProductImage" runat="server" ImageUrl="../Assets/Images/StreetFighterV.jpg" Height="100"></asp:Image>
                    </div>
                    <div class="col-md-10">
                        <asp:Label ID="lblProductName" runat="server" Text="Street Fighter V - " Font-Bold="true"></asp:Label>
                        <asp:Label ID="lblPlatform" runat="server" Text="Playstation 4" Font-Bold="true"></asp:Label><br/>
                        <asp:Label ID="lblPrice" runat="server" Text="$59.99"></asp:Label><br/>
                        <asp:Label ID="Label17" runat="server" Text="Quantity: 1"></asp:Label>
                    </div>
                </div>
                <br/>
                <div class="row">
                    <div class="col-md-2">
                        <asp:Image ID="Image1" runat="server" ImageUrl="../Assets/Images/FarCryPrimal.jpg" Height="100"></asp:Image>
                    </div>
                    <div class="col-md-10">
                        <asp:Label ID="Label1" runat="server" Text="Far Cry Primal - " Font-Bold="true"></asp:Label>
                        <asp:Label ID="Label2" runat="server" Text="Xbox One" Font-Bold="true"></asp:Label><br/>
                        <asp:Label ID="Label3" runat="server" Text="$59.99"></asp:Label><br/>
                        <asp:Label ID="Label18" runat="server" Text="Quantity: 1"></asp:Label>
                    </div>
                </div>  
            </div>
            <div class="col-md-5">
                <div class="col-md-3">
                    <p>Status</p>
                    <p>Total</p>
                    <p>Date</p>
                    <p>Ship to</p>
                </div>
                <div class="col-md-9">
                    <p>Shipped</p>
                    <p><asp:Label ID="lblTotal" runat="server" Text="$129.99"></asp:Label></p>
                    <p><asp:Label ID="lblDate" runat="server" Text="3/3/2016"></asp:Label></p>
                    <p>
                        <asp:Label ID="lblShippinName" runat="server" Text="Nicolas Nascimento"></asp:Label><br/>
                        <asp:Label ID="lblAddress1" runat="server" Text="525 S State St, Apt 300A"></asp:Label><br/>
                        <asp:Label ID="lblAddress2" runat="server" Text="Chicago, Illinois, 60605"></asp:Label>
                    </p>
                </div>
            </div>          
        </div>
        <hr/>
        <div class="row">
            <h4><asp:Label ID="Label4" runat="server" Text="Order number: 2"></asp:Label></h4>
            <div class="col-md-7">
                <div class="row">
                    <div class="col-md-2">
                        <asp:Image ID="Image2" runat="server" ImageUrl="../Assets/Images/MarioKart8.jpg" Height="100"></asp:Image>
                    </div>
                    <div class="col-md-10">
                        <asp:Label ID="Label5" runat="server" Text="Mario Kart 8 - " Font-Bold="true"></asp:Label>
                        <asp:Label ID="Label6" runat="server" Text="Nintendo Wii U" Font-Bold="true"></asp:Label><br/>
                        <asp:Label ID="Label7" runat="server" Text="$59.99"></asp:Label><br/>
                        <asp:Label ID="Label19" runat="server" Text="Quantity: 1"></asp:Label>
                    </div>
                </div>
                <br/>
                <div class="row">
                    <div class="col-md-2">
                        <asp:Image ID="Image3" runat="server" ImageUrl="../Assets/Images/Splatoon.jpg" Height="100"></asp:Image>
                    </div>
                    <div class="col-md-10">
                        <asp:Label ID="Label8" runat="server" Text="Splatoon - " Font-Bold="true"></asp:Label>
                        <asp:Label ID="Label9" runat="server" Text="Nintendo Wii U" Font-Bold="true"></asp:Label><br/>
                        <asp:Label ID="Label10" runat="server" Text="$59.99"></asp:Label><br/>
                        <asp:Label ID="Label20" runat="server" Text="Quantity: 1"></asp:Label>
                    </div>
                </div>  
            </div>
            <div class="col-md-5">
                <div class="col-md-3">
                    <p>Status</p>
                    <p>Total</p>
                    <p>Date</p>
                    <p>Ship to</p>
                </div>
                <div class="col-md-9">
                    <p><asp:Label ID="Label16" runat="server" Text="Shipping"></asp:Label></p>
                    <p><asp:Label ID="Label11" runat="server" Text="$129.99"></asp:Label></p>
                    <p><asp:Label ID="Label12" runat="server" Text="3/3/2016"></asp:Label></p>
                    <p>
                        <asp:Label ID="Label13" runat="server" Text="Nicolas Nascimento"></asp:Label><br/>
                        <asp:Label ID="Label14" runat="server" Text="525 S State St, Apt 300A"></asp:Label><br/>
                        <asp:Label ID="Label15" runat="server" Text="Chicago, Illinois, 60605"></asp:Label>
                    </p>
                </div>
            </div>          
        </div>
    </div>   
</asp:Content>
