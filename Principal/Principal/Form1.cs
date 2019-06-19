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

            string valores = "socioNombre, socioDNI, socioDireccion, socioMail, socioTelefono, socioCelular, socioFechaNac, socioFechaIng, socioFechaUltPago, socioGenero, socioCategoria, socioNivel";
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
            string valores = "socioNombre, socioDNI, socioDireccion, socioMail, socioTelefono, socioCelular, socioFechaIng, socioFechaUltPago, socioFechaNac, socioGenero, socioCategoria, socioNivel";
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

            //Seleccionar(modificar.cbCategoria, "catNombre", "Categoria", "catID", "catNombre");
            //Seleccionar(modificar.cbNivel, "nivelNombre", "Niveles", "nivelID", "nivelNumero");

            modificar.lblID.Text = temporal;
            modificar.txtNombre.Text = dgvSocio.CurrentRow.Cells[0].Value.ToString();
            modificar.txtDireccion.Text = dgvSocio.CurrentRow.Cells[2].Value.ToString();
            modificar.txtDNI.Text = dgvSocio.CurrentRow.Cells[1].Value.ToString();
            modificar.txtCelular.Text = dgvSocio.CurrentRow.Cells[5].Value.ToString();
            modificar.txtMail.Text = dgvSocio.CurrentRow.Cells[3].Value.ToString();
            modificar.txtTelefono.Text = dgvSocio.CurrentRow.Cells[4].Value.ToString();
            modificar.cbCategoria.Text = dgvSocio.CurrentRow.Cells[10].Value.ToString();
            modificar.cbNivel.Text = dgvSocio.CurrentRow.Cells[11].Value.ToString();

            //MessageBox.Show(dgvSocio.CurrentRow.Cells[10].Value.ToString());

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

        private void Seleccionar(ComboBox cb, string value, string table, string identificador, string orden)
        {
            Metodos llenado = new Metodos();
            llenado.Inicializar();
            llenado.LlenarCombo(value, table, cb, identificador, orden);
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
            //cargar();          
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

        private void smiGrupos_Click(object sender, EventArgs e)
        {
            Grupos nuevogrupo = new Grupos();
            nuevogrupo.ShowDialog();
        }


        //Divisiones
        private void miPrimeraH_Click(object sender, EventArgs e)
        {
            string division = "Primera";
            int genero = 1;
            Divisiones primerah = new Divisiones(division, genero);
            primerah.ShowDialog();
        }

        private void segundaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string division = "Segunda";
            int genero = 1;
            Divisiones segundah = new Divisiones(division, genero);
            segundah.ShowDialog();
        }

        private void quintaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string division = "Quinta";
            int genero = 1;
            Divisiones quintah = new Divisiones(division, genero);
            quintah.ShowDialog();
        }

        private void sextaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string division = "Sexta";
            int genero = 1;
            Divisiones sextah = new Divisiones(division, genero);
            sextah.ShowDialog();
        }

        private void septimaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string division = "Septima";
            int genero = 1;
            Divisiones septimah = new Divisiones(division, genero);
            septimah.ShowDialog();
        }

        private void miOctavaH_Click(object sender, EventArgs e)
        {
            string division = "Octava";
            int genero = 1;
            Divisiones octavah = new Divisiones(division, genero);
            octavah.ShowDialog();
        }

        private void miNovenaH_Click(object sender, EventArgs e)
        {
            string division = "Novena";
            int genero = 1;
            Divisiones novenah = new Divisiones(division, genero);
            novenah.ShowDialog();
        }

        private void miDecimaH_Click(object sender, EventArgs e)
        {
            string division = "Decima";
            int genero = 1;
            Divisiones decimah = new Divisiones(division, genero);
            decimah.ShowDialog();
        }

        private void miPreDecimaH_Click(object sender, EventArgs e)
        {
            string division = "PreDecima";
            int genero = 1;
            Divisiones preh = new Divisiones(division, genero);
            preh.ShowDialog();
        }

        private void miPrimeraF_Click(object sender, EventArgs e)
        {
            string division = "Primera";
            int genero = 0;
            Divisiones primf = new Divisiones(division, genero);
            primf.ShowDialog();
        }

        private void miSegundaF_Click(object sender, EventArgs e)
        {
            string division = "Segunda";
            int genero = 0;
            Divisiones segf = new Divisiones(division, genero);
            segf.ShowDialog();
        }

        private void miQuintaF_Click(object sender, EventArgs e)
        {
            string division = "Quinta";
            int genero = 0;
            Divisiones quintaf = new Divisiones(division, genero);
            quintaf.ShowDialog();
        }

        private void miSextaF_Click(object sender, EventArgs e)
        {
            string division = "Sexta";
            int genero = 0;
            Divisiones sextaf = new Divisiones(division, genero);
            sextaf.ShowDialog();
        }

        private void miSeptimaF_Click(object sender, EventArgs e)
        {
            string division = "Septima";
            int genero = 0;
            Divisiones septimaf = new Divisiones(division, genero);
            septimaf.ShowDialog();
        }

        private void miOctavaF_Click(object sender, EventArgs e)
        {
            string division = "Octava";
            int genero = 0;
            Divisiones octavaf = new Divisiones(division, genero);
            octavaf.ShowDialog();
        }

        private void miNovenaF_Click(object sender, EventArgs e)
        {
            string division = "Novena";
            int genero = 0;
            Divisiones novenaf = new Divisiones(division, genero);
            novenaf.ShowDialog();
        }

        private void miDecimaF_Click(object sender, EventArgs e)
        {
            string division = "Decima";
            int genero = 0;
            Divisiones decimaf = new Divisiones(division, genero);
            decimaf.ShowDialog();
        }

        private void miPreDecimaF_Click(object sender, EventArgs e)
        {
            string division = "PreDecima";
            int genero = 0;
            Divisiones predecimaf = new Divisiones(division, genero);
            predecimaf.ShowDialog();
        }
    }
}
