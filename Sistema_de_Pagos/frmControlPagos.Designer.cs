namespace Sistema_de_Pagos
{
    partial class frmControlPagos
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
            System.Windows.Forms.Label iD_PagosLabel;
            System.Windows.Forms.Label fecha_de_RegistroLabel;
            System.Windows.Forms.Label empleadoLabel;
            System.Windows.Forms.Label categoríaLabel;
            System.Windows.Forms.Label sueldoLabel;
            System.Windows.Forms.Label descuentoLabel;
            System.Windows.Forms.Label netoLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle41 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabla_de_PagosDataGridView = new System.Windows.Forms.DataGridView();
            this.tabla_de_PagosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetControlPagos = new Sistema_de_Pagos.DataSetControlPagos();
            this.iD_PagosTextBox = new System.Windows.Forms.TextBox();
            this.fecha_de_RegistroDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.empleadoTextBox = new System.Windows.Forms.TextBox();
            this.categoríaComboBox = new System.Windows.Forms.ComboBox();
            this.sueldoTextBox = new System.Windows.Forms.TextBox();
            this.descuentoTextBox = new System.Windows.Forms.TextBox();
            this.netoTextBox = new System.Windows.Forms.TextBox();
            this.btnNuevo = new Guna.UI2.WinForms.Guna2Button();
            this.btnGuardar = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditar = new Guna.UI2.WinForms.Guna2Button();
            this.btnEliminar = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            this.btnBuscar = new Guna.UI2.WinForms.Guna2Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabla_de_PagosTableAdapter = new Sistema_de_Pagos.DataSetControlPagosTableAdapters.Tabla_de_PagosTableAdapter();
            this.tableAdapterManager = new Sistema_de_Pagos.DataSetControlPagosTableAdapters.TableAdapterManager();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            iD_PagosLabel = new System.Windows.Forms.Label();
            fecha_de_RegistroLabel = new System.Windows.Forms.Label();
            empleadoLabel = new System.Windows.Forms.Label();
            categoríaLabel = new System.Windows.Forms.Label();
            sueldoLabel = new System.Windows.Forms.Label();
            descuentoLabel = new System.Windows.Forms.Label();
            netoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_de_PagosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_de_PagosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetControlPagos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_PagosLabel
            // 
            iD_PagosLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            iD_PagosLabel.AutoSize = true;
            iD_PagosLabel.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iD_PagosLabel.Location = new System.Drawing.Point(587, 171);
            iD_PagosLabel.Name = "iD_PagosLabel";
            iD_PagosLabel.Size = new System.Drawing.Size(48, 15);
            iD_PagosLabel.TabIndex = 1;
            iD_PagosLabel.Text = "Código:";
            // 
            // fecha_de_RegistroLabel
            // 
            fecha_de_RegistroLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            fecha_de_RegistroLabel.AutoSize = true;
            fecha_de_RegistroLabel.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fecha_de_RegistroLabel.Location = new System.Drawing.Point(824, 172);
            fecha_de_RegistroLabel.Name = "fecha_de_RegistroLabel";
            fecha_de_RegistroLabel.Size = new System.Drawing.Size(109, 15);
            fecha_de_RegistroLabel.TabIndex = 3;
            fecha_de_RegistroLabel.Text = "Fecha de Registro:";
            // 
            // empleadoLabel
            // 
            empleadoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            empleadoLabel.AutoSize = true;
            empleadoLabel.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            empleadoLabel.Location = new System.Drawing.Point(587, 213);
            empleadoLabel.Name = "empleadoLabel";
            empleadoLabel.Size = new System.Drawing.Size(65, 15);
            empleadoLabel.TabIndex = 5;
            empleadoLabel.Text = "Empleado:";
            // 
            // categoríaLabel
            // 
            categoríaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            categoríaLabel.AutoSize = true;
            categoríaLabel.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            categoríaLabel.Location = new System.Drawing.Point(587, 259);
            categoríaLabel.Name = "categoríaLabel";
            categoríaLabel.Size = new System.Drawing.Size(63, 15);
            categoríaLabel.TabIndex = 7;
            categoríaLabel.Text = "Categoría:";
            // 
            // sueldoLabel
            // 
            sueldoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            sueldoLabel.AutoSize = true;
            sueldoLabel.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sueldoLabel.Location = new System.Drawing.Point(933, 254);
            sueldoLabel.Name = "sueldoLabel";
            sueldoLabel.Size = new System.Drawing.Size(48, 15);
            sueldoLabel.TabIndex = 9;
            sueldoLabel.Text = "Sueldo:";
            sueldoLabel.Click += new System.EventHandler(this.sueldoLabel_Click);
            // 
            // descuentoLabel
            // 
            descuentoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            descuentoLabel.AutoSize = true;
            descuentoLabel.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descuentoLabel.Location = new System.Drawing.Point(587, 295);
            descuentoLabel.Name = "descuentoLabel";
            descuentoLabel.Size = new System.Drawing.Size(36, 15);
            descuentoLabel.TabIndex = 11;
            descuentoLabel.Text = "IGSS:";
            // 
            // netoLabel
            // 
            netoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            netoLabel.AutoSize = true;
            netoLabel.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            netoLabel.Location = new System.Drawing.Point(890, 300);
            netoLabel.Name = "netoLabel";
            netoLabel.Size = new System.Drawing.Size(90, 15);
            netoLabel.TabIndex = 13;
            netoLabel.Text = "Salario Líquido:";
            // 
            // tabla_de_PagosDataGridView
            // 
            this.tabla_de_PagosDataGridView.AllowUserToAddRows = false;
            this.tabla_de_PagosDataGridView.AllowUserToDeleteRows = false;
            this.tabla_de_PagosDataGridView.AllowUserToOrderColumns = true;
            this.tabla_de_PagosDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabla_de_PagosDataGridView.AutoGenerateColumns = false;
            this.tabla_de_PagosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tabla_de_PagosDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(224)))), ((int)(((byte)(201)))));
            this.tabla_de_PagosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla_de_PagosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.tabla_de_PagosDataGridView.DataSource = this.tabla_de_PagosBindingSource;
            this.tabla_de_PagosDataGridView.Location = new System.Drawing.Point(-1, 477);
            this.tabla_de_PagosDataGridView.Name = "tabla_de_PagosDataGridView";
            this.tabla_de_PagosDataGridView.ReadOnly = true;
            this.tabla_de_PagosDataGridView.Size = new System.Drawing.Size(1800, 419);
            this.tabla_de_PagosDataGridView.TabIndex = 0;
            this.tabla_de_PagosDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabla_de_PagosDataGridView_CellContentClick_1);
            // 
            // tabla_de_PagosBindingSource
            // 
            this.tabla_de_PagosBindingSource.DataMember = "Tabla_de_Pagos";
            this.tabla_de_PagosBindingSource.DataSource = this.dataSetControlPagos;
            // 
            // dataSetControlPagos
            // 
            this.dataSetControlPagos.DataSetName = "DataSetControlPagos";
            this.dataSetControlPagos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iD_PagosTextBox
            // 
            this.iD_PagosTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iD_PagosTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.iD_PagosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabla_de_PagosBindingSource, "ID_Pagos", true));
            this.iD_PagosTextBox.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iD_PagosTextBox.Location = new System.Drawing.Point(661, 168);
            this.iD_PagosTextBox.Name = "iD_PagosTextBox";
            this.iD_PagosTextBox.ReadOnly = true;
            this.iD_PagosTextBox.Size = new System.Drawing.Size(118, 23);
            this.iD_PagosTextBox.TabIndex = 2;
            // 
            // fecha_de_RegistroDateTimePicker
            // 
            this.fecha_de_RegistroDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fecha_de_RegistroDateTimePicker.CalendarMonthBackground = System.Drawing.SystemColors.InactiveBorder;
            this.fecha_de_RegistroDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tabla_de_PagosBindingSource, "Fecha_de_Registro", true));
            this.fecha_de_RegistroDateTimePicker.Enabled = false;
            this.fecha_de_RegistroDateTimePicker.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha_de_RegistroDateTimePicker.Location = new System.Drawing.Point(936, 168);
            this.fecha_de_RegistroDateTimePicker.Name = "fecha_de_RegistroDateTimePicker";
            this.fecha_de_RegistroDateTimePicker.Size = new System.Drawing.Size(244, 23);
            this.fecha_de_RegistroDateTimePicker.TabIndex = 4;
            // 
            // empleadoTextBox
            // 
            this.empleadoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.empleadoTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.empleadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabla_de_PagosBindingSource, "Empleado", true));
            this.empleadoTextBox.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empleadoTextBox.Location = new System.Drawing.Point(661, 210);
            this.empleadoTextBox.Name = "empleadoTextBox";
            this.empleadoTextBox.ReadOnly = true;
            this.empleadoTextBox.Size = new System.Drawing.Size(519, 23);
            this.empleadoTextBox.TabIndex = 6;
            // 
            // categoríaComboBox
            // 
            this.categoríaComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.categoríaComboBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.categoríaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabla_de_PagosBindingSource, "Categoría", true));
            this.categoríaComboBox.Enabled = false;
            this.categoríaComboBox.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoríaComboBox.FormattingEnabled = true;
            this.categoríaComboBox.Items.AddRange(new object[] {
            "Jefe",
            "Administrador",
            "Técnico",
            "Operario",
            "Intendente"});
            this.categoríaComboBox.Location = new System.Drawing.Point(661, 251);
            this.categoríaComboBox.Name = "categoríaComboBox";
            this.categoríaComboBox.Size = new System.Drawing.Size(252, 23);
            this.categoríaComboBox.TabIndex = 8;
            this.categoríaComboBox.SelectedIndexChanged += new System.EventHandler(this.categoríaComboBox_SelectedIndexChanged);
            // 
            // sueldoTextBox
            // 
            this.sueldoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sueldoTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.sueldoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabla_de_PagosBindingSource, "Sueldo", true));
            this.sueldoTextBox.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sueldoTextBox.Location = new System.Drawing.Point(986, 251);
            this.sueldoTextBox.Name = "sueldoTextBox";
            this.sueldoTextBox.ReadOnly = true;
            this.sueldoTextBox.Size = new System.Drawing.Size(194, 23);
            this.sueldoTextBox.TabIndex = 10;
            this.sueldoTextBox.TextChanged += new System.EventHandler(this.sueldoTextBox_TextChanged);
            // 
            // descuentoTextBox
            // 
            this.descuentoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descuentoTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.descuentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabla_de_PagosBindingSource, "Descuento", true));
            this.descuentoTextBox.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descuentoTextBox.Location = new System.Drawing.Point(661, 292);
            this.descuentoTextBox.Name = "descuentoTextBox";
            this.descuentoTextBox.ReadOnly = true;
            this.descuentoTextBox.Size = new System.Drawing.Size(160, 23);
            this.descuentoTextBox.TabIndex = 12;
            // 
            // netoTextBox
            // 
            this.netoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.netoTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.netoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabla_de_PagosBindingSource, "Neto", true));
            this.netoTextBox.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.netoTextBox.Location = new System.Drawing.Point(986, 295);
            this.netoTextBox.Name = "netoTextBox";
            this.netoTextBox.ReadOnly = true;
            this.netoTextBox.Size = new System.Drawing.Size(194, 23);
            this.netoTextBox.TabIndex = 14;
            // 
            // btnNuevo
            // 
            this.btnNuevo.AutoRoundedCorners = true;
            this.btnNuevo.BorderRadius = 21;
            this.btnNuevo.CheckedState.Parent = this.btnNuevo;
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.CustomImages.Parent = this.btnNuevo;
            this.btnNuevo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(182)))), ((int)(((byte)(197)))));
            this.btnNuevo.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.HoverState.Parent = this.btnNuevo;
            this.btnNuevo.Location = new System.Drawing.Point(502, 346);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.ShadowDecoration.Parent = this.btnNuevo;
            this.btnNuevo.Size = new System.Drawing.Size(126, 45);
            this.btnNuevo.TabIndex = 15;
            this.btnNuevo.Text = "Nueva Entrada";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.AutoRoundedCorners = true;
            this.btnGuardar.BorderRadius = 21;
            this.btnGuardar.CheckedState.Parent = this.btnGuardar;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.CustomImages.Parent = this.btnGuardar;
            this.btnGuardar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(182)))), ((int)(((byte)(197)))));
            this.btnGuardar.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.HoverState.Parent = this.btnGuardar;
            this.btnGuardar.Location = new System.Drawing.Point(634, 346);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.ShadowDecoration.Parent = this.btnGuardar;
            this.btnGuardar.Size = new System.Drawing.Size(126, 45);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.AutoRoundedCorners = true;
            this.btnEditar.BorderRadius = 21;
            this.btnEditar.CheckedState.Parent = this.btnEditar;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.CustomImages.Parent = this.btnEditar;
            this.btnEditar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(182)))), ((int)(((byte)(197)))));
            this.btnEditar.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.HoverState.Parent = this.btnEditar;
            this.btnEditar.Location = new System.Drawing.Point(766, 346);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.ShadowDecoration.Parent = this.btnEditar;
            this.btnEditar.Size = new System.Drawing.Size(126, 45);
            this.btnEditar.TabIndex = 17;
            this.btnEditar.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.AutoRoundedCorners = true;
            this.btnEliminar.BorderRadius = 21;
            this.btnEliminar.CheckedState.Parent = this.btnEliminar;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.CustomImages.Parent = this.btnEliminar;
            this.btnEliminar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(182)))), ((int)(((byte)(197)))));
            this.btnEliminar.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.HoverState.Parent = this.btnEliminar;
            this.btnEliminar.Location = new System.Drawing.Point(898, 346);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.ShadowDecoration.Parent = this.btnEliminar;
            this.btnEliminar.Size = new System.Drawing.Size(126, 45);
            this.btnEliminar.TabIndex = 18;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoRoundedCorners = true;
            this.btnCancelar.BorderRadius = 21;
            this.btnCancelar.CheckedState.Parent = this.btnCancelar;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.CustomImages.Parent = this.btnCancelar;
            this.btnCancelar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(182)))), ((int)(((byte)(197)))));
            this.btnCancelar.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.HoverState.Parent = this.btnCancelar;
            this.btnCancelar.Location = new System.Drawing.Point(1030, 346);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.ShadowDecoration.Parent = this.btnCancelar;
            this.btnCancelar.Size = new System.Drawing.Size(126, 45);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.AutoRoundedCorners = true;
            this.btnBuscar.BorderRadius = 21;
            this.btnBuscar.CheckedState.Parent = this.btnBuscar;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.CustomImages.Parent = this.btnBuscar;
            this.btnBuscar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(182)))), ((int)(((byte)(197)))));
            this.btnBuscar.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.HoverState.Parent = this.btnBuscar;
            this.btnBuscar.Location = new System.Drawing.Point(1162, 346);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.ShadowDecoration.Parent = this.btnBuscar;
            this.btnBuscar.Size = new System.Drawing.Size(126, 45);
            this.btnBuscar.TabIndex = 20;
            this.btnBuscar.Text = "Generar Cheque";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // tabla_de_PagosTableAdapter
            // 
            this.tabla_de_PagosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Tabla_de_PagosTableAdapter = this.tabla_de_PagosTableAdapter;
            this.tableAdapterManager.UpdateOrder = Sistema_de_Pagos.DataSetControlPagosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_Pagos";
            dataGridViewCellStyle36.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle36.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle36.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle36.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle36.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle36;
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Fecha_de_Registro";
            dataGridViewCellStyle37.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle37.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle37;
            this.dataGridViewTextBoxColumn2.HeaderText = "Fecha de Registro";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Empleado";
            dataGridViewCellStyle38.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle38.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle38;
            this.dataGridViewTextBoxColumn3.HeaderText = "Empleados";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Categoría";
            dataGridViewCellStyle39.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle39.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle39;
            this.dataGridViewTextBoxColumn4.HeaderText = "Categoría";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Sueldo";
            dataGridViewCellStyle40.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle40.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle40;
            this.dataGridViewTextBoxColumn5.HeaderText = "Sueldo";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Descuento";
            dataGridViewCellStyle41.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle41.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle41;
            this.dataGridViewTextBoxColumn6.HeaderText = "Descuento";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Neto";
            dataGridViewCellStyle42.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle42.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle42;
            this.dataGridViewTextBoxColumn7.HeaderText = "Salario Líquido";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Candara", 45F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(182)))), ((int)(((byte)(197)))));
            this.errorProvider1.SetIconAlignment(this.label1, System.Windows.Forms.ErrorIconAlignment.TopRight);
            this.label1.Location = new System.Drawing.Point(676, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(480, 73);
            this.label1.TabIndex = 21;
            this.label1.Text = "Sistema de Pagos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmControlPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(240)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(1800, 896);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(netoLabel);
            this.Controls.Add(this.netoTextBox);
            this.Controls.Add(descuentoLabel);
            this.Controls.Add(this.descuentoTextBox);
            this.Controls.Add(sueldoLabel);
            this.Controls.Add(this.sueldoTextBox);
            this.Controls.Add(categoríaLabel);
            this.Controls.Add(this.categoríaComboBox);
            this.Controls.Add(empleadoLabel);
            this.Controls.Add(this.empleadoTextBox);
            this.Controls.Add(fecha_de_RegistroLabel);
            this.Controls.Add(this.fecha_de_RegistroDateTimePicker);
            this.Controls.Add(iD_PagosLabel);
            this.Controls.Add(this.iD_PagosTextBox);
            this.Controls.Add(this.tabla_de_PagosDataGridView);
            this.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmControlPagos";
            this.Load += new System.EventHandler(this.frmControlPagos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabla_de_PagosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_de_PagosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetControlPagos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSetControlPagos dataSetControlPagos;
        private System.Windows.Forms.BindingSource tabla_de_PagosBindingSource;
        private DataSetControlPagosTableAdapters.Tabla_de_PagosTableAdapter tabla_de_PagosTableAdapter;
        private DataSetControlPagosTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView tabla_de_PagosDataGridView;
        private System.Windows.Forms.TextBox iD_PagosTextBox;
        private System.Windows.Forms.DateTimePicker fecha_de_RegistroDateTimePicker;
        private System.Windows.Forms.TextBox empleadoTextBox;
        private System.Windows.Forms.ComboBox categoríaComboBox;
        private System.Windows.Forms.TextBox sueldoTextBox;
        private System.Windows.Forms.TextBox descuentoTextBox;
        private System.Windows.Forms.TextBox netoTextBox;
        private Guna.UI2.WinForms.Guna2Button btnNuevo;
        private Guna.UI2.WinForms.Guna2Button btnGuardar;
        private Guna.UI2.WinForms.Guna2Button btnEditar;
        private Guna.UI2.WinForms.Guna2Button btnEliminar;
        private Guna.UI2.WinForms.Guna2Button btnCancelar;
        private Guna.UI2.WinForms.Guna2Button btnBuscar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Label label1;
    }
}