namespace Principal
{
    partial class NuevoProfesional
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
            this.actividadesTableAdapter = new Principal.Club_VistalbaDataSetTableAdapters.ActividadesTableAdapter();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.actividadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            profIdLabel = new System.Windows.Forms.Label();
            profNombreLabel = new System.Windows.Forms.Label();
            profDomicilioLabel = new System.Windows.Forms.Label();
            profTelefonoLabel = new System.Windows.Forms.Label();
            profMailLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.club_VistalbaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesionalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // profIdLabel
            // 
            profIdLabel.AutoSize = true;
            profIdLabel.Location = new System.Drawing.Point(20, 23);
            profIdLabel.Name = "profIdLabel";
            profIdLabel.Size = new System.Drawing.Size(19, 13);
            profIdLabel.TabIndex = 1;
            profIdLabel.Text = "Id:";
            // 
            // profNombreLabel
            // 
            profNombreLabel.AutoSize = true;
            profNombreLabel.Location = new System.Drawing.Point(20, 49);
            profNombreLabel.Name = "profNombreLabel";
            profNombreLabel.Size = new System.Drawing.Size(47, 13);
            profNombreLabel.TabIndex = 3;
            profNombreLabel.Text = "Nombre:";
            // 
            // profDomicilioLabel
            // 
            profDomicilioLabel.AutoSize = true;
            profDomicilioLabel.Location = new System.Drawing.Point(20, 75);
            profDomicilioLabel.Name = "profDomicilioLabel";
            profDomicilioLabel.Size = new System.Drawing.Size(52, 13);
            profDomicilioLabel.TabIndex = 5;
            profDomicilioLabel.Text = "Domicilio:";
            // 
            // profTelefonoLabel
            // 
            profTelefonoLabel.AutoSize = true;
            profTelefonoLabel.Location = new System.Drawing.Point(20, 101);
            profTelefonoLabel.Name = "profTelefonoLabel";
            profTelefonoLabel.Size = new System.Drawing.Size(52, 13);
            profTelefonoLabel.TabIndex = 7;
            profTelefonoLabel.Text = "Telefono:";
            // 
            // profMailLabel
            // 
            profMailLabel.AutoSize = true;
            profMailLabel.Location = new System.Drawing.Point(20, 127);
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
            // actividadesTableAdapter
            // 
            this.actividadesTableAdapter.ClearBeforeFill = true;
            // 
            // txtNombre
            // 
            this.txtNombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profesionalBindingSource, "profNombre", true));
            this.txtNombre.Location = new System.Drawing.Point(99, 46);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(179, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profesionalBindingSource, "profDomicilio", true));
            this.txtDomicilio.Location = new System.Drawing.Point(99, 72);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(179, 20);
            this.txtDomicilio.TabIndex = 6;
            // 
            // txtTelefono
            // 
            this.txtTelefono.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profesionalBindingSource, "profTelefono", true));
            this.txtTelefono.Location = new System.Drawing.Point(99, 98);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(179, 20);
            this.txtTelefono.TabIndex = 8;
            // 
            // txtMail
            // 
            this.txtMail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profesionalBindingSource, "profMail", true));
            this.txtMail.Location = new System.Drawing.Point(99, 124);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(179, 20);
            this.txtMail.TabIndex = 10;
            // 
            // actividadesBindingSource
            // 
            this.actividadesBindingSource.DataMember = "ProfesionalActividades";
            this.actividadesBindingSource.DataSource = this.profesionalBindingSource;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(12, 162);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 31);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(203, 162);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 31);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(96, 23);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(35, 13);
            this.lblID.TabIndex = 14;
            this.lblID.Text = "label1";
            // 
            // NuevoProfesional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 212);
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
            this.Name = "NuevoProfesional";
            this.Text = "NuevoProfesional";
            this.Load += new System.EventHandler(this.NuevoProfesional_Load);
            ((System.ComponentModel.ISupportInitialize)(this.club_VistalbaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesionalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Club_VistalbaDataSet club_VistalbaDataSet;
        private System.Windows.Forms.BindingSource profesionalBindingSource;
        private Club_VistalbaDataSetTableAdapters.ProfesionalTableAdapter profesionalTableAdapter;
        private Club_VistalbaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Club_VistalbaDataSetTableAdapters.ActividadesTableAdapter actividadesTableAdapter;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.BindingSource actividadesBindingSource;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblID;
    }
}