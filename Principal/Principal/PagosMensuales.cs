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
    public partial class PagosMensuales : Form
    {
        public PagosMensuales()
        {
            InitializeComponent();
        }

        OleDbConnection conPagos = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Club Vistalba.accdb;
Persist Security Info=False;");
        OleDbCommand comando = new OleDbCommand();

        private void mensualBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mensualBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.club_VistalbaDataSet);

        }

        private void PagosMensuales_Load(object sender, EventArgs e)
        {
            try
            {
                conPagos.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = conPagos;
                string query = "SELECT * FROM Mensual";
                command.CommandText = query;

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvPagos.DataSource = dt;

                conPagos.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectarse" + ex);
            }

            // TODO: esta línea de código carga datos en la tabla 'club_VistalbaDataSet.Mensual' Puede moverla o quitarla según sea necesario.
            //this.mensualTableAdapter.Fill(this.club_VistalbaDataSet.Mensual);

        }
    }
}
