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
    public class Hang_Bll
    {
        DataService dt_sr = new DataService();
        public List<Hang> laytatca()
        {
            string sql = "select * from TT_hang";
            DataTable Dt = dt_sr.getData(sql);
            List<Hang> Us_Ls = new List<Hang>();
            foreach (DataRow r in Dt.Rows)
            {
                Hang Us = new Hang();
                Us.Xuatxu= (string)r[0];
                Us.HangSx = (string)r[1];
                Us_Ls.Add(Us);
            }
            return Us_Ls;


        }
        public void ADD( string A, string B)
        {
            string sql = "insert into TT_hang values( @Hangsx, @XuatXu)";
            SqlParameter para_ID = new SqlParameter("Hangsx", A);
            SqlParameter para_Us = new SqlParameter("XuatXu", B);
            dt_sr.UpdateData(sql, para_ID, para_Us );
        }
    }
}
