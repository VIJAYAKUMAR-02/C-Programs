<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Training.aspx.cs" Inherits="WebApplication2.Training" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Temprature Converter</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Temprature Converter</h2>
            <label>Enter Temprature :</label>
            <asp:TextBox runat="server" placeholder="Enter the value" ID="text_Box"></asp:TextBox><br/>
            <br />
            <label>Convert to:</label>
            <asp:RadioButtonList runat="server" ID="radio_btn">
                <asp:ListItem>Celcius</asp:ListItem>
                <asp:ListItem>feran</asp:ListItem>
            </asp:RadioButtonList><br />
            <asp:Button text="Convert" OnClick="Unnamed_Click" runat="server"/>
            <asp:Label runat="server" Text="" ID="result_Lbl"></asp:Label>
        </div>
    </form>
</body>
</html>
