<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="myOrders.aspx.cs" Inherits="Gameverse.Code.myOrders" %>

<asp:Content ID="mainContent" ContentPlaceHolderID="mainContentPlaceHolder" runat="server">
    <h1 class="page-header">My Orders</h1>
    <div class="container">
        <asp:Repeater ID="rptOrders" runat="server" OnItemDataBound="ItemBound">
             <ItemTemplate>
                    <div class="row">
                        <h4>Order number: <%#Eval("Id")%></h4>
                        <div class="col-md-7">
                            <asp:Repeater ID="rptOrderProcuts" runat="server">
                                <ItemTemplate>
                                    <div class="row">
                                        <div class="col-md-2">
                                            <a href="/Code/viewProduct.aspx?product=<%#Eval("Product.Id")%>"><img src="<%#Eval("Product.ImageUrl")%>" height="100"></img></a>
                                        </div>
                                        <div class="col-md-10">
                                            <a href="/Code/viewProduct.aspx?product=<%#Eval("Product.Id")%>">
                                                <p style="font-weight: bold;"><%#Eval("Product.Name")%> - <%#Eval("Product.Platform")%></p>
                                            </a>
                                            <p style="color:red;">$<%#Eval("Product.Value")%></p>
                                            <p>Quantity: <%#Eval("Quantity")%></p>
                                        </div>
                                    </div>
                                    <br/>
                                </ItemTemplate>
                            </asp:Repeater>
                        </div>
                        <div class="col-md-5">
                            <div class="col-md-3">
                                <p style="font-weight: bold;">Status</p>
                                <p style="font-weight: bold;">Total</p>
                                <p style="font-weight: bold;">Date</p>
                                <p style="font-weight: bold;">Shipping address</p><br/>
                            </div>
                            <div class="col-md-9">
                                <p><%#Eval("Status")%></p>
                                <p>$<%#Eval("Total")%></p>
                                <p><%#Eval("Date")%></p>
                                <p>
                                    <p style="display:inline"><%#Eval("User.Name")%></p><br/>
                                    <p style="display:inline"><%#Eval("ShippingAddress.AddressLine1")%>, <%#Eval("ShippingAddress.AddressLine2")%></p><br/>
                                    <p><%#Eval("ShippingAddress.City")%>, <%#Eval("ShippingAddress.State")%>, <%#Eval("ShippingAddress.Zipcode")%></p>
                                </p>
                            </div>
                        </div>          
                    </div>
                    <hr/>
    	        </ItemTemplate>           
        </asp:Repeater>
    </div>   
</asp:Content>
