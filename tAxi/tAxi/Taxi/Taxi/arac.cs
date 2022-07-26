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
    public partial class arac : Form
    {
        public arac()
        {
            InitializeComponent();
        }
        Veritabani vt = new Veritabani();
        private void txt_aracMarka_TextChanged(object sender, EventArgs e)
        {

        }

        private void arac_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'taxiDataSet1.tbl_arac' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //this.tbl_aracTableAdapter.Fill(this.taxiDataSet1.tbl_arac);

            dgv_arac.DataSource = vt.Select("select aracId,aracMarka,aracModel,aracPlaka from tbl_arac");


        }

        private void btn_soforEkle_Click(object sender, EventArgs e)
        {
            if (txt_aracMarka.Text==""||txt_aracModel.Text==""||txt_aracPlaka.Text=="")
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz..");
            }
            if (txt_aracMarka.Text.Length<2)
            {
                MessageBox.Show("Marka en az 2 karakterden oluşmalıdır.");
            }
            if (txt_aracModel.Text.Length < 2)
            {
                MessageBox.Show("Model en az 2 karakterden oluşmalıdır.");
            }
            if (txt_aracPlaka.Text.Length < 6)
            {
                MessageBox.Show("Plaka en az 6 karakterden oluşmalıdır.");
            }

            object kayitSay = vt.Insert(@"insert into tbl_arac(aracMarka,aracModel,aracPlaka)
                                        values('" + txt_aracMarka.Text + "','" + txt_aracModel.Text + "','" + txt_aracPlaka.Text + "')");


            if (Convert.ToInt32(kayitSay) > 0)
            {
                arac_Load(null, null);
                MessageBox.Show("Kayıt Eklendi...");
            }


        }

        private void btn_soforGuncelle_Click(object sender, EventArgs e)
        {

            if (dgv_arac.SelectedRows.Count == 0)
            {
                MessageBox.Show("Güncellenecek satırı seçiniz !!!");
                return;
            }
            if (dgv_arac.SelectedRows.Count > 1)
            {
                MessageBox.Show("Güncellenecek satır 1 tane olmalıdır. !!!");
                return;
            }
            int kayitSay = vt.UpdateDelete(@"update tbl_arac
                                           set aracMarka='" + txt_aracMarka.Text + @"',      
                                               aracModel='" + txt_aracModel.Text + @"',
                                               aracPlaka='" + txt_aracPlaka.Text + @"'
                                              
                                            where aracId=" + dgv_arac.SelectedRows[0].Cells["aracId"].Value);
            if (kayitSay > 0)
            {
                arac_Load(null, null);
                MessageBox.Show("Kayıt güncellendi...");
            }
        }

        private void dgv_arac_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_arac.SelectedRows.Count == 0)
            {
                return;
            }
            else
            {
                txt_aracMarka.Text = dgv_arac.SelectedRows[0].Cells["aracMarka"].Value.ToString();
                txt_aracModel.Text = dgv_arac.SelectedRows[0].Cells["aracModel"].Value.ToString();
                txt_aracPlaka.Text = dgv_arac.SelectedRows[0].Cells["aracPlaka"].Value.ToString();
            }
        }

        private void btn_soforSil_Click(object sender, EventArgs e)
        {
            if (dgv_arac.SelectedRows.Count == 0)
            {
                MessageBox.Show("Silinecek satırı seçiniz !!!");
                return;
            }

            int kayitSay = vt.UpdateDelete("Delete from tbl_arac where aracId =" + dgv_arac.SelectedRows[0].Cells["aracId"].Value);
            if (kayitSay > 0)
            {
                arac_Load(null, null);
                MessageBox.Show("Kayıt silindi...");
            }
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Anasayfa ana= new Anasayfa();
            this.Hide();
            ana.Show();
        }
    }
}
