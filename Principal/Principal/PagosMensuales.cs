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

            string query = "Socio.socioID, Socio.socioNombre, Socio.socioCategoria, Mensual.mesEnero, Mensual.mesFebrero, Mensual.mesMarzo, Mensual.mesAbril, Mensual.mesMayo, Mensual.mesJunio, Mensual.mesTotalPago, Mensual.mesTotal";
            string tabla = "(Mensual INNER JOIN Socio ON Mensual.mesID = Socio.mesID)";

            cargapagos.Llenardgv(tabla, query, dgvPagos);
            
            
        }

        private void dgvPagos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            dgvPagos.Columns[0].HeaderText = "ID";
            dgvPagos.Columns[1].HeaderText = "Nombre";
            dgvPagos.Columns[2].HeaderText = "Categoria";
            dgvPagos.Columns[3].HeaderText = "Enero";
            dgvPagos.Columns[4].HeaderText = "Febrero";
            dgvPagos.Columns[5].HeaderText = "Marzo";
            dgvPagos.Columns[6].HeaderText = "Abril";
            dgvPagos.Columns[7].HeaderText = "Mayo";
            dgvPagos.Columns[8].HeaderText = "Junio";
            dgvPagos.Columns[9].HeaderText = "Pagado";
            dgvPagos.Columns[10].HeaderText = "Total";

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
