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

        private void Seleccionar(ComboBox cb, string value, string table, string identificador, string orden)
        {
            Metodos llenado = new Metodos();
            llenado.Inicializar();
            llenado.LlenarCombo(value, table, cb, identificador, orden);
        }

        private void Seleccion(string valor, string tabla, ComboBox cb, string id, Label lbl)
        {
            try
            {
                
                string busqueda = "SELECT " + valor + " FROM " + tabla + " WHERE (" + id + " LIKE '" + lbl.Text + "')";
                OleDbCommand comando = new OleDbCommand(busqueda, conexion);
                string temporal = Convert.ToString(comando.ExecuteScalar());
                cb.SelectedIndex = cb.FindStringExact(temporal);
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
            ModificarActividad neu = new ModificarActividad();
            try
            {
                conexion.Open();
                string query = "SELECT actID FROM Actividades WHERE actNombre = '" + dgvActividades.CurrentRow.Cells[0].Value.ToString() + "'";

                comando.Connection = conexion;
                comando.CommandText = query;
                 
                string temporal = comando.ExecuteScalar().ToString();

                string busquedaprof = "SELECT profID FROM Profesional WHERE (profNombre = '" + dgvActividades.CurrentRow.Cells[3].Value.ToString() + "')";
                OleDbCommand comprof = new OleDbCommand(busquedaprof, conexion);
                string temporalprof = Convert.ToString(comprof.ExecuteScalar());

                //MessageBox.Show(temporalprof);

                neu.txtNombre.Text = dgvActividades.CurrentRow.Cells[0].Value.ToString();
                neu.txtDesc.Text = dgvActividades.CurrentRow.Cells[1].Value.ToString();
                neu.txtMeses.Text = dgvActividades.CurrentRow.Cells[2].Value.ToString();
                neu.lblProfID.Text = temporalprof;

                neu.lblID.Text = temporal;

                Seleccionar(neu.cbProfesor, "profNombre", "Profesional", "profId", "profNombre");
                Seleccion("profNombre", "Profesional", neu.cbProfesor, "profID", neu.lblProfID);

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
