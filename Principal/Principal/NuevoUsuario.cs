    using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace Principal
{
    public partial class NuevoUsuario : Form
    {

        OleDbConnection conNuevo = new OleDbConnection();

        public NuevoUsuario( )
        {
            InitializeComponent();
            conNuevo.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Club Vistalba.accdb;
Persist Security Info=False;";
        }

        private void socioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.socioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.club_VistalbaDataSet);

        }

        private void NuevoUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'club_VistalbaDataSet.Categoria' Puede moverla o quitarla según sea necesario.
            this.categoriaTableAdapter.Fill(this.club_VistalbaDataSet.Categoria);
            // TODO: esta línea de código carga datos en la tabla 'club_VistalbaDataSet.Socio' Puede moverla o quitarla según sea necesario.
            //this.socioTableAdapter.Fill(this.club_VistalbaDataSet.Socio);


            try
            {
                conNuevo.Open();
                string query = "SELECT TOP 1 socioID FROM Socio ORDER BY socioID DESC ";
                OleDbCommand command = new OleDbCommand(query, conNuevo);


                string temporal = command.ExecuteScalar().ToString();
                int numero = Int32.Parse(temporal);
                numero = numero + 1;
                lblSocioID.Text = numero.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectarse " + ex);
            }
            finally
            {
                conNuevo.Close();
            }

            Seleccionar(cbCategoria, "catNombre", "Categoria", "catID", "catNombre");
            Seleccionar(cbNivel, "nivelNombre", "Niveles", "nivelID", "nivelID");
        }

        private void Seleccionar(ComboBox cb, string valor, string tabla, string identificador, string orden)
        {
            Metodos llenado = new Metodos();
            llenado.Inicializar();
            llenado.LlenarCombo(valor, tabla, cb, identificador, orden);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void rbSi_CheckedChanged(object sender, EventArgs e)
        {
            //cbGrupo.Visible = true;
        }

        private void rbNo_CheckedChanged(object sender, EventArgs e)
        {
            //cbGrupo.Visible = false;
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardar();

            this.Close();

            NuevoSalud nuevo = new NuevoSalud();
            nuevo.Show();
            nuevo.lblNombre.Text = txtNombre.Text;
            nuevo.TopMost = true;
            
        }

        private void guardar()
        {
            int flag;
            if (rbHombre.Checked)
            {
                flag = 1;
            }
            else
            {
                flag = 0;
            }

            Metodos nuevometodo = new Metodos();
            nuevometodo.Inicializar();

            string tabla = "Socio";
            string seters = "socioNombre, socioDNI, socioDireccion, socioMail, socioTelefono, socioCelular, socioGenero, socioNotas, socioFechaIng";
            string valores = "'" + txtNombre.Text + "','" + txtDNI.Text + "','" + txtDireccion.Text + "','" + txtMail.Text + "','" + txtTelefono.Text + "','" + txtCelular.Text + "','" + flag + "','" + txtNotas.Text + "','" + DateTime.Now + "'";

            nuevometodo.Insertar(tabla,seters,valores);
        }

        private void Seleccionar(ComboBox cb)
        {
            string valor = "grupoApellido";
            string tabla = "Grupo";
            string id = "grupoID";
            string ordenador = "grupoApellido";

            Metodos elegirgrupo = new Metodos();
            elegirgrupo.Inicializar();
            //elegirgrupo.LlenarCombo(valor, tabla, cb, id, ordenador);
        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {
            this.Close();
            NuevoSalud nuevo = new NuevoSalud();
            nuevo.Show();
            nuevo.TopMost = true;
        }

        private void cbEstado_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEstado.Checked == true)
            {
                cbEstado.Text = "Activo";
            }
            else if (cbEstado.Checked == false)
            {
                cbEstado.Text = "Inactivo";
            }
        }

        private void btnSalud_Click(object sender, EventArgs e)
        {
            NuevoSalud salud = new NuevoSalud();
            salud.lblID.Text = lblSocioID.Text;
            salud.Show();
        }
    }
}
