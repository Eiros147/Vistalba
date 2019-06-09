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
    public partial class ModificarActividad : Form
    {
        OleDbConnection conNueva = new OleDbConnection();

        public ModificarActividad()
        {
            InitializeComponent();
            conNueva.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Club Vistalba.accdb;
Persist Security Info=False;";
        }

        private void actividadesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.actividadesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.club_VistalbaDataSet);

        }

        private void ModificarActividad_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'club_VistalbaDataSet.Actividades' Puede moverla o quitarla según sea necesario.
            this.actividadesTableAdapter.Fill(this.club_VistalbaDataSet.Actividades);

            

            Selecccionar(cbProfesor);
        }

        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            txtNombre.Enabled = true;
            cbProfesor.Enabled = true;
            txtMeses.Enabled = true;
            txtDesc.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Metodos modMetodo = new Metodos();
            modMetodo.Inicializar();

            string valores = "actNombre = '" + txtNombre.Text + "', actDesc = '" + txtDesc.Text + "'";
            string tabla = "Actividades";
            string key = "actId";
            int id = Convert.ToInt32(lblID.Text);

            //MessageBox.Show(valores);

            modMetodo.Update(tabla, id, valores, key);
        }

        private void Selecccionar(ComboBox cb)
        {
            string valor = "profNombre";
            string tabla = "Profesional";
            string id = "profId";
            string ordenador = "profNombre";

            Metodos elegirprof = new Metodos();
            elegirprof.Inicializar();
            elegirprof.LlenarCombo(valor, tabla, cb, id, ordenador);
        }
    }
}
