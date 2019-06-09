namespace Principal
{
    partial class SociosInactivos
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
            this.dgvInactivos = new System.Windows.Forms.DataGridView();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInactivos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInactivos
            // 
            this.dgvInactivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInactivos.Location = new System.Drawing.Point(12, 12);
            this.dgvInactivos.Name = "dgvInactivos";
            this.dgvInactivos.Size = new System.Drawing.Size(863, 326);
            this.dgvInactivos.TabIndex = 0;
            this.dgvInactivos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvInactivos_CellFormatting);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(616, 358);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(259, 20);
            this.txtBusqueda.TabIndex = 1;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(552, 361);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Busqueda:";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(12, 358);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 41);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(93, 358);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 41);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // SociosInactivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 406);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.dgvInactivos);
            this.Name = "SociosInactivos";
            this.Activated += new System.EventHandler(this.SociosInactivos_Activated);
            this.Load += new System.EventHandler(this.SociosInactivos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInactivos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInactivos;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCancelar;
    }
}