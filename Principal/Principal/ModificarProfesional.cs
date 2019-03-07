using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal
{
    public partial class ModificarProfesional : Form
    {
        public ModificarProfesional()
        {
            InitializeComponent();
        }

        private void profesionalBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.profesionalBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.club_VistalbaDataSet);

        }

        private void ModificarProfesional_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'club_VistalbaDataSet.Profesional' Puede moverla o quitarla según sea necesario.
            this.profesionalTableAdapter.Fill(this.club_VistalbaDataSet.Profesional);

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            txtNombre.Enabled = true;
            txtDomicilio.Enabled = true;
            txtMail.Enabled = true;
            txtTelefono.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string valores = "profNombre = '" + txtNombre.Text + "', profTelefono = '" + txtTelefono.Text + "', profDomicilio = '" + txtDomicilio.Text + "', profMail = '" + txtMail.Text;
            string tabla = "Profesional";
            string key = "profId";
            int id = Convert.ToInt32(lblID);

            Metodos guardarprof = new Metodos();
            guardarprof.Inicializar();
            guardarprof.Update(tabla, id, valores, key);
        }
    }
}
