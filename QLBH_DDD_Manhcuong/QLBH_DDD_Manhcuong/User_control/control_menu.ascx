<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="control_menu.ascx.cs" Inherits="QLBH_DDD_Manhcuong.User_control.control_menu" %>
<style type="text/css">

    .auto-style1 {
        text-align: center;
    }
</style>

<table style="width: 100%;">
    <tr>
        <td class="auto-style1">
            <asp:HyperLink ID="Main" runat="server" NavigateUrl="~/User_control/Home.aspx">Trang chủ</asp:HyperLink>
            &nbsp;||
            <asp:HyperLink ID="Signup" runat="server" NavigateUrl="~/User_control/resign.aspx">Đăng ký</asp:HyperLink>
            &nbsp;||<asp:HyperLink ID="Login" runat="server" NavigateUrl="~/User_control/login.aspx">Đăng nhập</asp:HyperLink>
            &nbsp;||<asp:HyperLink ID="Contact" runat="server">Liên hệ</asp:HyperLink>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblthongbao" runat="server"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnthoat" runat="server" Height="29px" OnClick="btnthoat_Click" Text="Thoát" />
        </td>
    </tr>
</table>
<p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</p>

