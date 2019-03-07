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
    public partial class NuevoSalud : Form
    {
        public NuevoSalud()
        {
            InitializeComponent();
        }

        private void saludBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.saludBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.club_VistalbaDataSet);

        }

        private void saludBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.saludBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.club_VistalbaDataSet);

        }

        private void NuevoSalud_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'club_VistalbaDataSet.Socio' Puede moverla o quitarla según sea necesario.
            //this.socioTableAdapter.Fill(this.club_VistalbaDataSet.Socio);
            // TODO: esta línea de código carga datos en la tabla 'club_VistalbaDataSet.Salud' Puede moverla o quitarla según sea necesario.
            //this.saludTableAdapter.Fill(this.club_VistalbaDataSet.Salud);

        }

        private void saludAlergiaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            txtDescripcion.Enabled = true;
        }
    }
}
