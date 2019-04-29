using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data;

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
                //MessageBox.Show(query);

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

        //Llenar textboxs
        public void Llenartextbox(string valores, string tabla, string key, int id)
        {
            try
            {
                string query = "SELECT " + valores + " FROM " + tabla + " WHERE " + key + " = " + id + "";
                AbrirCon();

                OleDbCommand comando = new OleDbCommand(query, conexion);

                //Control de query para testeo de errores
                //MessageBox.Show(query);

                DataTable dt = new DataTable();
                OleDbDataReader lector = null;
                lector = comando.ExecuteReader();

                while (lector.Read())
                {

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
    }


}
