<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Temprature.aspx.cs" Inherits="WebApplication2.Temprature" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Temprature Converter</h2>
            <asp:Label Text="Enter Temprature:" runat="server"></asp:Label>
            <asp:TextBox runat="server" ID="text_Box"></asp:TextBox><br /><br />
            <asp:Label runat="server">Convert to:</asp:Label><br />
            <asp:RadioButtonList runat="server" RepeatDirection="Horizontal" ID="lblConversionType">
                <asp:ListItem Value="C">Celcius</asp:ListItem>
                <asp:ListItem Value="F">Fahrenheit</asp:ListItem>
            </asp:RadioButtonList><br /><br />
            <asp:Button runat="server" OnClick="Unnamed_Click" Text="Convert"/><br /><br />
            <asp:Label ForeColor="Green" runat="server" ID="result_Box">enter value</asp:Label>
        </div>
    </form>
</body>
</html>
