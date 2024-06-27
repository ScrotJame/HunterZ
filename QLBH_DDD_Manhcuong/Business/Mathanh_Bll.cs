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
    public class Mathanh_Bll
    {
        DataService dt_sr = new DataService();
        public List<Mathang> laytatca()
        {
            string sql = "select * from TT_Mathang";
            DataTable Dt = dt_sr.getData(sql);
            List<Mathang> Us_Ls = new List<Mathang>();
            foreach (DataRow r in Dt.Rows)
            {
                Mathang Us = new Mathang();
                Us.Ma_mathang = (string)r[0];
                Us.Ten_mathang = (string)r[1];
                Us_Ls.Add(Us);
            }
            return Us_Ls;


        }
        public void ADD( string ma, string ten)
        {
            string sql = "insert into  TT_Mathang values( @Ma_mathang, @Ten_mathang)";
            SqlParameter para_A = new SqlParameter("Ma_mathang", ma);
            SqlParameter para_B = new SqlParameter("Ten_mathang", ten);
            dt_sr.UpdateData(sql, para_A, para_B);
        }
    }
}
