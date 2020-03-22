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
    public partial class Form_canciones : Form
    {
        public Form_canciones()
        {
            InitializeComponent();
        }

        private void Canciones_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Menu_Principal menu = new Menu_Principal();
            this.Close();
            menu.Visible = true;

        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdias_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdiscipulado_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {

        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
