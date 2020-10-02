namespace Principal
{
    partial class Niveles
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
            this.dgvNiveles = new System.Windows.Forms.DataGridView();
            this.nivelNumeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nivelNombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nivelesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.club_VistalbaDataSet = new Principal.Club_VistalbaDataSet();
            this.nivelesTableAdapter = new Principal.Club_VistalbaDataSetTableAdapters.NivelesTableAdapter();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNiveles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nivelesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.club_VistalbaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNiveles
            // 
            this.dgvNiveles.AutoGenerateColumns = false;
            this.dgvNiveles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNiveles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nivelNumeroDataGridViewTextBoxColumn,
            this.nivelNombreDataGridViewTextBoxColumn});
            this.dgvNiveles.DataSource = this.nivelesBindingSource;
            this.dgvNiveles.Location = new System.Drawing.Point(12, 12);
            this.dgvNiveles.Name = "dgvNiveles";
            this.dgvNiveles.Size = new System.Drawing.Size(618, 233);
            this.dgvNiveles.TabIndex = 0;
            // 
            // nivelNumeroDataGridViewTextBoxColumn
            // 
            this.nivelNumeroDataGridViewTextBoxColumn.DataPropertyName = "nivelNumero";
            this.nivelNumeroDataGridViewTextBoxColumn.HeaderText = "Numero";
            this.nivelNumeroDataGridViewTextBoxColumn.Name = "nivelNumeroDataGridViewTextBoxColumn";
            // 
            // nivelNombreDataGridViewTextBoxColumn
            // 
            this.nivelNombreDataGridViewTextBoxColumn.DataPropertyName = "nivelNombre";
            this.nivelNombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nivelNombreDataGridViewTextBoxColumn.Name = "nivelNombreDataGridViewTextBoxColumn";
            // 
            // nivelesBindingSource
            // 
            this.nivelesBindingSource.DataMember = "Niveles";
            this.nivelesBindingSource.DataSource = this.club_VistalbaDataSet;
            // 
            // club_VistalbaDataSet
            // 
            this.club_VistalbaDataSet.DataSetName = "Club_VistalbaDataSet";
            this.club_VistalbaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nivelesTableAdapter
            // 
            this.nivelesTableAdapter.ClearBeforeFill = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(12, 258);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 35);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(93, 258);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 35);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(174, 258);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 35);
            this.btnActualizar.TabIndex = 3;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Visible = false;
            // 
            // Niveles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 305);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dgvNiveles);
            this.Name = "Niveles";
            this.Text = "Niveles";
            this.Load += new System.EventHandler(this.Niveles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNiveles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nivelesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.club_VistalbaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNiveles;
        private Club_VistalbaDataSet club_VistalbaDataSet;
        private System.Windows.Forms.BindingSource nivelesBindingSource;
        private Club_VistalbaDataSetTableAdapters.NivelesTableAdapter nivelesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nivelNumeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nivelNombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnActualizar;
    }
}