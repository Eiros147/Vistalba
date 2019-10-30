﻿namespace Principal
{
    partial class ModificarUsuario
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
            System.Windows.Forms.Label socioFechaIngLabel;
            System.Windows.Forms.Label socioFechaUltPagoLabel;
            System.Windows.Forms.Label catIdLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            this.club_VistalbaDataSet = new Principal.Club_VistalbaDataSet();
            this.socioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.socioTableAdapter = new Principal.Club_VistalbaDataSetTableAdapters.SocioTableAdapter();
            this.tableAdapterManager = new Principal.Club_VistalbaDataSetTableAdapters.TableAdapterManager();
            this.grupoTableAdapter = new Principal.Club_VistalbaDataSetTableAdapters.GrupoTableAdapter();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.dtpNacimiento = new System.Windows.Forms.DateTimePicker();
            this.dtpIngreso = new System.Windows.Forms.DateTimePicker();
            this.dtpPago = new System.Windows.Forms.DateTimePicker();
            this.lblID = new System.Windows.Forms.Label();
            this.grupoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.btnHabilitar = new System.Windows.Forms.Button();
            this.btnSalud = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rbHombre = new System.Windows.Forms.RadioButton();
            this.rbMujer = new System.Windows.Forms.RadioButton();
            this.lblNotas = new System.Windows.Forms.Label();
            this.txtNotas = new System.Windows.Forms.TextBox();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.cbEstado = new System.Windows.Forms.CheckBox();
            this.cbNivel = new System.Windows.Forms.ComboBox();
            this.categoriaTableAdapter = new Principal.Club_VistalbaDataSetTableAdapters.CategoriaTableAdapter();
            this.lblcatID = new System.Windows.Forms.Label();
            this.lblnivelID = new System.Windows.Forms.Label();
            socioIDLabel = new System.Windows.Forms.Label();
            socioNombreLabel = new System.Windows.Forms.Label();
            socioDNILabel = new System.Windows.Forms.Label();
            socioDireccionLabel = new System.Windows.Forms.Label();
            socioMailLabel = new System.Windows.Forms.Label();
            socioTelefonoLabel = new System.Windows.Forms.Label();
            socioCelularLabel = new System.Windows.Forms.Label();
            socioFechaNacLabel = new System.Windows.Forms.Label();
            socioFechaIngLabel = new System.Windows.Forms.Label();
            socioFechaUltPagoLabel = new System.Windows.Forms.Label();
            catIdLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.club_VistalbaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.socioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // socioIDLabel
            // 
            socioIDLabel.AutoSize = true;
            socioIDLabel.Location = new System.Drawing.Point(12, 9);
            socioIDLabel.Name = "socioIDLabel";
            socioIDLabel.Size = new System.Drawing.Size(21, 13);
            socioIDLabel.TabIndex = 1;
            socioIDLabel.Text = "ID:";
            // 
            // socioNombreLabel
            // 
            socioNombreLabel.AutoSize = true;
            socioNombreLabel.Location = new System.Drawing.Point(12, 35);
            socioNombreLabel.Name = "socioNombreLabel";
            socioNombreLabel.Size = new System.Drawing.Size(47, 13);
            socioNombreLabel.TabIndex = 3;
            socioNombreLabel.Text = "Nombre:";
            // 
            // socioDNILabel
            // 
            socioDNILabel.AutoSize = true;
            socioDNILabel.Location = new System.Drawing.Point(12, 61);
            socioDNILabel.Name = "socioDNILabel";
            socioDNILabel.Size = new System.Drawing.Size(29, 13);
            socioDNILabel.TabIndex = 5;
            socioDNILabel.Text = "DNI:";
            // 
            // socioDireccionLabel
            // 
            socioDireccionLabel.AutoSize = true;
            socioDireccionLabel.Location = new System.Drawing.Point(12, 87);
            socioDireccionLabel.Name = "socioDireccionLabel";
            socioDireccionLabel.Size = new System.Drawing.Size(55, 13);
            socioDireccionLabel.TabIndex = 7;
            socioDireccionLabel.Text = "Direccion:";
            // 
            // socioMailLabel
            // 
            socioMailLabel.AutoSize = true;
            socioMailLabel.Location = new System.Drawing.Point(12, 113);
            socioMailLabel.Name = "socioMailLabel";
            socioMailLabel.Size = new System.Drawing.Size(39, 13);
            socioMailLabel.TabIndex = 9;
            socioMailLabel.Text = "E-Mail:";
            // 
            // socioTelefonoLabel
            // 
            socioTelefonoLabel.AutoSize = true;
            socioTelefonoLabel.Location = new System.Drawing.Point(12, 139);
            socioTelefonoLabel.Name = "socioTelefonoLabel";
            socioTelefonoLabel.Size = new System.Drawing.Size(52, 13);
            socioTelefonoLabel.TabIndex = 11;
            socioTelefonoLabel.Text = "Telefono:";
            // 
            // socioCelularLabel
            // 
            socioCelularLabel.AutoSize = true;
            socioCelularLabel.Location = new System.Drawing.Point(12, 165);
            socioCelularLabel.Name = "socioCelularLabel";
            socioCelularLabel.Size = new System.Drawing.Size(42, 13);
            socioCelularLabel.TabIndex = 13;
            socioCelularLabel.Text = "Celular:";
            // 
            // socioFechaNacLabel
            // 
            socioFechaNacLabel.AutoSize = true;
            socioFechaNacLabel.Location = new System.Drawing.Point(12, 233);
            socioFechaNacLabel.Name = "socioFechaNacLabel";
            socioFechaNacLabel.Size = new System.Drawing.Size(63, 13);
            socioFechaNacLabel.TabIndex = 15;
            socioFechaNacLabel.Text = "Fecha Nac:";
            // 
            // socioFechaIngLabel
            // 
            socioFechaIngLabel.AutoSize = true;
            socioFechaIngLabel.Location = new System.Drawing.Point(12, 259);
            socioFechaIngLabel.Name = "socioFechaIngLabel";
            socioFechaIngLabel.Size = new System.Drawing.Size(58, 13);
            socioFechaIngLabel.TabIndex = 17;
            socioFechaIngLabel.Text = "Fecha Ing:";
            // 
            // socioFechaUltPagoLabel
            // 
            socioFechaUltPagoLabel.AutoSize = true;
            socioFechaUltPagoLabel.Location = new System.Drawing.Point(12, 285);
            socioFechaUltPagoLabel.Name = "socioFechaUltPagoLabel";
            socioFechaUltPagoLabel.Size = new System.Drawing.Size(84, 13);
            socioFechaUltPagoLabel.TabIndex = 19;
            socioFechaUltPagoLabel.Text = "Fecha Ult Pago:";
            // 
            // catIdLabel
            // 
            catIdLabel.AutoSize = true;
            catIdLabel.Location = new System.Drawing.Point(12, 433);
            catIdLabel.Name = "catIdLabel";
            catIdLabel.Size = new System.Drawing.Size(55, 13);
            catIdLabel.TabIndex = 23;
            catIdLabel.Text = "Categoria:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 191);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(45, 13);
            label1.TabIndex = 34;
            label1.Text = "Genero:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(11, 458);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(43, 13);
            label2.TabIndex = 41;
            label2.Text = "Estado:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(12, 406);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(34, 13);
            label3.TabIndex = 43;
            label3.Text = "Nivel:";
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
            this.tableAdapterManager.GrupoTableAdapter = this.grupoTableAdapter;
            this.tableAdapterManager.MensualTableAdapter = null;
            this.tableAdapterManager.NivelesTableAdapter = null;
            this.tableAdapterManager.ProfesionalTableAdapter = null;
            this.tableAdapterManager.SaludTableAdapter = null;
            this.tableAdapterManager.SocioTableAdapter = this.socioTableAdapter;
            this.tableAdapterManager.UpdateOrder = Principal.Club_VistalbaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ValorFijoTableAdapter = null;
            // 
            // grupoTableAdapter
            // 
            this.grupoTableAdapter.ClearBeforeFill = true;
            // 
            // txtNombre
            // 
            this.txtNombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.socioBindingSource, "socioNombre", true));
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(130, 32);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(281, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtDNI
            // 
            this.txtDNI.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.socioBindingSource, "socioDNI", true));
            this.txtDNI.Enabled = false;
            this.txtDNI.Location = new System.Drawing.Point(130, 58);
            this.txtDNI.MaxLength = 8;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(281, 20);
            this.txtDNI.TabIndex = 6;
            // 
            // txtDireccion
            // 
            this.txtDireccion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.socioBindingSource, "socioDireccion", true));
            this.txtDireccion.Enabled = false;
            this.txtDireccion.Location = new System.Drawing.Point(130, 84);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(281, 20);
            this.txtDireccion.TabIndex = 8;
            // 
            // txtMail
            // 
            this.txtMail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.socioBindingSource, "socioMail", true));
            this.txtMail.Enabled = false;
            this.txtMail.Location = new System.Drawing.Point(130, 110);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(281, 20);
            this.txtMail.TabIndex = 10;
            this.txtMail.TextChanged += new System.EventHandler(this.socioMailTextBox_TextChanged);
            // 
            // txtTelefono
            // 
            this.txtTelefono.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.socioBindingSource, "socioTelefono", true));
            this.txtTelefono.Enabled = false;
            this.txtTelefono.Location = new System.Drawing.Point(130, 136);
            this.txtTelefono.MaxLength = 15;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(281, 20);
            this.txtTelefono.TabIndex = 12;
            // 
            // txtCelular
            // 
            this.txtCelular.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.socioBindingSource, "socioCelular", true));
            this.txtCelular.Enabled = false;
            this.txtCelular.Location = new System.Drawing.Point(130, 162);
            this.txtCelular.MaxLength = 15;
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(281, 20);
            this.txtCelular.TabIndex = 14;
            // 
            // dtpNacimiento
            // 
            this.dtpNacimiento.CustomFormat = "dd-MM-yyyy";
            this.dtpNacimiento.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.socioBindingSource, "socioFechaNac", true));
            this.dtpNacimiento.Enabled = false;
            this.dtpNacimiento.Location = new System.Drawing.Point(130, 229);
            this.dtpNacimiento.MaxDate = new System.DateTime(2019, 12, 25, 23, 59, 59, 0);
            this.dtpNacimiento.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dtpNacimiento.Name = "dtpNacimiento";
            this.dtpNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dtpNacimiento.TabIndex = 16;
            // 
            // dtpIngreso
            // 
            this.dtpIngreso.CustomFormat = "dd-MM-yyyy";
            this.dtpIngreso.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.socioBindingSource, "socioFechaIng", true));
            this.dtpIngreso.Enabled = false;
            this.dtpIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIngreso.Location = new System.Drawing.Point(130, 255);
            this.dtpIngreso.Name = "dtpIngreso";
            this.dtpIngreso.Size = new System.Drawing.Size(200, 20);
            this.dtpIngreso.TabIndex = 18;
            // 
            // dtpPago
            // 
            this.dtpPago.CustomFormat = "dd-MM-yyyy";
            this.dtpPago.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.socioBindingSource, "socioFechaUltPago", true));
            this.dtpPago.Enabled = false;
            this.dtpPago.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPago.Location = new System.Drawing.Point(130, 281);
            this.dtpPago.Name = "dtpPago";
            this.dtpPago.Size = new System.Drawing.Size(200, 20);
            this.dtpPago.TabIndex = 20;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(127, 9);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(55, 13);
            this.lblID.TabIndex = 25;
            this.lblID.Text = "Id Usuario";
            // 
            // grupoBindingSource
            // 
            this.grupoBindingSource.DataMember = "Grupo";
            this.grupoBindingSource.DataSource = this.club_VistalbaDataSet;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(336, 505);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 34);
            this.button2.TabIndex = 28;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnHabilitar
            // 
            this.btnHabilitar.Location = new System.Drawing.Point(12, 505);
            this.btnHabilitar.Name = "btnHabilitar";
            this.btnHabilitar.Size = new System.Drawing.Size(75, 34);
            this.btnHabilitar.TabIndex = 29;
            this.btnHabilitar.Text = "Habilitar";
            this.btnHabilitar.UseVisualStyleBackColor = true;
            this.btnHabilitar.Click += new System.EventHandler(this.btnHabilitar_Click);
            // 
            // btnSalud
            // 
            this.btnSalud.Location = new System.Drawing.Point(130, 505);
            this.btnSalud.Name = "btnSalud";
            this.btnSalud.Size = new System.Drawing.Size(75, 34);
            this.btnSalud.TabIndex = 30;
            this.btnSalud.Text = "Salud";
            this.btnSalud.UseVisualStyleBackColor = true;
            this.btnSalud.Click += new System.EventHandler(this.btnSalud_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(235, 505);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 34);
            this.btnGuardar.TabIndex = 32;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cbCategoria
            // 
            this.cbCategoria.Enabled = false;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(130, 430);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(281, 21);
            this.cbCategoria.TabIndex = 33;
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataMember = "Categoria";
            this.categoriaBindingSource.DataSource = this.club_VistalbaDataSet;
            // 
            // rbHombre
            // 
            this.rbHombre.AutoSize = true;
            this.rbHombre.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.socioBindingSource, "socioGenero", true));
            this.rbHombre.Location = new System.Drawing.Point(130, 189);
            this.rbHombre.Name = "rbHombre";
            this.rbHombre.Size = new System.Drawing.Size(62, 17);
            this.rbHombre.TabIndex = 35;
            this.rbHombre.TabStop = true;
            this.rbHombre.Text = "Hombre";
            this.rbHombre.UseVisualStyleBackColor = true;
            this.rbHombre.CheckedChanged += new System.EventHandler(this.rbHombre_CheckedChanged);
            // 
            // rbMujer
            // 
            this.rbMujer.AutoSize = true;
            this.rbMujer.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.socioBindingSource, "socioGenero", true));
            this.rbMujer.Location = new System.Drawing.Point(198, 189);
            this.rbMujer.Name = "rbMujer";
            this.rbMujer.Size = new System.Drawing.Size(51, 17);
            this.rbMujer.TabIndex = 36;
            this.rbMujer.TabStop = true;
            this.rbMujer.Text = "Mujer";
            this.rbMujer.UseVisualStyleBackColor = true;
            // 
            // lblNotas
            // 
            this.lblNotas.AutoSize = true;
            this.lblNotas.Location = new System.Drawing.Point(12, 311);
            this.lblNotas.Name = "lblNotas";
            this.lblNotas.Size = new System.Drawing.Size(35, 13);
            this.lblNotas.TabIndex = 37;
            this.lblNotas.Text = "Notas";
            // 
            // txtNotas
            // 
            this.txtNotas.Enabled = false;
            this.txtNotas.Location = new System.Drawing.Point(130, 311);
            this.txtNotas.Multiline = true;
            this.txtNotas.Name = "txtNotas";
            this.txtNotas.Size = new System.Drawing.Size(281, 86);
            this.txtNotas.TabIndex = 38;
            // 
            // pbFoto
            // 
            this.pbFoto.Location = new System.Drawing.Point(438, 12);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(229, 192);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFoto.TabIndex = 40;
            this.pbFoto.TabStop = false;
            // 
            // cbEstado
            // 
            this.cbEstado.AutoSize = true;
            this.cbEstado.Checked = true;
            this.cbEstado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbEstado.Location = new System.Drawing.Point(130, 457);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(56, 17);
            this.cbEstado.TabIndex = 42;
            this.cbEstado.Text = "Activo";
            this.cbEstado.UseVisualStyleBackColor = true;
            this.cbEstado.CheckedChanged += new System.EventHandler(this.cbEstado_CheckedChanged);
            // 
            // cbNivel
            // 
            this.cbNivel.Enabled = false;
            this.cbNivel.FormattingEnabled = true;
            this.cbNivel.Location = new System.Drawing.Point(130, 403);
            this.cbNivel.Name = "cbNivel";
            this.cbNivel.Size = new System.Drawing.Size(281, 21);
            this.cbNivel.TabIndex = 44;
            // 
            // categoriaTableAdapter
            // 
            this.categoriaTableAdapter.ClearBeforeFill = true;
            // 
            // lblcatID
            // 
            this.lblcatID.AutoSize = true;
            this.lblcatID.Location = new System.Drawing.Point(195, 9);
            this.lblcatID.Name = "lblcatID";
            this.lblcatID.Size = new System.Drawing.Size(35, 13);
            this.lblcatID.TabIndex = 45;
            this.lblcatID.Text = "label4";
            this.lblcatID.Visible = false;
            // 
            // lblnivelID
            // 
            this.lblnivelID.AutoSize = true;
            this.lblnivelID.Location = new System.Drawing.Point(236, 9);
            this.lblnivelID.Name = "lblnivelID";
            this.lblnivelID.Size = new System.Drawing.Size(35, 13);
            this.lblnivelID.TabIndex = 46;
            this.lblnivelID.Text = "label4";
            this.lblnivelID.Visible = false;
            // 
            // ModificarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 559);
            this.Controls.Add(this.lblnivelID);
            this.Controls.Add(this.lblcatID);
            this.Controls.Add(this.cbNivel);
            this.Controls.Add(label3);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(label2);
            this.Controls.Add(this.rbHombre);
            this.Controls.Add(this.rbMujer);
            this.Controls.Add(this.pbFoto);
            this.Controls.Add(this.txtNotas);
            this.Controls.Add(this.lblNotas);
            this.Controls.Add(label1);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnSalud);
            this.Controls.Add(this.btnHabilitar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblID);
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
            this.Controls.Add(this.dtpNacimiento);
            this.Controls.Add(socioFechaIngLabel);
            this.Controls.Add(this.dtpIngreso);
            this.Controls.Add(socioFechaUltPagoLabel);
            this.Controls.Add(this.dtpPago);
            this.Controls.Add(catIdLabel);
            this.Name = "ModificarUsuario";
            this.Text = "Modificar Socio";
            this.Load += new System.EventHandler(this.ModificarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.club_VistalbaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.socioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Club_VistalbaDataSet club_VistalbaDataSet;
        private System.Windows.Forms.BindingSource socioBindingSource;
        private Club_VistalbaDataSetTableAdapters.SocioTableAdapter socioTableAdapter;
        private Club_VistalbaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DateTimePicker dtpNacimiento;
        private System.Windows.Forms.DateTimePicker dtpIngreso;
        private System.Windows.Forms.DateTimePicker dtpPago;
        private Club_VistalbaDataSetTableAdapters.GrupoTableAdapter grupoTableAdapter;
        private System.Windows.Forms.BindingSource grupoBindingSource;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.TextBox txtDNI;
        public System.Windows.Forms.TextBox txtDireccion;
        public System.Windows.Forms.TextBox txtMail;
        public System.Windows.Forms.TextBox txtTelefono;
        public System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Button btnHabilitar;
        private System.Windows.Forms.Button btnSalud;
        private System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblNotas;
        public System.Windows.Forms.TextBox txtNotas;
        public System.Windows.Forms.PictureBox pbFoto;
        public System.Windows.Forms.RadioButton rbHombre;
        public System.Windows.Forms.RadioButton rbMujer;
        public System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.CheckBox cbEstado;
        public System.Windows.Forms.ComboBox cbNivel;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private Club_VistalbaDataSetTableAdapters.CategoriaTableAdapter categoriaTableAdapter;
        public System.Windows.Forms.Label lblcatID;
        public System.Windows.Forms.Label lblnivelID;
    }
}