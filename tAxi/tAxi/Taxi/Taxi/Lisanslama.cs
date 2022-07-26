using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using Microsoft.Win32;
using System.Security.Cryptography;
using System.IO;

namespace Taxi
{
    public partial class Lisanslama : Form
    {
        public Lisanslama()
        {
            InitializeComponent();
        }

        private void Lisanslama_Load(object sender, EventArgs e)
        {
            string seriNo_cpu = CPUSeriNoCek();
            string seriNo_hdd = "";
            foreach (var item in HDDSeriNoCek())
            {
                seriNo_hdd += item;
            }
            string seriNo_birlesik = seriNo_cpu + "-" + seriNo_hdd.Trim();
            string seriNo_degisen = "";
            foreach (var item in seriNo_birlesik)
            {
                if (item == '0')
                    seriNo_degisen += "T";
                else if (item == 'B')
                    seriNo_degisen += "S";
                else if (item == 'T')
                    seriNo_degisen += "B";
                else if (item == 'S')
                    seriNo_degisen += "0";
                else
                    seriNo_degisen += item;

            }
            seriNo_degisen = seriNo_degisen.Substring(0, seriNo_degisen.Length - 4).ToUpper();
            string serino_MD5 = MD5Sifrele(seriNo_degisen).ToUpper();
            string anahtarKodu = serino_MD5.Substring(1, 2) +
                                  serino_MD5.Substring(4, 3) +
                                  serino_MD5.Substring(9, 1) +
                                  serino_MD5.Substring(12, 4) +
                                  serino_MD5.Substring(18, 2) +
                                  serino_MD5.Substring(25, 2) +
                                  serino_MD5.Substring(29, 2);
            anahtarKodu = anahtarKodu.Insert(12, "-").Insert(8, "-").Insert(4, "-");
            tx_anahatarKodu.Text = anahtarKodu;

        }

        public static String CPUSeriNoCek()
        {
            String processorID = "";
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("Select * FROM WIN32_Processor");
            ManagementObjectCollection mObject = searcher.Get();

            foreach (ManagementObject obj in mObject)
            {
                processorID = obj["ProcessorId"].ToString();
            }

            return processorID;
        }
        public static List<string> HDDSeriNoCek()
        {
            List<string> serials = new List<string>();
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMedia");
            ManagementObjectCollection disks = searcher.Get();
            foreach (ManagementObject disk in disks)
            {
                if (disk["SerialNumber"] == null)
                {
                    //  serials.Add("");
                }
                else
                    serials.Add(disk["SerialNumber"].ToString());
            }
            List<string> s = new List<string>();
            s.Add(serials[0]);
            return s;
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

        private void btn_lisansla_Click(object sender, EventArgs e)
        {
            string uygulamaAnahtarKodu = tx_anahatarKodu.Text + "KelimeEzber1.0";
            string serino_MD5 = MD5Sifrele(uygulamaAnahtarKodu);
            string lisansKodu = serino_MD5.Substring(1, 2) +
                                  serino_MD5.Substring(4, 3) +
                                  serino_MD5.Substring(9, 1) +
                                  serino_MD5.Substring(12, 4) +
                                  serino_MD5.Substring(18, 2) +
                                  serino_MD5.Substring(25, 2) +
                                  serino_MD5.Substring(29, 2);
            lisansKodu = lisansKodu.Insert(12, "-").Insert(8, "-").Insert(4, "-");
            //tx_lisansKodu.Text = lisansKodu;

            if (tx_lisansKodu.Text == lisansKodu)
            {
                StreamWriter sw = new StreamWriter("lisans.l", false, Encoding.Default);
                sw.WriteLine(lisansKodu);
                sw.Close();
                MessageBox.Show("Lisanslama işlemi tamamlandı. \nUygulama Yeniden Başlatılıyor");
                Application.Restart();
            }
            else
            {
                MessageBox.Show("Lisans kodu hatalı...");
            }
        }
    }
}
