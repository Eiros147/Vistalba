using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal
{
    public partial class NuevoProfesional : Form
    {
        OleDbConnection conNuevo = new OleDbConnection();

        public NuevoProfesional()
        {
            InitializeComponent();
            conNuevo.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Club Vistalba.accdb;
Persist Security Info=False;";
        }

        private void profesionalBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.profesionalBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.club_VistalbaDataSet);

        }


        private void NuevoProfesional_Load(object sender, EventArgs e)
        {
            try
            {
                conNuevo.Open();
                string query = "SELECT TOP 1 profId FROM Profesional ORDER BY profId DESC ";
                OleDbCommand comando = new OleDbCommand(query, conNuevo);

                string temporal = comando.ExecuteScalar().ToString();
                int numero = Int32.Parse(temporal);
                numero = numero + 1;
                lblID.Text = numero.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectarse /b " + ex);
            }
            finally
            {
                conNuevo.Close();
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardar();
            this.Refresh();
        }

        private void guardar()
        {
            string tabla = "Profesional";
            string valores = "'" + txtNombre.Text + "','" + txtDomicilio.Text + "'," + txtTelefono.Text + ",'" + txtMail.Text + "'";
            string seters = "profNombre, profDomicilio, profTelefono, profMail";

            Metodos nuevoprof = new Metodos();
            nuevoprof.Inicializar();
            nuevoprof.Insertar(tabla, seters,valores);  
        }
    }
}
