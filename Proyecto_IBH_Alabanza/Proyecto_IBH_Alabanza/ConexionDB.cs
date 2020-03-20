using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Proyecto_IBH_Alabanza
{
    public class ConexionDB
    {

        public static SqlConnection enlace()
        {
            SqlConnection conexion_Data = new SqlConnection("Data Source = DESKTOP-S0OC9DG\\SQLEXPRESS; Initial Catalog = IBH_Ministerio_Alabanza; Integrated Security = True");
            conexion_Data.Open();
            return conexion_Data;
        }

    }
}
