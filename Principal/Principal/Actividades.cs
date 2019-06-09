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
        
        

        public Actividades()
        {
            InitializeComponent();
            
        }
            OleDbConnection conexion = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Club Vistalba.accdb;
Persist Security Info=False;");
            OleDbCommand comando = new OleDbCommand();

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
                conexion.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = conexion;
                string query = "SELECT Actividades.actNombre, Actividades.actDesc, Actividades.actMeses, Profesional.profNombre FROM(Actividades INNER JOIN Profesional ON Actividades.profId = Profesional.profId)";
                command.CommandText = query;

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvActividades.DataSource = dt;

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectarse" + ex);
            }
            finally
            {
                conexion.Close();
            }

            formatear();
        }

        private void formatear()
        {
            this.dgvActividades.Columns[0].HeaderText = "Nombre";
            this.dgvActividades.Columns[1].HeaderText = "Descripción";
            this.dgvActividades.Columns[2].HeaderText = "Meses";
            this.dgvActividades.Columns[3].HeaderText = "Profesional";
        }

        private void busqueda()
        {
            DataTable dtDatos = new DataTable();
            string cadena = ("SELECT Actividades.actNombre, Actividades.actDesc, Actividades.actMeses, Profesional.profNombre FROM(Actividades INNER JOIN Profesional ON Actividades.profId = Profesional.profId) WHERE actNombre LIKE '" + txtBusqueda.Text + "%'");
            OleDbDataAdapter data = new OleDbDataAdapter(cadena, conexion);
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
            Modificar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Modificar();
                        
        }

        private void Modificar()
        {
            try
            {
                conexion.Open();
                string query = "SELECT actID FROM Actividades WHERE actNombre = '" + dgvActividades.CurrentRow.Cells[0].Value.ToString() + "'";

                comando.Connection = conexion;
                comando.CommandText = query;

                string temporal = comando.ExecuteScalar().ToString();

                ModificarActividad neu = new ModificarActividad();
                neu.lblID.Text = temporal;
                neu.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
            finally
            {
                conexion.Close();
            }
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
