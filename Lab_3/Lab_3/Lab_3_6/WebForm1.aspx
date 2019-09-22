<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Lab_3_6.WebForm1" %>

<%@ Register TagPrefix="chn" TagName="WebUserControl1" Src="./WebUserControl1.ascx" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
    <body>
    <form runat="server" id="Form1">
        <chn:WebUserControl1 runat="server"
                           Surname="Кукареко"
                           Name="Юлия"
                           Fathername="Александровна"
                           Input="Отправить">
        </chn:WebUserControl1>
    </form>
</body>
</html>
