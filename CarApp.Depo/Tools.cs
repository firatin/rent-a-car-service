using CarApp.Varliklar.Varliklar;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp.Depo
{
    public class Tools
    {
        public static string ConnString
        {
            get
            {
                return "server=tcp:sariserver.database.windows.net;database=sari;uid=ulab;pwd=abcd1234.;multipleactiveresultsets=true;";
            }
        }
        public static DataTable dataGridDoldur(List<RezervasyonVarlik> listeOlarakDataVer)
        {
            SqlDataAdapter sda = new SqlDataAdapter("select R.RezID,SF.SoforID,A.AracID,R.BiraktigiSubeID,S.SubeID,R.Taksit,R.SonYakitDurum,S.SubeAdi,R.BiraktigiSubeID,M.MusAdi,M.MusSoyadi,SF.SoforAd,A.Model, A.Plaka,R.AlisTarihi,R.TeslimTarihi from Rezervasyon R join Musteriler M on M.MusId = R.MusId join Araclar A on A.AracId = R.AracId join Subeler S on S.SubeId = R.BiraktigiSubeID join Soforler SF on SF.SoforId = R.SoforId", ConnString);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        public static DataTable dataMusteriyeGore(List<RezervasyonVarlik> listeOlarakDataVer)
        {
            SqlDataAdapter sda = new SqlDataAdapter("select R.RezID,SF.SoforID,A.AracID,R.BiraktigiSubeID,S.SubeID,R.Taksit,R.SonYakitDurum,S.SubeAdi,R.BiraktigiSubeID,M.MusAdi,M.MusSoyadi,SF.SoforAd,A.Model, A.Plaka,R.AlisTarihi,R.TeslimTarihi from Rezervasyon R join Musteriler M on M.MusId = R.MusId join Araclar A on A.AracId = R.AracId join Subeler S on S.SubeId = R.BiraktigiSubeID join Soforler SF on SF.SoforId = R.SoforId order by M.MusAdi desc", ConnString);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        public static DataTable dataPlakayGore(List<RezervasyonVarlik> listeOlarakDataVer)
        {
            SqlDataAdapter sda = new SqlDataAdapter("select R.RezID,SF.SoforID,A.AracID,R.BiraktigiSubeID,S.SubeID,R.Taksit,R.SonYakitDurum,S.SubeAdi,R.BiraktigiSubeID,M.MusAdi,M.MusSoyadi,SF.SoforAd,A.Model, A.Plaka,R.AlisTarihi,R.TeslimTarihi from Rezervasyon R join Musteriler M on M.MusId = R.MusId join Araclar A on A.AracId = R.AracId join Subeler S on S.SubeId = R.BiraktigiSubeID join Soforler SF on SF.SoforId = R.SoforId order by A.Plaka asc", ConnString);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        public static DataTable dataTeslimTarihineGore(List<RezervasyonVarlik> listeOlarakDataVer)
        {
            SqlDataAdapter sda = new SqlDataAdapter("select R.RezID,SF.SoforID,A.AracID,R.BiraktigiSubeID,S.SubeID,R.Taksit,R.SonYakitDurum,S.SubeAdi,R.BiraktigiSubeID,M.MusAdi,M.MusSoyadi,SF.SoforAd,A.Model, A.Plaka,R.AlisTarihi,R.TeslimTarihi from Rezervasyon R join Musteriler M on M.MusId = R.MusId join Araclar A on A.AracId = R.AracId join Subeler S on S.SubeId = R.BiraktigiSubeID join Soforler SF on SF.SoforId = R.SoforId order by R.TeslimTarihi desc", ConnString);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        public static DataTable dataAlisTarihineGore(List<RezervasyonVarlik> listeOlarakDataVer)
        {
            SqlDataAdapter sda = new SqlDataAdapter("select R.RezID,SF.SoforID,A.AracID,R.BiraktigiSubeID,S.SubeID,R.Taksit,R.SonYakitDurum,S.SubeAdi,R.BiraktigiSubeID,M.MusAdi,M.MusSoyadi,SF.SoforAd,A.Model, A.Plaka,R.AlisTarihi,R.TeslimTarihi from Rezervasyon R join Musteriler M on M.MusId = R.MusId join Araclar A on A.AracId = R.AracId join Subeler S on S.SubeId = R.BiraktigiSubeID join Soforler SF on SF.SoforId = R.SoforId order by R.AlisTarihi desc", ConnString);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
    }
}
