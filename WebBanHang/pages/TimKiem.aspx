<%@ Page Title="" Language="C#" MasterPageFile="~/Master_page.Master" AutoEventWireup="true" CodeBehind="TimKiem.aspx.cs" Inherits="WebBanHang.pages.component.TimKiem" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../style/TimKiem.css" rel="Stylesheet" type="text/css" /> 
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
     <asp:placeholder id="False_Result" runat="server" visible="false">
         <section class="error_container">
         <div class="error_mess">
             <h4><i class="fa-solid fa-box-open"></i></h4>
             <br />
             <h4>Không tìm thấy sản phẩm </h4>
         </div>
         </section>
         </asp:placeholder>
        
    <asp:placeholder id="True_Result" runat="server" >
    <div id="layout_timkiem">
        <div class="tool_timkiem">

        </div>
        <section>
        <div class="result_timkiem">
            <asp:DataList ID="dl_result" CssClass="result_content" runat="server">
                <ItemTemplate>
                <div class="card">
                        <a href="ChiTiet.aspx?masp=<%# Eval("MASP") %>">
                            <img src="../img/sanpham/<%# Eval("HINHANH") %>" alt="Avatar">
                            <div class="container">
                                <h4><b title="<%# Eval("TENSP") %>"><%# Eval("TENSP") %></b></h4>
                                <p>Giá: <%# Eval("DONGIA") %> VNĐ</p>
                            </div>
                        </a>
                   </div>
                    </ItemTemplate>
            </asp:DataList>
        </div>
            </section>
    </div>
        </asp:placeholder>



</asp:Content>
