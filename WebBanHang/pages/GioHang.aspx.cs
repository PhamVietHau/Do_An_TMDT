using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace WebBanHang.pages
{
    public partial class GioHang : System.Web.UI.Page
    {
        LopKetNoi kn = new LopKetNoi();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;
            string makh = Session["ma_khachhang"] + "";
            string query_giohang = "select *, g.SOLUONG*s.DONGIA as THANHTIEN from GIOHANG g, KHACHHANG k, SANPHAM s " +
                "where g.MAKH = k.MAKH and s.MASP = g.MASP and g.MAKH = '"+makh+"'";
            string query_tong = "select SUM(s.DONGIA*g.SOLUONG) as THANHTIEN  from GIOHANG g, KHACHHANG k, SANPHAM s " +
                "where g.MAKH = k.MAKH and s.MASP = g.MASP and g.MAKH = '"+makh+"'";
            float tongtien = (float)kn.layCot_float(query_tong);
                Total.Text = ""+ tongtien;
            dl_giohang.DataSource = kn.layDL(query_giohang);
                dl_giohang.DataBind();
                
          
            
            

        }

        protected void deleteBtn_Click(object sender, EventArgs e)
        {
            string makh = Session["ma_khachhang"] + "";
            string masp = ((Button)sender).CommandArgument;
            Button btn = (Button)sender;
            string query_delete = "delete from GIOHANG where MAKH = '" + makh + "' and MASP = '" + masp + "'";
            int kq = kn.capnhat(query_delete);
            string query_giohang = "select *, g.SOLUONG*s.DONGIA as THANHTIEN from GIOHANG g, KHACHHANG k, SANPHAM s " +
                "where g.MAKH = k.MAKH and s.MASP = g.MASP and g.MAKH = '" + makh + "'";
            dl_giohang.DataSource = kn.layDL(query_giohang);
            dl_giohang.DataBind();

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {

        }
    }
}