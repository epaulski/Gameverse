<%@ Page Title="Gameverse | Games" Language="C#" MasterPageFile="~/Code/Site.Master" AutoEventWireup="true" CodeBehind="listProducts.aspx.cs" Inherits="Gameverse.Code.listProducts" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="mainContentPlaceHolder" runat="server">
    <div class="container text-center">
        <br/>
        <div class="row">
            <asp:Repeater runat="server" ID="rptListProducts">
                <ItemTemplate>
                    <div id="listProducts" class="col-md-3">
                        <a href="/Code/viewProduct.aspx?product=<%#Eval("Id")%>"><asp:Image ID="imgCover" Height="200" runat="server" ImageUrl='<%#Eval("ImageUrl")%>'></asp:Image></a>
                        <h4><asp:Label ID="lblName" runat="server"  Text='<%#Eval("Name")%>'></asp:Label></h4>
                        <h5><asp:Label ID="lblPlatform" runat="server" Text='<%#Eval("Platform")%>'></asp:Label></h5>
                        <h4><asp:Label ID="lblPrice" runat="server" Text='<%#Eval("Value")%>'></asp:Label></h4>
                    </div>
    	        </ItemTemplate>
            </asp:Repeater> 
        </div>
    </div>
</asp:Content>