namespace Principal
{
    partial class ModificarSalud
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
            System.Windows.Forms.Label saludAlergiaLabel;
            System.Windows.Forms.Label saludAlergiaDescLabel;
            System.Windows.Forms.Label saludSangreLabel;
            System.Windows.Forms.Label saludMedLabel;
            System.Windows.Forms.Label saludObraSocLabel;
            System.Windows.Forms.Label saludTelEmLabel;
            System.Windows.Forms.Label saludExtraLabel;
            System.Windows.Forms.Label socioNombreLabel;
            this.club_VistalbaDataSet = new Principal.Club_VistalbaDataSet();
            this.saludBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saludTableAdapter = new Principal.Club_VistalbaDataSetTableAdapters.SaludTableAdapter();
            this.tableAdapterManager = new Principal.Club_VistalbaDataSetTableAdapters.TableAdapterManager();
            this.socioTableAdapter = new Principal.Club_VistalbaDataSetTableAdapters.SocioTableAdapter();
            this.cbAlergia = new System.Windows.Forms.CheckBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtSangre = new System.Windows.Forms.TextBox();
            this.txtMedicamentos = new System.Windows.Forms.TextBox();
            this.txtObrasocial = new System.Windows.Forms.TextBox();
            this.txtEmergencia = new System.Windows.Forms.TextBox();
            this.txtExtra = new System.Windows.Forms.TextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.socioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblNombre = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lblid = new System.Windows.Forms.Label();
            saludAlergiaLabel = new System.Windows.Forms.Label();
            saludAlergiaDescLabel = new System.Windows.Forms.Label();
            saludSangreLabel = new System.Windows.Forms.Label();
            saludMedLabel = new System.Windows.Forms.Label();
            saludObraSocLabel = new System.Windows.Forms.Label();
            saludTelEmLabel = new System.Windows.Forms.Label();
            saludExtraLabel = new System.Windows.Forms.Label();
            socioNombreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.club_VistalbaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saludBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.socioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // saludAlergiaLabel
            // 
            saludAlergiaLabel.AutoSize = true;
            saludAlergiaLabel.Location = new System.Drawing.Point(10, 39);
            saludAlergiaLabel.Name = "saludAlergiaLabel";
            saludAlergiaLabel.Size = new System.Drawing.Size(42, 13);
            saludAlergiaLabel.TabIndex = 5;
            saludAlergiaLabel.Text = "Alergia:";
            // 
            // saludAlergiaDescLabel
            // 
            saludAlergiaDescLabel.AutoSize = true;
            saludAlergiaDescLabel.Location = new System.Drawing.Point(10, 67);
            saludAlergiaDescLabel.Name = "saludAlergiaDescLabel";
            saludAlergiaDescLabel.Size = new System.Drawing.Size(101, 13);
            saludAlergiaDescLabel.TabIndex = 7;
            saludAlergiaDescLabel.Text = "Alergia Descripción:";
            // 
            // saludSangreLabel
            // 
            saludSangreLabel.AutoSize = true;
            saludSangreLabel.Location = new System.Drawing.Point(10, 93);
            saludSangreLabel.Name = "saludSangreLabel";
            saludSangreLabel.Size = new System.Drawing.Size(44, 13);
            saludSangreLabel.TabIndex = 9;
            saludSangreLabel.Text = "Sangre:";
            // 
            // saludMedLabel
            // 
            saludMedLabel.AutoSize = true;
            saludMedLabel.Location = new System.Drawing.Point(10, 119);
            saludMedLabel.Name = "saludMedLabel";
            saludMedLabel.Size = new System.Drawing.Size(79, 13);
            saludMedLabel.TabIndex = 11;
            saludMedLabel.Text = "Medicamentos:";
            // 
            // saludObraSocLabel
            // 
            saludObraSocLabel.AutoSize = true;
            saludObraSocLabel.Location = new System.Drawing.Point(10, 145);
            saludObraSocLabel.Name = "saludObraSocLabel";
            saludObraSocLabel.Size = new System.Drawing.Size(65, 13);
            saludObraSocLabel.TabIndex = 13;
            saludObraSocLabel.Text = "Obra Social:";
            // 
            // saludTelEmLabel
            // 
            saludTelEmLabel.AutoSize = true;
            saludTelEmLabel.Location = new System.Drawing.Point(10, 171);
            saludTelEmLabel.Name = "saludTelEmLabel";
            saludTelEmLabel.Size = new System.Drawing.Size(116, 13);
            saludTelEmLabel.TabIndex = 15;
            saludTelEmLabel.Text = "Telefono Emergencias:";
            // 
            // saludExtraLabel
            // 
            saludExtraLabel.AutoSize = true;
            saludExtraLabel.Location = new System.Drawing.Point(10, 197);
            saludExtraLabel.Name = "saludExtraLabel";
            saludExtraLabel.Size = new System.Drawing.Size(34, 13);
            saludExtraLabel.TabIndex = 17;
            saludExtraLabel.Text = "Extra:";
            // 
            // socioNombreLabel
            // 
            socioNombreLabel.AutoSize = true;
            socioNombreLabel.Location = new System.Drawing.Point(10, 15);
            socioNombreLabel.Name = "socioNombreLabel";
            socioNombreLabel.Size = new System.Drawing.Size(47, 13);
            socioNombreLabel.TabIndex = 21;
            socioNombreLabel.Text = "Nombre:";
            // 
            // club_VistalbaDataSet
            // 
            this.club_VistalbaDataSet.DataSetName = "Club_VistalbaDataSet";
            this.club_VistalbaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // saludBindingSource
            // 
            this.saludBindingSource.DataMember = "Salud";
            this.saludBindingSource.DataSource = this.club_VistalbaDataSet;
            // 
            // saludTableAdapter
            // 
            this.saludTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ActividadesTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriaTableAdapter = null;
            this.tableAdapterManager.CuotaTableAdapter = null;
            this.tableAdapterManager.GrupoTableAdapter = null;
            this.tableAdapterManager.MensualTableAdapter = null;
            this.tableAdapterManager.NivelesTableAdapter = null;
            this.tableAdapterManager.ProfesionalTableAdapter = null;
            this.tableAdapterManager.SaludTableAdapter = this.saludTableAdapter;
            this.tableAdapterManager.SocioTableAdapter = this.socioTableAdapter;
            this.tableAdapterManager.UpdateOrder = Principal.Club_VistalbaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ValorFijoTableAdapter = null;
            // 
            // socioTableAdapter
            // 
            this.socioTableAdapter.ClearBeforeFill = true;
            // 
            // cbAlergia
            // 
            this.cbAlergia.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.saludBindingSource, "saludAlergia", true));
            this.cbAlergia.Location = new System.Drawing.Point(132, 34);
            this.cbAlergia.Name = "cbAlergia";
            this.cbAlergia.Size = new System.Drawing.Size(104, 24);
            this.cbAlergia.TabIndex = 6;
            this.cbAlergia.Text = "No";
            this.cbAlergia.UseVisualStyleBackColor = true;
            this.cbAlergia.CheckedChanged += new System.EventHandler(this.cbAlergia_CheckedChanged);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.saludBindingSource, "saludAlergiaDesc", true));
            this.txtDescripcion.Location = new System.Drawing.Point(132, 64);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(215, 20);
            this.txtDescripcion.TabIndex = 8;
            // 
            // txtSangre
            // 
            this.txtSangre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.saludBindingSource, "saludSangre", true));
            this.txtSangre.Location = new System.Drawing.Point(132, 90);
            this.txtSangre.Name = "txtSangre";
            this.txtSangre.Size = new System.Drawing.Size(215, 20);
            this.txtSangre.TabIndex = 10;
            // 
            // txtMedicamentos
            // 
            this.txtMedicamentos.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.saludBindingSource, "saludMed", true));
            this.txtMedicamentos.Location = new System.Drawing.Point(132, 116);
            this.txtMedicamentos.Name = "txtMedicamentos";
            this.txtMedicamentos.Size = new System.Drawing.Size(215, 20);
            this.txtMedicamentos.TabIndex = 12;
            // 
            // txtObrasocial
            // 
            this.txtObrasocial.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.saludBindingSource, "saludObraSoc", true));
            this.txtObrasocial.Location = new System.Drawing.Point(132, 142);
            this.txtObrasocial.Name = "txtObrasocial";
            this.txtObrasocial.Size = new System.Drawing.Size(215, 20);
            this.txtObrasocial.TabIndex = 14;
            // 
            // txtEmergencia
            // 
            this.txtEmergencia.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.saludBindingSource, "saludTelEm", true));
            this.txtEmergencia.Location = new System.Drawing.Point(132, 168);
            this.txtEmergencia.Name = "txtEmergencia";
            this.txtEmergencia.Size = new System.Drawing.Size(215, 20);
            this.txtEmergencia.TabIndex = 16;
            // 
            // txtExtra
            // 
            this.txtExtra.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.saludBindingSource, "saludExtra", true));
            this.txtExtra.Location = new System.Drawing.Point(132, 194);
            this.txtExtra.Multiline = true;
            this.txtExtra.Name = "txtExtra";
            this.txtExtra.Size = new System.Drawing.Size(215, 74);
            this.txtExtra.TabIndex = 18;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(13, 283);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 44);
            this.btnVolver.TabIndex = 19;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(272, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 44);
            this.button1.TabIndex = 21;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // socioBindingSource
            // 
            this.socioBindingSource.DataMember = "Socio";
            this.socioBindingSource.DataSource = this.club_VistalbaDataSet;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(129, 15);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(74, 13);
            this.lblNombre.TabIndex = 22;
            this.lblNombre.Text = "Nombre Socio";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(142, 283);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 44);
            this.button2.TabIndex = 23;
            this.button2.Text = "Volver";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(289, 15);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(35, 13);
            this.lblid.TabIndex = 24;
            this.lblid.Text = "label1";
            this.lblid.Visible = false;
            // 
            // ModificarSalud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 339);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(socioNombreLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(saludAlergiaLabel);
            this.Controls.Add(this.cbAlergia);
            this.Controls.Add(saludAlergiaDescLabel);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(saludSangreLabel);
            this.Controls.Add(this.txtSangre);
            this.Controls.Add(saludMedLabel);
            this.Controls.Add(this.txtMedicamentos);
            this.Controls.Add(saludObraSocLabel);
            this.Controls.Add(this.txtObrasocial);
            this.Controls.Add(saludTelEmLabel);
            this.Controls.Add(this.txtEmergencia);
            this.Controls.Add(saludExtraLabel);
            this.Controls.Add(this.txtExtra);
            this.Name = "ModificarSalud";
            this.Text = "ModificarSalud";
            this.Load += new System.EventHandler(this.ModificarSalud_Load);
            ((System.ComponentModel.ISupportInitialize)(this.club_VistalbaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saludBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.socioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Club_VistalbaDataSet club_VistalbaDataSet;
        private System.Windows.Forms.BindingSource saludBindingSource;
        private Club_VistalbaDataSetTableAdapters.SaludTableAdapter saludTableAdapter;
        private Club_VistalbaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.CheckBox cbAlergia;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button button1;
        private Club_VistalbaDataSetTableAdapters.SocioTableAdapter socioTableAdapter;
        private System.Windows.Forms.BindingSource socioBindingSource;
        public System.Windows.Forms.Label lblNombre;
        public System.Windows.Forms.TextBox txtDescripcion;
        public System.Windows.Forms.TextBox txtSangre;
        public System.Windows.Forms.TextBox txtMedicamentos;
        public System.Windows.Forms.TextBox txtObrasocial;
        public System.Windows.Forms.TextBox txtEmergencia;
        public System.Windows.Forms.TextBox txtExtra;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblid;
    }
}