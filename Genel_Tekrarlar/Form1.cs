using Genel_Tekrarlar.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Genel_Tekrarlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Faktoriyel faktoriyel=new Faktoriyel();


        private void btnHesapla_Click(object sender, EventArgs e)
        {

            faktoriyel.Deger=Convert.ToInt32(txtSayi.Text);
            label1.Text=faktoriyel.Deger.ToString();

        }
    }
}
