using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FileOperations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //system .IO namespace ((Ad alanı), dosyaları ve veri akışları için okuma ve yazöa sağlayan türler ve temel dosya ve dizin desteği sağlayantürleri içerir.

        private void btnDriverInfo_Click(object sender, EventArgs e)
        {
            DriveInfo[] tumSurucler=DriveInfo.GetDrives();

            foreach (DriveInfo item in tumSurucler)
            {
                MessageBox.Show(item.Name);
                MessageBox.Show(item.TotalFreeSpace.ToString());
                MessageBox.Show(item.TotalSize.ToString());
                MessageBox.Show(item.VolumeLabel);
            }
        }

        private void btnDirectory_Click(object sender, EventArgs e)
        {
            if (Directory.Exists("C:\\Yaren"))
            {
                Directory.Delete("C:\\Yaren");
            }
          //  Directory.CreateDirectory("C:\\Yaren");
        }
    }
}
