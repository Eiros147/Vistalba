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
            System.Windows.Forms.Label grupoIdLabel;
            System.Windows.Forms.Label catIdLabel;
            System.Windows.Forms.Label socioGeneroLabel;
            System.Windows.Forms.Label socioCategoriaLabel;
            System.Windows.Forms.Label socioNivelLabel;
            System.Windows.Forms.Label socioEstadoLabel;
            this.club_VistalbaDataSet = new Principal.Club_VistalbaDataSet();
            this.socioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.socioTableAdapter = new Principal.Club_VistalbaDataSetTableAdapters.SocioTableAdapter();
            this.tableAdapterManager = new Principal.Club_VistalbaDataSetTableAdapters.TableAdapterManager();
            this.socioIDLabel1 = new System.Windows.Forms.Label();
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
            this.socioGeneroCheckBox = new System.Windows.Forms.CheckBox();
            this.socioCategoriaTextBox = new System.Windows.Forms.TextBox();
            this.socioNivelTextBox = new System.Windows.Forms.TextBox();
            this.socioEstadoCheckBox = new System.Windows.Forms.CheckBox();
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
            socioGeneroLabel = new System.Windows.Forms.Label();
            socioCategoriaLabel = new System.Windows.Forms.Label();
            socioNivelLabel = new System.Windows.Forms.Label();
            socioEstadoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.club_VistalbaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.socioBindingSource)).BeginInit();
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
            this.tableAdapterManager.GrupoTableAdapter = null;
            this.tableAdapterManager.MensualTableAdapter = null;
            this.tableAdapterManager.ProfesionalTableAdapter = null;
            this.tableAdapterManager.SaludTableAdapter = null;
            this.tableAdapterManager.SocioTableAdapter = this.socioTableAdapter;
            this.tableAdapterManager.UpdateOrder = Principal.Club_VistalbaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            // socioIDLabel1
            // 
            this.socioIDLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.socioBindingSource, "socioID", true));
            this.socioIDLabel1.Location = new System.Drawing.Point(131, 27);
            this.socioIDLabel1.Name = "socioIDLabel1";
            this.socioIDLabel1.Size = new System.Drawing.Size(200, 23);
            this.socioIDLabel1.TabIndex = 2;
            this.socioIDLabel1.Text = "label1";
            // 
            // socioNombreLabel
            // 
            socioNombreLabel.AutoSize = true;
            socioNombreLabel.Location = new System.Drawing.Point(13, 56);
            socioNombreLabel.Name = "socioNombreLabel";
            socioNombreLabel.Size = new System.Drawing.Size(75, 13);
            socioNombreLabel.TabIndex = 3;
            socioNombreLabel.Text = "socio Nombre:";
            // 
            // socioNombreTextBox
            // 
            this.socioNombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.socioBindingSource, "socioNombre", true));
            this.socioNombreTextBox.Location = new System.Drawing.Point(131, 53);
            this.socioNombreTextBox.Name = "socioNombreTextBox";
            this.socioNombreTextBox.Size = new System.Drawing.Size(200, 20);
            this.socioNombreTextBox.TabIndex = 4;
            // 
            // socioDNILabel
            // 
            socioDNILabel.AutoSize = true;
            socioDNILabel.Location = new System.Drawing.Point(13, 82);
            socioDNILabel.Name = "socioDNILabel";
            socioDNILabel.Size = new System.Drawing.Size(57, 13);
            socioDNILabel.TabIndex = 5;
            socioDNILabel.Text = "socio DNI:";
            // 
            // socioDNITextBox
            // 
            this.socioDNITextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.socioBindingSource, "socioDNI", true));
            this.socioDNITextBox.Location = new System.Drawing.Point(131, 79);
            this.socioDNITextBox.Name = "socioDNITextBox";
            this.socioDNITextBox.Size = new System.Drawing.Size(200, 20);
            this.socioDNITextBox.TabIndex = 6;
            // 
            // socioDireccionLabel
            // 
            socioDireccionLabel.AutoSize = true;
            socioDireccionLabel.Location = new System.Drawing.Point(13, 108);
            socioDireccionLabel.Name = "socioDireccionLabel";
            socioDireccionLabel.Size = new System.Drawing.Size(83, 13);
            socioDireccionLabel.TabIndex = 7;
            socioDireccionLabel.Text = "socio Direccion:";
            // 
            // socioDireccionTextBox
            // 
            this.socioDireccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.socioBindingSource, "socioDireccion", true));
            this.socioDireccionTextBox.Location = new System.Drawing.Point(131, 105);
            this.socioDireccionTextBox.Name = "socioDireccionTextBox";
            this.socioDireccionTextBox.Size = new System.Drawing.Size(200, 20);
            this.socioDireccionTextBox.TabIndex = 8;
            // 
            // socioMailLabel
            // 
            socioMailLabel.AutoSize = true;
            socioMailLabel.Location = new System.Drawing.Point(13, 134);
            socioMailLabel.Name = "socioMailLabel";
            socioMailLabel.Size = new System.Drawing.Size(57, 13);
            socioMailLabel.TabIndex = 9;
            socioMailLabel.Text = "socio Mail:";
            // 
            // socioMailTextBox
            // 
            this.socioMailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.socioBindingSource, "socioMail", true));
            this.socioMailTextBox.Location = new System.Drawing.Point(131, 131);
            this.socioMailTextBox.Name = "socioMailTextBox";
            this.socioMailTextBox.Size = new System.Drawing.Size(200, 20);
            this.socioMailTextBox.TabIndex = 10;
            // 
            // socioTelefonoLabel
            // 
            socioTelefonoLabel.AutoSize = true;
            socioTelefonoLabel.Location = new System.Drawing.Point(13, 160);
            socioTelefonoLabel.Name = "socioTelefonoLabel";
            socioTelefonoLabel.Size = new System.Drawing.Size(80, 13);
            socioTelefonoLabel.TabIndex = 11;
            socioTelefonoLabel.Text = "socio Telefono:";
            // 
            // socioTelefonoTextBox
            // 
            this.socioTelefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.socioBindingSource, "socioTelefono", true));
            this.socioTelefonoTextBox.Location = new System.Drawing.Point(131, 157);
            this.socioTelefonoTextBox.Name = "socioTelefonoTextBox";
            this.socioTelefonoTextBox.Size = new System.Drawing.Size(200, 20);
            this.socioTelefonoTextBox.TabIndex = 12;
            // 
            // socioCelularLabel
            // 
            socioCelularLabel.AutoSize = true;
            socioCelularLabel.Location = new System.Drawing.Point(13, 186);
            socioCelularLabel.Name = "socioCelularLabel";
            socioCelularLabel.Size = new System.Drawing.Size(70, 13);
            socioCelularLabel.TabIndex = 13;
            socioCelularLabel.Text = "socio Celular:";
            // 
            // socioCelularTextBox
            // 
            this.socioCelularTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.socioBindingSource, "socioCelular", true));
            this.socioCelularTextBox.Location = new System.Drawing.Point(131, 183);
            this.socioCelularTextBox.Name = "socioCelularTextBox";
            this.socioCelularTextBox.Size = new System.Drawing.Size(200, 20);
            this.socioCelularTextBox.TabIndex = 14;
            // 
            // socioFechaNacLabel
            // 
            socioFechaNacLabel.AutoSize = true;
            socioFechaNacLabel.Location = new System.Drawing.Point(13, 213);
            socioFechaNacLabel.Name = "socioFechaNacLabel";
            socioFechaNacLabel.Size = new System.Drawing.Size(91, 13);
            socioFechaNacLabel.TabIndex = 15;
            socioFechaNacLabel.Text = "socio Fecha Nac:";
            // 
            // socioFechaNacDateTimePicker
            // 
            this.socioFechaNacDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.socioBindingSource, "socioFechaNac", true));
            this.socioFechaNacDateTimePicker.Location = new System.Drawing.Point(131, 209);
            this.socioFechaNacDateTimePicker.Name = "socioFechaNacDateTimePicker";
            this.socioFechaNacDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.socioFechaNacDateTimePicker.TabIndex = 16;
            // 
            // socioFechaIngLabel
            // 
            socioFechaIngLabel.AutoSize = true;
            socioFechaIngLabel.Location = new System.Drawing.Point(13, 239);
            socioFechaIngLabel.Name = "socioFechaIngLabel";
            socioFechaIngLabel.Size = new System.Drawing.Size(86, 13);
            socioFechaIngLabel.TabIndex = 17;
            socioFechaIngLabel.Text = "socio Fecha Ing:";
            // 
            // socioFechaIngDateTimePicker
            // 
            this.socioFechaIngDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.socioBindingSource, "socioFechaIng", true));
            this.socioFechaIngDateTimePicker.Location = new System.Drawing.Point(131, 235);
            this.socioFechaIngDateTimePicker.Name = "socioFechaIngDateTimePicker";
            this.socioFechaIngDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.socioFechaIngDateTimePicker.TabIndex = 18;
            // 
            // socioFechaUltPagoLabel
            // 
            socioFechaUltPagoLabel.AutoSize = true;
            socioFechaUltPagoLabel.Location = new System.Drawing.Point(13, 265);
            socioFechaUltPagoLabel.Name = "socioFechaUltPagoLabel";
            socioFechaUltPagoLabel.Size = new System.Drawing.Size(112, 13);
            socioFechaUltPagoLabel.TabIndex = 19;
            socioFechaUltPagoLabel.Text = "socio Fecha Ult Pago:";
            // 
            // socioFechaUltPagoDateTimePicker
            // 
            this.socioFechaUltPagoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.socioBindingSource, "socioFechaUltPago", true));
            this.socioFechaUltPagoDateTimePicker.Location = new System.Drawing.Point(131, 261);
            this.socioFechaUltPagoDateTimePicker.Name = "socioFechaUltPagoDateTimePicker";
            this.socioFechaUltPagoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.socioFechaUltPagoDateTimePicker.TabIndex = 20;
            // 
            // grupoIdLabel
            // 
            grupoIdLabel.AutoSize = true;
            grupoIdLabel.Location = new System.Drawing.Point(13, 290);
            grupoIdLabel.Name = "grupoIdLabel";
            grupoIdLabel.Size = new System.Drawing.Size(49, 13);
            grupoIdLabel.TabIndex = 21;
            grupoIdLabel.Text = "grupo Id:";
            // 
            // grupoIdTextBox
            // 
            this.grupoIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.socioBindingSource, "grupoId", true));
            this.grupoIdTextBox.Location = new System.Drawing.Point(131, 287);
            this.grupoIdTextBox.Name = "grupoIdTextBox";
            this.grupoIdTextBox.Size = new System.Drawing.Size(200, 20);
            this.grupoIdTextBox.TabIndex = 22;
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
            // catIdTextBox
            // 
            this.catIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.socioBindingSource, "catId", true));
            this.catIdTextBox.Location = new System.Drawing.Point(131, 313);
            this.catIdTextBox.Name = "catIdTextBox";
            this.catIdTextBox.Size = new System.Drawing.Size(200, 20);
            this.catIdTextBox.TabIndex = 24;
            // 
            // socioGeneroLabel
            // 
            socioGeneroLabel.AutoSize = true;
            socioGeneroLabel.Location = new System.Drawing.Point(13, 344);
            socioGeneroLabel.Name = "socioGeneroLabel";
            socioGeneroLabel.Size = new System.Drawing.Size(73, 13);
            socioGeneroLabel.TabIndex = 25;
            socioGeneroLabel.Text = "socio Genero:";
            // 
            // socioGeneroCheckBox
            // 
            this.socioGeneroCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.socioBindingSource, "socioGenero", true));
            this.socioGeneroCheckBox.Location = new System.Drawing.Point(131, 339);
            this.socioGeneroCheckBox.Name = "socioGeneroCheckBox";
            this.socioGeneroCheckBox.Size = new System.Drawing.Size(200, 24);
            this.socioGeneroCheckBox.TabIndex = 26;
            this.socioGeneroCheckBox.Text = "checkBox1";
            this.socioGeneroCheckBox.UseVisualStyleBackColor = true;
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
            // socioCategoriaTextBox
            // 
            this.socioCategoriaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.socioBindingSource, "socioCategoria", true));
            this.socioCategoriaTextBox.Location = new System.Drawing.Point(128, 363);
            this.socioCategoriaTextBox.Name = "socioCategoriaTextBox";
            this.socioCategoriaTextBox.Size = new System.Drawing.Size(200, 20);
            this.socioCategoriaTextBox.TabIndex = 32;
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
            // socioNivelTextBox
            // 
            this.socioNivelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.socioBindingSource, "socioNivel", true));
            this.socioNivelTextBox.Location = new System.Drawing.Point(128, 389);
            this.socioNivelTextBox.Name = "socioNivelTextBox";
            this.socioNivelTextBox.Size = new System.Drawing.Size(200, 20);
            this.socioNivelTextBox.TabIndex = 34;
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
            // socioEstadoCheckBox
            // 
            this.socioEstadoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.socioBindingSource, "socioEstado", true));
            this.socioEstadoCheckBox.Location = new System.Drawing.Point(128, 415);
            this.socioEstadoCheckBox.Name = "socioEstadoCheckBox";
            this.socioEstadoCheckBox.Size = new System.Drawing.Size(200, 24);
            this.socioEstadoCheckBox.TabIndex = 36;
            this.socioEstadoCheckBox.Text = "checkBox1";
            this.socioEstadoCheckBox.UseVisualStyleBackColor = true;
            // 
            // ModificarInactivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 441);
            this.Controls.Add(socioIDLabel);
            this.Controls.Add(this.socioIDLabel1);
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
            this.Controls.Add(socioGeneroLabel);
            this.Controls.Add(this.socioGeneroCheckBox);
            this.Controls.Add(socioCategoriaLabel);
            this.Controls.Add(this.socioCategoriaTextBox);
            this.Controls.Add(socioNivelLabel);
            this.Controls.Add(this.socioNivelTextBox);
            this.Controls.Add(socioEstadoLabel);
            this.Controls.Add(this.socioEstadoCheckBox);
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
        private System.Windows.Forms.Label socioIDLabel1;
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
        private System.Windows.Forms.CheckBox socioGeneroCheckBox;
        private System.Windows.Forms.TextBox socioCategoriaTextBox;
        private System.Windows.Forms.TextBox socioNivelTextBox;
        private System.Windows.Forms.CheckBox socioEstadoCheckBox;
    }
}