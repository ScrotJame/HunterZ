<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="QLBH_DDD_Manhcuong.User_control.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">

        .auto-style8 {
            width: 46%;
        }
        .auto-style6 {
            text-align: center;
        }
        .auto-style7 {
            text-align: left;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style8">
        <tr>
            <td class="auto-style6" colspan="2"><strong>ĐĂNG NHẬP</strong></td>
        </tr>
        <tr>
            <td class="auto-style7">Tên đăng nhập</td>
            <td class="auto-style7">
                <asp:TextBox ID="UnameBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">Mật khẩu</td>
            <td class="auto-style7">
                <asp:TextBox ID="PassBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <table style="width:100%;">
                    <tr>
                        <td>
                            <asp:Button ID="loginbtn" runat="server" OnClick="loginbtn_Click" Text="Đăng nhập" />
                        </td>
                    </tr>
                </table>
            </td>
            <td>
                <asp:Label ID="lblthongbao" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
