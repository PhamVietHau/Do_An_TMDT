using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Web.Security;

namespace WebBanHang
{
    public partial class Master_page : System.Web.UI.MasterPage
    {
        LopKetNoi kn = new LopKetNoi();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;
            if (Session["User_name"] != null)
            {
                Not_Login.Visible = false;
                Logged.Visible = true;
                string name = Session["User_name"]+"";
               
                user.Text =name;
                
                
            }
        }

        protected void timkiem_Click(object sender, EventArgs e)
        {
            string nhap = input.Text;
            Response.Redirect("TimKiem.aspx?input="+nhap);
        }



       
        //Đăng ký
        protected void RegistButton_Click(object sender, EventArgs e)
        {
            string username = UserName.Text;
            string password = Password.Text;
            string repeat_password = Repeat_Password.Text;

            string insert="";
            string matk="TK";
            string layMa = "select MATK from TAIKHOAN";
            string checkten = "select TENDN from TAIKHOAN where TENDN ='"+username+"'";
            DataTable count = kn.layDL(layMa);
            DataTable name = kn.layDL(checkten);
           
            //lấy được số hàng nhưng phải +1 mới lên!!
            int stt = count.Rows.Count+1;
            //mã tài khoản tăng dần theo số 
            if(stt<10)// VD: TK02, TK03
            matk = matk +"0"+ stt;
            else // VD: TK11, TK12
            matk = matk + stt;


            if (password == repeat_password && password!="" && username!="" && name.Rows.Count<1)
            {
                insert = "insert into TAIKHOAN values('"+matk+"','"+username +"','"+password+"')";
                int kq = kn.capnhat(insert);
                if(kq > 0){
                    lb_dk.Text = "Đăng ký thành công.";
                }
                else
                {
                    lb_dk.Text = "Đăng ký thất bại.\n"+ insert;
                }
            }
            else
            {
                lb_dk.Text = "Kiểm tra lại thông tin đã nhập";
            }
        }


        //đăng xuất
        protected void btnLogout_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();

            Session.Abandon();
            
            Response.Redirect("Default.aspx");
        }
        //Đăng nhập
        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            string username = Login1.UserName;
            string password = Login1.Password;
            //query lấy tài khoản
            string sql = "select * from TAIKHOAN where TENDN ='" + username + "' and MK ='" + password + "'";
            DataTable dt = kn.layDL(sql);
            //query lấy mã tài khoản
            string query_matk = "select MATK from TAIKHOAN where TENDN ='" + username + "' and MK ='" + password + "'";
            string query_makh = "select MAKH from KHACHHANG k, TAIKHOAN t where k.MATK = t.MATK and TENDN ='"+username+"'";
            
            if (dt != null && dt.Rows.Count > 0)
            {
                string matk = kn.layCot(query_matk);
                string makh = kn.layCot(query_makh);
                Session["User_name"] = username;
                Session["ma_taikhoan"] = matk;
                Session["ma_khachhang"] = makh;
                Response.Redirect("Default.aspx");
            }
            else
            {
                Login1.FailureText = "Sai tài khoản hoặc mật khẩu !";

            }
        }
    }
}