namespace Principal
{
    partial class ModificarProfesional
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
            System.Windows.Forms.Label profIdLabel;
            System.Windows.Forms.Label profNombreLabel;
            System.Windows.Forms.Label profDomicilioLabel;
            System.Windows.Forms.Label profTelefonoLabel;
            System.Windows.Forms.Label profMailLabel;
            this.club_VistalbaDataSet = new Principal.Club_VistalbaDataSet();
            this.profesionalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.profesionalTableAdapter = new Principal.Club_VistalbaDataSetTableAdapters.ProfesionalTableAdapter();
            this.tableAdapterManager = new Principal.Club_VistalbaDataSetTableAdapters.TableAdapterManager();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.btnHabilitar = new System.Windows.Forms.Button();
            profIdLabel = new System.Windows.Forms.Label();
            profNombreLabel = new System.Windows.Forms.Label();
            profDomicilioLabel = new System.Windows.Forms.Label();
            profTelefonoLabel = new System.Windows.Forms.Label();
            profMailLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.club_VistalbaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesionalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // profIdLabel
            // 
            profIdLabel.AutoSize = true;
            profIdLabel.Location = new System.Drawing.Point(19, 15);
            profIdLabel.Name = "profIdLabel";
            profIdLabel.Size = new System.Drawing.Size(19, 13);
            profIdLabel.TabIndex = 1;
            profIdLabel.Text = "Id:";
            // 
            // profNombreLabel
            // 
            profNombreLabel.AutoSize = true;
            profNombreLabel.Location = new System.Drawing.Point(19, 41);
            profNombreLabel.Name = "profNombreLabel";
            profNombreLabel.Size = new System.Drawing.Size(47, 13);
            profNombreLabel.TabIndex = 3;
            profNombreLabel.Text = "Nombre:";
            // 
            // profDomicilioLabel
            // 
            profDomicilioLabel.AutoSize = true;
            profDomicilioLabel.Location = new System.Drawing.Point(19, 67);
            profDomicilioLabel.Name = "profDomicilioLabel";
            profDomicilioLabel.Size = new System.Drawing.Size(52, 13);
            profDomicilioLabel.TabIndex = 5;
            profDomicilioLabel.Text = "Domicilio:";
            // 
            // profTelefonoLabel
            // 
            profTelefonoLabel.AutoSize = true;
            profTelefonoLabel.Location = new System.Drawing.Point(19, 93);
            profTelefonoLabel.Name = "profTelefonoLabel";
            profTelefonoLabel.Size = new System.Drawing.Size(52, 13);
            profTelefonoLabel.TabIndex = 7;
            profTelefonoLabel.Text = "Telefono:";
            // 
            // profMailLabel
            // 
            profMailLabel.AutoSize = true;
            profMailLabel.Location = new System.Drawing.Point(19, 119);
            profMailLabel.Name = "profMailLabel";
            profMailLabel.Size = new System.Drawing.Size(29, 13);
            profMailLabel.TabIndex = 9;
            profMailLabel.Text = "Mail:";
            // 
            // club_VistalbaDataSet
            // 
            this.club_VistalbaDataSet.DataSetName = "Club_VistalbaDataSet";
            this.club_VistalbaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.ActividadesTableAdapter = null;
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
            // txtNombre
            // 
            this.txtNombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profesionalBindingSource, "profNombre", true));
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(98, 38);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(151, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profesionalBindingSource, "profDomicilio", true));
            this.txtDomicilio.Enabled = false;
            this.txtDomicilio.Location = new System.Drawing.Point(98, 64);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(151, 20);
            this.txtDomicilio.TabIndex = 6;
            // 
            // txtTelefono
            // 
            this.txtTelefono.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profesionalBindingSource, "profTelefono", true));
            this.txtTelefono.Enabled = false;
            this.txtTelefono.Location = new System.Drawing.Point(98, 90);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(151, 20);
            this.txtTelefono.TabIndex = 8;
            // 
            // txtMail
            // 
            this.txtMail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profesionalBindingSource, "profMail", true));
            this.txtMail.Enabled = false;
            this.txtMail.Location = new System.Drawing.Point(98, 116);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(152, 20);
            this.txtMail.TabIndex = 10;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(93, 157);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 38);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(174, 157);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 38);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(95, 15);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(35, 13);
            this.lblID.TabIndex = 13;
            this.lblID.Text = "label1";
            // 
            // btnHabilitar
            // 
            this.btnHabilitar.Location = new System.Drawing.Point(12, 157);
            this.btnHabilitar.Name = "btnHabilitar";
            this.btnHabilitar.Size = new System.Drawing.Size(75, 38);
            this.btnHabilitar.TabIndex = 14;
            this.btnHabilitar.Text = "Habilitar";
            this.btnHabilitar.UseVisualStyleBackColor = true;
            this.btnHabilitar.Click += new System.EventHandler(this.btnHabilitar_Click);
            // 
            // ModificarProfesional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 208);
            this.Controls.Add(this.btnHabilitar);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(profIdLabel);
            this.Controls.Add(profNombreLabel);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(profDomicilioLabel);
            this.Controls.Add(this.txtDomicilio);
            this.Controls.Add(profTelefonoLabel);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(profMailLabel);
            this.Controls.Add(this.txtMail);
            this.Name = "ModificarProfesional";
            this.Text = "ModificarProfesional";
            this.Load += new System.EventHandler(this.ModificarProfesional_Load);
            ((System.ComponentModel.ISupportInitialize)(this.club_VistalbaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesionalBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Club_VistalbaDataSet club_VistalbaDataSet;
        private System.Windows.Forms.BindingSource profesionalBindingSource;
        private Club_VistalbaDataSetTableAdapters.ProfesionalTableAdapter profesionalTableAdapter;
        private Club_VistalbaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.Label lblID;
        public System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.TextBox txtDomicilio;
        public System.Windows.Forms.TextBox txtTelefono;
        public System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Button btnHabilitar;
    }
}