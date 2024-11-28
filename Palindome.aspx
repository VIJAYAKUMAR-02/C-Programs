<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Palindome.aspx.cs" Inherits="WebApplication2.Palindome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title>Palindrome Checker</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align: center; margin-top: 50px;">
            <h2>Palindrome Checker</h2>
            <asp:TextBox ID="txtInput" runat="server" placeholder="Enter text"></asp:TextBox>
            <br /><br />
            <asp:Button ID="btnCheck" runat="server" Text="Check Palindrome" OnClick="btnCheck_Click" />
            <br /><br />
            <asp:Label ID="lblResult" runat="server" ForeColor="Blue"></asp:Label>
        </div>
    </form>
</body>
</html>
