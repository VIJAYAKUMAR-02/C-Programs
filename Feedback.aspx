<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Feedback.aspx.cs" Inherits="WebApplication2.Feedback" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Feedback real</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Feedback form</h2>
            <label>Name:</label>
            <asp:TextBox runat="server" ID="lbl_Text"></asp:TextBox><br /><br />

            <label>Gmail:</label>
            <asp:TextBox runat="server" ID="lbl_Gmail"></asp:TextBox><br />

            <label>Feedback:</label>
            <asp:TextBox runat="server" ID="TextBox2" Rows="4" Columns="40" TextMode="MultiLine"></asp:TextBox><br />

            <asp:Button runat="server" onclick="Unnamed_Click" Text="Submit"/>

            <h2>Feedbacks</h2>
            <asp:Label runat="server" Text="" ID="lbl_Feedback"></asp:Label>
        </div>
    </form>
</body>
</html>
