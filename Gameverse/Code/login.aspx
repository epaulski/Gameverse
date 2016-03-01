<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Gameverse.Code.login" %>

<asp:Content ID="mainContent" ContentPlaceHolderID="mainContentPlaceHolder" runat="server">
    <div class="page-header">
        <h1>Log in</h1>
    </div>
    <section>
        <asp:Panel ID="panelError" Visible="false" runat="server">
            <div class="alert alert-danger" role="alert"><asp:Label runat="server" ID="lblResults"></asp:Label></div>
        </asp:Panel>
        <asp:Panel ID="panelLogin" Visible="true" runat="server">
            User Name/Email:
            <br />
            <asp:TextBox ID="txtUserName" runat="server" class="form-control" placeholder="example@mail.com" Width="250px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="reqUsername" ControlToValidate="txtUserName" EnableClientScript="true" ErrorMessage="User Name/Email required" ForeColor="Red" runat="server" SetFocusOnError="true"></asp:RequiredFieldValidator>
            <br />
            Password:
            <br />
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" class="form-control" Width="250px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="reqPassword" ControlToValidate="txtPassword" EnableClientScript="true" ErrorMessage="Password required" ForeColor="Red" runat="server" SetFocusOnError="true"></asp:RequiredFieldValidator>
            <br />
            <asp:Button runat="server" ID="btnLogin" OnClick="Login" Text="Login" class="btn btn-primary"></asp:Button>
        </asp:Panel>
        <asp:Panel ID="panelLogout" Visible="false" runat="server">
            <asp:Button ID="btnLogout" runat="server" Text="LogOut" OnClick="LogOut" class="btn btn-danger"></asp:Button>
        </asp:Panel>
    </section>
</asp:Content>
