namespace Principal
{
    partial class ModificarCategoria
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
            System.Windows.Forms.Label catIDLabel;
            System.Windows.Forms.Label catDescLabel;
            System.Windows.Forms.Label catNombreLabel;
            System.Windows.Forms.Label catMesActLabel;
            System.Windows.Forms.Label catMesInactLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            this.club_VistalbaDataSet = new Principal.Club_VistalbaDataSet();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriaTableAdapter = new Principal.Club_VistalbaDataSetTableAdapters.CategoriaTableAdapter();
            this.tableAdapterManager = new Principal.Club_VistalbaDataSetTableAdapters.TableAdapterManager();
            this.v = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtMesAct = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtMesInact = new System.Windows.Forms.TextBox();
            this.cbCant = new System.Windows.Forms.ComboBox();
            this.txtMesInact2 = new System.Windows.Forms.TextBox();
            this.txtMesAct2 = new System.Windows.Forms.TextBox();
            this.txtSeguro2 = new System.Windows.Forms.TextBox();
            this.txtSeguro = new System.Windows.Forms.TextBox();
            this.txtDerecho2 = new System.Windows.Forms.TextBox();
            this.txtDerecho = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            catIDLabel = new System.Windows.Forms.Label();
            catDescLabel = new System.Windows.Forms.Label();
            catNombreLabel = new System.Windows.Forms.Label();
            catMesActLabel = new System.Windows.Forms.Label();
            catMesInactLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.club_VistalbaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // catIDLabel
            // 
            catIDLabel.AutoSize = true;
            catIDLabel.Location = new System.Drawing.Point(12, 9);
            catIDLabel.Name = "catIDLabel";
            catIDLabel.Size = new System.Drawing.Size(21, 13);
            catIDLabel.TabIndex = 5;
            catIDLabel.Text = "ID:";
            // 
            // catDescLabel
            // 
            catDescLabel.AutoSize = true;
            catDescLabel.Location = new System.Drawing.Point(12, 35);
            catDescLabel.Name = "catDescLabel";
            catDescLabel.Size = new System.Drawing.Size(66, 13);
            catDescLabel.TabIndex = 7;
            catDescLabel.Text = "Descripción:";
            // 
            // catNombreLabel
            // 
            catNombreLabel.AutoSize = true;
            catNombreLabel.Location = new System.Drawing.Point(12, 61);
            catNombreLabel.Name = "catNombreLabel";
            catNombreLabel.Size = new System.Drawing.Size(47, 13);
            catNombreLabel.TabIndex = 9;
            catNombreLabel.Text = "Nombre:";
            // 
            // catMesActLabel
            // 
            catMesActLabel.AutoSize = true;
            catMesActLabel.Location = new System.Drawing.Point(12, 129);
            catMesActLabel.Name = "catMesActLabel";
            catMesActLabel.Size = new System.Drawing.Size(79, 13);
            catMesActLabel.TabIndex = 11;
            catMesActLabel.Text = "Meses Activos:";
            // 
            // catMesInactLabel
            // 
            catMesInactLabel.AutoSize = true;
            catMesInactLabel.Location = new System.Drawing.Point(12, 227);
            catMesInactLabel.Name = "catMesInactLabel";
            catMesInactLabel.Size = new System.Drawing.Size(98, 13);
            catMesInactLabel.TabIndex = 13;
            catMesInactLabel.Text = "Cantidad personas:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 155);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(87, 13);
            label1.TabIndex = 18;
            label1.Text = "Meses Inactivos:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 181);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(44, 13);
            label2.TabIndex = 23;
            label2.Text = "Seguro:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(12, 207);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(51, 13);
            label3.TabIndex = 26;
            label3.Text = "Derecho:";
            // 
            // club_VistalbaDataSet
            // 
            this.club_VistalbaDataSet.DataSetName = "Club_VistalbaDataSet";
            this.club_VistalbaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.ActividadesTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriaTableAdapter = this.categoriaTableAdapter;
            this.tableAdapterManager.CuotaTableAdapter = null;
            this.tableAdapterManager.GrupoTableAdapter = null;
            this.tableAdapterManager.MensualTableAdapter = null;
            this.tableAdapterManager.NivelesTableAdapter = null;
            this.tableAdapterManager.ProfesionalTableAdapter = null;
            this.tableAdapterManager.SaludTableAdapter = null;
            this.tableAdapterManager.SocioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Principal.Club_VistalbaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ValorFijoTableAdapter = null;
            // 
            // v
            // 
            this.v.Location = new System.Drawing.Point(12, 251);
            this.v.Name = "v";
            this.v.Size = new System.Drawing.Size(75, 40);
            this.v.TabIndex = 4;
            this.v.Text = "Guardar";
            this.v.UseVisualStyleBackColor = true;
            this.v.Click += new System.EventHandler(this.v_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(307, 251);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 40);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriaBindingSource, "catDesc", true));
            this.txtDescripcion.Location = new System.Drawing.Point(130, 28);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(252, 20);
            this.txtDescripcion.TabIndex = 8;
            // 
            // txtNombre
            // 
            this.txtNombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriaBindingSource, "catNombre", true));
            this.txtNombre.Location = new System.Drawing.Point(130, 54);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(252, 20);
            this.txtNombre.TabIndex = 10;
            // 
            // txtMesAct
            // 
            this.txtMesAct.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriaBindingSource, "catMesAct", true));
            this.txtMesAct.Location = new System.Drawing.Point(130, 122);
            this.txtMesAct.Name = "txtMesAct";
            this.txtMesAct.Size = new System.Drawing.Size(118, 20);
            this.txtMesAct.TabIndex = 12;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(127, 9);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(66, 13);
            this.lblID.TabIndex = 16;
            this.lblID.Text = "ID Categoria";
            // 
            // txtMesInact
            // 
            this.txtMesInact.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriaBindingSource, "catMesAct", true));
            this.txtMesInact.Location = new System.Drawing.Point(130, 148);
            this.txtMesInact.Name = "txtMesInact";
            this.txtMesInact.Size = new System.Drawing.Size(118, 20);
            this.txtMesInact.TabIndex = 19;
            // 
            // cbCant
            // 
            this.cbCant.FormattingEnabled = true;
            this.cbCant.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbCant.Location = new System.Drawing.Point(130, 224);
            this.cbCant.Name = "cbCant";
            this.cbCant.Size = new System.Drawing.Size(252, 21);
            this.cbCant.TabIndex = 20;
            // 
            // txtMesInact2
            // 
            this.txtMesInact2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriaBindingSource, "catMesAct", true));
            this.txtMesInact2.Location = new System.Drawing.Point(272, 148);
            this.txtMesInact2.Name = "txtMesInact2";
            this.txtMesInact2.Size = new System.Drawing.Size(110, 20);
            this.txtMesInact2.TabIndex = 22;
            // 
            // txtMesAct2
            // 
            this.txtMesAct2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriaBindingSource, "catMesAct", true));
            this.txtMesAct2.Location = new System.Drawing.Point(272, 122);
            this.txtMesAct2.Name = "txtMesAct2";
            this.txtMesAct2.Size = new System.Drawing.Size(110, 20);
            this.txtMesAct2.TabIndex = 21;
            // 
            // txtSeguro2
            // 
            this.txtSeguro2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriaBindingSource, "catMesAct", true));
            this.txtSeguro2.Location = new System.Drawing.Point(272, 174);
            this.txtSeguro2.Name = "txtSeguro2";
            this.txtSeguro2.Size = new System.Drawing.Size(110, 20);
            this.txtSeguro2.TabIndex = 25;
            // 
            // txtSeguro
            // 
            this.txtSeguro.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriaBindingSource, "catMesAct", true));
            this.txtSeguro.Location = new System.Drawing.Point(130, 174);
            this.txtSeguro.Name = "txtSeguro";
            this.txtSeguro.Size = new System.Drawing.Size(118, 20);
            this.txtSeguro.TabIndex = 24;
            // 
            // txtDerecho2
            // 
            this.txtDerecho2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriaBindingSource, "catMesAct", true));
            this.txtDerecho2.Location = new System.Drawing.Point(272, 200);
            this.txtDerecho2.Name = "txtDerecho2";
            this.txtDerecho2.Size = new System.Drawing.Size(110, 20);
            this.txtDerecho2.TabIndex = 28;
            // 
            // txtDerecho
            // 
            this.txtDerecho.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriaBindingSource, "catMesAct", true));
            this.txtDerecho.Location = new System.Drawing.Point(130, 200);
            this.txtDerecho.Name = "txtDerecho";
            this.txtDerecho.Size = new System.Drawing.Size(118, 20);
            this.txtDerecho.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(147, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Primer Semestre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(279, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Segundo Semestre";
            // 
            // ModificarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 303);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDerecho2);
            this.Controls.Add(label3);
            this.Controls.Add(this.txtDerecho);
            this.Controls.Add(this.txtSeguro2);
            this.Controls.Add(label2);
            this.Controls.Add(this.txtSeguro);
            this.Controls.Add(this.txtMesInact2);
            this.Controls.Add(this.txtMesAct2);
            this.Controls.Add(this.cbCant);
            this.Controls.Add(label1);
            this.Controls.Add(this.txtMesInact);
            this.Controls.Add(this.lblID);
            this.Controls.Add(catIDLabel);
            this.Controls.Add(catDescLabel);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(catNombreLabel);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(catMesActLabel);
            this.Controls.Add(this.txtMesAct);
            this.Controls.Add(catMesInactLabel);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.v);
            this.Name = "ModificarCategoria";
            this.Text = "Modificar Tipo de Socio";
            this.Load += new System.EventHandler(this.ModificarCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.club_VistalbaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Club_VistalbaDataSet club_VistalbaDataSet;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private Club_VistalbaDataSetTableAdapters.CategoriaTableAdapter categoriaTableAdapter;
        private Club_VistalbaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button v;
        private System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.TextBox txtDescripcion;
        public System.Windows.Forms.Label lblID;
        public System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.TextBox txtMesAct;
        public System.Windows.Forms.TextBox txtMesInact;
        public System.Windows.Forms.ComboBox cbCant;
        public System.Windows.Forms.TextBox txtMesInact2;
        public System.Windows.Forms.TextBox txtMesAct2;
        public System.Windows.Forms.TextBox txtSeguro2;
        public System.Windows.Forms.TextBox txtSeguro;
        public System.Windows.Forms.TextBox txtDerecho2;
        public System.Windows.Forms.TextBox txtDerecho;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}