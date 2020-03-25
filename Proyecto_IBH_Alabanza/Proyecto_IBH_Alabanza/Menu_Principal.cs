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
    public partial class Menu_Principal : Form
    {
        public Menu_Principal()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Menu_Principal_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void bntNuevacancion_Click(object sender, EventArgs e)
        {
            Form_canciones pantalla_canciones = new Form_canciones();
            pantalla_canciones.Show();
            this.Visible = false;
        }

        private void btnNuevoInventario_Click(object sender, EventArgs e)
        {
            Inventario pantalla_Inventario = new Inventario();
            pantalla_Inventario.Show();
            this.Visible = false;
        }

        private void mantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenimiento_Usuario man_usuario = new Mantenimiento_Usuario();
            man_usuario.Show();
        }

        private void tablaDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void tablasDeResultadosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nuevaCancionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_canciones pantalla_canciones = new Form_canciones();
            pantalla_canciones.Show();
            this.Visible = false;
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nuevaPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nuevo_Usuario pantalla_Nuevousuario = new Nuevo_Usuario();
            pantalla_Nuevousuario.Show();
            this.Visible = false;
        }

        private void datosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nuevoIngresoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inventario pantalla_Inventario = new Inventario();
            pantalla_Inventario.Show();
            this.Visible = false;
        }

        private void bntCalendario_Click(object sender, EventArgs e)
        {

        }

        private void tablaDeResultadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tabla_Usuario resultadoUsuario = new Tabla_Usuario();
            resultadoUsuario.Show();
            this.Visible = false;
        }

        private void archivosToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
