namespace Principal
{
    partial class ModificarActividades
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
            System.Windows.Forms.Label actIdLabel;
            System.Windows.Forms.Label actDescLabel;
            System.Windows.Forms.Label actMesesLabel;
            System.Windows.Forms.Label actNombreLabel;
            System.Windows.Forms.Label profNombreLabel;
            this.club_VistalbaDataSet = new Principal.Club_VistalbaDataSet();
            this.actividadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.actividadesTableAdapter = new Principal.Club_VistalbaDataSetTableAdapters.ActividadesTableAdapter();
            this.tableAdapterManager = new Principal.Club_VistalbaDataSetTableAdapters.TableAdapterManager();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtMeses = new System.Windows.Forms.TextBox();
            this.txtNombreAct = new System.Windows.Forms.TextBox();
            this.profesionalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.profesionalTableAdapter = new Principal.Club_VistalbaDataSetTableAdapters.ProfesionalTableAdapter();
            this.txtNombreProfesor = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            actIdLabel = new System.Windows.Forms.Label();
            actDescLabel = new System.Windows.Forms.Label();
            actMesesLabel = new System.Windows.Forms.Label();
            actNombreLabel = new System.Windows.Forms.Label();
            profNombreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.club_VistalbaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesionalBindingSource)).BeginInit();
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
            this.tableAdapterManager.ProfesionalTableAdapter = this.profesionalTableAdapter;
            this.tableAdapterManager.SaludTableAdapter = null;
            this.tableAdapterManager.SocioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Principal.Club_VistalbaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // actIdLabel
            // 
            actIdLabel.AutoSize = true;
            actIdLabel.Location = new System.Drawing.Point(12, 9);
            actIdLabel.Name = "actIdLabel";
            actIdLabel.Size = new System.Drawing.Size(21, 13);
            actIdLabel.TabIndex = 1;
            actIdLabel.Text = "ID:";
            // 
            // actDescLabel
            // 
            actDescLabel.AutoSize = true;
            actDescLabel.Location = new System.Drawing.Point(12, 61);
            actDescLabel.Name = "actDescLabel";
            actDescLabel.Size = new System.Drawing.Size(66, 13);
            actDescLabel.TabIndex = 3;
            actDescLabel.Text = "Descripcion:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.actividadesBindingSource, "actDesc", true));
            this.txtDescripcion.Location = new System.Drawing.Point(83, 58);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcion.TabIndex = 4;
            // 
            // actMesesLabel
            // 
            actMesesLabel.AutoSize = true;
            actMesesLabel.Location = new System.Drawing.Point(12, 87);
            actMesesLabel.Name = "actMesesLabel";
            actMesesLabel.Size = new System.Drawing.Size(41, 13);
            actMesesLabel.TabIndex = 7;
            actMesesLabel.Text = "Meses:";
            // 
            // txtMeses
            // 
            this.txtMeses.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.actividadesBindingSource, "actMeses", true));
            this.txtMeses.Location = new System.Drawing.Point(83, 84);
            this.txtMeses.Name = "txtMeses";
            this.txtMeses.Size = new System.Drawing.Size(100, 20);
            this.txtMeses.TabIndex = 8;
            // 
            // actNombreLabel
            // 
            actNombreLabel.AutoSize = true;
            actNombreLabel.Location = new System.Drawing.Point(12, 35);
            actNombreLabel.Name = "actNombreLabel";
            actNombreLabel.Size = new System.Drawing.Size(47, 13);
            actNombreLabel.TabIndex = 9;
            actNombreLabel.Text = "Nombre:";
            // 
            // txtNombreAct
            // 
            this.txtNombreAct.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.actividadesBindingSource, "actNombre", true));
            this.txtNombreAct.Location = new System.Drawing.Point(83, 32);
            this.txtNombreAct.Name = "txtNombreAct";
            this.txtNombreAct.Size = new System.Drawing.Size(100, 20);
            this.txtNombreAct.TabIndex = 10;
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
            // profNombreLabel
            // 
            profNombreLabel.AutoSize = true;
            profNombreLabel.Location = new System.Drawing.Point(9, 113);
            profNombreLabel.Name = "profNombreLabel";
            profNombreLabel.Size = new System.Drawing.Size(49, 13);
            profNombreLabel.TabIndex = 10;
            profNombreLabel.Text = "Profesor:";
            // 
            // txtNombreProfesor
            // 
            this.txtNombreProfesor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profesionalBindingSource, "profNombre", true));
            this.txtNombreProfesor.Location = new System.Drawing.Point(83, 110);
            this.txtNombreProfesor.Name = "txtNombreProfesor";
            this.txtNombreProfesor.Size = new System.Drawing.Size(100, 20);
            this.txtNombreProfesor.TabIndex = 11;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(80, 9);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(65, 13);
            this.lblID.TabIndex = 12;
            this.lblID.Text = "ID Actividad";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(12, 146);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 34);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(108, 146);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 34);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // ModificarActividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 192);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblID);
            this.Controls.Add(profNombreLabel);
            this.Controls.Add(this.txtNombreProfesor);
            this.Controls.Add(actIdLabel);
            this.Controls.Add(actDescLabel);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(actMesesLabel);
            this.Controls.Add(this.txtMeses);
            this.Controls.Add(actNombreLabel);
            this.Controls.Add(this.txtNombreAct);
            this.Name = "ModificarActividades";
            this.Text = "ModificarActividades";
            this.Load += new System.EventHandler(this.ModificarActividades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.club_VistalbaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesionalBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Club_VistalbaDataSet club_VistalbaDataSet;
        private System.Windows.Forms.BindingSource actividadesBindingSource;
        private Club_VistalbaDataSetTableAdapters.ActividadesTableAdapter actividadesTableAdapter;
        private Club_VistalbaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtMeses;
        private System.Windows.Forms.TextBox txtNombreAct;
        private Club_VistalbaDataSetTableAdapters.ProfesionalTableAdapter profesionalTableAdapter;
        private System.Windows.Forms.BindingSource profesionalBindingSource;
        private System.Windows.Forms.TextBox txtNombreProfesor;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}