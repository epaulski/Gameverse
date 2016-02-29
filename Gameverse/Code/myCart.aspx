<%@ Page Title="" Language="C#" MasterPageFile="~/Code/Site.Master" AutoEventWireup="true" CodeBehind="myCart.aspx.cs" Inherits="Gameverse.Code.myCart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="mainContentPlaceHolder" runat="server">
    <div class="page-header">
        <h1>My Cart</h1>
    </div>
    
	<section>
		<asp:Table ID="TableCart" runat="server">
			<asp:TableHeaderRow>
				<asp:TableHeaderCell>Product</asp:TableHeaderCell>
				<asp:TableHeaderCell>Quantity</asp:TableHeaderCell>
                <asp:TableHeaderCell>Remove</asp:TableHeaderCell>
			</asp:TableHeaderRow>
		</asp:Table>
	</section>
</asp:Content>
