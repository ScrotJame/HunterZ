<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="resign.aspx.cs" Inherits="QLBH_DDD_Manhcuong.User_control.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">

        .auto-style8 {
            text-align: center;
        }
        .auto-style7 {
            text-align: left;
            width: 167px;
        }
        .auto-style6 {
            text-align: left;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width:100%;">
        <tr>
            <td class="auto-style8" colspan="2"><strong>ĐĂNG KÝ THÔNG TIN KHÁCH HÀNG</strong></td>
        </tr>
        <tr>
            <td class="auto-style7">Tên đăng nhập:</td>
            <td class="auto-style6">
                <asp:TextBox ID="Unametxt" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="Unamerv" runat="server" ControlToValidate="Unametxt" ErrorMessage="Tên đăng nhập không được để trống"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">Mật khẩu:</td>
            <td class="auto-style6">
                <asp:TextBox ID="passtxt" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="Passrv" runat="server" ControlToValidate="passtxt" ErrorMessage="Mật khẩu không được để trống"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">Nhập lại mật khẩu:</td>
            <td class="auto-style6">
                <asp:TextBox ID="Repasstxt" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">Email:</td>
            <td class="auto-style6">
                <asp:TextBox ID="emailtxt" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="Emailrv" runat="server" ControlToValidate="emailtxt" ErrorMessage="Email chưa nhập"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">
                <asp:Label ID="lblthongbao" runat="server" Text="Label"></asp:Label>
                <asp:BulletedList ID="lbl" runat="server">
                </asp:BulletedList>
            </td>
            <td class="auto-style6">
                <asp:Button ID="signupbtn" runat="server" OnClick="signupbtn_Click" Text="Đăng Ký" />
            </td>
        </tr>
    </table>
</asp:Content>
