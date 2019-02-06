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
    public partial class PagosMensuales : Form
    {
        public PagosMensuales()
        {
            InitializeComponent();
        }

        private void mensualBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mensualBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.club_VistalbaDataSet);

        }

        private void PagosMensuales_Load(object sender, EventArgs e)
        {
            
            
            // TODO: esta línea de código carga datos en la tabla 'club_VistalbaDataSet.Mensual' Puede moverla o quitarla según sea necesario.
            //this.mensualTableAdapter.Fill(this.club_VistalbaDataSet.Mensual);

        }
    }
}
