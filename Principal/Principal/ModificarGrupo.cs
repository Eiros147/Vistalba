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
        OleDbCommand comando = new OleDbCommand();

        private void grupoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //this.Validate();
            //this.grupoBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.club_VistalbaDataSet);

        }

        private void ModificarGrupo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'club_VistalbaDataSet.Categoria' Puede moverla o quitarla según sea necesario.
            this.categoriaTableAdapter.Fill(this.club_VistalbaDataSet.Categoria);

            cargarcantidad();
            //Seleccionar()
        }

        private void cargarcantidad()
        {
            conModificar.Open();
            string query = "Select catCant FROM Categoria WHERE catNombre = '" + cbCategoria.Text + "'";

            comando.Connection = conModificar;
            comando.CommandText = query;

            using (OleDbDataReader dr = comando.ExecuteReader())
            {
                bool exito = dr.Read();
                if (exito)
                {
                    lblCantidad.Text = dr["catCant"].ToString();
                }
            }

            conModificar.Close();

        }

        private void Seleccionar(string valor, string tabla, ComboBox cb, string id, string orden)
        {
            Metodos llenar = new Metodos();
            llenar.Inicializar();
            llenar.LlenarCombo(valor, tabla, cb, id, orden);
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
            cargarcantidad();
            //Metodos labelelear = new Metodos();
            //labelelear.Inicializar();
            //labelelear.Llenarlabel(lblCantidad, "Categoria", "catCant", "catID", lblID.Text);
        }

        private void lblCantidad_TextChanged(object sender, EventArgs e)
        {
            if(lblCantidad.Text == "1")
            {
                txtPersona2.Visible = false;
                txtPersona3.Visible = false;
                txtPersona4.Visible = false;
            }else if(lblCantidad.Text == "2")
            {
                txtPersona2.Visible = true;
                txtPersona3.Visible = false;
                txtPersona4.Visible = false;
            }else if(lblCantidad.Text == "3")
            {
                txtPersona2.Visible = true;
                txtPersona3.Visible = true;
                txtPersona4.Visible = true;
            }else if(lblCantidad.Text == "4")
            {
                txtPersona2.Visible = true;
                txtPersona3.Visible = true;
                txtPersona4.Visible = true;
            }
        }
    }
}
