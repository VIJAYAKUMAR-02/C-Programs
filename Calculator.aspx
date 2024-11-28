<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculator.aspx.cs" Inherits="WebApplication2.Calculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
      <title>Simple Calculator</title>
      <link href="CalculatorStyle.css" rel="stylesheet"/>
</head>
<body>
     <form id="form1" runat="server">
         <div>
         <h2>Calculator</h2>
        <asp:TextBox ID="txtNumber1" runat="server" Placeholder="Enter first number"></asp:TextBox>
        <br />
        <asp:TextBox ID="txtNumber2" runat="server" Placeholder="Enter second number"></asp:TextBox>
        <br />
        <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
        <asp:Button ID="btnSubtract" runat="server" Text="Subtract" OnClick="btnSubtract_Click" />
        <asp:Button ID="btnMultiply" runat="server" Text="Multiply" OnClick="btnMultiply_Click" />
        <asp:Button ID="btnDivide" runat="server" Text="Divide" OnClick="btnDivide_Click" />
        <br /><br />
        <asp:Label ID="lblResult" runat="server" Text="Result will appear here"></asp:Label>
        </div>
    </form>
</body>
</html>
