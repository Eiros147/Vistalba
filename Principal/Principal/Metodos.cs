using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

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
        public void Insertar(string tabla,int id, string seters)
        {
            if(tabla == "Socio")
            {

            }
            string query = "insert into ";
        }

    }


}
