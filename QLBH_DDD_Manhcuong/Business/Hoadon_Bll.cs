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
    public class Hoadon_Bll
    {
        DataService dt_sr = new DataService();
        public List<Hoadon> laytatca()
        {
            string sql = "select * from TT_hoadon";
            DataTable Dt = dt_sr.getData(sql);
            List<Hoadon> Us_Ls = new List<Hoadon>();
            foreach (DataRow r in Dt.Rows)
            {
                Hoadon Us = new Hoadon();
                Us.ma_hoadon = (string)r[0];
                Us.tenhang = (string)r[2];
                Us.tenkhach = (string)r[1];
                Us.tongtien = (int)r[5];
                Us.soluong = (int)r[3];
                Us.ngaytao = (DateTime)r[4];
                Us_Ls.Add(Us);
            }
            return Us_Ls;


        }
        public void ADD(string A, DateTime B, string C, string D, int E, int F)
        {
            string sql = "insert into  TT_hoadon values( @Ma_hoadon, @Tenkhach, @Tenhang, @Soluong, @Ngaytao, @Tongtien)";
            SqlParameter para_A = new SqlParameter("Ma_hoadon", A);
            SqlParameter para_B = new SqlParameter("Tenkhach", C);
            SqlParameter para_C = new SqlParameter("Tenhang", D);
            SqlParameter para_D = new SqlParameter("Soluong",E);
            SqlParameter para_E = new SqlParameter("Ngaytao", B);
            SqlParameter para_F = new SqlParameter("Tongtien", F);
            dt_sr.UpdateData(sql, para_A, para_B, para_C, para_D, para_E, para_F);
        }
    }
}
