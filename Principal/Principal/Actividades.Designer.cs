namespace Principal
{
    partial class Actividades
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
            this.club_VistalbaDataSet = new Principal.Club_VistalbaDataSet();
            this.actividadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.actividadesTableAdapter = new Principal.Club_VistalbaDataSetTableAdapters.ActividadesTableAdapter();
            this.tableAdapterManager = new Principal.Club_VistalbaDataSetTableAdapters.TableAdapterManager();
            this.profesionalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.profesionalTableAdapter = new Principal.Club_VistalbaDataSetTableAdapters.ProfesionalTableAdapter();
            this.profesionalBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.actividadesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clubVistalbaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.actividadesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dgvActividades = new System.Windows.Forms.DataGridView();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.profesionalActividadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.profesionalActividadesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.club_VistalbaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesionalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesionalBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubVistalbaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActividades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesionalActividadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesionalActividadesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // club_VistalbaDataSet
            // 
            this.club_VistalbaDataSet.DataSetName = "Club_VistalbaDataSet";
            this.club_VistalbaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // actividadesBindingSource
            // 
            this.actividadesBindingSource.DataMember = "Actividades";
            this.actividadesBindingSource.DataSource = this.club_VistalbaDataSet;
            // 
            // actividadesTableAdapter
            // 
            this.actividadesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ActividadesTableAdapter = this.actividadesTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriaTableAdapter = null;
            this.tableAdapterManager.CuotaTableAdapter = null;
            this.tableAdapterManager.GrupoTableAdapter = null;
            this.tableAdapterManager.MensualTableAdapter = null;
            this.tableAdapterManager.ProfesionalTableAdapter = null;
            this.tableAdapterManager.SaludTableAdapter = null;
            this.tableAdapterManager.SocioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Principal.Club_VistalbaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // profesionalBindingSource
            // 
            this.profesionalBindingSource.DataMember = "Profesional";
            this.profesionalBindingSource.DataSource = this.club_VistalbaDataSet;
            // 
            // profesionalTableAdapter
            // 
            this.profesionalTableAdapter.ClearBeforeFill = true;
            // 
            // profesionalBindingSource1
            // 
            this.profesionalBindingSource1.DataMember = "Profesional";
            this.profesionalBindingSource1.DataSource = this.club_VistalbaDataSet;
            // 
            // actividadesBindingSource1
            // 
            this.actividadesBindingSource1.DataMember = "Actividades";
            this.actividadesBindingSource1.DataSource = this.club_VistalbaDataSet;
            // 
            // clubVistalbaDataSetBindingSource
            // 
            this.clubVistalbaDataSetBindingSource.DataSource = this.club_VistalbaDataSet;
            this.clubVistalbaDataSetBindingSource.Position = 0;
            // 
            // actividadesBindingSource2
            // 
            this.actividadesBindingSource2.DataMember = "Actividades";
            this.actividadesBindingSource2.DataSource = this.clubVistalbaDataSetBindingSource;
            // 
            // dgvActividades
            // 
            this.dgvActividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActividades.Location = new System.Drawing.Point(12, 21);
            this.dgvActividades.Name = "dgvActividades";
            this.dgvActividades.Size = new System.Drawing.Size(764, 343);
            this.dgvActividades.TabIndex = 0;
            this.dgvActividades.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvActividades_CellClick);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(409, 383);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(367, 20);
            this.txtBusqueda.TabIndex = 1;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(12, 376);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(90, 32);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // profesionalActividadesBindingSource
            // 
            this.profesionalActividadesBindingSource.DataMember = "ProfesionalActividades";
            this.profesionalActividadesBindingSource.DataSource = this.profesionalBindingSource;
            // 
            // profesionalActividadesBindingSource1
            // 
            this.profesionalActividadesBindingSource1.DataMember = "ProfesionalActividades";
            this.profesionalActividadesBindingSource1.DataSource = this.profesionalBindingSource;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(108, 376);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(90, 32);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(204, 376);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(90, 32);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // Actividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 415);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.dgvActividades);
            this.Name = "Actividades";
            this.Text = "Actividades";
            this.Activated += new System.EventHandler(this.Actividades_Activated);
            this.Load += new System.EventHandler(this.Actividades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.club_VistalbaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesionalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesionalBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubVistalbaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActividades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesionalActividadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesionalActividadesBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Club_VistalbaDataSet club_VistalbaDataSet;
        private System.Windows.Forms.BindingSource actividadesBindingSource;
        private Club_VistalbaDataSetTableAdapters.ActividadesTableAdapter actividadesTableAdapter;
        private Club_VistalbaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource profesionalBindingSource;
        private Club_VistalbaDataSetTableAdapters.ProfesionalTableAdapter profesionalTableAdapter;
        private System.Windows.Forms.BindingSource profesionalActividadesBindingSource;
        private System.Windows.Forms.BindingSource profesionalBindingSource1;
        private System.Windows.Forms.BindingSource profesionalActividadesBindingSource1;
        private System.Windows.Forms.BindingSource actividadesBindingSource1;
        private System.Windows.Forms.BindingSource clubVistalbaDataSetBindingSource;
        private System.Windows.Forms.BindingSource actividadesBindingSource2;
        private System.Windows.Forms.DataGridView dgvActividades;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCerrar;
    }
}