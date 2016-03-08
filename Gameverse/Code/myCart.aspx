<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="myCart.aspx.cs" Inherits="Gameverse.Code.myCart" %>

<asp:Content ID="mainContent" ContentPlaceHolderID="mainContentPlaceHolder" runat="server">
    <div class="page-header">
        <h1>My Cart</h1>
    </div>
    <br/>
   
    <asp:Label ID="Message" runat="server" CssClass="message"></asp:Label>
	<section>

		 <asp:Panel ID="Panel1" runat="server" Visible="false">
             <asp:Table ID="TableCart" runat="server" CssClass="table_cart text-center">
			    <asp:TableHeaderRow CssClass="table_titles">
				    <asp:TableHeaderCell CssClass="text-center">Game</asp:TableHeaderCell>
				    <asp:TableHeaderCell CssClass="text-center">Quantity</asp:TableHeaderCell>
                    <asp:TableHeaderCell CssClass="text-center">Remove</asp:TableHeaderCell>
			    </asp:TableHeaderRow>
		    </asp:Table>
            <br/>
           <asp:Button ID="BtnNextToAddress" runat="server" Text="Next to Address" CssClass="btn btn-primary" OnClick="ClickNextToAddress" />
        
         </asp:Panel>
        
        <asp:Panel ID="Panel2" runat="server" Visible="false">
             <hr/>
             <asp:RadioButtonList AutoPostBack="true" ID="RadioButtonList" runat="server" OnSelectedIndexChanged="RadioButtonList_SelectedIndexChanged">
                 <asp:ListItem Value="1"> Choose existing address</asp:ListItem>   
                 <asp:ListItem Value="2"> Use a different address</asp:ListItem>
             </asp:RadioButtonList>
             <asp:Panel ID="PanelChooseAddress" runat="server" Visible="false">
                 <h4>Choose an existing address</h4>
                 <asp:DropDownList ID="DropDownListAddress" runat="server">
                 </asp:DropDownList>
                 <br/>
                 <br/>
             </asp:Panel>
             <asp:Panel ID="PanelAddAddress" runat="server" Visible="false">
                 <h4>Add a new address</h4>
                 <br/>
                 <div class="row">
                 <div class="col-md-6">
                 <asp:Label ID="LabelAddress1" runat="server" Text="Address Line 1"></asp:Label>
                 <asp:TextBox cssclass="form-control" ID="TextBoxAddress1" runat="server"></asp:TextBox>
                 <asp:RequiredFieldValidator ID="RequiredFieldAddress1" runat="server" ControlToValidate="TextBoxAddress1" ErrorMessage="Required Field"></asp:RequiredFieldValidator>
                 <br/>
                 <asp:Label ID="LabelAddress2" runat="server" Text="Address Line 2"></asp:Label>
                 <asp:TextBox cssclass="form-control" ID="TextBoxAddress2" runat="server"></asp:TextBox>
                 <br/>
                 <asp:Label ID="LabelState" runat="server" Text="State"></asp:Label>
                 <asp:TextBox ID="TextBoxState" cssclass="form-control" runat="server"></asp:TextBox>
                 <asp:RequiredFieldValidator ID="RequiredFieldState" runat="server" ControlToValidate="TextBoxState" ErrorMessage="Required Field"></asp:RequiredFieldValidator>
                 <br/>
                 <asp:Label ID="LabelCity" runat="server" Text="City"></asp:Label>
                 <asp:TextBox ID="TextBoxCity" cssclass="form-control" runat="server"></asp:TextBox>
                 <asp:RequiredFieldValidator ID="RequiredFieldCity" runat="server" ControlToValidate="TextBoxCity" ErrorMessage="Required Field"></asp:RequiredFieldValidator>
                 <br/>
                 <asp:Label ID="LabelZipCode" runat="server" Text="Zip Code"></asp:Label>
                 <asp:TextBox ID="TextBoxZipCode" cssclass="form-control" runat="server"></asp:TextBox>
                 <asp:RequiredFieldValidator ID="RequiredFieldZipCode" runat="server" ControlToValidate="TextBoxZipCode" ErrorMessage="Required Field"></asp:RequiredFieldValidator>               
                 <br/>
                 <asp:Button ID="ButtonSaveAddress" runat="server" Text="Save Address" CssClass="btn btn-primary" OnClick="ClickSaveAddress" />
                 <br/>
                 </div>
                 </div>
             </asp:Panel>
            <asp:Panel id="AddressAdded" runat="server" Visible="false">
                <h4>Shipping to:</h4>
                <asp:Label ID="Address1" runat="server" Text="Address Line 1"></asp:Label><br/>
                <asp:Label ID="Address2" runat="server" Text="Address Line 2"></asp:Label><br/>
                <asp:Label ID="City" runat="server" Text="Address Line 2"></asp:Label><br/>
                <asp:Label ID="State" runat="server" Text="Address Line 2"></asp:Label><br/>
                <asp:Label ID="ZipCode" runat="server" Text="Address Line 2"></asp:Label>
            </asp:Panel>
            <hr/>
            <asp:Button Visible="false" ID="BtnNexToToPayment" runat="server" Text="Next to Payment" CssClass="btn btn-primary" OnClick="ClickNextToPayment" />
            <br/>
        </asp:Panel>

        
        <asp:Panel ID="Panel3" runat="server" Visible="false">
            <h4>You don't have any items in your cart yet!</h4>
        </asp:Panel>
        
	</section>
            
</asp:Content>
