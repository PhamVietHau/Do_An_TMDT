using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebBanHang.pages
{
    public partial class Default : System.Web.UI.Page
    {
        LopKetNoi kn = new LopKetNoi();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;
            //ÁO
            string query_ao = "";
            query_ao = "select top 5 *  from SANPHAM s, NHOMSP n,  LOAISP l where s.MANHOM = n.MANHOM and n.MALOAI = l.MALOAI and n.MALOAI = 'L01'";
            ds_sanpham.DataSource= kn.layDL(query_ao);
            ds_sanpham.DataBind();
            //DANH MỤC SẢN PHẨM
            string query_dm = "";
            query_dm = "select  * from NHOMSP";
            dl_dm.DataSource = kn.layDL(query_dm);
            dl_dm.DataBind();
            //QUẦN
            string query_quan = "";
            query_quan = "select top 5 *  from SANPHAM s, NHOMSP n,  LOAISP l where s.MANHOM = n.MANHOM and n.MALOAI = l.MALOAI and n.MALOAI = 'L02'";
            dl_quan.DataSource = kn.layDL(query_quan);
            dl_quan.DataBind();
        }
    }
}