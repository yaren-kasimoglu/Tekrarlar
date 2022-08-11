using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enumss
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //if (level==Level.Low)
            //{

            //}

            Level sinir = Level.Medium;

            MessageBox.Show(sinir.ToString());
        }


    }
}
 //Low:0
 //Medium:1
 //High:2

enum Level
{
    Low,
    Medium,
    High,
}

enum TransferType
{
    CreditCard=2,//istersek değer vererwk de kullanabiliriz. bundan sonrakiler sırayla 3,4 gibi gider. ama diğerlerine farklı değerler de veebiliriz.
    Eft,
    shift,
}
