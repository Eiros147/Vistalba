namespace Principal
{
    partial class PagosMensuales
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvPagos = new System.Windows.Forms.DataGridView();
            this.btnSemestre = new System.Windows.Forms.Button();
            this.btnPagoCat = new System.Windows.Forms.Button();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clubVistalbaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.club_VistalbaDataSet = new Principal.Club_VistalbaDataSet();
            this.mensualBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mensualTableAdapter = new Principal.Club_VistalbaDataSetTableAdapters.MensualTableAdapter();
            this.tableAdapterManager = new Principal.Club_VistalbaDataSetTableAdapters.TableAdapterManager();
            this.categoriaTableAdapter = new Principal.Club_VistalbaDataSetTableAdapters.CategoriaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubVistalbaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.club_VistalbaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mensualBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(513, 381);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(422, 20);
            this.textBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 44);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dgvPagos
            // 
            this.dgvPagos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPagos.Location = new System.Drawing.Point(12, 12);
            this.dgvPagos.Name = "dgvPagos";
            this.dgvPagos.Size = new System.Drawing.Size(923, 311);
            this.dgvPagos.TabIndex = 5;
            this.dgvPagos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPagos_CellFormatting);
            // 
            // btnSemestre
            // 
            this.btnSemestre.Location = new System.Drawing.Point(97, 357);
            this.btnSemestre.Name = "btnSemestre";
            this.btnSemestre.Size = new System.Drawing.Size(79, 44);
            this.btnSemestre.TabIndex = 6;
            this.btnSemestre.Text = "Segundo Semestre";
            this.btnSemestre.UseVisualStyleBackColor = true;
            this.btnSemestre.Click += new System.EventHandler(this.btnSemestre_Click);
            // 
            // btnPagoCat
            // 
            this.btnPagoCat.Location = new System.Drawing.Point(182, 357);
            this.btnPagoCat.Name = "btnPagoCat";
            this.btnPagoCat.Size = new System.Drawing.Size(79, 44);
            this.btnPagoCat.TabIndex = 7;
            this.btnPagoCat.Text = "Por Categoria";
            this.btnPagoCat.UseVisualStyleBackColor = true;
            this.btnPagoCat.Click += new System.EventHandler(this.btnPagoCat_Click);
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataMember = "Categoria";
            this.categoriaBindingSource.DataSource = this.clubVistalbaDataSetBindingSource;
            // 
            // clubVistalbaDataSetBindingSource
            // 
            this.clubVistalbaDataSetBindingSource.DataSource = this.club_VistalbaDataSet;
            this.clubVistalbaDataSetBindingSource.Position = 0;
            // 
            // club_VistalbaDataSet
            // 
            this.club_VistalbaDataSet.DataSetName = "Club_VistalbaDataSet";
            this.club_VistalbaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mensualBindingSource
            // 
            this.mensualBindingSource.DataMember = "Mensual";
            this.mensualBindingSource.DataSource = this.club_VistalbaDataSet;
            // 
            // mensualTableAdapter
            // 
            this.mensualTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ActividadesTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriaTableAdapter = null;
            this.tableAdapterManager.CuotaTableAdapter = null;
            this.tableAdapterManager.GrupoTableAdapter = null;
            this.tableAdapterManager.MensualTableAdapter = this.mensualTableAdapter;
            this.tableAdapterManager.NivelesTableAdapter = null;
            this.tableAdapterManager.ProfesionalTableAdapter = null;
            this.tableAdapterManager.SaludTableAdapter = null;
            this.tableAdapterManager.SocioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Principal.Club_VistalbaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ValorFijoTableAdapter = null;
            // 
            // categoriaTableAdapter
            // 
            this.categoriaTableAdapter.ClearBeforeFill = true;
            // 
            // PagosMensuales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 421);
            this.Controls.Add(this.btnPagoCat);
            this.Controls.Add(this.btnSemestre);
            this.Controls.Add(this.dgvPagos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "PagosMensuales";
            this.Text = "PagosMensuales";
            this.Load += new System.EventHandler(this.PagosMensuales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubVistalbaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.club_VistalbaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mensualBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Club_VistalbaDataSet club_VistalbaDataSet;
        private System.Windows.Forms.BindingSource mensualBindingSource;
        private Club_VistalbaDataSetTableAdapters.MensualTableAdapter mensualTableAdapter;
        private Club_VistalbaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource clubVistalbaDataSetBindingSource;
        private System.Windows.Forms.DataGridView dgvPagos;
        private System.Windows.Forms.Button btnSemestre;
        private System.Windows.Forms.Button btnPagoCat;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private Club_VistalbaDataSetTableAdapters.CategoriaTableAdapter categoriaTableAdapter;
    }
}