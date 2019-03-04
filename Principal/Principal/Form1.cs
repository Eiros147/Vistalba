using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.OleDb;

namespace Principal
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection conexion = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Club Vistalba.accdb;
Persist Security Info=False;");
        OleDbCommand comando = new OleDbCommand();

        private void socioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.socioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.club_VistalbaDataSet);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            NuevoUsuario nuform = new NuevoUsuario();
            nuform.ShowDialog();
            this.dgvSocio.EndEdit();
            this.dgvSocio.Refresh();
        }

        public void busqueda()
        {
            Metodos buscar = new Metodos();
            buscar.Inicializar();

            string valores = "socioNombre, socioDNI, socioDireccion, socioMail, socioTelefono, socioCelular, socioFechaNac, socioFechaIng, socioFechaUltPago, socioGenero";
            string tabla = "Socio";
            string condicion = "socioNombre LIKE '" + txtBusqueda.Text + "%'";

            buscar.Llenardgvcondiciones(tabla, valores, dgvSocio, condicion);

            //DataTable dtDatos = new DataTable();
            //string cadena = ("SELECT socioNombre, socioDNI, socioDireccion, socioMail, socioTelefono, socioCelular, socioFechaNac, socioFechaIng, socioFechaUltPago, socioGenero FROM Socio WHERE socioNombre LIKE '" + txtBusqueda.Text + "%'");
            //OleDbDataAdapter data = new OleDbDataAdapter(cadena, conexion);
            //data.Fill(dtDatos);
            //dgvSocio.DataSource = dtDatos;
        }

        public void cargar()
        {
            Metodos cargametodo = new Metodos();
            string tabla = "Socio";
            string valores = "socioNombre, socioDNI, socioDireccion, socioMail, socioTelefono, socioCelular, socioFechaIng, socioFechaUltPago, socioFechaNac, socioGenero";
            string condicion = "socioEstado LIKE true";

            cargametodo.Inicializar();
            cargametodo.Llenardgvcondiciones(tabla, valores, dgvSocio, condicion);
        }

        public void modificar()
        {
            conexion.Open();
            string query = "Select socioID FROM socio WHERE socioNombre='" + dgvSocio.CurrentRow.Cells[0].Value.ToString() + "'";
            
            comando.Connection = conexion;
            comando.CommandText = query;

            string temporal = comando.ExecuteScalar().ToString();

            ModificarUsuario modificar = new ModificarUsuario();

            modificar.lblID.Text = temporal;
            modificar.txtNombre.Text = dgvSocio.CurrentRow.Cells[0].Value.ToString();
            modificar.txtDireccion.Text = dgvSocio.CurrentRow.Cells[2].Value.ToString();
            modificar.txtDNI.Text = dgvSocio.CurrentRow.Cells[1].Value.ToString();
            modificar.txtCelular.Text = dgvSocio.CurrentRow.Cells[5].Value.ToString();
            modificar.txtMail.Text = dgvSocio.CurrentRow.Cells[3].Value.ToString();
            modificar.txtTelefono.Text = dgvSocio.CurrentRow.Cells[4].Value.ToString();
            
            if(dgvSocio.CurrentRow.Cells[6].Value.Equals(true))
            {
                modificar.rbHombre.Checked = true;
            }else if(dgvSocio.CurrentRow.Cells[6].Value.Equals(false))
            {
                modificar.rbMujer.Checked = true;
            }

            modificar.ShowDialog();

            conexion.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            busqueda();
        }

        private void dgvSocio_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            modificar();
        }

        private void dgvSocio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //ModificarUsuario modificar = new ModificarUsuario();

           // modificar.txtNombre.Text = dgvSocio.CurrentRow.Cells[0].Value.ToString();

            //modificar.ShowDialog();
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (txtBusqueda.Text == "")
            {
                cargar();
            }
            else
            {
                busqueda();
                this.dgvSocio.EndEdit();
            }
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            modificar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Refresh();
            this.dgvSocio.Refresh();
        }

        private void dgvSocio_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.ColumnIndex == 6)
            {
                if(e.Value is bool)
                {
                    bool value = (bool)e.Value;
                    e.Value = (value) ? "Hombre" : "Mujer";
                    e.FormattingApplied = true;
                }
            }
        }

        private void smiActividades_Click(object sender, EventArgs e)
        {
            Actividades nuacts = new Actividades();
            nuacts.ShowDialog();
        }

        private void smiPagos_Click(object sender, EventArgs e)
        {
            PagosMensuales nupagos = new PagosMensuales();
            nupagos.ShowDialog();
        }

        private void smiProfesionales_Click(object sender, EventArgs e)
        {
            Profesionales nuprof = new Profesionales();
            nuprof.ShowDialog();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            cargar();          
        }

        private void smiInactivos_Click(object sender, EventArgs e)
        {
            SociosInactivos neuinactivos = new SociosInactivos();
            neuinactivos.ShowDialog();
        }

        private void smiCategorias_Click(object sender, EventArgs e)
        {
            Categorias nuevocats = new Categorias();
            nuevocats.ShowDialog();
        }
    }
}
