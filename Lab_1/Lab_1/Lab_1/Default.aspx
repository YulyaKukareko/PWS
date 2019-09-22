<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Lab_1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="myLabel" runat="server" Text="Label"></asp:Label>
        <br />
        <p>
           <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
        </p>
        <br />
        <br />
        <p>
            <asp:TextBox ID="myTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="myButton" runat="server" style="margin-bottom: 0px" Text="Button" OnClick="myButton_Click" />
        </p>
    </form>
</body>
</html>
