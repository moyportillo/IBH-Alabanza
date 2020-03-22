using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_IBH_Alabanza
{
    public partial class Nuevo_Usuario : Form
    {
        public Nuevo_Usuario()
        {
            InitializeComponent();
        }

        ConexionDB data = new ConexionDB();

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Regresar al Menu Principal?\nPerdera la informacion Ingresada.", "¡PREGUNTA!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Menu_Principal pantalla_Menu = new Menu_Principal();
                this.Close();
                pantalla_Menu.Visible = true;
            }
            
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            Miembro datos_Miembro = new Miembro(txtId.Text, txtNombre.Text, txtApellido.Text, datetime_Fecha.Text, cmbGenero.Text, txtdireccion.Text, txtCorreo.Text, txtTelefono.Text, Compartir_Datos.estado, Compartir_Datos.bautizo, Compartir_Datos.disponibilidad, Compartir_Datos.observacion);
            MessageBox.Show("¡AGREGADO NUEVO USUARIO!\n"+datos_Miembro.Confirmacion_Usuario(), "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cmbGenero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Nuevo_Usuario_Load(object sender, EventArgs e)
        {
            data.SeleccionGenero(cmbGenero);
            cmbUsuario.SelectedIndex = 0;
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cmbUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            Nuevo_Usuario_Datos new_miembro = new Nuevo_Usuario_Datos();
            Nuevo_Candidato new_candidato = new Nuevo_Candidato();

            if(cmbUsuario.Text == "MINISTERIO")
            {
                new_miembro.Show();
            }
            if(cmbUsuario.Text == "CANDIDATO")
            {
                new_candidato.Show();
            }
        }
    }
}
