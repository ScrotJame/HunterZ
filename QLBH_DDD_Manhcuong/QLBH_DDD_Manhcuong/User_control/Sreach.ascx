<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Sreach.ascx.cs" Inherits="QLBH_DDD_Manhcuong.User_control.Sreach" %>
<style type="text/css">

    .auto-style3 {
        width: 22%;
        height: 15px;
    }
    .auto-style1 {
        text-align: center;
    }
    .auto-style4 {
        width: 126px;
    }
    .auto-style2 {
        text-align: right;
    }
    </style>

<table class="auto-style3">
    <tr>
        <td class="auto-style1" colspan="2">Tìm kiếm</td>
    </tr>
    <tr>
        <td class="auto-style4">Tên hàng</td>
        <td>
            <asp:TextBox ID="Productbox" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style4">Thương hiệu</td>
        <td>
            <asp:TextBox ID="Trademarkbox" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style2" colspan="2">
            <asp:Button ID="Sreachbtn" runat="server" OnClick="Sreachbtn_Click" style="height: 29px" Text="Tìm kiếm" />
        </td>
    </tr>
</table>

