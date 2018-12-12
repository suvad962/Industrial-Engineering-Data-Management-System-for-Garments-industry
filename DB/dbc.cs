using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DB
{
    public class dbc
    {
        public SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\SP1\Form1\Database\IDMSdb.mdf;Integrated Security=True;Connect Timeout=30");

        public SqlConnection getcon()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        public int ExeNonQuery(SqlCommand com) //for insert, update and delete
        {
            com.Connection = getcon();
            int rowsaffected = -1;
            rowsaffected = com.ExecuteNonQuery();
            con.Close();
            return rowsaffected;
        }

        public object ExeScaler(SqlCommand com) //for retrivce a single value
        {
            com.Connection = getcon();
            object obj = -1;
            obj = com.ExecuteScalar();
            con.Close();
            return obj;
        }

        public DataTable ExeReader(SqlCommand com)
        {
            com.Connection = getcon();
            DataTable dt = new DataTable();
            SqlDataReader sdr;
            sdr = com.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            return dt;
        }

      

    }
}
