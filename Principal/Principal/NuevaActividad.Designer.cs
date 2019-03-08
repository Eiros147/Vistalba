namespace Principal
{
    partial class NuevaActividad
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
            System.Windows.Forms.Label actIdLabel;
            System.Windows.Forms.Label actDescLabel;
            System.Windows.Forms.Label profIdLabel;
            System.Windows.Forms.Label actMesesLabel;
            System.Windows.Forms.Label actNombreLabel;
            this.club_VistalbaDataSet = new Principal.Club_VistalbaDataSet();
            this.actividadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.actividadesTableAdapter = new Principal.Club_VistalbaDataSetTableAdapters.ActividadesTableAdapter();
            this.tableAdapterManager = new Principal.Club_VistalbaDataSetTableAdapters.TableAdapterManager();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNombreProfesor = new System.Windows.Forms.TextBox();
            this.txtMeses = new System.Windows.Forms.TextBox();
            this.txtNombreActividad = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            actIdLabel = new System.Windows.Forms.Label();
            actDescLabel = new System.Windows.Forms.Label();
            profIdLabel = new System.Windows.Forms.Label();
            actMesesLabel = new System.Windows.Forms.Label();
            actNombreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.club_VistalbaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // actIdLabel
            // 
            actIdLabel.AutoSize = true;
            actIdLabel.Location = new System.Drawing.Point(16, 15);
            actIdLabel.Name = "actIdLabel";
            actIdLabel.Size = new System.Drawing.Size(19, 13);
            actIdLabel.TabIndex = 1;
            actIdLabel.Text = "Id:";
            // 
            // actDescLabel
            // 
            actDescLabel.AutoSize = true;
            actDescLabel.Location = new System.Drawing.Point(16, 67);
            actDescLabel.Name = "actDescLabel";
            actDescLabel.Size = new System.Drawing.Size(66, 13);
            actDescLabel.TabIndex = 3;
            actDescLabel.Text = "Descripcion:";
            // 
            // profIdLabel
            // 
            profIdLabel.AutoSize = true;
            profIdLabel.Location = new System.Drawing.Point(16, 93);
            profIdLabel.Name = "profIdLabel";
            profIdLabel.Size = new System.Drawing.Size(49, 13);
            profIdLabel.TabIndex = 5;
            profIdLabel.Text = "Profesor:";
            // 
            // actMesesLabel
            // 
            actMesesLabel.AutoSize = true;
            actMesesLabel.Location = new System.Drawing.Point(16, 119);
            actMesesLabel.Name = "actMesesLabel";
            actMesesLabel.Size = new System.Drawing.Size(41, 13);
            actMesesLabel.TabIndex = 7;
            actMesesLabel.Text = "Meses:";
            // 
            // actNombreLabel
            // 
            actNombreLabel.AutoSize = true;
            actNombreLabel.Location = new System.Drawing.Point(16, 41);
            actNombreLabel.Name = "actNombreLabel";
            actNombreLabel.Size = new System.Drawing.Size(47, 13);
            actNombreLabel.TabIndex = 9;
            actNombreLabel.Text = "Nombre:";
            // 
            // club_VistalbaDataSet
            // 
            this.club_VistalbaDataSet.DataSetName = "Club_VistalbaDataSet";
            this.club_VistalbaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // actividadesBindingSource
            // 
            this.actividadesBindingSource.DataMember = "Actividades";
            this.actividadesBindingSource.DataSource = this.club_VistalbaDataSet;
            // 
            // actividadesTableAdapter
            // 
            this.actividadesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ActividadesTableAdapter = this.actividadesTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriaTableAdapter = null;
            this.tableAdapterManager.CuotaTableAdapter = null;
            this.tableAdapterManager.GrupoTableAdapter = null;
            this.tableAdapterManager.MensualTableAdapter = null;
            this.tableAdapterManager.ProfesionalTableAdapter = null;
            this.tableAdapterManager.SaludTableAdapter = null;
            this.tableAdapterManager.SocioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Principal.Club_VistalbaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.actividadesBindingSource, "actDesc", true));
            this.txtDescripcion.Location = new System.Drawing.Point(112, 64);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcion.TabIndex = 4;
            // 
            // txtNombreProfesor
            // 
            this.txtNombreProfesor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.actividadesBindingSource, "profId", true));
            this.txtNombreProfesor.Enabled = false;
            this.txtNombreProfesor.Location = new System.Drawing.Point(112, 90);
            this.txtNombreProfesor.Name = "txtNombreProfesor";
            this.txtNombreProfesor.Size = new System.Drawing.Size(100, 20);
            this.txtNombreProfesor.TabIndex = 6;
            // 
            // txtMeses
            // 
            this.txtMeses.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.actividadesBindingSource, "actMeses", true));
            this.txtMeses.Location = new System.Drawing.Point(112, 116);
            this.txtMeses.Name = "txtMeses";
            this.txtMeses.Size = new System.Drawing.Size(100, 20);
            this.txtMeses.TabIndex = 8;
            // 
            // txtNombreActividad
            // 
            this.txtNombreActividad.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.actividadesBindingSource, "actNombre", true));
            this.txtNombreActividad.Location = new System.Drawing.Point(112, 38);
            this.txtNombreActividad.Name = "txtNombreActividad";
            this.txtNombreActividad.Size = new System.Drawing.Size(100, 20);
            this.txtNombreActividad.TabIndex = 10;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(19, 161);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 35);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(137, 161);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 35);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(109, 15);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(65, 13);
            this.lblID.TabIndex = 13;
            this.lblID.Text = "ID Actividad";
            // 
            // NuevaActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 208);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(actIdLabel);
            this.Controls.Add(actDescLabel);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(profIdLabel);
            this.Controls.Add(this.txtNombreProfesor);
            this.Controls.Add(actMesesLabel);
            this.Controls.Add(this.txtMeses);
            this.Controls.Add(actNombreLabel);
            this.Controls.Add(this.txtNombreActividad);
            this.Name = "NuevaActividad";
            this.Text = "NuevaActividad";
            this.Load += new System.EventHandler(this.NuevaActividad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.club_VistalbaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Club_VistalbaDataSet club_VistalbaDataSet;
        private System.Windows.Forms.BindingSource actividadesBindingSource;
        private Club_VistalbaDataSetTableAdapters.ActividadesTableAdapter actividadesTableAdapter;
        private Club_VistalbaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNombreProfesor;
        private System.Windows.Forms.TextBox txtMeses;
        private System.Windows.Forms.TextBox txtNombreActividad;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblID;
    }
}