using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

namespace QLBH_DDD_Manhcuong.User_control
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        SqlDataAdapter _adapter = new SqlDataAdapter();
        DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            string tenhang = Session["Tenhang"].ToString();
            string tenmathang = Session["HangSx"].ToString();
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["qlDuan1"].ToString());
            string sql1 = "select * from TT_hanghoa where Tenhang like N'%" + tenhang + "%' and HangSx like N'%" + tenmathang + "%'";
            try
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql1, con);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    DataList1.DataSource = dt;
                    DataList1.DataBind();
                }
                else
                {
                    lblthongbao.Text = "Khong co du lieu";
                }
            }
            catch (Exception ex)
            {
                lblthongbao.Text = "Loi" + ex.Message;
            }
            finally
            {
                con.Close(); _adapter.Dispose(); dt.Dispose();
            }
        }

        protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}