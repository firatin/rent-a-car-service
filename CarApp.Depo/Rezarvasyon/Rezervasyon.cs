using CarApp.Varliklar.Varliklar;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp.Depo.Rezarvasyon
{
    public class Rezervasyon : IRezervasyon<RezervasyonVarlik>
    {
        SqlConnection conn;
        public Rezervasyon()
        {
            conn = new SqlConnection(Tools.ConnString);
        }
        public void SoforsuzRezEkle(RezervasyonVarlik entity)
        {
            SqlCommand cmd = new SqlCommand("SoforsuzRezervasyonEkle", conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MusID", Convert.ToInt32(entity.MusId));
            cmd.Parameters.AddWithValue("@AracID", Convert.ToInt32(entity.AracId));

            cmd.Parameters.AddWithValue("@AlSubeId", Convert.ToInt32(entity.AldigiSubeId));
            cmd.Parameters.AddWithValue("@BirSubeID", Convert.ToInt32(entity.BiraktigiSubeId));
            cmd.Parameters.AddWithValue("@AlTarih", entity.AlisTarihi);
            cmd.Parameters.AddWithValue("@TesTarihi", entity.TeslimTarihi);
            cmd.Parameters.AddWithValue("@OdemeTip", Convert.ToInt32(entity.OdemeTip));
            cmd.Parameters.AddWithValue("@Taksit", Convert.ToInt32(entity.Taksit));
            cmd.Parameters.AddWithValue("@IlkYakit", Convert.ToInt32(entity.IlkYakitDurum));
            cmd.Parameters.AddWithValue("@SonYakit", Convert.ToInt32(entity.SonYakitDurum));

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void Add(RezervasyonVarlik entity)
        {
            SqlCommand cmd = new SqlCommand("spADDRezervasyon", conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MusID", Convert.ToInt32(entity.MusId));
            cmd.Parameters.AddWithValue("@AracID", Convert.ToInt32(entity.AracId));
            cmd.Parameters.AddWithValue("@SoforID", Convert.ToInt32(entity.SoforId));
            cmd.Parameters.AddWithValue("@AlSubeId", Convert.ToInt32(entity.AldigiSubeId));
            cmd.Parameters.AddWithValue("@BirSubeID", Convert.ToInt32(entity.BiraktigiSubeId));
            cmd.Parameters.AddWithValue("@AlTarih", entity.AlisTarihi);
            cmd.Parameters.AddWithValue("@TesTarihi", entity.TeslimTarihi);
            cmd.Parameters.AddWithValue("@OdemeTip", Convert.ToInt32(entity.OdemeTip));
            cmd.Parameters.AddWithValue("@Taksit", Convert.ToInt32(entity.Taksit));
            cmd.Parameters.AddWithValue("@IlkYakit", Convert.ToInt32(entity.IlkYakitDurum));
            cmd.Parameters.AddWithValue("@SonYakit", Convert.ToInt32(entity.SonYakitDurum));

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public List<RezervasyonVarlik> AlisTarihineGoreSirala()
        {
            List<RezervasyonVarlik> donecekGeneric = new List<RezervasyonVarlik>();

        
            conn.Close();
            return donecekGeneric;
        }
        public List<RezervasyonVarlik> TeslimTarihineGoreSirala()
        {
            List<RezervasyonVarlik> donecekGeneric = new List<RezervasyonVarlik>();
            conn.Open();
            string query = "select * from Rezervasyon order by TeslimTarihi";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                RezervasyonVarlik car = new RezervasyonVarlik
                {
                    RezId = (int)dr["RezId"],

                    AldigiSubeId = (int)dr["AldigiSubeId"],

                    MusId = (int)dr["MusId"],
                    SoforId = (int)dr["SoforId"],
                    AracId = (int)dr["AracId"],
                    AlisTarihi = (DateTime)dr["AlisTarihi"],
                    TeslimTarihi = (DateTime)dr["TeslimTarihi"],
                    BiraktigiSubeId = (int)dr["BiraktigiSubeId"],
                    IlkYakitDurum = Convert.ToInt16(dr["ilkYakitDurum"]),
                    SonYakitDurum = Convert.ToInt16(dr["sonYakitDurum"]),
                    Taksit = Convert.ToInt16(dr["Taksit"]),
                    OdemeTip = (bool)dr["OdemeTip"],
                };
                donecekGeneric.Add(car);
            }
            conn.Close();
            return donecekGeneric;
        }
        public void Delete(int entityId)
        {
            SqlCommand cmd = new SqlCommand("delete from Rezervasyon where RezId=@id", conn);
            cmd.Parameters.AddWithValue("@id", entityId);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public RezervasyonVarlik IdYeGoreRezervasyonGetir(int id)
        {
            throw new NotImplementedException();
        }
        public void Insert(RezervasyonVarlik entity)
        {
            throw new NotImplementedException();
        }
        public List<RezervasyonVarlik> TumRezervasyonlariGetir()
        {
            List<RezervasyonVarlik> donecekGeneric = new List<RezervasyonVarlik>();    
                RezervasyonVarlik car = new RezervasyonVarlik{  };
                donecekGeneric.Add(car);       
            return donecekGeneric;
        }
        public void Update(RezervasyonVarlik entity)
        {
            SqlCommand cmd = new SqlCommand("spUpdateRezervasyon", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@AracID", entity.AracId);
            cmd.Parameters.AddWithValue("@SoforID", entity.SoforId);
            cmd.Parameters.AddWithValue("@BirSubeID", entity.BiraktigiSubeId);
            cmd.Parameters.AddWithValue("@TesTarihi", entity.TeslimTarihi);
            cmd.Parameters.AddWithValue("@OdemeTip", entity.OdemeTip);
            cmd.Parameters.AddWithValue("@Taksit", entity.Taksit);
            cmd.Parameters.AddWithValue("@SonYakit", entity.SonYakitDurum);
            cmd.Parameters.AddWithValue("@RezID", entity.RezId);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

        }
        public object CmbAracDoldur()
        {
            SqlDataAdapter sqlDa = new SqlDataAdapter("select * from Araclar where Durum='Bos'", conn);
            DataTable ds = new DataTable();
            sqlDa.Fill(ds);
            return ds;        
        }
        public object CmbSoforDoldur()
        {
            SqlDataAdapter sqlDa = new SqlDataAdapter("select SoforId,SoforAd,SoforSoyad from Soforler", conn);
            DataTable ds = new DataTable();
            sqlDa.Fill(ds);
            return ds; 
        }
        public object CmbSubeDoldur()
        {
            SqlDataAdapter sqlDa = new SqlDataAdapter("select SubeId,SubeAdi from Subeler", conn);
            DataTable ds = new DataTable();
            sqlDa.Fill(ds);
            return ds; 
        }
        public object CmbMusteriDoldur()
        {
            SqlDataAdapter sqlDa = new SqlDataAdapter("select MusId,MusAdi from Musteriler", conn);
            DataTable ds = new DataTable();
            sqlDa.Fill(ds);
            return ds; 
        }


     
    }
}
