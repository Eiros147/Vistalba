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
    public partial class NuevaActividad : Form
    {
        OleDbConnection conNueva = new OleDbConnection();

        public NuevaActividad()
        {
            InitializeComponent();
            conNueva.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Club Vistalba.accdb;
Persist Security Info=False;";
        }

        private void actividadesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.actividadesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.club_VistalbaDataSet);

        }

        private void NuevaActividad_Load(object sender, EventArgs e)
        {
            try
            {
                conNueva.Open();
                string query = "SELECT TOP 1 actId FROM Actividades ORDER BY actId DESC ";
                OleDbCommand command = new OleDbCommand(query, conNueva);


                string temporal = command.ExecuteScalar().ToString();
                int numero = Int32.Parse(temporal);
                numero = numero + 1;
                lblID.Text = numero.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectarse" + ex);
            }
            finally
            {
                conNueva.Close();
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
            string valores = "actDesc, actMeses, actNombre";
            string tabla = "Actividades";
            string seters = "'" + txtDescripcion.Text + "','" + txtMeses.Text + "','" + txtNombreActividad.Text + "'";

            Metodos nuevaact = new Metodos();
            nuevaact.Inicializar();
            nuevaact.Insertar(tabla, seters, valores);
        }
    }
}
