﻿namespace Principal
{
    partial class ModificarCategoria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label catIDLabel;
            System.Windows.Forms.Label catDescLabel;
            System.Windows.Forms.Label catNombreLabel;
            System.Windows.Forms.Label catMesActLabel;
            System.Windows.Forms.Label catMesInactLabel;
            System.Windows.Forms.Label catClubCardLabel;
            this.club_VistalbaDataSet = new Principal.Club_VistalbaDataSet();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriaTableAdapter = new Principal.Club_VistalbaDataSetTableAdapters.CategoriaTableAdapter();
            this.tableAdapterManager = new Principal.Club_VistalbaDataSetTableAdapters.TableAdapterManager();
            this.v = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtMesAct = new System.Windows.Forms.TextBox();
            this.txtMesInact = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.cbCard = new System.Windows.Forms.CheckBox();
            catIDLabel = new System.Windows.Forms.Label();
            catDescLabel = new System.Windows.Forms.Label();
            catNombreLabel = new System.Windows.Forms.Label();
            catMesActLabel = new System.Windows.Forms.Label();
            catMesInactLabel = new System.Windows.Forms.Label();
            catClubCardLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.club_VistalbaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // catIDLabel
            // 
            catIDLabel.AutoSize = true;
            catIDLabel.Location = new System.Drawing.Point(12, 18);
            catIDLabel.Name = "catIDLabel";
            catIDLabel.Size = new System.Drawing.Size(21, 13);
            catIDLabel.TabIndex = 5;
            catIDLabel.Text = "ID:";
            // 
            // catDescLabel
            // 
            catDescLabel.AutoSize = true;
            catDescLabel.Location = new System.Drawing.Point(12, 44);
            catDescLabel.Name = "catDescLabel";
            catDescLabel.Size = new System.Drawing.Size(66, 13);
            catDescLabel.TabIndex = 7;
            catDescLabel.Text = "Descripción:";
            // 
            // catNombreLabel
            // 
            catNombreLabel.AutoSize = true;
            catNombreLabel.Location = new System.Drawing.Point(12, 70);
            catNombreLabel.Name = "catNombreLabel";
            catNombreLabel.Size = new System.Drawing.Size(47, 13);
            catNombreLabel.TabIndex = 9;
            catNombreLabel.Text = "Nombre:";
            // 
            // catMesActLabel
            // 
            catMesActLabel.AutoSize = true;
            catMesActLabel.Location = new System.Drawing.Point(12, 96);
            catMesActLabel.Name = "catMesActLabel";
            catMesActLabel.Size = new System.Drawing.Size(79, 13);
            catMesActLabel.TabIndex = 11;
            catMesActLabel.Text = "Meses Activos:";
            // 
            // catMesInactLabel
            // 
            catMesInactLabel.AutoSize = true;
            catMesInactLabel.Location = new System.Drawing.Point(12, 122);
            catMesInactLabel.Name = "catMesInactLabel";
            catMesInactLabel.Size = new System.Drawing.Size(87, 13);
            catMesInactLabel.TabIndex = 13;
            catMesInactLabel.Text = "Meses Inactivos:";
            // 
            // catClubCardLabel
            // 
            catClubCardLabel.AutoSize = true;
            catClubCardLabel.Location = new System.Drawing.Point(12, 148);
            catClubCardLabel.Name = "catClubCardLabel";
            catClubCardLabel.Size = new System.Drawing.Size(56, 13);
            catClubCardLabel.TabIndex = 15;
            catClubCardLabel.Text = "Club Card:";
            // 
            // club_VistalbaDataSet
            // 
            this.club_VistalbaDataSet.DataSetName = "Club_VistalbaDataSet";
            this.club_VistalbaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataMember = "Categoria";
            this.categoriaBindingSource.DataSource = this.club_VistalbaDataSet;
            // 
            // categoriaTableAdapter
            // 
            this.categoriaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ActividadesTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriaTableAdapter = this.categoriaTableAdapter;
            this.tableAdapterManager.CuotaTableAdapter = null;
            this.tableAdapterManager.GrupoTableAdapter = null;
            this.tableAdapterManager.MensualTableAdapter = null;
            this.tableAdapterManager.ProfesionalTableAdapter = null;
            this.tableAdapterManager.SaludTableAdapter = null;
            this.tableAdapterManager.SocioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Principal.Club_VistalbaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // v
            // 
            this.v.Location = new System.Drawing.Point(12, 180);
            this.v.Name = "v";
            this.v.Size = new System.Drawing.Size(75, 31);
            this.v.TabIndex = 4;
            this.v.Text = "Guardar";
            this.v.UseVisualStyleBackColor = true;
            this.v.Click += new System.EventHandler(this.v_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(130, 180);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 31);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriaBindingSource, "catDesc", true));
            this.txtDescripcion.Location = new System.Drawing.Point(105, 37);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcion.TabIndex = 8;
            // 
            // txtNombre
            // 
            this.txtNombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriaBindingSource, "catNombre", true));
            this.txtNombre.Location = new System.Drawing.Point(105, 63);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 10;
            // 
            // txtMesAct
            // 
            this.txtMesAct.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriaBindingSource, "catMesAct", true));
            this.txtMesAct.Location = new System.Drawing.Point(105, 89);
            this.txtMesAct.Name = "txtMesAct";
            this.txtMesAct.Size = new System.Drawing.Size(100, 20);
            this.txtMesAct.TabIndex = 12;
            // 
            // txtMesInact
            // 
            this.txtMesInact.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriaBindingSource, "catMesInact", true));
            this.txtMesInact.Location = new System.Drawing.Point(105, 115);
            this.txtMesInact.Name = "txtMesInact";
            this.txtMesInact.Size = new System.Drawing.Size(100, 20);
            this.txtMesInact.TabIndex = 14;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(102, 18);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(66, 13);
            this.lblID.TabIndex = 16;
            this.lblID.Text = "ID Categoria";
            // 
            // cbCard
            // 
            this.cbCard.AutoSize = true;
            this.cbCard.Location = new System.Drawing.Point(105, 147);
            this.cbCard.Name = "cbCard";
            this.cbCard.Size = new System.Drawing.Size(92, 17);
            this.cbCard.TabIndex = 17;
            this.cbCard.Text = "Con Beneficio";
            this.cbCard.UseVisualStyleBackColor = true;
            this.cbCard.CheckedChanged += new System.EventHandler(this.cbCard_CheckedChanged);
            // 
            // ModificarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 225);
            this.Controls.Add(this.cbCard);
            this.Controls.Add(this.lblID);
            this.Controls.Add(catIDLabel);
            this.Controls.Add(catDescLabel);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(catNombreLabel);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(catMesActLabel);
            this.Controls.Add(this.txtMesAct);
            this.Controls.Add(catMesInactLabel);
            this.Controls.Add(this.txtMesInact);
            this.Controls.Add(catClubCardLabel);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.v);
            this.Name = "ModificarCategoria";
            this.Text = "ModificarCategoria";
            this.Load += new System.EventHandler(this.ModificarCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.club_VistalbaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Club_VistalbaDataSet club_VistalbaDataSet;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private Club_VistalbaDataSetTableAdapters.CategoriaTableAdapter categoriaTableAdapter;
        private Club_VistalbaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button v;
        private System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.TextBox txtDescripcion;
        public System.Windows.Forms.Label lblID;
        public System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.TextBox txtMesAct;
        public System.Windows.Forms.TextBox txtMesInact;
        public System.Windows.Forms.CheckBox cbCard;
    }
}