<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TempratureConverter.aspx.cs" Inherits="WebApplication2.TempratureConverter" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Temperature Converter</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Temperature Converter</h2>
            <asp:Label ID="lblInput" runat="server" Text="Enter Temperature:" />
            <asp:TextBox ID="txtInput" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblConversionType" runat="server" Text="Convert to:" />
            <asp:RadioButtonList ID="rblConversionType" runat="server" RepeatDirection="Horizontal">
                <asp:ListItem Text="Celsius" Value="C" />
                <asp:ListItem Text="Fahrenheit" Value="F" />
            </asp:RadioButtonList>
            <br />
            <br />
            <asp:Button ID="btnConvert" runat="server" Text="Convert" OnClick="btnConvert_Click" />
            <br />
            <br />
            <asp:Label ID="lblResult" runat="server" Text="" ForeColor="Green" />
            <asp:Label ID="lblError" runat="server" Text="" ForeColor="Red" />
        </div>
    </form>
</body>
</html>
