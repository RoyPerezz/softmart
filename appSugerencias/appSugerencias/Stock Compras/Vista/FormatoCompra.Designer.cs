
namespace appSugerencias.Stock_Compras.Vista
{
    partial class FormatoCompra
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CB_proveedor = new System.Windows.Forms.ComboBox();
            this.CB_stock = new System.Windows.Forms.ComboBox();
            this.TB_folio = new System.Windows.Forms.TextBox();
            this.TB_descuento = new System.Windows.Forms.TextBox();
            this.TB_utilidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BT_buscar = new System.Windows.Forms.Button();
            this.RB_com3 = new System.Windows.Forms.RadioButton();
            this.RB_com2 = new System.Windows.Forms.RadioButton();
            this.DG_tabla = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TB_idproveedor = new System.Windows.Forms.TextBox();
            this.TB_idstock = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.RB_iva = new System.Windows.Forms.RadioButton();
            this.CB_tipoImpuesto = new System.Windows.Forms.ComboBox();
            this.RB_sys = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BT_aplicar_cambio_linea = new System.Windows.Forms.Button();
            this.CB_cambio_linea = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BT_aplicar_cambio_fab = new System.Windows.Forms.Button();
            this.CB_cambio_fabricante = new System.Windows.Forms.ComboBox();
            this.BT_Exportar = new System.Windows.Forms.Button();
            this.BT_Aplicar = new System.Windows.Forms.Button();
            this.CB_sucursal = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TB_observaciones = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TB_orden_compra = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TB_factura = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.DT_fecha_llegada = new System.Windows.Forms.DateTimePicker();
            this.CLAVE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COSTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PMAYOREO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PMENUDEO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LINEA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MARCA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FABRICANTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DG_tabla)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // CB_proveedor
            // 
            this.CB_proveedor.FormattingEnabled = true;
            this.CB_proveedor.Location = new System.Drawing.Point(86, 18);
            this.CB_proveedor.Name = "CB_proveedor";
            this.CB_proveedor.Size = new System.Drawing.Size(335, 21);
            this.CB_proveedor.TabIndex = 1;
            this.CB_proveedor.SelectedIndexChanged += new System.EventHandler(this.CB_proveedor_SelectedIndexChanged);
            // 
            // CB_stock
            // 
            this.CB_stock.FormattingEnabled = true;
            this.CB_stock.Location = new System.Drawing.Point(86, 45);
            this.CB_stock.Name = "CB_stock";
            this.CB_stock.Size = new System.Drawing.Size(335, 21);
            this.CB_stock.TabIndex = 2;
            this.CB_stock.SelectedIndexChanged += new System.EventHandler(this.CB_stock_SelectedIndexChanged);
            // 
            // TB_folio
            // 
            this.TB_folio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_folio.Location = new System.Drawing.Point(1829, 3);
            this.TB_folio.Name = "TB_folio";
            this.TB_folio.Size = new System.Drawing.Size(52, 20);
            this.TB_folio.TabIndex = 3;
            // 
            // TB_descuento
            // 
            this.TB_descuento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_descuento.Location = new System.Drawing.Point(1829, 30);
            this.TB_descuento.Name = "TB_descuento";
            this.TB_descuento.Size = new System.Drawing.Size(52, 20);
            this.TB_descuento.TabIndex = 4;
            // 
            // TB_utilidad
            // 
            this.TB_utilidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_utilidad.Location = new System.Drawing.Point(1829, 57);
            this.TB_utilidad.Name = "TB_utilidad";
            this.TB_utilidad.Size = new System.Drawing.Size(52, 20);
            this.TB_utilidad.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1785, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "FOLIO";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1749, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "DESCUENTO";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1766, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "UTILIDAD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "PROVEEDOR";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "STOCK";
            // 
            // BT_buscar
            // 
            this.BT_buscar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_buscar.ForeColor = System.Drawing.Color.White;
            this.BT_buscar.Location = new System.Drawing.Point(496, 18);
            this.BT_buscar.Name = "BT_buscar";
            this.BT_buscar.Size = new System.Drawing.Size(104, 48);
            this.BT_buscar.TabIndex = 11;
            this.BT_buscar.Text = "Buscar";
            this.BT_buscar.UseVisualStyleBackColor = false;
            this.BT_buscar.Click += new System.EventHandler(this.BT_buscar_Click);
            // 
            // RB_com3
            // 
            this.RB_com3.AutoSize = true;
            this.RB_com3.Location = new System.Drawing.Point(16, 43);
            this.RB_com3.Name = "RB_com3";
            this.RB_com3.Size = new System.Drawing.Size(58, 17);
            this.RB_com3.TabIndex = 12;
            this.RB_com3.TabStop = true;
            this.RB_com3.Text = "COM 3";
            this.RB_com3.UseVisualStyleBackColor = true;
            this.RB_com3.CheckedChanged += new System.EventHandler(this.RB_com3_CheckedChanged);
            // 
            // RB_com2
            // 
            this.RB_com2.AutoSize = true;
            this.RB_com2.Location = new System.Drawing.Point(16, 20);
            this.RB_com2.Name = "RB_com2";
            this.RB_com2.Size = new System.Drawing.Size(58, 17);
            this.RB_com2.TabIndex = 13;
            this.RB_com2.TabStop = true;
            this.RB_com2.Text = "COM 2";
            this.RB_com2.UseVisualStyleBackColor = true;
            this.RB_com2.CheckedChanged += new System.EventHandler(this.RB_com2_CheckedChanged);
            // 
            // DG_tabla
            // 
            this.DG_tabla.AllowUserToAddRows = false;
            this.DG_tabla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DG_tabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_tabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DG_tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CLAVE,
            this.DESCRIPCION,
            this.COSTO,
            this.PMAYOREO,
            this.PMENUDEO,
            this.IVA,
            this.LINEA,
            this.MARCA,
            this.FABRICANTE,
            this.VA,
            this.RE,
            this.VL,
            this.CO,
            this.BO});
            this.DG_tabla.Location = new System.Drawing.Point(0, 241);
            this.DG_tabla.Name = "DG_tabla";
            this.DG_tabla.Size = new System.Drawing.Size(1892, 210);
            this.DG_tabla.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.RB_com2);
            this.groupBox1.Controls.Add(this.RB_com3);
            this.groupBox1.Location = new System.Drawing.Point(1591, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(110, 71);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Marca";
            // 
            // TB_idproveedor
            // 
            this.TB_idproveedor.Location = new System.Drawing.Point(427, 18);
            this.TB_idproveedor.Name = "TB_idproveedor";
            this.TB_idproveedor.Size = new System.Drawing.Size(52, 20);
            this.TB_idproveedor.TabIndex = 15;
            // 
            // TB_idstock
            // 
            this.TB_idstock.Location = new System.Drawing.Point(428, 46);
            this.TB_idstock.Name = "TB_idstock";
            this.TB_idstock.Size = new System.Drawing.Size(52, 20);
            this.TB_idstock.TabIndex = 16;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.RB_iva);
            this.groupBox2.Controls.Add(this.CB_tipoImpuesto);
            this.groupBox2.Controls.Add(this.RB_sys);
            this.groupBox2.Location = new System.Drawing.Point(1274, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(311, 71);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo impuesto";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(233, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 48);
            this.button1.TabIndex = 17;
            this.button1.Text = "Aplicar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "TIPO IMPUESTO";
            // 
            // RB_iva
            // 
            this.RB_iva.AutoSize = true;
            this.RB_iva.Location = new System.Drawing.Point(16, 20);
            this.RB_iva.Name = "RB_iva";
            this.RB_iva.Size = new System.Drawing.Size(42, 17);
            this.RB_iva.TabIndex = 13;
            this.RB_iva.TabStop = true;
            this.RB_iva.Text = "IVA";
            this.RB_iva.UseVisualStyleBackColor = true;
            this.RB_iva.CheckedChanged += new System.EventHandler(this.RB_iva_CheckedChanged);
            // 
            // CB_tipoImpuesto
            // 
            this.CB_tipoImpuesto.FormattingEnabled = true;
            this.CB_tipoImpuesto.Items.AddRange(new object[] {
            "IVA",
            "SYS"});
            this.CB_tipoImpuesto.Location = new System.Drawing.Point(78, 36);
            this.CB_tipoImpuesto.Name = "CB_tipoImpuesto";
            this.CB_tipoImpuesto.Size = new System.Drawing.Size(149, 21);
            this.CB_tipoImpuesto.TabIndex = 17;
            // 
            // RB_sys
            // 
            this.RB_sys.AutoSize = true;
            this.RB_sys.Location = new System.Drawing.Point(16, 43);
            this.RB_sys.Name = "RB_sys";
            this.RB_sys.Size = new System.Drawing.Size(46, 17);
            this.RB_sys.TabIndex = 12;
            this.RB_sys.TabStop = true;
            this.RB_sys.Text = "SYS";
            this.RB_sys.UseVisualStyleBackColor = true;
            this.RB_sys.CheckedChanged += new System.EventHandler(this.RB_sys_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.BT_aplicar_cambio_linea);
            this.groupBox3.Controls.Add(this.CB_cambio_linea);
            this.groupBox3.Location = new System.Drawing.Point(1010, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(258, 71);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cambio de linea";
            // 
            // BT_aplicar_cambio_linea
            // 
            this.BT_aplicar_cambio_linea.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_aplicar_cambio_linea.ForeColor = System.Drawing.Color.White;
            this.BT_aplicar_cambio_linea.Location = new System.Drawing.Point(173, 17);
            this.BT_aplicar_cambio_linea.Name = "BT_aplicar_cambio_linea";
            this.BT_aplicar_cambio_linea.Size = new System.Drawing.Size(69, 48);
            this.BT_aplicar_cambio_linea.TabIndex = 17;
            this.BT_aplicar_cambio_linea.Text = "Aplicar";
            this.BT_aplicar_cambio_linea.UseVisualStyleBackColor = false;
            this.BT_aplicar_cambio_linea.Click += new System.EventHandler(this.BT_aplicar_cambio_linea_Click);
            // 
            // CB_cambio_linea
            // 
            this.CB_cambio_linea.FormattingEnabled = true;
            this.CB_cambio_linea.Location = new System.Drawing.Point(18, 34);
            this.CB_cambio_linea.Name = "CB_cambio_linea";
            this.CB_cambio_linea.Size = new System.Drawing.Size(149, 21);
            this.CB_cambio_linea.TabIndex = 17;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.BT_aplicar_cambio_fab);
            this.groupBox4.Controls.Add(this.CB_cambio_fabricante);
            this.groupBox4.Location = new System.Drawing.Point(604, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(400, 71);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cambio de fabricante";
            // 
            // BT_aplicar_cambio_fab
            // 
            this.BT_aplicar_cambio_fab.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_aplicar_cambio_fab.ForeColor = System.Drawing.Color.White;
            this.BT_aplicar_cambio_fab.Location = new System.Drawing.Point(285, 41);
            this.BT_aplicar_cambio_fab.Name = "BT_aplicar_cambio_fab";
            this.BT_aplicar_cambio_fab.Size = new System.Drawing.Size(101, 24);
            this.BT_aplicar_cambio_fab.TabIndex = 17;
            this.BT_aplicar_cambio_fab.Text = "Aplicar";
            this.BT_aplicar_cambio_fab.UseVisualStyleBackColor = false;
            this.BT_aplicar_cambio_fab.Click += new System.EventHandler(this.BT_aplicar_cambio_fab_Click);
            // 
            // CB_cambio_fabricante
            // 
            this.CB_cambio_fabricante.FormattingEnabled = true;
            this.CB_cambio_fabricante.Location = new System.Drawing.Point(18, 16);
            this.CB_cambio_fabricante.Name = "CB_cambio_fabricante";
            this.CB_cambio_fabricante.Size = new System.Drawing.Size(368, 21);
            this.CB_cambio_fabricante.TabIndex = 17;
            // 
            // BT_Exportar
            // 
            this.BT_Exportar.BackColor = System.Drawing.Color.CadetBlue;
            this.BT_Exportar.ForeColor = System.Drawing.Color.White;
            this.BT_Exportar.Location = new System.Drawing.Point(1777, 83);
            this.BT_Exportar.Name = "BT_Exportar";
            this.BT_Exportar.Size = new System.Drawing.Size(104, 48);
            this.BT_Exportar.TabIndex = 21;
            this.BT_Exportar.Text = "Exportar";
            this.BT_Exportar.UseVisualStyleBackColor = false;
            this.BT_Exportar.Click += new System.EventHandler(this.BT_Exportar_Click);
            // 
            // BT_Aplicar
            // 
            this.BT_Aplicar.BackColor = System.Drawing.Color.CadetBlue;
            this.BT_Aplicar.ForeColor = System.Drawing.Color.White;
            this.BT_Aplicar.Location = new System.Drawing.Point(468, 98);
            this.BT_Aplicar.Name = "BT_Aplicar";
            this.BT_Aplicar.Size = new System.Drawing.Size(104, 48);
            this.BT_Aplicar.TabIndex = 22;
            this.BT_Aplicar.Text = "Aplicar Compra";
            this.BT_Aplicar.UseVisualStyleBackColor = false;
            this.BT_Aplicar.Click += new System.EventHandler(this.BT_Aplicar_Click);
            // 
            // CB_sucursal
            // 
            this.CB_sucursal.FormattingEnabled = true;
            this.CB_sucursal.Items.AddRange(new object[] {
            "CEDIS",
            "VALLARTA",
            "RENA",
            "VELAZQUEZ",
            "COLOSO"});
            this.CB_sucursal.Location = new System.Drawing.Point(127, 19);
            this.CB_sucursal.Name = "CB_sucursal";
            this.CB_sucursal.Size = new System.Drawing.Size(149, 21);
            this.CB_sucursal.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "SUCURSAL";
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.TB_observaciones);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.TB_orden_compra);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.TB_factura);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.DT_fecha_llegada);
            this.groupBox5.Controls.Add(this.BT_Aplicar);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.CB_sucursal);
            this.groupBox5.Location = new System.Drawing.Point(9, 83);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(591, 152);
            this.groupBox5.TabIndex = 21;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Cargar compra";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 102);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "OBSERVACIONES";
            // 
            // TB_observaciones
            // 
            this.TB_observaciones.Location = new System.Drawing.Point(128, 99);
            this.TB_observaciones.Multiline = true;
            this.TB_observaciones.Name = "TB_observaciones";
            this.TB_observaciones.Size = new System.Drawing.Size(316, 47);
            this.TB_observaciones.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(321, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "ORDEN DE COMPRA";
            // 
            // TB_orden_compra
            // 
            this.TB_orden_compra.Location = new System.Drawing.Point(448, 20);
            this.TB_orden_compra.Name = "TB_orden_compra";
            this.TB_orden_compra.Size = new System.Drawing.Size(137, 20);
            this.TB_orden_compra.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(64, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "FACTURA";
            // 
            // TB_factura
            // 
            this.TB_factura.Location = new System.Drawing.Point(127, 73);
            this.TB_factura.Name = "TB_factura";
            this.TB_factura.Size = new System.Drawing.Size(317, 20);
            this.TB_factura.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "FECHA DE LLEGADA";
            // 
            // DT_fecha_llegada
            // 
            this.DT_fecha_llegada.Location = new System.Drawing.Point(128, 47);
            this.DT_fecha_llegada.Name = "DT_fecha_llegada";
            this.DT_fecha_llegada.Size = new System.Drawing.Size(214, 20);
            this.DT_fecha_llegada.TabIndex = 23;
            // 
            // CLAVE
            // 
            this.CLAVE.HeaderText = "CLAVE";
            this.CLAVE.Name = "CLAVE";
            // 
            // DESCRIPCION
            // 
            this.DESCRIPCION.HeaderText = "DESCRIPCION";
            this.DESCRIPCION.Name = "DESCRIPCION";
            // 
            // COSTO
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.COSTO.DefaultCellStyle = dataGridViewCellStyle2;
            this.COSTO.HeaderText = "COSTO";
            this.COSTO.Name = "COSTO";
            // 
            // PMAYOREO
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.PMAYOREO.DefaultCellStyle = dataGridViewCellStyle3;
            this.PMAYOREO.HeaderText = "P. MAYOREO";
            this.PMAYOREO.Name = "PMAYOREO";
            // 
            // PMENUDEO
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.PMENUDEO.DefaultCellStyle = dataGridViewCellStyle4;
            this.PMENUDEO.HeaderText = "P. MENUDEO";
            this.PMENUDEO.Name = "PMENUDEO";
            // 
            // IVA
            // 
            this.IVA.HeaderText = "IVA";
            this.IVA.Name = "IVA";
            // 
            // LINEA
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.LINEA.DefaultCellStyle = dataGridViewCellStyle5;
            this.LINEA.HeaderText = "LINEA";
            this.LINEA.Name = "LINEA";
            // 
            // MARCA
            // 
            this.MARCA.HeaderText = "MARCA";
            this.MARCA.Name = "MARCA";
            // 
            // FABRICANTE
            // 
            this.FABRICANTE.HeaderText = "FABRICANTE";
            this.FABRICANTE.Name = "FABRICANTE";
            // 
            // VA
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.VA.DefaultCellStyle = dataGridViewCellStyle6;
            this.VA.HeaderText = "VA";
            this.VA.Name = "VA";
            // 
            // RE
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.RE.DefaultCellStyle = dataGridViewCellStyle7;
            this.RE.HeaderText = "RE";
            this.RE.Name = "RE";
            // 
            // VL
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.VL.DefaultCellStyle = dataGridViewCellStyle8;
            this.VL.HeaderText = "VL";
            this.VL.Name = "VL";
            // 
            // CO
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CO.DefaultCellStyle = dataGridViewCellStyle9;
            this.CO.HeaderText = "CO";
            this.CO.Name = "CO";
            // 
            // BO
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.BO.DefaultCellStyle = dataGridViewCellStyle10;
            this.BO.HeaderText = "BO";
            this.BO.Name = "BO";
            // 
            // FormatoCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1893, 450);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.BT_Exportar);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.TB_idstock);
            this.Controls.Add(this.TB_idproveedor);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BT_buscar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_utilidad);
            this.Controls.Add(this.TB_descuento);
            this.Controls.Add(this.TB_folio);
            this.Controls.Add(this.CB_stock);
            this.Controls.Add(this.CB_proveedor);
            this.Controls.Add(this.DG_tabla);
            this.Name = "FormatoCompra";
            this.Text = "FormatoCompra";
            this.Load += new System.EventHandler(this.FormatoCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_tabla)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox CB_proveedor;
        private System.Windows.Forms.ComboBox CB_stock;
        private System.Windows.Forms.TextBox TB_folio;
        private System.Windows.Forms.TextBox TB_descuento;
        private System.Windows.Forms.TextBox TB_utilidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BT_buscar;
        private System.Windows.Forms.RadioButton RB_com3;
        private System.Windows.Forms.RadioButton RB_com2;
        private System.Windows.Forms.DataGridView DG_tabla;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TB_idproveedor;
        private System.Windows.Forms.TextBox TB_idstock;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton RB_iva;
        private System.Windows.Forms.RadioButton RB_sys;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CB_tipoImpuesto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BT_aplicar_cambio_linea;
        private System.Windows.Forms.ComboBox CB_cambio_linea;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button BT_aplicar_cambio_fab;
        private System.Windows.Forms.ComboBox CB_cambio_fabricante;
        private System.Windows.Forms.Button BT_Exportar;
        private System.Windows.Forms.Button BT_Aplicar;
        private System.Windows.Forms.ComboBox CB_sucursal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker DT_fecha_llegada;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TB_factura;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TB_orden_compra;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TB_observaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLAVE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn COSTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PMAYOREO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PMENUDEO;
        private System.Windows.Forms.DataGridViewTextBoxColumn IVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn LINEA;
        private System.Windows.Forms.DataGridViewTextBoxColumn MARCA;
        private System.Windows.Forms.DataGridViewTextBoxColumn FABRICANTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn VA;
        private System.Windows.Forms.DataGridViewTextBoxColumn RE;
        private System.Windows.Forms.DataGridViewTextBoxColumn VL;
        private System.Windows.Forms.DataGridViewTextBoxColumn CO;
        private System.Windows.Forms.DataGridViewTextBoxColumn BO;
    }
}