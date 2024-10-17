<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HiddenField.aspx.cs" Inherits="Assignment3.HiddenField" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enter Name:  <asp:TextBox ID="txtName" runat="server" TextMode="SingleLine" /> <br />
            Enter Password: <asp:TextBox ID="txtPsw" runat="server" TextMode="Password" /> <br />

            <asp:HiddenField ID="hdName" runat="server" />
            <asp:HiddenField ID="hdPsw" runat="server" />

            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" /> 
        </div>
    </form>
</body>
</html>
