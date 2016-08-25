<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="MasterPageEbuy.HomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    Hello Welcome to Ebuy Online. </p>
    <p>
        Enter First Name and Last Name</p>
    <p style="text-align: left">
        <asp:Label ID="Label2" runat="server" Text="First Name : "></asp:Label>
        <asp:TextBox ID="firstNameTB" runat="server"></asp:TextBox>
    </p>
    <p style="text-align: left">
        <asp:Label ID="Label3" runat="server" Text="Last Name : "></asp:Label>
        <asp:TextBox ID="lastNameTB" runat="server"></asp:TextBox>
    </p>
    <p style="text-align: left">
        <asp:Button ID="pushButton" runat="server" OnClick="pushButton_Click" Text="Push/Submit Button" />
    </p>
    <p>
        &nbsp;</p>
    
</asp:Content>
