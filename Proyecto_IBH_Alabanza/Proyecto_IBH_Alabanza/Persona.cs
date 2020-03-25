using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_IBH_Alabanza
{
    public class Persona
    {
        protected string identidad;
        protected string Nombre_Persona;
        protected string Apellido_Persona;
        protected string fecha;
        protected int genero;
        protected string direccion;
        protected string correo;
        protected string telefono;

        public Persona()
        {

        }

        public Persona(string id, string nom, string ape,  string tiempo, int gen, string dir, string email, string tel)
        {
            identidad = id;
            Nombre_Persona = nom;
            Apellido_Persona = ape;
            fecha = tiempo;
            genero = gen;
            direccion = dir;
            correo = email;
            telefono = tel;
        }

        public virtual string Confirmacion_Usuario()
        {
            return "El Nuevo Usuario\nIdentidad: " + identidad +
                "\nNombre: " + Nombre_Persona + " " + Apellido_Persona+
                "\nGenero: "+genero;
        }
    }
}
