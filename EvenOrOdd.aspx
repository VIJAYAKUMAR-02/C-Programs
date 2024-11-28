<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EvenOrOdd.aspx.cs" Inherits="WebApplication2.EvenOrOdd" %>

<!DOCTYPE html>
<html lang="en">
<head runat="server">
    <meta charset="utf-8" />
    <title>Even or Odd Checker</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align:center; margin: 20px;">
            <h2>Check if Numbers are Even or Odd</h2>
            
            <asp:TextBox ID="txtInput" runat="server" placeholder="Enter numbers separated by commas" Width="300px"></asp:TextBox>
            <br /><br />
            
            <asp:Button ID="btnCheck" runat="server" Text="Check" OnClick="btnCheck_Click" />
            
            <br />
            
            <asp:Label ID="lblResult" runat="server" Text="" ForeColor="Green" />
        </div>
    </form>
</body>
</html>
