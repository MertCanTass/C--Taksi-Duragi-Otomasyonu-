using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace Taxi
{
    internal static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            if (File.Exists("lisans.l"))
            {
                StreamReader sr = new StreamReader("lisans.l", Encoding.Default);
                string oku_lisans = sr.ReadLine();
                sr.Close();
                if (LisansIslemleri.LisansKontrol(oku_lisans))
                    Application.Run(new Form1());
                else
                {
                    MessageBox.Show("Lisans Kodu Geçersiz");
                    Application.Run(new Lisanslama());
                }
            }
            else
                Application.Run(new Lisanslama());
        }
    }
}
