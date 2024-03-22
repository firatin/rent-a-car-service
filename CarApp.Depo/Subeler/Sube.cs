
using CarApp.Varliklar.Varliklar;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp.Depo.Subeler
{
    public class Sube : ISube<SubeVarlik>
    {
        SqlConnection conn;
        public Sube()
        {
            conn = new SqlConnection(Tools.ConnString);
        }
        public void Add(SubeVarlik entity)
        {
            try
            {                
                SqlCommand cmd = new SqlCommand("insert into Subeler values(@subeAd, @subeYetkili, @subeTel, @subeAdres, @subeIlce, @sifre)", conn);
                cmd.Parameters.AddWithValue("@subeAd", entity.SubeAdi);
                cmd.Parameters.AddWithValue("@subeAdres", entity.SubeAdres);
                cmd.Parameters.AddWithValue("@subeYetkili", entity.SubeYetkili);
                cmd.Parameters.AddWithValue("@sifre", entity.Sifre);
                cmd.Parameters.AddWithValue("@subeIlce", entity.Subeilce);
                cmd.Parameters.AddWithValue("@subeTel", entity.SubeTel);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
       

        public void Delete(int entityId)
        {
            SqlCommand cmd = new SqlCommand("delete from Subeler where SubeId=" + entityId,conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
 
        public List<SubeVarlik> SubeleriGetir()
        {
            List<SubeVarlik> donecekGeneric = new List<SubeVarlik>();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from Subeler", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                SubeVarlik car = new SubeVarlik
                {
                    SubeAdi = dr["SubeAdi"].ToString(),
                    SubeYetkili = dr["SubeYetkili"].ToString()
                };
                donecekGeneric.Add(car);
            }
            conn.Close();
            return donecekGeneric;
        }
     
        public SubeVarlik IdyeGoreSubeGetir(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(SubeVarlik entity)
        {
            throw new NotImplementedException();
        }    

        public void Update(SubeVarlik entity)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("spUpdateSubeler", conn);
                cmd.Parameters.AddWithValue("@subeId", entity.SubeAdi);
                cmd.Parameters.AddWithValue("@subeAdres", entity.SubeAdres);
                cmd.Parameters.AddWithValue("@subeYetkili", entity.SubeYetkili);
                cmd.Parameters.AddWithValue("@sifre", entity.Sifre);
                cmd.Parameters.AddWithValue("@subeIlce", entity.Subeilce);
                cmd.Parameters.AddWithValue("@subeTel", entity.SubeTel);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }  

        List<SubeVarlik> ISube<SubeVarlik>.SubeleriGetir()
        {
            throw new NotImplementedException();
        }


        public bool Dene(string p1, string p2)
        {
            bool durum = false;
            conn.Open();
            SqlCommand cmd = new SqlCommand("select SubeYetkili, Sifre from Subeler", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                if (p1 == dr.GetString(0) && p2 == dr.GetString(1)) durum = true;
            }
            conn.Close();
            return durum;
        }

        public int IdGetir(string t1, string t2)
        {
            SqlCommand cmd = new SqlCommand("select SubeId from Subeler where SubeYetkili='" + t1 + "' and Sifre='" + t2 + "'", conn);
            conn.Open();
            int id = (int)cmd.ExecuteScalar();
            conn.Close();
            return id;
        }


        public void SubeAdSifreDegistir(SubeVarlik entity)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("update Subeler set SubeYetkili=@SubeYetkili,Sifre=@Sifre where SubeId=@SubeId", conn);
                cmd.Parameters.AddWithValue("@SubeId", entity.SubeId);

                cmd.Parameters.AddWithValue("@SubeYetkili", entity.SubeYetkili);
                cmd.Parameters.AddWithValue("@Sifre", entity.Sifre);


                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
