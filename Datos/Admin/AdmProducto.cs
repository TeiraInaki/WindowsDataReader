using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Datos.Models;
using Datos.Server;

namespace Datos.Admin
{
    public static class AdmProducto
    {
        public static List<Product> listar()
        {
            //Variable de consulta (query) SQL (copiado desde el SSMS)

            string consultaSQL = "SELECT ProductID,ProductName,SupplierID,CategoryID,QuantityPerUnit,UnitPrice,UnitsInStock,UnitsOnOrder,ReorderLevel,Discontinued FROM dbo.Products";

            //Crear un objeto de SqlCommand

            SqlCommand command = new SqlCommand(consultaSQL, AdminDB.ConectarBD());

            //Declarar un objeto SqlDataReader

            SqlDataReader dataReader;

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

            AdminDB.ConectarBD().Close();
            dataReader.Close();

            return products;
        }

        //Le agrego sobrecarga al metodo para que sea posible buscar por CategoriaID
        public static List<Product> listar(int CategoriaID)
        {
            //Variable de consulta (query) SQL (copiado desde el SSMS)

            string consultaSQL = "SELECT ProductID,ProductName,SupplierID, CategoryID,QuantityPerUnit,UnitPrice,UnitsInStock,UnitsOnOrder,ReorderLevel,Discontinued FROM dbo.Products WHERE CategoryID=@CategoryID";

            //Crear un objeto de SqlCommand

            SqlCommand command = new SqlCommand(consultaSQL, AdminDB.ConectarBD());

            //Decalro el parametro de SQL Server y lo igualo a el parametro que recibe mi metodo
            //DE esa manera el Sql me devuelve todos los products con esa CategoriaID
            command.Parameters.Add("@CategoryID", SqlDbType.Int).Value = CategoriaID;

            //Declarar un objeto SqlDataReader

            SqlDataReader dataReader;

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

            AdminDB.ConectarBD().Close();
            dataReader.Close();

            return products;
        }
    }
}
