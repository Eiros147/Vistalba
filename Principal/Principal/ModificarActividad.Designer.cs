namespace Principal
{
    partial class ModificarActividad
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
            System.Windows.Forms.Label profIdLabel;
            System.Windows.Forms.Label actMesesLabel;
            System.Windows.Forms.Label actNombreLabel;
            this.club_VistalbaDataSet = new Principal.Club_VistalbaDataSet();
            this.actividadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.actividadesTableAdapter = new Principal.Club_VistalbaDataSetTableAdapters.ActividadesTableAdapter();
            this.tableAdapterManager = new Principal.Club_VistalbaDataSetTableAdapters.TableAdapterManager();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtMeses = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnHabilitar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.cbProfesor = new System.Windows.Forms.ComboBox();
            this.lblProfID = new System.Windows.Forms.Label();
            actIdLabel = new System.Windows.Forms.Label();
            actDescLabel = new System.Windows.Forms.Label();
            profIdLabel = new System.Windows.Forms.Label();
            actMesesLabel = new System.Windows.Forms.Label();
            actNombreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.club_VistalbaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // actIdLabel
            // 
            actIdLabel.AutoSize = true;
            actIdLabel.Location = new System.Drawing.Point(14, 15);
            actIdLabel.Name = "actIdLabel";
            actIdLabel.Size = new System.Drawing.Size(21, 13);
            actIdLabel.TabIndex = 1;
            actIdLabel.Text = "ID:";
            // 
            // actDescLabel
            // 
            actDescLabel.AutoSize = true;
            actDescLabel.Location = new System.Drawing.Point(14, 67);
            actDescLabel.Name = "actDescLabel";
            actDescLabel.Size = new System.Drawing.Size(66, 13);
            actDescLabel.TabIndex = 3;
            actDescLabel.Text = "Descripcion:";
            // 
            // profIdLabel
            // 
            profIdLabel.AutoSize = true;
            profIdLabel.Location = new System.Drawing.Point(14, 93);
            profIdLabel.Name = "profIdLabel";
            profIdLabel.Size = new System.Drawing.Size(49, 13);
            profIdLabel.TabIndex = 5;
            profIdLabel.Text = "Profesor:";
            // 
            // actMesesLabel
            // 
            actMesesLabel.AutoSize = true;
            actMesesLabel.Location = new System.Drawing.Point(14, 119);
            actMesesLabel.Name = "actMesesLabel";
            actMesesLabel.Size = new System.Drawing.Size(41, 13);
            actMesesLabel.TabIndex = 7;
            actMesesLabel.Text = "Meses:";
            // 
            // actNombreLabel
            // 
            actNombreLabel.AutoSize = true;
            actNombreLabel.Location = new System.Drawing.Point(14, 41);
            actNombreLabel.Name = "actNombreLabel";
            actNombreLabel.Size = new System.Drawing.Size(47, 13);
            actNombreLabel.TabIndex = 9;
            actNombreLabel.Text = "Nombre:";
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
            this.tableAdapterManager.NivelesTableAdapter = null;
            this.tableAdapterManager.ProfesionalTableAdapter = null;
            this.tableAdapterManager.SaludTableAdapter = null;
            this.tableAdapterManager.SocioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Principal.Club_VistalbaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ValorFijoTableAdapter = null;
            // 
            // txtDesc
            // 
            this.txtDesc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.actividadesBindingSource, "actDesc", true));
            this.txtDesc.Enabled = false;
            this.txtDesc.Location = new System.Drawing.Point(118, 64);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(146, 20);
            this.txtDesc.TabIndex = 4;
            // 
            // txtMeses
            // 
            this.txtMeses.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.actividadesBindingSource, "actMeses", true));
            this.txtMeses.Enabled = false;
            this.txtMeses.Location = new System.Drawing.Point(118, 116);
            this.txtMeses.Name = "txtMeses";
            this.txtMeses.Size = new System.Drawing.Size(146, 20);
            this.txtMeses.TabIndex = 8;
            // 
            // txtNombre
            // 
            this.txtNombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.actividadesBindingSource, "actNombre", true));
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(118, 38);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(146, 20);
            this.txtNombre.TabIndex = 10;
            // 
            // btnHabilitar
            // 
            this.btnHabilitar.Location = new System.Drawing.Point(12, 153);
            this.btnHabilitar.Name = "btnHabilitar";
            this.btnHabilitar.Size = new System.Drawing.Size(75, 36);
            this.btnHabilitar.TabIndex = 11;
            this.btnHabilitar.Text = "Habilitar";
            this.btnHabilitar.UseVisualStyleBackColor = true;
            this.btnHabilitar.Click += new System.EventHandler(this.btnHabilitar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(200, 153);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 36);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(108, 153);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 36);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(115, 15);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(65, 13);
            this.lblID.TabIndex = 14;
            this.lblID.Text = "ID Actividad";
            // 
            // cbProfesor
            // 
            this.cbProfesor.FormattingEnabled = true;
            this.cbProfesor.Location = new System.Drawing.Point(118, 90);
            this.cbProfesor.Name = "cbProfesor";
            this.cbProfesor.Size = new System.Drawing.Size(146, 21);
            this.cbProfesor.TabIndex = 15;
            // 
            // lblProfID
            // 
            this.lblProfID.AutoSize = true;
            this.lblProfID.Location = new System.Drawing.Point(229, 15);
            this.lblProfID.Name = "lblProfID";
            this.lblProfID.Size = new System.Drawing.Size(35, 13);
            this.lblProfID.TabIndex = 16;
            this.lblProfID.Text = "label1";
            // 
            // ModificarActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 203);
            this.Controls.Add(this.lblProfID);
            this.Controls.Add(this.cbProfesor);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnHabilitar);
            this.Controls.Add(actIdLabel);
            this.Controls.Add(actDescLabel);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(profIdLabel);
            this.Controls.Add(actMesesLabel);
            this.Controls.Add(this.txtMeses);
            this.Controls.Add(actNombreLabel);
            this.Controls.Add(this.txtNombre);
            this.Name = "ModificarActividad";
            this.Text = "Modificar Actividad";
            this.Load += new System.EventHandler(this.ModificarActividad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.club_VistalbaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Club_VistalbaDataSet club_VistalbaDataSet;
        private System.Windows.Forms.BindingSource actividadesBindingSource;
        private Club_VistalbaDataSetTableAdapters.ActividadesTableAdapter actividadesTableAdapter;
        private Club_VistalbaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnHabilitar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.Label lblID;
        public System.Windows.Forms.ComboBox cbProfesor;
        public System.Windows.Forms.TextBox txtDesc;
        public System.Windows.Forms.TextBox txtMeses;
        public System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.Label lblProfID;
    }
}