using System.Data;
using System.Data.SqlClient;


namespace DAL
{
    
    public class DBConnection
    {
        public SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-SLE0JBB\MSQLSERVER1 ; Initial Catalog = OkulDBSube2 ; Integrated Security= true");

        public SqlConnection getcon() 
        {
           if (con.State == ConnectionState.Closed)
           {
             con.Open();
           }
           return con;     
        }
        public int ExeNonQuery(SqlCommand cmd)
        {
            cmd.Connection = getcon();
            int rowsaffected = -1;
            rowsaffected = cmd.ExecuteNonQuery();
            con.Close();
            return rowsaffected;
        }
        public object ExeScalar(SqlCommand cmd)
        {
            cmd.Connection= getcon();
            object obj = -1;
            obj = cmd.ExecuteScalar();
            con.Close();
            return obj;
        }
        public DataTable ExeReader(SqlCommand cmd)
        {
            cmd.Connection = getcon();
            SqlDataReader sdr;
            DataTable dt = new DataTable();
            sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            return dt;
        }

    }
}