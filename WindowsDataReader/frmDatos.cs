using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Datos.Admin;

namespace WindowsDataReader
{
    public partial class frmDatos : Form
    {
        public frmDatos()
        {
            InitializeComponent();
        }

        private void frmDatos_Load(object sender, EventArgs e)
        {
            
        }

        private void btnTraerPorID_Click(object sender, EventArgs e)
        {
            //gridProduct.DataSource = null;
            gridProduct.DataSource = AdmProducto.listar(Convert.ToInt32(txtTraer.Text));
        }

        private void btnTraerTodos_Click(object sender, EventArgs e)
        {
            //gridProduct.DataSource = null;
            gridProduct.DataSource = AdmProducto.listar();
        }
    }
}
