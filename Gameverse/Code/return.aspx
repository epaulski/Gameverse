<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="return.aspx.cs" Inherits="Gameverse.Code._return" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContentPlaceHolder" runat="server">
     <div class="page-header">
        <h1><asp:Label id="LabelStatus" runat="server" Text="Thank You For Your Order!"></asp:Label></h1>
    </div>
    <asp:Label ID="message" runat="server" Text="Your order history can be viewed on your <a href='myOrders.aspx'>Orders Page</a>."></asp:Label>
</asp:Content>
