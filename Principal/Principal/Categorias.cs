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
    public partial class Categorias : Form
    {

        public Categorias()
        {
            InitializeComponent();
        }

        OleDbConnection conPagos = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Club Vistalba.accdb;
Persist Security Info=False;");
        OleDbCommand comando = new OleDbCommand();
        DateTime dt = DateTime.Today;

        private void Categorias_Load(object sender, EventArgs e)
        {
            cargar();

            formatear();

            this.AutoSize = true;
        }

        private void cargar()
        {
            Metodos cargarcat = new Metodos();
            cargarcat.Inicializar();

            string mes = dt.Month.ToString();

            if (mes == "1" || mes == "2" || mes == "3" || mes == "4" || mes == "5" || mes == "6")
            {
                string query = "catNombre, catDesc, catMesAct, catMesInact, catSeguro1, catDer1, catCant";
                string orden = "catNombre";
                string tabla = "Categoria";

                cargarcat.Llenardgvordenado(tabla, query, dgvCategorias, orden);

            }
            else
            {
                string query = "catNombre, catDesc, catMesAct2, catMesInact2, catSeguro2, catDer2, catCant";
                string orden = "catNombre";
                string tabla = "Categoria";

                cargarcat.Llenardgvordenado(tabla, query, dgvCategorias, orden);
            }
        }

        private void formatear()
        {
            this.dgvCategorias.Columns[0].HeaderText = "Nombre";
            this.dgvCategorias.Columns[1].HeaderText = "Descripción";
            this.dgvCategorias.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dgvCategorias.Columns[2].HeaderText = "Costo Meses Activos";
            this.dgvCategorias.Columns[3].HeaderText = "Costo Meses Inactivos";
            this.dgvCategorias.Columns[4].HeaderText = "Seguro";
            this.dgvCategorias.Columns[5].HeaderText = "Derecho";
            this.dgvCategorias.Columns[6].HeaderText = "Cantidad Personas";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            NuevaCategoria nuevo = new NuevaCategoria();
            nuevo.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            modificar();
        }

        public void modificar()
        {
            conPagos.Open();
            string query = "SELECT catID FROM Categoria WHERE catNombre = '" + dgvCategorias.CurrentRow.Cells[0].Value.ToString() + "'";

            comando.Connection = conPagos;
            comando.CommandText = query;

            string temporal = comando.ExecuteScalar().ToString();

            ModificarCategoria nuovo = new ModificarCategoria();

            nuovo.lblID.Text = temporal;
            nuovo.txtDescripcion.Text = dgvCategorias.CurrentRow.Cells[1].Value.ToString();
            nuovo.txtNombre.Text = dgvCategorias.CurrentRow.Cells[0].Value.ToString();
            nuovo.txtMesAct.Text = dgvCategorias.CurrentRow.Cells[2].Value.ToString();
            nuovo.txtMesInact.Text = dgvCategorias.CurrentRow.Cells[3].Value.ToString();
            nuovo.cbCant.Text = dgvCategorias.CurrentRow.Cells[4].Value.ToString();

            Seleccionar(nuovo.cbCant, "catCant", "Categoria", "catID", "catCant");
            Seleccion("catCant", "Categoria", nuovo.cbCant, "catID", nuovo.lblID);

            nuovo.ShowDialog();

            conPagos.Close();
        }

        private void dgvCategorias_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

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
                OleDbCommand comando = new OleDbCommand(busqueda, conPagos);
                string temporal = Convert.ToString(comando.ExecuteScalar());
                cb.SelectedIndex = cb.FindStringExact(temporal);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
            finally
            {
                conPagos.Close();
            }
        }


    }
}
