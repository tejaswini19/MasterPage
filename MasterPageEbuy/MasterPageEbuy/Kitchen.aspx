<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Kitchen.aspx.cs" Inherits="MasterPageEbuy.Kitchen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    <asp:Label ID="Label3" runat="server" Text="Check the Items to buy"></asp:Label>
</p>
<asp:CheckBoxList ID="CheckBoxList1" runat="server" autoPostBack="true" OnSelectedIndexChanged="CheckBoxList1_SelectedIndexChanged">
    <asp:ListItem Value="35">Coffee_Maker</asp:ListItem>
    <asp:ListItem Value="30">Rice_Cooker</asp:ListItem>
    <asp:ListItem Value="150">Non_Stick_Ware</asp:ListItem>
    <asp:ListItem Value="20">Wooden_Spoons</asp:ListItem>
    <asp:ListItem Value="10">Spoons</asp:ListItem>
</asp:CheckBoxList>
<p>
    Selected Items are</p>
<p>
    <asp:Label ID="kl1" runat="server"></asp:Label>
            <!--<asp:Label ID="kl2" runat="server" Text="Label" Visible="False"></asp:Label>
            <asp:Label ID="kl3" runat="server" Text="Label" Visible="False"></asp:Label>
            <asp:Label ID="kl4" runat="server" Text="Label" Visible="False"></asp:Label>
            <asp:Label ID="kl5" runat="server" Text="Label" Visible="False"></asp:Label>-->
        </p>
<p>
    Total Price:
    <asp:Label ID="price" runat="server"></asp:Label>
</p>
<p>
    <asp:Button ID="Button1" runat="server" PostBackUrl="~/Cart.aspx" Text="Cart" />
</p>
</asp:Content>
