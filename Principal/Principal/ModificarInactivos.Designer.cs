namespace Principal
{
    partial class ModificarInactivos
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
            System.Windows.Forms.Label socioGeneroLabel;
            System.Windows.Forms.Label socioCategoriaLabel;
            System.Windows.Forms.Label socioNivelLabel;
            System.Windows.Forms.Label socioEstadoLabel;
            this.club_VistalbaDataSet = new Principal.Club_VistalbaDataSet();
            this.socioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.socioTableAdapter = new Principal.Club_VistalbaDataSetTableAdapters.SocioTableAdapter();
            this.tableAdapterManager = new Principal.Club_VistalbaDataSetTableAdapters.TableAdapterManager();
            this.lblID = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.socioFechaNacDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.socioFechaIngDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.socioFechaUltPagoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.catIdTextBox = new System.Windows.Forms.TextBox();
            this.socioCategoriaTextBox = new System.Windows.Forms.TextBox();
            this.socioNivelTextBox = new System.Windows.Forms.TextBox();
            this.cbEstado = new System.Windows.Forms.CheckBox();
            this.rbHombre = new System.Windows.Forms.RadioButton();
            this.rbMujer = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            socioGeneroLabel = new System.Windows.Forms.Label();
            socioCategoriaLabel = new System.Windows.Forms.Label();
            socioNivelLabel = new System.Windows.Forms.Label();
            socioEstadoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.club_VistalbaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.socioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // socioIDLabel
            // 
            socioIDLabel.AutoSize = true;
            socioIDLabel.Location = new System.Drawing.Point(13, 27);
            socioIDLabel.Name = "socioIDLabel";
            socioIDLabel.Size = new System.Drawing.Size(21, 13);
            socioIDLabel.TabIndex = 1;
            socioIDLabel.Text = "ID:";
            // 
            // socioNombreLabel
            // 
            socioNombreLabel.AutoSize = true;
            socioNombreLabel.Location = new System.Drawing.Point(13, 56);
            socioNombreLabel.Name = "socioNombreLabel";
            socioNombreLabel.Size = new System.Drawing.Size(47, 13);
            socioNombreLabel.TabIndex = 3;
            socioNombreLabel.Text = "Nombre:";
            // 
            // socioDNILabel
            // 
            socioDNILabel.AutoSize = true;
            socioDNILabel.Location = new System.Drawing.Point(13, 82);
            socioDNILabel.Name = "socioDNILabel";
            socioDNILabel.Size = new System.Drawing.Size(29, 13);
            socioDNILabel.TabIndex = 5;
            socioDNILabel.Text = "DNI:";
            // 
            // socioDireccionLabel
            // 
            socioDireccionLabel.AutoSize = true;
            socioDireccionLabel.Location = new System.Drawing.Point(13, 108);
            socioDireccionLabel.Name = "socioDireccionLabel";
            socioDireccionLabel.Size = new System.Drawing.Size(55, 13);
            socioDireccionLabel.TabIndex = 7;
            socioDireccionLabel.Text = "Direccion:";
            // 
            // socioMailLabel
            // 
            socioMailLabel.AutoSize = true;
            socioMailLabel.Location = new System.Drawing.Point(13, 134);
            socioMailLabel.Name = "socioMailLabel";
            socioMailLabel.Size = new System.Drawing.Size(39, 13);
            socioMailLabel.TabIndex = 9;
            socioMailLabel.Text = "E-Mail:";
            // 
            // socioTelefonoLabel
            // 
            socioTelefonoLabel.AutoSize = true;
            socioTelefonoLabel.Location = new System.Drawing.Point(13, 160);
            socioTelefonoLabel.Name = "socioTelefonoLabel";
            socioTelefonoLabel.Size = new System.Drawing.Size(52, 13);
            socioTelefonoLabel.TabIndex = 11;
            socioTelefonoLabel.Text = "Teléfono:";
            // 
            // socioCelularLabel
            // 
            socioCelularLabel.AutoSize = true;
            socioCelularLabel.Location = new System.Drawing.Point(13, 186);
            socioCelularLabel.Name = "socioCelularLabel";
            socioCelularLabel.Size = new System.Drawing.Size(42, 13);
            socioCelularLabel.TabIndex = 13;
            socioCelularLabel.Text = "Celular:";
            // 
            // socioFechaNacLabel
            // 
            socioFechaNacLabel.AutoSize = true;
            socioFechaNacLabel.Location = new System.Drawing.Point(10, 239);
            socioFechaNacLabel.Name = "socioFechaNacLabel";
            socioFechaNacLabel.Size = new System.Drawing.Size(96, 13);
            socioFechaNacLabel.TabIndex = 15;
            socioFechaNacLabel.Text = "Fecha Nacimiento:";
            // 
            // socioFechaIngLabel
            // 
            socioFechaIngLabel.AutoSize = true;
            socioFechaIngLabel.Location = new System.Drawing.Point(10, 265);
            socioFechaIngLabel.Name = "socioFechaIngLabel";
            socioFechaIngLabel.Size = new System.Drawing.Size(78, 13);
            socioFechaIngLabel.TabIndex = 17;
            socioFechaIngLabel.Text = "Fecha Ingreso:";
            // 
            // socioFechaUltPagoLabel
            // 
            socioFechaUltPagoLabel.AutoSize = true;
            socioFechaUltPagoLabel.Location = new System.Drawing.Point(10, 291);
            socioFechaUltPagoLabel.Name = "socioFechaUltPagoLabel";
            socioFechaUltPagoLabel.Size = new System.Drawing.Size(100, 13);
            socioFechaUltPagoLabel.TabIndex = 19;
            socioFechaUltPagoLabel.Text = "Fecha Último Pago:";
            // 
            // catIdLabel
            // 
            catIdLabel.AutoSize = true;
            catIdLabel.Location = new System.Drawing.Point(13, 316);
            catIdLabel.Name = "catIdLabel";
            catIdLabel.Size = new System.Drawing.Size(37, 13);
            catIdLabel.TabIndex = 23;
            catIdLabel.Text = "cat Id:";
            // 
            // socioGeneroLabel
            // 
            socioGeneroLabel.AutoSize = true;
            socioGeneroLabel.Location = new System.Drawing.Point(13, 214);
            socioGeneroLabel.Name = "socioGeneroLabel";
            socioGeneroLabel.Size = new System.Drawing.Size(45, 13);
            socioGeneroLabel.TabIndex = 25;
            socioGeneroLabel.Text = "Genero:";
            // 
            // socioCategoriaLabel
            // 
            socioCategoriaLabel.AutoSize = true;
            socioCategoriaLabel.Location = new System.Drawing.Point(10, 366);
            socioCategoriaLabel.Name = "socioCategoriaLabel";
            socioCategoriaLabel.Size = new System.Drawing.Size(83, 13);
            socioCategoriaLabel.TabIndex = 31;
            socioCategoriaLabel.Text = "socio Categoria:";
            // 
            // socioNivelLabel
            // 
            socioNivelLabel.AutoSize = true;
            socioNivelLabel.Location = new System.Drawing.Point(10, 392);
            socioNivelLabel.Name = "socioNivelLabel";
            socioNivelLabel.Size = new System.Drawing.Size(62, 13);
            socioNivelLabel.TabIndex = 33;
            socioNivelLabel.Text = "socio Nivel:";
            // 
            // socioEstadoLabel
            // 
            socioEstadoLabel.AutoSize = true;
            socioEstadoLabel.Location = new System.Drawing.Point(10, 420);
            socioEstadoLabel.Name = "socioEstadoLabel";
            socioEstadoLabel.Size = new System.Drawing.Size(71, 13);
            socioEstadoLabel.TabIndex = 35;
            socioEstadoLabel.Text = "socio Estado:";
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
            this.tableAdapterManager.GrupoTableAdapter = null;
            this.tableAdapterManager.MensualTableAdapter = null;
            this.tableAdapterManager.ProfesionalTableAdapter = null;
            this.tableAdapterManager.SaludTableAdapter = null;
            this.tableAdapterManager.SocioTableAdapter = this.socioTableAdapter;
            this.tableAdapterManager.UpdateOrder = Principal.Club_VistalbaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lblID
            // 
            this.lblID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.socioBindingSource, "socioID", true));
            this.lblID.Location = new System.Drawing.Point(131, 27);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(200, 23);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "ID Socio";
            // 
            // txtNombre
            // 
            this.txtNombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.socioBindingSource, "socioNombre", true));
            this.txtNombre.Location = new System.Drawing.Point(131, 53);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(280, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtDNI
            // 
            this.txtDNI.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.socioBindingSource, "socioDNI", true));
            this.txtDNI.Location = new System.Drawing.Point(131, 79);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(280, 20);
            this.txtDNI.TabIndex = 6;
            // 
            // txtDireccion
            // 
            this.txtDireccion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.socioBindingSource, "socioDireccion", true));
            this.txtDireccion.Location = new System.Drawing.Point(131, 105);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(280, 20);
            this.txtDireccion.TabIndex = 8;
            // 
            // txtMail
            // 
            this.txtMail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.socioBindingSource, "socioMail", true));
            this.txtMail.Location = new System.Drawing.Point(131, 131);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(280, 20);
            this.txtMail.TabIndex = 10;
            // 
            // txtTelefono
            // 
            this.txtTelefono.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.socioBindingSource, "socioTelefono", true));
            this.txtTelefono.Location = new System.Drawing.Point(131, 157);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(280, 20);
            this.txtTelefono.TabIndex = 12;
            // 
            // txtCelular
            // 
            this.txtCelular.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.socioBindingSource, "socioCelular", true));
            this.txtCelular.Location = new System.Drawing.Point(131, 183);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(280, 20);
            this.txtCelular.TabIndex = 14;
            // 
            // socioFechaNacDateTimePicker
            // 
            this.socioFechaNacDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.socioBindingSource, "socioFechaNac", true));
            this.socioFechaNacDateTimePicker.Location = new System.Drawing.Point(128, 235);
            this.socioFechaNacDateTimePicker.Name = "socioFechaNacDateTimePicker";
            this.socioFechaNacDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.socioFechaNacDateTimePicker.TabIndex = 16;
            // 
            // socioFechaIngDateTimePicker
            // 
            this.socioFechaIngDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.socioBindingSource, "socioFechaIng", true));
            this.socioFechaIngDateTimePicker.Enabled = false;
            this.socioFechaIngDateTimePicker.Location = new System.Drawing.Point(128, 261);
            this.socioFechaIngDateTimePicker.Name = "socioFechaIngDateTimePicker";
            this.socioFechaIngDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.socioFechaIngDateTimePicker.TabIndex = 18;
            // 
            // socioFechaUltPagoDateTimePicker
            // 
            this.socioFechaUltPagoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.socioBindingSource, "socioFechaUltPago", true));
            this.socioFechaUltPagoDateTimePicker.Location = new System.Drawing.Point(128, 287);
            this.socioFechaUltPagoDateTimePicker.Name = "socioFechaUltPagoDateTimePicker";
            this.socioFechaUltPagoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.socioFechaUltPagoDateTimePicker.TabIndex = 20;
            // 
            // catIdTextBox
            // 
            this.catIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.socioBindingSource, "catId", true));
            this.catIdTextBox.Location = new System.Drawing.Point(131, 313);
            this.catIdTextBox.Name = "catIdTextBox";
            this.catIdTextBox.Size = new System.Drawing.Size(200, 20);
            this.catIdTextBox.TabIndex = 24;
            // 
            // socioCategoriaTextBox
            // 
            this.socioCategoriaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.socioBindingSource, "socioCategoria", true));
            this.socioCategoriaTextBox.Location = new System.Drawing.Point(128, 363);
            this.socioCategoriaTextBox.Name = "socioCategoriaTextBox";
            this.socioCategoriaTextBox.Size = new System.Drawing.Size(200, 20);
            this.socioCategoriaTextBox.TabIndex = 32;
            // 
            // socioNivelTextBox
            // 
            this.socioNivelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.socioBindingSource, "socioNivel", true));
            this.socioNivelTextBox.Location = new System.Drawing.Point(128, 389);
            this.socioNivelTextBox.Name = "socioNivelTextBox";
            this.socioNivelTextBox.Size = new System.Drawing.Size(200, 20);
            this.socioNivelTextBox.TabIndex = 34;
            // 
            // cbEstado
            // 
            this.cbEstado.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.socioBindingSource, "socioEstado", true));
            this.cbEstado.Location = new System.Drawing.Point(128, 415);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(200, 24);
            this.cbEstado.TabIndex = 36;
            this.cbEstado.Text = "Inactivo";
            this.cbEstado.UseVisualStyleBackColor = true;
            this.cbEstado.CheckedChanged += new System.EventHandler(this.cbEstado_CheckedChanged);
            // 
            // rbHombre
            // 
            this.rbHombre.AutoSize = true;
            this.rbHombre.Location = new System.Drawing.Point(131, 212);
            this.rbHombre.Name = "rbHombre";
            this.rbHombre.Size = new System.Drawing.Size(62, 17);
            this.rbHombre.TabIndex = 37;
            this.rbHombre.TabStop = true;
            this.rbHombre.Text = "Hombre";
            this.rbHombre.UseVisualStyleBackColor = true;
            // 
            // rbMujer
            // 
            this.rbMujer.AutoSize = true;
            this.rbMujer.Location = new System.Drawing.Point(211, 212);
            this.rbMujer.Name = "rbMujer";
            this.rbMujer.Size = new System.Drawing.Size(51, 17);
            this.rbMujer.TabIndex = 38;
            this.rbMujer.TabStop = true;
            this.rbMujer.Text = "Mujer";
            this.rbMujer.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 445);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 38);
            this.button1.TabIndex = 39;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(253, 445);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 38);
            this.button2.TabIndex = 40;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ModificarInactivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 499);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rbMujer);
            this.Controls.Add(this.rbHombre);
            this.Controls.Add(socioIDLabel);
            this.Controls.Add(this.lblID);
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
            this.Controls.Add(socioFechaIngLabel);
            this.Controls.Add(this.socioFechaIngDateTimePicker);
            this.Controls.Add(socioFechaUltPagoLabel);
            this.Controls.Add(this.socioFechaUltPagoDateTimePicker);
            this.Controls.Add(catIdLabel);
            this.Controls.Add(this.catIdTextBox);
            this.Controls.Add(socioGeneroLabel);
            this.Controls.Add(socioCategoriaLabel);
            this.Controls.Add(this.socioCategoriaTextBox);
            this.Controls.Add(socioNivelLabel);
            this.Controls.Add(this.socioNivelTextBox);
            this.Controls.Add(socioEstadoLabel);
            this.Controls.Add(this.cbEstado);
            this.Name = "ModificarInactivos";
            this.Text = "ModificarInactivos";
            this.Load += new System.EventHandler(this.ModificarInactivos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.club_VistalbaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.socioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Club_VistalbaDataSet club_VistalbaDataSet;
        private System.Windows.Forms.BindingSource socioBindingSource;
        private Club_VistalbaDataSetTableAdapters.SocioTableAdapter socioTableAdapter;
        private Club_VistalbaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.DateTimePicker socioFechaNacDateTimePicker;
        private System.Windows.Forms.DateTimePicker socioFechaIngDateTimePicker;
        private System.Windows.Forms.DateTimePicker socioFechaUltPagoDateTimePicker;
        private System.Windows.Forms.TextBox catIdTextBox;
        private System.Windows.Forms.TextBox socioCategoriaTextBox;
        private System.Windows.Forms.TextBox socioNivelTextBox;
        private System.Windows.Forms.CheckBox cbEstado;
        private System.Windows.Forms.RadioButton rbHombre;
        private System.Windows.Forms.RadioButton rbMujer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}