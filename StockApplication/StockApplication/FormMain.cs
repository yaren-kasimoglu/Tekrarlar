using StockApplication.Model1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockApplication
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }


        //yapıcı metot constructor
        private string _userName;
        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            initForm();
        }
        private void initForm()
        {
            this.lblUserame.Text = _userName;
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); //uygulamayı tamamen kapat
        }

       List<Customer> customers = new List<Customer>();

        private void müşteriListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // customers.Add(new Customer() { Id=1 , CustomerName="Yaren Kas",Adres="İzmit Kocaeli"});
            

           FormCustomerList formCustomerList = new FormCustomerList();
            formCustomerList.Customers = customers;

            formCustomerList.ShowDialog();

        }

        private void yeniMusteriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCustomer formCustomer=new FormCustomer();
            DialogResult result=formCustomer.ShowDialog();

            if (result == DialogResult.OK)
            {
                //eğer formda işlem iptal edilmesi ise ok ise işleme devam edeceğim

               var customer= formCustomer.Customer;
                customers.Add(customer);
            }

        }
    }
}
//bir formun kontrolünü farklı formlara açmak güvenilirlik sebebi ile sıkıntılı olabilir. Bunun yerine property tanımlayıp veriyi çekeceğimiz forma alıp metot ile veriyi forma çekebiliriz