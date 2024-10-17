<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Session.aspx.cs" Inherits="Assignment3.Session" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
    <tr>
        <td>First Name: </td>
        <td>
            <asp:TextBox ID="txtFName" runat="server" />
        </td>
    </tr>
    <tr>
        <td>Last Name: </td>
        <td>
            <asp:TextBox ID="txtLName" runat="server" />
        </td>
    </tr>
    <tr>
        <td>Gender</td>
        <td>
            <asp:RadioButton ID="rbMale" runat="server" Text="Male" />
            <asp:RadioButton ID="rbFeMale" runat="server" Text="FeMale" />
        </td>
    </tr>   
    <tr>
        <td>City: </td>
        <td>
            <asp:DropDownList ID="ddCity" runat="server" ValidationGroup="city">
                <asp:ListItem Text="Ahmedabad" Value="ahmedabad" />
                <asp:ListItem Text="Khambhat" Value="Khambhat" />
                <asp:ListItem Text="Baroda" Value="Baroda" />
                <asp:ListItem Text="Nadiad" Value="Nadiad" />
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td colspan="2">
            <asp:Button ID="btnSubmit" Text="Submit" runat="server" OnClick="btnSubmit_Click" />
        </td>
    </tr>
</table>
        </div>
    </form>
</body>
</html>
