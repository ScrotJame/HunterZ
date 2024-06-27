using Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class HH_Bll
    {
        DataService dt_sr = new DataService();
        public List<Hanghoa> laytatca()
        {
            string sql = "select * from TT_hanghoa";
            DataTable Dt = dt_sr.getData(sql);
            List<Hanghoa> Us_Ls = new List<Hanghoa>();
            foreach (DataRow r in Dt.Rows)
            {
                Hanghoa Us = new Hanghoa();
                Us.ma_hang = (string)r[0];
                Us.ma_mathang = (string)r[1];
                Us.tenhang = (string)r[2];
                Us.hangsx = (string)r[3];
                Us.giaban = (int)r[4];
                Us.baohanh = (string)r[5];
                Us.Ha = (string)r[6];
                Us_Ls.Add(Us);
            }
            return Us_Ls;


        }
        public void ADD(int ID, string Ten, string ten, string hang, int gia, string han, string anh)
        {
            string sql = "insert into  TT_hanghoa values( @Ma_hang, @Ma_mathang, @Tenhang, @HangSx, @Giaban, @Hanbaohanh, @Hinh_anh)";
            SqlParameter para_A = new SqlParameter("Ma_hang", ID);
            SqlParameter para_B = new SqlParameter("Ma_mathang", Ten);
            SqlParameter para_C = new SqlParameter("Tenhang", ten);
            SqlParameter para_D = new SqlParameter("HangSx", hang);
            SqlParameter para_E = new SqlParameter("Giaban", gia);
            SqlParameter para_F = new SqlParameter("Hanbaohanh", han);
            SqlParameter para_G = new SqlParameter("Hinh_anh", anh);
            dt_sr.UpdateData(sql, para_A, para_B, para_C, para_D, para_E, para_F,para_G);
        }
    }
}
