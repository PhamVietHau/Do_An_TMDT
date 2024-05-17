<%@ Page Title="" Language="C#" MasterPageFile="~/Master_page.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebBanHang.pages.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../style/Default.css" rel="Stylesheet" type="text/css" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <slide>
        <div class="slide">
            <img src="../img/trangchu/slider_3.jpg" />
        </div>
    </slide>
    <%--DANH SÁCH--%>
    <h3>DANH SÁCH SẢN PHẨM</h3>
    <section >
        <div class="container_sp">

            <asp:DataList ID="dl_dm" runat="server" >
                <ItemTemplate>
                   <div class="card">
                        <a href="TimKiem.aspx?mn=<%# Eval("MANHOM") %>">
                            <img src="../img/sanpham/<%# Eval("HINHANH") %>" alt="Avatar">
                            <div class="container">
                                <h4><b title="<%# Eval("TENNHOM") %>"><%# Eval("TENNHOM") %></b></h4>
                            </div>
                        </a>
                   </div>
                </ItemTemplate>


            </asp:DataList>


            
        </div>
    </section>


    <slide>
        <div class="slide">
            <img src="../img/trangchu/content_slide_1.jpg" />
        </div>
    </slide>
    <%--ÁO--%>
    <h3>ÁO</h3>
    <section>
        <div class="container_sp">
            <asp:DataList ID="ds_sanpham" runat="server">
                <ItemTemplate>
                    <div class="card">
                        <a href="ChiTiet.aspx?maSP=<%# Eval("MASP")%>">
                            <img src="../img/sanpham/<%# Eval("HINHANH") %>" alt="Avatar" />
                            <div class="container">
                                <h4><b title="<%# Eval("TENSP") %>"><%# Eval("TENSP") %></b></h4>
                                <p>Giá: <%# Eval("DONGIA") %> VNĐ</p>
                            </div>
                        </a>
                   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</div>
                </ItemTemplate>
            </asp:DataList>
            <div class="more"><a  href="TimKiem.aspx?ml=L01">XEM THÊM</a></div>
            
        </div>
         
    </section>
    <slide>
        <div class="content_slide">
            <div class="img_content1"><img  src="../img/trangchu/anh_content_5.jpg" /></div>
            <div><img  src="../img/trangchu/anh_content_1.jpg" /></div>
            <div><img  src="../img/trangchu/anh_content_2.jpg" /></div>
            <div><img  src="../img/trangchu/anh_content_3.jpg" /></div>
            <div><img  src="../img/trangchu/anh_content_4.jpg" /></div>
        </div>

    </slide>
    <%--QUẦN--%>
    <h3>QUẦN</h3>
    <section>
        <div class="container_sp">
            <asp:DataList ID="dl_quan" runat="server">
                <ItemTemplate>
                    <div class="card">
                        <a href="ChiTiet.aspx?maSP=<%# Eval("MASP")%>">
                            <img src="../img/sanpham/<%# Eval("HINHANH")%>" alt="Avatar">
                            <div class="container">
                                <h4><b title="<%# Eval("TENSP") %>"><%# Eval("TENSP") %></b></h4>
                                <p>Giá: <%# Eval("DONGIA") %> VNĐ</p>
                            </div>
                        </a>
                   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</div>
                </ItemTemplate>
            </asp:DataList>
            <div class="more"><a  href="TimKiem.aspx?ml=L02">XEM THÊM</a></div>
        </div>
         
    </section>

    <section class="section_tintuc">
        <h2>TIN TỨC THỜI TRANG</h2>
        <div class="tintuc">
            <div class="card_tt">
                <img src="../img/trangchu/tt_img.jpg" alt="" />
                <div class="xuhuong">
                <a href="#">Xu hướng thời trang</a></div><br />
                <b>Xu Hướng Thời Trang Nắm bắt top xu hướng các phong cách thời trang hot năm 2024</b>
                <div class="tt_body">
                    <p class="tt_text" >
                        Xem ngay các phong cách thời trang đang được ưa chuộng và dẫn đầu xu hướng trong năm 2024 và một số gợi ý.
                    </p>
                </div>
            </div>
            <div class="card_tt">
                <img src="../img/trangchu/tt_img2.jpg" alt="" />
                 <div class="xuhuong">
                <a href="#">Xu hướng thời trang</a></div><br />
                <b>Bí quyết phối đồ style Hàn Quốc dành cho nam trong mùa hè 2024</b>
               
                <div class="tt_body">
                    <p class="tt_text" >
                        Xem ngay các phong cách thời trang đang được ưa chuộng và dẫn đầu xu hướng trong năm 2024 và một số gợi ý.
                    </p>
                </div>
            </div>
            <div class="card_tt">
                <img src="../img/trangchu/tt_img3.jpg" alt="" />
                 <div class="xuhuong">
                <a href="#">Xu hướng thời trang</a></div><br />
                <b>Gợi ý các kiểu áo sơ mi nữ Hàn Quốc mà nàng nên có trong tủ đồ</b>
                
                <div class="tt_body">
                    <p class="tt_text" >
                        Xem ngay các phong cách thời trang đang được ưa chuộng và dẫn đầu xu hướng trong năm 2024 và một số gợi ý.
                    </p>
                </div>
            </div>
        </div>
    </section>


</asp:Content>
