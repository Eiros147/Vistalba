namespace Principal
{
    partial class ModificarSalud
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
            System.Windows.Forms.Label saludAlergiaLabel;
            System.Windows.Forms.Label saludAlergiaDescLabel;
            System.Windows.Forms.Label saludSangreLabel;
            System.Windows.Forms.Label saludMedLabel;
            System.Windows.Forms.Label saludObraSocLabel;
            System.Windows.Forms.Label saludTelEmLabel;
            System.Windows.Forms.Label saludExtraLabel;
            System.Windows.Forms.Label socioNombreLabel;
            this.club_VistalbaDataSet = new Principal.Club_VistalbaDataSet();
            this.saludBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saludTableAdapter = new Principal.Club_VistalbaDataSetTableAdapters.SaludTableAdapter();
            this.tableAdapterManager = new Principal.Club_VistalbaDataSetTableAdapters.TableAdapterManager();
            this.saludAlergiaCheckBox = new System.Windows.Forms.CheckBox();
            this.saludAlergiaDescTextBox = new System.Windows.Forms.TextBox();
            this.saludSangreTextBox = new System.Windows.Forms.TextBox();
            this.saludMedTextBox = new System.Windows.Forms.TextBox();
            this.saludObraSocTextBox = new System.Windows.Forms.TextBox();
            this.saludTelEmTextBox = new System.Windows.Forms.TextBox();
            this.saludExtraTextBox = new System.Windows.Forms.TextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.socioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.socioTableAdapter = new Principal.Club_VistalbaDataSetTableAdapters.SocioTableAdapter();
            this.socioNombreTextBox = new System.Windows.Forms.TextBox();
            saludAlergiaLabel = new System.Windows.Forms.Label();
            saludAlergiaDescLabel = new System.Windows.Forms.Label();
            saludSangreLabel = new System.Windows.Forms.Label();
            saludMedLabel = new System.Windows.Forms.Label();
            saludObraSocLabel = new System.Windows.Forms.Label();
            saludTelEmLabel = new System.Windows.Forms.Label();
            saludExtraLabel = new System.Windows.Forms.Label();
            socioNombreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.club_VistalbaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saludBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.socioBindingSource)).BeginInit();
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
            this.tableAdapterManager.SocioTableAdapter = this.socioTableAdapter;
            this.tableAdapterManager.UpdateOrder = Principal.Club_VistalbaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // saludAlergiaLabel
            // 
            saludAlergiaLabel.AutoSize = true;
            saludAlergiaLabel.Location = new System.Drawing.Point(26, 81);
            saludAlergiaLabel.Name = "saludAlergiaLabel";
            saludAlergiaLabel.Size = new System.Drawing.Size(70, 13);
            saludAlergiaLabel.TabIndex = 5;
            saludAlergiaLabel.Text = "salud Alergia:";
            // 
            // saludAlergiaCheckBox
            // 
            this.saludAlergiaCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.saludBindingSource, "saludAlergia", true));
            this.saludAlergiaCheckBox.Location = new System.Drawing.Point(130, 76);
            this.saludAlergiaCheckBox.Name = "saludAlergiaCheckBox";
            this.saludAlergiaCheckBox.Size = new System.Drawing.Size(104, 24);
            this.saludAlergiaCheckBox.TabIndex = 6;
            this.saludAlergiaCheckBox.Text = "checkBox1";
            this.saludAlergiaCheckBox.UseVisualStyleBackColor = true;
            // 
            // saludAlergiaDescLabel
            // 
            saludAlergiaDescLabel.AutoSize = true;
            saludAlergiaDescLabel.Location = new System.Drawing.Point(26, 109);
            saludAlergiaDescLabel.Name = "saludAlergiaDescLabel";
            saludAlergiaDescLabel.Size = new System.Drawing.Size(98, 13);
            saludAlergiaDescLabel.TabIndex = 7;
            saludAlergiaDescLabel.Text = "salud Alergia Desc:";
            // 
            // saludAlergiaDescTextBox
            // 
            this.saludAlergiaDescTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.saludBindingSource, "saludAlergiaDesc", true));
            this.saludAlergiaDescTextBox.Location = new System.Drawing.Point(130, 106);
            this.saludAlergiaDescTextBox.Name = "saludAlergiaDescTextBox";
            this.saludAlergiaDescTextBox.Size = new System.Drawing.Size(104, 20);
            this.saludAlergiaDescTextBox.TabIndex = 8;
            // 
            // saludSangreLabel
            // 
            saludSangreLabel.AutoSize = true;
            saludSangreLabel.Location = new System.Drawing.Point(26, 135);
            saludSangreLabel.Name = "saludSangreLabel";
            saludSangreLabel.Size = new System.Drawing.Size(72, 13);
            saludSangreLabel.TabIndex = 9;
            saludSangreLabel.Text = "salud Sangre:";
            // 
            // saludSangreTextBox
            // 
            this.saludSangreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.saludBindingSource, "saludSangre", true));
            this.saludSangreTextBox.Location = new System.Drawing.Point(130, 132);
            this.saludSangreTextBox.Name = "saludSangreTextBox";
            this.saludSangreTextBox.Size = new System.Drawing.Size(104, 20);
            this.saludSangreTextBox.TabIndex = 10;
            // 
            // saludMedLabel
            // 
            saludMedLabel.AutoSize = true;
            saludMedLabel.Location = new System.Drawing.Point(26, 161);
            saludMedLabel.Name = "saludMedLabel";
            saludMedLabel.Size = new System.Drawing.Size(59, 13);
            saludMedLabel.TabIndex = 11;
            saludMedLabel.Text = "salud Med:";
            // 
            // saludMedTextBox
            // 
            this.saludMedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.saludBindingSource, "saludMed", true));
            this.saludMedTextBox.Location = new System.Drawing.Point(130, 158);
            this.saludMedTextBox.Name = "saludMedTextBox";
            this.saludMedTextBox.Size = new System.Drawing.Size(104, 20);
            this.saludMedTextBox.TabIndex = 12;
            // 
            // saludObraSocLabel
            // 
            saludObraSocLabel.AutoSize = true;
            saludObraSocLabel.Location = new System.Drawing.Point(26, 187);
            saludObraSocLabel.Name = "saludObraSocLabel";
            saludObraSocLabel.Size = new System.Drawing.Size(83, 13);
            saludObraSocLabel.TabIndex = 13;
            saludObraSocLabel.Text = "salud Obra Soc:";
            // 
            // saludObraSocTextBox
            // 
            this.saludObraSocTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.saludBindingSource, "saludObraSoc", true));
            this.saludObraSocTextBox.Location = new System.Drawing.Point(130, 184);
            this.saludObraSocTextBox.Name = "saludObraSocTextBox";
            this.saludObraSocTextBox.Size = new System.Drawing.Size(104, 20);
            this.saludObraSocTextBox.TabIndex = 14;
            // 
            // saludTelEmLabel
            // 
            saludTelEmLabel.AutoSize = true;
            saludTelEmLabel.Location = new System.Drawing.Point(26, 213);
            saludTelEmLabel.Name = "saludTelEmLabel";
            saludTelEmLabel.Size = new System.Drawing.Size(71, 13);
            saludTelEmLabel.TabIndex = 15;
            saludTelEmLabel.Text = "salud Tel Em:";
            // 
            // saludTelEmTextBox
            // 
            this.saludTelEmTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.saludBindingSource, "saludTelEm", true));
            this.saludTelEmTextBox.Location = new System.Drawing.Point(130, 210);
            this.saludTelEmTextBox.Name = "saludTelEmTextBox";
            this.saludTelEmTextBox.Size = new System.Drawing.Size(104, 20);
            this.saludTelEmTextBox.TabIndex = 16;
            // 
            // saludExtraLabel
            // 
            saludExtraLabel.AutoSize = true;
            saludExtraLabel.Location = new System.Drawing.Point(26, 239);
            saludExtraLabel.Name = "saludExtraLabel";
            saludExtraLabel.Size = new System.Drawing.Size(62, 13);
            saludExtraLabel.TabIndex = 17;
            saludExtraLabel.Text = "salud Extra:";
            // 
            // saludExtraTextBox
            // 
            this.saludExtraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.saludBindingSource, "saludExtra", true));
            this.saludExtraTextBox.Location = new System.Drawing.Point(130, 236);
            this.saludExtraTextBox.Name = "saludExtraTextBox";
            this.saludExtraTextBox.Size = new System.Drawing.Size(104, 20);
            this.saludExtraTextBox.TabIndex = 18;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(13, 283);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 19;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(103, 283);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(194, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // socioBindingSource
            // 
            this.socioBindingSource.DataMember = "Socio";
            this.socioBindingSource.DataSource = this.club_VistalbaDataSet;
            // 
            // socioTableAdapter
            // 
            this.socioTableAdapter.ClearBeforeFill = true;
            // 
            // socioNombreLabel
            // 
            socioNombreLabel.AutoSize = true;
            socioNombreLabel.Location = new System.Drawing.Point(26, 57);
            socioNombreLabel.Name = "socioNombreLabel";
            socioNombreLabel.Size = new System.Drawing.Size(75, 13);
            socioNombreLabel.TabIndex = 21;
            socioNombreLabel.Text = "socio Nombre:";
            // 
            // socioNombreTextBox
            // 
            this.socioNombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.socioBindingSource, "socioNombre", true));
            this.socioNombreTextBox.Location = new System.Drawing.Point(130, 54);
            this.socioNombreTextBox.Name = "socioNombreTextBox";
            this.socioNombreTextBox.Size = new System.Drawing.Size(100, 20);
            this.socioNombreTextBox.TabIndex = 22;
            // 
            // ModificarSalud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 333);
            this.Controls.Add(socioNombreLabel);
            this.Controls.Add(this.socioNombreTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnVolver);
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
            this.Name = "ModificarSalud";
            this.Text = "ModificarSalud";
            this.Load += new System.EventHandler(this.ModificarSalud_Load);
            ((System.ComponentModel.ISupportInitialize)(this.club_VistalbaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saludBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.socioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Club_VistalbaDataSet club_VistalbaDataSet;
        private System.Windows.Forms.BindingSource saludBindingSource;
        private Club_VistalbaDataSetTableAdapters.SaludTableAdapter saludTableAdapter;
        private Club_VistalbaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.CheckBox saludAlergiaCheckBox;
        private System.Windows.Forms.TextBox saludAlergiaDescTextBox;
        private System.Windows.Forms.TextBox saludSangreTextBox;
        private System.Windows.Forms.TextBox saludMedTextBox;
        private System.Windows.Forms.TextBox saludObraSocTextBox;
        private System.Windows.Forms.TextBox saludTelEmTextBox;
        private System.Windows.Forms.TextBox saludExtraTextBox;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button button1;
        private Club_VistalbaDataSetTableAdapters.SocioTableAdapter socioTableAdapter;
        private System.Windows.Forms.BindingSource socioBindingSource;
        private System.Windows.Forms.TextBox socioNombreTextBox;
    }
}