namespace appSugerencias
{
    partial class CuentasXPagar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CuentasXPagar));
            this.CB_proveedor = new System.Windows.Forms.ComboBox();
            this.DG_datos = new System.Windows.Forms.DataGridView();
            this.IDMOV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPO_DOCUMENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REFERENCIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MOVIMIENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUCURSAL_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COMPRA_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PAGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SALDO_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OBSERV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COBRADOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TB_proveedor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROVEEDOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LB_bo = new System.Windows.Forms.Label();
            this.LB_va = new System.Windows.Forms.Label();
            this.LB_re = new System.Windows.Forms.Label();
            this.LB_co = new System.Windows.Forms.Label();
            this.LB_ve = new System.Windows.Forms.Label();
            this.LB_pre = new System.Windows.Forms.Label();
            this.BT_Buscar = new System.Windows.Forms.Button();
            this.TB_filtro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PN_conexiones = new System.Windows.Forms.Panel();
            this.IDPAGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDPROVEEDOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_MOV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPO_DOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MOV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BT_abonos = new System.Windows.Forms.Button();
            this.CHB_bodega = new System.Windows.Forms.CheckBox();
            this.CHB_vallarta = new System.Windows.Forms.CheckBox();
            this.CHB_rena = new System.Windows.Forms.CheckBox();
            this.CHB_velazquez = new System.Windows.Forms.CheckBox();
            this.CHB_coloso = new System.Windows.Forms.CheckBox();
            this.CHB_pregot = new System.Windows.Forms.CheckBox();
            this.BT_buscar_compra = new System.Windows.Forms.Button();
            this.TB_compra = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BT_cuentasOS = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LB_saldo = new System.Windows.Forms.Label();
            this.BT_guardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DG_datos)).BeginInit();
            this.PN_conexiones.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CB_proveedor
            // 
            this.CB_proveedor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CB_proveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_proveedor.FormattingEnabled = true;
            this.CB_proveedor.Location = new System.Drawing.Point(228, 92);
            this.CB_proveedor.Name = "CB_proveedor";
            this.CB_proveedor.Size = new System.Drawing.Size(1186, 33);
            this.CB_proveedor.TabIndex = 3;
            this.CB_proveedor.SelectedIndexChanged += new System.EventHandler(this.CB_proveedor_SelectedIndexChanged);
            this.CB_proveedor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CB_proveedor_KeyDown);
            // 
            // DG_datos
            // 
            this.DG_datos.AllowUserToAddRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.LightSkyBlue;
            this.DG_datos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DG_datos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DG_datos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DG_datos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DG_datos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_datos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DG_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_datos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDMOV,
            this.PROV,
            this.FECHA_,
            this.TIPO_DOCUMENTO,
            this.REFERENCIA,
            this.MOVIMIENTO,
            this.SUCURSAL_,
            this.COMPRA_,
            this.PAGO,
            this.SALDO_,
            this.OBSERV,
            this.COBRADOR});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DG_datos.DefaultCellStyle = dataGridViewCellStyle10;
            this.DG_datos.EnableHeadersVisualStyles = false;
            this.DG_datos.Location = new System.Drawing.Point(2, 163);
            this.DG_datos.Name = "DG_datos";
            this.DG_datos.Size = new System.Drawing.Size(1840, 532);
            this.DG_datos.TabIndex = 9;
            this.DG_datos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_datos_CellClick);
            this.DG_datos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_datos_CellContentClick);
            this.DG_datos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_datos_CellDoubleClick);
            // 
            // IDMOV
            // 
            this.IDMOV.HeaderText = "COMPRA";
            this.IDMOV.Name = "IDMOV";
            // 
            // PROV
            // 
            this.PROV.HeaderText = "PROVEEDOR";
            this.PROV.Name = "PROV";
            // 
            // FECHA_
            // 
            this.FECHA_.HeaderText = "FECHA";
            this.FECHA_.Name = "FECHA_";
            // 
            // TIPO_DOCUMENTO
            // 
            this.TIPO_DOCUMENTO.HeaderText = "TIPO_DOC";
            this.TIPO_DOCUMENTO.Name = "TIPO_DOCUMENTO";
            // 
            // REFERENCIA
            // 
            this.REFERENCIA.HeaderText = "REFERENCIA";
            this.REFERENCIA.Name = "REFERENCIA";
            // 
            // MOVIMIENTO
            // 
            this.MOVIMIENTO.HeaderText = "MOV";
            this.MOVIMIENTO.Name = "MOVIMIENTO";
            // 
            // SUCURSAL_
            // 
            this.SUCURSAL_.HeaderText = "SUCURSAL";
            this.SUCURSAL_.Name = "SUCURSAL_";
            // 
            // COMPRA_
            // 
            this.COMPRA_.HeaderText = "CARGO/COMPRA";
            this.COMPRA_.Name = "COMPRA_";
            // 
            // PAGO
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.PAGO.DefaultCellStyle = dataGridViewCellStyle8;
            this.PAGO.HeaderText = "ABONO/PAGO";
            this.PAGO.Name = "PAGO";
            // 
            // SALDO_
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.SALDO_.DefaultCellStyle = dataGridViewCellStyle9;
            this.SALDO_.HeaderText = "SALDO";
            this.SALDO_.Name = "SALDO_";
            // 
            // OBSERV
            // 
            this.OBSERV.HeaderText = "OBSERV";
            this.OBSERV.Name = "OBSERV";
            this.OBSERV.Visible = false;
            // 
            // COBRADOR
            // 
            this.COBRADOR.HeaderText = "COBRADOR";
            this.COBRADOR.Name = "COBRADOR";
            this.COBRADOR.Visible = false;
            // 
            // TB_proveedor
            // 
            this.TB_proveedor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TB_proveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_proveedor.Location = new System.Drawing.Point(1420, 94);
            this.TB_proveedor.Name = "TB_proveedor";
            this.TB_proveedor.Size = new System.Drawing.Size(100, 31);
            this.TB_proveedor.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(68, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "PROVEEDOR";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // PROVEEDOR
            // 
            this.PROVEEDOR.HeaderText = "PROVEEDOR";
            this.PROVEEDOR.Name = "PROVEEDOR";
            // 
            // LB_bo
            // 
            this.LB_bo.AutoSize = true;
            this.LB_bo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_bo.ForeColor = System.Drawing.Color.Gray;
            this.LB_bo.Location = new System.Drawing.Point(8, 12);
            this.LB_bo.Name = "LB_bo";
            this.LB_bo.Size = new System.Drawing.Size(58, 13);
            this.LB_bo.TabIndex = 10;
            this.LB_bo.Text = "BODEGA";
            // 
            // LB_va
            // 
            this.LB_va.AutoSize = true;
            this.LB_va.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_va.ForeColor = System.Drawing.Color.Gray;
            this.LB_va.Location = new System.Drawing.Point(111, 12);
            this.LB_va.Name = "LB_va";
            this.LB_va.Size = new System.Drawing.Size(70, 13);
            this.LB_va.TabIndex = 11;
            this.LB_va.Text = "VALLARTA";
            // 
            // LB_re
            // 
            this.LB_re.AutoSize = true;
            this.LB_re.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_re.ForeColor = System.Drawing.Color.Gray;
            this.LB_re.Location = new System.Drawing.Point(223, 12);
            this.LB_re.Name = "LB_re";
            this.LB_re.Size = new System.Drawing.Size(41, 13);
            this.LB_re.TabIndex = 12;
            this.LB_re.Text = "RENA";
            // 
            // LB_co
            // 
            this.LB_co.AutoSize = true;
            this.LB_co.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_co.ForeColor = System.Drawing.Color.Gray;
            this.LB_co.Location = new System.Drawing.Point(424, 12);
            this.LB_co.Name = "LB_co";
            this.LB_co.Size = new System.Drawing.Size(57, 13);
            this.LB_co.TabIndex = 13;
            this.LB_co.Text = "COLOSO";
            // 
            // LB_ve
            // 
            this.LB_ve.AutoSize = true;
            this.LB_ve.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_ve.ForeColor = System.Drawing.Color.Gray;
            this.LB_ve.Location = new System.Drawing.Point(314, 12);
            this.LB_ve.Name = "LB_ve";
            this.LB_ve.Size = new System.Drawing.Size(80, 13);
            this.LB_ve.TabIndex = 14;
            this.LB_ve.Text = "VELAZQUEZ";
            // 
            // LB_pre
            // 
            this.LB_pre.AutoSize = true;
            this.LB_pre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_pre.ForeColor = System.Drawing.Color.Gray;
            this.LB_pre.Location = new System.Drawing.Point(691, 60);
            this.LB_pre.Name = "LB_pre";
            this.LB_pre.Size = new System.Drawing.Size(58, 13);
            this.LB_pre.TabIndex = 15;
            this.LB_pre.Text = "PREGOT";
            this.LB_pre.Visible = false;
            // 
            // BT_Buscar
            // 
            this.BT_Buscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BT_Buscar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Buscar.ForeColor = System.Drawing.Color.White;
            this.BT_Buscar.Location = new System.Drawing.Point(1526, 94);
            this.BT_Buscar.Name = "BT_Buscar";
            this.BT_Buscar.Size = new System.Drawing.Size(92, 36);
            this.BT_Buscar.TabIndex = 22;
            this.BT_Buscar.Text = "Buscar";
            this.BT_Buscar.UseVisualStyleBackColor = false;
            this.BT_Buscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // TB_filtro
            // 
            this.TB_filtro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TB_filtro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_filtro.Location = new System.Drawing.Point(228, 49);
            this.TB_filtro.Name = "TB_filtro";
            this.TB_filtro.Size = new System.Drawing.Size(273, 31);
            this.TB_filtro.TabIndex = 2;
            this.TB_filtro.TextChanged += new System.EventHandler(this.TB_filtro_TextChanged_1);
            this.TB_filtro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_filtro_KeyDown);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(130, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "FILTRO";
            // 
            // PN_conexiones
            // 
            this.PN_conexiones.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PN_conexiones.BackColor = System.Drawing.Color.White;
            this.PN_conexiones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PN_conexiones.Controls.Add(this.LB_bo);
            this.PN_conexiones.Controls.Add(this.LB_va);
            this.PN_conexiones.Controls.Add(this.LB_re);
            this.PN_conexiones.Controls.Add(this.LB_co);
            this.PN_conexiones.Controls.Add(this.LB_ve);
            this.PN_conexiones.Location = new System.Drawing.Point(790, 42);
            this.PN_conexiones.Name = "PN_conexiones";
            this.PN_conexiones.Size = new System.Drawing.Size(512, 43);
            this.PN_conexiones.TabIndex = 26;
            // 
            // IDPAGO
            // 
            this.IDPAGO.HeaderText = "ID";
            this.IDPAGO.Name = "IDPAGO";
            // 
            // IDPROVEEDOR
            // 
            this.IDPROVEEDOR.Name = "IDPROVEEDOR";
            // 
            // FECHA_MOV
            // 
            this.FECHA_MOV.HeaderText = "FECHA";
            this.FECHA_MOV.Name = "FECHA_MOV";
            // 
            // TIPO_DOC
            // 
            this.TIPO_DOC.HeaderText = "TIPO_DOC";
            this.TIPO_DOC.Name = "TIPO_DOC";
            // 
            // REF
            // 
            this.REF.HeaderText = "DESCRIPCION";
            this.REF.Name = "REF";
            // 
            // MOV
            // 
            this.MOV.HeaderText = "MOV";
            this.MOV.Name = "MOV";
            // 
            // BT_abonos
            // 
            this.BT_abonos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BT_abonos.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_abonos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_abonos.ForeColor = System.Drawing.Color.White;
            this.BT_abonos.Location = new System.Drawing.Point(403, 3);
            this.BT_abonos.Name = "BT_abonos";
            this.BT_abonos.Size = new System.Drawing.Size(98, 36);
            this.BT_abonos.TabIndex = 8;
            this.BT_abonos.Text = "Abonos";
            this.BT_abonos.UseVisualStyleBackColor = false;
            this.BT_abonos.Click += new System.EventHandler(this.BT_abonos_Click);
            // 
            // CHB_bodega
            // 
            this.CHB_bodega.AutoSize = true;
            this.CHB_bodega.Location = new System.Drawing.Point(790, 22);
            this.CHB_bodega.Name = "CHB_bodega";
            this.CHB_bodega.Size = new System.Drawing.Size(63, 17);
            this.CHB_bodega.TabIndex = 28;
            this.CHB_bodega.Text = "Bodega";
            this.CHB_bodega.UseVisualStyleBackColor = true;
            // 
            // CHB_vallarta
            // 
            this.CHB_vallarta.AutoSize = true;
            this.CHB_vallarta.Location = new System.Drawing.Point(906, 22);
            this.CHB_vallarta.Name = "CHB_vallarta";
            this.CHB_vallarta.Size = new System.Drawing.Size(61, 17);
            this.CHB_vallarta.TabIndex = 29;
            this.CHB_vallarta.Text = "Vallarta";
            this.CHB_vallarta.UseVisualStyleBackColor = true;
            // 
            // CHB_rena
            // 
            this.CHB_rena.AutoSize = true;
            this.CHB_rena.Location = new System.Drawing.Point(1004, 22);
            this.CHB_rena.Name = "CHB_rena";
            this.CHB_rena.Size = new System.Drawing.Size(52, 17);
            this.CHB_rena.TabIndex = 30;
            this.CHB_rena.Text = "Rena";
            this.CHB_rena.UseVisualStyleBackColor = true;
            // 
            // CHB_velazquez
            // 
            this.CHB_velazquez.AutoSize = true;
            this.CHB_velazquez.Location = new System.Drawing.Point(1102, 22);
            this.CHB_velazquez.Name = "CHB_velazquez";
            this.CHB_velazquez.Size = new System.Drawing.Size(75, 17);
            this.CHB_velazquez.TabIndex = 31;
            this.CHB_velazquez.Text = "Velazquez";
            this.CHB_velazquez.UseVisualStyleBackColor = true;
            // 
            // CHB_coloso
            // 
            this.CHB_coloso.AutoSize = true;
            this.CHB_coloso.Location = new System.Drawing.Point(1215, 22);
            this.CHB_coloso.Name = "CHB_coloso";
            this.CHB_coloso.Size = new System.Drawing.Size(58, 17);
            this.CHB_coloso.TabIndex = 32;
            this.CHB_coloso.Text = "Coloso";
            this.CHB_coloso.UseVisualStyleBackColor = true;
            // 
            // CHB_pregot
            // 
            this.CHB_pregot.AutoSize = true;
            this.CHB_pregot.Location = new System.Drawing.Point(692, 22);
            this.CHB_pregot.Name = "CHB_pregot";
            this.CHB_pregot.Size = new System.Drawing.Size(57, 17);
            this.CHB_pregot.TabIndex = 33;
            this.CHB_pregot.Text = "Pregot";
            this.CHB_pregot.UseVisualStyleBackColor = true;
            this.CHB_pregot.Visible = false;
            // 
            // BT_buscar_compra
            // 
            this.BT_buscar_compra.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BT_buscar_compra.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_buscar_compra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_buscar_compra.ForeColor = System.Drawing.Color.White;
            this.BT_buscar_compra.Location = new System.Drawing.Point(121, 24);
            this.BT_buscar_compra.Name = "BT_buscar_compra";
            this.BT_buscar_compra.Size = new System.Drawing.Size(85, 36);
            this.BT_buscar_compra.TabIndex = 1;
            this.BT_buscar_compra.Text = "Buscar";
            this.BT_buscar_compra.UseVisualStyleBackColor = false;
            this.BT_buscar_compra.Click += new System.EventHandler(this.BT_buscar_compra_Click);
            // 
            // TB_compra
            // 
            this.TB_compra.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TB_compra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_compra.Location = new System.Drawing.Point(15, 28);
            this.TB_compra.Name = "TB_compra";
            this.TB_compra.Size = new System.Drawing.Size(100, 31);
            this.TB_compra.TabIndex = 0;
            this.TB_compra.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_compra_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.BT_buscar_compra);
            this.groupBox1.Controls.Add(this.TB_compra);
            this.groupBox1.Location = new System.Drawing.Point(1397, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 66);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Compra";
            this.groupBox1.Visible = false;
            // 
            // BT_cuentasOS
            // 
            this.BT_cuentasOS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BT_cuentasOS.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_cuentasOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_cuentasOS.ForeColor = System.Drawing.Color.White;
            this.BT_cuentasOS.Location = new System.Drawing.Point(1624, 18);
            this.BT_cuentasOS.Name = "BT_cuentasOS";
            this.BT_cuentasOS.Size = new System.Drawing.Size(98, 68);
            this.BT_cuentasOS.TabIndex = 5;
            this.BT_cuentasOS.Text = "Depositar a Cuenta Osmart";
            this.BT_cuentasOS.UseVisualStyleBackColor = false;
            this.BT_cuentasOS.Click += new System.EventHandler(this.BT_cuentasOS_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1741, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 68);
            this.button1.TabIndex = 6;
            this.button1.Text = "Depositar a otro proveedor";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(507, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 39;
            this.label1.Text = "SALDO";
            // 
            // LB_saldo
            // 
            this.LB_saldo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LB_saldo.AutoSize = true;
            this.LB_saldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_saldo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LB_saldo.Location = new System.Drawing.Point(601, 52);
            this.LB_saldo.Name = "LB_saldo";
            this.LB_saldo.Size = new System.Drawing.Size(0, 25);
            this.LB_saldo.TabIndex = 40;
            // 
            // BT_guardar
            // 
            this.BT_guardar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BT_guardar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_guardar.ForeColor = System.Drawing.Color.White;
            this.BT_guardar.Image = ((System.Drawing.Image)(resources.GetObject("BT_guardar.Image")));
            this.BT_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_guardar.Location = new System.Drawing.Point(1624, 92);
            this.BT_guardar.Name = "BT_guardar";
            this.BT_guardar.Size = new System.Drawing.Size(98, 36);
            this.BT_guardar.TabIndex = 7;
            this.BT_guardar.Text = "Exportar";
            this.BT_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BT_guardar.UseVisualStyleBackColor = false;
            this.BT_guardar.Click += new System.EventHandler(this.BT_guardar_Click);
            // 
            // CuentasXPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1846, 696);
            this.Controls.Add(this.LB_pre);
            this.Controls.Add(this.LB_saldo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BT_cuentasOS);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CHB_pregot);
            this.Controls.Add(this.CHB_coloso);
            this.Controls.Add(this.CHB_velazquez);
            this.Controls.Add(this.CHB_rena);
            this.Controls.Add(this.CHB_vallarta);
            this.Controls.Add(this.CHB_bodega);
            this.Controls.Add(this.BT_abonos);
            this.Controls.Add(this.PN_conexiones);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_filtro);
            this.Controls.Add(this.BT_Buscar);
            this.Controls.Add(this.BT_guardar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_proveedor);
            this.Controls.Add(this.DG_datos);
            this.Controls.Add(this.CB_proveedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CuentasXPagar";
            this.Text = "Cuentas Por Pagar";
            this.Load += new System.EventHandler(this.CuentasXPagar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_datos)).EndInit();
            this.PN_conexiones.ResumeLayout(false);
            this.PN_conexiones.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DG_datos;
        private System.Windows.Forms.TextBox TB_proveedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROVEEDOR;
        private System.Windows.Forms.Button BT_guardar;
        private System.Windows.Forms.Label LB_bo;
        private System.Windows.Forms.Label LB_va;
        private System.Windows.Forms.Label LB_re;
        private System.Windows.Forms.Label LB_co;
        private System.Windows.Forms.Label LB_ve;
        private System.Windows.Forms.Label LB_pre;
        private System.Windows.Forms.Button BT_Buscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel PN_conexiones;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPAGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPROVEEDOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_MOV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO_DOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn REF;
        private System.Windows.Forms.DataGridViewTextBoxColumn MOV;
        private System.Windows.Forms.Button BT_abonos;
        private System.Windows.Forms.CheckBox CHB_bodega;
        private System.Windows.Forms.CheckBox CHB_vallarta;
        private System.Windows.Forms.CheckBox CHB_rena;
        private System.Windows.Forms.CheckBox CHB_velazquez;
        private System.Windows.Forms.CheckBox CHB_coloso;
        private System.Windows.Forms.CheckBox CHB_pregot;
        private System.Windows.Forms.Button BT_buscar_compra;
        private System.Windows.Forms.TextBox TB_compra;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BT_cuentasOS;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox TB_filtro;
        public System.Windows.Forms.ComboBox CB_proveedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LB_saldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDMOV;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROV;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO_DOCUMENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn REFERENCIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn MOVIMIENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUCURSAL_;
        private System.Windows.Forms.DataGridViewTextBoxColumn COMPRA_;
        private System.Windows.Forms.DataGridViewTextBoxColumn PAGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SALDO_;
        private System.Windows.Forms.DataGridViewTextBoxColumn OBSERV;
        private System.Windows.Forms.DataGridViewTextBoxColumn COBRADOR;
    }
}