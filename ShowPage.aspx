<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowPage.aspx.cs" Inherits="SessionExample.ShowPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <table>
<tr>
<td colspan="2">Welcome <b><asp:Label ID="lblString" runat="server"/></b></td>
</tr>
<tr>
<td>Your FirstName: </td><td><b><asp:Label ID="lblfName" runat="server"/></b></td>
</tr>
<tr>
<td>Your LastName </td><td><b><asp:Label ID="lbllName" runat="server"/></b></td>
</tr>
<tr><td></td><td> </td></tr>
</table>
    </div>
    </form>
</body>
</html>