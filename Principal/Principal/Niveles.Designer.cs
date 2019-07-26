namespace Principal
{
    partial class Niveles
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.club_VistalbaDataSet = new Principal.Club_VistalbaDataSet();
            this.nivelesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nivelesTableAdapter = new Principal.Club_VistalbaDataSetTableAdapters.NivelesTableAdapter();
            this.nivelNumeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nivelNombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.club_VistalbaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nivelesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nivelNumeroDataGridViewTextBoxColumn,
            this.nivelNombreDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.nivelesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(618, 233);
            this.dataGridView1.TabIndex = 0;
            // 
            // club_VistalbaDataSet
            // 
            this.club_VistalbaDataSet.DataSetName = "Club_VistalbaDataSet";
            this.club_VistalbaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nivelesBindingSource
            // 
            this.nivelesBindingSource.DataMember = "Niveles";
            this.nivelesBindingSource.DataSource = this.club_VistalbaDataSet;
            // 
            // nivelesTableAdapter
            // 
            this.nivelesTableAdapter.ClearBeforeFill = true;
            // 
            // nivelNumeroDataGridViewTextBoxColumn
            // 
            this.nivelNumeroDataGridViewTextBoxColumn.DataPropertyName = "nivelNumero";
            this.nivelNumeroDataGridViewTextBoxColumn.HeaderText = "Numero";
            this.nivelNumeroDataGridViewTextBoxColumn.Name = "nivelNumeroDataGridViewTextBoxColumn";
            // 
            // nivelNombreDataGridViewTextBoxColumn
            // 
            this.nivelNombreDataGridViewTextBoxColumn.DataPropertyName = "nivelNombre";
            this.nivelNombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nivelNombreDataGridViewTextBoxColumn.Name = "nivelNombreDataGridViewTextBoxColumn";
            // 
            // Niveles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 305);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Niveles";
            this.Text = "Niveles";
            this.Load += new System.EventHandler(this.Niveles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.club_VistalbaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nivelesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Club_VistalbaDataSet club_VistalbaDataSet;
        private System.Windows.Forms.BindingSource nivelesBindingSource;
        private Club_VistalbaDataSetTableAdapters.NivelesTableAdapter nivelesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nivelNumeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nivelNombreDataGridViewTextBoxColumn;
    }
}