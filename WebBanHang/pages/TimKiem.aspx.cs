using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace WebBanHang.pages.component
{
    public partial class TimKiem : System.Web.UI.Page
    {
        LopKetNoi kn = new LopKetNoi();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;
            string mn = Request.QueryString["mn"]+"";
            string ml = Request.QueryString["ml"] + "";
            string inp_timkiem = Request.QueryString["input"] + "";
            string result = "";
            if (mn != "")
            {
                //Nếu tìm mà không có thì trả về thông báo
                result = "select * from SANPHAM where MANHOM='" + mn + "'";
                DataTable nhomsp = kn.layDL(result);
                if (nhomsp.Rows.Count > 0)
                {
                    dl_result.DataSource = kn.layDL(result);
                    dl_result.DataBind();
                }
                else
                {
                    False_Result.Visible = true;
                    True_Result.Visible = false;
                }
                
            }else if(ml != "")
            {
                //Bấm vào quần hoặc áo
                result = "select * from SANPHAM s, NHOMSP n, LOAISP l where s.MANHOM = n.MANHOM and l.MALOAI=n.MALOAI and l.MALOAI='"+ml+"'";
                DataTable loaisp = kn.layDL(result);
                if (loaisp.Rows.Count > 0)
                {
                    dl_result.DataSource = kn.layDL(result);
                    dl_result.DataBind();
                }
                else
                {
                    False_Result.Visible = true;
                    True_Result.Visible = false;
                }
               
            }
            else if(inp_timkiem != "")
            {
                //Tìm kiếm dựa vào input
                result = "SELECT * FROM SANPHAM WHERE  TENSP  COLLATE SQL_Latin1_General_CP1_CI_AI like ('%"+inp_timkiem+"%')";
                DataTable sp = kn.layDL(result);
                if (sp.Rows.Count > 0)
                {
                    dl_result.DataSource = kn.layDL(result);
                    dl_result.DataBind();
                }
                else
                {
                    False_Result.Visible = true;
                    True_Result.Visible = false;
                }
                
                
            }
            



        }
    }
}