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
    public partial class SociosInactivos : Form
    {
        public SociosInactivos()
        {
            InitializeComponent();
        }

        OleDbConnection conexion = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Club Vistalba.accdb;
Persist Security Info=False;");

        private void SociosInactivos_Activated(object sender, EventArgs e)
        {
            cargar();
        }

        private void dgvInactivos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                if (e.Value is bool)
                {
                    bool value = (bool)e.Value;
                    e.Value = (value) ? "Hombre" : "Mujer";
                    e.FormattingApplied = true;
                }
            }
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (txtBusqueda.Text == "")
            {
                cargar();
            }
            else
            {
                buscar();
                this.dgvInactivos.EndEdit();
            }
        }

        private void cargar()
        {
            Metodos cargametodo = new Metodos();
            string tabla = "Socio";
            string valores = "socioNombre, socioDNI, socioDireccion, socioMail, socioTelefono, socioCelular, socioFechaIng, socioFechaUltPago, socioFechaNac, socioGenero, socioCategoria, socioNivel";
            string condicion = "socioEstado LIKE false";

            cargametodo.Inicializar();
            cargametodo.Llenardgvcondiciones(tabla, valores, dgvInactivos, condicion);
        }

        private void buscar()
        {
            DataTable dtDatos = new DataTable();
            string cadena = ("SELECT * FROM Socio WHERE socioNombre LIKE '" + txtBusqueda.Text + "%'");
            OleDbDataAdapter data = new OleDbDataAdapter(cadena, conexion);
            data.Fill(dtDatos);
            dgvInactivos.DataSource = dtDatos;
        }

        private void SociosInactivos_Load(object sender, EventArgs e)
        {
            cargar();
        }
    }
}
