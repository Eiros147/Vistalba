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
    public partial class DetalleGrupos : Form
    {
        public DetalleGrupos()
        {
            InitializeComponent();
        }

        private void grupoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.grupoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.club_VistalbaDataSet);

        }

        private void DetalleGrupos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'club_VistalbaDataSet.Grupo' Puede moverla o quitarla según sea necesario.
            //this.grupoTableAdapter.Fill(this.club_VistalbaDataSet.Grupo);


            Seleccionar(cbCategoria);
        }

        private void Seleccionar(ComboBox cb)
        {
            string valor = "catNombre";
            string tabla = "Categoria";
            string id = "catID";
            string ordenador = "catNombre";

            Metodos cargar = new Metodos();
            cargar.Inicializar();
            //cargar.LlenarCombo(valor, tabla, cb, id, ordenador);
        }
    }
}
