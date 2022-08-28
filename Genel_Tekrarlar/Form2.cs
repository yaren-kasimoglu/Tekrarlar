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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        Mirasci_Sinif mirasci=new Mirasci_Sinif();
        private void btnTuret_Click(object sender, EventArgs e)
        {
            textBox1.Text = mirasci.Turet().ToString();

        }
    }
}
