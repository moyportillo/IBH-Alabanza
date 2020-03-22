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
    public partial class Nuevo_Usuario_Datos : Form
    {
        public Nuevo_Usuario_Datos()
        {
            InitializeComponent();
        }

        ConexionDB data = new ConexionDB();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Compartir_Datos.estado = cmbEstado.Text;
            if (rbtnSi.Checked)
            {
                Compartir_Datos.bautizo = "Si";
            }
            if (rbtnNo.Checked)
            {
                Compartir_Datos.bautizo = "No";
            }
            Compartir_Datos.disponibilidad = cmbDias.Text;
            Compartir_Datos.observacion = txtObs.Text;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Desea Cancelar el Registro?\nPerdera el total de la informacion Ingresada.", "¡PREGUNTA!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Nuevo_Usuario pantalla_User = new Nuevo_Usuario();
                this.Close();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

        }

        private void Nuevo_Usuario_Datos_Load(object sender, EventArgs e)
        {
            data.SeleccionEstado(cmbEstado);
            data.SeleccionDisponibilidad(cmbDias);
        }

        private void ckAudio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
