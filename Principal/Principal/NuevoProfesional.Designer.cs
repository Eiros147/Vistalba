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
            System.Windows.Forms.Label actNombreLabel;
            this.club_VistalbaDataSet = new Principal.Club_VistalbaDataSet();
            this.profesionalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.profesionalTableAdapter = new Principal.Club_VistalbaDataSetTableAdapters.ProfesionalTableAdapter();
            this.tableAdapterManager = new Principal.Club_VistalbaDataSetTableAdapters.TableAdapterManager();
            this.profIdTextBox = new System.Windows.Forms.TextBox();
            this.profNombreTextBox = new System.Windows.Forms.TextBox();
            this.profDomicilioTextBox = new System.Windows.Forms.TextBox();
            this.profTelefonoTextBox = new System.Windows.Forms.TextBox();
            this.profMailTextBox = new System.Windows.Forms.TextBox();
            this.actividadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.actividadesTableAdapter = new Principal.Club_VistalbaDataSetTableAdapters.ActividadesTableAdapter();
            this.actNombreTextBox = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            profIdLabel = new System.Windows.Forms.Label();
            profNombreLabel = new System.Windows.Forms.Label();
            profDomicilioLabel = new System.Windows.Forms.Label();
            profTelefonoLabel = new System.Windows.Forms.Label();
            profMailLabel = new System.Windows.Forms.Label();
            actNombreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.club_VistalbaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesionalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadesBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // profIdLabel
            // 
            profIdLabel.AutoSize = true;
            profIdLabel.Location = new System.Drawing.Point(20, 23);
            profIdLabel.Name = "profIdLabel";
            profIdLabel.Size = new System.Drawing.Size(40, 13);
            profIdLabel.TabIndex = 1;
            profIdLabel.Text = "prof Id:";
            // 
            // profIdTextBox
            // 
            this.profIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profesionalBindingSource, "profId", true));
            this.profIdTextBox.Location = new System.Drawing.Point(99, 20);
            this.profIdTextBox.Name = "profIdTextBox";
            this.profIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.profIdTextBox.TabIndex = 2;
            // 
            // profNombreLabel
            // 
            profNombreLabel.AutoSize = true;
            profNombreLabel.Location = new System.Drawing.Point(20, 49);
            profNombreLabel.Name = "profNombreLabel";
            profNombreLabel.Size = new System.Drawing.Size(68, 13);
            profNombreLabel.TabIndex = 3;
            profNombreLabel.Text = "prof Nombre:";
            // 
            // profNombreTextBox
            // 
            this.profNombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profesionalBindingSource, "profNombre", true));
            this.profNombreTextBox.Location = new System.Drawing.Point(99, 46);
            this.profNombreTextBox.Name = "profNombreTextBox";
            this.profNombreTextBox.Size = new System.Drawing.Size(100, 20);
            this.profNombreTextBox.TabIndex = 4;
            // 
            // profDomicilioLabel
            // 
            profDomicilioLabel.AutoSize = true;
            profDomicilioLabel.Location = new System.Drawing.Point(20, 75);
            profDomicilioLabel.Name = "profDomicilioLabel";
            profDomicilioLabel.Size = new System.Drawing.Size(73, 13);
            profDomicilioLabel.TabIndex = 5;
            profDomicilioLabel.Text = "prof Domicilio:";
            // 
            // profDomicilioTextBox
            // 
            this.profDomicilioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profesionalBindingSource, "profDomicilio", true));
            this.profDomicilioTextBox.Location = new System.Drawing.Point(99, 72);
            this.profDomicilioTextBox.Name = "profDomicilioTextBox";
            this.profDomicilioTextBox.Size = new System.Drawing.Size(100, 20);
            this.profDomicilioTextBox.TabIndex = 6;
            // 
            // profTelefonoLabel
            // 
            profTelefonoLabel.AutoSize = true;
            profTelefonoLabel.Location = new System.Drawing.Point(20, 101);
            profTelefonoLabel.Name = "profTelefonoLabel";
            profTelefonoLabel.Size = new System.Drawing.Size(73, 13);
            profTelefonoLabel.TabIndex = 7;
            profTelefonoLabel.Text = "prof Telefono:";
            // 
            // profTelefonoTextBox
            // 
            this.profTelefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profesionalBindingSource, "profTelefono", true));
            this.profTelefonoTextBox.Location = new System.Drawing.Point(99, 98);
            this.profTelefonoTextBox.Name = "profTelefonoTextBox";
            this.profTelefonoTextBox.Size = new System.Drawing.Size(100, 20);
            this.profTelefonoTextBox.TabIndex = 8;
            // 
            // profMailLabel
            // 
            profMailLabel.AutoSize = true;
            profMailLabel.Location = new System.Drawing.Point(20, 127);
            profMailLabel.Name = "profMailLabel";
            profMailLabel.Size = new System.Drawing.Size(50, 13);
            profMailLabel.TabIndex = 9;
            profMailLabel.Text = "prof Mail:";
            // 
            // profMailTextBox
            // 
            this.profMailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profesionalBindingSource, "profMail", true));
            this.profMailTextBox.Location = new System.Drawing.Point(99, 124);
            this.profMailTextBox.Name = "profMailTextBox";
            this.profMailTextBox.Size = new System.Drawing.Size(100, 20);
            this.profMailTextBox.TabIndex = 10;
            // 
            // actividadesBindingSource
            // 
            this.actividadesBindingSource.DataMember = "ProfesionalActividades";
            this.actividadesBindingSource.DataSource = this.profesionalBindingSource;
            // 
            // actividadesTableAdapter
            // 
            this.actividadesTableAdapter.ClearBeforeFill = true;
            // 
            // actNombreLabel
            // 
            actNombreLabel.AutoSize = true;
            actNombreLabel.Location = new System.Drawing.Point(20, 153);
            actNombreLabel.Name = "actNombreLabel";
            actNombreLabel.Size = new System.Drawing.Size(65, 13);
            actNombreLabel.TabIndex = 10;
            actNombreLabel.Text = "act Nombre:";
            // 
            // actNombreTextBox
            // 
            this.actNombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.actividadesBindingSource, "actNombre", true));
            this.actNombreTextBox.Location = new System.Drawing.Point(99, 150);
            this.actNombreTextBox.Name = "actNombreTextBox";
            this.actNombreTextBox.Size = new System.Drawing.Size(100, 20);
            this.actNombreTextBox.TabIndex = 11;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(18, 191);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 31);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(124, 191);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 31);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // NuevoProfesional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 234);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(actNombreLabel);
            this.Controls.Add(this.actNombreTextBox);
            this.Controls.Add(profIdLabel);
            this.Controls.Add(this.profIdTextBox);
            this.Controls.Add(profNombreLabel);
            this.Controls.Add(this.profNombreTextBox);
            this.Controls.Add(profDomicilioLabel);
            this.Controls.Add(this.profDomicilioTextBox);
            this.Controls.Add(profTelefonoLabel);
            this.Controls.Add(this.profTelefonoTextBox);
            this.Controls.Add(profMailLabel);
            this.Controls.Add(this.profMailTextBox);
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
        private System.Windows.Forms.TextBox profIdTextBox;
        private System.Windows.Forms.TextBox profNombreTextBox;
        private System.Windows.Forms.TextBox profDomicilioTextBox;
        private System.Windows.Forms.TextBox profTelefonoTextBox;
        private System.Windows.Forms.TextBox profMailTextBox;
        private System.Windows.Forms.BindingSource actividadesBindingSource;
        private System.Windows.Forms.TextBox actNombreTextBox;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}