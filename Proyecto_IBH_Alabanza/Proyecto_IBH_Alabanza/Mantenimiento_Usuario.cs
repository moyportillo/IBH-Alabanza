using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto_IBH_Alabanza
{
    public partial class Mantenimiento_Usuario : Form
    {
        SqlCommand comando;
        SqlDataAdapter adapter;
        DataTable datatabla;
        ConexionDB database = new ConexionDB();
        public Mantenimiento_Usuario()
        {
            InitializeComponent();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar_Usuario(txtIdentidad.Text);
        }

        public void Buscar_Usuario(string id)
        {
            ConexionDB.enlace();
            comando = new SqlCommand("SELECT * FROM Miembro where identidad = @id_user", ConexionDB.enlace());
            comando.Parameters.AddWithValue("id_user", id);
            adapter = new SqlDataAdapter(comando);
            datatabla = new DataTable();
            adapter.Fill(datatabla);
            if(datatabla.Rows.Count == 1)
            {
                txtNombre.Text = datatabla.Rows[0][1].ToString();
                txtApellido.Text = datatabla.Rows[0][2].ToString();
                datetime_Fecha.Text = datatabla.Rows[0][3].ToString();
                cmbGenero.SelectedIndex = int.Parse(datatabla.Rows[0][6].ToString());
                txtdireccion.Text = datatabla.Rows[0][5].ToString();
                txtCorreo.Text = datatabla.Rows[0][4].ToString();
                txtTelefono.Text = datatabla.Rows[0][9].ToString();
                cmbUsuario.SelectedIndex = 1;
                cmbEstado.SelectedIndex = int.Parse(datatabla.Rows[0][7].ToString());
                if(datatabla.Rows[0][10].ToString() == "Si")
                {
                    rbtnSi.Checked = true;
                }
                else
                {
                    rbtnNo.Checked = true;
                }
                cmbDias.SelectedIndex = int.Parse(datatabla.Rows[0][11].ToString());
                txtObs.Text = datatabla.Rows[0][8].ToString();
                gbDatos.Enabled = true;
                gbInfo.Enabled = true;
                btneliminar.Enabled = true;
                btnGuardar.Enabled = true;
                txtIdentidad.Enabled = false;
                btnBuscar.Enabled = false;
            }
            ConexionDB.enlace().Close();
        }

        private void Mantenimiento_Usuario_Load(object sender, EventArgs e)
        {
            gbDatos.Enabled = false;
            gbInfo.Enabled = false;
            btnGuardar.Enabled = false;
            btneliminar.Enabled = false;
            database.SeleccionGenero(cmbGenero);
            cmbGenero.SelectedIndex = 0;
            database.SeleccionEstado(cmbEstado);
            cmbEstado.SelectedIndex = 0;
            database.SeleccionDisponibilidad(cmbDias);
            cmbDias.SelectedIndex = 0;

        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string bau = "";
            if(rbtnSi.Text == "Si")
            {
                bau = "Si";
            }
            if(rbtnSi.Text == "No")
            {
                bau = "No";
            }
            try
            {
                ConexionDB.enlace();
                comando = new SqlCommand("update Miembro set nombre_miembro ='" + txtNombre.Text + "', apellido_miembro = '" + txtApellido.Text + "', fecha = '" + datetime_Fecha.Text + "', correo = '" + txtCorreo.Text + "', direccion_miembro = '" + txtdireccion.Text + "', genero = '" + cmbGenero.SelectedIndex + "', estado = '" + cmbUsuario.SelectedIndex + "', observacion = '" + txtObs.Text + "', telefono = '" + txtTelefono.Text + "', bautizo = '" + bau + "', id_dias = '" + cmbDias.SelectedIndex + "' where identidad = '"+txtIdentidad.Text+"'", ConexionDB.enlace());
                if (comando.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Miembro Modificado Exitosamente\nContacto #: " + txtIdentidad.Text + "\nNombre completo: " + txtNombre.Text + " " + txtApellido.Text, "Modificacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocurrio un Problema: "+ ex.ToString() , "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ConexionDB.enlace().Close();
            }
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        public void Limpiar()
        {
            txtIdentidad.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtCorreo.Text = "";
            txtdireccion.Text = "";
            txtObs.Text = "";
            txtTelefono.Text = "";
            cmbDias.SelectedIndex = 0;
            cmbGenero.SelectedIndex = 0;
            cmbUsuario.SelectedIndex = 0;
            cmbEstado.SelectedIndex = 0;
            rbtnNo.Checked = false;
            rbtnSi.Checked = false;
            gbDatos.Enabled = false;
            gbInfo.Enabled = false;
            btneliminar.Enabled = true;
            txtIdentidad.Enabled = true;
            btnBuscar.Enabled = true;
            btnGuardar.Enabled = false;
            btneliminar.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("El Contacto #: " + txtIdentidad.Text + "\nNombre Completo: " + txtNombre.Text + " " + txtApellido.Text + "\n¿Desea eliminar el contacto?", "Eliminar Miembro", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes){
                ConexionDB.enlace();
            comando = new SqlCommand("DELETE FROM Miembro where identidad ='" + txtIdentidad.Text + "'", ConexionDB.enlace());
            comando.ExecuteNonQuery();
            Limpiar();
            }
        }
    }
}
