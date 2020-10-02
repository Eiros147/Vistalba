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
    public partial class NuevoNivel : Form
    {
        public NuevoNivel()
        {
            InitializeComponent();
        }


        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Metodos insertar = new Metodos();
            insertar.Inicializar();

            string tabla = "Niveles";
            string sets = "nivelNumero, nivelNombre";
            string valores = "'" + txtNumero.Text + "','" + txtNombre.Text + "'";

            insertar.Insertar(tabla, sets, valores);
        }
    }
}
