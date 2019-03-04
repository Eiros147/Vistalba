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
    public partial class ModificarActividad : Form
    {
        public ModificarActividad()
        {
            InitializeComponent();
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

        }

        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            txtNombre.Enabled = true;
            txtProfesor.Enabled = true;
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

            string valores = "actNombre = '" + txtNombre + "', actDesc = '" + txtDesc;
            string tabla = "";
            string key = "";
            int id = 3;

            modMetodo.Update(tabla, id, key, valores);
        }
    }
}
