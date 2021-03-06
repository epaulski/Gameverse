﻿<%@ Page Title="Gameverse | Games" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="listProducts.aspx.cs" Inherits="Gameverse.Code.listProducts" %>

<asp:Content ID="mainContent" ContentPlaceHolderID="mainContentPlaceHolder" runat="server">
    <asp:Panel ID="Panel1" runat="server" Visible="false">
        <div class="container text-center">
            <br/>
            <div class="row">
                <asp:Repeater runat="server" ID="rptListProducts">
                    <ItemTemplate>
                        <div id="listProducts" class="col-md-3">
                            <a href="/Code/viewProduct.aspx?product=<%#Eval("Id")%>"><img height="200" src="<%#Eval("ImageUrl")%>"/></a>
                            <a href="/Code/viewProduct.aspx?product=<%#Eval("Id")%>"><h4><%#Eval("Name")%></h4></a>
                            <p><%#Eval("Platform")%></p>
                            <h4 style="color:red;">$<%#Eval("Value")%></h4>
                        </div>
    	            </ItemTemplate>
                </asp:Repeater> 
            </div>
        </div>
    </asp:Panel>
    <asp:Panel ID="Panel2" runat="server" Visible="false">
        <br/><br/>
        <h4>Your search <asp:Label ID="lblSearchKey" runat="server" Font-Bold="true"></asp:Label> did not match any games</h4>
    </asp:Panel>
</asp:Content>