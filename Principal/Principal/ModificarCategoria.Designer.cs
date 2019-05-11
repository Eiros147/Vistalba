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
            System.Windows.Forms.Label catClubCardLabel;
            this.club_VistalbaDataSet = new Principal.Club_VistalbaDataSet();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriaTableAdapter = new Principal.Club_VistalbaDataSetTableAdapters.CategoriaTableAdapter();
            this.tableAdapterManager = new Principal.Club_VistalbaDataSetTableAdapters.TableAdapterManager();
            this.v = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtMesAct = new System.Windows.Forms.TextBox();
            this.txtMesInact = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            catIDLabel = new System.Windows.Forms.Label();
            catDescLabel = new System.Windows.Forms.Label();
            catNombreLabel = new System.Windows.Forms.Label();
            catMesActLabel = new System.Windows.Forms.Label();
            catMesInactLabel = new System.Windows.Forms.Label();
            catClubCardLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.club_VistalbaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.tableAdapterManager.ProfesionalTableAdapter = null;
            this.tableAdapterManager.SaludTableAdapter = null;
            this.tableAdapterManager.SocioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Principal.Club_VistalbaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // v
            // 
            this.v.Location = new System.Drawing.Point(12, 180);
            this.v.Name = "v";
            this.v.Size = new System.Drawing.Size(75, 31);
            this.v.TabIndex = 4;
            this.v.Text = "Guardar";
            this.v.UseVisualStyleBackColor = true;
            this.v.Click += new System.EventHandler(this.v_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(130, 180);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 31);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // catIDLabel
            // 
            catIDLabel.AutoSize = true;
            catIDLabel.Location = new System.Drawing.Point(12, 18);
            catIDLabel.Name = "catIDLabel";
            catIDLabel.Size = new System.Drawing.Size(21, 13);
            catIDLabel.TabIndex = 5;
            catIDLabel.Text = "ID:";
            // 
            // catDescLabel
            // 
            catDescLabel.AutoSize = true;
            catDescLabel.Location = new System.Drawing.Point(12, 44);
            catDescLabel.Name = "catDescLabel";
            catDescLabel.Size = new System.Drawing.Size(66, 13);
            catDescLabel.TabIndex = 7;
            catDescLabel.Text = "Descripción:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriaBindingSource, "catDesc", true));
            this.txtDescripcion.Location = new System.Drawing.Point(105, 37);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcion.TabIndex = 8;
            // 
            // catNombreLabel
            // 
            catNombreLabel.AutoSize = true;
            catNombreLabel.Location = new System.Drawing.Point(12, 70);
            catNombreLabel.Name = "catNombreLabel";
            catNombreLabel.Size = new System.Drawing.Size(47, 13);
            catNombreLabel.TabIndex = 9;
            catNombreLabel.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriaBindingSource, "catNombre", true));
            this.txtNombre.Location = new System.Drawing.Point(105, 63);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 10;
            // 
            // catMesActLabel
            // 
            catMesActLabel.AutoSize = true;
            catMesActLabel.Location = new System.Drawing.Point(12, 96);
            catMesActLabel.Name = "catMesActLabel";
            catMesActLabel.Size = new System.Drawing.Size(79, 13);
            catMesActLabel.TabIndex = 11;
            catMesActLabel.Text = "Meses Activos:";
            // 
            // txtMesAct
            // 
            this.txtMesAct.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriaBindingSource, "catMesAct", true));
            this.txtMesAct.Location = new System.Drawing.Point(105, 89);
            this.txtMesAct.Name = "txtMesAct";
            this.txtMesAct.Size = new System.Drawing.Size(100, 20);
            this.txtMesAct.TabIndex = 12;
            // 
            // catMesInactLabel
            // 
            catMesInactLabel.AutoSize = true;
            catMesInactLabel.Location = new System.Drawing.Point(12, 122);
            catMesInactLabel.Name = "catMesInactLabel";
            catMesInactLabel.Size = new System.Drawing.Size(87, 13);
            catMesInactLabel.TabIndex = 13;
            catMesInactLabel.Text = "Meses Inactivos:";
            // 
            // txtMesInact
            // 
            this.txtMesInact.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriaBindingSource, "catMesInact", true));
            this.txtMesInact.Location = new System.Drawing.Point(105, 115);
            this.txtMesInact.Name = "txtMesInact";
            this.txtMesInact.Size = new System.Drawing.Size(100, 20);
            this.txtMesInact.TabIndex = 14;
            // 
            // catClubCardLabel
            // 
            catClubCardLabel.AutoSize = true;
            catClubCardLabel.Location = new System.Drawing.Point(12, 148);
            catClubCardLabel.Name = "catClubCardLabel";
            catClubCardLabel.Size = new System.Drawing.Size(56, 13);
            catClubCardLabel.TabIndex = 15;
            catClubCardLabel.Text = "Club Card:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(102, 18);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(66, 13);
            this.lblID.TabIndex = 16;
            this.lblID.Text = "ID Categoria";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(105, 147);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(92, 17);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "Con Beneficio";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // ModificarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 239);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lblID);
            this.Controls.Add(catIDLabel);
            this.Controls.Add(catDescLabel);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(catNombreLabel);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(catMesActLabel);
            this.Controls.Add(this.txtMesAct);
            this.Controls.Add(catMesInactLabel);
            this.Controls.Add(this.txtMesInact);
            this.Controls.Add(catClubCardLabel);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.v);
            this.Name = "ModificarCategoria";
            this.Text = "ModificarCategoria";
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
        private System.Windows.Forms.CheckBox checkBox1;
        public System.Windows.Forms.TextBox txtDescripcion;
        public System.Windows.Forms.Label lblID;
        public System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.TextBox txtMesAct;
        public System.Windows.Forms.TextBox txtMesInact;
    }
}