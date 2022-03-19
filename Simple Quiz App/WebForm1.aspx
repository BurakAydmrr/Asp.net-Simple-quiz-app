<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication8.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        Ders adı
        <asp:TextBox ID="tbsayi1" runat="server"></asp:TextBox>
        <p>
            sınav 1&nbsp;
            <asp:TextBox ID="tbsayi2" runat="server"></asp:TextBox>
        </p>
        <p>
            sınav 2&nbsp;
            <asp:TextBox ID="tbsayi3" runat="server"></asp:TextBox>
        </p>
        <p>
            sınav 3&nbsp;
            <asp:TextBox ID="tbsayi4" runat="server"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        <p>
            &nbsp;</p>
        <asp:Table ID="Table1" runat="server" Height="119px" Width="322px">
        </asp:Table>
    </form>
</body>
</html>
