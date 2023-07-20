namespace appSugerencias
{
    partial class Rep_pagosprogramados
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DG_tabla = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_VENC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUCURSAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BANCO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMPORTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUENTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CONTRIBUYENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROVEEDOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RFC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COMPRA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CONCEPTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ENLACE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FACTURA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ANTICIPADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHECK = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PAGO_PARCIAL = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PAGO_ANTICIPADO = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DT_inicio = new System.Windows.Forms.DateTimePicker();
            this.DT_fin = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BT_aceptar = new System.Windows.Forms.Button();
            this.RB_todos = new System.Windows.Forms.RadioButton();
            this.RB_efectivo = new System.Windows.Forms.RadioButton();
            this.RB_spei = new System.Windows.Forms.RadioButton();
            this.BT_guardar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RB_deposito = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BT_buscar_prov = new System.Windows.Forms.Button();
            this.CB_filtro_prov = new System.Windows.Forms.ComboBox();
            this.RB_prov = new System.Windows.Forms.RadioButton();
            this.RB_prov_serv = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.DG_tabla)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // DG_tabla
            // 
            this.DG_tabla.AllowUserToAddRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.DG_tabla.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DG_tabla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DG_tabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DG_tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.FECHA,
            this.FECHA_VENC,
            this.SUCURSAL,
            this.BANCO,
            this.IMPORTE,
            this.IVA,
            this.CLIENTE,
            this.CUENTA,
            this.CONTRIBUYENTE,
            this.PROVEEDOR,
            this.RFC,
            this.COMPRA,
            this.CONCEPTO,
            this.ENLACE,
            this.FACTURA,
            this.TIPO,
            this.ANTICIPADO,
            this.CHECK,
            this.PAGO_PARCIAL,
            this.PAGO_ANTICIPADO});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DG_tabla.DefaultCellStyle = dataGridViewCellStyle8;
            this.DG_tabla.Location = new System.Drawing.Point(5, 146);
            this.DG_tabla.Name = "DG_tabla";
            this.DG_tabla.Size = new System.Drawing.Size(1902, 417);
            this.DG_tabla.TabIndex = 0;
            this.DG_tabla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_tabla_CellContentClick);
            this.DG_tabla.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_tabla_CellDoubleClick);
            this.DG_tabla.CellStateChanged += new System.Windows.Forms.DataGridViewCellStateChangedEventHandler(this.DG_tabla_CellStateChanged);
            this.DG_tabla.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_tabla_CellValueChanged);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // FECHA
            // 
            this.FECHA.HeaderText = "FECHA";
            this.FECHA.Name = "FECHA";
            this.FECHA.Visible = false;
            // 
            // FECHA_VENC
            // 
            this.FECHA_VENC.HeaderText = "FECHA VENCIMIENTO";
            this.FECHA_VENC.Name = "FECHA_VENC";
            // 
            // SUCURSAL
            // 
            this.SUCURSAL.HeaderText = "SUCURSAL";
            this.SUCURSAL.Name = "SUCURSAL";
            // 
            // BANCO
            // 
            this.BANCO.HeaderText = "BANCO";
            this.BANCO.Name = "BANCO";
            // 
            // IMPORTE
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.IMPORTE.DefaultCellStyle = dataGridViewCellStyle6;
            this.IMPORTE.HeaderText = "IMPORTE";
            this.IMPORTE.Name = "IMPORTE";
            // 
            // IVA
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.IVA.DefaultCellStyle = dataGridViewCellStyle7;
            this.IVA.HeaderText = "IVA";
            this.IVA.Name = "IVA";
            // 
            // CLIENTE
            // 
            this.CLIENTE.HeaderText = "CLIENTE BANCARIO";
            this.CLIENTE.Name = "CLIENTE";
            // 
            // CUENTA
            // 
            this.CUENTA.HeaderText = "CUENTA BANCARIA";
            this.CUENTA.Name = "CUENTA";
            // 
            // CONTRIBUYENTE
            // 
            this.CONTRIBUYENTE.HeaderText = "CONTRIBUYENTE";
            this.CONTRIBUYENTE.Name = "CONTRIBUYENTE";
            // 
            // PROVEEDOR
            // 
            this.PROVEEDOR.HeaderText = "PROVEEDOR";
            this.PROVEEDOR.Name = "PROVEEDOR";
            // 
            // RFC
            // 
            this.RFC.HeaderText = "RFC";
            this.RFC.Name = "RFC";
            // 
            // COMPRA
            // 
            this.COMPRA.HeaderText = "NO. COMPRA";
            this.COMPRA.Name = "COMPRA";
            // 
            // CONCEPTO
            // 
            this.CONCEPTO.HeaderText = "CONCEPTO";
            this.CONCEPTO.Name = "CONCEPTO";
            this.CONCEPTO.Visible = false;
            // 
            // ENLACE
            // 
            this.ENLACE.HeaderText = "ENLACE";
            this.ENLACE.Name = "ENLACE";
            this.ENLACE.Visible = false;
            // 
            // FACTURA
            // 
            this.FACTURA.HeaderText = "FACTURA";
            this.FACTURA.Name = "FACTURA";
            // 
            // TIPO
            // 
            this.TIPO.HeaderText = "TIPO PAGO";
            this.TIPO.Name = "TIPO";
            // 
            // ANTICIPADO
            // 
            this.ANTICIPADO.HeaderText = "ANTICIPADO";
            this.ANTICIPADO.Name = "ANTICIPADO";
            // 
            // CHECK
            // 
            this.CHECK.HeaderText = "CHECK";
            this.CHECK.Name = "CHECK";
            this.CHECK.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CHECK.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // PAGO_PARCIAL
            // 
            this.PAGO_PARCIAL.HeaderText = "PARCIAL";
            this.PAGO_PARCIAL.Name = "PAGO_PARCIAL";
            this.PAGO_PARCIAL.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PAGO_PARCIAL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // PAGO_ANTICIPADO
            // 
            this.PAGO_ANTICIPADO.HeaderText = "PAGO ANTICIPADO";
            this.PAGO_ANTICIPADO.Name = "PAGO_ANTICIPADO";
            // 
            // DT_inicio
            // 
            this.DT_inicio.Location = new System.Drawing.Point(51, 20);
            this.DT_inicio.Name = "DT_inicio";
            this.DT_inicio.Size = new System.Drawing.Size(200, 20);
            this.DT_inicio.TabIndex = 1;
            // 
            // DT_fin
            // 
            this.DT_fin.Location = new System.Drawing.Point(51, 68);
            this.DT_fin.Name = "DT_fin";
            this.DT_fin.Size = new System.Drawing.Size(200, 20);
            this.DT_fin.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "INICIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "FIN";
            // 
            // BT_aceptar
            // 
            this.BT_aceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_aceptar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_aceptar.ForeColor = System.Drawing.Color.White;
            this.BT_aceptar.Location = new System.Drawing.Point(102, 19);
            this.BT_aceptar.Name = "BT_aceptar";
            this.BT_aceptar.Size = new System.Drawing.Size(144, 76);
            this.BT_aceptar.TabIndex = 6;
            this.BT_aceptar.Text = "Aceptar";
            this.BT_aceptar.UseVisualStyleBackColor = false;
            this.BT_aceptar.Click += new System.EventHandler(this.BT_aceptar_Click);
            // 
            // RB_todos
            // 
            this.RB_todos.AutoSize = true;
            this.RB_todos.Location = new System.Drawing.Point(10, 24);
            this.RB_todos.Name = "RB_todos";
            this.RB_todos.Size = new System.Drawing.Size(55, 17);
            this.RB_todos.TabIndex = 7;
            this.RB_todos.TabStop = true;
            this.RB_todos.Text = "Todos";
            this.RB_todos.UseVisualStyleBackColor = true;
            // 
            // RB_efectivo
            // 
            this.RB_efectivo.AutoSize = true;
            this.RB_efectivo.Location = new System.Drawing.Point(10, 44);
            this.RB_efectivo.Name = "RB_efectivo";
            this.RB_efectivo.Size = new System.Drawing.Size(64, 17);
            this.RB_efectivo.TabIndex = 8;
            this.RB_efectivo.TabStop = true;
            this.RB_efectivo.Text = "Efectivo";
            this.RB_efectivo.UseVisualStyleBackColor = true;
            // 
            // RB_spei
            // 
            this.RB_spei.AutoSize = true;
            this.RB_spei.Location = new System.Drawing.Point(10, 83);
            this.RB_spei.Name = "RB_spei";
            this.RB_spei.Size = new System.Drawing.Size(49, 17);
            this.RB_spei.TabIndex = 9;
            this.RB_spei.TabStop = true;
            this.RB_spei.Text = "SPEI";
            this.RB_spei.UseVisualStyleBackColor = true;
            // 
            // BT_guardar
            // 
            this.BT_guardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_guardar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_guardar.ForeColor = System.Drawing.Color.White;
            this.BT_guardar.Location = new System.Drawing.Point(24, 23);
            this.BT_guardar.Name = "BT_guardar";
            this.BT_guardar.Size = new System.Drawing.Size(139, 73);
            this.BT_guardar.TabIndex = 10;
            this.BT_guardar.Text = "Guardar Estado";
            this.BT_guardar.UseVisualStyleBackColor = false;
            this.BT_guardar.Click += new System.EventHandler(this.BT_guardar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.RB_deposito);
            this.groupBox1.Controls.Add(this.RB_spei);
            this.groupBox1.Controls.Add(this.RB_todos);
            this.groupBox1.Controls.Add(this.RB_efectivo);
            this.groupBox1.Controls.Add(this.BT_aceptar);
            this.groupBox1.Location = new System.Drawing.Point(287, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 109);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de pago";
            // 
            // RB_deposito
            // 
            this.RB_deposito.AutoSize = true;
            this.RB_deposito.Location = new System.Drawing.Point(10, 64);
            this.RB_deposito.Name = "RB_deposito";
            this.RB_deposito.Size = new System.Drawing.Size(86, 17);
            this.RB_deposito.TabIndex = 10;
            this.RB_deposito.TabStop = true;
            this.RB_deposito.Text = "Deposito Efe";
            this.RB_deposito.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DT_fin);
            this.groupBox2.Controls.Add(this.DT_inicio);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(269, 109);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fecha de solicitud de pago";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.BT_guardar);
            this.groupBox3.Location = new System.Drawing.Point(565, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(193, 109);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Guardar Estado";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Location = new System.Drawing.Point(1874, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(28, 28);
            this.panel1.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1796, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "PAGO TOTAL";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1786, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "PAGO PARCIAL";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Yellow;
            this.panel2.Location = new System.Drawing.Point(1874, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(28, 28);
            this.panel2.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1766, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "PAGO ANTICIPADO";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel3.Location = new System.Drawing.Point(1874, 107);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(28, 28);
            this.panel3.TabIndex = 18;
            // 
            // BT_buscar_prov
            // 
            this.BT_buscar_prov.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_buscar_prov.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_buscar_prov.ForeColor = System.Drawing.Color.White;
            this.BT_buscar_prov.Location = new System.Drawing.Point(15, 69);
            this.BT_buscar_prov.Name = "BT_buscar_prov";
            this.BT_buscar_prov.Size = new System.Drawing.Size(123, 31);
            this.BT_buscar_prov.TabIndex = 20;
            this.BT_buscar_prov.Text = "Buscar Proveedor";
            this.BT_buscar_prov.UseVisualStyleBackColor = false;
            this.BT_buscar_prov.Click += new System.EventHandler(this.BT_buscar_prov_Click);
            // 
            // CB_filtro_prov
            // 
            this.CB_filtro_prov.FormattingEnabled = true;
            this.CB_filtro_prov.Location = new System.Drawing.Point(15, 42);
            this.CB_filtro_prov.Name = "CB_filtro_prov";
            this.CB_filtro_prov.Size = new System.Drawing.Size(311, 21);
            this.CB_filtro_prov.TabIndex = 21;
            this.CB_filtro_prov.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CB_filtro_prov_KeyPress);
            // 
            // RB_prov
            // 
            this.RB_prov.AutoSize = true;
            this.RB_prov.Location = new System.Drawing.Point(191, 21);
            this.RB_prov.Name = "RB_prov";
            this.RB_prov.Size = new System.Drawing.Size(135, 17);
            this.RB_prov.TabIndex = 22;
            this.RB_prov.TabStop = true;
            this.RB_prov.Text = "Proveedores productos";
            this.RB_prov.UseVisualStyleBackColor = true;
            this.RB_prov.CheckedChanged += new System.EventHandler(this.RB_prov_CheckedChanged);
            // 
            // RB_prov_serv
            // 
            this.RB_prov_serv.AutoSize = true;
            this.RB_prov_serv.Location = new System.Drawing.Point(15, 21);
            this.RB_prov_serv.Name = "RB_prov_serv";
            this.RB_prov_serv.Size = new System.Drawing.Size(131, 17);
            this.RB_prov_serv.TabIndex = 23;
            this.RB_prov_serv.TabStop = true;
            this.RB_prov_serv.Text = "Proveedores Servicios";
            this.RB_prov_serv.UseVisualStyleBackColor = true;
            this.RB_prov_serv.CheckedChanged += new System.EventHandler(this.RB_prov_serv_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.RB_prov_serv);
            this.groupBox4.Controls.Add(this.BT_buscar_prov);
            this.groupBox4.Controls.Add(this.RB_prov);
            this.groupBox4.Controls.Add(this.CB_filtro_prov);
            this.groupBox4.Location = new System.Drawing.Point(764, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(351, 109);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Buscar pagos anticipados por proveedor";
            // 
            // Rep_pagosprogramados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1909, 575);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DG_tabla);
            this.Name = "Rep_pagosprogramados";
            this.Text = "Reporte de Solitud de Pagos";
            this.Load += new System.EventHandler(this.Rep_pagosprogramados_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Rep_pagosprogramados_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.DG_tabla)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DG_tabla;
        private System.Windows.Forms.DateTimePicker DT_inicio;
        private System.Windows.Forms.DateTimePicker DT_fin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BT_aceptar;
        private System.Windows.Forms.RadioButton RB_todos;
        private System.Windows.Forms.RadioButton RB_efectivo;
        private System.Windows.Forms.RadioButton RB_spei;
        private System.Windows.Forms.Button BT_guardar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton RB_deposito;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_VENC;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUCURSAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn BANCO;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMPORTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn IVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUENTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CONTRIBUYENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROVEEDOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn RFC;
        private System.Windows.Forms.DataGridViewTextBoxColumn COMPRA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CONCEPTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ENLACE;
        private System.Windows.Forms.DataGridViewTextBoxColumn FACTURA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ANTICIPADO;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CHECK;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PAGO_PARCIAL;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PAGO_ANTICIPADO;
        private System.Windows.Forms.Button BT_buscar_prov;
        private System.Windows.Forms.ComboBox CB_filtro_prov;
        private System.Windows.Forms.RadioButton RB_prov;
        private System.Windows.Forms.RadioButton RB_prov_serv;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}