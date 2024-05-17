using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace WebBanHang.pages
{
    public partial class ChiTiet : System.Web.UI.Page
    {
        LopKetNoi kn = new LopKetNoi();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;
            string masp = Request.QueryString["maSP"] + "";
            string sp = "";
            if (masp != "")
            {
                sp = "select * from SANPHAM where MASP ='" + masp + "'";
                dl_detail.DataSource = kn.layDL(sp);
                dl_detail.DataBind();
            }
        }

        protected void btnMua_Click(object sender, EventArgs e)
        {
            string user_name = Session["User_name"] + "";// username
            


            if (user_name != "")
            {
                string masp = ((Button)sender).CommandArgument;//MASP
                Button btn = (Button)sender;
                DataListItem list_item = (DataListItem)btn.Parent;
                TextBox txt_sl = (TextBox)list_item.FindControl("Soluong");
                string matk = Session["ma_taikhoan"] + "";
                string makh = Session["ma_khachhang"] + "";
                string soluong = txt_sl.Text;
                int amount = int.Parse(soluong);
                string query_check = "select * from GIOHANG where MAKH ='" + makh+"' and MASP ='"+masp+"'";
                string query_all = "select * from GIOHANG ";
                DataTable dt = kn.layDL(query_check);
                DataTable id_increase = kn.layDL(query_all);
                int id = id_increase.Rows.Count + 1;
                string active="";
                
             
                if(amount>0)
                if (dt.Rows.Count>0 && query_check!=null)
                {
                    
                    //update
                    active = "update GIOHANG set SOLUONG =SOLUONG +" + soluong 
                        + " where MAKH='"+makh+"' and MASP ='"+masp+"'";
                    
                }
                else
                {
                    //insert
                    active = "insert into GIOHANG values("+id+",'"+makh+"','"+masp+"',"+soluong+")";
                }
                
                if (amount > 0 )
                {
                    int kq = kn.capnhat(active);
                    if (kq > 0) lb_thongbao.Text = "Thêm vào giỏ hàng thành công";
                    else lb_thongbao.Text = "Không thêm vào giỏ hàng được !";
                }
                else
                {
                    lb_thongbao.Text = "Số lượng phải lớn hơn 0";
                }
                    
                



            }
            else
            {
                lb_thongbao.Text = "Phải đăng nhập";
            }



        }
    }
    
}