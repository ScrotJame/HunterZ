using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QLBH_DDD_Manhcuong.User_control
{
    public partial class WebForm2 : System.Web.UI.Page
    {

        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void signupbtn_Click(object sender, EventArgs e)
        {
            string sql1 = "select * from Acc where Username='" + Unametxt.Text + "'";
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["qlDuan1"].ToString());
            try
            {
                conn.Open();
                String User, Pass, Email;
                User = Unametxt.Text; Pass = passtxt.Text; Email = emailtxt.Text;
                string sql2 = " insert into Acc(Username, Pass, Email) values ('" + User + "','" + Pass + "','" + Email + "')";
                SqlDataAdapter _da = new SqlDataAdapter(sql1, conn);

                _da.Fill(dt);
                SqlCommand cmd = new SqlCommand(sql2);
                cmd.Connection = conn;
                if (dt.Rows.Count > 0)
                {
                    lblthongbao.Text = "Ten dang nhap nay da ton tai";
                    Unametxt.Focus();
                }
                else
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        lblthongbao.Text = "Dang ky thanh cong";
                    }
                }
            }
            catch (Exception ex)
            {
                lblthongbao.Text = "loi" + ex.Message;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}