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

        public NuevoUsuario()
        {
            InitializeComponent();
            conNuevo.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Mi PC\Documents\Proyecto Club\Vistalba\Vistalba\Principal\Principal\Club Vistalba.accdb;
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
            // TODO: esta línea de código carga datos en la tabla 'club_VistalbaDataSet.Socio' Puede moverla o quitarla según sea necesario.
            //this.socioTableAdapter.Fill(this.club_VistalbaDataSet.Socio);
            try
            {
                conNuevo.Open();
                string query = "SELECT socioID FROM Socio";
                OleDbCommand command = new OleDbCommand(query,conNuevo);

                OleDbDataReader dr = command.ExecuteReader();
                bool exito = dr.Read();
                if (exito)
                {
                    lblSocioID.Text = dr.GetString(0);
                }
                               
                
                conNuevo.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectarse" + ex);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbSi_CheckedChanged(object sender, EventArgs e)
        {
            cbGrupo.Visible = true;
        }

        private void rbNo_CheckedChanged(object sender, EventArgs e)
        {
            cbGrupo.Visible = false;
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {

        }
    }
}
