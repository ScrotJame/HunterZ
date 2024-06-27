<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="kqtimkiem.aspx.cs" Inherits="QLBH_DDD_Manhcuong.User_control.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DataList ID="DataList1" runat="server" OnSelectedIndexChanged="DataList1_SelectedIndexChanged">
    <ItemTemplate>
        <table style="width: 100%;">
            <tr>
                <td class="auto-style7" rowspan="2">
                    <asp:Image ID="Image1" runat="server" ImageUrl='<%# "~/Image/"+Eval("Hinh_anh") %>' />
                </td>
                <td class="auto-style6">
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# "chitietmt.aspx?mahang="+Eval("Ma_hang") %>' Text='<%# Eval("Tenhang") %>'></asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">Đơn giá:<br />
                    <asp:Label ID="label1" runat="server" Text='<%# Eval("Giaban","{0:#,##0}VND") %>'></asp:Label>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style7">
                    <asp:Button ID="selectbtn" runat="server" Text="Chọn Mua " />
                </td>
            </tr>
        </table>
    </ItemTemplate>
</asp:DataList>
<asp:Label ID="lblthongbao" runat="server"></asp:Label>
</asp:Content>
