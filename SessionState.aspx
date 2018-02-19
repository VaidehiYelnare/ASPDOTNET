<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SessionState.aspx.cs" Inherits="SessionExample.SessionState" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Asp.net Session State Example in C#, VB.NET</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <table>
<tr>
<td>FirstName:</td><td><asp:TextBox ID="txtfName" runat="server"/></td>
</tr>
<tr>
<td>LastName:</td><td><asp:TextBox ID="txtlName" runat="server"/></td>
</tr>
<tr><td></td><td> <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" /></td></tr>
</table>
    </div>
    </form>
</body>
</html>