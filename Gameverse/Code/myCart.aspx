﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="myCart.aspx.cs" Inherits="Gameverse.Code.myCart" %>

<asp:Content ID="mainContent" ContentPlaceHolderID="mainContentPlaceHolder" runat="server">
    <div class="page-header">
        <h1>My Cart</h1>
    </div>
    <br/>
    <asp:Label ID="Message" runat="server" CssClass="message"></asp:Label>
	<section>
		<asp:Table ID="TableCart" runat="server" CssClass="table_cart text-center">
			<asp:TableHeaderRow CssClass="table_titles">
				<asp:TableHeaderCell CssClass="text-center">Game</asp:TableHeaderCell>
				<asp:TableHeaderCell CssClass="text-center">Quantity</asp:TableHeaderCell>
                <asp:TableHeaderCell CssClass="text-center">Remove</asp:TableHeaderCell>
			</asp:TableHeaderRow>
		</asp:Table>
        <br/>
        
        <asp:Button ID="ButtonNextToAddress" runat="server" Text="Next to Address" CssClass="btn btn-primary" OnClick="ClickNextToAddress" />
        <br/><br/>
        <asp:Panel ID="Panel1" runat="server" Visible="false">
            <asp:Button ID="BtnNexToToPayment" runat="server" Text="Next to Payment" CssClass="btn btn-primary" OnClick="ClickNextToPayment" />
        </asp:Panel>
        <br/>
        <asp:Panel ID="Panel2" runat="server" Visible="false">
        </asp:Panel>
        
	</section>
</asp:Content>
