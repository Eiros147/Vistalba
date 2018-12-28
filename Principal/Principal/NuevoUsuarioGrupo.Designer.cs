namespace Principal
{
    partial class NuevoUsuarioGrupo
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
            System.Windows.Forms.Label grupoCantLabel;
            System.Windows.Forms.Label catIDLabel;
            System.Windows.Forms.Label label1;
            this.club_VistalbaDataSet = new Principal.Club_VistalbaDataSet();
            this.grupoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grupoTableAdapter = new Principal.Club_VistalbaDataSetTableAdapters.GrupoTableAdapter();
            this.tableAdapterManager = new Principal.Club_VistalbaDataSetTableAdapters.TableAdapterManager();
            this.grupoApellidoTextBox = new System.Windows.Forms.TextBox();
            this.grupoCantTextBox = new System.Windows.Forms.TextBox();
            this.cuotaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cuotaTableAdapter = new Principal.Club_VistalbaDataSetTableAdapters.CuotaTableAdapter();
            this.catIDTextBox = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            grupoApellidoLabel = new System.Windows.Forms.Label();
            grupoCantLabel = new System.Windows.Forms.Label();
            catIDLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.club_VistalbaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuotaBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.tableAdapterManager.CuotaTableAdapter = this.cuotaTableAdapter;
            this.tableAdapterManager.GrupoTableAdapter = this.grupoTableAdapter;
            this.tableAdapterManager.ProfesionalTableAdapter = null;
            this.tableAdapterManager.SaludTableAdapter = null;
            this.tableAdapterManager.SocioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Principal.Club_VistalbaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // grupoApellidoLabel
            // 
            grupoApellidoLabel.AutoSize = true;
            grupoApellidoLabel.Location = new System.Drawing.Point(13, 29);
            grupoApellidoLabel.Name = "grupoApellidoLabel";
            grupoApellidoLabel.Size = new System.Drawing.Size(47, 13);
            grupoApellidoLabel.TabIndex = 1;
            grupoApellidoLabel.Text = "Apellido:";
            // 
            // grupoApellidoTextBox
            // 
            this.grupoApellidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.grupoBindingSource, "grupoApellido", true));
            this.grupoApellidoTextBox.Location = new System.Drawing.Point(127, 26);
            this.grupoApellidoTextBox.Name = "grupoApellidoTextBox";
            this.grupoApellidoTextBox.Size = new System.Drawing.Size(141, 20);
            this.grupoApellidoTextBox.TabIndex = 2;
            // 
            // grupoCantLabel
            // 
            grupoCantLabel.AutoSize = true;
            grupoCantLabel.Location = new System.Drawing.Point(13, 55);
            grupoCantLabel.Name = "grupoCantLabel";
            grupoCantLabel.Size = new System.Drawing.Size(108, 13);
            grupoCantLabel.TabIndex = 2;
            grupoCantLabel.Text = "Cantidad Integrantes:";
            // 
            // grupoCantTextBox
            // 
            this.grupoCantTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.grupoBindingSource, "grupoCant", true));
            this.grupoCantTextBox.Location = new System.Drawing.Point(127, 52);
            this.grupoCantTextBox.Name = "grupoCantTextBox";
            this.grupoCantTextBox.Size = new System.Drawing.Size(141, 20);
            this.grupoCantTextBox.TabIndex = 3;
            // 
            // cuotaBindingSource
            // 
            this.cuotaBindingSource.DataMember = "GrupoCuota";
            this.cuotaBindingSource.DataSource = this.grupoBindingSource;
            // 
            // cuotaTableAdapter
            // 
            this.cuotaTableAdapter.ClearBeforeFill = true;
            // 
            // catIDLabel
            // 
            catIDLabel.AutoSize = true;
            catIDLabel.Location = new System.Drawing.Point(13, 81);
            catIDLabel.Name = "catIDLabel";
            catIDLabel.Size = new System.Drawing.Size(55, 13);
            catIDLabel.TabIndex = 4;
            catIDLabel.Text = "Categoria:";
            // 
            // catIDTextBox
            // 
            this.catIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cuotaBindingSource, "catID", true));
            this.catIDTextBox.Location = new System.Drawing.Point(127, 78);
            this.catIDTextBox.Name = "catIDTextBox";
            this.catIDTextBox.Size = new System.Drawing.Size(141, 20);
            this.catIDTextBox.TabIndex = 5;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(127, 104);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(141, 95);
            this.listBox1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(13, 113);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(63, 13);
            label1.TabIndex = 7;
            label1.Text = "Integrantes:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 8;
            this.button1.Text = "Siguiente";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(197, 223);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 29);
            this.button2.TabIndex = 9;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // NuevoUsuarioGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 269);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(catIDLabel);
            this.Controls.Add(this.catIDTextBox);
            this.Controls.Add(grupoCantLabel);
            this.Controls.Add(this.grupoCantTextBox);
            this.Controls.Add(grupoApellidoLabel);
            this.Controls.Add(this.grupoApellidoTextBox);
            this.Name = "NuevoUsuarioGrupo";
            this.Text = "NuevoUsuarioGrupo";
            this.Load += new System.EventHandler(this.NuevoUsuarioGrupo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.club_VistalbaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuotaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Club_VistalbaDataSet club_VistalbaDataSet;
        private System.Windows.Forms.BindingSource grupoBindingSource;
        private Club_VistalbaDataSetTableAdapters.GrupoTableAdapter grupoTableAdapter;
        private Club_VistalbaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Club_VistalbaDataSetTableAdapters.CuotaTableAdapter cuotaTableAdapter;
        private System.Windows.Forms.TextBox grupoApellidoTextBox;
        private System.Windows.Forms.TextBox grupoCantTextBox;
        private System.Windows.Forms.BindingSource cuotaBindingSource;
        private System.Windows.Forms.TextBox catIDTextBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}