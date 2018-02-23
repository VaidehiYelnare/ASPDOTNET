<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="LinqQueryDemo.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" AutoGenerateColumns ="false">
         <Columns>
            <asp:BoundField DataField="ID" HeaderText="ID"/>
            <asp:BoundField DataField="FirstName" HeaderText="FirstName"/>
            <asp:BoundField DataField="LastName" HeaderText="LastName"/>
            <asp:BoundField DataField="Gender" HeaderText="Gender"/>
            <asp:BoundField DataField="DeptID" HeaderText="DeptID"/>
            <asp:BoundField DataField="Salary" HeaderText="Salary"/>
         </Columns>
        </asp:GridView>
    
        <br />
    
    </div>
        <asp:Button ID="btnShow" runat="server" OnClick="btnShow_Click" Text="Show" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnInsert" runat="server" OnClick="btnInsert_Click" Text="Insert" />
&nbsp;&nbsp;
        <asp:Button ID="btnUpdate" runat="server" OnClick="btnUpdate_Click" Text="Update" />
    &nbsp;&nbsp;
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
    </form>
</body>
</html>
