using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Proyecto_IBH_Alabanza
{
    public partial class Tabla_Usuario : Form { 


        SqlCommand comando;
        SqlDataAdapter adapter;
        DataTable datatabla;
        ConexionDB data = new ConexionDB();
        public Tabla_Usuario()
        {
            InitializeComponent();
        }

        private void Tabla_Usuario_Load(object sender, EventArgs e)
        {
            data.SeleccionEstado(cmbEstado);
            cmbEstado.SelectedIndex = 0;
            data.SeleccionDisponibilidad(cmbDias);
            cmbDias.SelectedIndex = 0;
            data.SeleccionGenero(cmbGenero);
            cmbGenero.SelectedIndex = 0;
            Buscar_Miembro("SELECT * FROM Miembro");
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
            if(txtIdentidad.TextLength > 0)
            {
                Buscar_Miembro("Select * from Miembro where identidad =", txtIdentidad.Text);
            }
            if (cmbEstado.SelectedIndex > 0)
            {
                Buscar_Miembro("Select * from Miembro where estado =", Convert.ToString(cmbEstado.SelectedIndex));
            }
            if(cmbDias.SelectedIndex > 0)
            {
                Buscar_Miembro("Select * from Miembro where id_dias =", Convert.ToString(cmbDias.SelectedIndex));
            }
            if (cmbGenero.SelectedIndex > 0)
            {
                Buscar_Miembro("Select * from Miembro where genero =", Convert.ToString(cmbGenero.SelectedIndex));
            }
        }

        public void limpiar()
        {
            txtIdentidad.Text = "";
            cmbDias.SelectedIndex = 0;
            cmbEstado.SelectedIndex = 0;
            cmbGenero.SelectedIndex = 0;
        }

        public void Buscar_Miembro(string query, string valor)
        {
            try
            {
                dtgUsuario.Rows.Clear();
                ConexionDB.enlace();
                comando = new SqlCommand(query + valor, ConexionDB.enlace());
                adapter = new SqlDataAdapter(comando);
                datatabla = new DataTable();
                adapter.Fill(datatabla);
                if (datatabla.Rows.Count > 0)
                {
                    for (int i = 0; i < datatabla.Rows.Count; i++)
                    {
                        string id = datatabla.Rows[i][12].ToString();
                        string Nombre_Completo = datatabla.Rows[i][1].ToString() + " " + datatabla.Rows[i][2].ToString();
                        string fecha = datatabla.Rows[i][3].ToString();
                        string direccion = datatabla.Rows[i][5].ToString();
                        cmbGenero.SelectedIndex = int.Parse(datatabla.Rows[i][6].ToString());
                        string genero = cmbGenero.Text;
                        string telefono = datatabla.Rows[i][9].ToString();
                        cmbEstado.SelectedIndex = int.Parse(datatabla.Rows[i][7].ToString());
                        string estado = cmbEstado.Text;
                        string bautizo = datatabla.Rows[i][10].ToString();
                        cmbDias.SelectedIndex = int.Parse(datatabla.Rows[i][11].ToString());
                        string disponibilidad = cmbDias.Text;
                        string obs = datatabla.Rows[i][8].ToString();
                        dtgUsuario.Rows.Add(id, Nombre_Completo, fecha, direccion, genero, telefono, estado, bautizo, disponibilidad, obs);
                    }
                    limpiar();
                }
                else
                {
                    MessageBox.Show("No se Encontro");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                ConexionDB.enlace().Close();
            }
        }

        public void Buscar_Miembro(string query)
        {
            try
            {
                limpiar();
                dtgUsuario.Rows.Clear();
                ConexionDB.enlace();
                comando = new SqlCommand(query, ConexionDB.enlace());
                adapter = new SqlDataAdapter(comando);
                datatabla = new DataTable();
                adapter.Fill(datatabla);
                if (datatabla.Rows.Count > 0)
                {
                    for (int i = 0; i < datatabla.Rows.Count; i++)
                    {
                        string id = datatabla.Rows[i][12].ToString();
                        string Nombre_Completo = datatabla.Rows[i][1].ToString() + " " + datatabla.Rows[i][2].ToString();
                        string fecha = datatabla.Rows[i][3].ToString();
                        string direccion = datatabla.Rows[i][5].ToString();
                        cmbGenero.SelectedIndex = int.Parse(datatabla.Rows[i][6].ToString());
                        string genero = cmbGenero.Text;
                        string telefono = datatabla.Rows[i][9].ToString();
                        cmbEstado.SelectedIndex =int.Parse(datatabla.Rows[i][7].ToString());
                        string estado = cmbEstado.Text;
                        string bautizo = datatabla.Rows[i][10].ToString();
                        cmbDias.SelectedIndex = int.Parse(datatabla.Rows[i][11].ToString());
                        string disponibilidad = cmbDias.Text;
                        string obs = datatabla.Rows[i][8].ToString();
                        dtgUsuario.Rows.Add(id, Nombre_Completo, fecha, direccion, genero, telefono, estado, bautizo, disponibilidad, obs);
                    }

                }
                limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                ConexionDB.enlace().Close();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
