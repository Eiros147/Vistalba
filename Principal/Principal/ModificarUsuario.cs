using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace Principal
{
    public partial class ModificarUsuario : Form
    {
        OleDbConnection conModificar = new OleDbConnection();
        Image Foto;
        Bitmap MyImage;

        public ModificarUsuario()
        {
            InitializeComponent();
            conModificar.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Club Vistalba.accdb;
Persist Security Info=False;";
           
        }

        OleDbCommand comando = new OleDbCommand();

        void FillCombo()
        {

        }

        private void socioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.socioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.club_VistalbaDataSet);

        }

        private void ModificarUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'club_VistalbaDataSet.Categoria' Puede moverla o quitarla según sea necesario.
            this.categoriaTableAdapter.Fill(this.club_VistalbaDataSet.Categoria);
            string key = lblID.Text.ToString();



            CargaNota(txtNotas, lblID);
            //CargaImagen(lblID);

            Seleccionar("catNombre", "Categoria", cbCategoria, "catID", "catNombre");
            Seleccionar("nivelNombre", "Niveles", cbNivel, "nivelID", "nivelNombre");

            Seleccion("catNombre", "Categoria", cbCategoria, "catID", lblcatID);
            Seleccion("nivelNombre", "Niveles", cbNivel, "nivelID", lblnivelID);

            AutoCargaFoto();
        }

        private void Seleccion(string valor, string tabla, ComboBox cb, string id, Label lbl)
        {
            try
            {
                conModificar.Open();
                string busqueda = "SELECT " + valor + " FROM " + tabla + " WHERE (" + id + " LIKE '" + lbl.Text + "')";
                OleDbCommand comando = new OleDbCommand(busqueda, conModificar);
                string temporal = Convert.ToString(comando.ExecuteScalar());
                cb.SelectedIndex = cb.FindStringExact(temporal);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
            finally
            {
                conModificar.Close();
            }
        }

        private void Seleccionar(string valor, string tabla, ComboBox cb, string id, string orden)
        {
            Metodos llenar = new Metodos();
            llenar.Inicializar();
            llenar.LlenarCombo(valor, tabla, cb, id, orden);
        }

        private void CargaImagen(Label lbl)
        {
            conModificar.Open();
            string query = "SELECT socioFoto FROM Socio WHERE socioID = " + lbl.Text + "";
            comando.Connection = conModificar;
            comando.CommandText = query;

            conModificar.Close();
        }

        private void CargaNota(TextBox tx, Label lbl)
        {
            conModificar.Open();
            string query = "SELECT socioNotas FROM Socio WHERE socioID = " + lbl.Text + "";
            comando.Connection = conModificar;
            comando.CommandText = query;

            //MessageBox.Show(query);

            OleDbDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                tx.AppendText(lector["socioNotas"].ToString());
            }

            conModificar.Close();
        }

        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            txtNombre.Enabled = true;
            txtDireccion.Enabled = true;
            txtCelular.Enabled = true;
            txtDNI.Enabled = true;
            txtMail.Enabled = true;
            txtTelefono.Enabled = true;
            cbCategoria.Enabled = true;
            //dtpIngreso.Enabled = true;
            dtpNacimiento.Enabled = true;
            txtNotas.Enabled = true;
            cbCategoria.Enabled = true;
            cbNivel.Enabled = true;
            rbHombre.Enabled = true;
            rbMujer.Enabled = true;
            cbEstado.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void socioMailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void guardar()
        {
            int flag;
            if (rbHombre.Checked)
            {
                flag = 1;
            }
            else
            {
                flag = 0;
            }

            int estado;
            if (cbEstado.Checked)
            {
                estado = 1;
            }
            else
            {
                estado = 0;
            }

            //MessageBox.Show(dtpNacimiento.Value.ToString());
            //MessageBox.Show(dtpNacimiento.Value.ToShortDateString());
            double intermedio = dtpNacimiento.Value.ToOADate();
            string segundo = intermedio.ToString();
            //MessageBox.Show(segundo);


            string seters = "socioNombre = '" + txtNombre.Text + "', socioFechaNac = " + dtpNacimiento.Value.ToOADate() + ", socioDNI = " + txtDNI.Text + ", socioDireccion = '" + txtDireccion.Text + "', socioMail = '" + txtMail.Text + "', socioNotas = '" + txtNotas.Text + "', socioCategoria = '" + cbCategoria.Text + "', socioTelefono = " + txtTelefono.Text + ", socioCelular = " + txtCelular.Text + ", socioGenero = " + flag + ", socioEstado = " + estado + ", socioNivel = '" + cbNivel.Text + "'";
            string tabla = "Socio";
            string key = "socioID";
            int id = Convert.ToInt32(lblID.Text);

            Metodos modMetodo = new Metodos();
            modMetodo.Inicializar();

            modMetodo.Update(tabla, id, seters, key);

            GuardarFoto();

        }
        
        private void Seleccionar(ComboBox cb, string value, string table, string identificador, string orden, string key, int mod)
        {
            Metodos llenado = new Metodos();
            llenado.Inicializar();
            llenado.LlenarCombo(value, table, cb, identificador, orden);

        }
         
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void rbHombre_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSalud_Click(object sender, EventArgs e)
        {
            conModificar.Open();
            string query = "SELECT socioNombre FROM Socio WHERE socioID = " + lblID.Text + "";

            comando.CommandText = query;
            comando.Connection = conModificar;

            string temporal = comando.ExecuteScalar().ToString();

            ModificarSalud salud = new ModificarSalud();
            salud.lblNombre.Text = temporal;
            salud.idsocio = Convert.ToInt32(lblID.Text);

            salud.ShowDialog();
            conModificar.Close();
        }
              
        private void cbEstado_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEstado.Checked == true)
            {
                cbEstado.Text = "Activo";
            }
            else if(cbEstado.Checked == false)
            {
                cbEstado.Text = "Inactivo";
            }
        }

        private void btnGrupo_Click(object sender, EventArgs e)
        {
            ModificarGrupo modif = new ModificarGrupo();
            modif.ShowDialog();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.categoriaTableAdapter.FillBy(this.club_VistalbaDataSet.Categoria);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillOrdenadoToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.categoriaTableAdapter.FillOrdenado(this.club_VistalbaDataSet.Categoria);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillOrdenadoToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.categoriaTableAdapter.FillOrdenado(this.club_VistalbaDataSet.Categoria);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private byte[] GuardarFoto()
        {
            MemoryStream ms = new MemoryStream();
            pbSocioFoto.Image.Save(ms, pbSocioFoto.Image.RawFormat);
            return ms.GetBuffer();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            //string query = "SELECT socioFoto FROM Socio WHERE socioID ='" + lblID.Text + "'";
            //comando = new OleDbCommand(query, conModificar);
            //OleDbDataReader lector;

            //try
            //{
            //    conModificar.Open();
            //    lector = comando.ExecuteReader();
            //    while (lector.Read())
            //    {

            //        if (lector.HasRows)
            //        {
            //            byte[] images = (byte[])(lector["socioFoto"]);

            //            if (images == null)
            //            {
            //                socioFotoPictureBox.Image = null;
            //            }
            //            else
            //            {
            //                MemoryStream mstream = new MemoryStream(images);
            //                socioFotoPictureBox.Image = Image.FromStream(mstream);
            //            }
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error" + ex);
            //}
            //finally
            //{
            //    conModificar.Close();
            //}
        }

        private void socioFotoPictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Elija una foto";
            //ofd.InitialDirectory();
            ofd.Filter = "JPG(*.JPG)|*.jpg";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                Foto = Image.FromFile(ofd.FileName);
                pbSocioFoto.Image = Foto;
            }
        }

        private void AutoCargaFoto()
        {
            String nombreimagen = txtDNI.Text;
            //MessageBox.Show(nombreimagen);
            if (MyImage != null)
            {
                MyImage.Dispose();
            }

            if (File.Exists(@"C:\Users\Usuario\Socios\" + nombreimagen + ".jpg")) { 
                pbSocioFoto.ImageLocation = @"C:\Users\Usuario\Socios\" + nombreimagen + ".jpg";
                //pbSocioFoto.ImageLocation = @"C:\Users\Mi PC\Documents\Proyecto Club\Vistalba\Vistalba\Principal\fotos\" + nombreimagen;
                pbSocioFoto.Load();
            }
            else
            {
                pbSocioFoto.ImageLocation = @"C:\Users\Usuario\Socios\default.jpg";
                pbSocioFoto.Load();
            }
        }

        private void btnGuardarFoto_Click(object sender, EventArgs e)
        {
            SaveFileDialog f = new SaveFileDialog();
            f.Filter = "JPG(*.JPG)|*.jpg";

            if(f.ShowDialog() == DialogResult.OK)
            {
                Foto.Save(f.FileName);
            }
        }
    }
}
