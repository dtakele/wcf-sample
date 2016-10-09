<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WCFSelfHostClient.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        a:
        <asp:TextBox runat="server" ID="txta" />
        <br />
        b:
        <asp:TextBox runat="server" ID="txtb" />
        <br />
        <asp:Button runat="server" ID="btnAdd" OnClick="btnAdd_Click" Text="Add" /><br />
        <asp:Label runat="server" ID="lblResult" />

    </form>
</body>
</html>
