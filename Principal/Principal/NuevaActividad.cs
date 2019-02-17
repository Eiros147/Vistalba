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
    public partial class NuevaActividad : Form
    {
        public NuevaActividad()
        {
            InitializeComponent();
        }

        private void actividadesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.actividadesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.club_VistalbaDataSet);

        }

        private void NuevaActividad_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'club_VistalbaDataSet.Actividades' Puede moverla o quitarla según sea necesario.
            this.actividadesTableAdapter.Fill(this.club_VistalbaDataSet.Actividades);

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Metodos nuevometodo = new Metodos();
            nuevometodo.Inicializar();

            string tabla = "Actividades";
            string seters = "socioNombre, socioDNI, socioDireccion, socioMail, socioTelefono, socioCelular";
            //string valores = "'" + txtNombre.Text + "','" + txtDNI.Text + "','" + txtDireccion.Text + "','" + txtMail.Text + "','" + txtTelefono.Text + "','" + txtCelular.Text + "'";

            //nuevometodo.Insertar(tabla, seters, valores);
        }
    }
}
