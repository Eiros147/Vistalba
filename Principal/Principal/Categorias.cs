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
    public partial class Categorias : Form
    {
        public Categorias()
        {
            InitializeComponent();
        }

        OleDbConnection conPagos = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Club Vistalba.accdb;
Persist Security Info=False;");
        OleDbCommand comando = new OleDbCommand();

        private void Categorias_Load(object sender, EventArgs e)
        {
            cargar();

            formatear();
        }

        private void cargar()
        {
            Metodos cargarcat = new Metodos();
            cargarcat.Inicializar();

            string query = "catNombre, catDesc, catClubCard, catMesAct, catMesInact";
            string orden = "catNombre";
            string tabla = "Categoria";

            cargarcat.Llenardgvordenado(tabla, query, dgvCategorias, orden);
        }

        private void formatear()
        {
            this.dgvCategorias.Columns[0].HeaderText = "Nombre";
            this.dgvCategorias.Columns[1].HeaderText = "Descripción";
            this.dgvCategorias.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dgvCategorias.Columns[2].HeaderText = "Club Card";
            this.dgvCategorias.Columns[3].HeaderText = "Costo Meses Activos";
            this.dgvCategorias.Columns[4].HeaderText = "Costo Meses Inactivos";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            NuevaCategoria nuevo = new NuevaCategoria();
            nuevo.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            modificar();
        }

        public void modificar()
        {
            conPagos.Open();
            string query = "SELECT catID FROM Categoria WHERE catNombre = '" + dgvCategorias.CurrentRow.Cells[0].Value.ToString() + "'";

            comando.Connection = conPagos;
            comando.CommandText = query;

            string temporal = comando.ExecuteScalar().ToString();

            ModificarCategoria nuovo = new ModificarCategoria();

            nuovo.lblID.Text = temporal;
            nuovo.txtDescripcion.Text = dgvCategorias.CurrentRow.Cells[1].Value.ToString();
            nuovo.txtNombre.Text = dgvCategorias.CurrentRow.Cells[0].Value.ToString();
            nuovo.txtMesAct.Text = dgvCategorias.CurrentRow.Cells[3].Value.ToString();
            nuovo.txtMesInact.Text = dgvCategorias.CurrentRow.Cells[4].Value.ToString();

            if (dgvCategorias.CurrentRow.Cells[2].Value.Equals(true))
            {
                nuovo.cbCard.Checked = true;
            }
            else
            {
                nuovo.cbCard.Checked = false;
            }

            nuovo.ShowDialog();

            conPagos.Close();
        }

        private void dgvCategorias_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }
    }
}