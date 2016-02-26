<%@ Page Title="Gameverse | Register" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="Gameverse.register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server" >
    <!-- specific head -->
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="mainContentPlaceHolder" runat="server" >
    <div class="page-header">
        <h1>Register</h1>
    </div>
    <asp:Panel runat="server"  ID="pnlEditing" Visible="true">

        <table style="width: 100%">
            <tr>
                <td>
                    <asp:Label ID="lblFirstName" runat="server"  Text="First Name: " ToolTip="REQUIRED: Enter your first name"></asp:Label></td>
                <td>
                    <asp:TextBox ID="txtFirstName" runat="server"  AutoCompleteType="FirstName" class="form-control" placeholder="Jane" Width="250px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="reqFirstName" ControlToValidate="txtFirstName" EnableClientScript="true" ErrorMessage="First name required" ForeColor="Red" runat="server"  SetFocusOnError="true"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblLastName" runat="server"  Text="Last Name: " ToolTip="REQUIRED: Enter your last name"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtLastName" runat="server"  AutoCompleteType="LastName" class="form-control" placeholder="Doe" Width="250px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="reqLastName" ControlToValidate="txtLastName" EnableClientScript="true" ErrorMessage="Last name required" ForeColor="Red" runat="server"  SetFocusOnError="true"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblAddress1" runat="server"  Text="Address 1: " ToolTip="REQUIRED: Enter your address (1)"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtAddress1" runat="server"  AutoCompleteType="HomeStreetAddress"  class="form-control" placeholder="123 Sample Street" Width="250px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="reqAddress1" ControlToValidate="txtAddress1" EnableClientScript="true" ErrorMessage="Address required" ForeColor="Red" runat="server"  SetFocusOnError="true"></asp:RequiredFieldValidator>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblAddress2" runat="server"  Text="Address 2: " ToolTip="Enter your address (2)"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtAddress2" runat="server"  class="form-control" placeholder="" Width="250px"></asp:TextBox>
                </td>
                <td></td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblCity" runat="server"  Text="City: " ToolTip="REQUIRED: Enter your city"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtCity" runat="server"  AutoCompleteType="HomeCity" class="form-control" placeholder="Chicago" Width="250px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="reqCity" ControlToValidate="txtCity" EnableClientScript="true" ErrorMessage="City required" ForeColor="Red" runat="server"  SetFocusOnError="true"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblState" runat="server"  Text="State: " ToolTip="REQUIRED: Select your state"></asp:Label>
                </td>
                <td>
                    <%--<asp:TextBox ID="txtState" runat="server"  AutoCompleteType="HomeState"></asp:TextBox>--%>
                    <asp:DropDownList ID="ddlState" runat="server" class="form-control" Width="250px">
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
                <td>
                    <%-- %><asp:RequiredFieldValidator ID="reqState" ControlToValidate="txtState" EnableClientScript="true" ErrorMessage="State required" ForeColor="Red" runat="server"  SetFocusOnError="true"></asp:RequiredFieldValidator>
                    --%>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblZipcode" runat="server"  Text="Zipcode: " ToolTip="REQUIRED: Enter your 5 digit zipcode"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtZipcode" runat="server"  AutoCompleteType="HomeZipCode" MaxLength="5" class="form-control" placeholder="60614" Width="250px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="reqZipcode" ControlToValidate="txtZipcode" EnableClientScript="true" ErrorMessage="Zipcode required" ForeColor="Red" runat="server"  SetFocusOnError="true"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblEmail" runat="server"  Text="Email: " ToolTip="REQUIRED: Enter your email"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtEmail" runat="server"  AutoCompleteType="Email" class="form-control" placeholder="example@mail.com" Width="250px"></asp:TextBox>
                </td>
                <td>
                    <asp:RegularExpressionValidator ID="regexEmail" ControlToValidate="txtEmail" ValidationExpression="^([0-9a-zA-Z]([-.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$" EnableClientScript="true" ErrorMessage="Email not in the correct format" ForeColor="Red" runat="server"  SetFocusOnError="true"></asp:RegularExpressionValidator>
                    <br /><asp:RequiredFieldValidator ID="reqEmail" ControlToValidate="txtEmail" EnableClientScript="true" ErrorMessage="Email required" ForeColor="Red" runat="server"  SetFocusOnError="true"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblPassword" runat="server"  Text="Password: " ToolTip="REQUIRED: Enter a secure password"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtPassword" runat="server"  TextMode="Password"  class="form-control" placeholder="" Width="250px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="reqPassword" ControlToValidate="txtPassword" EnableClientScript="true" ErrorMessage="Password required" ForeColor="Red" runat="server"  SetFocusOnError="true"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblPassword2" runat="server"  Text="Confirm password: " ToolTip="REQUIRED: Re-enter a secure password"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtPassword2" runat="server"  TextMode="Password" class="form-control" placeholder="" Width="250px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="reqPassword2" ControlToValidate="txtPassword2" EnableClientScript="true" ErrorMessage="Password re-entry required" ForeColor="Red" runat="server"  SetFocusOnError="true"></asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="comparePwdValidator" ControlToCompare="txtPassword" ControlToValidate="txtPassword2" EnableClientScript="true" ErrorMessage="Passwords don't match" ForeColor="Red" runat="server" ></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblEmailOffer" runat="server"  Text="Sign up for email offers? " ToolTip="Would you like to sign up for special email offers?"></asp:Label>
                </td>
                <td>
                    <asp:RadioButtonList runat="server"  ID="lstEmailOffer" class="checkbox">
                        <asp:ListItem Text="Yes" Value="Yes" Selected="True"></asp:ListItem>
                        <asp:ListItem Text="No" Value="No"></asp:ListItem>
                    </asp:RadioButtonList>
                </td>
                <td></td>
            </tr>            
        </table>
        <asp:Button ID="btnSubmit" runat="server"  CausesValidation="true" Text="Submit" OnClick="btnSubmit_Click" class="btn btn-primary"></asp:Button>
    </asp:Panel>

    <asp:Panel runat="server"  ID="pnlSummary" Visible="false">
        <h2><asp:Label runat="server"  ID="lblMessage"></asp:Label></h2>
        <asp:Label runat="server"  ID="lblID"></asp:Label><br />
        <asp:Label runat="server"  ID="lblUserFirstName"></asp:Label><br />
        <asp:Label runat="server"  ID="lblUserLastName"></asp:Label><br />
        <asp:Label runat="server"  ID="lblUserAddress1"></asp:Label><br />
        <asp:Label runat="server"  ID="lblUserAddress2"></asp:Label><br />
        <asp:Label runat="server"  ID="lblUserCity"></asp:Label><br />
        <asp:Label runat="server"  ID="lblUserState"></asp:Label><br />
        <asp:Label runat="server"  ID="lblUserZipcode"></asp:Label><br />
        <asp:Label runat="server"  ID="lblUserEmail"></asp:Label><br />
        <asp:Label runat="server"  ID="lblUserEmailOffer"></asp:Label><br />
    </asp:Panel>

</asp:Content>

