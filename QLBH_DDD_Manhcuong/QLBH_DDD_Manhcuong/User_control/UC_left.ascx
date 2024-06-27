<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UC_left.ascx.cs" Inherits="QLBH_DDD_Manhcuong.User_control.UC_left" %>
<asp:DataList ID="DataList1" runat="server" OnSelectedIndexChanged="DataList1_SelectedIndexChanged">
    <ItemTemplate>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# "theomathang.aspx?Ma_mathang="+Eval("Ma_mathang") %>' Text='<%# Eval("Ten_mathang") %>'></asp:HyperLink>
    </ItemTemplate>
</asp:DataList>
<asp:Label ID="lblthongbao" runat="server"></asp:Label>

