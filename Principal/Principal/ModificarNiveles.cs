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
    public partial class ModificarNiveles : Form
    {
        public ModificarNiveles()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Metodos guardar = new Metodos();
            guardar.Inicializar();

            string valores = "nivelNumero = '" + txtNumero.Text + "', nivelNombre ='" + txtNombre.Text + "'";
            string tabla = "Niveles";
            string key = "actID";
            int id = Convert.ToInt32(lblID.Text);

            guardar.Update(tabla, id, valores, key);
        }

    }
}
