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
    public class Acc_Bll
    {
        DataService dt_sr = new DataService();
        public List<User> laytatca()
        {
            string sql = "select * from Acc";
            DataTable Dt = dt_sr.getData(sql);
            List<User> Us_Ls = new List<User>();
            foreach (DataRow r in Dt.Rows)
            {
                User Us = new User();
                Us._IDuser = (int)r[0];
                Us._UserName = (string)r[1];
                Us._Pwd = (string)r[2];
                Us._Email= (string)r[3];
                Us_Ls.Add(Us);
            }
            return Us_Ls;


        }
        public void ADD(int ID, string Tendangnhap, string Matkhau, string Email)
        {
            string sql = "insert into Acc values( @Username, @Pass, @Email)";
            SqlParameter para_ID = new SqlParameter("ID_user", ID);
            SqlParameter para_Us = new SqlParameter("Username", Tendangnhap);
            SqlParameter para_Pwd = new SqlParameter("Pass", Matkhau);
            SqlParameter para_Email= new SqlParameter("Email",Email);
            dt_sr.UpdateData(sql, para_ID, para_Us, para_Pwd, para_Email);
        }
    }
}
