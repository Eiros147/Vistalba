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
    public partial class Profesionales : Form
    {
        public Profesionales()
        {
            InitializeComponent();
        }

        OleDbConnection conexion = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Club Vistalba.accdb;
Persist Security Info=False;");
        OleDbCommand comando = new OleDbCommand();

        private void profesionalBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.profesionalBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.club_VistalbaDataSet);

        }

        private void Profesionales_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'club_VistalbaDataSet.Profesional' Puede moverla o quitarla según sea necesario.
            this.profesionalTableAdapter.Fill(this.club_VistalbaDataSet.Profesional);

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            NuevoProfesional nuprof = new NuevoProfesional();
            nuprof.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            modificar();
        }

        void modificar()
        {
            conexion.Open();
            string query = "SELECT profId FROM Profesional WHERE profNombre ='" + dgvProfesional.CurrentRow.Cells[1].Value.ToString() + "'";

            comando.Connection = conexion;
            comando.CommandText = query;

            string temporal = comando.ExecuteScalar().ToString();

            ModificarProfesional nuevoprof = new ModificarProfesional();

            nuevoprof.lblID.Text = temporal;
            nuevoprof.txtNombre.Text = dgvProfesional.CurrentRow.Cells[1].Value.ToString();
            nuevoprof.txtDomicilio.Text = dgvProfesional.CurrentRow.Cells[2].Value.ToString();
            nuevoprof.txtTelefono.Text = dgvProfesional.CurrentRow.Cells[3].Value.ToString();
            nuevoprof.txtMail.Text = dgvProfesional.CurrentRow.Cells[4].Value.ToString();

            nuevoprof.ShowDialog();
            conexion.Close();
        }

        private void dgvProfesional_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            modificar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
