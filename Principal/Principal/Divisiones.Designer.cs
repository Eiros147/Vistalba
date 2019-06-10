namespace Principal
{
    partial class Divisiones
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
            this.dgvDivision = new System.Windows.Forms.DataGridView();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtBuscador = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDivision)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDivision
            // 
            this.dgvDivision.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDivision.Location = new System.Drawing.Point(12, 12);
            this.dgvDivision.Name = "dgvDivision";
            this.dgvDivision.Size = new System.Drawing.Size(692, 335);
            this.dgvDivision.TabIndex = 0;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(12, 354);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 35);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBuscador
            // 
            this.txtBuscador.Location = new System.Drawing.Point(288, 362);
            this.txtBuscador.Name = "txtBuscador";
            this.txtBuscador.Size = new System.Drawing.Size(416, 20);
            this.txtBuscador.TabIndex = 2;
            // 
            // Divisiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 401);
            this.Controls.Add(this.txtBuscador);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.dgvDivision);
            this.Name = "Divisiones";
            this.Text = "Divisiones";
            this.Load += new System.EventHandler(this.Divisiones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDivision)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDivision;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txtBuscador;
    }
}