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
    public partial class Niveles : Form
    {
        public Niveles()
        {
            InitializeComponent();
        }

        private void Niveles_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'club_VistalbaDataSet.Niveles' Puede moverla o quitarla según sea necesario.
            this.nivelesTableAdapter.Fill(this.club_VistalbaDataSet.Niveles);

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarNiveles modnivel = new ModificarNiveles();

            modnivel.txtNumero.Text = dgvNiveles.CurrentRow.Cells[0].Value.ToString();
            modnivel.txtNombre.Text = dgvNiveles.CurrentRow.Cells[1].Value.ToString();

            modnivel.ShowDialog();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            NuevoNivel nuevonivel = new NuevoNivel();

            nuevonivel.ShowDialog();
        }
    }
}
