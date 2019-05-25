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

        OleDbCommand comando = new OleDbCommand();

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
            //dtpIngreso.Enabled = true;
            //dtpNacimiento.Enabled = true;
            txtNotas.Enabled = true;
            cbCategoria.Enabled = true;
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

            int estado;
            if (cbEstado.Checked)
            {
                estado = 1;
            }
            else
            {
                estado = 0;
            }

            string seters = "socioNombre = '" + txtNombre.Text + "', socioDNI = " + txtDNI.Text + ", socioDireccion = '" + txtDireccion.Text + "', socioMail = '" + txtMail.Text + "', socioNotas = '" + txtNotas.Text + "', socioCategoria = '" + cbCategoria.Text + "', socioTelefono = " + txtTelefono.Text + ", socioCelular = " + txtCelular.Text + ", socioGenero = " + flag + ", socioEstado = " + estado;
            string tabla = "Socio";
            string key = "socioID";
            int id = Convert.ToInt32(lblID.Text);

            Metodos modMetodo = new Metodos();
            modMetodo.Inicializar();

            modMetodo.Update(tabla, id, seters, key);

        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void rbHombre_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSalud_Click(object sender, EventArgs e)
        {
            conModificar.Open();
            string query = "SELECT socioNombre FROM Socio WHERE socioID = " + lblID.Text + "";

            comando.CommandText = query;
            comando.Connection = conModificar;

            string temporal = comando.ExecuteScalar().ToString();

            ModificarSalud salud = new ModificarSalud();
            salud.lblNombre.Text = temporal;
            salud.idsocio = Convert.ToInt32(lblID.Text);

            salud.ShowDialog();
        }

        private void Seleccionar(ComboBox cb)
        {
            string valor = "catNombre";
            string tabla = "Categoria";
            string id = "catID";

            Metodos llenar = new Metodos();
            llenar.Inicializar();
            llenar.LlenarCombo(valor, tabla, cbCategoria, id);
        }

        private void cbEstado_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEstado.Checked == true)
            {
                cbEstado.Text = "Activo";
            }
            else if(cbEstado.Checked == false)
            {
                cbEstado.Text = "Inactivo";
            }
        }

        private void btnGrupo_Click(object sender, EventArgs e)
        {
            ModificarGrupo modif = new ModificarGrupo();
            modif.ShowDialog();
        }
    }
}
