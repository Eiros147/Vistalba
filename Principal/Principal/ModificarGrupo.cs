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
    public partial class ModificarGrupo : Form
    {
        OleDbConnection conModificar = new OleDbConnection();

        public ModificarGrupo()
        {
            InitializeComponent();
            conModificar.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Club Vistalba.accdb;
Persist Security Info=False;";

        }

        private void grupoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //this.Validate();
            //this.grupoBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.club_VistalbaDataSet);

        }

        private void ModificarGrupo_Load(object sender, EventArgs e)
        {
            Metodos labelelear = new Metodos();
            labelelear.Inicializar();
            labelelear.Llenarlabel(lblCantidad, "Categoria", "catCant", "catID", lblID.Text);
        }

        private void Seleccionar(string valor, string tabla, ComboBox cb, string id, string orden)
        {
            Metodos llenar = new Metodos();
            //llenar.LlenarCombo(valor, tabla, cb, id, orden);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            using(ListaMiembros lista = new ListaMiembros())
            {
                if(lista.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    txtSocio.Text = lista.textoSeleccionado;
                }
            }
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            Metodos labelelear = new Metodos();
            labelelear.Inicializar();
            labelelear.Llenarlabel(lblCantidad, "Categoria", "catCant", "catID", lblID.Text);
        }
    }
}
