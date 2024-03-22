using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp.Depo
{
    public class hataMesajlari
    {
        SqlConnection conn = new SqlConnection(Tools.ConnString);
        public void hataekle(string msj)
        {
           
            SqlCommand cmd = new SqlCommand("insert hata(hata) values ('" + msj + "')", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public object HataBildirimleriniListele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter sqlDa = new SqlDataAdapter("select * from hata", conn);
           
            sqlDa.Fill(dt);
            return dt;
        }
    }
}
