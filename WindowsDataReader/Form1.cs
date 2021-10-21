using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Namespace proveedor de SQL
using System.Data.SqlClient;

using WindowsDataReader.Models;



namespace WindowsDataReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTraerProductos_Click(object sender, EventArgs e)
        {
            //Una variable para leer la connection string en App.Congif
            string cadena = WindowsDataReader.Properties.Settings.Default.KeyNorthwind;

            //Crear un objeto de conexion y asignarle mi cadena

            SqlConnection connection = new SqlConnection(cadena);

            //Variable de consulta (query) SQL (copiado desde el SSMS)

            string consultaSQL = "SELECT ProductID,ProductName,SupplierID,CategoryID,QuantityPerUnit,UnitPrice,UnitsInStock,UnitsOnOrder,ReorderLevel,Discontinued FROM dbo.Products";

            //Crear un objeto de SqlCommand

            SqlCommand command = new SqlCommand(consultaSQL, connection);

            //Declarar un objeto SqlDataReader

            SqlDataReader dataReader;

            //Abrir conexion
            connection.Open();

            //Crear el reader
            dataReader = command.ExecuteReader();

            //Recorrer/leer los datos hacia adelante (secuencialmente)

            List<Product> products = new List<Product>();

            //El read devuelve true siempre que haya algo para leer
            while (dataReader.Read())
            {
                products.Add(new Product()
                {
                        ProductID = (int)dataReader["ProductID"],
                        ProductName = (string)dataReader["ProductName"],
                        SupplierID = (int)dataReader["SupplierID"],
                        CategoryID = (int)dataReader["CategoryID"],
                        QuantityPerUnit = (string)dataReader["QuantityPerUnit"],
                        UnitPrice = (decimal)dataReader["UnitPrice"],
                        UnitsInStock = (short)dataReader["UnitsInStock"],
                        UnitsOnOrder = (short)dataReader["UnitsOnOrder"],
                        ReorderLevel = (short)dataReader["ReorderLevel"],
                        Discontinued = (bool)dataReader["Discontinued"]
                }
                    );
            }

            //Cerrar la conexion a la base y el reader

            connection.Close();
            dataReader.Close();

            //Mostrar los datos

            gridProduct.DataSource = products;
        }
    }
}
