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
    public partial class ModificarUsuario : Form
    {
        OleDbConnection conModificar = new OleDbConnection();

        public ModificarUsuario()
        {
            InitializeComponent();
            conModificar.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Mi PC\Documents\Proyecto Club\Vistalba\Vistalba\Principal\Principal\Club Vistalba.accdb;
Persist Security Info=False;";
        }

        void FillCombo()
        {

        }

        private void socioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.socioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.club_VistalbaDataSet);

        }

        private void ModificarUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'club_VistalbaDataSet.Grupo' Puede moverla o quitarla según sea necesario.
            //this.grupoTableAdapter.Fill(this.club_VistalbaDataSet.Grupo);
            // TODO: esta línea de código carga datos en la tabla 'club_VistalbaDataSet.Socio' Puede moverla o quitarla según sea necesario.
            //this.socioTableAdapter.Fill(this.club_VistalbaDataSet.Socio);

        }

        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            txtNombre.Enabled = true;
            txtDireccion.Enabled = true;
            txtCelular.Enabled = true;
            txtDNI.Enabled = true;
            txtMail.Enabled = true;
            txtTelefono.Enabled = true;
            cbCategoria.Enabled = true;
            txtGrupo.Enabled = true;
            dtpIngreso.Enabled = true;
            dtpNacimiento.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void socioMailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                conModificar.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = conModificar;
                string query = "UPDATE Socio SET socioNombre ='" + txtNombre + "', socioDNI ='" + txtDNI + "', socioDireccion ='" + txtDireccion + "', socioMail ='" + txtMail + "', socioTelefono ='" + txtTelefono + "', socioCelular ='" + txtCelular + "', socioFechaNac ='" + dtpNacimiento + "'";
                command.CommandText = query;

                command.ExecuteNonQuery();

                conModificar.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar" + ex);
            }
        }
    }
}
