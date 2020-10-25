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
    public partial class PagosMensuales : Form
    {
        DateTime dt = DateTime.Now;
        

        public PagosMensuales()
        {
            InitializeComponent();
        }

        OleDbConnection conPagos = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Club Vistalba.accdb;
Persist Security Info=False;");
        OleDbCommand comando = new OleDbCommand();

        private void mensualBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mensualBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.club_VistalbaDataSet);

        }

        private void PagosMensuales_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'club_VistalbaDataSet.Categoria' Puede moverla o quitarla según sea necesario.
            this.categoriaTableAdapter.Fill(this.club_VistalbaDataSet.Categoria);
            Metodos cargapagos = new Metodos();
            cargapagos.Inicializar();

            DateTime dt = DateTime.Now;
            String mes = dt.Month.ToString();
            String nombremes = dt.ToString("MMMM");

            //MessageBox.Show(mes);
            //MessageBox.Show(nombremes);

            if (mes == "11" || mes == "12")
            {
                //MessageBox.Show(mes);  
            string query = "Socio.socioNombre, Socio.socioCategoria, Categoria.catMesInact";
            string tabla = "(Categoria INNER JOIN Socio ON Categoria.catID = Socio.catId)";

            cargapagos.Llenardgv(tabla, query, dgvPagos);

            }
            else
            {
                //MessageBox.Show("no anduvo");
                string query = "Socio.socioNombre, Socio.socioCategoria, Categoria.catMesAct";
                //string query = "socioNombre, socioCategoria, catMesAct";
                string tabla = "(Categoria INNER JOIN Socio ON Categoria.catID = Socio.catId)";

                cargapagos.Llenardgv(tabla, query, dgvPagos);
            }
        }


        private void dgvPagos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            String mes = dt.Month.ToString();

            dgvPagos.Columns[0].HeaderText = "Nombre";
            dgvPagos.Columns[1].HeaderText = "Categoria";
            dgvPagos.Columns[2].HeaderText = mes;
            dgvPagos.Columns[3].HeaderText = "Deuda" + mes;
            dgvPagos.Columns[4].HeaderText = "Deuda anual";
        }

        private void btnSemestre_Click(object sender, EventArgs e)
        {
            this.Close();
            PagosMensualesDos otrosemestre = new PagosMensualesDos();
            otrosemestre.Show();
        }

        private void btnPagoCat_Click(object sender, EventArgs e)
        {
            PagosPorCategoria catpago = new PagosPorCategoria();
            catpago.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
