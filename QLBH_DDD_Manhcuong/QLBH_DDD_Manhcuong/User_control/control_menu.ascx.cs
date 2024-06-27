using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QLBH_DDD_Manhcuong.User_control
{
    public partial class control_menu : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Ma_khach"] != null)
            {
                lblthongbao.Text = "Xin chao ban" + Session["Ma_khach"];
                btnthoat.Text = "Thoat";
            }
        }

        protected void btnthoat_Click(object sender, EventArgs e)
        {
            Session["Ma_khach"] = null;
            Response.Redirect("dangnhapthanhcong.aspx");
        }
    }
}