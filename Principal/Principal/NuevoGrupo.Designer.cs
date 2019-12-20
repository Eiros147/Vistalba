namespace Principal
{
    partial class NuevoGrupo
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
            System.Windows.Forms.Label grupoIDLabel;
            System.Windows.Forms.Label grupoCategoriaLabel;
            System.Windows.Forms.Label grupoSocioPpalLabel;
            System.Windows.Forms.Label grupoApellidoLabel;
            this.club_VistalbaDataSet = new Principal.Club_VistalbaDataSet();
            this.grupoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grupoTableAdapter = new Principal.Club_VistalbaDataSetTableAdapters.GrupoTableAdapter();
            this.tableAdapterManager = new Principal.Club_VistalbaDataSetTableAdapters.TableAdapterManager();
            this.txtSocioPpal = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.gbPersona2 = new System.Windows.Forms.GroupBox();
            this.btnBuscar2 = new System.Windows.Forms.Button();
            this.txtPersona2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbPersona3 = new System.Windows.Forms.GroupBox();
            this.btnBuscar3 = new System.Windows.Forms.Button();
            this.txtPersona3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            grupoIDLabel = new System.Windows.Forms.Label();
            grupoCategoriaLabel = new System.Windows.Forms.Label();
            grupoSocioPpalLabel = new System.Windows.Forms.Label();
            grupoApellidoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.club_VistalbaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoBindingSource)).BeginInit();
            this.gbPersona2.SuspendLayout();
            this.gbPersona3.SuspendLayout();
            this.SuspendLayout();
            // 
            // grupoIDLabel
            // 
            grupoIDLabel.AutoSize = true;
            grupoIDLabel.Location = new System.Drawing.Point(12, 9);
            grupoIDLabel.Name = "grupoIDLabel";
            grupoIDLabel.Size = new System.Drawing.Size(21, 13);
            grupoIDLabel.TabIndex = 1;
            grupoIDLabel.Text = "ID:";
            // 
            // grupoCategoriaLabel
            // 
            grupoCategoriaLabel.AutoSize = true;
            grupoCategoriaLabel.Location = new System.Drawing.Point(12, 33);
            grupoCategoriaLabel.Name = "grupoCategoriaLabel";
            grupoCategoriaLabel.Size = new System.Drawing.Size(55, 13);
            grupoCategoriaLabel.TabIndex = 3;
            grupoCategoriaLabel.Text = "Categoria:";
            // 
            // grupoSocioPpalLabel
            // 
            grupoSocioPpalLabel.AutoSize = true;
            grupoSocioPpalLabel.Location = new System.Drawing.Point(12, 60);
            grupoSocioPpalLabel.Name = "grupoSocioPpalLabel";
            grupoSocioPpalLabel.Size = new System.Drawing.Size(80, 13);
            grupoSocioPpalLabel.TabIndex = 5;
            grupoSocioPpalLabel.Text = "Socio Principal:";
            // 
            // grupoApellidoLabel
            // 
            grupoApellidoLabel.AutoSize = true;
            grupoApellidoLabel.Location = new System.Drawing.Point(12, 134);
            grupoApellidoLabel.Name = "grupoApellidoLabel";
            grupoApellidoLabel.Size = new System.Drawing.Size(47, 13);
            grupoApellidoLabel.TabIndex = 7;
            grupoApellidoLabel.Text = "Apellido:";
            // 
            // club_VistalbaDataSet
            // 
            this.club_VistalbaDataSet.DataSetName = "Club_VistalbaDataSet";
            this.club_VistalbaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.tableAdapterManager.SocioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Principal.Club_VistalbaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ValorFijoTableAdapter = null;
            // 
            // txtSocioPpal
            // 
            this.txtSocioPpal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.grupoBindingSource, "grupoSocioPpal", true));
            this.txtSocioPpal.Location = new System.Drawing.Point(109, 57);
            this.txtSocioPpal.Name = "txtSocioPpal";
            this.txtSocioPpal.Size = new System.Drawing.Size(263, 20);
            this.txtSocioPpal.TabIndex = 6;
            // 
            // txtApellido
            // 
            this.txtApellido.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.grupoBindingSource, "grupoApellido", true));
            this.txtApellido.Location = new System.Drawing.Point(109, 131);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(263, 20);
            this.txtApellido.TabIndex = 8;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(106, 9);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(35, 13);
            this.lblID.TabIndex = 9;
            this.lblID.Text = "label1";
            // 
            // cbCategoria
            // 
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(109, 30);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(55, 21);
            this.cbCategoria.TabIndex = 10;
            this.cbCategoria.SelectedIndexChanged += new System.EventHandler(this.cbCategoria_SelectedIndexChanged);
            this.cbCategoria.TextChanged += new System.EventHandler(this.cbCategoria_TextChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(297, 83);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 42);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nombre Grupo:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(109, 157);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(55, 20);
            this.txtNombre.TabIndex = 13;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(12, 380);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 37);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrar.Location = new System.Drawing.Point(310, 380);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 37);
            this.btnCerrar.TabIndex = 15;
            this.btnCerrar.Text = "Cancelar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // gbPersona2
            // 
            this.gbPersona2.Controls.Add(this.btnBuscar2);
            this.gbPersona2.Controls.Add(this.txtPersona2);
            this.gbPersona2.Controls.Add(this.label2);
            this.gbPersona2.Enabled = false;
            this.gbPersona2.Location = new System.Drawing.Point(12, 183);
            this.gbPersona2.Name = "gbPersona2";
            this.gbPersona2.Size = new System.Drawing.Size(370, 88);
            this.gbPersona2.TabIndex = 16;
            this.gbPersona2.TabStop = false;
            // 
            // btnBuscar2
            // 
            this.btnBuscar2.Location = new System.Drawing.Point(282, 39);
            this.btnBuscar2.Name = "btnBuscar2";
            this.btnBuscar2.Size = new System.Drawing.Size(75, 42);
            this.btnBuscar2.TabIndex = 12;
            this.btnBuscar2.Text = "Buscar";
            this.btnBuscar2.UseVisualStyleBackColor = true;
            this.btnBuscar2.Click += new System.EventHandler(this.btnBuscar2_Click);
            // 
            // txtPersona2
            // 
            this.txtPersona2.Location = new System.Drawing.Point(94, 13);
            this.txtPersona2.Name = "txtPersona2";
            this.txtPersona2.Size = new System.Drawing.Size(257, 20);
            this.txtPersona2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Persona 2:";
            // 
            // gbPersona3
            // 
            this.gbPersona3.Controls.Add(this.btnBuscar3);
            this.gbPersona3.Controls.Add(this.txtPersona3);
            this.gbPersona3.Controls.Add(this.label3);
            this.gbPersona3.Enabled = false;
            this.gbPersona3.Location = new System.Drawing.Point(15, 277);
            this.gbPersona3.Name = "gbPersona3";
            this.gbPersona3.Size = new System.Drawing.Size(370, 88);
            this.gbPersona3.TabIndex = 17;
            this.gbPersona3.TabStop = false;
            // 
            // btnBuscar3
            // 
            this.btnBuscar3.Location = new System.Drawing.Point(282, 39);
            this.btnBuscar3.Name = "btnBuscar3";
            this.btnBuscar3.Size = new System.Drawing.Size(75, 42);
            this.btnBuscar3.TabIndex = 12;
            this.btnBuscar3.Text = "Buscar";
            this.btnBuscar3.UseVisualStyleBackColor = true;
            this.btnBuscar3.Click += new System.EventHandler(this.btnBuscar3_Click);
            // 
            // txtPersona3
            // 
            this.txtPersona3.Location = new System.Drawing.Point(94, 13);
            this.txtPersona3.Name = "txtPersona3";
            this.txtPersona3.Size = new System.Drawing.Size(257, 20);
            this.txtPersona3.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Persona 3:";
            // 
            // NuevoGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 431);
            this.Controls.Add(this.gbPersona3);
            this.Controls.Add(this.gbPersona2);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.lblID);
            this.Controls.Add(grupoIDLabel);
            this.Controls.Add(grupoCategoriaLabel);
            this.Controls.Add(grupoSocioPpalLabel);
            this.Controls.Add(this.txtSocioPpal);
            this.Controls.Add(grupoApellidoLabel);
            this.Controls.Add(this.txtApellido);
            this.Name = "NuevoGrupo";
            this.Text = "Nuevo Grupo";
            this.Load += new System.EventHandler(this.NuevoGrupo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.club_VistalbaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoBindingSource)).EndInit();
            this.gbPersona2.ResumeLayout(false);
            this.gbPersona2.PerformLayout();
            this.gbPersona3.ResumeLayout(false);
            this.gbPersona3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Club_VistalbaDataSet club_VistalbaDataSet;
        private System.Windows.Forms.BindingSource grupoBindingSource;
        private Club_VistalbaDataSetTableAdapters.GrupoTableAdapter grupoTableAdapter;
        private Club_VistalbaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCerrar;
        public System.Windows.Forms.TextBox txtSocioPpal;
        private System.Windows.Forms.GroupBox gbPersona2;
        private System.Windows.Forms.TextBox txtPersona2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscar2;
        private System.Windows.Forms.GroupBox gbPersona3;
        private System.Windows.Forms.Button btnBuscar3;
        private System.Windows.Forms.TextBox txtPersona3;
        private System.Windows.Forms.Label label3;
    }
}