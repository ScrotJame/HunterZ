using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QLBH_DDD_Manhcuong.User_control
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void loginbtn_Click(object sender, EventArgs e)
        {
            string sql = "select * from Acc where Username='" + UnameBox.Text + "' and Pass='" + PassBox.Text + "'";
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["qlDuan1"].ToString());
            try
            {
                conn.Open();
                String User, Pass;
                User = UnameBox.Text;
                Pass = PassBox.Text;
                SqlDataAdapter _da = new SqlDataAdapter(sql, conn);
                _da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    Session["Ma_khach"] = UnameBox.Text;
                    Response.Redirect("dangnhapthanhcong.aspx");
                }
                else
                {
                    lblthongbao.Text = "Tai khoan haoc mat khau khong dung";
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}