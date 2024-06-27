using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business;
using Data;
namespace QLBH_DDD_Manhcuong
{
    public partial class Admin : System.Web.UI.Page
    {
        Acc_Bll acc_Bll = new Acc_Bll();
        KH_Bll kH_Bll = new KH_Bll();
        Hang_Bll Hang_Bll = new Hang_Bll();
        HH_Bll HH_Bll = new HH_Bll();
        Hoadon_Bll Hoadon_Bll= new Hoadon_Bll();
        Mathanh_Bll Mathanh_Bll = new Mathanh_Bll();
        protected void Page_Load(object sender, EventArgs e)
        {
            grv_quyen.DataSource = acc_Bll.laytatca();
            grv_quyen.DataBind();

            grv_Us.DataSource = kH_Bll.laytatca();
            grv_Us.DataBind();

            grv_Hang.DataSource=Hang_Bll.laytatca();
            grv_Hang.DataBind();

            grv_Hanghoa.DataSource= HH_Bll.laytatca();
            grv_Hanghoa.DataBind();

            grv_Mathang.DataSource= Mathanh_Bll.laytatca();
            grv_Mathang.DataBind();

            grv_Hoadon.DataSource = Hoadon_Bll.laytatca();
            grv_Hoadon.DataBind();
        }
    }
}