<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Lab_1_2._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server" />
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click1" />
            <br />
            <br />
        </div>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </form>
    <a href="Task_22.aspx">Task_2</a>
    <br />
    <br />
    <a href="Task_3.aspx">Task_3</a>
</asp:Content>
