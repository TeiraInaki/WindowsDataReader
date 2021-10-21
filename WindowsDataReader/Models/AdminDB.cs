using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace WindowsDataReader.Models
{
    //La declar internal por un tema de seguridad
    //(la visibilidad es a nivel proyecto)
    internal static class AdminDB
    {
        internal static List<Customer> cargarClientes(string Key, string Query)
        {
            //Inicio la conexiona la BD
            SqlConnection connection = new SqlConnection(Key);

            //Creo el command
            SqlCommand command = new SqlCommand(Query, connection);

            //Declaro reader
            SqlDataReader dataReader;

            //Abro la conexion
            connection.Open();

            //Creo el reader
            dataReader = command.ExecuteReader();

            //Cargo los datos

            List<Customer> clientes = new List<Customer>();

            while (dataReader.Read())
            {
                clientes.Add(new Customer() 
                {
                    CustomerID = (string)dataReader["CustomerID"],
                    CompanyName = (string)dataReader["CompanyName"],
                    ContactName = (string)dataReader["ContactName"],
                    ContactTitle = (string)dataReader["ContactTitle"],
                    Address = (string)dataReader["Address"],
                    City = (string)dataReader["City"],
                    
                    //Los que deje comentados es pq algunos tienen valores NULL 
                    Region = (dataReader["Region"] == DBNull.Value) ? string.Empty : (string)dataReader["Region"],
                    PostalCode = (dataReader["PostalCode"] == DBNull.Value) ? string.Empty : (string)dataReader["PostalCode"],
                    Country = (string)dataReader["Country"],
                    Phone = (string)dataReader["Phone"],
                    Fax = (dataReader["Fax"] == DBNull.Value) ? string.Empty : (string)dataReader["Fax"]
                });
            }

            connection.Close();
            dataReader.Close();

            return clientes;
        }
    }
}
