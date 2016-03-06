<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="myCart.aspx.cs" Inherits="Gameverse.Code.myCart" %>

<asp:Content ID="mainContent" ContentPlaceHolderID="mainContentPlaceHolder" runat="server">
    <div class="page-header">
        <h1>My Cart</h1>
    </div>
    <asp:Label ID="Message" runat="server" CssClass="message"></asp:Label>
	<section>
		<asp:Table ID="TableCart" runat="server" CssClass="table_cart">
			<asp:TableHeaderRow CssClass="table_titles">
				<asp:TableHeaderCell>Product</asp:TableHeaderCell>
				<asp:TableHeaderCell>Quantity</asp:TableHeaderCell>
                <asp:TableHeaderCell>Remove</asp:TableHeaderCell>
			</asp:TableHeaderRow>
		</asp:Table>
        <br />
        
        <asp:Button ID="ButtonNextToAddress" runat="server" Text="Next to Address" CssClass="btn btn-primary btn-lg" OnClick="ClickNextToAddress" />

        <br />
        <asp:Panel ID="Panel1" runat="server" Visible="false">
            <asp:Button ID="BtnNexToToPayment" runat="server" Text="Next to Payment" CssClass="btn btn-primary btn-lg" OnClick="ClickNextToPayment" />
        </asp:Panel>
        <br />
        <asp:Panel ID="Panel2" runat="server" Visible="false">
        </asp:Panel>
        
	</section>
</asp:Content>
