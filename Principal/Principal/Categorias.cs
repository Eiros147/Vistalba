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

            string query = "*";
            string tabla = "Categoria";

            cargarcat.Llenardgv(tabla, query, dgvCategorias);       
        }
    }
}
