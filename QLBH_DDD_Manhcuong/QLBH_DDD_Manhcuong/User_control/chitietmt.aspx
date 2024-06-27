<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="chitietmt.aspx.cs" Inherits="QLBH_DDD_Manhcuong.User_control.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">

        .auto-style6 {
            text-align: center;
        }
        .auto-style7 {
            text-align: left;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width: 100%;">
        <tr>
            <td class="auto-style6" colspan="2">Thông tin sản phẩm</td>
        </tr>
        <tr>
            <td class="auto-style6" rowspan="2">
                <asp:Image ID="Image1" runat="server" />
            </td>
            <td class="auto-style7">Tên hàng:<asp:Label ID="tenhangtxt" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">Giá bán:<asp:Label ID="Giatxt" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
