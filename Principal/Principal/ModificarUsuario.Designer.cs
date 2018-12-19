namespace Principal
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
            System.Windows.Forms.Label grupoIdLabel;
            System.Windows.Forms.Label catIdLabel;
            System.Windows.Forms.Label grupoApellidoLabel;
            this.club_VistalbaDataSet = new Principal.Club_VistalbaDataSet();
            this.socioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.socioTableAdapter = new Principal.Club_VistalbaDataSetTableAdapters.SocioTableAdapter();
            this.tableAdapterManager = new Principal.Club_VistalbaDataSetTableAdapters.TableAdapterManager();
            this.socioNombreTextBox = new System.Windows.Forms.TextBox();
            this.socioDNITextBox = new System.Windows.Forms.TextBox();
            this.socioDireccionTextBox = new System.Windows.Forms.TextBox();
            this.socioMailTextBox = new System.Windows.Forms.TextBox();
            this.socioTelefonoTextBox = new System.Windows.Forms.TextBox();
            this.socioCelularTextBox = new System.Windows.Forms.TextBox();
            this.socioFechaNacDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.socioFechaIngDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.socioFechaUltPagoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.grupoIdTextBox = new System.Windows.Forms.TextBox();
            this.catIdTextBox = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.grupoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grupoTableAdapter = new Principal.Club_VistalbaDataSetTableAdapters.GrupoTableAdapter();
            this.txtGrupo = new System.Windows.Forms.TextBox();
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
            grupoIdLabel = new System.Windows.Forms.Label();
            catIdLabel = new System.Windows.Forms.Label();
            grupoApellidoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.club_VistalbaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.socioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.tableAdapterManager.ProfesionalTableAdapter = null;
            this.tableAdapterManager.SaludTableAdapter = null;
            this.tableAdapterManager.SocioTableAdapter = this.socioTableAdapter;
            this.tableAdapterManager.UpdateOrder = Principal.Club_VistalbaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            // socioNombreTextBox
            // 
            this.socioNombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.socioBindingSource, "socioNombre", true));
            this.socioNombreTextBox.Location = new System.Drawing.Point(130, 32);
            this.socioNombreTextBox.Name = "socioNombreTextBox";
            this.socioNombreTextBox.Size = new System.Drawing.Size(200, 20);
            this.socioNombreTextBox.TabIndex = 4;
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
            // socioDNITextBox
            // 
            this.socioDNITextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.socioBindingSource, "socioDNI", true));
            this.socioDNITextBox.Location = new System.Drawing.Point(130, 58);
            this.socioDNITextBox.Name = "socioDNITextBox";
            this.socioDNITextBox.Size = new System.Drawing.Size(200, 20);
            this.socioDNITextBox.TabIndex = 6;
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
            // socioDireccionTextBox
            // 
            this.socioDireccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.socioBindingSource, "socioDireccion", true));
            this.socioDireccionTextBox.Location = new System.Drawing.Point(130, 84);
            this.socioDireccionTextBox.Name = "socioDireccionTextBox";
            this.socioDireccionTextBox.Size = new System.Drawing.Size(200, 20);
            this.socioDireccionTextBox.TabIndex = 8;
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
            // socioMailTextBox
            // 
            this.socioMailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.socioBindingSource, "socioMail", true));
            this.socioMailTextBox.Location = new System.Drawing.Point(130, 110);
            this.socioMailTextBox.Name = "socioMailTextBox";
            this.socioMailTextBox.Size = new System.Drawing.Size(200, 20);
            this.socioMailTextBox.TabIndex = 10;
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
            // socioTelefonoTextBox
            // 
            this.socioTelefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.socioBindingSource, "socioTelefono", true));
            this.socioTelefonoTextBox.Location = new System.Drawing.Point(130, 136);
            this.socioTelefonoTextBox.Name = "socioTelefonoTextBox";
            this.socioTelefonoTextBox.Size = new System.Drawing.Size(200, 20);
            this.socioTelefonoTextBox.TabIndex = 12;
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
            // socioCelularTextBox
            // 
            this.socioCelularTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.socioBindingSource, "socioCelular", true));
            this.socioCelularTextBox.Location = new System.Drawing.Point(130, 162);
            this.socioCelularTextBox.Name = "socioCelularTextBox";
            this.socioCelularTextBox.Size = new System.Drawing.Size(200, 20);
            this.socioCelularTextBox.TabIndex = 14;
            // 
            // socioFechaNacLabel
            // 
            socioFechaNacLabel.AutoSize = true;
            socioFechaNacLabel.Location = new System.Drawing.Point(12, 192);
            socioFechaNacLabel.Name = "socioFechaNacLabel";
            socioFechaNacLabel.Size = new System.Drawing.Size(63, 13);
            socioFechaNacLabel.TabIndex = 15;
            socioFechaNacLabel.Text = "Fecha Nac:";
            // 
            // socioFechaNacDateTimePicker
            // 
            this.socioFechaNacDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.socioBindingSource, "socioFechaNac", true));
            this.socioFechaNacDateTimePicker.Location = new System.Drawing.Point(130, 188);
            this.socioFechaNacDateTimePicker.Name = "socioFechaNacDateTimePicker";
            this.socioFechaNacDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.socioFechaNacDateTimePicker.TabIndex = 16;
            // 
            // socioFechaIngLabel
            // 
            socioFechaIngLabel.AutoSize = true;
            socioFechaIngLabel.Location = new System.Drawing.Point(12, 218);
            socioFechaIngLabel.Name = "socioFechaIngLabel";
            socioFechaIngLabel.Size = new System.Drawing.Size(58, 13);
            socioFechaIngLabel.TabIndex = 17;
            socioFechaIngLabel.Text = "Fecha Ing:";
            // 
            // socioFechaIngDateTimePicker
            // 
            this.socioFechaIngDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.socioBindingSource, "socioFechaIng", true));
            this.socioFechaIngDateTimePicker.Location = new System.Drawing.Point(130, 214);
            this.socioFechaIngDateTimePicker.Name = "socioFechaIngDateTimePicker";
            this.socioFechaIngDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.socioFechaIngDateTimePicker.TabIndex = 18;
            // 
            // socioFechaUltPagoLabel
            // 
            socioFechaUltPagoLabel.AutoSize = true;
            socioFechaUltPagoLabel.Location = new System.Drawing.Point(12, 244);
            socioFechaUltPagoLabel.Name = "socioFechaUltPagoLabel";
            socioFechaUltPagoLabel.Size = new System.Drawing.Size(84, 13);
            socioFechaUltPagoLabel.TabIndex = 19;
            socioFechaUltPagoLabel.Text = "Fecha Ult Pago:";
            // 
            // socioFechaUltPagoDateTimePicker
            // 
            this.socioFechaUltPagoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.socioBindingSource, "socioFechaUltPago", true));
            this.socioFechaUltPagoDateTimePicker.Location = new System.Drawing.Point(130, 240);
            this.socioFechaUltPagoDateTimePicker.Name = "socioFechaUltPagoDateTimePicker";
            this.socioFechaUltPagoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.socioFechaUltPagoDateTimePicker.TabIndex = 20;
            // 
            // grupoIdLabel
            // 
            grupoIdLabel.AutoSize = true;
            grupoIdLabel.Location = new System.Drawing.Point(12, 269);
            grupoIdLabel.Name = "grupoIdLabel";
            grupoIdLabel.Size = new System.Drawing.Size(19, 13);
            grupoIdLabel.TabIndex = 21;
            grupoIdLabel.Text = "Id:";
            // 
            // grupoIdTextBox
            // 
            this.grupoIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.socioBindingSource, "grupoId", true));
            this.grupoIdTextBox.Location = new System.Drawing.Point(130, 266);
            this.grupoIdTextBox.Name = "grupoIdTextBox";
            this.grupoIdTextBox.Size = new System.Drawing.Size(200, 20);
            this.grupoIdTextBox.TabIndex = 22;
            // 
            // catIdLabel
            // 
            catIdLabel.AutoSize = true;
            catIdLabel.Location = new System.Drawing.Point(12, 321);
            catIdLabel.Name = "catIdLabel";
            catIdLabel.Size = new System.Drawing.Size(55, 13);
            catIdLabel.TabIndex = 23;
            catIdLabel.Text = "Categoria:";
            catIdLabel.Visible = false;
            // 
            // catIdTextBox
            // 
            this.catIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.socioBindingSource, "catId", true));
            this.catIdTextBox.Location = new System.Drawing.Point(130, 318);
            this.catIdTextBox.Name = "catIdTextBox";
            this.catIdTextBox.Size = new System.Drawing.Size(200, 20);
            this.catIdTextBox.TabIndex = 24;
            this.catIdTextBox.Visible = false;
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
            // grupoTableAdapter
            // 
            this.grupoTableAdapter.ClearBeforeFill = true;
            // 
            // grupoApellidoLabel
            // 
            grupoApellidoLabel.AutoSize = true;
            grupoApellidoLabel.Location = new System.Drawing.Point(12, 295);
            grupoApellidoLabel.Name = "grupoApellidoLabel";
            grupoApellidoLabel.Size = new System.Drawing.Size(39, 13);
            grupoApellidoLabel.TabIndex = 25;
            grupoApellidoLabel.Text = "Grupo:";
            grupoApellidoLabel.Visible = false;
            // 
            // txtGrupo
            // 
            this.txtGrupo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.grupoBindingSource, "grupoApellido", true));
            this.txtGrupo.Location = new System.Drawing.Point(130, 292);
            this.txtGrupo.Name = "txtGrupo";
            this.txtGrupo.Size = new System.Drawing.Size(200, 20);
            this.txtGrupo.TabIndex = 26;
            this.txtGrupo.Visible = false;
            // 
            // ModificarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 362);
            this.Controls.Add(grupoApellidoLabel);
            this.Controls.Add(this.txtGrupo);
            this.Controls.Add(this.lblID);
            this.Controls.Add(socioIDLabel);
            this.Controls.Add(socioNombreLabel);
            this.Controls.Add(this.socioNombreTextBox);
            this.Controls.Add(socioDNILabel);
            this.Controls.Add(this.socioDNITextBox);
            this.Controls.Add(socioDireccionLabel);
            this.Controls.Add(this.socioDireccionTextBox);
            this.Controls.Add(socioMailLabel);
            this.Controls.Add(this.socioMailTextBox);
            this.Controls.Add(socioTelefonoLabel);
            this.Controls.Add(this.socioTelefonoTextBox);
            this.Controls.Add(socioCelularLabel);
            this.Controls.Add(this.socioCelularTextBox);
            this.Controls.Add(socioFechaNacLabel);
            this.Controls.Add(this.socioFechaNacDateTimePicker);
            this.Controls.Add(socioFechaIngLabel);
            this.Controls.Add(this.socioFechaIngDateTimePicker);
            this.Controls.Add(socioFechaUltPagoLabel);
            this.Controls.Add(this.socioFechaUltPagoDateTimePicker);
            this.Controls.Add(grupoIdLabel);
            this.Controls.Add(this.grupoIdTextBox);
            this.Controls.Add(catIdLabel);
            this.Controls.Add(this.catIdTextBox);
            this.Name = "ModificarUsuario";
            this.Text = "ModificarUsuario";
            this.Load += new System.EventHandler(this.ModificarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.club_VistalbaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.socioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Club_VistalbaDataSet club_VistalbaDataSet;
        private System.Windows.Forms.BindingSource socioBindingSource;
        private Club_VistalbaDataSetTableAdapters.SocioTableAdapter socioTableAdapter;
        private Club_VistalbaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox socioNombreTextBox;
        private System.Windows.Forms.TextBox socioDNITextBox;
        private System.Windows.Forms.TextBox socioDireccionTextBox;
        private System.Windows.Forms.TextBox socioMailTextBox;
        private System.Windows.Forms.TextBox socioTelefonoTextBox;
        private System.Windows.Forms.TextBox socioCelularTextBox;
        private System.Windows.Forms.DateTimePicker socioFechaNacDateTimePicker;
        private System.Windows.Forms.DateTimePicker socioFechaIngDateTimePicker;
        private System.Windows.Forms.DateTimePicker socioFechaUltPagoDateTimePicker;
        private System.Windows.Forms.TextBox grupoIdTextBox;
        private System.Windows.Forms.TextBox catIdTextBox;
        private Club_VistalbaDataSetTableAdapters.GrupoTableAdapter grupoTableAdapter;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.BindingSource grupoBindingSource;
        private System.Windows.Forms.TextBox txtGrupo;
    }
}