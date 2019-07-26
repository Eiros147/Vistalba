namespace Principal
{
    partial class PagosPorCategoria
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
            this.mensualBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mensualTableAdapter = new Principal.Club_VistalbaDataSetTableAdapters.MensualTableAdapter();
            this.catIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesEneroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesFebreroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesMarzoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesAbrilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesMayoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesJunioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesJulioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesAgostoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesSeptiembreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesOctubreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesNoviembreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesDiciembreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesTotalPagoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.club_VistalbaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mensualBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.catIDDataGridViewTextBoxColumn,
            this.mesEneroDataGridViewTextBoxColumn,
            this.mesFebreroDataGridViewTextBoxColumn,
            this.mesMarzoDataGridViewTextBoxColumn,
            this.mesAbrilDataGridViewTextBoxColumn,
            this.mesMayoDataGridViewTextBoxColumn,
            this.mesJunioDataGridViewTextBoxColumn,
            this.mesJulioDataGridViewTextBoxColumn,
            this.mesAgostoDataGridViewTextBoxColumn,
            this.mesSeptiembreDataGridViewTextBoxColumn,
            this.mesOctubreDataGridViewTextBoxColumn,
            this.mesNoviembreDataGridViewTextBoxColumn,
            this.mesDiciembreDataGridViewTextBoxColumn,
            this.mesTotalDataGridViewTextBoxColumn,
            this.mesTotalPagoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mensualBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(740, 423);
            this.dataGridView1.TabIndex = 0;
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
            // catIDDataGridViewTextBoxColumn
            // 
            this.catIDDataGridViewTextBoxColumn.DataPropertyName = "catID";
            this.catIDDataGridViewTextBoxColumn.HeaderText = "catID";
            this.catIDDataGridViewTextBoxColumn.Name = "catIDDataGridViewTextBoxColumn";
            // 
            // mesEneroDataGridViewTextBoxColumn
            // 
            this.mesEneroDataGridViewTextBoxColumn.DataPropertyName = "mesEnero";
            this.mesEneroDataGridViewTextBoxColumn.HeaderText = "mesEnero";
            this.mesEneroDataGridViewTextBoxColumn.Name = "mesEneroDataGridViewTextBoxColumn";
            // 
            // mesFebreroDataGridViewTextBoxColumn
            // 
            this.mesFebreroDataGridViewTextBoxColumn.DataPropertyName = "mesFebrero";
            this.mesFebreroDataGridViewTextBoxColumn.HeaderText = "mesFebrero";
            this.mesFebreroDataGridViewTextBoxColumn.Name = "mesFebreroDataGridViewTextBoxColumn";
            // 
            // mesMarzoDataGridViewTextBoxColumn
            // 
            this.mesMarzoDataGridViewTextBoxColumn.DataPropertyName = "mesMarzo";
            this.mesMarzoDataGridViewTextBoxColumn.HeaderText = "mesMarzo";
            this.mesMarzoDataGridViewTextBoxColumn.Name = "mesMarzoDataGridViewTextBoxColumn";
            // 
            // mesAbrilDataGridViewTextBoxColumn
            // 
            this.mesAbrilDataGridViewTextBoxColumn.DataPropertyName = "mesAbril";
            this.mesAbrilDataGridViewTextBoxColumn.HeaderText = "mesAbril";
            this.mesAbrilDataGridViewTextBoxColumn.Name = "mesAbrilDataGridViewTextBoxColumn";
            // 
            // mesMayoDataGridViewTextBoxColumn
            // 
            this.mesMayoDataGridViewTextBoxColumn.DataPropertyName = "mesMayo";
            this.mesMayoDataGridViewTextBoxColumn.HeaderText = "mesMayo";
            this.mesMayoDataGridViewTextBoxColumn.Name = "mesMayoDataGridViewTextBoxColumn";
            // 
            // mesJunioDataGridViewTextBoxColumn
            // 
            this.mesJunioDataGridViewTextBoxColumn.DataPropertyName = "mesJunio";
            this.mesJunioDataGridViewTextBoxColumn.HeaderText = "mesJunio";
            this.mesJunioDataGridViewTextBoxColumn.Name = "mesJunioDataGridViewTextBoxColumn";
            // 
            // mesJulioDataGridViewTextBoxColumn
            // 
            this.mesJulioDataGridViewTextBoxColumn.DataPropertyName = "mesJulio";
            this.mesJulioDataGridViewTextBoxColumn.HeaderText = "mesJulio";
            this.mesJulioDataGridViewTextBoxColumn.Name = "mesJulioDataGridViewTextBoxColumn";
            // 
            // mesAgostoDataGridViewTextBoxColumn
            // 
            this.mesAgostoDataGridViewTextBoxColumn.DataPropertyName = "mesAgosto";
            this.mesAgostoDataGridViewTextBoxColumn.HeaderText = "mesAgosto";
            this.mesAgostoDataGridViewTextBoxColumn.Name = "mesAgostoDataGridViewTextBoxColumn";
            // 
            // mesSeptiembreDataGridViewTextBoxColumn
            // 
            this.mesSeptiembreDataGridViewTextBoxColumn.DataPropertyName = "mesSeptiembre";
            this.mesSeptiembreDataGridViewTextBoxColumn.HeaderText = "mesSeptiembre";
            this.mesSeptiembreDataGridViewTextBoxColumn.Name = "mesSeptiembreDataGridViewTextBoxColumn";
            // 
            // mesOctubreDataGridViewTextBoxColumn
            // 
            this.mesOctubreDataGridViewTextBoxColumn.DataPropertyName = "mesOctubre";
            this.mesOctubreDataGridViewTextBoxColumn.HeaderText = "mesOctubre";
            this.mesOctubreDataGridViewTextBoxColumn.Name = "mesOctubreDataGridViewTextBoxColumn";
            // 
            // mesNoviembreDataGridViewTextBoxColumn
            // 
            this.mesNoviembreDataGridViewTextBoxColumn.DataPropertyName = "mesNoviembre";
            this.mesNoviembreDataGridViewTextBoxColumn.HeaderText = "mesNoviembre";
            this.mesNoviembreDataGridViewTextBoxColumn.Name = "mesNoviembreDataGridViewTextBoxColumn";
            // 
            // mesDiciembreDataGridViewTextBoxColumn
            // 
            this.mesDiciembreDataGridViewTextBoxColumn.DataPropertyName = "mesDiciembre";
            this.mesDiciembreDataGridViewTextBoxColumn.HeaderText = "mesDiciembre";
            this.mesDiciembreDataGridViewTextBoxColumn.Name = "mesDiciembreDataGridViewTextBoxColumn";
            // 
            // mesTotalDataGridViewTextBoxColumn
            // 
            this.mesTotalDataGridViewTextBoxColumn.DataPropertyName = "mesTotal";
            this.mesTotalDataGridViewTextBoxColumn.HeaderText = "mesTotal";
            this.mesTotalDataGridViewTextBoxColumn.Name = "mesTotalDataGridViewTextBoxColumn";
            // 
            // mesTotalPagoDataGridViewTextBoxColumn
            // 
            this.mesTotalPagoDataGridViewTextBoxColumn.DataPropertyName = "mesTotalPago";
            this.mesTotalPagoDataGridViewTextBoxColumn.HeaderText = "mesTotalPago";
            this.mesTotalPagoDataGridViewTextBoxColumn.Name = "mesTotalPagoDataGridViewTextBoxColumn";
            // 
            // PagosPorCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 491);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PagosPorCategoria";
            this.Text = "PagosPorCategoria";
            this.Load += new System.EventHandler(this.PagosPorCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.club_VistalbaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mensualBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Club_VistalbaDataSet club_VistalbaDataSet;
        private System.Windows.Forms.BindingSource mensualBindingSource;
        private Club_VistalbaDataSetTableAdapters.MensualTableAdapter mensualTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn catIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesEneroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesFebreroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesMarzoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesAbrilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesMayoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesJunioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesJulioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesAgostoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesSeptiembreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesOctubreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesNoviembreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesDiciembreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesTotalPagoDataGridViewTextBoxColumn;
    }
}