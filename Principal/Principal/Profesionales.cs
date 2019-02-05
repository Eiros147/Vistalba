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
    public partial class Profesionales : Form
    {
        public Profesionales()
        {
            InitializeComponent();
        }

        private void profesionalBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.profesionalBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.club_VistalbaDataSet);

        }

        private void Profesionales_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'club_VistalbaDataSet.Profesional' Puede moverla o quitarla según sea necesario.
            this.profesionalTableAdapter.Fill(this.club_VistalbaDataSet.Profesional);

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            NuevoProfesional nuprof = new NuevoProfesional();
            nuprof.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarProfesional moprof = new ModificarProfesional();
            moprof.ShowDialog();
        }
    }
}