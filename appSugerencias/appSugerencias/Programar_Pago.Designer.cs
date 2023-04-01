namespace appSugerencias
{
    partial class Programar_Pago
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
            this.DT_fecha_vencimiento = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.CB_sucursal = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CB_banco = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CB_cuenta = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_cliente = new System.Windows.Forms.TextBox();
            this.TB_enlace = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TB_importe = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.CB_tipo_pago = new System.Windows.Forms.ComboBox();
            this.BT_programarPago = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TB_factura = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TB_rfc = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.LB_mensajeCompras = new System.Windows.Forms.Label();
            this.BT_compras = new System.Windows.Forms.Button();
            this.CB_proveedor = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TB_proveedor = new System.Windows.Forms.TextBox();
            this.CB_compra = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.TB_proveedorServ = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TB_concepto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CB_proveedoresServicios = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CHX_anticipado = new System.Windows.Forms.CheckBox();
            this.BT_bancos = new System.Windows.Forms.Button();
            this.SPEI = new System.Windows.Forms.GroupBox();
            this.BT_patron = new System.Windows.Forms.Button();
            this.CB_patrones = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TB_iva = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SPEI.SuspendLayout();
            this.SuspendLayout();
            // 
            // DT_fecha_vencimiento
            // 
            this.DT_fecha_vencimiento.Location = new System.Drawing.Point(21, 44);
            this.DT_fecha_vencimiento.Name = "DT_fecha_vencimiento";
            this.DT_fecha_vencimiento.Size = new System.Drawing.Size(200, 20);
            this.DT_fecha_vencimiento.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha Vencimiento";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CB_sucursal
            // 
            this.CB_sucursal.FormattingEnabled = true;
            this.CB_sucursal.Items.AddRange(new object[] {
            "BODEGA",
            "VALLARTA",
            "RENA",
            "VELAZQUEZ",
            "COLOSO",
            "PREGOT"});
            this.CB_sucursal.Location = new System.Drawing.Point(14, 32);
            this.CB_sucursal.Name = "CB_sucursal";
            this.CB_sucursal.Size = new System.Drawing.Size(121, 21);
            this.CB_sucursal.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sucursal";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CB_banco
            // 
            this.CB_banco.FormattingEnabled = true;
            this.CB_banco.Location = new System.Drawing.Point(28, 114);
            this.CB_banco.Name = "CB_banco";
            this.CB_banco.Size = new System.Drawing.Size(121, 21);
            this.CB_banco.TabIndex = 4;
            this.CB_banco.SelectedIndexChanged += new System.EventHandler(this.CB_banco_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(155, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cuenta";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CB_cuenta
            // 
            this.CB_cuenta.FormattingEnabled = true;
            this.CB_cuenta.Location = new System.Drawing.Point(155, 114);
            this.CB_cuenta.Name = "CB_cuenta";
            this.CB_cuenta.Size = new System.Drawing.Size(198, 21);
            this.CB_cuenta.TabIndex = 6;
            this.CB_cuenta.SelectedIndexChanged += new System.EventHandler(this.CB_cuenta_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(360, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Cliente Bancario";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TB_cliente
            // 
            this.TB_cliente.Location = new System.Drawing.Point(363, 114);
            this.TB_cliente.Name = "TB_cliente";
            this.TB_cliente.Size = new System.Drawing.Size(233, 20);
            this.TB_cliente.TabIndex = 10;
            // 
            // TB_enlace
            // 
            this.TB_enlace.Location = new System.Drawing.Point(19, 272);
            this.TB_enlace.Multiline = true;
            this.TB_enlace.Name = "TB_enlace";
            this.TB_enlace.Size = new System.Drawing.Size(618, 37);
            this.TB_enlace.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 256);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Enlace Orden de Compra";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TB_importe
            // 
            this.TB_importe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_importe.Location = new System.Drawing.Point(398, 669);
            this.TB_importe.Name = "TB_importe";
            this.TB_importe.Size = new System.Drawing.Size(119, 26);
            this.TB_importe.TabIndex = 19;
            this.TB_importe.TextChanged += new System.EventHandler(this.TB_importe_TextChanged);
            this.TB_importe.Enter += new System.EventHandler(this.TB_importe_Enter);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(350, 677);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Importe";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Tipo pago";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CB_tipo_pago
            // 
            this.CB_tipo_pago.FormattingEnabled = true;
            this.CB_tipo_pago.Items.AddRange(new object[] {
            "EFECTIVO",
            "DEP/EFE",
            "SPEI"});
            this.CB_tipo_pago.Location = new System.Drawing.Point(28, 36);
            this.CB_tipo_pago.Name = "CB_tipo_pago";
            this.CB_tipo_pago.Size = new System.Drawing.Size(121, 21);
            this.CB_tipo_pago.TabIndex = 20;
            this.CB_tipo_pago.SelectedIndexChanged += new System.EventHandler(this.CB_tipo_pago_SelectedIndexChanged);
            // 
            // BT_programarPago
            // 
            this.BT_programarPago.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_programarPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_programarPago.ForeColor = System.Drawing.Color.White;
            this.BT_programarPago.Location = new System.Drawing.Point(554, 677);
            this.BT_programarPago.Name = "BT_programarPago";
            this.BT_programarPago.Size = new System.Drawing.Size(132, 50);
            this.BT_programarPago.TabIndex = 22;
            this.BT_programarPago.Text = "Programar Pago";
            this.BT_programarPago.UseVisualStyleBackColor = false;
            this.BT_programarPago.Click += new System.EventHandler(this.BT_programarPago_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TB_factura);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.TB_rfc);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Controls.Add(this.TB_enlace);
            this.groupBox1.Controls.Add(this.CB_sucursal);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(21, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(665, 315);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la compra";
            // 
            // TB_factura
            // 
            this.TB_factura.Location = new System.Drawing.Point(366, 222);
            this.TB_factura.Name = "TB_factura";
            this.TB_factura.Size = new System.Drawing.Size(275, 20);
            this.TB_factura.TabIndex = 31;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(322, 225);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 13);
            this.label14.TabIndex = 30;
            this.label14.Text = "Factura";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TB_rfc
            // 
            this.TB_rfc.Location = new System.Drawing.Point(57, 222);
            this.TB_rfc.Name = "TB_rfc";
            this.TB_rfc.Size = new System.Drawing.Size(233, 20);
            this.TB_rfc.TabIndex = 29;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(23, 225);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "RFC";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(19, 59);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(622, 136);
            this.tabControl1.TabIndex = 27;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.LB_mensajeCompras);
            this.tabPage1.Controls.Add(this.BT_compras);
            this.tabPage1.Controls.Add(this.CB_proveedor);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.TB_proveedor);
            this.tabPage1.Controls.Add(this.CB_compra);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(614, 110);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Proveedor Productos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // LB_mensajeCompras
            // 
            this.LB_mensajeCompras.AutoSize = true;
            this.LB_mensajeCompras.Location = new System.Drawing.Point(104, 93);
            this.LB_mensajeCompras.Name = "LB_mensajeCompras";
            this.LB_mensajeCompras.Size = new System.Drawing.Size(0, 13);
            this.LB_mensajeCompras.TabIndex = 32;
            this.LB_mensajeCompras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BT_compras
            // 
            this.BT_compras.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_compras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_compras.ForeColor = System.Drawing.Color.White;
            this.BT_compras.Location = new System.Drawing.Point(24, 60);
            this.BT_compras.Name = "BT_compras";
            this.BT_compras.Size = new System.Drawing.Size(63, 29);
            this.BT_compras.TabIndex = 31;
            this.BT_compras.Text = "Compras";
            this.BT_compras.UseVisualStyleBackColor = false;
            this.BT_compras.Click += new System.EventHandler(this.BT_compras_Click_1);
            // 
            // CB_proveedor
            // 
            this.CB_proveedor.FormattingEnabled = true;
            this.CB_proveedor.Location = new System.Drawing.Point(24, 31);
            this.CB_proveedor.Name = "CB_proveedor";
            this.CB_proveedor.Size = new System.Drawing.Size(345, 21);
            this.CB_proveedor.TabIndex = 27;
            this.CB_proveedor.SelectedIndexChanged += new System.EventHandler(this.CB_proveedor_SelectedIndexChanged_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Proveedor";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TB_proveedor
            // 
            this.TB_proveedor.Location = new System.Drawing.Point(375, 31);
            this.TB_proveedor.Name = "TB_proveedor";
            this.TB_proveedor.Size = new System.Drawing.Size(68, 20);
            this.TB_proveedor.TabIndex = 29;
            // 
            // CB_compra
            // 
            this.CB_compra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_compra.FormattingEnabled = true;
            this.CB_compra.Location = new System.Drawing.Point(98, 61);
            this.CB_compra.Name = "CB_compra";
            this.CB_compra.Size = new System.Drawing.Size(121, 28);
            this.CB_compra.TabIndex = 30;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.TB_proveedorServ);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.TB_concepto);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.CB_proveedoresServicios);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(614, 110);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Proveedor Servicios";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // TB_proveedorServ
            // 
            this.TB_proveedorServ.Location = new System.Drawing.Point(322, 28);
            this.TB_proveedorServ.Name = "TB_proveedorServ";
            this.TB_proveedorServ.Size = new System.Drawing.Size(70, 20);
            this.TB_proveedorServ.TabIndex = 32;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "Concepto";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TB_concepto
            // 
            this.TB_concepto.Location = new System.Drawing.Point(15, 68);
            this.TB_concepto.Name = "TB_concepto";
            this.TB_concepto.Size = new System.Drawing.Size(576, 20);
            this.TB_concepto.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Proveedor";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CB_proveedoresServicios
            // 
            this.CB_proveedoresServicios.FormattingEnabled = true;
            this.CB_proveedoresServicios.Location = new System.Drawing.Point(15, 28);
            this.CB_proveedoresServicios.Name = "CB_proveedoresServicios";
            this.CB_proveedoresServicios.Size = new System.Drawing.Size(301, 21);
            this.CB_proveedoresServicios.TabIndex = 22;
            this.CB_proveedoresServicios.SelectedIndexChanged += new System.EventHandler(this.CB_proveedoresServicios_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CHX_anticipado);
            this.groupBox2.Controls.Add(this.BT_bancos);
            this.groupBox2.Controls.Add(this.TB_cliente);
            this.groupBox2.Controls.Add(this.CB_banco);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.CB_tipo_pago);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.CB_cuenta);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(21, 406);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(665, 146);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del pago";
            // 
            // CHX_anticipado
            // 
            this.CHX_anticipado.AutoSize = true;
            this.CHX_anticipado.Location = new System.Drawing.Point(538, 16);
            this.CHX_anticipado.Name = "CHX_anticipado";
            this.CHX_anticipado.Size = new System.Drawing.Size(103, 17);
            this.CHX_anticipado.TabIndex = 28;
            this.CHX_anticipado.Text = "Pago anticipado";
            this.CHX_anticipado.UseVisualStyleBackColor = true;
            // 
            // BT_bancos
            // 
            this.BT_bancos.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_bancos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_bancos.ForeColor = System.Drawing.Color.White;
            this.BT_bancos.Location = new System.Drawing.Point(28, 79);
            this.BT_bancos.Name = "BT_bancos";
            this.BT_bancos.Size = new System.Drawing.Size(63, 29);
            this.BT_bancos.TabIndex = 27;
            this.BT_bancos.Text = "Bancos";
            this.BT_bancos.UseVisualStyleBackColor = false;
            this.BT_bancos.Click += new System.EventHandler(this.BT_bancos_Click);
            // 
            // SPEI
            // 
            this.SPEI.Controls.Add(this.BT_patron);
            this.SPEI.Controls.Add(this.CB_patrones);
            this.SPEI.Controls.Add(this.label13);
            this.SPEI.Location = new System.Drawing.Point(21, 558);
            this.SPEI.Name = "SPEI";
            this.SPEI.Size = new System.Drawing.Size(665, 105);
            this.SPEI.TabIndex = 25;
            this.SPEI.TabStop = false;
            this.SPEI.Text = "SPEI";
            // 
            // BT_patron
            // 
            this.BT_patron.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_patron.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_patron.ForeColor = System.Drawing.Color.White;
            this.BT_patron.Location = new System.Drawing.Point(17, 19);
            this.BT_patron.Name = "BT_patron";
            this.BT_patron.Size = new System.Drawing.Size(129, 29);
            this.BT_patron.TabIndex = 45;
            this.BT_patron.Text = "Patrón";
            this.BT_patron.UseVisualStyleBackColor = false;
            this.BT_patron.Click += new System.EventHandler(this.BT_bancosOsmart_Click_1);
            // 
            // CB_patrones
            // 
            this.CB_patrones.FormattingEnabled = true;
            this.CB_patrones.Location = new System.Drawing.Point(57, 65);
            this.CB_patrones.Name = "CB_patrones";
            this.CB_patrones.Size = new System.Drawing.Size(198, 21);
            this.CB_patrones.TabIndex = 41;
            this.CB_patrones.SelectedIndexChanged += new System.EventHandler(this.CB_cuenta_os_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 68);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 42;
            this.label13.Text = "Patrón";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TB_iva
            // 
            this.TB_iva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_iva.Location = new System.Drawing.Point(398, 701);
            this.TB_iva.Name = "TB_iva";
            this.TB_iva.Size = new System.Drawing.Size(119, 26);
            this.TB_iva.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(350, 706);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "IVA";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Programar_Pago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(708, 739);
            this.Controls.Add(this.TB_iva);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SPEI);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BT_programarPago);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DT_fecha_vencimiento);
            this.Controls.Add(this.TB_importe);
            this.Controls.Add(this.label9);
            this.Name = "Programar_Pago";
            this.Text = "Programar Pago";
            this.Load += new System.EventHandler(this.Programar_Pago_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.SPEI.ResumeLayout(false);
            this.SPEI.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DT_fecha_vencimiento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CB_sucursal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CB_banco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CB_cuenta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_cliente;
        private System.Windows.Forms.TextBox TB_enlace;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TB_importe;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox CB_tipo_pago;
        private System.Windows.Forms.Button BT_programarPago;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BT_bancos;
        private System.Windows.Forms.GroupBox SPEI;
        private System.Windows.Forms.Button BT_patron;
        private System.Windows.Forms.ComboBox CB_patrones;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TB_iva;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_rfc;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label LB_mensajeCompras;
        private System.Windows.Forms.Button BT_compras;
        private System.Windows.Forms.ComboBox CB_proveedor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TB_proveedor;
        private System.Windows.Forms.ComboBox CB_compra;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TB_concepto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CB_proveedoresServicios;
        private System.Windows.Forms.TextBox TB_factura;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TB_proveedorServ;
        private System.Windows.Forms.CheckBox CHX_anticipado;
    }
}