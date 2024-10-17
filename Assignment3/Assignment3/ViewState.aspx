<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewState.aspx.cs" Inherits="Assignment3.ViewState" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtCount" runat="server" />
            <asp:Button ID="btnClick" runat="server" Text="Click" OnClick="btnClick_Click" />
        </div>
    </form>
</body>
</html>
