using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QLBH_DDD_Manhcuong.User_control
{
    public partial class Sreach : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Sreachbtn_Click(object sender, EventArgs e)
        {
            Session["Tenhang"] = Productbox.Text;
            Session["HangSx"] = Trademarkbox.Text;
            Response.Redirect("~/User_control/kqtimkiem.aspx");
        }
    }
}