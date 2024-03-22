using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
namespace CarApp.WinUI
{
    public partial class Iletisim : Form
    {
        public Iletisim()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }
        public bool Gonder(string konu, string icerik)
        {
            MailMessage ePosta = new MailMessage();
            ePosta.From = new MailAddress("ozgul90@hotmail.com");
            //
            ePosta.To.Add("ozgulcolakoglu@gmail.com");
            ePosta.To.Add("ozgul90@hotmail.com");
            ePosta.To.Add("alan3@hotmail.com");
            //
            //ePosta.Attachments.Add(new Attachment(@"C:\Users\ozgul\Desktop\sql.txt"));
            //
            ePosta.Subject = konu;
            //
            ePosta.Body = icerik;
            //
            SmtpClient smtp = new SmtpClient();
            //
            smtp.Credentials = new System.Net.NetworkCredential("ozgulcolakoglu@gmail.com", "ozgul5866");
            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
            object userState = ePosta;
            bool kontrol = true;
            try
            {
                smtp.SendAsync(ePosta, (object)ePosta);
            }
            catch (SmtpException ex)
            {
                kontrol = false;
                System.Windows.Forms.MessageBox.Show(ex.Message, "Mail Gönderme Hatasi");
            }
            return kontrol;
        }
    }
}
