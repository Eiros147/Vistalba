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
    public partial class ModificarCategoria : Form
    {
        public ModificarCategoria()
        {
            InitializeComponent();
        }

        private void categoriaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.categoriaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.club_VistalbaDataSet);

        }

        private void ModificarCategoria_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void v_Click(object sender, EventArgs e)
        {
            string tabla = "Categoria";
            string values = "catNombre ='" + txtNombre.Text + "', catDesc = '" + txtDescripcion.Text + "'";
            int id = Convert.ToInt32(lblID.Text);
            string key = "catID";

            Metodos guardar = new Metodos();
            guardar.Inicializar();
            guardar.Update(tabla, id, values, key);
        }

        private void cbCard_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCard.Checked == true)
            {
                cbCard.Text = "Con beneficios";
            }else if(cbCard.Checked == false)
            {
                cbCard.Text = "Sin beneficios";
            }
          
        }
    }
}
