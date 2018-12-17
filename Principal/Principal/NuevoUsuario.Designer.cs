namespace Principal
{
    partial class NuevoUsuario
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
            System.Windows.Forms.Label socioIDLabel;
            System.Windows.Forms.Label socioNombreLabel;
            System.Windows.Forms.Label socioDNILabel;
            System.Windows.Forms.Label socioDireccionLabel;
            System.Windows.Forms.Label socioMailLabel;
            System.Windows.Forms.Label socioTelefonoLabel;
            System.Windows.Forms.Label socioCelularLabel;
            System.Windows.Forms.Label socioFechaNacLabel;
            this.club_VistalbaDataSet = new Principal.Club_VistalbaDataSet();
            this.socioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.socioTableAdapter = new Principal.Club_VistalbaDataSetTableAdapters.SocioTableAdapter();
            this.tableAdapterManager = new Principal.Club_VistalbaDataSetTableAdapters.TableAdapterManager();
            this.grupoTableAdapter1 = new Principal.Club_VistalbaDataSetTableAdapters.GrupoTableAdapter();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.socioFechaNacDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.rbSi = new System.Windows.Forms.RadioButton();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.gboxGrupo = new System.Windows.Forms.GroupBox();
            this.cbGrupo = new System.Windows.Forms.ComboBox();
            this.grupoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            socioIDLabel = new System.Windows.Forms.Label();
            socioNombreLabel = new System.Windows.Forms.Label();
            socioDNILabel = new System.Windows.Forms.Label();
            socioDireccionLabel = new System.Windows.Forms.Label();
            socioMailLabel = new System.Windows.Forms.Label();
            socioTelefonoLabel = new System.Windows.Forms.Label();
            socioCelularLabel = new System.Windows.Forms.Label();
            socioFechaNacLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.club_VistalbaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.socioBindingSource)).BeginInit();
            this.gboxGrupo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grupoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // socioIDLabel
            // 
            socioIDLabel.AutoSize = true;
            socioIDLabel.Location = new System.Drawing.Point(12, 24);
            socioIDLabel.Name = "socioIDLabel";
            socioIDLabel.Size = new System.Drawing.Size(49, 13);
            socioIDLabel.TabIndex = 1;
            socioIDLabel.Text = "socio ID:";
            // 
            // socioNombreLabel
            // 
            socioNombreLabel.AutoSize = true;
            socioNombreLabel.Location = new System.Drawing.Point(12, 50);
            socioNombreLabel.Name = "socioNombreLabel";
            socioNombreLabel.Size = new System.Drawing.Size(75, 13);
            socioNombreLabel.TabIndex = 3;
            socioNombreLabel.Text = "socio Nombre:";
            // 
            // socioDNILabel
            // 
            socioDNILabel.AutoSize = true;
            socioDNILabel.Location = new System.Drawing.Point(12, 76);
            socioDNILabel.Name = "socioDNILabel";
            socioDNILabel.Size = new System.Drawing.Size(57, 13);
            socioDNILabel.TabIndex = 5;
            socioDNILabel.Text = "socio DNI:";
            // 
            // socioDireccionLabel
            // 
            socioDireccionLabel.AutoSize = true;
            socioDireccionLabel.Location = new System.Drawing.Point(12, 102);
            socioDireccionLabel.Name = "socioDireccionLabel";
            socioDireccionLabel.Size = new System.Drawing.Size(83, 13);
            socioDireccionLabel.TabIndex = 7;
            socioDireccionLabel.Text = "socio Direccion:";
            // 
            // socioMailLabel
            // 
            socioMailLabel.AutoSize = true;
            socioMailLabel.Location = new System.Drawing.Point(12, 128);
            socioMailLabel.Name = "socioMailLabel";
            socioMailLabel.Size = new System.Drawing.Size(57, 13);
            socioMailLabel.TabIndex = 9;
            socioMailLabel.Text = "socio Mail:";
            // 
            // socioTelefonoLabel
            // 
            socioTelefonoLabel.AutoSize = true;
            socioTelefonoLabel.Location = new System.Drawing.Point(12, 154);
            socioTelefonoLabel.Name = "socioTelefonoLabel";
            socioTelefonoLabel.Size = new System.Drawing.Size(80, 13);
            socioTelefonoLabel.TabIndex = 11;
            socioTelefonoLabel.Text = "socio Telefono:";
            // 
            // socioCelularLabel
            // 
            socioCelularLabel.AutoSize = true;
            socioCelularLabel.Location = new System.Drawing.Point(12, 180);
            socioCelularLabel.Name = "socioCelularLabel";
            socioCelularLabel.Size = new System.Drawing.Size(70, 13);
            socioCelularLabel.TabIndex = 13;
            socioCelularLabel.Text = "socio Celular:";
            // 
            // socioFechaNacLabel
            // 
            socioFechaNacLabel.AutoSize = true;
            socioFechaNacLabel.Location = new System.Drawing.Point(12, 207);
            socioFechaNacLabel.Name = "socioFechaNacLabel";
            socioFechaNacLabel.Size = new System.Drawing.Size(91, 13);
            socioFechaNacLabel.TabIndex = 15;
            socioFechaNacLabel.Text = "socio Fecha Nac:";
            // 
            // club_VistalbaDataSet
            // 
            this.club_VistalbaDataSet.DataSetName = "Club_VistalbaDataSet";
            this.club_VistalbaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.ActividadesTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriaTableAdapter = null;
            this.tableAdapterManager.CuotaTableAdapter = null;
            this.tableAdapterManager.GrupoTableAdapter = this.grupoTableAdapter1;
            this.tableAdapterManager.ProfesionalTableAdapter = null;
            this.tableAdapterManager.SaludTableAdapter = null;
            this.tableAdapterManager.SocioTableAdapter = this.socioTableAdapter;
            this.tableAdapterManager.UpdateOrder = Principal.Club_VistalbaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // grupoTableAdapter1
            // 
            this.grupoTableAdapter1.ClearBeforeFill = true;
            // 
            // txtNombre
            // 
            this.txtNombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.socioBindingSource, "socioNombre", true));
            this.txtNombre.Location = new System.Drawing.Point(130, 47);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtDNI
            // 
            this.txtDNI.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.socioBindingSource, "socioDNI", true));
            this.txtDNI.Location = new System.Drawing.Point(130, 73);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(200, 20);
            this.txtDNI.TabIndex = 6;
            // 
            // txtDireccion
            // 
            this.txtDireccion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.socioBindingSource, "socioDireccion", true));
            this.txtDireccion.Location = new System.Drawing.Point(130, 99);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(200, 20);
            this.txtDireccion.TabIndex = 8;
            // 
            // txtMail
            // 
            this.txtMail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.socioBindingSource, "socioMail", true));
            this.txtMail.Location = new System.Drawing.Point(130, 125);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(200, 20);
            this.txtMail.TabIndex = 10;
            // 
            // txtTelefono
            // 
            this.txtTelefono.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.socioBindingSource, "socioTelefono", true));
            this.txtTelefono.Location = new System.Drawing.Point(130, 151);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(200, 20);
            this.txtTelefono.TabIndex = 12;
            // 
            // txtCelular
            // 
            this.txtCelular.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.socioBindingSource, "socioCelular", true));
            this.txtCelular.Location = new System.Drawing.Point(130, 177);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(200, 20);
            this.txtCelular.TabIndex = 14;
            // 
            // socioFechaNacDateTimePicker
            // 
            this.socioFechaNacDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.socioBindingSource, "socioFechaNac", true));
            this.socioFechaNacDateTimePicker.Location = new System.Drawing.Point(130, 203);
            this.socioFechaNacDateTimePicker.Name = "socioFechaNacDateTimePicker";
            this.socioFechaNacDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.socioFechaNacDateTimePicker.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "label1";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(7, 376);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 26;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(250, 376);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 27;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // rbSi
            // 
            this.rbSi.AutoSize = true;
            this.rbSi.Location = new System.Drawing.Point(121, 19);
            this.rbSi.Name = "rbSi";
            this.rbSi.Size = new System.Drawing.Size(34, 17);
            this.rbSi.TabIndex = 29;
            this.rbSi.Text = "Si";
            this.rbSi.UseVisualStyleBackColor = true;
            this.rbSi.CheckedChanged += new System.EventHandler(this.rbSi_CheckedChanged);
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.Checked = true;
            this.rbNo.Location = new System.Drawing.Point(161, 19);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(39, 17);
            this.rbNo.TabIndex = 30;
            this.rbNo.TabStop = true;
            this.rbNo.Text = "No";
            this.rbNo.UseVisualStyleBackColor = true;
            this.rbNo.CheckedChanged += new System.EventHandler(this.rbNo_CheckedChanged);
            // 
            // gboxGrupo
            // 
            this.gboxGrupo.Controls.Add(this.cbGrupo);
            this.gboxGrupo.Controls.Add(this.rbNo);
            this.gboxGrupo.Controls.Add(this.rbSi);
            this.gboxGrupo.Location = new System.Drawing.Point(7, 288);
            this.gboxGrupo.Name = "gboxGrupo";
            this.gboxGrupo.Size = new System.Drawing.Size(321, 82);
            this.gboxGrupo.TabIndex = 31;
            this.gboxGrupo.TabStop = false;
            this.gboxGrupo.Text = "Grupo Familiar";
            // 
            // cbGrupo
            // 
            this.cbGrupo.DataSource = this.grupoBindingSource;
            this.cbGrupo.DisplayMember = "grupoApellido";
            this.cbGrupo.FormattingEnabled = true;
            this.cbGrupo.Location = new System.Drawing.Point(121, 42);
            this.cbGrupo.Name = "cbGrupo";
            this.cbGrupo.Size = new System.Drawing.Size(121, 21);
            this.cbGrupo.TabIndex = 31;
            this.cbGrupo.Visible = false;
            // 
            // grupoBindingSource
            // 
            this.grupoBindingSource.DataMember = "Grupo";
            this.grupoBindingSource.DataSource = this.club_VistalbaDataSet;
            // 
            // NuevoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 411);
            this.Controls.Add(this.gboxGrupo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label1);
            this.Controls.Add(socioIDLabel);
            this.Controls.Add(socioNombreLabel);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(socioDNILabel);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(socioDireccionLabel);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(socioMailLabel);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(socioTelefonoLabel);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(socioCelularLabel);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(socioFechaNacLabel);
            this.Controls.Add(this.socioFechaNacDateTimePicker);
            this.Name = "NuevoUsuario";
            this.Text = "Crear Usuario Nuevo";
            this.Load += new System.EventHandler(this.NuevoUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.club_VistalbaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.socioBindingSource)).EndInit();
            this.gboxGrupo.ResumeLayout(false);
            this.gboxGrupo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grupoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Club_VistalbaDataSet club_VistalbaDataSet;
        private System.Windows.Forms.BindingSource socioBindingSource;
        private Club_VistalbaDataSetTableAdapters.SocioTableAdapter socioTableAdapter;
        private Club_VistalbaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Club_VistalbaDataSetTableAdapters.GrupoTableAdapter grupoTableAdapter1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.DateTimePicker socioFechaNacDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.RadioButton rbSi;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.GroupBox gboxGrupo;
        private System.Windows.Forms.BindingSource grupoBindingSource;
        internal System.Windows.Forms.ComboBox cbGrupo;
    }
}