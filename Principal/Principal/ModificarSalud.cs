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
        bool control = false;

        public ModificarSalud()
        {
            InitializeComponent();
            conModificar.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Club Vistalba.accdb;
Persist Security Info=False;";
        }
        OleDbCommand comando = new OleDbCommand();

        public int idsocio;

        private void saludBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.saludBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.club_VistalbaDataSet);

        }

        private void ModificarSalud_Load(object sender, EventArgs e)
        {
            lblid.Text = idsocio.ToString();
            try
            {
                conModificar.Open();
                OleDbCommand comando = new OleDbCommand();
                comando.Connection = conModificar;
                string query = "SELECT Socio.socioNombre, Salud.saludAlergia, Salud.saludAlergiaDesc, Salud.saludTelEm, Salud.saludExtra, Salud.saludObraSoc, Salud.saludSangre FROM (Socio INNER JOIN Salud ON Socio.socioID = Salud.socioID) WHERE Socio.socioID = " + idsocio + "";
                comando.CommandText = query;

                //Control
                //MessageBox.Show(query);

                OleDbDataReader lector = comando.ExecuteReader();

                if (lector.Read())
                {
                    txtDescripcion.Text = (lector["saludAlergiaDesc"].ToString());
                    txtEmergencia.Text = (lector["saludTelEm"].ToString());
                    txtExtra.Text = (lector["saludExtra"].ToString());
                    txtMedicamentos.Text = (lector["saludExtra"].ToString());
                    txtObrasocial.Text = (lector["saludObraSoc"].ToString());
                    txtSangre.Text = (lector["saludSangre"].ToString());

                    if (lector["saludAlergia"].Equals(true))
                    {
                        cbAlergia.Checked = true;
                    }else if (lector["saludAlergia"].Equals(false))
                    {
                        cbAlergia.Checked = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
            finally
            {
                conModificar.Close();
            }
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

            OleDbCommand cmdchequeo = new OleDbCommand();
            cmdchequeo.CommandText = "SELECT * FROM Salud";
            cmdchequeo.Connection = conModificar;

            OleDbDataReader lector = cmdchequeo.ExecuteReader();
            while (lector.Read())
            {
                if (lector[1].ToString() == idsocio.ToString())
                {
                    control = true;
                    break;
                }
            }

            if(control== true)
            {
                string seters = "saludAlergia = '" + flag + "', saludAlergiaDesc = '" + txtDescripcion.Text + "', saludSangre = '" + txtSangre.Text + "', saludMed = '" + txtMedicamentos.Text + "', saludObraSoc = '" + txtObrasocial.Text + "', saludTelEm = " + txtEmergencia.Text + ", saludExtra = '" + txtExtra.Text + "'";
                string tabla = "Salud";
                string key = "socioID";

                Metodos guardar = new Metodos();
                guardar.Inicializar();
                guardar.Update(tabla, idsocio, seters, key);
            }
            else
            {
                string tabla = "Salud";
                string seters = "saludAlergia, saludAlergiaDesc, saludSangre, saludMed, saludObraSoc, saludTelEm, saludExtra, socioID";
                string valores = "'" + flag + "','" + txtDescripcion.Text + "','" + txtSangre.Text + "','" + txtMedicamentos.Text + "','" + txtObrasocial.Text + "','" + txtEmergencia.Text + "','" + txtExtra.Text + "'," + idsocio.ToString() + "";

                Metodos crear = new Metodos();
                crear.Inicializar();
                crear.Insertar(tabla, seters, valores);
            }

            conModificar.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string algo = idsocio.ToString();
            MessageBox.Show(algo);
        }

        private void cbAlergia_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAlergia.Checked == true)
            {
                cbAlergia.Text = "Si";
            }else if(cbAlergia.Checked == false)
            {
                cbAlergia.Text = "No";
            }
        }
    }
}
