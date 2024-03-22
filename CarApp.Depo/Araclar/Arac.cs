using CarApp.Varliklar.Varliklar;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp.Depo.Araclar
{
    public class Arac : IArac<AracVarlik>
    {
        public enum Para
        {
            Dolar, Euro, TL
        }
        SqlConnection conn;
        public Arac()
        {
            conn = new SqlConnection(Tools.ConnString);
        }
        public void Add(AracVarlik entity)
        {
            SqlCommand cmd = new SqlCommand("spADDAraclar", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Plaka", entity.Plaka);
            cmd.Parameters.AddWithValue("@Marka", entity.Marka);
            cmd.Parameters.AddWithValue("@Model", entity.Model);
            cmd.Parameters.AddWithValue("@ModelYili", entity.ModelYili);
            cmd.Parameters.AddWithValue("@Kilometre", entity.Kilometre);
            cmd.Parameters.AddWithValue("@SigortaTarihi", entity.SigortaTarihi);
            cmd.Parameters.AddWithValue("@Ucret", entity.Ucret);
            cmd.Parameters.AddWithValue("@Durum", entity.Durum);
            conn.Open();
            cmd.ExecuteScalar();
            conn.Close();
        }

        public void Delete(int entityId)
        {
            SqlCommand cmd = new SqlCommand("delete from Araclar where AracId=@id", conn);
            cmd.Parameters.AddWithValue("@id", entityId);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public AracVarlik IdyeGoreAracGetir(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(AracVarlik entity)
        {
            throw new NotImplementedException();
        }

        public List<AracVarlik> TumAraclariGetir()
        {
            List<AracVarlik> donecekGeneric = new List<AracVarlik>();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from Araclar", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                AracVarlik car = new AracVarlik
                {
                    AracId = (int)dr["AracId"],
                    Plaka = dr["Plaka"].ToString()
                };
                donecekGeneric.Add(car);
            }
            conn.Close();
            return donecekGeneric;
        }

        public void Update(AracVarlik entity)
        {
            SqlCommand cmd = new SqlCommand("spUpdateAraclar", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@AracID", entity.AracId);
  
            cmd.Parameters.AddWithValue("@Kilometre", entity.Kilometre);
            cmd.Parameters.AddWithValue("@SigortaTarihi", entity.SigortaTarihi);
            cmd.Parameters.AddWithValue("@Ucret", entity.Ucret);
            cmd.Parameters.AddWithValue("@Durum", entity.Durum);
            conn.Open();
            cmd.ExecuteScalar();
            conn.Close();
        }


        public object CbAracDoldur()
        {
            SqlDataAdapter sqlDa = new SqlDataAdapter("select * from Subeler", conn);
            DataTable ds = new DataTable();
            sqlDa.Fill(ds);
            return ds;
        }

     
        SqlDataAdapter sda;
        DataTable dt;
        DataSet ds;
        public object AracGetir()
        {
            ds = new DataSet();
            sda = new SqlDataAdapter("select * from Araclar", conn);
            dt = new DataTable();
            sda.Fill(dt);
            sda.Fill(ds);
            return dt;
        }
    }
}
