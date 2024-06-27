using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
namespace Business
{
    public class KH_Bll
    {
        DataService dt_sr = new DataService();
        public List<Khachhang> laytatca()
        {
            string sql = "select * from TT_khach";
            DataTable dt = dt_sr.getData(sql);
            List<Khachhang> Rule = new List<Khachhang>();
            foreach (DataRow r in dt.Rows)
            {
                Khachhang Q1 = new Khachhang();
                Q1.makhach = (int)r[0];
                Q1.tenkhach = (string)r[1];
                Q1.email = (string)r[2];
                Q1.sodienthoai = (int)r[3];
                Q1.diachi = (string)r[4];
                Rule.Add(Q1);
            }
            return Rule;
        }
        public void Add(int Id, string name, string email, int sdt, string address)
        {
            string sql = " Insert into TT_khach values (@Ma_khach, @Ten_khach, @Email, @Sodienthoai, @Diachi)";
            SqlParameter prID = new SqlParameter("ID", Id);
            SqlParameter prName = new SqlParameter("Name", name);
            SqlParameter prEmail = new SqlParameter("Email", email);
            SqlParameter prNum = new SqlParameter("Sodienthoai", sdt);
            SqlParameter prAdd = new SqlParameter("address", address);
            dt_sr.UpdateData(sql, prID, prName, prEmail, prNum, prAdd);
        }
    }
}
