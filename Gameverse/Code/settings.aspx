<%@ Page Title="" Language="C#" MasterPageFile="~/Code/Site.Master" AutoEventWireup="true" CodeBehind="settings.aspx.cs" Inherits="Gameverse.Code.settings" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContentPlaceHolder" runat="server">

    <div class="page-header">
        <h1>Settings</h1>
    </div>

    <h3>Current Profile</h3>

    <asp:Table ID="tblData" runat="server" class="table" Width="50%">
        <asp:TableHeaderRow>
        </asp:TableHeaderRow>
        <asp:TableRow>
            <asp:TableCell>Name</asp:TableCell>
            <asp:TableCell>
                <asp:Label runat="server" ID="lblname"></asp:Label>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>Address 1</asp:TableCell>
            <asp:TableCell>
                <asp:Label runat="server" ID="lbluseraddress1"></asp:Label>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>Address 2</asp:TableCell>
            <asp:TableCell>
                <asp:Label runat="server" ID="lbluseraddress2"></asp:Label>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>State</asp:TableCell>
            <asp:TableCell>
                <asp:Label runat="server" ID="lbluserstate"></asp:Label>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>City</asp:TableCell>
            <asp:TableCell>
                <asp:Label runat="server" ID="lblusercity"></asp:Label>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>Zipcode</asp:TableCell>
            <asp:TableCell>
                <asp:Label runat="server" ID="lbluserzipcode"></asp:Label>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>User Name/Email</asp:TableCell>
            <asp:TableCell>
                <asp:Label runat="server" ID="lbluseremail"></asp:Label>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>Email subscription</asp:TableCell>
            <asp:TableCell>
                <asp:Label runat="server" ID="lblemailoffer"></asp:Label>
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>

    <br />
    <br />

    <h3>Edit Your Profile</h3>

    <asp:Panel runat="server" ID="pnlEditing" Visible="true">
        <table style="width: 100%">
            <tr>
                <td>
                    <asp:Label ID="lblAddress1" runat="server" Text="Address 1: " ToolTip="Change your address (1)"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtAddress1" runat="server" AutoCompleteType="HomeStreetAddress" class="form-control" placeholder="123 Sample Street" Width="250px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblAddress2" runat="server" Text="Address 2: " ToolTip="Change your address (2)"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtAddress2" runat="server" class="form-control" placeholder="" Width="250px"></asp:TextBox>
                </td>
                <td></td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblCity" runat="server" Text="City: " ToolTip="Change your city"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtCity" runat="server" AutoCompleteType="HomeCity" class="form-control" placeholder="Chicago" Width="250px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblState" runat="server" Text="State: " ToolTip="Change your state"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlState" runat="server" class="form-control" Width="250px">
                        <asp:ListItem Value=""></asp:ListItem>
                        <asp:ListItem Value="AL">Alabama</asp:ListItem>
                        <asp:ListItem Value="AK">Alaska</asp:ListItem>
                        <asp:ListItem Value="AZ">Arizona</asp:ListItem>
                        <asp:ListItem Value="AR">Arkansas</asp:ListItem>
                        <asp:ListItem Value="CA">California</asp:ListItem>
                        <asp:ListItem Value="CO">Colorado</asp:ListItem>
                        <asp:ListItem Value="CT">Connecticut</asp:ListItem>
                        <asp:ListItem Value="DC">District of Columbia</asp:ListItem>
                        <asp:ListItem Value="DE">Delaware</asp:ListItem>
                        <asp:ListItem Value="FL">Florida</asp:ListItem>
                        <asp:ListItem Value="GA">Georgia</asp:ListItem>
                        <asp:ListItem Value="HI">Hawaii</asp:ListItem>
                        <asp:ListItem Value="ID">Idaho</asp:ListItem>
                        <asp:ListItem Value="IL">Illinois</asp:ListItem>
                        <asp:ListItem Value="IN">Indiana</asp:ListItem>
                        <asp:ListItem Value="IA">Iowa</asp:ListItem>
                        <asp:ListItem Value="KS">Kansas</asp:ListItem>
                        <asp:ListItem Value="KY">Kentucky</asp:ListItem>
                        <asp:ListItem Value="LA">Louisiana</asp:ListItem>
                        <asp:ListItem Value="ME">Maine</asp:ListItem>
                        <asp:ListItem Value="MD">Maryland</asp:ListItem>
                        <asp:ListItem Value="MA">Massachusetts</asp:ListItem>
                        <asp:ListItem Value="MI">Michigan</asp:ListItem>
                        <asp:ListItem Value="MN">Minnesota</asp:ListItem>
                        <asp:ListItem Value="MS">Mississippi</asp:ListItem>
                        <asp:ListItem Value="MO">Missouri</asp:ListItem>
                        <asp:ListItem Value="MT">Montana</asp:ListItem>
                        <asp:ListItem Value="NE">Nebraska</asp:ListItem>
                        <asp:ListItem Value="NV">Nevada</asp:ListItem>
                        <asp:ListItem Value="NH">New Hampshire</asp:ListItem>
                        <asp:ListItem Value="NJ">New Jersey</asp:ListItem>
                        <asp:ListItem Value="NM">New Mexico</asp:ListItem>
                        <asp:ListItem Value="NY">New York</asp:ListItem>
                        <asp:ListItem Value="NC">North Carolina</asp:ListItem>
                        <asp:ListItem Value="ND">North Dakota</asp:ListItem>
                        <asp:ListItem Value="OH">Ohio</asp:ListItem>
                        <asp:ListItem Value="OK">Oklahoma</asp:ListItem>
                        <asp:ListItem Value="OR">Oregon</asp:ListItem>
                        <asp:ListItem Value="PA">Pennsylvania</asp:ListItem>
                        <asp:ListItem Value="RI">Rhode Island</asp:ListItem>
                        <asp:ListItem Value="SC">South Carolina</asp:ListItem>
                        <asp:ListItem Value="SD">South Dakota</asp:ListItem>
                        <asp:ListItem Value="TN">Tennessee</asp:ListItem>
                        <asp:ListItem Value="TX">Texas</asp:ListItem>
                        <asp:ListItem Value="UT">Utah</asp:ListItem>
                        <asp:ListItem Value="VT">Vermont</asp:ListItem>
                        <asp:ListItem Value="VA">Virginia</asp:ListItem>
                        <asp:ListItem Value="WA">Washington</asp:ListItem>
                        <asp:ListItem Value="WV">West Virginia</asp:ListItem>
                        <asp:ListItem Value="WI">Wisconsin</asp:ListItem>
                        <asp:ListItem Value="WY">Wyoming</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblZipcode" runat="server" Text="Zipcode: " ToolTip="Change your 5 digit zipcode"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtZipcode" runat="server" AutoCompleteType="HomeZipCode" MaxLength="5" class="form-control" placeholder="60614" Width="250px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblEmail" runat="server" Text="Email: " ToolTip="Change your email"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtEmail" runat="server" AutoCompleteType="Email" class="form-control" placeholder="example@mail.com" Width="250px"></asp:TextBox>
                </td>
                <td>
                    <asp:RegularExpressionValidator ID="regexEmail" ControlToValidate="txtEmail" ValidationExpression="^([0-9a-zA-Z]([-.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$" EnableClientScript="true" ErrorMessage="Email not in the correct format" ForeColor="Red" runat="server" SetFocusOnError="true"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblPassword" runat="server" Text="Password: " ToolTip="Change your secure password"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" class="form-control" placeholder="" Width="250px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblPassword2" runat="server" Text="Confirm password: " ToolTip="REQUIRED: Re-enter a secure password"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtPassword2" runat="server" TextMode="Password" class="form-control" placeholder="" Width="250px"></asp:TextBox>
                </td>
                <td>
                    <asp:CompareValidator ID="comparePwdValidator" ControlToCompare="txtPassword" ControlToValidate="txtPassword2" EnableClientScript="true" ErrorMessage="Passwords don't match" ForeColor="Red" runat="server"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Sign up for email offers? " ToolTip="Would you like to sign up for special email offers?"></asp:Label>
                </td>
                <td>
                    <asp:RadioButtonList runat="server" ID="lstEmailOffer" class="checkbox">
                        <asp:ListItem Text="No change" Value="NoChange" Selected="True"></asp:ListItem>
                        <asp:ListItem Text="Yes" Value="Yes"></asp:ListItem>
                        <asp:ListItem Text="No" Value="No"></asp:ListItem>
                    </asp:RadioButtonList>
                </td>
                <td></td>
            </tr>
        </table>
        <br />
        <asp:Button ID="btnSubmit" runat="server" CausesValidation="true" Text="Submit Changes" OnClick="btnSubmit_Click" class="btn btn-primary"></asp:Button>
    </asp:Panel>
</asp:Content>
