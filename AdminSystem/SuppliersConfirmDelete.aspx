<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SuppliersConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblConfirmDelete" runat="server" style="z-index: 1; left: 450px; top: 395px; position: absolute" Text="Are you sure you want to delete this record?"></asp:Label>
        </p>
         <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 568px; top: 555px; position: absolute; height: 59px; width: 92px;" Text="Yes" />
         <asp:Button ID="btnNo" runat="server" style="z-index: 1; left: 783px; top: 555px; position: absolute; height: 58px; width: 98px;" Text="No" OnClick="btnNo_Click" />
    </form>
</body>
</html>
