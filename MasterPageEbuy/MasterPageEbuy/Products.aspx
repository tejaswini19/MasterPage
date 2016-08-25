<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="MasterPageEbuy.Products" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
        <p class="auto-style2">
            Welcome
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
&nbsp;<asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        </p>
        <p style="text-align: left">
            <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/Kitchen.aspx">Kitchen-LinkButton</asp:LinkButton>
        </p>
        <p style="text-align: left">
            <asp:ImageButton ID="ImageButton1" runat="server" Height="149px" Width="237px" PostBackUrl="~/PaintingGallery.aspx" ImageUrl="~/PaintingImage.jpg"/>
        </p>
        <p style="text-align: left">
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Cart.aspx">Cart-HyperLink</asp:HyperLink>
        </p>
</asp:Content>
