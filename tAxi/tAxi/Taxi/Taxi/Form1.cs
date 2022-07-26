using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VTI;

namespace Taxi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void label5_Click(object sender, EventArgs e)
        {
            pn_kullanıcıKayit.Visible=false;
            guna2Transition1.HideSync(pn_kullanıcıKayit);
        }

        

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            pn_kullanıcıKayit.Visible = true;
            guna2Transition1.ShowSync(pn_kullanıcıKayit);
        }
        public static string MD5Sifrele(string sifrelenecekMetin)
        {

            // MD5CryptoServiceProvider sınıfının bir örneğini oluşturduk.
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            //Parametre olarak gelen veriyi byte dizisine dönüştürdük.
            byte[] dizi = Encoding.UTF8.GetBytes(sifrelenecekMetin);
            //dizinin hash'ini hesaplattık.
            dizi = md5.ComputeHash(dizi);
            //Hashlenmiş verileri depolamak için StringBuilder nesnesi oluşturduk.
            StringBuilder sb = new StringBuilder();
            //Her byte'i dizi içerisinden alarak string türüne dönüştürdük.

            foreach (byte ba in dizi)
            {
                sb.Append(ba.ToString("x2").ToLower());
            }

            //hexadecimal(onaltılık) stringi geri döndürdük.
            return sb.ToString();
        }
        Veritabani vt = new Veritabani();
        private void btn_kayıtol_Click(object sender, EventArgs e)
        {
            try { 
            if (tx_kyAd.Text==""||tx_kySoyad.Text==""||tx_kyTc.Text==""||tx_kyTel.Text==""||tx_kyMail.Text==""||tx_kyAdres.Text==""||tx_kySifre.Text=="")
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.");
            }
            if (tx_kyAd.Text.Length < 2)
            {
                MessageBox.Show("Ad en az 2 karakter olmalıdır.");
                return;
            }
            if (tx_kySoyad.Text.Length < 2)
            {
                MessageBox.Show("Soyad en az 2 karakter olmalıdır.");
                return;
            }
            if (tx_kyTc.Text.Length != 11)
            {
                MessageBox.Show("TcNo 11 karakter olmalıdır !!!");
                return;
            }
            if (tx_kyTel.Text.Length != 11)
            {
                MessageBox.Show("Tel 11 karakter olmalıdır !!!");
                return;
            }
            if (tx_kyAdres.Text.Length == 0)
            {
                MessageBox.Show("Adresiniz boş bırakılamaz.");
                return;
            }
            if (!tx_kyMail.Text.Contains("@"))//@ yoksa hata verecek
            {
                MessageBox.Show("Lütfen geçerli bir Mail giriniz.");
                return;
            }
            if (tx_kySifre.Text.Length == 0)
            {
                MessageBox.Show("Lütfen şifre giriniz.");
                return;
            }
            object kayitSay = vt.Insert(@"insert into tbl_admin(adminAd,adminSoyad,adminTc,adminTel,adminAdres,adminMail,adminSifre)
                                        values('" + tx_kyAd.Text + "','" + tx_kySoyad.Text + "','" + tx_kyTc.Text + "','" + tx_kyTel.Text + "','" + tx_kyAdres.Text + "','" + tx_kyMail.Text + "','" + MD5Sifrele(tx_kySifre.Text) + "')");

            if (Convert.ToInt32(kayitSay)>0)
            {
                Form1_Load(null, null);
                MessageBox.Show("Kayıt Eklendi...");
            }
            }
            catch
            {
                MessageBox.Show("Hata Var..");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            try { 
            if (tx_tc.Text==""||tx_sifre.Text=="")
            {
                MessageBox.Show("Tc Kimlik Numaranız veya Şifrenizi Girmediniz !!!");
            }
            DataTable dt = vt.Select(@"select adminId,adminTc,adminSifre from tbl_admin where adminTc=" + tx_tc.Text + "and adminSifre='" + MD5Sifrele(tx_sifre.Text) + "'");
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Kullanıcı adın veya şifre hatalı...");
                tx_tc.Text = tx_sifre.Text = "";
                return;
            }
            Anasayfa ana = new Anasayfa();
            this.Hide();
            ana.Show();
            }
            catch
            {
                MessageBox.Show("Hata Var");
            }
        }

        private void pn_kullanıcıKayit_Paint(object sender, PaintEventArgs e)
        {

        }

        private void benihatırla_CheckedChanged(object sender, EventArgs e)
        {
            if (benihatırla.Checked==false)
            {
                ayarlar.Default.beniHatirla = false;
                ayarlar.Default.kullaniciAdi = "";
                ayarlar.Default.sifre = "";
                ayarlar.Default.Save();
                tx_tc.Text = "";
                tx_sifre.Text = "";
            }
        }
    }
}
