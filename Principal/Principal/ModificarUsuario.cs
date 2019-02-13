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
            conModificar.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Club Vistalba.accdb;
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
            //cargargenero();
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


            try
            {
                conModificar.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = conModificar;
                string query = "UPDATE Socio SET socioNombre = '" + txtNombre.Text + "', socioDNI = " + txtDNI.Text + ", socioDireccion = '" + txtDireccion.Text + "', socioMail = '" + txtMail.Text + "', socioTelefono = " + txtTelefono.Text + ", socioCelular = " + txtCelular.Text + ", socioGenero = '" + flag + "' WHERE socioID = " + lblID.Text + "";

                string seters = "socioNombre = '" + txtNombre.Text + "', socioDNI = " + txtDNI.Text + ", socioDireccion = '" + txtDireccion.Text + "', socioMail = '" + txtMail.Text + "', socioTelefono = " + txtTelefono.Text + ", socioCelular = " + txtCelular.Text + ", socioGenero = '" + flag + "' WHERE socioID = " + lblID.Text + "";
                command.CommandText = query;

                command.ExecuteNonQuery();

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
            finally
            {
                conModificar.Close();
                conModificar.Dispose();
                this.Refresh();
            }
        }

        private void cargargenero()
        {
            try
            {
                conModificar.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = conModificar;
                string query = "SELECT socioGenero FROM Socio WHERE socioID='" + lblID.Text + "'";
                command.CommandText = query;

                string temporal = command.ExecuteScalar().ToString();

                MessageBox.Show(temporal);

                /*if ()
                {
                    if (e.Value is bool)
                    {
                        bool value = (bool)e.Value;
                        e.Value = (value) ? "Hombre" : "Mujer";
                        e.FormattingApplied = true;
                    }
                }*/

                conModificar.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectarse" + ex);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void rbHombre_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
