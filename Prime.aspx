<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Prime.aspx.cs" Inherits="WebApplication2.Prime" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align:center">
            <h3>Check if number is prime or Not</h3>
            <asp:TextBox runat="server" ID="txt_Box" placeholder="Enter the number"></asp:TextBox><br /><br/>
            <asp:Button text="Check" runat="server" OnClick="Unnamed_Click"/><br />
            <asp:Label runat="server" Text="" ID="result_Box"></asp:Label>
        </div>
    </form>
</body>
</html>
