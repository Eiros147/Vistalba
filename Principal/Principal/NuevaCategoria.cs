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
    public partial class NuevaCategoria : Form
    {
        OleDbConnection conNuevo = new OleDbConnection();


        public NuevaCategoria()
        {
            InitializeComponent();
            conNuevo.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Club Vistalba.accdb;
Persist Security Info=False;";
        }

        private void categoriaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.categoriaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.club_VistalbaDataSet);

        }

        private void NuevaCategoria_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'club_VistalbaDataSet.Categoria' Puede moverla o quitarla según sea necesario.
            //this.categoriaTableAdapter.Fill(this.club_VistalbaDataSet.Categoria);

            try
            {
                conNuevo.Open();
                string query = "SELECT TOP 1 catID FROM Categoria ORDER BY catID DESC ";
                OleDbCommand command = new OleDbCommand(query, conNuevo);


                string temporal = command.ExecuteScalar().ToString();
                int numero = Int32.Parse(temporal);
                numero = numero + 1;
                lblCatID.Text = numero.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectarse " + ex);
            }
            finally
            {
                conNuevo.Close();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardar();
            this.Refresh();
        }

        private void guardar()
        {
            Metodos guardar = new Metodos();

            int tarjeta;

            if(cbCard.Checked)
            {
                tarjeta = 1;
            }
            else
            {
                tarjeta = 2;
            }

            string tabla = "Categoria";
            string sets = "catDesc, catNombre, catMesAct, catMesInact, catClubCard";
            string valores = "'" + txtDescripcion + "','" + txtNombre + "'," + txtMesAct + "," + txtMesInact + "," + tarjeta;

            guardar.Inicializar();
            guardar.Insertar(tabla, sets, valores);
        }

        private void cbCard_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCard.Checked == true)
            {
                cbCard.Text = "Con beneficios";
            }
            else if (cbCard.Checked == false)
            {
                cbCard.Text = "Sin beneficios";
            }
        }
    }
}
