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
    public partial class NuevoUsuarioGrupo : Form
    {
        public NuevoUsuarioGrupo()
        {
            InitializeComponent();
        }

        private void grupoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.grupoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.club_VistalbaDataSet);

        }

        private void NuevoUsuarioGrupo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'club_VistalbaDataSet.Cuota' Puede moverla o quitarla según sea necesario.
            this.cuotaTableAdapter.Fill(this.club_VistalbaDataSet.Cuota);
            // TODO: esta línea de código carga datos en la tabla 'club_VistalbaDataSet.Grupo' Puede moverla o quitarla según sea necesario.
            this.grupoTableAdapter.Fill(this.club_VistalbaDataSet.Grupo);

        }
    }
}
