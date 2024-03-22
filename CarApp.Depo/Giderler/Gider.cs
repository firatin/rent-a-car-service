using CarApp.Varliklar.Varliklar;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp.Depo.Giderler
{
    public enum GiderTipleri
    {
        Bakım, Onarım
    }
    public enum Para
    {
        Dolar, Euro, TL
    }
    public class Gider : IGider<GiderVarlik>
    {
        SqlConnection conn;
        public Gider()
        {
            conn = new SqlConnection(Tools.ConnString);
        }
        public void Add(GiderVarlik entity)
        {
            SqlCommand cmd = new SqlCommand("spADDGider", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@AracID", entity.AracId);
            cmd.Parameters.AddWithValue("@SubeID", entity.SubeId);
            cmd.Parameters.AddWithValue("@GiderTip", entity.GiderTip);
            cmd.Parameters.AddWithValue("@Tutar", entity.Tutar);
            cmd.Parameters.AddWithValue("@Aciklama", entity.Aciklama);
            cmd.Parameters.AddWithValue("@Tarih", entity.Tarih);
            conn.Open();
            cmd.ExecuteScalar();
            conn.Close();

        }

        public void Delete(int entityId)
        {
            SqlCommand cmd = new SqlCommand("delete from Gider where GiderId=@id",conn);
            cmd.Parameters.AddWithValue("@id",entityId);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public GiderVarlik IdyeGoreGiderGetir(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(GiderVarlik entity)
        {
            throw new NotImplementedException();
        }
        SqlDataAdapter sqlDa;
        DataSet ds;
        DataTable dt;
        public object PlakaGetir()
        {
            sqlDa = new SqlDataAdapter("select * from  Araclar", conn);
            ds = new DataSet();
            dt = new DataTable();
            sqlDa.Fill(dt);
            return dt;
        }

        public object SubeGetir()
        {
            sqlDa = new SqlDataAdapter("select * from Subeler", conn);
            ds = new DataSet();
            dt = new DataTable();
            sqlDa.Fill(dt);
            return dt;
        }

        //public GiderVarlik TumGiderleriGetir(GiderVarlik entity)
        //{
        //    GiderVarlik g=new GiderVarlik();
        //    SqlCommand cmd = new SqlCommand("select * from Gider", conn);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue("@GiderID", entity.GiderId);
        //    cmd.Parameters.AddWithValue("@AracID", entity.AracId);
        //    cmd.Parameters.AddWithValue("@SubeId", entity.SubeId);
        //    cmd.Parameters.AddWithValue("@GiderTip", entity.GiderTip);
        //    cmd.Parameters.AddWithValue("@Aciklama", entity.Aciklama);
        //    cmd.Parameters.AddWithValue("@Tarih", entity.Tarih);
        //    cmd.Parameters.AddWithValue("@tutar", entity.Tutar);
        //    conn.Open();
        //    cmd.ExecuteScalar();
        //    conn.Close();
        //    g.GiderTip=entity.GiderTip;
        //    g.AracId = entity.AracId;
        //    g.SubeId = entity.SubeId;
        //    g.Tutar = entity.Tutar;
        //    g.Aciklama = entity.Aciklama;
        //    g.Tarih = entity.Tarih;
        //    return g;
        //}

        public void Update(GiderVarlik entity)
        {
            SqlCommand cmd = new SqlCommand("spUpdateGider", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@AracID", entity.AracId);
            cmd.Parameters.AddWithValue("@SubeID", entity.SubeId);
            cmd.Parameters.AddWithValue("@GiderTip", entity.GiderTip);
            cmd.Parameters.AddWithValue("@Tutar", entity.Tutar);
            cmd.Parameters.AddWithValue("@Aciklama", entity.Aciklama);
            cmd.Parameters.AddWithValue("@Tarih", entity.Tarih);
            conn.Open();
            cmd.ExecuteScalar();
            conn.Close();
        }

        public object GiderGetir()
        {
            SqlDataAdapter sda = new SqlDataAdapter("select * from Gider", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
    }
}
