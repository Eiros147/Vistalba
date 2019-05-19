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
    public partial class Grupos : Form
    {
        OleDbConnection conActv = new OleDbConnection();

        public Grupos()
        {
            InitializeComponent();
            conActv.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Mi PC\Documents\Proyecto Club\Vistalba\Vistalba\Principal\Principal\Club Vistalba.accdb;
Persist Security Info=False;";

        }

        private void grupoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.grupoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.club_VistalbaDataSet);

        }

        private void Grupos_Load(object sender, EventArgs e)
        {
            try
            {
                conActv.Open();
                OleDbCommand comando = new OleDbCommand();
                comando.Connection = conActv;
                string query = "SELECT grupoCategoria, grupoSocioPpal, grupoApellido, grupoSocio1, grupoSocio2, grupoSocio3 FROM Grupo";
                comando.CommandText = query;

                OleDbDataAdapter da = new OleDbDataAdapter(comando);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvGrupos.DataSource = dt;

                conActv.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectarse a la base de datos \n" + ex);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            NuevoGrupo nuevo = new NuevoGrupo();
            nuevo.ShowDialog();
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            NuevoGrupo nuevo = new NuevoGrupo();
            nuevo.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            modificar();
        }

        private void modificar()
        {
            ModificarGrupo mod = new ModificarGrupo();
            mod.ShowDialog();
        }
    }
}
