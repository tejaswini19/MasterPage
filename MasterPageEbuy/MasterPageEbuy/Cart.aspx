<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="MasterPageEbuy.Cart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
    <tr>
        <td class="auto-style2">Cart</td>
    </tr>
    <tr>
        <td class="auto-style3">Items Added to Cart</td>
    </tr>
    <tr>
        <td class="auto-style5">
            <asp:Label ID="K1" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="auto-style5">
            <asp:Label ID="Label2" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="auto-style5">Total Price :
            <asp:Label ID="tPrice" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="auto-style5">
            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Default.aspx">Default Page</asp:HyperLink>
        </td>
    </tr>
    <tr>
        <td class="auto-style5">
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Products.aspx">Products</asp:HyperLink>
        </td>
    </tr>
    <tr>
        <td class="auto-style5">
            <asp:LinkButton ID="Kitchen1" runat="server" PostBackUrl="~/Kitchen.aspx">Kitchen</asp:LinkButton>
        </td>
    </tr>
    <tr>
        <td class="auto-style5">
            <asp:LinkButton ID="Painting1" runat="server" PostBackUrl="~/PaintingGallery.aspx">Painting Gallery</asp:LinkButton>
        </td>
    </tr>
</table>
</asp:Content>
