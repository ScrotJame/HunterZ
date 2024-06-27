using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Data
{
    public class DataService
    {
        SqlConnection Conn;
        string sql = "Data Source=localhost;Initial Catalog=QL_dodadung;Integrated Security=True";
        public DataService() { }
        public DataTable getData(string sql, params SqlParameter[] thamso)
        {
            ConnOpen();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(sql, Conn);
            cmd.Parameters.AddRange(thamso);
            dt.Load(cmd.ExecuteReader());
            ConnClose();
            return dt;
        }
        void ConnOpen()
        {
            Conn = new SqlConnection(sql);
            Conn.Open();
        }
        void ConnClose()
        {
            Conn.Close();
        }
        public void UpdateData(string sql, params SqlParameter[] thamso)
        {
            ConnOpen();
            SqlCommand cmd = new SqlCommand(sql, Conn);
            cmd.Parameters.AddRange(thamso);
            cmd.ExecuteNonQuery();
            ConnClose();
        }
    }
}
