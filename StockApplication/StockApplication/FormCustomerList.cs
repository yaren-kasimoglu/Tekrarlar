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
    public partial class FormCustomerList : Form
    {
        public FormCustomerList()
        {
            InitializeComponent();
        }

        private List<Customer> _customers;

        public List<Customer> Customers
        {
            get { return _customers; }
            set { _customers = value; }
        }

        private void FormCustomerList_Load(object sender, EventArgs e)
        {
            initForm();
        }

        private void initForm()
        {
            GridSetDataSource();
        }

        private void GridSetDataSource()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = this.Customers;
        }
    }
}
