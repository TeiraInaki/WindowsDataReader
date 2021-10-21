﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace Datos.Server
{
    internal static class AdminDB
    {
        internal static SqlConnection ConectarBD()
        {
            string cadena = Datos.Properties.Settings.Default.KeyDBNorthwind;
            SqlConnection connection = new SqlConnection(cadena);
            connection.Open();

            return connection;  //Habria q implementar patron de diseño
        }
    }
}
