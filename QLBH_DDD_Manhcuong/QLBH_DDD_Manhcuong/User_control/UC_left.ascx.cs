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
    public partial class UC_left : System.Web.UI.UserControl
    {
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        string sql1 = "select * from TT_mathang";
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["qlDuan1"].ToString());
            try
            {
                con.Open();
                SqlDataAdapter DA = new SqlDataAdapter(sql1, con);
                DA.Fill(dt);
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
                con.Close();
                da.Dispose();
                dt.Dispose();
                }
        }

        protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}