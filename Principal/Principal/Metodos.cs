using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data;
using System.IO;

namespace Principal
{
    class Metodos
    {

        public OleDbConnection conexion;

        //Definir conexión
        public void Inicializar()
        {
            string dircon = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Club Vistalba.accdb;
            Persist Security Info = False; ";
            conexion = new OleDbConnection(dircon);
        }

        //Abrir la conexión
        public bool AbrirCon()
        {
            try
            {
                conexion.Open();
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error " + ex);
                return false;
            }
        }

        //Cerrar la conexión
        public bool CerrarCon()
        {
            try
            {
                conexion.Close();
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error " + ex);
                return false;
            }
        }

        //Insertar
        public void Insertar(string tabla, string seters, string valores)
        {
            try
            {
                    string query = "INSERT INTO " + tabla + " (" + seters + ") VALUES (" + valores + ")";
                    AbrirCon();

                    OleDbCommand comando = new OleDbCommand(query, conexion);

                    //Control de query para testeo de errores
                    //MessageBox.Show(query);

                    comando.ExecuteNonQuery();
                    MessageBox.Show("Nuevo "+tabla+" guardado");
            }
            catch (Exception ex)
            {
                    MessageBox.Show("Error " + ex);
            }
            finally
            {
                this.CerrarCon();
            }
        }

        //Actualizar
        public void Update(string tabla, int id, string valores, string key)
        {
            try
            {
                string query = "UPDATE "+tabla+" SET "+valores+" WHERE "+key+ " = "+id+"";
                AbrirCon();

                OleDbCommand comando = new OleDbCommand(query, conexion);

                //Control de query para testeo de errores
                //MessageBox.Show(query);

                comando.ExecuteNonQuery();
                MessageBox.Show(tabla + " actualizado");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
            finally
            {
                this.CerrarCon();
            }
        }
               
        //Llenar tabla
        public void Llenardgv (string tabla, string valores, DataGridView dgv)
        {
            try
            {
                string query = "SELECT "+valores+" FROM "+tabla;
                AbrirCon();

                OleDbCommand comando = new OleDbCommand(query, conexion);

                //Control de query para testeo de errores
                MessageBox.Show(query);

                OleDbDataAdapter da = new OleDbDataAdapter(comando);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;

                comando.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
            finally
            {
                this.CerrarCon();
            }
        }

        //Llenar tabla con condiciones
        public void Llenardgvcondiciones(string tabla, string valores, DataGridView dgv,string condicion)
        {
            try
            {
                string query = "SELECT " + valores + " FROM " + tabla + " WHERE " + condicion + "";
                AbrirCon();

                OleDbCommand comando = new OleDbCommand(query, conexion);

                //Control de query para testeo de errores
                //MessageBox.Show(query);

                OleDbDataAdapter da = new OleDbDataAdapter(comando);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;

                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
            finally
            {
                this.CerrarCon();
            }
        }

        //Llenar label
        public void Llenarlabel(Label lbl, string tabla, string valor, string condicion, string igual)
        {
            try
            {
                string query = "SELECT " + valor + " FROM " + tabla + " WHERE (" + condicion + " = '" + igual + "')";
                AbrirCon();

                OleDbCommand comando = new OleDbCommand(query, conexion);
                
                //Control de query
                //MessageBox.Show(query);

                OleDbDataReader lector = comando.ExecuteReader();

                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
            finally
            {
                CerrarCon();
            }
        }

        //Llenar tabla ordenada
        public void Llenardgvordenado(string tabla, string valores, DataGridView dgv, string orden)
        {
            try
            {
                string query = "SELECT " + valores + " FROM " + tabla + " ORDER BY " + orden + ";";
                AbrirCon();

                OleDbCommand comando = new OleDbCommand(query, conexion);

                //Control de query para testeo de errores
                //MessageBox.Show(query);

                OleDbDataAdapter da = new OleDbDataAdapter(comando);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;

                comando.ExecuteNonQuery();
            }
            catch  (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
            finally
            {
                this.CerrarCon();
            }
        }

        //Llenar textboxs
        public void Llenartextbox(string valores, string tabla, string key, string id, TextBox tb)
        {
            try
            {
                string query = "SELECT " + valores + " FROM " + tabla + " WHERE " + key + " = '" + id + "'";
                AbrirCon();

                OleDbCommand comando = new OleDbCommand(query, conexion);

                //Control de query para testeo de errores
                //MessageBox.Show(query);

                OleDbDataReader lector = null;
                lector = comando.ExecuteReader();

                if (lector.Read())
                {
                    tb.Text = (lector[valores].ToString());
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
            finally
            {
                CerrarCon();
            }
        }

        //Llenar imagen
        public void Llenarimagen(string valor, string tabla, string key, string id, PictureBox pb)
        {
            try
            {
                string query = "SELECT " + valor + " FROM " + tabla + " WHERE " + key + " = '" + id + "'";
                AbrirCon();

                OleDbCommand comando = new OleDbCommand(query, conexion);

                OleDbDataReader lector = null;
                lector = comando.ExecuteReader();

                if (lector.Read())
                {
                    byte[] imgg = (byte[])(lector[valor]);
                    if (imgg == null)
                    {
                        pb.Image = null;
                    }
                    else
                    {
                        MemoryStream mstream = new MemoryStream(imgg);
                        pb.Image = System.Drawing.Image.FromStream(mstream);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
            finally
            {
                CerrarCon();
            }
        }

        //Busqueda
        public void Buscar(string tabla, string valores, DataGridView dgv, string condicion)
        {
            try
            {
                AbrirCon();

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
            finally
            {
                CerrarCon();
            }
        }

        //Llenar combobox
        public void LlenarCombo(string valor, string tabla,ComboBox cb,string id, string orden)
        {
            try
            {
                string query = "SELECT " + valor + " FROM " +tabla+ " ORDER BY " + orden;
                AbrirCon();

                OleDbCommand comando = new OleDbCommand(query, conexion);
                OleDbDataReader lector = comando.ExecuteReader();
                DataTable dt = new DataTable();

                dt.Columns.Add(valor, typeof(string));
                dt.Columns.Add(id, typeof(string));
                dt.Load(lector);

                cb.ValueMember = id;
                cb.DisplayMember = valor;
                cb.DataSource = dt;

                //MessageBox.Show(query);

            } catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            finally
            {
                CerrarCon();
            }
        }

        //Seleccionar
        public void Seleccionar(string valor, string tabla, ComboBox cb, string key, string id)
        {
            try
            {
                AbrirCon();
                string query = "SELECT " + valor + " FROM " + tabla + " WHERE " + key + " = " + id + "";

                OleDbCommand comando = new OleDbCommand(query, conexion);

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex);
            }
            finally
            {
                CerrarCon();
            }
        }
    }


}
