using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QLBH_DDD_Manhcuong.User_control
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["qlDuan1"].ToString());
        SqlDataAdapter Da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            string maloai = Request.QueryString["Ma_mathang"];
            String sql = "select * from TT_hanghoa where Ma_mathang ='"+maloai+"'";
            
            try
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    DataList1.DataSource = dt;
                    DataList1.DataBind();
                }
                else
                {
                    lblthongbao.Text = "Khong Co Du Lieu";
                }

            }
            catch (Exception ex)
            {
                lblthongbao.Text = "Loi" + ex.Message;
            }
            finally { con.Close(); Da.Dispose(); dt.Dispose(); }
        }

        protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void selectbtn_Click(object sender, EventArgs e)
        {

        }
    }
}