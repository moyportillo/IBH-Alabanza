using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Proyecto_IBH_Alabanza
{
    public class Miembro:Persona
    {
        SqlConnection conectar;
        SqlCommand comando;

        protected int estado;
        protected string bautizo;
        protected int disponibilidad;
        protected string observacion;

        public Miembro(string id, string nom, string ape, string tiempo, int gen, string dir, string email, string tel, int state, string bau, int dias, string obs)
        {
            identidad = id;
            Nombre_Persona = nom;
            Apellido_Persona = ape;
            fecha = tiempo;
            genero = gen;
            direccion = dir;
            correo = email;
            telefono = tel;
            estado = state;
            disponibilidad = dias;
            observacion = obs;
            bautizo = bau;
        }

        public override string Confirmacion_Usuario()
        {
            return "El Nuevo Usuario\nIdentidad: " + identidad +
                "\nNombre: " + Nombre_Persona + " " + Apellido_Persona +
                "\nGenero: " + genero + "\nEstado: " + estado + "\nDisponibilidad: " + disponibilidad;

        }

        public bool guardar_Usuario()
        {
            conectar = ConexionDB.enlace();
            comando = new SqlCommand(string.Format("INSERT INTO Miembro (identidad, nombre_miembro, apellido_miembro, fecha, correo, direccion_miembro, genero, estado, observacion, telefono, bautizo, id_dias)" +
                " values ('"+identidad+"', '"+Nombre_Persona+"', '"+Apellido_Persona+"', '"+fecha+ "', '" + correo+ "', '" +direccion + "', '" +genero+ "'," +
                " '" + estado + "', '" + observacion+ "', '" +telefono+ "', '" + bautizo+ "', " + disponibilidad+")",identidad, Nombre_Persona, Apellido_Persona, fecha, correo, direccion, genero, estado, observacion, telefono, bautizo, disponibilidad ), conectar);
            if(comando.ExecuteNonQuery() > 0)
            {
                conectar.Close();
                return true;
            }
            else
            {
                conectar.Close();
                return false;
            }
        }
    }
}
