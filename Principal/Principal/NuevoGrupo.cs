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
    public partial class NuevoGrupo : Form
    {

        OleDbConnection conNuevo = new OleDbConnection();

        public NuevoGrupo()
        {
            InitializeComponent();
            conNuevo.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Club Vistalba.accdb;
Persist Security Info=False;";

        }

        private void grupoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.grupoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.club_VistalbaDataSet);

        }

        private void NuevoGrupo_Load(object sender, EventArgs e)
        {
            try
            {
                conNuevo.Open();
                string query = "SELECT TOP 1 grupoID FROM Grupo ORDER BY grupoID DESC ";
                OleDbCommand command = new OleDbCommand(query, conNuevo);


                string temporal = command.ExecuteScalar().ToString();
                int numero = Int32.Parse(temporal);
                numero = numero + 1;
                lblID.Text = numero.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectarse " + ex);
            }
            finally
            {
                conNuevo.Close();
            }

            Seleccionar(cbCategoria);
        }

        private void Seleccionar(ComboBox cb)
        {
            string valor = "catNombre";
            string tabla = "Categoria";
            string id = "catID";
            string orden = "catNombre";

            Metodos cargar = new Metodos();
            cargar.Inicializar();
            //cargar.LlenarCombo(valor, tabla, cb, id, orden);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            using(ListaMiembros lista = new ListaMiembros())
            {
                if(lista.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    txtSocioPpal.Text = lista.textoSeleccionado;
                }
            }
        }

        

        private void Notifyme(string s)
        {

        }

        private void cbCategoria_TextChanged(object sender, EventArgs e)
        {
            if(cbCategoria.Text.Length > 0 && lblID.Text.Length > 0)
            {
                txtNombre.Text = cbCategoria.Text + lblID.Text;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Metodos guardar = new Metodos();
            guardar.Inicializar();

            string tabla = "Grupo";
            string seters = "grupoCategoria, grupoSocioPpal, grupoApellido, grupoNombre";
            string valores = "'" + cbCategoria.Text + "','" + txtSocioPpal.Text + "','" + txtApellido.Text + "','" + txtNombre.Text + "'";

            guardar.Insertar(tabla, seters, valores);
        }
    }
}
