namespace Principal
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvSocio = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.socioGenero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.socioCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.socioNivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.socioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.club_VistalbaDataSet = new Principal.Club_VistalbaDataSet();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.smiActividades = new System.Windows.Forms.ToolStripMenuItem();
            this.smiProfesionales = new System.Windows.Forms.ToolStripMenuItem();
            this.smiGrupos = new System.Windows.Forms.ToolStripMenuItem();
            this.smiCategorias = new System.Windows.Forms.ToolStripMenuItem();
            this.smiPagos = new System.Windows.Forms.ToolStripMenuItem();
            this.smiInactivos = new System.Windows.Forms.ToolStripMenuItem();
            this.divisionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hombresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miPrimeraH = new System.Windows.Forms.ToolStripMenuItem();
            this.segundaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quintaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sextaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.septimaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miOctavaH = new System.Windows.Forms.ToolStripMenuItem();
            this.miNovenaH = new System.Windows.Forms.ToolStripMenuItem();
            this.miDecimaH = new System.Windows.Forms.ToolStripMenuItem();
            this.miPreDecimaH = new System.Windows.Forms.ToolStripMenuItem();
            this.mujeresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miPrimeraF = new System.Windows.Forms.ToolStripMenuItem();
            this.miSegundaF = new System.Windows.Forms.ToolStripMenuItem();
            this.miQuintaF = new System.Windows.Forms.ToolStripMenuItem();
            this.miSextaF = new System.Windows.Forms.ToolStripMenuItem();
            this.miSeptimaF = new System.Windows.Forms.ToolStripMenuItem();
            this.miOctavaF = new System.Windows.Forms.ToolStripMenuItem();
            this.miNovenaF = new System.Windows.Forms.ToolStripMenuItem();
            this.miDecimaF = new System.Windows.Forms.ToolStripMenuItem();
            this.miPreDecimaF = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.socioTableAdapter = new Principal.Club_VistalbaDataSetTableAdapters.SocioTableAdapter();
            this.tableAdapterManager = new Principal.Club_VistalbaDataSetTableAdapters.TableAdapterManager();
            this.saludTableAdapter = new Principal.Club_VistalbaDataSetTableAdapters.SaludTableAdapter();
            this.socioSaludBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSocio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.socioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.club_VistalbaDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.socioSaludBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSocio
            // 
            this.dgvSocio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSocio.AutoGenerateColumns = false;
            this.dgvSocio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSocio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.socioGenero,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.socioCategoria,
            this.socioNivel});
            this.dgvSocio.DataSource = this.socioBindingSource;
            this.dgvSocio.Location = new System.Drawing.Point(12, 28);
            this.dgvSocio.Name = "dgvSocio";
            this.dgvSocio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSocio.Size = new System.Drawing.Size(901, 335);
            this.dgvSocio.TabIndex = 1;
            this.dgvSocio.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSocio_CellContentClick);
            this.dgvSocio.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSocio_CellContentDoubleClick);
            this.dgvSocio.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvSocio_CellFormatting);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "socioNombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "socioDNI";
            this.dataGridViewTextBoxColumn3.HeaderText = "DNI";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "socioDireccion";
            this.dataGridViewTextBoxColumn4.HeaderText = "Direccion";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "socioMail";
            this.dataGridViewTextBoxColumn5.HeaderText = "Mail";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "socioTelefono";
            this.dataGridViewTextBoxColumn6.HeaderText = "Telefono";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "socioCelular";
            this.dataGridViewTextBoxColumn7.HeaderText = "Celular";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // socioGenero
            // 
            this.socioGenero.DataPropertyName = "socioGenero";
            this.socioGenero.HeaderText = "Genero";
            this.socioGenero.Name = "socioGenero";
            this.socioGenero.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.socioGenero.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "socioFechaNac";
            this.dataGridViewTextBoxColumn8.HeaderText = "Fecha Nacimiento";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "socioFechaIng";
            this.dataGridViewTextBoxColumn9.HeaderText = "Fecha Ingreso";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "socioFechaUltPago";
            this.dataGridViewTextBoxColumn10.HeaderText = "Fecha Ult Pago";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // socioCategoria
            // 
            this.socioCategoria.DataPropertyName = "socioCategoria";
            this.socioCategoria.HeaderText = "socioCategoria";
            this.socioCategoria.Name = "socioCategoria";
            // 
            // socioNivel
            // 
            this.socioNivel.DataPropertyName = "socioNivel";
            this.socioNivel.HeaderText = "socioNivel";
            this.socioNivel.Name = "socioNivel";
            // 
            // socioBindingSource
            // 
            this.socioBindingSource.DataMember = "Socio";
            this.socioBindingSource.DataSource = this.club_VistalbaDataSet;
            // 
            // club_VistalbaDataSet
            // 
            this.club_VistalbaDataSet.DataSetName = "Club_VistalbaDataSet";
            this.club_VistalbaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNuevo.Location = new System.Drawing.Point(12, 379);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 39);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnAbrir
            // 
            this.btnAbrir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAbrir.Location = new System.Drawing.Point(108, 379);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(75, 39);
            this.btnAbrir.TabIndex = 3;
            this.btnAbrir.Text = "Modificar";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBusqueda.Location = new System.Drawing.Point(576, 389);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(337, 20);
            this.txtBusqueda.TabIndex = 4;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(213, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 32);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smiActividades,
            this.smiProfesionales,
            this.smiGrupos,
            this.smiCategorias,
            this.smiPagos,
            this.smiInactivos,
            this.divisionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(925, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // smiActividades
            // 
            this.smiActividades.Name = "smiActividades";
            this.smiActividades.Size = new System.Drawing.Size(80, 20);
            this.smiActividades.Text = "Actividades";
            this.smiActividades.Click += new System.EventHandler(this.smiActividades_Click);
            // 
            // smiProfesionales
            // 
            this.smiProfesionales.Name = "smiProfesionales";
            this.smiProfesionales.Size = new System.Drawing.Size(89, 20);
            this.smiProfesionales.Text = "Profesionales";
            this.smiProfesionales.Click += new System.EventHandler(this.smiProfesionales_Click);
            // 
            // smiGrupos
            // 
            this.smiGrupos.Name = "smiGrupos";
            this.smiGrupos.Size = new System.Drawing.Size(57, 20);
            this.smiGrupos.Text = "Grupos";
            this.smiGrupos.Click += new System.EventHandler(this.smiGrupos_Click);
            // 
            // smiCategorias
            // 
            this.smiCategorias.Name = "smiCategorias";
            this.smiCategorias.Size = new System.Drawing.Size(75, 20);
            this.smiCategorias.Text = "Categorias";
            this.smiCategorias.Click += new System.EventHandler(this.smiCategorias_Click);
            // 
            // smiPagos
            // 
            this.smiPagos.Name = "smiPagos";
            this.smiPagos.Size = new System.Drawing.Size(51, 20);
            this.smiPagos.Text = "Pagos";
            this.smiPagos.Click += new System.EventHandler(this.smiPagos_Click);
            // 
            // smiInactivos
            // 
            this.smiInactivos.Name = "smiInactivos";
            this.smiInactivos.Size = new System.Drawing.Size(66, 20);
            this.smiInactivos.Text = "Inactivos";
            this.smiInactivos.Click += new System.EventHandler(this.smiInactivos_Click);
            // 
            // divisionesToolStripMenuItem
            // 
            this.divisionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hombresToolStripMenuItem,
            this.mujeresToolStripMenuItem});
            this.divisionesToolStripMenuItem.Name = "divisionesToolStripMenuItem";
            this.divisionesToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.divisionesToolStripMenuItem.Text = "Divisiones";
            // 
            // hombresToolStripMenuItem
            // 
            this.hombresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miPrimeraH,
            this.segundaToolStripMenuItem,
            this.quintaToolStripMenuItem,
            this.sextaToolStripMenuItem,
            this.septimaToolStripMenuItem,
            this.miOctavaH,
            this.miNovenaH,
            this.miDecimaH,
            this.miPreDecimaH});
            this.hombresToolStripMenuItem.Name = "hombresToolStripMenuItem";
            this.hombresToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.hombresToolStripMenuItem.Text = "Hombres";
            // 
            // miPrimeraH
            // 
            this.miPrimeraH.Name = "miPrimeraH";
            this.miPrimeraH.Size = new System.Drawing.Size(136, 22);
            this.miPrimeraH.Text = "Primera";
            this.miPrimeraH.Click += new System.EventHandler(this.miPrimeraH_Click);
            // 
            // segundaToolStripMenuItem
            // 
            this.segundaToolStripMenuItem.Name = "segundaToolStripMenuItem";
            this.segundaToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.segundaToolStripMenuItem.Text = "Segunda";
            this.segundaToolStripMenuItem.Click += new System.EventHandler(this.segundaToolStripMenuItem_Click);
            // 
            // quintaToolStripMenuItem
            // 
            this.quintaToolStripMenuItem.Name = "quintaToolStripMenuItem";
            this.quintaToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.quintaToolStripMenuItem.Text = "Quinta";
            this.quintaToolStripMenuItem.Click += new System.EventHandler(this.quintaToolStripMenuItem_Click);
            // 
            // sextaToolStripMenuItem
            // 
            this.sextaToolStripMenuItem.Name = "sextaToolStripMenuItem";
            this.sextaToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.sextaToolStripMenuItem.Text = "Sexta";
            this.sextaToolStripMenuItem.Click += new System.EventHandler(this.sextaToolStripMenuItem_Click);
            // 
            // septimaToolStripMenuItem
            // 
            this.septimaToolStripMenuItem.Name = "septimaToolStripMenuItem";
            this.septimaToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.septimaToolStripMenuItem.Text = "Septima";
            this.septimaToolStripMenuItem.Click += new System.EventHandler(this.septimaToolStripMenuItem_Click);
            // 
            // miOctavaH
            // 
            this.miOctavaH.Name = "miOctavaH";
            this.miOctavaH.Size = new System.Drawing.Size(136, 22);
            this.miOctavaH.Text = "Octava";
            this.miOctavaH.Click += new System.EventHandler(this.miOctavaH_Click);
            // 
            // miNovenaH
            // 
            this.miNovenaH.Name = "miNovenaH";
            this.miNovenaH.Size = new System.Drawing.Size(136, 22);
            this.miNovenaH.Text = "Novena";
            this.miNovenaH.Click += new System.EventHandler(this.miNovenaH_Click);
            // 
            // miDecimaH
            // 
            this.miDecimaH.Name = "miDecimaH";
            this.miDecimaH.Size = new System.Drawing.Size(136, 22);
            this.miDecimaH.Text = "Decima";
            this.miDecimaH.Click += new System.EventHandler(this.miDecimaH_Click);
            // 
            // miPreDecimaH
            // 
            this.miPreDecimaH.Name = "miPreDecimaH";
            this.miPreDecimaH.Size = new System.Drawing.Size(136, 22);
            this.miPreDecimaH.Text = "Pre-Decima";
            this.miPreDecimaH.Click += new System.EventHandler(this.miPreDecimaH_Click);
            // 
            // mujeresToolStripMenuItem
            // 
            this.mujeresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miPrimeraF,
            this.miSegundaF,
            this.miQuintaF,
            this.miSextaF,
            this.miSeptimaF,
            this.miOctavaF,
            this.miNovenaF,
            this.miDecimaF,
            this.miPreDecimaF});
            this.mujeresToolStripMenuItem.Name = "mujeresToolStripMenuItem";
            this.mujeresToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.mujeresToolStripMenuItem.Text = "Mujeres";
            // 
            // miPrimeraF
            // 
            this.miPrimeraF.Name = "miPrimeraF";
            this.miPrimeraF.Size = new System.Drawing.Size(136, 22);
            this.miPrimeraF.Text = "Primera";
            this.miPrimeraF.Click += new System.EventHandler(this.miPrimeraF_Click);
            // 
            // miSegundaF
            // 
            this.miSegundaF.Name = "miSegundaF";
            this.miSegundaF.Size = new System.Drawing.Size(136, 22);
            this.miSegundaF.Text = "Segunda";
            this.miSegundaF.Click += new System.EventHandler(this.miSegundaF_Click);
            // 
            // miQuintaF
            // 
            this.miQuintaF.Name = "miQuintaF";
            this.miQuintaF.Size = new System.Drawing.Size(136, 22);
            this.miQuintaF.Text = "Quinta";
            this.miQuintaF.Click += new System.EventHandler(this.miQuintaF_Click);
            // 
            // miSextaF
            // 
            this.miSextaF.Name = "miSextaF";
            this.miSextaF.Size = new System.Drawing.Size(136, 22);
            this.miSextaF.Text = "Sexta";
            this.miSextaF.Click += new System.EventHandler(this.miSextaF_Click);
            // 
            // miSeptimaF
            // 
            this.miSeptimaF.Name = "miSeptimaF";
            this.miSeptimaF.Size = new System.Drawing.Size(136, 22);
            this.miSeptimaF.Text = "Septima";
            this.miSeptimaF.Click += new System.EventHandler(this.miSeptimaF_Click);
            // 
            // miOctavaF
            // 
            this.miOctavaF.Name = "miOctavaF";
            this.miOctavaF.Size = new System.Drawing.Size(136, 22);
            this.miOctavaF.Text = "Octava";
            this.miOctavaF.Click += new System.EventHandler(this.miOctavaF_Click);
            // 
            // miNovenaF
            // 
            this.miNovenaF.Name = "miNovenaF";
            this.miNovenaF.Size = new System.Drawing.Size(136, 22);
            this.miNovenaF.Text = "Novena";
            this.miNovenaF.Click += new System.EventHandler(this.miNovenaF_Click);
            // 
            // miDecimaF
            // 
            this.miDecimaF.Name = "miDecimaF";
            this.miDecimaF.Size = new System.Drawing.Size(136, 22);
            this.miDecimaF.Text = "Decima";
            this.miDecimaF.Click += new System.EventHandler(this.miDecimaF_Click);
            // 
            // miPreDecimaF
            // 
            this.miPreDecimaF.Name = "miPreDecimaF";
            this.miPreDecimaF.Size = new System.Drawing.Size(136, 22);
            this.miPreDecimaF.Text = "Pre-Decima";
            this.miPreDecimaF.Click += new System.EventHandler(this.miPreDecimaF_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(512, 392);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Busqueda:";
            // 
            // socioTableAdapter
            // 
            this.socioTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ActividadesTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriaTableAdapter = null;
            this.tableAdapterManager.CuotaTableAdapter = null;
            this.tableAdapterManager.GrupoTableAdapter = null;
            this.tableAdapterManager.MensualTableAdapter = null;
            this.tableAdapterManager.ProfesionalTableAdapter = null;
            this.tableAdapterManager.SaludTableAdapter = null;
            this.tableAdapterManager.SocioTableAdapter = this.socioTableAdapter;
            this.tableAdapterManager.UpdateOrder = Principal.Club_VistalbaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // saludTableAdapter
            // 
            this.saludTableAdapter.ClearBeforeFill = true;
            // 
            // socioSaludBindingSource
            // 
            this.socioSaludBindingSource.DataMember = "SocioSalud";
            this.socioSaludBindingSource.DataSource = this.socioBindingSource;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 430);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dgvSocio);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Club Vistalba";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSocio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.socioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.club_VistalbaDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.socioSaludBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Club_VistalbaDataSet club_VistalbaDataSet;
        private System.Windows.Forms.BindingSource socioBindingSource;
        private Club_VistalbaDataSetTableAdapters.SocioTableAdapter socioTableAdapter;
        private Club_VistalbaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource socioSaludBindingSource;
        private Club_VistalbaDataSetTableAdapters.SaludTableAdapter saludTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem smiActividades;
        private System.Windows.Forms.ToolStripMenuItem smiProfesionales;
        private System.Windows.Forms.ToolStripMenuItem smiGrupos;
        private System.Windows.Forms.ToolStripMenuItem smiCategorias;
        private System.Windows.Forms.ToolStripMenuItem smiPagos;
        public System.Windows.Forms.DataGridView dgvSocio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn socioGenero;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn socioCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn socioNivel;
        private System.Windows.Forms.ToolStripMenuItem smiInactivos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem divisionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hombresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miPrimeraH;
        private System.Windows.Forms.ToolStripMenuItem segundaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quintaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sextaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem septimaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miOctavaH;
        private System.Windows.Forms.ToolStripMenuItem miNovenaH;
        private System.Windows.Forms.ToolStripMenuItem miDecimaH;
        private System.Windows.Forms.ToolStripMenuItem mujeresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miPreDecimaH;
        private System.Windows.Forms.ToolStripMenuItem miPrimeraF;
        private System.Windows.Forms.ToolStripMenuItem miSegundaF;
        private System.Windows.Forms.ToolStripMenuItem miQuintaF;
        private System.Windows.Forms.ToolStripMenuItem miSextaF;
        private System.Windows.Forms.ToolStripMenuItem miSeptimaF;
        private System.Windows.Forms.ToolStripMenuItem miOctavaF;
        private System.Windows.Forms.ToolStripMenuItem miNovenaF;
        private System.Windows.Forms.ToolStripMenuItem miDecimaF;
        private System.Windows.Forms.ToolStripMenuItem miPreDecimaF;
    }
}

