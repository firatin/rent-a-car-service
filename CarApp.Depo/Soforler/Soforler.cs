using CarApp.Varliklar.Varliklar;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp.Depo.Soforler
{
    public class Soforler : ISoforler<SoforVarlik>
    {
        SqlConnection conn;
        public Soforler()
        {
            conn = new SqlConnection(Tools.ConnString);
        }
        public void Add(SoforVarlik entity)
        {
            /*
             * create proc spADDSofor(@Ad nvarchar(20),@Soyad nvarchar(20),@TC nchar(11),@Tel nvarchar(20))as
insert into Soforler(SoforAd,SoforSoyad,SoforTC,SoforTel)values(@Ad,@Soyad,@TC,@Tel)
             * */
            SqlCommand cmd = new SqlCommand("spADDSofor", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Ad", entity.SoforAd);
            cmd.Parameters.AddWithValue("@Soyad", entity.SoforSoyad);
            cmd.Parameters.AddWithValue("@TC", entity.SoforTC);
            cmd.Parameters.AddWithValue("@Tel", entity.SoforTel);
        
            conn.Open();
            cmd.ExecuteScalar();
            conn.Close();
        }

        public void Delete(int entityId)
        {
            SqlCommand cmd = new SqlCommand("delete from Soforler where SoforId=" + entityId,conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public SoforVarlik IdyeGoreSoforGetir(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(SoforVarlik entity)
        {
            throw new NotImplementedException();
        }

        public List<SoforVarlik> TumSoforleriGetir()
        {
            List<SoforVarlik> donecekGeneric = new List<SoforVarlik>();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from Soforler", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                SoforVarlik car = new SoforVarlik
                {
                    SoforAd = dr["SoforAd"].ToString(),
                    SoforSoyad = dr["SoforSoyad"].ToString()
                };
                donecekGeneric.Add(car);
            }
            conn.Close();
            return donecekGeneric;
        }

        public void Update(SoforVarlik entity)
        {
            SqlCommand cmd = new SqlCommand("spUpdateSofor", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Ad", entity.SoforAd);
            cmd.Parameters.AddWithValue("@Soyad", entity.SoforSoyad);
            cmd.Parameters.AddWithValue("@TC", entity.SoforTC);
            cmd.Parameters.AddWithValue("@Tel", entity.SoforTel);

            conn.Open();
            cmd.ExecuteScalar();
            conn.Close();
        }
    }
}
