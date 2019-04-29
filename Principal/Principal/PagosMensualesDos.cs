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
    public partial class PagosMensualesDos : Form
    {
        public PagosMensualesDos()
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

        private void PagosMensualesDos_Load(object sender, EventArgs e)
        {
            Metodos cargapagos = new Metodos();
            cargapagos.Inicializar();

            string query = "Socio.socioID, Socio.socioNombre, Socio.socioCategoria, Mensual.mesJulio, Mensual.mesAgosto, Mensual.mesSeptiembre, Mensual.mesOctubre, Mensual.mesNoviembre, Mensual.mesDiciembre, Mensual.mesTotalPago, Mensual.mesTotal";
            string tabla = "(Socio INNER JOIN Mensual ON Socio.socioID = Mensual.socioID)";

            cargapagos.Llenardgv(tabla, query, dgvPagosDos);
        }

        private void btnSemestre_Click(object sender, EventArgs e)
        {
            this.Close();
            PagosMensuales pagos = new PagosMensuales();
            pagos.Show();
        }
    }
}
