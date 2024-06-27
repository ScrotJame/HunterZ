<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="QLBH_DDD_Manhcuong.Admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <div>
        </div>
        <asp:GridView ID="grv_quyen" runat="server">
        </asp:GridView>
        <hr />
        <br />
        <asp:GridView ID="grv_Us" runat="server">
        </asp:GridView>
        <hr />
        <asp:GridView ID="grv_Hang" runat="server">
        </asp:GridView>
        <hr />
        <asp:GridView ID="grv_Hanghoa" runat="server">
        </asp:GridView>
        <hr />
        <asp:GridView ID="grv_Hoadon" runat="server">
        </asp:GridView>
        <hr />
        <asp:GridView ID="grv_Mathang" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
