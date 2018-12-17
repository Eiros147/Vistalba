namespace Principal
{
    partial class NuevoSalud
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
            System.Windows.Forms.Label saludIDLabel;
            System.Windows.Forms.Label socioIDLabel;
            System.Windows.Forms.Label saludAlergiaLabel;
            System.Windows.Forms.Label saludAlergiaDescLabel;
            System.Windows.Forms.Label saludSangreLabel;
            System.Windows.Forms.Label saludMedLabel;
            System.Windows.Forms.Label saludObraSocLabel;
            System.Windows.Forms.Label saludTelEmLabel;
            System.Windows.Forms.Label saludExtraLabel;
            this.club_VistalbaDataSet = new Principal.Club_VistalbaDataSet();
            this.saludBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saludTableAdapter = new Principal.Club_VistalbaDataSetTableAdapters.SaludTableAdapter();
            this.tableAdapterManager = new Principal.Club_VistalbaDataSetTableAdapters.TableAdapterManager();
            this.saludIDTextBox = new System.Windows.Forms.TextBox();
            this.socioIDTextBox = new System.Windows.Forms.TextBox();
            this.saludAlergiaCheckBox = new System.Windows.Forms.CheckBox();
            this.saludAlergiaDescTextBox = new System.Windows.Forms.TextBox();
            this.saludSangreTextBox = new System.Windows.Forms.TextBox();
            this.saludMedTextBox = new System.Windows.Forms.TextBox();
            this.saludObraSocTextBox = new System.Windows.Forms.TextBox();
            this.saludTelEmTextBox = new System.Windows.Forms.TextBox();
            this.saludExtraTextBox = new System.Windows.Forms.TextBox();
            saludIDLabel = new System.Windows.Forms.Label();
            socioIDLabel = new System.Windows.Forms.Label();
            saludAlergiaLabel = new System.Windows.Forms.Label();
            saludAlergiaDescLabel = new System.Windows.Forms.Label();
            saludSangreLabel = new System.Windows.Forms.Label();
            saludMedLabel = new System.Windows.Forms.Label();
            saludObraSocLabel = new System.Windows.Forms.Label();
            saludTelEmLabel = new System.Windows.Forms.Label();
            saludExtraLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.club_VistalbaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saludBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // club_VistalbaDataSet
            // 
            this.club_VistalbaDataSet.DataSetName = "Club_VistalbaDataSet";
            this.club_VistalbaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // saludBindingSource
            // 
            this.saludBindingSource.DataMember = "Salud";
            this.saludBindingSource.DataSource = this.club_VistalbaDataSet;
            // 
            // saludTableAdapter
            // 
            this.saludTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ActividadesTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriaTableAdapter = null;
            this.tableAdapterManager.CuotaTableAdapter = null;
            this.tableAdapterManager.GrupoTableAdapter = null;
            this.tableAdapterManager.ProfesionalTableAdapter = null;
            this.tableAdapterManager.SaludTableAdapter = this.saludTableAdapter;
            this.tableAdapterManager.SocioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Principal.Club_VistalbaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // saludIDLabel
            // 
            saludIDLabel.AutoSize = true;
            saludIDLabel.Location = new System.Drawing.Point(12, 40);
            saludIDLabel.Name = "saludIDLabel";
            saludIDLabel.Size = new System.Drawing.Size(49, 13);
            saludIDLabel.TabIndex = 1;
            saludIDLabel.Text = "salud ID:";
            // 
            // saludIDTextBox
            // 
            this.saludIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.saludBindingSource, "saludID", true));
            this.saludIDTextBox.Location = new System.Drawing.Point(116, 37);
            this.saludIDTextBox.Name = "saludIDTextBox";
            this.saludIDTextBox.Size = new System.Drawing.Size(104, 20);
            this.saludIDTextBox.TabIndex = 2;
            // 
            // socioIDLabel
            // 
            socioIDLabel.AutoSize = true;
            socioIDLabel.Location = new System.Drawing.Point(12, 66);
            socioIDLabel.Name = "socioIDLabel";
            socioIDLabel.Size = new System.Drawing.Size(49, 13);
            socioIDLabel.TabIndex = 3;
            socioIDLabel.Text = "socio ID:";
            // 
            // socioIDTextBox
            // 
            this.socioIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.saludBindingSource, "socioID", true));
            this.socioIDTextBox.Location = new System.Drawing.Point(116, 63);
            this.socioIDTextBox.Name = "socioIDTextBox";
            this.socioIDTextBox.Size = new System.Drawing.Size(104, 20);
            this.socioIDTextBox.TabIndex = 4;
            // 
            // saludAlergiaLabel
            // 
            saludAlergiaLabel.AutoSize = true;
            saludAlergiaLabel.Location = new System.Drawing.Point(12, 94);
            saludAlergiaLabel.Name = "saludAlergiaLabel";
            saludAlergiaLabel.Size = new System.Drawing.Size(70, 13);
            saludAlergiaLabel.TabIndex = 5;
            saludAlergiaLabel.Text = "salud Alergia:";
            // 
            // saludAlergiaCheckBox
            // 
            this.saludAlergiaCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.saludBindingSource, "saludAlergia", true));
            this.saludAlergiaCheckBox.Location = new System.Drawing.Point(116, 89);
            this.saludAlergiaCheckBox.Name = "saludAlergiaCheckBox";
            this.saludAlergiaCheckBox.Size = new System.Drawing.Size(104, 24);
            this.saludAlergiaCheckBox.TabIndex = 6;
            this.saludAlergiaCheckBox.Text = "Si";
            this.saludAlergiaCheckBox.UseVisualStyleBackColor = true;
            // 
            // saludAlergiaDescLabel
            // 
            saludAlergiaDescLabel.AutoSize = true;
            saludAlergiaDescLabel.Location = new System.Drawing.Point(12, 122);
            saludAlergiaDescLabel.Name = "saludAlergiaDescLabel";
            saludAlergiaDescLabel.Size = new System.Drawing.Size(98, 13);
            saludAlergiaDescLabel.TabIndex = 7;
            saludAlergiaDescLabel.Text = "salud Alergia Desc:";
            // 
            // saludAlergiaDescTextBox
            // 
            this.saludAlergiaDescTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.saludBindingSource, "saludAlergiaDesc", true));
            this.saludAlergiaDescTextBox.Enabled = false;
            this.saludAlergiaDescTextBox.Location = new System.Drawing.Point(116, 119);
            this.saludAlergiaDescTextBox.Name = "saludAlergiaDescTextBox";
            this.saludAlergiaDescTextBox.Size = new System.Drawing.Size(104, 20);
            this.saludAlergiaDescTextBox.TabIndex = 8;
            // 
            // saludSangreLabel
            // 
            saludSangreLabel.AutoSize = true;
            saludSangreLabel.Location = new System.Drawing.Point(12, 148);
            saludSangreLabel.Name = "saludSangreLabel";
            saludSangreLabel.Size = new System.Drawing.Size(72, 13);
            saludSangreLabel.TabIndex = 9;
            saludSangreLabel.Text = "salud Sangre:";
            // 
            // saludSangreTextBox
            // 
            this.saludSangreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.saludBindingSource, "saludSangre", true));
            this.saludSangreTextBox.Location = new System.Drawing.Point(116, 145);
            this.saludSangreTextBox.Name = "saludSangreTextBox";
            this.saludSangreTextBox.Size = new System.Drawing.Size(104, 20);
            this.saludSangreTextBox.TabIndex = 10;
            // 
            // saludMedLabel
            // 
            saludMedLabel.AutoSize = true;
            saludMedLabel.Location = new System.Drawing.Point(12, 174);
            saludMedLabel.Name = "saludMedLabel";
            saludMedLabel.Size = new System.Drawing.Size(59, 13);
            saludMedLabel.TabIndex = 11;
            saludMedLabel.Text = "salud Med:";
            // 
            // saludMedTextBox
            // 
            this.saludMedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.saludBindingSource, "saludMed", true));
            this.saludMedTextBox.Location = new System.Drawing.Point(116, 171);
            this.saludMedTextBox.Name = "saludMedTextBox";
            this.saludMedTextBox.Size = new System.Drawing.Size(104, 20);
            this.saludMedTextBox.TabIndex = 12;
            // 
            // saludObraSocLabel
            // 
            saludObraSocLabel.AutoSize = true;
            saludObraSocLabel.Location = new System.Drawing.Point(12, 200);
            saludObraSocLabel.Name = "saludObraSocLabel";
            saludObraSocLabel.Size = new System.Drawing.Size(83, 13);
            saludObraSocLabel.TabIndex = 13;
            saludObraSocLabel.Text = "salud Obra Soc:";
            // 
            // saludObraSocTextBox
            // 
            this.saludObraSocTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.saludBindingSource, "saludObraSoc", true));
            this.saludObraSocTextBox.Location = new System.Drawing.Point(116, 197);
            this.saludObraSocTextBox.Name = "saludObraSocTextBox";
            this.saludObraSocTextBox.Size = new System.Drawing.Size(104, 20);
            this.saludObraSocTextBox.TabIndex = 14;
            // 
            // saludTelEmLabel
            // 
            saludTelEmLabel.AutoSize = true;
            saludTelEmLabel.Location = new System.Drawing.Point(12, 226);
            saludTelEmLabel.Name = "saludTelEmLabel";
            saludTelEmLabel.Size = new System.Drawing.Size(71, 13);
            saludTelEmLabel.TabIndex = 15;
            saludTelEmLabel.Text = "salud Tel Em:";
            // 
            // saludTelEmTextBox
            // 
            this.saludTelEmTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.saludBindingSource, "saludTelEm", true));
            this.saludTelEmTextBox.Location = new System.Drawing.Point(116, 223);
            this.saludTelEmTextBox.Name = "saludTelEmTextBox";
            this.saludTelEmTextBox.Size = new System.Drawing.Size(104, 20);
            this.saludTelEmTextBox.TabIndex = 16;
            // 
            // saludExtraLabel
            // 
            saludExtraLabel.AutoSize = true;
            saludExtraLabel.Location = new System.Drawing.Point(12, 252);
            saludExtraLabel.Name = "saludExtraLabel";
            saludExtraLabel.Size = new System.Drawing.Size(62, 13);
            saludExtraLabel.TabIndex = 17;
            saludExtraLabel.Text = "salud Extra:";
            // 
            // saludExtraTextBox
            // 
            this.saludExtraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.saludBindingSource, "saludExtra", true));
            this.saludExtraTextBox.Location = new System.Drawing.Point(116, 249);
            this.saludExtraTextBox.Name = "saludExtraTextBox";
            this.saludExtraTextBox.Size = new System.Drawing.Size(104, 20);
            this.saludExtraTextBox.TabIndex = 18;
            // 
            // NuevoSalud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 362);
            this.Controls.Add(saludIDLabel);
            this.Controls.Add(this.saludIDTextBox);
            this.Controls.Add(socioIDLabel);
            this.Controls.Add(this.socioIDTextBox);
            this.Controls.Add(saludAlergiaLabel);
            this.Controls.Add(this.saludAlergiaCheckBox);
            this.Controls.Add(saludAlergiaDescLabel);
            this.Controls.Add(this.saludAlergiaDescTextBox);
            this.Controls.Add(saludSangreLabel);
            this.Controls.Add(this.saludSangreTextBox);
            this.Controls.Add(saludMedLabel);
            this.Controls.Add(this.saludMedTextBox);
            this.Controls.Add(saludObraSocLabel);
            this.Controls.Add(this.saludObraSocTextBox);
            this.Controls.Add(saludTelEmLabel);
            this.Controls.Add(this.saludTelEmTextBox);
            this.Controls.Add(saludExtraLabel);
            this.Controls.Add(this.saludExtraTextBox);
            this.Name = "NuevoSalud";
            this.Text = "NuevoSalud";
            this.Load += new System.EventHandler(this.NuevoSalud_Load);
            ((System.ComponentModel.ISupportInitialize)(this.club_VistalbaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saludBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Club_VistalbaDataSet club_VistalbaDataSet;
        private System.Windows.Forms.BindingSource saludBindingSource;
        private Club_VistalbaDataSetTableAdapters.SaludTableAdapter saludTableAdapter;
        private Club_VistalbaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox saludIDTextBox;
        private System.Windows.Forms.TextBox socioIDTextBox;
        private System.Windows.Forms.CheckBox saludAlergiaCheckBox;
        private System.Windows.Forms.TextBox saludAlergiaDescTextBox;
        private System.Windows.Forms.TextBox saludSangreTextBox;
        private System.Windows.Forms.TextBox saludMedTextBox;
        private System.Windows.Forms.TextBox saludObraSocTextBox;
        private System.Windows.Forms.TextBox saludTelEmTextBox;
        private System.Windows.Forms.TextBox saludExtraTextBox;
    }
}