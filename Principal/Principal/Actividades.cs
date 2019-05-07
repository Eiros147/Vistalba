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
    public partial class Actividades : Form
    {
        OleDbConnection conActv = new OleDbConnection();
        

        public Actividades()
        {
            InitializeComponent();
            conActv.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Mi PC\Documents\Proyecto Club\Vistalba\Vistalba\Principal\Principal\Club Vistalba.accdb;
Persist Security Info=False;";

        }

        private void actividadesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.actividadesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.club_VistalbaDataSet);

        }

        private void Actividades_Load(object sender, EventArgs e)
        {
            try
            {
                conActv.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = conActv;
                string query = "SELECT Actividades.actNombre, Actividades.actDesc, Actividades.actMeses, Profesional.profNombre FROM(Actividades INNER JOIN Profesional ON Actividades.profId = Profesional.profId)";
                command.CommandText = query;

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvActividades.DataSource = dt;

                conActv.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectarse" + ex);
            }
        }

        void busqueda()
        {
            DataTable dtDatos = new DataTable();
            string cadena = ("SELECT Actividades.actNombre, Actividades.actDesc, Actividades.actMeses, Profesional.profNombre FROM(Actividades INNER JOIN Profesional ON Actividades.profId = Profesional.profId) WHERE actNombre LIKE '" + txtBusqueda.Text + "%'");
            OleDbDataAdapter data = new OleDbDataAdapter(cadena, conActv);
            data.Fill(dtDatos);
            dgvActividades.DataSource = dtDatos;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            busqueda();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            NuevaActividad nuovo = new NuevaActividad();
            nuovo.ShowDialog();
        }

        private void dgvActividades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ModificarActividad neu = new ModificarActividad();
            neu.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarActividad neu = new ModificarActividad();
            neu.ShowDialog();
        }

        private void Actividades_Activated(object sender, EventArgs e)
        {
            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
