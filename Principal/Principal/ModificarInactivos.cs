using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Principal
{
    public partial class ModificarInactivos : Form
    {
        OleDbConnection conModificar = new OleDbConnection();
        Image Foto;
        Bitmap MyImage;

        public ModificarInactivos()
        {
            InitializeComponent();
            conModificar.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Club Vistalba.accdb;
Persist Security Info=False;";
        }

        private void socioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.socioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.club_VistalbaDataSet);

        }

        private void ModificarInactivos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'club_VistalbaDataSet.Socio' Puede moverla o quitarla según sea necesario.
            //this.socioTableAdapter.Fill(this.club_VistalbaDataSet.Socio);
            this.socioTableAdapter.FillBy(this.club_VistalbaDataSet.Socio);

            Seleccionar("catNombre", "Categoria", "catID", "catNombre", cbCategoria);
            Seleccionar("nivelNombre", "Niveles", "nivelID", "nivelNombre", cbNivel);

            Seleccion("catNombre", "Categoria", "catID", cbCategoria, lblID);
            Seleccion("nivelNombre", "Niveles", "nivelID", cbNivel, lblID);

        }

        private void cbEstado_CheckedChanged(object sender, EventArgs e)
        {
            if(cbEstado.Checked == true)
            {
                cbEstado.Text = "Activo";
            }
            else if(cbEstado.Checked == false)
            {
                cbEstado.Text = "Inactivo";
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int genero;
            if (rbHombre.Checked)
            {
                genero = 1;
            }
            else
            {
                genero = 0;
            }

            int activo;
            if (cbEstado.Checked)
            {
                activo = 1;
            }
            else
            {
                activo = 0;
            }

            string seters = "socioNombre = '" + txtNombre.Text + "', socioDNI = " + txtDNI.Text + ", socioDireccion = '" + txtDireccion.Text + "', socioMail = '" + txtMail.Text + "', socioNotas = '" + txtNotas.Text + "', socioCategoria = '" + cbCategoria.Text + "', socioTelefono = " + txtTelefono.Text + ", socioCelular = " + txtCelular.Text + ", socioGenero = " + genero + ", socioEstado = " + activo + ", socioNivel = '" + cbNivel.Text + "'";
            string tabla = "Socio";
            string key = "socioID";
            int id = Convert.ToInt32(lblID.Text);

            Metodos grabar = new Metodos();
            grabar.Inicializar();
            grabar.Update(tabla, id, seters, key);
        }

        private void AutoCargaFoto()
        {
            String nombreimagen = txtDNI.Text;

            if(File.Exists(@"C:\Users\Mi PC\Documents\Proyecto Club\Vistalba\Vistalba\Principal\fotos\" + nombreimagen + ".jpg"))
            {
                pbFoto.ImageLocation = @"C:\Users\Mi PC\Documents\Proyecto Club\Vistalba\Vistalba\Principal\fotos\" + nombreimagen + ".jpg";
                pbFoto.Load();
            }
            else
            {
                pbFoto.ImageLocation = @"C:\Users\Mi PC\Documents\Proyecto Club\Vistalba\Vistalba\Principal\fotos\default.jpg";
                pbFoto.Load();
            }


        }

        private void cbEliminar_CheckedChanged(object sender, EventArgs e)
        {
            if(cbEliminar.Checked == true)
            {
                btnEliminar.Enabled = true;
            }else if (cbEliminar.Checked == false)
            {
                btnEliminar.Enabled = false;
            }
        }

        private void Seleccion(string valor, string tabla, string id, ComboBox cb, Label lbl)
        {
            try
            {
                conModificar.Open();
                string busqueda = "SELECT " + valor + " FROM " + tabla + " WHERE (" + id + " LIKE '" + lbl.Text + "')";
                OleDbCommand comando = new OleDbCommand(busqueda, conModificar);
                string temporal = Convert.ToString(comando.ExecuteScalar());
                cb.SelectedIndex = cb.FindStringExact(temporal);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
            finally
            {
                conModificar.Close();
            }
        }

        private void Seleccionar(string valor, string tabla, string id, string orden, ComboBox cb)
        {
            Metodos llenar = new Metodos();
            llenar.Inicializar();
            llenar.LlenarCombo(valor, tabla, cb, id, orden);
        }
    }
}
