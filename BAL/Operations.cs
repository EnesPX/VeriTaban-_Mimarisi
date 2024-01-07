using DAL;
using BEL;
using System.Data;
using System.Data.SqlClient;

namespace BAL
{

    public class Operations
    {
        public DBConnection db = new DBConnection();
        public Informations info = new Informations();

        public int insertEmp(Informations info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into tblOgrenciler (OgrenciID,Ad,Soyad,Numara) values ('"+info.id+"','"+info.name +"','"+ info.surname +"','"+info.no +"')";
            return db.ExeNonQuery(cmd);
        }
    }
}