using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Proyecto_IBH_Alabanza
{
    public class ConexionDB
    {
        SqlConnection conectar;
        SqlCommand comando;
        SqlDataReader dataleer;

        public static SqlConnection enlace()
        {
            SqlConnection conexion_Data = new SqlConnection("Data Source = DESKTOP-S0OC9DG\\SQLEXPRESS; Initial Catalog = IBH_Ministerio_Alabanza; Integrated Security = True");
            conexion_Data.Open();
            return conexion_Data;
        }

        public void SeleccionGenero(ComboBox t)
        {
            conectar = ConexionDB.enlace();
            comando = new SqlCommand(string.Format("SELECT descripcion_genero FROM Genero"), conectar);
            dataleer = comando.ExecuteReader();

            while (dataleer.Read())
            {
                t.Items.Add(dataleer[0].ToString());
            }
            conectar.Close();
            t.Items.Insert(0, "Seleccione su Genero");
            t.SelectedIndex = 0;
            return;
        }

        public void SeleccionEstado(ComboBox t)
        {
            conectar = ConexionDB.enlace();
            comando = new SqlCommand(string.Format("SELECT descripcion_estado FROM Tipo_Estado"), conectar);
            dataleer = comando.ExecuteReader();

            while (dataleer.Read())
            {
                t.Items.Add(dataleer[0].ToString());
            }
            conectar.Close();
            t.Items.Insert(0, "Seleccione un Estado");
            t.SelectedIndex = 0;
            return;
        }

        public void SeleccionDisponibilidad(ComboBox t)
        {
            conectar = ConexionDB.enlace();
            comando = new SqlCommand(string.Format("SELECT descripcion_dias FROM Dias"), conectar);
            dataleer = comando.ExecuteReader();

            while (dataleer.Read())
            {
                t.Items.Add(dataleer[0].ToString());
            }
            conectar.Close();
            t.Items.Insert(0, "Seleccione su Disponibilidad");
            t.SelectedIndex = 0;
            return;
        }

        

    }
}
