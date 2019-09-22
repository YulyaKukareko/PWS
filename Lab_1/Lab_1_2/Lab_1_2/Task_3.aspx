<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Task_3.aspx.cs" Inherits="Lab_1_2.Task_3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
        <div>
            <asp:Label ID="myLabel" runat="server" Text="Label"></asp:Label>
        </div>
        <br />
        <br />
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" AutoPostBack="true" />
        <br />
        <br />
            <asp:CheckBox ID="CheckBox1" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" AutoPostBack="true" />
        <br />
        <br />
            <asp:radiobutton runat="server" OnCheckedChanged="Unnamed1_CheckedChanged" AutoPostBack="true" />
        <br />
     </form>
</body>
</html>
