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
            Metodos cargapagos = new Metodos();
            cargapagos.Inicializar();

            string query = "Socio.socioID, Socio.socioNombre, Socio.socioCategoria, Mensual.mesEnero, Mensual.mesFebrero, Mensual.mesMarzo, Mensual.mesAbril, Mensual.mesMayo, Mensual.mesJunio, Mensual.mesTotalPago, Mensual.mesTotal";
            string tabla = "(Socio INNER JOIN Mensual ON Socio.socioID = Mensual.socioID)";

            cargapagos.Llenardgv(tabla, query, dgvPagos);
            
            
        }

        private void dgvPagos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            dgvPagos.Columns[0].HeaderText = "probando";
            //dgvPagos.Columns.Add();
        }
    }
}
