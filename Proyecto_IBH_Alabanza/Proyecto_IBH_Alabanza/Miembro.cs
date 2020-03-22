using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_IBH_Alabanza
{
    public class Miembro:Persona
    {
        protected string estado;
        protected string bautizo;
        protected string disponibilidad;
        protected string observacion;

        public Miembro(string id, string nom, string ape, string tiempo, string gen, string dir, string email, string tel, string state, string bau, string dias, string obs)
        {
            identidad = id;
            Nombre_Persona = nom;
            Apellido_Persona = ape;
            fecha = tiempo;
            genero = gen;
            direcccion = dir;
            correo = email;
            telefono = tel;
            estado = state;
            disponibilidad = dias;
            observacion = obs;
        }

        public override string Confirmacion_Usuario()
        {
            return "El Nuevo Usuario\nIdentidad: " + identidad +
                "\nNombre: " + Nombre_Persona + " " + Apellido_Persona +
                "\nGenero: " + genero + "\nEstado: " + estado + "\nDisponibilidad: " + disponibilidad;

        }

        public void guardar_Usuario()
        {

        }
    }
}
