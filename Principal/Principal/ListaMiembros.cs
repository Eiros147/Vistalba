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
    public partial class ListaMiembros : Form
    {
        OleDbConnection listado = new OleDbConnection();


        public ListaMiembros()
        {
            InitializeComponent();
            listado.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Club Vistalba.accdb;
Persist Security Info=False;";

        }

        private void ListaMiembros_Load(object sender, EventArgs e)
        {
            try
            {
                listado.Open();
                OleDbCommand comando = new OleDbCommand();
                comando.Connection = listado;
                string query = "SELECT socioNombre, socioDNI, socioMail, socioTelefono FROM Socio";
                comando.CommandText = query;

                OleDbDataAdapter da = new OleDbDataAdapter(comando);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvSocios.DataSource = dt;

                listado.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectarse a la base de datos \n" + ex);
            }
        }

        private void dgvSocios_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //string elegido;
            //elegido = dgvSocios.CurrentRow.Cells[0].Value.ToString();

            
            //this.Close();
            
        }
    }
}
