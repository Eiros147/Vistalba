namespace Principal
{
    partial class ModificarGrupo
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
            System.Windows.Forms.Label grupoApellidoLabel;
            System.Windows.Forms.Label grupoSocioPpalLabel;
            System.Windows.Forms.Label grupoCategoriaLabel;
            System.Windows.Forms.Label grupoIDLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.grupoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.club_VistalbaDataSet = new Principal.Club_VistalbaDataSet();
            this.lblID = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtSocio = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grupoTableAdapter = new Principal.Club_VistalbaDataSetTableAdapters.GrupoTableAdapter();
            this.tableAdapterManager = new Principal.Club_VistalbaDataSetTableAdapters.TableAdapterManager();
            this.txtPersona2 = new System.Windows.Forms.TextBox();
            this.txtPersona3 = new System.Windows.Forms.TextBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.txtPersona4 = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriaTableAdapter = new Principal.Club_VistalbaDataSetTableAdapters.CategoriaTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            grupoApellidoLabel = new System.Windows.Forms.Label();
            grupoSocioPpalLabel = new System.Windows.Forms.Label();
            grupoCategoriaLabel = new System.Windows.Forms.Label();
            grupoIDLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grupoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.club_VistalbaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // grupoSocioPpalLabel
            // 
            grupoSocioPpalLabel.AutoSize = true;
            grupoSocioPpalLabel.Location = new System.Drawing.Point(12, 61);
            grupoSocioPpalLabel.Name = "grupoSocioPpalLabel";
            grupoSocioPpalLabel.Size = new System.Drawing.Size(80, 13);
            grupoSocioPpalLabel.TabIndex = 5;
            grupoSocioPpalLabel.Text = "Socio Principal:";
            // 
            // grupoCategoriaLabel
            // 
            grupoCategoriaLabel.AutoSize = true;
            grupoCategoriaLabel.Location = new System.Drawing.Point(12, 35);
            grupoCategoriaLabel.Name = "grupoCategoriaLabel";
            grupoCategoriaLabel.Size = new System.Drawing.Size(55, 13);
            grupoCategoriaLabel.TabIndex = 3;
            grupoCategoriaLabel.Text = "Categoria:";
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 160);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(79, 13);
            label2.TabIndex = 12;
            label2.Text = "Nombre Grupo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 186);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(58, 13);
            label1.TabIndex = 19;
            label1.Text = "Persona 2:";
            label1.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(12, 273);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(58, 13);
            label3.TabIndex = 21;
            label3.Text = "Persona 3:";
            label3.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(202, 35);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(114, 13);
            label4.TabIndex = 24;
            label4.Text = "Cantidad de Personas:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(12, 299);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(58, 13);
            label5.TabIndex = 26;
            label5.Text = "Persona 4:";
            label5.Visible = false;
            // 
            // txtApellido
            // 
            this.txtApellido.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.grupoBindingSource, "grupoApellido", true));
            this.txtApellido.Location = new System.Drawing.Point(109, 131);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(249, 20);
            this.txtApellido.TabIndex = 8;
            // 
            // grupoBindingSource
            // 
            this.grupoBindingSource.DataMember = "Grupo";
            this.grupoBindingSource.DataSource = this.club_VistalbaDataSet;
            // 
            // club_VistalbaDataSet
            // 
            this.club_VistalbaDataSet.DataSetName = "Club_VistalbaDataSet";
            this.club_VistalbaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // txtNombre
            // 
            this.txtNombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.grupoBindingSource, "grupoApellido", true));
            this.txtNombre.Location = new System.Drawing.Point(109, 157);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(249, 20);
            this.txtNombre.TabIndex = 13;
            // 
            // txtSocio
            // 
            this.txtSocio.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.grupoBindingSource, "grupoApellido", true));
            this.txtSocio.Location = new System.Drawing.Point(109, 58);
            this.txtSocio.Name = "txtSocio";
            this.txtSocio.Size = new System.Drawing.Size(249, 20);
            this.txtSocio.TabIndex = 15;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(283, 84);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 41);
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(15, 322);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 41);
            this.btnGuardar.TabIndex = 17;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(283, 322);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 41);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
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
            // 
            // txtPersona2
            // 
            this.txtPersona2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.grupoBindingSource, "grupoApellido", true));
            this.txtPersona2.Location = new System.Drawing.Point(109, 183);
            this.txtPersona2.Name = "txtPersona2";
            this.txtPersona2.Size = new System.Drawing.Size(249, 20);
            this.txtPersona2.TabIndex = 20;
            this.txtPersona2.Visible = false;
            // 
            // txtPersona3
            // 
            this.txtPersona3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.grupoBindingSource, "grupoApellido", true));
            this.txtPersona3.Location = new System.Drawing.Point(109, 270);
            this.txtPersona3.Name = "txtPersona3";
            this.txtPersona3.Size = new System.Drawing.Size(249, 20);
            this.txtPersona3.TabIndex = 22;
            this.txtPersona3.Visible = false;
            // 
            // cbCategoria
            // 
            this.cbCategoria.DataSource = this.categoriaBindingSource;
            this.cbCategoria.DisplayMember = "catNombre";
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(109, 31);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(52, 21);
            this.cbCategoria.TabIndex = 23;
            this.cbCategoria.ValueMember = "catID";
            this.cbCategoria.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // txtPersona4
            // 
            this.txtPersona4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.grupoBindingSource, "grupoApellido", true));
            this.txtPersona4.Location = new System.Drawing.Point(109, 296);
            this.txtPersona4.Name = "txtPersona4";
            this.txtPersona4.Size = new System.Drawing.Size(249, 20);
            this.txtPersona4.TabIndex = 27;
            this.txtPersona4.Visible = false;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(323, 35);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(35, 13);
            this.lblCantidad.TabIndex = 28;
            this.lblCantidad.Text = "label1";
            this.lblCantidad.TextChanged += new System.EventHandler(this.lblCantidad_TextChanged);
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataMember = "Categoria";
            this.categoriaBindingSource.DataSource = this.club_VistalbaDataSet;
            // 
            // categoriaTableAdapter
            // 
            this.categoriaTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(283, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 41);
            this.button1.TabIndex = 29;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ModificarGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 375);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(label5);
            this.Controls.Add(this.txtPersona4);
            this.Controls.Add(label4);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(label3);
            this.Controls.Add(this.txtPersona3);
            this.Controls.Add(label1);
            this.Controls.Add(this.txtPersona2);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtSocio);
            this.Controls.Add(label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblID);
            this.Controls.Add(grupoIDLabel);
            this.Controls.Add(grupoCategoriaLabel);
            this.Controls.Add(grupoSocioPpalLabel);
            this.Controls.Add(grupoApellidoLabel);
            this.Controls.Add(this.txtApellido);
            this.Name = "ModificarGrupo";
            this.Text = "ModificarGrupo";
            this.Load += new System.EventHandler(this.ModificarGrupo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grupoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.club_VistalbaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Club_VistalbaDataSet club_VistalbaDataSet;
        private System.Windows.Forms.BindingSource grupoBindingSource;
        private Club_VistalbaDataSetTableAdapters.GrupoTableAdapter grupoTableAdapter;
        private Club_VistalbaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.ComboBox cbCategoria;
        public System.Windows.Forms.TextBox txtApellido;
        public System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.TextBox txtSocio;
        public System.Windows.Forms.TextBox txtPersona2;
        public System.Windows.Forms.TextBox txtPersona3;
        public System.Windows.Forms.TextBox txtPersona4;
        public System.Windows.Forms.Label lblCantidad;
        public System.Windows.Forms.Label lblID;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private Club_VistalbaDataSetTableAdapters.CategoriaTableAdapter categoriaTableAdapter;
        private System.Windows.Forms.Button button1;
    }
}