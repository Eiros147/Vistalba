namespace Principal
{
    partial class NuevaCategoria
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
            System.Windows.Forms.Label label1;
            this.club_VistalbaDataSet = new Principal.Club_VistalbaDataSet();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriaTableAdapter = new Principal.Club_VistalbaDataSetTableAdapters.CategoriaTableAdapter();
            this.tableAdapterManager = new Principal.Club_VistalbaDataSetTableAdapters.TableAdapterManager();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtMesAct = new System.Windows.Forms.TextBox();
            this.txtMesInact = new System.Windows.Forms.TextBox();
            this.lblCatID = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.cbCard = new System.Windows.Forms.CheckBox();
            this.cbCant = new System.Windows.Forms.ComboBox();
            catIDLabel = new System.Windows.Forms.Label();
            catDescLabel = new System.Windows.Forms.Label();
            catNombreLabel = new System.Windows.Forms.Label();
            catMesActLabel = new System.Windows.Forms.Label();
            catMesInactLabel = new System.Windows.Forms.Label();
            catClubCardLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.club_VistalbaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // catIDLabel
            // 
            catIDLabel.AutoSize = true;
            catIDLabel.Location = new System.Drawing.Point(12, 19);
            catIDLabel.Name = "catIDLabel";
            catIDLabel.Size = new System.Drawing.Size(21, 13);
            catIDLabel.TabIndex = 1;
            catIDLabel.Text = "ID:";
            // 
            // catDescLabel
            // 
            catDescLabel.AutoSize = true;
            catDescLabel.Location = new System.Drawing.Point(12, 45);
            catDescLabel.Name = "catDescLabel";
            catDescLabel.Size = new System.Drawing.Size(66, 13);
            catDescLabel.TabIndex = 3;
            catDescLabel.Text = "Descripción:";
            // 
            // catNombreLabel
            // 
            catNombreLabel.AutoSize = true;
            catNombreLabel.Location = new System.Drawing.Point(12, 71);
            catNombreLabel.Name = "catNombreLabel";
            catNombreLabel.Size = new System.Drawing.Size(47, 13);
            catNombreLabel.TabIndex = 5;
            catNombreLabel.Text = "Nombre:";
            // 
            // catMesActLabel
            // 
            catMesActLabel.AutoSize = true;
            catMesActLabel.Location = new System.Drawing.Point(12, 97);
            catMesActLabel.Name = "catMesActLabel";
            catMesActLabel.Size = new System.Drawing.Size(79, 13);
            catMesActLabel.TabIndex = 7;
            catMesActLabel.Text = "Meses Activos:";
            // 
            // catMesInactLabel
            // 
            catMesInactLabel.AutoSize = true;
            catMesInactLabel.Location = new System.Drawing.Point(12, 123);
            catMesInactLabel.Name = "catMesInactLabel";
            catMesInactLabel.Size = new System.Drawing.Size(87, 13);
            catMesInactLabel.TabIndex = 9;
            catMesInactLabel.Text = "Meses Inactivos:";
            // 
            // catClubCardLabel
            // 
            catClubCardLabel.AutoSize = true;
            catClubCardLabel.Location = new System.Drawing.Point(12, 173);
            catClubCardLabel.Name = "catClubCardLabel";
            catClubCardLabel.Size = new System.Drawing.Size(56, 13);
            catClubCardLabel.TabIndex = 11;
            catClubCardLabel.Text = "Club Card:";
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
            // txtDescripcion
            // 
            this.txtDescripcion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriaBindingSource, "catDesc", true));
            this.txtDescripcion.Location = new System.Drawing.Point(117, 42);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(183, 20);
            this.txtDescripcion.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriaBindingSource, "catNombre", true));
            this.txtNombre.Location = new System.Drawing.Point(117, 68);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(183, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // txtMesAct
            // 
            this.txtMesAct.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriaBindingSource, "catMesAct", true));
            this.txtMesAct.Location = new System.Drawing.Point(117, 94);
            this.txtMesAct.Name = "txtMesAct";
            this.txtMesAct.Size = new System.Drawing.Size(183, 20);
            this.txtMesAct.TabIndex = 8;
            // 
            // txtMesInact
            // 
            this.txtMesInact.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriaBindingSource, "catMesInact", true));
            this.txtMesInact.Location = new System.Drawing.Point(117, 120);
            this.txtMesInact.Name = "txtMesInact";
            this.txtMesInact.Size = new System.Drawing.Size(183, 20);
            this.txtMesInact.TabIndex = 10;
            // 
            // lblCatID
            // 
            this.lblCatID.AutoSize = true;
            this.lblCatID.Location = new System.Drawing.Point(114, 19);
            this.lblCatID.Name = "lblCatID";
            this.lblCatID.Size = new System.Drawing.Size(35, 13);
            this.lblCatID.TabIndex = 13;
            this.lblCatID.Text = "label1";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(12, 188);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 35);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(225, 188);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 35);
            this.btnCerrar.TabIndex = 15;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // cbCard
            // 
            this.cbCard.AutoSize = true;
            this.cbCard.Location = new System.Drawing.Point(117, 172);
            this.cbCard.Name = "cbCard";
            this.cbCard.Size = new System.Drawing.Size(92, 17);
            this.cbCard.TabIndex = 16;
            this.cbCard.Text = "Sin beneficios";
            this.cbCard.UseVisualStyleBackColor = true;
            this.cbCard.CheckedChanged += new System.EventHandler(this.cbCard_CheckedChanged);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 149);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(99, 13);
            label1.TabIndex = 17;
            label1.Text = "Cantidad Personas:";
            // 
            // cbCant
            // 
            this.cbCant.FormattingEnabled = true;
            this.cbCant.Location = new System.Drawing.Point(117, 145);
            this.cbCant.Name = "cbCant";
            this.cbCant.Size = new System.Drawing.Size(183, 21);
            this.cbCant.TabIndex = 18;
            // 
            // NuevaCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 239);
            this.Controls.Add(this.cbCant);
            this.Controls.Add(label1);
            this.Controls.Add(this.cbCard);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblCatID);
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
            this.Name = "NuevaCategoria";
            this.Text = "NuevaCategoria";
            this.Load += new System.EventHandler(this.NuevaCategoria_Load);
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
        public System.Windows.Forms.Label lblCatID;
        public System.Windows.Forms.TextBox txtDescripcion;
        public System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.TextBox txtMesAct;
        public System.Windows.Forms.TextBox txtMesInact;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.CheckBox cbCard;
        public System.Windows.Forms.ComboBox cbCant;
    }
}