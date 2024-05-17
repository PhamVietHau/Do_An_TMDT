<%@ Page Title="" Language="C#" MasterPageFile="~/Master_page.Master" AutoEventWireup="true" CodeBehind="ChiTiet.aspx.cs" Inherits="WebBanHang.pages.ChiTiet" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../style/ChiTiet.css" rel="Stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <section>
        <asp:Label ID="lb_thongbao" CssClass="thongbao" runat="server" ForeColor="Red" Text="" ></asp:Label>
        <asp:DataList ID="dl_detail" runat="server">
            <ItemTemplate>
                <div class="container">
                    <div id="img_Content">
                        <img src="../img/sanpham/<%# Eval("HINHANH")%>" alt="" />
                    </div>
                    <div id="Detail_content">
                            <div><b class="product_name"><%# Eval("TENSP")%></b><br />
                            </div>
                            <div>
                                <p>Giá: 
                                <b class="product_price"><%# Eval("DONGIA")%> </b>VNĐ
                                    </p>
                            </div>
                            <div>
                                <p class="describe"><b>Mô tả:</b> <%# Eval("MOTA")%></p>
                            </div>
                            <div>
                                <p>Chọn số lượng: </p>
                            </div>
                            <div>
                                <asp:TextBox ID="Soluong" CssClass="amount" runat="server" Text="0" TextMode="Number"></asp:TextBox>
                                <asp:Button ID="btnMua" CssClass="btn_mua" runat="server" Text="Thêm vào giỏ hàng" OnClick="btnMua_Click" CommandArgument='<%# Eval("MASP") %>' />

                            </div>
                    </div>
                </div>
            </ItemTemplate>
        </asp:DataList>
        
    </section>

</asp:Content>

