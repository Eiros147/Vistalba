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
    public partial class Divisiones : Form
    {
        public string div;
        public int gen;

        public Divisiones(string division, int genero)
        {
            InitializeComponent();
            div = division;
            gen = genero;
        }
        

        private void Divisiones_Load(object sender, EventArgs e)
        {
            titulo();
            
            cargar();
        }

        public void titulo()
        {
            string sexo;
            if (gen == 1)
            {
                sexo = "Hombre";
            }
            else
            {
                sexo = "Mujer";
            }
            this.Text = div + " " + sexo;
        }

        public void cargar()
        {
            Metodos cargar = new Metodos();
            cargar.Inicializar();

            string tabla = "Socio";
            string valores = "socioNombre, socioDNI, socioDireccion, socioMail, socioTelefono, socioCelular, socioFechaIng, socioFechaUltPago, socioFechaNac";
            string condicion = "(socioGenero = " + gen + ") AND(socioNivel = '" + div + "')";

            cargar.Llenardgvcondiciones(tabla, valores, dgvDivision, condicion);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
