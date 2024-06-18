<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamMainMenu.aspx.cs" Inherits="TeamMainMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div> <h1> Keyboard Warriors </h1> </div>
            <div> 
            <h3 style="height: 321px">
                Main Menu 
                <asp:Button ID="btnStaff" runat="server" style="z-index: 1; left: 201px; top: 344px; position: absolute" Text="Staff" />
                <asp:Button ID="btnOrders" runat="server" style="z-index: 1; left: 169px; top: 225px; position: absolute" Text="Orders" />
                <asp:Button ID="btnSuppliers" runat="server" OnClick="btnSuppliers_Click" style="z-index: 1; left: 419px; top: 228px; position: absolute" Text="Suppliers" />
                <asp:Button ID="btnCustomers" runat="server" style="z-index: 1; left: 407px; top: 346px; position: absolute" Text="Customers" />
            </h3>
            </div>
        </div>
    </form>
</body>
</html>
