<%@ Page Language="C#" Theme="Task2" AutoEventWireup="true" CodeBehind="Task2.aspx.cs" Inherits="Lab4.Task2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="Task1.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" Text="Button" />
            <asp:TextBox ID="TextBox1" CssClass="class_text" runat="server"></asp:TextBox>
            <asp:Button ID="Button2" runat="server" EnableTheming="false" Text="Button" />
            <asp:Label ID="Label1"  runat="server" Text="Label"></asp:Label>
            <asp:Label ID="Label2" CssClass="class_text" SkinID="TwoLabel" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
