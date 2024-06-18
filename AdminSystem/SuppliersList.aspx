<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SuppliersList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstSuppliersList" runat="server" Height="598px" Width="784px"></asp:ListBox>
        
        <p>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 146px; top: 667px; position: absolute" Text="Add" />
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 360px; top: 667px; position: absolute; right: 1234px;" Text="Edit" height="48px" width="70px" />
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 556px; top: 667px; position: absolute; width: 98px;" Text="Delete" height="48px" />
        </p>
        <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" style="z-index: 1; left: 182px; top: 807px; position: absolute" Text="Apply Filter" />
        <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" style="z-index: 1; left: 520px; top: 807px; position: absolute" Text="Clear Filter" height="48px" width="207px" />
        <asp:Button ID="btnStatisticsPage" runat="server" OnClick="btnStatisticsPage_Click" style="z-index: 1; left: 1028px; top: 636px; position: absolute" Text="Statistics Page" />
        <asp:Button ID="lblReturnToMainMenu" runat="server" style="z-index: 1; left: 979px; top: 793px; position: absolute; width: 308px" Text="Return To Main Menu" OnClick="lblReturnToMainMenu_Click" />
        <p id="EnterSupplierName">
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 138px; top: 874px; position: absolute" Text="lblError"></asp:Label>
            <asp:Label ID="lblEnterSupplierName" runat="server" style="z-index: 1; left: 108px; top: 749px; position: absolute" Text="Enter a Supplier Name"></asp:Label>
            <asp:TextBox ID="txtEnterSupplierName" runat="server" style="z-index: 1; left: 446px; top: 751px; position: absolute; width: 347px"></asp:TextBox>
        </p>
    </form>
</body>
</html>
