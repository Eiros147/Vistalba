﻿using System;
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
    public partial class Grupos : Form
    {
        OleDbConnection conActv = new OleDbConnection();

        public Grupos()
        {
            InitializeComponent();
            conActv.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Mi PC\Documents\Proyecto Club\Vistalba\Vistalba\Principal\Principal\Club Vistalba.accdb;
Persist Security Info=False;";

        }

        private void grupoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.grupoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.club_VistalbaDataSet);

        }

        private void Grupos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'club_VistalbaDataSet.Categoria' Puede moverla o quitarla según sea necesario.
            //this.categoriaTableAdapter.Fill(this.club_VistalbaDataSet.Categoria);

            cargar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            NuevoGrupo nuevo = new NuevoGrupo();
            nuevo.ShowDialog();
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            NuevoGrupo nuevo = new NuevoGrupo();
            nuevo.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            modificar();
        }

        private void modificar()
        {
            conActv.Open();
            ModificarGrupo mod = new ModificarGrupo();

            string busqueda = "SELECT grupoID FROM Grupo WHERE (grupoNombre LIKE '" + dgvGrupos.CurrentRow.Cells[0].Value.ToString() + "')";
            OleDbCommand comando = new OleDbCommand(busqueda, conActv);

            //MessageBox.Show(busqueda);

            string temporal = Convert.ToString(comando.ExecuteScalar());

            mod.txtApellido.Text = dgvGrupos.CurrentRow.Cells[1].Value.ToString();
            mod.txtSocio.Text = dgvGrupos.CurrentRow.Cells[2].Value.ToString();
            mod.txtPersona2.Text = dgvGrupos.CurrentRow.Cells[3].Value.ToString();
            mod.txtPersona3.Text = dgvGrupos.CurrentRow.Cells[4].Value.ToString();
            mod.lblID.Text = temporal;
            
            mod.ShowDialog();

            conActv.Close();
        }

        private void cargar()
        {
            Metodos cargado = new Metodos();

            string valores = "Grupo.grupoNombre, Grupo.grupoApellido, Grupo.grupoSocioPpal, Grupo.grupoSocio1, Grupo.grupoSocio2";
            string tabla = "(Categoria INNER JOIN Grupo ON Categoria.catID = Grupo.catID)";
            cargado.Inicializar();

            cargado.Llenardgv(tabla, valores, dgvGrupos);

          
        }
    }
}
