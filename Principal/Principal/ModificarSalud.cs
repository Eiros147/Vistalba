﻿using System;
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
    public partial class ModificarSalud : Form
    {
        public ModificarSalud()
        {
            InitializeComponent();
        }

        private void saludBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.saludBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.club_VistalbaDataSet);

        }

        private void ModificarSalud_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'club_VistalbaDataSet.Socio' Puede moverla o quitarla según sea necesario.
            this.socioTableAdapter.Fill(this.club_VistalbaDataSet.Socio);
            // TODO: esta línea de código carga datos en la tabla 'club_VistalbaDataSet.Salud' Puede moverla o quitarla según sea necesario.
            this.saludTableAdapter.Fill(this.club_VistalbaDataSet.Salud);

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int flag;
            if (cbAlergia.Checked)
            {
                flag = 1;
            }
            else
            {
                flag = 0;
            }

            string seters = "saludAlergia = '" + flag + "', saludAlergiaDesc = '" + txtDescripcion.Text + "', saludSangre = '" + txtSangre.Text + "', saludMed = '" + txtMedicamentos.Text + "', saludObraSoc = '" + txtObrasocial + "', saludTelEm = " + txtEmergencia.Text + ", saludExtra = '" + txtExtra.Text;
            string tabla = "Salud";
            string key = "saludID";
            
        }
    }
}
