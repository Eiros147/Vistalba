namespace Principal
{
    partial class Grupos
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
            this.dgvGrupos = new System.Windows.Forms.DataGridView();
            this.grupoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.club_VistalbaDataSet = new Principal.Club_VistalbaDataSet();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.grupoTableAdapter = new Principal.Club_VistalbaDataSetTableAdapters.GrupoTableAdapter();
            this.tableAdapterManager = new Principal.Club_VistalbaDataSetTableAdapters.TableAdapterManager();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriaTableAdapter = new Principal.Club_VistalbaDataSetTableAdapters.CategoriaTableAdapter();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.rbSocioPpal = new System.Windows.Forms.RadioButton();
            this.rbApellido = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.club_VistalbaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGrupos
            // 
            this.dgvGrupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrupos.Location = new System.Drawing.Point(12, 12);
            this.dgvGrupos.Name = "dgvGrupos";
            this.dgvGrupos.Size = new System.Drawing.Size(754, 316);
            this.dgvGrupos.TabIndex = 1;
            // 
            // grupoBindingSource
            // 
            this.grupoBindingSource.DataMember = "Grupo";
            this.grupoBindingSource.DataSource = this.club_VistalbaDataSet;
            // 
            // club_VistalbaDataSet
            // 
            this.club_VistalbaDataSet.DataSetName = "Club_VistalbaDataSet";
            this.club_VistalbaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(12, 350);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 35);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click_1);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(102, 350);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 35);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // grupoTableAdapter
            // 
            this.grupoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ActividadesTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriaTableAdapter = null;
            this.tableAdapterManager.CuotaTableAdapter = null;
            this.tableAdapterManager.GrupoTableAdapter = this.grupoTableAdapter;
            this.tableAdapterManager.MensualTableAdapter = null;
            this.tableAdapterManager.NivelesTableAdapter = null;
            this.tableAdapterManager.ProfesionalTableAdapter = null;
            this.tableAdapterManager.SaludTableAdapter = null;
            this.tableAdapterManager.SocioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Principal.Club_VistalbaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ValorFijoTableAdapter = null;
            // 
            // btnCerrar
            // 
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrar.Location = new System.Drawing.Point(192, 350);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 35);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
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
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(543, 358);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(223, 20);
            this.txtBusqueda.TabIndex = 5;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(462, 350);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 35);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // rbSocioPpal
            // 
            this.rbSocioPpal.AutoSize = true;
            this.rbSocioPpal.Checked = true;
            this.rbSocioPpal.Location = new System.Drawing.Point(361, 350);
            this.rbSocioPpal.Name = "rbSocioPpal";
            this.rbSocioPpal.Size = new System.Drawing.Size(95, 17);
            this.rbSocioPpal.TabIndex = 7;
            this.rbSocioPpal.TabStop = true;
            this.rbSocioPpal.Text = "Socio Principal";
            this.rbSocioPpal.UseVisualStyleBackColor = true;
            // 
            // rbApellido
            // 
            this.rbApellido.AutoSize = true;
            this.rbApellido.Location = new System.Drawing.Point(361, 373);
            this.rbApellido.Name = "rbApellido";
            this.rbApellido.Size = new System.Drawing.Size(62, 17);
            this.rbApellido.TabIndex = 8;
            this.rbApellido.Text = "Apellido";
            this.rbApellido.UseVisualStyleBackColor = true;
            // 
            // Grupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 397);
            this.Controls.Add(this.rbApellido);
            this.Controls.Add(this.rbSocioPpal);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dgvGrupos);
            this.Name = "Grupos";
            this.Text = "Grupos";
            this.Load += new System.EventHandler(this.Grupos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.club_VistalbaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Club_VistalbaDataSet club_VistalbaDataSet;
        private System.Windows.Forms.BindingSource grupoBindingSource;
        private Club_VistalbaDataSetTableAdapters.GrupoTableAdapter grupoTableAdapter;
        private Club_VistalbaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dgvGrupos;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private Club_VistalbaDataSetTableAdapters.CategoriaTableAdapter categoriaTableAdapter;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.RadioButton rbSocioPpal;
        private System.Windows.Forms.RadioButton rbApellido;
    }
}