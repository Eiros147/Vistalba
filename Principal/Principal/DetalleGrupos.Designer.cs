namespace Principal
{
    partial class DetalleGrupos
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label lblID;
            this.club_VistalbaDataSet = new Principal.Club_VistalbaDataSet();
            this.grupoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grupoTableAdapter = new Principal.Club_VistalbaDataSetTableAdapters.GrupoTableAdapter();
            this.tableAdapterManager = new Principal.Club_VistalbaDataSetTableAdapters.TableAdapterManager();
            this.grupoSocioPpalTextBox = new System.Windows.Forms.TextBox();
            this.grupoApellidoTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            grupoIDLabel = new System.Windows.Forms.Label();
            grupoCategoriaLabel = new System.Windows.Forms.Label();
            grupoSocioPpalLabel = new System.Windows.Forms.Label();
            grupoApellidoLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            lblID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.club_VistalbaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grupoIDLabel
            // 
            grupoIDLabel.AutoSize = true;
            grupoIDLabel.Location = new System.Drawing.Point(12, 15);
            grupoIDLabel.Name = "grupoIDLabel";
            grupoIDLabel.Size = new System.Drawing.Size(21, 13);
            grupoIDLabel.TabIndex = 1;
            grupoIDLabel.Text = "ID:";
            // 
            // grupoCategoriaLabel
            // 
            grupoCategoriaLabel.AutoSize = true;
            grupoCategoriaLabel.Location = new System.Drawing.Point(12, 60);
            grupoCategoriaLabel.Name = "grupoCategoriaLabel";
            grupoCategoriaLabel.Size = new System.Drawing.Size(55, 13);
            grupoCategoriaLabel.TabIndex = 3;
            grupoCategoriaLabel.Text = "Categoria:";
            // 
            // grupoSocioPpalLabel
            // 
            grupoSocioPpalLabel.AutoSize = true;
            grupoSocioPpalLabel.Location = new System.Drawing.Point(12, 86);
            grupoSocioPpalLabel.Name = "grupoSocioPpalLabel";
            grupoSocioPpalLabel.Size = new System.Drawing.Size(80, 13);
            grupoSocioPpalLabel.TabIndex = 5;
            grupoSocioPpalLabel.Text = "Socio Principal:";
            // 
            // grupoApellidoLabel
            // 
            grupoApellidoLabel.AutoSize = true;
            grupoApellidoLabel.Location = new System.Drawing.Point(12, 112);
            grupoApellidoLabel.Name = "grupoApellidoLabel";
            grupoApellidoLabel.Size = new System.Drawing.Size(47, 13);
            grupoApellidoLabel.TabIndex = 7;
            grupoApellidoLabel.Text = "Apellido:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 34);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(39, 13);
            label1.TabIndex = 9;
            label1.Text = "Grupo:";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new System.Drawing.Point(106, 15);
            lblID.Name = "lblID";
            lblID.Size = new System.Drawing.Size(48, 13);
            lblID.TabIndex = 11;
            lblID.Text = "ID grupo";
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
            this.tableAdapterManager.ProfesionalTableAdapter = null;
            this.tableAdapterManager.SaludTableAdapter = null;
            this.tableAdapterManager.SocioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Principal.Club_VistalbaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // grupoSocioPpalTextBox
            // 
            this.grupoSocioPpalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.grupoBindingSource, "grupoSocioPpal", true));
            this.grupoSocioPpalTextBox.Location = new System.Drawing.Point(109, 83);
            this.grupoSocioPpalTextBox.Name = "grupoSocioPpalTextBox";
            this.grupoSocioPpalTextBox.Size = new System.Drawing.Size(100, 20);
            this.grupoSocioPpalTextBox.TabIndex = 6;
            // 
            // grupoApellidoTextBox
            // 
            this.grupoApellidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.grupoBindingSource, "grupoApellido", true));
            this.grupoApellidoTextBox.Location = new System.Drawing.Point(109, 109);
            this.grupoApellidoTextBox.Name = "grupoApellidoTextBox";
            this.grupoApellidoTextBox.Size = new System.Drawing.Size(100, 20);
            this.grupoApellidoTextBox.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.grupoBindingSource, "grupoApellido", true));
            this.textBox1.Location = new System.Drawing.Point(109, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 10;
            // 
            // cbCategoria
            // 
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(109, 57);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(100, 21);
            this.cbCategoria.TabIndex = 12;
            // 
            // DetalleGrupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 189);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(lblID);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(label1);
            this.Controls.Add(grupoIDLabel);
            this.Controls.Add(grupoCategoriaLabel);
            this.Controls.Add(grupoSocioPpalLabel);
            this.Controls.Add(this.grupoSocioPpalTextBox);
            this.Controls.Add(grupoApellidoLabel);
            this.Controls.Add(this.grupoApellidoTextBox);
            this.Name = "DetalleGrupos";
            this.Text = "DetalleGrupos";
            this.Load += new System.EventHandler(this.DetalleGrupos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.club_VistalbaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Club_VistalbaDataSet club_VistalbaDataSet;
        private System.Windows.Forms.BindingSource grupoBindingSource;
        private Club_VistalbaDataSetTableAdapters.GrupoTableAdapter grupoTableAdapter;
        private Club_VistalbaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox grupoSocioPpalTextBox;
        private System.Windows.Forms.TextBox grupoApellidoTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cbCategoria;
    }
}