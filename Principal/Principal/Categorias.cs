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

        private void Categorias_Load(object sender, EventArgs e)
        {
            Metodos cargarcat = new Metodos();
            cargarcat.Inicializar();

            string query = "catNombre, catDesc";
            string orden = "catNombre";
            string tabla = "Categoria";

            cargarcat.Llenardgvordenado(tabla, query, dgvCategorias, orden);       
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            NuevaCategoria nuevo = new NuevaCategoria();
            nuevo.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //conPagos.Open();
            //string query = "SELECT catID FROM Categoria WHERE catNombre = '" + dgvCategorias.CurrentRow.Cells[1].Value.ToString() + "'";

            //comando.Connection = conPagos;
            //comando.CommandText = query;

            //string temporal = comando.ExecuteScalar().ToString();

            //ModificarCategoria nuovo = new ModificarCategoria();

            //nuovo.lblID.Text = temporal;
            //nuovo.txtDescripcion.Text = dgvCategorias.CurrentRow.Cells[2].Value.ToString();
            //nuovo.txtNombre.Text = dgvCategorias.CurrentRow.Cells[1].Value.ToString();
            //nuovo.ShowDialog();

            //conPagos.Close();
        }
    }
}
