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

namespace Taxi
{
    public partial class tarife : Form
    {
        public tarife()
        {
            InitializeComponent();
        }
        Veritabani vt=new Veritabani();
        private void btn_hesapla_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(txt_kmHesapla.Text);
            double sayi2 = 6.30;
            double sayi3 = 9.30;

            double sonuc = sayi1 * sayi2 + sayi3;

            MessageBox.Show("Bu yol için toplam " +sonuc+ " TL tutacaktır.");
            return;
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Anasayfa ana = new Anasayfa();
            this.Hide();
            ana.Show();
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            //int kayitSay = vt.UpdateDelete(@"update tbl_tarife
            //                               set kmUcreti='" + txt_kmHesapla.Text + @"',      
            //                                   acılısUcreti='" + tx_acılısUcreti.Text + @"',                                                                                  
            //                                where tarifeId=" + dgv_tarife.SelectedRows[0].Cells["tarifeId"].Value);


            //if (kayitSay > 0)
            //{
            //    tarife_Load(null, null);
            //    MessageBox.Show("Kayıt güncellendi...");
            //}
        }

        private void tarife_Load(object sender, EventArgs e)
        {
            //DataTable dt = vt.Select("kmUcreti,acılısUcreti,tarifeId from tbl_tarife");
        }

        private void dgv_tarife_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}
