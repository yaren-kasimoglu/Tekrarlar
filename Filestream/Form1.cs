using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filestream
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //FileStream: 
        //file stream ile diskte bulunan bir dosyaya ulaşım sağlayabiliriz.
        //stream reader ve stream writer ie de açılan bir dosya üzerinde okuma ve yazma işlemleri yapabiliriz
        //dosya üzerinde metin veya byte tabanlı işlemler yapılabilir.
        //ReaD()( veya REAdBYTE metotlar ile byte veri okumamızı sağlar
        // /Reeadbyte okuma yapmazsa geriye -1 değer döndürür.

        string filePath;

        private void btnDosyaSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Metin Dosyaları | *.txt";



            ofd.ShowDialog();

            filePath = ofd.FileName;

            txtDosyaAdi.Text = ofd.FileName;

        }

        private void btnDosyayaYaz_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(filePath);
            string gelenMetin = sr.ReadToEnd();

            sr.Close();

            gelenMetin=gelenMetin + "\n" + txtMetin.Text;

            StreamWriter sw= new StreamWriter(filePath);
            sw.Write(gelenMetin);

            sw.Close();

            txtMetin.Text=string.Empty;

        }

        private void btnDosyadanOku_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(filePath);
            string gelenMetin = sr.ReadToEnd();
            txtMetin.Text = gelenMetin;
            sr.Close();
        }
    }
}
