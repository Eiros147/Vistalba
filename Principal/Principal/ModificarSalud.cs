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
    public partial class ModificarSalud : Form
    {
        OleDbConnection conModificar = new OleDbConnection();

        public ModificarSalud()
        {
            InitializeComponent();
            conModificar.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Club Vistalba.accdb;
Persist Security Info=False;";
        }
        OleDbCommand comando = new OleDbCommand();

        private void saludBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.saludBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.club_VistalbaDataSet);

        }

        private void ModificarSalud_Load(object sender, EventArgs e)
        {
            
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int flag;
            if (cbAlergia.Checked)
            {
                flag = 1;
            }
            else
            {
                flag = 0;
            }

            conModificar.Open();
            string query = "SELECT socioID FROM Socio WHERE socioNombre = '" + lblNombre.Text + "'";
            comando.CommandText = query;
            comando.Connection = conModificar;

            int nombre = Convert.ToInt32(comando.ExecuteScalar().ToString());

            string seters = "saludAlergia = '" + flag + "', saludAlergiaDesc = '" + txtDescripcion.Text + "', saludSangre = '" + txtSangre.Text + "', saludMed = '" + txtMedicamentos.Text + "', saludObraSoc = '" + txtObrasocial.Text + "', saludTelEm = " + txtEmergencia.Text + ", saludExtra = '" + txtExtra.Text + "'";
            string tabla = "Salud";
            string key = "saludID";
            int id = nombre;

            Metodos guardar = new Metodos();
            guardar.Inicializar();
            guardar.Update(tabla, id, seters, key);

            conModificar.Close();
        }
    }
}
