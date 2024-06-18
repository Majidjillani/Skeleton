<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SuppliersDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 941px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblSupplierID" runat="server" style="z-index: 1; left: 443px; top: 120px; position: absolute" Text="Supplier ID"></asp:Label>
        <asp:Label ID="lblSupplierName" runat="server" style="z-index: 1; left: 443px; top: 189px; position: absolute" Text="Supplier Name"></asp:Label>
        <asp:Label ID="lblContactPhone" runat="server" style="z-index: 1; left: 443px; top: 269px; position: absolute" Text="Contact Phone"></asp:Label>
        <asp:Label ID="lblContactEmail" runat="server" style="z-index: 1; left: 443px; top: 342px; position: absolute" Text="Contact Email"></asp:Label>
        <asp:Label ID="lblContractStartDate" runat="server" style="z-index: 1; left: 443px; top: 416px; position: absolute" Text="Contract Start Date"></asp:Label>
        <asp:Label ID="lblContractEndDate" runat="server" style="z-index: 1; left: 443px; top: 494px; position: absolute" Text="Contract End Date"></asp:Label>
        <asp:TextBox ID="txtSupplierID" runat="server" style="z-index: 1; left: 784px; top: 119px; position: absolute; width: 347px"></asp:TextBox>
        <asp:TextBox ID="txtSupplierName" runat="server" style="z-index: 1; left: 784px; top: 178px; position: absolute; width: 347px"></asp:TextBox>
        <asp:TextBox ID="txtContactPhone" runat="server" style="z-index: 1; left: 784px; top: 263px; position: absolute; width: 347px"></asp:TextBox>
        <asp:TextBox ID="txtContactEmail" runat="server" style="z-index: 1; left: 784px; top: 344px; position: absolute; width: 347px"></asp:TextBox>
        <asp:TextBox ID="txtContractStartDate" runat="server" style="z-index: 1; left: 784px; top: 424px; position: absolute; width: 347px"></asp:TextBox>
        <asp:TextBox ID="txtContractEndDate" runat="server" style="z-index: 1; left: 784px; top: 494px; position: absolute; width: 347px"></asp:TextBox>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 298px; top: 692px; position: absolute" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 456px; top: 692px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
        <asp:Button ID="btnFind" runat="server" style="z-index: 1; left: 699px; top: 690px; position: absolute" Text="Find" OnClick="btnFind_Click" />
        <asp:Button ID="lblReturnToMainMenu" runat="server" style="z-index: 1; left: 971px; top: 699px; position: absolute; width: 308px" Text="Return To Main Menu" OnClick="lblReturnToMainMenu_Click" />
        <asp:CheckBox ID="chkIsActive" runat="server" style="z-index: 1; left: 459px; top: 582px; position: absolute" Text="Is Active" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 103px; top: 803px; position: absolute" Text="Label"></asp:Label>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
