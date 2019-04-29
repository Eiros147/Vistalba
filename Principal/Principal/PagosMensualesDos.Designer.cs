namespace Principal
{
    partial class PagosMensualesDos
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
            this.club_VistalbaDataSet = new Principal.Club_VistalbaDataSet();
            this.mensualBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mensualTableAdapter = new Principal.Club_VistalbaDataSetTableAdapters.MensualTableAdapter();
            this.tableAdapterManager = new Principal.Club_VistalbaDataSetTableAdapters.TableAdapterManager();
            this.dgvPagosDos = new System.Windows.Forms.DataGridView();
            this.btnSemestre = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.club_VistalbaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mensualBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagosDos)).BeginInit();
            this.SuspendLayout();
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
            this.tableAdapterManager.ProfesionalTableAdapter = null;
            this.tableAdapterManager.SaludTableAdapter = null;
            this.tableAdapterManager.SocioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Principal.Club_VistalbaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dgvPagosDos
            // 
            this.dgvPagosDos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPagosDos.Location = new System.Drawing.Point(12, 12);
            this.dgvPagosDos.Name = "dgvPagosDos";
            this.dgvPagosDos.Size = new System.Drawing.Size(802, 367);
            this.dgvPagosDos.TabIndex = 1;
            // 
            // btnSemestre
            // 
            this.btnSemestre.Location = new System.Drawing.Point(12, 385);
            this.btnSemestre.Name = "btnSemestre";
            this.btnSemestre.Size = new System.Drawing.Size(75, 35);
            this.btnSemestre.TabIndex = 2;
            this.btnSemestre.Text = "Primer Semestre";
            this.btnSemestre.UseVisualStyleBackColor = true;
            this.btnSemestre.Click += new System.EventHandler(this.btnSemestre_Click);
            // 
            // PagosMensualesDos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 432);
            this.Controls.Add(this.btnSemestre);
            this.Controls.Add(this.dgvPagosDos);
            this.Name = "PagosMensualesDos";
            this.Text = "PagosMensualesDos";
            this.Load += new System.EventHandler(this.PagosMensualesDos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.club_VistalbaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mensualBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagosDos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Club_VistalbaDataSet club_VistalbaDataSet;
        private System.Windows.Forms.BindingSource mensualBindingSource;
        private Club_VistalbaDataSetTableAdapters.MensualTableAdapter mensualTableAdapter;
        private Club_VistalbaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dgvPagosDos;
        private System.Windows.Forms.Button btnSemestre;
    }
}