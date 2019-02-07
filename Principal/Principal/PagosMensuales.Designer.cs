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
            this.club_VistalbaDataSet = new Principal.Club_VistalbaDataSet();
            this.mensualBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mensualTableAdapter = new Principal.Club_VistalbaDataSetTableAdapters.MensualTableAdapter();
            this.tableAdapterManager = new Principal.Club_VistalbaDataSetTableAdapters.TableAdapterManager();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.clubVistalbaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvPagos = new System.Windows.Forms.DataGridView();
            this.socioIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.mesEneroPagoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesFebreroPagoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesMarzoPagoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesAbrilPagoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesMayoPagoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesJunioPagoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesJulioPagoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesAgostoPagoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesSeptiembrePagoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesOctubrePagoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesNoviembrePagoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesDiciembrePagoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesDerechoUnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesDerechoDosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesDeudaAnteriorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.club_VistalbaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mensualBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubVistalbaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).BeginInit();
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(513, 381);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(422, 20);
            this.textBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(93, 369);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 32);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // clubVistalbaDataSetBindingSource
            // 
            this.clubVistalbaDataSetBindingSource.DataSource = this.club_VistalbaDataSet;
            this.clubVistalbaDataSetBindingSource.Position = 0;
            // 
            // dgvPagos
            // 
            this.dgvPagos.AutoGenerateColumns = false;
            this.dgvPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPagos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.socioIDDataGridViewTextBoxColumn,
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
            this.mesEneroPagoDataGridViewTextBoxColumn,
            this.mesFebreroPagoDataGridViewTextBoxColumn,
            this.mesMarzoPagoDataGridViewTextBoxColumn,
            this.mesAbrilPagoDataGridViewTextBoxColumn,
            this.mesMayoPagoDataGridViewTextBoxColumn,
            this.mesJunioPagoDataGridViewTextBoxColumn,
            this.mesJulioPagoDataGridViewTextBoxColumn,
            this.mesAgostoPagoDataGridViewTextBoxColumn,
            this.mesSeptiembrePagoDataGridViewTextBoxColumn,
            this.mesOctubrePagoDataGridViewTextBoxColumn,
            this.mesNoviembrePagoDataGridViewTextBoxColumn,
            this.mesDiciembrePagoDataGridViewTextBoxColumn,
            this.mesDerechoUnoDataGridViewTextBoxColumn,
            this.mesDerechoDosDataGridViewTextBoxColumn,
            this.mesDeudaAnteriorDataGridViewTextBoxColumn,
            this.mesTotalDataGridViewTextBoxColumn});
            this.dgvPagos.DataSource = this.mensualBindingSource;
            this.dgvPagos.Location = new System.Drawing.Point(12, 12);
            this.dgvPagos.Name = "dgvPagos";
            this.dgvPagos.Size = new System.Drawing.Size(923, 311);
            this.dgvPagos.TabIndex = 5;
            // 
            // socioIDDataGridViewTextBoxColumn
            // 
            this.socioIDDataGridViewTextBoxColumn.DataPropertyName = "socioID";
            this.socioIDDataGridViewTextBoxColumn.HeaderText = "socioID";
            this.socioIDDataGridViewTextBoxColumn.Name = "socioIDDataGridViewTextBoxColumn";
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
            // mesEneroPagoDataGridViewTextBoxColumn
            // 
            this.mesEneroPagoDataGridViewTextBoxColumn.DataPropertyName = "mesEneroPago";
            this.mesEneroPagoDataGridViewTextBoxColumn.HeaderText = "mesEneroPago";
            this.mesEneroPagoDataGridViewTextBoxColumn.Name = "mesEneroPagoDataGridViewTextBoxColumn";
            // 
            // mesFebreroPagoDataGridViewTextBoxColumn
            // 
            this.mesFebreroPagoDataGridViewTextBoxColumn.DataPropertyName = "mesFebreroPago";
            this.mesFebreroPagoDataGridViewTextBoxColumn.HeaderText = "mesFebreroPago";
            this.mesFebreroPagoDataGridViewTextBoxColumn.Name = "mesFebreroPagoDataGridViewTextBoxColumn";
            // 
            // mesMarzoPagoDataGridViewTextBoxColumn
            // 
            this.mesMarzoPagoDataGridViewTextBoxColumn.DataPropertyName = "mesMarzoPago";
            this.mesMarzoPagoDataGridViewTextBoxColumn.HeaderText = "mesMarzoPago";
            this.mesMarzoPagoDataGridViewTextBoxColumn.Name = "mesMarzoPagoDataGridViewTextBoxColumn";
            // 
            // mesAbrilPagoDataGridViewTextBoxColumn
            // 
            this.mesAbrilPagoDataGridViewTextBoxColumn.DataPropertyName = "mesAbrilPago";
            this.mesAbrilPagoDataGridViewTextBoxColumn.HeaderText = "mesAbrilPago";
            this.mesAbrilPagoDataGridViewTextBoxColumn.Name = "mesAbrilPagoDataGridViewTextBoxColumn";
            // 
            // mesMayoPagoDataGridViewTextBoxColumn
            // 
            this.mesMayoPagoDataGridViewTextBoxColumn.DataPropertyName = "mesMayoPago";
            this.mesMayoPagoDataGridViewTextBoxColumn.HeaderText = "mesMayoPago";
            this.mesMayoPagoDataGridViewTextBoxColumn.Name = "mesMayoPagoDataGridViewTextBoxColumn";
            // 
            // mesJunioPagoDataGridViewTextBoxColumn
            // 
            this.mesJunioPagoDataGridViewTextBoxColumn.DataPropertyName = "mesJunioPago";
            this.mesJunioPagoDataGridViewTextBoxColumn.HeaderText = "mesJunioPago";
            this.mesJunioPagoDataGridViewTextBoxColumn.Name = "mesJunioPagoDataGridViewTextBoxColumn";
            // 
            // mesJulioPagoDataGridViewTextBoxColumn
            // 
            this.mesJulioPagoDataGridViewTextBoxColumn.DataPropertyName = "mesJulioPago";
            this.mesJulioPagoDataGridViewTextBoxColumn.HeaderText = "mesJulioPago";
            this.mesJulioPagoDataGridViewTextBoxColumn.Name = "mesJulioPagoDataGridViewTextBoxColumn";
            // 
            // mesAgostoPagoDataGridViewTextBoxColumn
            // 
            this.mesAgostoPagoDataGridViewTextBoxColumn.DataPropertyName = "mesAgostoPago";
            this.mesAgostoPagoDataGridViewTextBoxColumn.HeaderText = "mesAgostoPago";
            this.mesAgostoPagoDataGridViewTextBoxColumn.Name = "mesAgostoPagoDataGridViewTextBoxColumn";
            // 
            // mesSeptiembrePagoDataGridViewTextBoxColumn
            // 
            this.mesSeptiembrePagoDataGridViewTextBoxColumn.DataPropertyName = "mesSeptiembrePago";
            this.mesSeptiembrePagoDataGridViewTextBoxColumn.HeaderText = "mesSeptiembrePago";
            this.mesSeptiembrePagoDataGridViewTextBoxColumn.Name = "mesSeptiembrePagoDataGridViewTextBoxColumn";
            // 
            // mesOctubrePagoDataGridViewTextBoxColumn
            // 
            this.mesOctubrePagoDataGridViewTextBoxColumn.DataPropertyName = "mesOctubrePago";
            this.mesOctubrePagoDataGridViewTextBoxColumn.HeaderText = "mesOctubrePago";
            this.mesOctubrePagoDataGridViewTextBoxColumn.Name = "mesOctubrePagoDataGridViewTextBoxColumn";
            // 
            // mesNoviembrePagoDataGridViewTextBoxColumn
            // 
            this.mesNoviembrePagoDataGridViewTextBoxColumn.DataPropertyName = "mesNoviembrePago";
            this.mesNoviembrePagoDataGridViewTextBoxColumn.HeaderText = "mesNoviembrePago";
            this.mesNoviembrePagoDataGridViewTextBoxColumn.Name = "mesNoviembrePagoDataGridViewTextBoxColumn";
            // 
            // mesDiciembrePagoDataGridViewTextBoxColumn
            // 
            this.mesDiciembrePagoDataGridViewTextBoxColumn.DataPropertyName = "mesDiciembrePago";
            this.mesDiciembrePagoDataGridViewTextBoxColumn.HeaderText = "mesDiciembrePago";
            this.mesDiciembrePagoDataGridViewTextBoxColumn.Name = "mesDiciembrePagoDataGridViewTextBoxColumn";
            // 
            // mesDerechoUnoDataGridViewTextBoxColumn
            // 
            this.mesDerechoUnoDataGridViewTextBoxColumn.DataPropertyName = "mesDerechoUno";
            this.mesDerechoUnoDataGridViewTextBoxColumn.HeaderText = "mesDerechoUno";
            this.mesDerechoUnoDataGridViewTextBoxColumn.Name = "mesDerechoUnoDataGridViewTextBoxColumn";
            // 
            // mesDerechoDosDataGridViewTextBoxColumn
            // 
            this.mesDerechoDosDataGridViewTextBoxColumn.DataPropertyName = "mesDerechoDos";
            this.mesDerechoDosDataGridViewTextBoxColumn.HeaderText = "mesDerechoDos";
            this.mesDerechoDosDataGridViewTextBoxColumn.Name = "mesDerechoDosDataGridViewTextBoxColumn";
            // 
            // mesDeudaAnteriorDataGridViewTextBoxColumn
            // 
            this.mesDeudaAnteriorDataGridViewTextBoxColumn.DataPropertyName = "mesDeudaAnterior";
            this.mesDeudaAnteriorDataGridViewTextBoxColumn.HeaderText = "mesDeudaAnterior";
            this.mesDeudaAnteriorDataGridViewTextBoxColumn.Name = "mesDeudaAnteriorDataGridViewTextBoxColumn";
            // 
            // mesTotalDataGridViewTextBoxColumn
            // 
            this.mesTotalDataGridViewTextBoxColumn.DataPropertyName = "mesTotal";
            this.mesTotalDataGridViewTextBoxColumn.HeaderText = "mesTotal";
            this.mesTotalDataGridViewTextBoxColumn.Name = "mesTotalDataGridViewTextBoxColumn";
            // 
            // PagosMensuales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 421);
            this.Controls.Add(this.dgvPagos);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "PagosMensuales";
            this.Text = "PagosMensuales";
            this.Load += new System.EventHandler(this.PagosMensuales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.club_VistalbaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mensualBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubVistalbaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).EndInit();
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource clubVistalbaDataSetBindingSource;
        private System.Windows.Forms.DataGridView dgvPagos;
        private System.Windows.Forms.DataGridViewTextBoxColumn socioIDDataGridViewTextBoxColumn;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn mesEneroPagoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesFebreroPagoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesMarzoPagoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesAbrilPagoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesMayoPagoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesJunioPagoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesJulioPagoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesAgostoPagoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesSeptiembrePagoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesOctubrePagoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesNoviembrePagoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesDiciembrePagoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesDerechoUnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesDerechoDosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesDeudaAnteriorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesTotalDataGridViewTextBoxColumn;
    }
}