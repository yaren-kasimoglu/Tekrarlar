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
    public partial class FormCustomer : Form
    {
        public FormCustomer()
        {
            InitializeComponent();
        }

        private Customer _customer;

        public Customer Customer
        {
            get { return _customer; }
            set { _customer = value; }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_customer==null)
            {
                _customer = new Customer();

            }
            _customer.CustomerName = txtCustomerName.Text;
            _customer.Adres = txtAdres.Text;

            this.DialogResult= DialogResult.OK;
            this.Close();
        }
    }
}
