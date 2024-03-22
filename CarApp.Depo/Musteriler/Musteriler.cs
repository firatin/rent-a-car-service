using CarApp.Varliklar.Varliklar;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp.Depo.Musteriler
{
    public class Musteriler : IMusteriler<MusteriVarlik>
    {
        SqlConnection conn;
        public Musteriler()
        {
            conn = new SqlConnection(Tools.ConnString);
        }
        public void Add(MusteriVarlik entity)
        {           
            SqlCommand cmd = new SqlCommand("spADDMusteriler", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MusAdi", entity.MusAdi);
            cmd.Parameters.AddWithValue("@MusSoyadi", entity.MusSoyadi);
            cmd.Parameters.AddWithValue("@MusAdres", entity.MusAdres);
            cmd.Parameters.AddWithValue("@MusTc", entity.MusTc);
            cmd.Parameters.AddWithValue("@MusTel", entity.MusTel);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void Delete(int entityId)
        {
            SqlCommand cmd = new SqlCommand("delete from Musteriler where MusId=" + entityId,conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public MusteriVarlik IdyeGoreMusteriGetir(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(MusteriVarlik entity)
        {
            throw new NotImplementedException();
        }

        public List<MusteriVarlik> TumMusterileriGetir()
        {
            List<MusteriVarlik> donecekGeneric = new List<MusteriVarlik>();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from Musteriler", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                MusteriVarlik car = new MusteriVarlik
                {
                    MusId = (int)dr["MusId"],
                    MusAdi = dr["MusAdi"].ToString()
                };
                donecekGeneric.Add(car);
            }
            conn.Close();
            return donecekGeneric;
        }

        public void Update(MusteriVarlik entity)
        {
            SqlCommand cmd = new SqlCommand("spUpdateMusteri", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MusAdi", entity.MusAdi);
            cmd.Parameters.AddWithValue("@MusSoyadi", entity.MusSoyadi);
            cmd.Parameters.AddWithValue("@MusAdres", entity.MusAdres);
            cmd.Parameters.AddWithValue("@MusTc", entity.MusTc);
            cmd.Parameters.AddWithValue("@MusTel", entity.MusTel);
            cmd.Parameters.AddWithValue("@MusId", entity.MusId);
     
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void AdaGoreIdGetir(string ad)
        {
            //SqlCommand cmd=ne
        }
    }
}
