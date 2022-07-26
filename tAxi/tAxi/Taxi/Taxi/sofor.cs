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
    public partial class sofor : Form
    {
        public sofor()
        {
            InitializeComponent();
        }
        Veritabani vt=new Veritabani();
        private void sofor_Load(object sender, EventArgs e)
        {
            dgv_sofor.DataSource = vt.Select("select soforId,soforAd,soforSoyad,soforMail,soforTel,soforAdres,soforTc from tbl_sofor");
            dgv_sofor.Columns["soforId"].Visible = false;
            
        }
        private void btn_resimyukle_Click(object sender, EventArgs e)
        {
            //pcbx_sofor.SizeMode=PictureBoxSizeMode.Zoom;
            //openFileDialog1.ShowDialog();
            //pcbx_sofor.ImageLocation = openFileDialog1.FileName;
            //string dosyayolu = openFileDialog1.FileName;
            //label1.Text = dosyayolu;
            //pcbx_sofor.ImageLocation = dosyayolu;
        }

        private void btn_soforEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (tx_soforAd.Text == "" || tx_soforSoyad.Text == "" || tx_soforMail.Text == "" || tx_soforTel.Text == "" || tx_soforAdres.Text == "" || tx_soforTc.Text == "")
                {
                    MessageBox.Show("Lütfen Tüm Alanları Doldurunuz");
                }

                if (tx_soforAd.Text.Length < 2)
                {
                    MessageBox.Show("Ad en az 2 karakter olmalıdır.");
                    return;
                }
                if (tx_soforSoyad.Text.Length < 2)
                {
                    MessageBox.Show("Soyad en az 2 karakter olmalıdır.");
                    return;
                }
                if (tx_soforTc.Text.Length != 11)
                {
                    MessageBox.Show("TcNo 11 karakter olmalıdır !!!");
                    return;
                }
                if (tx_soforTel.Text.Length != 10)
                {
                    MessageBox.Show("Tel 10 karakter olmalıdır !!!");
                    return;
                }
                if (tx_soforAdres.Text.Length == 0)
                {
                    MessageBox.Show("Adresiniz boş bırakılamaz.");
                    return;
                }
                if (!tx_soforMail.Text.Contains("@"))//@ yoksa hata verecek
                {
                    MessageBox.Show("Lütfen geçerli bir Mail giriniz.");
                    return;
                }
                object kayitSay = vt.Insert(@"insert into tbl_sofor(soforAd,soforSoyad,soforMail,soforTel,soforAdres,soforTc)
                                        values('" + tx_soforAd.Text + "','" + tx_soforSoyad.Text + "','" + tx_soforMail.Text + "','" + tx_soforTel.Text + "','" + tx_soforAdres.Text + "','" + tx_soforTc.Text + "')");

                if (Convert.ToInt32(kayitSay) > 0)
                {
                    sofor_Load(null, null);
                    MessageBox.Show("Kayıt Eklendi...");
                }
               }
                catch
                    {
                MessageBox.Show("Test");
            }
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Anasayfa ana = new Anasayfa();
            this.Hide();
            ana.Show();
        }

        private void btn_soforGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                int kayitSay = vt.UpdateDelete(@"update tbl_sofor
                                           set soforAd='" + tx_soforAd.Text + @"',      
                                               soforSoyad='" + tx_soforSoyad.Text + @"',
                                               soforMail='" + tx_soforMail.Text + @"',
                                               soforTel='" + tx_soforTel.Text + @"',
                                                soforAdres='" + tx_soforAdres.Text + @"',
                                             soforTc='" + tx_soforTc.Text + @"'
                                            where soforId=" + dgv_sofor.SelectedRows[0].Cells["soforId"].Value);


                if (kayitSay > 0)
                {
                    sofor_Load(null, null);
                    MessageBox.Show("Kayıt güncellendi...");
                }
            }
            catch
            {
                MessageBox.Show("Test");
            }
        }
        private void dgv_sofor_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgv_sofor.SelectedRows.Count == 0)
                {
                    return;
                }
                else
                {
                    tx_soforAd.Text = dgv_sofor.SelectedRows[0].Cells["soforAd"].Value.ToString();
                    tx_soforSoyad.Text = dgv_sofor.SelectedRows[0].Cells["soforSoyad"].Value.ToString();
                    tx_soforMail.Text = dgv_sofor.SelectedRows[0].Cells["soforMail"].Value.ToString();
                    tx_soforTel.Text = dgv_sofor.SelectedRows[0].Cells["soforTel"].Value.ToString();
                    tx_soforAdres.Text = dgv_sofor.SelectedRows[0].Cells["soforAdres"].Value.ToString();
                    tx_soforTc.Text = dgv_sofor.SelectedRows[0].Cells["soforTc"].Value.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Test");
            }
        }

        private void btn_soforSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_sofor.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Silinecek satırı seçiniz !!!");
                    return;
                }

                int kayitSay = vt.UpdateDelete("Delete from tbl_sofor where soforId =" + dgv_sofor.SelectedRows[0].Cells["soforId"].Value);
                if (kayitSay > 0)
                {
                    sofor_Load(null, null);
                    MessageBox.Show("Kayıt silindi...");
                }
            }
            catch
            {
                MessageBox.Show("Test");
            }
        }

      
    }
}
