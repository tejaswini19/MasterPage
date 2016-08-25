<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Painting.aspx.cs" Inherits="MasterPageEbuy.Painting" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Check the Items to buy"></asp:Label>
<br />
<asp:CheckBoxList ID="CheckBoxList1" runat="server" autoPostBack="true" Height="122px" OnSelectedIndexChanged="CheckBoxList1_SelectedIndexChanged" style="text-align: left" Width="123px">
    <asp:ListItem Value="40">Baby</asp:ListItem>
    <asp:ListItem Value="30">Girl</asp:ListItem>
    <asp:ListItem Value="70">Rain</asp:ListItem>
    <asp:ListItem Value="50">Tree</asp:ListItem>
    <asp:ListItem Value="60">Butterfly</asp:ListItem>
</asp:CheckBoxList>
<p>
    <asp:Label ID="pl1" runat="server" Text="Label" Visible="False"></asp:Label>
    <asp:Label ID="pl2" runat="server" Text="Label" Visible="False"></asp:Label>
    <asp:Label ID="pl3" runat="server" Text="Label" Visible="False"></asp:Label>
    <asp:Label ID="pl4" runat="server" Text="Label" Visible="False"></asp:Label>
    <asp:Label ID="pl5" runat="server" Text="Label" Visible="False"></asp:Label>
</p>
<p>
    <asp:Image ID="Image1" runat="server" Height="200px" Visible="False" Width="200px" ImageUrl="~/Baby.jpg" />
&nbsp;&nbsp;&nbsp;
    <asp:Image ID="Image2" runat="server" Height="200px" Visible="False" Width="200px" ImageUrl="~/Girl.jpg" />
&nbsp;&nbsp;&nbsp;
    <asp:Image ID="Image3" runat="server" Height="200px" Visible="False" Width="200px" ImageUrl="~/Rain.jpg" />
&nbsp;&nbsp;&nbsp;
    <asp:Image ID="Image4" runat="server" Height="200px" Visible="False" Width="200px" ImageUrl="~/Tree.jpg" />
&nbsp;&nbsp;&nbsp;
    <asp:Image ID="Image5" runat="server" Height="200px" Visible="False" Width="200px" ImageUrl="~/Butterfly.jpg" />
</p>
<p>
    Total Price:
    <asp:Label ID="pPrice" runat="server"></asp:Label>
</p>
<p>
    <asp:Button ID="Button1" runat="server" PostBackUrl="~/Cart.aspx" Text="Cart" />
</p>
</asp:Content>
