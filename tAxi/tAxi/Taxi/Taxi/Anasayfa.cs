using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VTI;
using Microsoft.Win32;


namespace Taxi
{
    public partial class Anasayfa : Form
    {
        string ProgramAdi = "Taksi Durağı";
        public Anasayfa()
        {
            InitializeComponent();
            try
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
                if (key.GetValue(ProgramAdi).ToString() == "\"" + Application.ExecutablePath + "\"")
                { // Eğer regeditte varsa, checkbox ı işaretle
                    cbx_windows.Checked = true;
                }
            }
            catch
            {

            }
        }
        Veritabani vt=new Veritabani();
        private void guna2GradientCircleButton2_Click(object sender, EventArgs e)
        {
            sofor sf = new sofor();
            this.Hide();
            sf.Show();
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {
           DataTable dt = vt.Select("select adminAd from tbl_admin");
            if (dt.Rows.Count != 0)
            {
                label2.Text = dt.Rows[0]["adminAd"].ToString() + "Bey";
            }
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_tarih.Text = DateTime.Now.ToLongDateString();
            lbl_saat.Text = DateTime.Now.ToLongTimeString();

        }

        private void guna2GradientCircleButton1_Click(object sender, EventArgs e)
        {
            Durak dr= new Durak();
            this.Hide();
            dr.Show();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Form1 fr =new Form1();
            this.Hide();
            fr.Show();
        }

        private void guna2GradientCircleButton4_Click(object sender, EventArgs e)
        {
            tarife tarife = new tarife();
            this.Hide();
            tarife.Show();
        }

        private void guna2GradientCircleButton1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.D)
            {
                guna2GradientCircleButton1_Click(null, null);
            }
        }

        private void guna2GradientCircleButton2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData== Keys.S)
            {
              guna2GradientCircleButton2_Click(null, null);
            }
        }

        private void guna2GradientCircleButton3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.A)
            {
                guna2GradientCircleButton3_Click(null, null);
            }
        }

        private void guna2GradientCircleButton4_KeyDown(object sender, KeyEventArgs e)
        {
            guna2GradientCircleButton4_Click(null,null);
        }

        private void guna2GradientCircleButton3_Click(object sender, EventArgs e)
        {
            arac car = new arac();
            this.Hide();
            car.Show();
        }

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void durakİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Durak dr = new Durak();
            this.Hide();
            dr.Show();
        }

        private void tarifeİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tarife tarife = new tarife();
            this.Hide();
            tarife.Show();
        }

        private void sürücüİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sofor sfr=new sofor();
            this.Hide();
            sfr.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (cbx_windows.Checked)
            { //işaretlendi ise Regedit e açılışta çalıştır olarak ekle
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
                key.SetValue(ProgramAdi, "\"" + Application.ExecutablePath + "\"");
            }
            else
            {  //işaret kaldırıldı ise Regeditten açılışta çalıştırılacaklardan kaldır
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
                key.DeleteValue(ProgramAdi);
            }
        }
    }
}
