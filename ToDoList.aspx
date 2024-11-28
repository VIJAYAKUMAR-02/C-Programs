<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ToDoList.aspx.cs" Inherits="WebApplication2.ToDoList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Simple To-Do List</title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Simple To-Do List</h2>
        <asp:TextBox ID="txtTask" runat="server" Placeholder="Enter task"></asp:TextBox>
        <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
        <asp:Button ID="btnRemoveAll" runat="server" Text="Remove All" OnClick="btnRemoveAll_Click" />
        <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
        <hr />
        <asp:ListBox ID="lstTasks" runat="server" SelectionMode="Multiple" style="width:30%;height:100px"></asp:ListBox>
        <br />
        <asp:Button ID="btnDelete" runat="server" Text="Delete Selected" OnClick="btnDelete_Click" />
    </form>
</body>
</html>
