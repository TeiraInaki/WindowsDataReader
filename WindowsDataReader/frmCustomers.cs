using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WindowsDataReader.Models;

namespace WindowsDataReader
{
    public partial class frmCustomers : Form
    {
        public frmCustomers()
        {
            InitializeComponent();
        }

        private void btnTraerClientes_Click(object sender, EventArgs e)
        {
            string Key = WindowsDataReader.Properties.Settings.Default.KeyNorthwind;
            string Query = "SELECT CustomerID,CompanyName,ContactName,ContactTitle,Address,City,Region,PostalCode,Country,Phone,Fax FROM dbo.Customers";

            gridClientes.DataSource = AdminDB.cargarClientes(Key, Query);
        }
    }
}
