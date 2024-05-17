<%@ Page Title="" Language="C#" MasterPageFile="~/Master_page.Master" AutoEventWireup="true" CodeBehind="GioHang.aspx.cs" Inherits="WebBanHang.pages.GioHang" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../style/GioHang.css" rel="Stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section>
        
        <div class="cart_container">


            <div class="cart_content">
                <asp:DataList ID="dl_giohang" runat="server"  >
                    <ItemTemplate>
                        <table style="width: 100%;" class="border_bot">
                            <tr >
                                <td><asp:Button ID="deleteBtn" runat="server" OnClick="deleteBtn_Click" CommandArgument='<%# Eval("MASP") %>' CssClass="fa-solid fa-xmark delete_btn" Text="X"/></td>
                                <td class="img_content"> <img src="../img/sanpham/<%# Eval("HINHANH")%>" alt="Alternate Text" /></td>
                                <td class="ten_sp"><b><a href="ChiTiet.aspx?maSP=<%# Eval("TENSP")%>"><%# Eval("TENSP")%></a></b></td>
                                <td><b><%# Eval("DONGIA")%></b> VNĐ</td>
                                <td>

                                    <asp:TextBox ID="Soluong" CssClass="soluong" runat="server"  TextMode="Number" 
                                    Text='<%# Eval("SOLUONG")%>'></asp:TextBox>

                                </td>
                                <td><i class="fa-solid fa-equals"></i> <b><%# Eval("THANHTIEN")%></b> VNĐ</td>
                            </tr>
                        </table>
                    </ItemTemplate>
                </asp:DataList>
                <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
            </div>
            
            <div class="checkout_content">
                <h2>Tiền của giỏ hàng</h2>
                <div class="toltal_container">
                    <table>
                        <tr>
                            <td><b>Tổng tiền</b></td>
                            <td class=" total"><b><asp:Label ID="Total" runat="server" Text="0" ></asp:Label>VNĐ</b></td>
                        </tr>
                        
                    </table>
                </div>

                <div class="btn_checkout">
                    <asp:LinkButton ID="LinkButton1" CssClass="a" runat="server" OnClick="LinkButton1_Click">THANH TOÁN</asp:LinkButton>
                </div>
            </div>

        </div>
    </section>
</asp:Content>
