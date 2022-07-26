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
    public partial class Durak : Form
    {
        public Durak()
        {
            InitializeComponent();
        }
        Veritabani vt =new Veritabani();


        private void Durak_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'taxiDataSet.tbl_durak' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            
            dgv_durak.DataSource = vt.Select("select durakId,durakAd,durakAdres,durakAracSayısı,durakSoforSayisi from tbl_durak");
            dgv_durak.Columns["durakId"].Visible = false;
        }
        private void btn_durakEkle_Click(object sender, EventArgs e)
        {
            if (tx_durakAd.Text==""||tx_durakAdres.Text==""||tx_durakAracSayisi.Text==""||tx_durakSoforSayisi.Text=="")
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz...");
            }
            if (tx_durakAd.Text.Length<2)
            {
                MessageBox.Show("Durak Adı 2 Karakterden Fazla Olmalıdır.");
            }
            if (tx_durakAdres.Text.Length<2)
            {
                MessageBox.Show("Durak Adresi 2 Karakterden Fazla Olmalıdır.");
            }
            if (tx_durakAracSayisi.Text.Length==0)
            {
                MessageBox.Show("Araç Sayısı 0'dan Farklı Olmalıdır.");
            }
            if (tx_durakSoforSayisi.Text.Length == 0)
            {
                MessageBox.Show("Şöför Sayısı 0'dan Farklı Olmalıdır.");
            }
            object kayitSay = vt.Insert(@"insert into tbl_durak(durakAd,durakAdres,durakAracSayısı,durakSoforSayisi)
                                        values('" + tx_durakAd.Text + "','" + tx_durakAdres.Text + "','" + tx_durakAracSayisi.Text + "','" + tx_durakSoforSayisi.Text + "')");
            if (Convert.ToInt32(kayitSay) > 0)
            {
                Durak_Load(null, null);
                MessageBox.Show("Kayıt Eklendi...");
            }
        }

       

        private void btn_durakGuncelle_Click(object sender, EventArgs e)
        {
            int kayitSay = vt.UpdateDelete(@"update tbl_durak
                                           set durakAd='" + tx_durakAd.Text + @"',      
                                               durakAdres='" + tx_durakAdres.Text + @"',
                                               durakAracSayısı='" + tx_durakAracSayisi.Text + @"',
                                               durakSoforSayisi='" + tx_durakSoforSayisi.Text + @"'
                                             
                                            where durakId=" + dgv_durak.SelectedRows[0].Cells["durakId"].Value);


            if (kayitSay > 0)
            {
                Durak_Load(null, null);
                MessageBox.Show("Kayıt güncellendi...");
            }
        }

        private void btn_durakSil_Click(object sender, EventArgs e)
        {
            if (dgv_durak.SelectedRows.Count == 0)
            {
                MessageBox.Show("Silinecek satırı seçiniz !!!");
                return;
            }

            int kayitSay = vt.UpdateDelete("Delete from tbl_durak where durakId =" + dgv_durak.SelectedRows[0].Cells["durakId"].Value);
            if (kayitSay > 0)
            {
                Durak_Load(null, null);
                MessageBox.Show("Kayıt silindi...");
            }
        }

        private void dgv_durak_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        

        private void dgv_durak_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_durak.SelectedRows.Count == 0)
            {
                return;
            }
            else
            {
                tx_durakAd.Text = dgv_durak.SelectedRows[0].Cells["durakAd"].Value.ToString();
                tx_durakAdres.Text = dgv_durak.SelectedRows[0].Cells["durakAdres"].Value.ToString();
                tx_durakAracSayisi.Text = dgv_durak.SelectedRows[0].Cells["durakAracSayısı"].Value.ToString();
                tx_durakSoforSayisi.Text = dgv_durak.SelectedRows[0].Cells["durakSoforSayisi"].Value.ToString();
            }
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Anasayfa ana = new Anasayfa();
            this.Hide();
            ana.Show();
        }
    }
}
