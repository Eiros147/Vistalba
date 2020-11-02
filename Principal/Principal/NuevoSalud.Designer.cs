namespace Principal
{
    partial class NuevoSalud
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
            this.cbAlergia = new System.Windows.Forms.CheckBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtSangre = new System.Windows.Forms.TextBox();
            this.txtMedicamentos = new System.Windows.Forms.TextBox();
            this.txtObra = new System.Windows.Forms.TextBox();
            this.txtTelefonoEmerg = new System.Windows.Forms.TextBox();
            this.socioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.socioTableAdapter = new Principal.Club_VistalbaDataSetTableAdapters.SocioTableAdapter();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtExtra = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
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
            saludAlergiaLabel.Location = new System.Drawing.Point(12, 46);
            saludAlergiaLabel.Name = "saludAlergiaLabel";
            saludAlergiaLabel.Size = new System.Drawing.Size(42, 13);
            saludAlergiaLabel.TabIndex = 5;
            saludAlergiaLabel.Text = "Alergia:";
            // 
            // saludAlergiaDescLabel
            // 
            saludAlergiaDescLabel.AutoSize = true;
            saludAlergiaDescLabel.Location = new System.Drawing.Point(12, 74);
            saludAlergiaDescLabel.Name = "saludAlergiaDescLabel";
            saludAlergiaDescLabel.Size = new System.Drawing.Size(70, 13);
            saludAlergiaDescLabel.TabIndex = 7;
            saludAlergiaDescLabel.Text = "Alergia Desc:";
            // 
            // saludSangreLabel
            // 
            saludSangreLabel.AutoSize = true;
            saludSangreLabel.Location = new System.Drawing.Point(12, 104);
            saludSangreLabel.Name = "saludSangreLabel";
            saludSangreLabel.Size = new System.Drawing.Size(44, 13);
            saludSangreLabel.TabIndex = 9;
            saludSangreLabel.Text = "Sangre:";
            // 
            // saludMedLabel
            // 
            saludMedLabel.AutoSize = true;
            saludMedLabel.Location = new System.Drawing.Point(12, 130);
            saludMedLabel.Name = "saludMedLabel";
            saludMedLabel.Size = new System.Drawing.Size(79, 13);
            saludMedLabel.TabIndex = 11;
            saludMedLabel.Text = "Medicamentos:";
            // 
            // saludObraSocLabel
            // 
            saludObraSocLabel.AutoSize = true;
            saludObraSocLabel.Location = new System.Drawing.Point(12, 156);
            saludObraSocLabel.Name = "saludObraSocLabel";
            saludObraSocLabel.Size = new System.Drawing.Size(55, 13);
            saludObraSocLabel.TabIndex = 13;
            saludObraSocLabel.Text = "Obra Soc:";
            // 
            // saludTelEmLabel
            // 
            saludTelEmLabel.AutoSize = true;
            saludTelEmLabel.Location = new System.Drawing.Point(12, 182);
            saludTelEmLabel.Name = "saludTelEmLabel";
            saludTelEmLabel.Size = new System.Drawing.Size(43, 13);
            saludTelEmLabel.TabIndex = 15;
            saludTelEmLabel.Text = "Tel Em:";
            // 
            // saludExtraLabel
            // 
            saludExtraLabel.AutoSize = true;
            saludExtraLabel.Location = new System.Drawing.Point(12, 208);
            saludExtraLabel.Name = "saludExtraLabel";
            saludExtraLabel.Size = new System.Drawing.Size(34, 13);
            saludExtraLabel.TabIndex = 17;
            saludExtraLabel.Text = "Extra:";
            // 
            // socioNombreLabel
            // 
            socioNombreLabel.AutoSize = true;
            socioNombreLabel.Location = new System.Drawing.Point(12, 23);
            socioNombreLabel.Name = "socioNombreLabel";
            socioNombreLabel.Size = new System.Drawing.Size(47, 13);
            socioNombreLabel.TabIndex = 18;
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
            this.tableAdapterManager.SocioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Principal.Club_VistalbaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ValorFijoTableAdapter = null;
            // 
            // cbAlergia
            // 
            this.cbAlergia.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.saludBindingSource, "saludAlergia", true));
            this.cbAlergia.Location = new System.Drawing.Point(116, 41);
            this.cbAlergia.Name = "cbAlergia";
            this.cbAlergia.Size = new System.Drawing.Size(104, 24);
            this.cbAlergia.TabIndex = 6;
            this.cbAlergia.Text = "Si";
            this.cbAlergia.UseVisualStyleBackColor = true;
            this.cbAlergia.CheckedChanged += new System.EventHandler(this.saludAlergiaCheckBox_CheckedChanged);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.saludBindingSource, "saludAlergiaDesc", true));
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Location = new System.Drawing.Point(116, 71);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(185, 20);
            this.txtDescripcion.TabIndex = 8;
            // 
            // txtSangre
            // 
            this.txtSangre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.saludBindingSource, "saludSangre", true));
            this.txtSangre.Location = new System.Drawing.Point(116, 101);
            this.txtSangre.Name = "txtSangre";
            this.txtSangre.Size = new System.Drawing.Size(185, 20);
            this.txtSangre.TabIndex = 10;
            // 
            // txtMedicamentos
            // 
            this.txtMedicamentos.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.saludBindingSource, "saludMed", true));
            this.txtMedicamentos.Location = new System.Drawing.Point(116, 127);
            this.txtMedicamentos.Name = "txtMedicamentos";
            this.txtMedicamentos.Size = new System.Drawing.Size(185, 20);
            this.txtMedicamentos.TabIndex = 12;
            // 
            // txtObra
            // 
            this.txtObra.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.saludBindingSource, "saludObraSoc", true));
            this.txtObra.Location = new System.Drawing.Point(116, 153);
            this.txtObra.Name = "txtObra";
            this.txtObra.Size = new System.Drawing.Size(185, 20);
            this.txtObra.TabIndex = 14;
            // 
            // txtTelefonoEmerg
            // 
            this.txtTelefonoEmerg.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.saludBindingSource, "saludTelEm", true));
            this.txtTelefonoEmerg.Location = new System.Drawing.Point(116, 179);
            this.txtTelefonoEmerg.Name = "txtTelefonoEmerg";
            this.txtTelefonoEmerg.Size = new System.Drawing.Size(185, 20);
            this.txtTelefonoEmerg.TabIndex = 16;
            // 
            // socioBindingSource
            // 
            this.socioBindingSource.DataMember = "Socio";
            this.socioBindingSource.DataSource = this.club_VistalbaDataSet;
            // 
            // socioTableAdapter
            // 
            this.socioTableAdapter.ClearBeforeFill = true;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(113, 23);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(89, 13);
            this.lblNombre.TabIndex = 19;
            this.lblNombre.Text = "Nombre del socio";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(15, 300);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 33);
            this.btnGuardar.TabIndex = 20;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(226, 300);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 33);
            this.button2.TabIndex = 21;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtExtra
            // 
            this.txtExtra.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.saludBindingSource, "saludExtra", true));
            this.txtExtra.Location = new System.Drawing.Point(116, 205);
            this.txtExtra.Multiline = true;
            this.txtExtra.Name = "txtExtra";
            this.txtExtra.Size = new System.Drawing.Size(185, 71);
            this.txtExtra.TabIndex = 18;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(234, 23);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(15, 13);
            this.lblID.TabIndex = 22;
            this.lblID.Text = "id";
            // 
            // NuevoSalud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 345);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(socioNombreLabel);
            this.Controls.Add(saludAlergiaLabel);
            this.Controls.Add(this.cbAlergia);
            this.Controls.Add(saludAlergiaDescLabel);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(saludSangreLabel);
            this.Controls.Add(this.txtSangre);
            this.Controls.Add(saludMedLabel);
            this.Controls.Add(this.txtMedicamentos);
            this.Controls.Add(saludObraSocLabel);
            this.Controls.Add(this.txtObra);
            this.Controls.Add(saludTelEmLabel);
            this.Controls.Add(this.txtTelefonoEmerg);
            this.Controls.Add(saludExtraLabel);
            this.Controls.Add(this.txtExtra);
            this.Name = "NuevoSalud";
            this.Text = "NuevoSalud";
            this.Load += new System.EventHandler(this.NuevoSalud_Load);
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
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtSangre;
        private System.Windows.Forms.TextBox txtMedicamentos;
        private System.Windows.Forms.TextBox txtObra;
        private System.Windows.Forms.TextBox txtTelefonoEmerg;
        private System.Windows.Forms.BindingSource socioBindingSource;
        private Club_VistalbaDataSetTableAdapters.SocioTableAdapter socioTableAdapter;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtExtra;
        public System.Windows.Forms.Label lblNombre;
        public System.Windows.Forms.Label lblID;
    }
}