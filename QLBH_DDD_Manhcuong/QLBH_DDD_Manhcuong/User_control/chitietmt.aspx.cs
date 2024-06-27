using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QLBH_DDD_Manhcuong.User_control
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string maHang = Request.QueryString["mahang"];

            if (!string.IsNullOrEmpty(maHang))
            {
                string connectionString = ConfigurationManager.ConnectionStrings["qlDuan1"].ToString();
                string query = "SELECT Tenhang, Giaban FROM TT_hanghoa WHERE Ma_hang = @MaHang";
                using (SqlConnection con = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@MaHang", maHang);
                    try
                    {
                        con.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            string tenHang = reader["Tenhang"].ToString();
                            decimal giaBan = Convert.ToDecimal(reader["Giaban"]);
                            tenhangtxt.Text = tenHang;
                            Giatxt.Text = giaBan.ToString("C");
                        }
                        else
                        {
                            tenhangtxt.Text = "Không tìm thấy sản phẩm.";
                        }
                    }
                    catch (Exception ex)
                    {
                        tenhangtxt.Text = "Lỗi: " + ex.Message;
                    }
                }
            }
            else
            {
                tenhangtxt.Text = "Không có mã sản phẩm được chỉ định.";
            }
        }
    }
}