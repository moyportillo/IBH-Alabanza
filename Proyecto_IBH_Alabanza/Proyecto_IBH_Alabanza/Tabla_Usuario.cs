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
    public partial class Tabla_Usuario : Form
    {
        public Tabla_Usuario()
        {
            InitializeComponent();
        }

        private void Tabla_Usuario_Load(object sender, EventArgs e)
        {

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Menu_Principal menu = new Menu_Principal();
            this.Close();
            menu.Visible = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cmbDias_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
        }

        public void limpiar()
        {
            txtIdentidad.Text = "";
            cmbDias.SelectedIndex = 0;
            cmbEstado.SelectedIndex = 0;
            cmbTalento.SelectedIndex = 0;
        }
    }
}
