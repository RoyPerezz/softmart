namespace appSugerencias
{
    partial class Modificar_pago
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
            this.DG_tabla = new System.Windows.Forms.DataGridView();
            this.DT_fecha = new System.Windows.Forms.DateTimePicker();
            this.CB_proveedores = new System.Windows.Forms.ComboBox();
            this.RB_prov_merc = new System.Windows.Forms.RadioButton();
            this.RB_prov_serv = new System.Windows.Forms.RadioButton();
            this.BT_buscar = new System.Windows.Forms.Button();
            this.BT_modificar = new System.Windows.Forms.Button();
            this.BT_eliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.TB_registro = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TB_factura = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TB_concepto = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TB_importe = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TB_patron = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.TB_tipo = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.TB_cliente = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TB_cuenta = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TB_banco = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TB_enlace = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TB_compra = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TB_rfc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_sucursal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_fecha_venc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_fecha_prog = new System.Windows.Forms.TextBox();
            this.BT_limpiar = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.TB_iva = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_PRO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_VEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUCURSAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RFC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COMPRA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ENLACE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BANCO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUENTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PATRON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMPORTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CONCEPTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FACTURA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DG_tabla)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DG_tabla
            // 
            this.DG_tabla.AllowUserToAddRows = false;
            this.DG_tabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DG_tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.FECHA_PRO,
            this.FECHA_VEN,
            this.SUCURSAL,
            this.RFC,
            this.COMPRA,
            this.ENLACE,
            this.BANCO,
            this.CUENTA,
            this.CLIENTE,
            this.TIPO,
            this.PATRON,
            this.IMPORTE,
            this.IVA,
            this.CONCEPTO,
            this.FACTURA});
            this.DG_tabla.Location = new System.Drawing.Point(16, 231);
            this.DG_tabla.Name = "DG_tabla";
            this.DG_tabla.Size = new System.Drawing.Size(1442, 191);
            this.DG_tabla.TabIndex = 0;
            this.DG_tabla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_tabla_CellContentClick);
            this.DG_tabla.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_tabla_CellContentDoubleClick);
            // 
            // DT_fecha
            // 
            this.DT_fecha.Location = new System.Drawing.Point(28, 143);
            this.DT_fecha.Name = "DT_fecha";
            this.DT_fecha.Size = new System.Drawing.Size(200, 20);
            this.DT_fecha.TabIndex = 1;
            // 
            // CB_proveedores
            // 
            this.CB_proveedores.FormattingEnabled = true;
            this.CB_proveedores.Location = new System.Drawing.Point(24, 95);
            this.CB_proveedores.Name = "CB_proveedores";
            this.CB_proveedores.Size = new System.Drawing.Size(365, 21);
            this.CB_proveedores.TabIndex = 2;
            this.CB_proveedores.SelectedIndexChanged += new System.EventHandler(this.CB_proveedores_SelectedIndexChanged);
            // 
            // RB_prov_merc
            // 
            this.RB_prov_merc.AutoSize = true;
            this.RB_prov_merc.Location = new System.Drawing.Point(24, 33);
            this.RB_prov_merc.Name = "RB_prov_merc";
            this.RB_prov_merc.Size = new System.Drawing.Size(129, 17);
            this.RB_prov_merc.TabIndex = 3;
            this.RB_prov_merc.TabStop = true;
            this.RB_prov_merc.Text = "Proveedor Mercancía";
            this.RB_prov_merc.UseVisualStyleBackColor = true;
            this.RB_prov_merc.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // RB_prov_serv
            // 
            this.RB_prov_serv.AutoSize = true;
            this.RB_prov_serv.Location = new System.Drawing.Point(197, 33);
            this.RB_prov_serv.Name = "RB_prov_serv";
            this.RB_prov_serv.Size = new System.Drawing.Size(120, 17);
            this.RB_prov_serv.TabIndex = 4;
            this.RB_prov_serv.TabStop = true;
            this.RB_prov_serv.Text = "Proveedor Servicios";
            this.RB_prov_serv.UseVisualStyleBackColor = true;
            this.RB_prov_serv.CheckedChanged += new System.EventHandler(this.RB_prov_serv_CheckedChanged);
            // 
            // BT_buscar
            // 
            this.BT_buscar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_buscar.ForeColor = System.Drawing.Color.White;
            this.BT_buscar.Location = new System.Drawing.Point(1088, 432);
            this.BT_buscar.Name = "BT_buscar";
            this.BT_buscar.Size = new System.Drawing.Size(88, 37);
            this.BT_buscar.TabIndex = 5;
            this.BT_buscar.Text = "Buscar";
            this.BT_buscar.UseVisualStyleBackColor = false;
            this.BT_buscar.Click += new System.EventHandler(this.BT_buscar_Click);
            // 
            // BT_modificar
            // 
            this.BT_modificar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_modificar.ForeColor = System.Drawing.Color.White;
            this.BT_modificar.Location = new System.Drawing.Point(1276, 432);
            this.BT_modificar.Name = "BT_modificar";
            this.BT_modificar.Size = new System.Drawing.Size(88, 37);
            this.BT_modificar.TabIndex = 6;
            this.BT_modificar.Text = "Modificar";
            this.BT_modificar.UseVisualStyleBackColor = false;
            this.BT_modificar.Click += new System.EventHandler(this.BT_modificar_Click);
            // 
            // BT_eliminar
            // 
            this.BT_eliminar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_eliminar.ForeColor = System.Drawing.Color.White;
            this.BT_eliminar.Location = new System.Drawing.Point(1370, 432);
            this.BT_eliminar.Name = "BT_eliminar";
            this.BT_eliminar.Size = new System.Drawing.Size(88, 37);
            this.BT_eliminar.TabIndex = 7;
            this.BT_eliminar.Text = "Eliminar";
            this.BT_eliminar.UseVisualStyleBackColor = false;
            this.BT_eliminar.Click += new System.EventHandler(this.BT_eliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Proveedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Fecha de Venc.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RB_prov_merc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.DT_fecha);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CB_proveedores);
            this.groupBox1.Controls.Add(this.RB_prov_serv);
            this.groupBox1.Location = new System.Drawing.Point(16, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 201);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS DE BUSQUEDA";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.TB_iva);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.TB_registro);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.TB_factura);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.TB_concepto);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.TB_importe);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.TB_patron);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.TB_tipo);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.TB_cliente);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.TB_cuenta);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.TB_banco);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.TB_enlace);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.TB_compra);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.TB_rfc);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.TB_sucursal);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.TB_fecha_venc);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.TB_fecha_prog);
            this.groupBox2.Location = new System.Drawing.Point(487, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(966, 201);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DATOS DEL PAGO";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(22, 33);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(46, 13);
            this.label17.TabIndex = 38;
            this.label17.Text = "Registro";
            // 
            // TB_registro
            // 
            this.TB_registro.Enabled = false;
            this.TB_registro.Location = new System.Drawing.Point(75, 30);
            this.TB_registro.Name = "TB_registro";
            this.TB_registro.Size = new System.Drawing.Size(61, 20);
            this.TB_registro.TabIndex = 37;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(811, 156);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 36;
            this.label11.Text = "Factura";
            // 
            // TB_factura
            // 
            this.TB_factura.Location = new System.Drawing.Point(726, 172);
            this.TB_factura.Name = "TB_factura";
            this.TB_factura.Size = new System.Drawing.Size(215, 20);
            this.TB_factura.TabIndex = 35;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(405, 157);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 34;
            this.label12.Text = "Concepto";
            // 
            // TB_concepto
            // 
            this.TB_concepto.Location = new System.Drawing.Point(266, 173);
            this.TB_concepto.Name = "TB_concepto";
            this.TB_concepto.Size = new System.Drawing.Size(431, 20);
            this.TB_concepto.TabIndex = 33;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(26, 157);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 13);
            this.label13.TabIndex = 32;
            this.label13.Text = "Importe";
            // 
            // TB_importe
            // 
            this.TB_importe.Location = new System.Drawing.Point(26, 173);
            this.TB_importe.Name = "TB_importe";
            this.TB_importe.Size = new System.Drawing.Size(100, 20);
            this.TB_importe.TabIndex = 31;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(786, 107);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 13);
            this.label14.TabIndex = 30;
            this.label14.Text = "Patrón";
            // 
            // TB_patron
            // 
            this.TB_patron.Location = new System.Drawing.Point(681, 123);
            this.TB_patron.Name = "TB_patron";
            this.TB_patron.Size = new System.Drawing.Size(260, 20);
            this.TB_patron.TabIndex = 29;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(585, 107);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 13);
            this.label15.TabIndex = 28;
            this.label15.Text = "Tipo Pago";
            // 
            // TB_tipo
            // 
            this.TB_tipo.Location = new System.Drawing.Point(563, 123);
            this.TB_tipo.Name = "TB_tipo";
            this.TB_tipo.Size = new System.Drawing.Size(100, 20);
            this.TB_tipo.TabIndex = 27;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(405, 107);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(39, 13);
            this.label16.TabIndex = 26;
            this.label16.Text = "Cliente";
            // 
            // TB_cliente
            // 
            this.TB_cliente.Location = new System.Drawing.Point(329, 123);
            this.TB_cliente.Name = "TB_cliente";
            this.TB_cliente.Size = new System.Drawing.Size(216, 20);
            this.TB_cliente.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(219, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Cuenta";
            // 
            // TB_cuenta
            // 
            this.TB_cuenta.Location = new System.Drawing.Point(181, 123);
            this.TB_cuenta.Name = "TB_cuenta";
            this.TB_cuenta.Size = new System.Drawing.Size(124, 20);
            this.TB_cuenta.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Banco";
            // 
            // TB_banco
            // 
            this.TB_banco.Location = new System.Drawing.Point(26, 123);
            this.TB_banco.Name = "TB_banco";
            this.TB_banco.Size = new System.Drawing.Size(135, 20);
            this.TB_banco.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(765, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Enlace";
            // 
            // TB_enlace
            // 
            this.TB_enlace.Location = new System.Drawing.Point(636, 73);
            this.TB_enlace.Name = "TB_enlace";
            this.TB_enlace.Size = new System.Drawing.Size(305, 20);
            this.TB_enlace.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(539, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Compra";
            // 
            // TB_compra
            // 
            this.TB_compra.Location = new System.Drawing.Point(514, 73);
            this.TB_compra.Name = "TB_compra";
            this.TB_compra.Size = new System.Drawing.Size(100, 20);
            this.TB_compra.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(423, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "RFC";
            // 
            // TB_rfc
            // 
            this.TB_rfc.Location = new System.Drawing.Point(383, 73);
            this.TB_rfc.Name = "TB_rfc";
            this.TB_rfc.Size = new System.Drawing.Size(113, 20);
            this.TB_rfc.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(282, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Sucursal";
            // 
            // TB_sucursal
            // 
            this.TB_sucursal.Location = new System.Drawing.Point(266, 73);
            this.TB_sucursal.Name = "TB_sucursal";
            this.TB_sucursal.Size = new System.Drawing.Size(100, 20);
            this.TB_sucursal.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(162, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Fecha venc.";
            // 
            // TB_fecha_venc
            // 
            this.TB_fecha_venc.Location = new System.Drawing.Point(146, 73);
            this.TB_fecha_venc.Name = "TB_fecha_venc";
            this.TB_fecha_venc.Size = new System.Drawing.Size(100, 20);
            this.TB_fecha_venc.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Fecha prog.";
            // 
            // TB_fecha_prog
            // 
            this.TB_fecha_prog.Location = new System.Drawing.Point(26, 73);
            this.TB_fecha_prog.Name = "TB_fecha_prog";
            this.TB_fecha_prog.Size = new System.Drawing.Size(100, 20);
            this.TB_fecha_prog.TabIndex = 0;
            // 
            // BT_limpiar
            // 
            this.BT_limpiar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_limpiar.ForeColor = System.Drawing.Color.White;
            this.BT_limpiar.Location = new System.Drawing.Point(1182, 432);
            this.BT_limpiar.Name = "BT_limpiar";
            this.BT_limpiar.Size = new System.Drawing.Size(88, 37);
            this.BT_limpiar.TabIndex = 12;
            this.BT_limpiar.Text = "Limpiar";
            this.BT_limpiar.UseVisualStyleBackColor = false;
            this.BT_limpiar.Click += new System.EventHandler(this.BT_limpiar_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(146, 157);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(24, 13);
            this.label18.TabIndex = 40;
            this.label18.Text = "IVA";
            // 
            // TB_iva
            // 
            this.TB_iva.Location = new System.Drawing.Point(146, 173);
            this.TB_iva.Name = "TB_iva";
            this.TB_iva.Size = new System.Drawing.Size(100, 20);
            this.TB_iva.TabIndex = 39;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // FECHA_PRO
            // 
            this.FECHA_PRO.HeaderText = "FECHA_PRO";
            this.FECHA_PRO.Name = "FECHA_PRO";
            // 
            // FECHA_VEN
            // 
            this.FECHA_VEN.HeaderText = "FECHA_VEN";
            this.FECHA_VEN.Name = "FECHA_VEN";
            // 
            // SUCURSAL
            // 
            this.SUCURSAL.HeaderText = "SUCURSAL";
            this.SUCURSAL.Name = "SUCURSAL";
            // 
            // RFC
            // 
            this.RFC.HeaderText = "RFC";
            this.RFC.Name = "RFC";
            // 
            // COMPRA
            // 
            this.COMPRA.HeaderText = "COMPRA";
            this.COMPRA.Name = "COMPRA";
            // 
            // ENLACE
            // 
            this.ENLACE.HeaderText = "ENLACE";
            this.ENLACE.Name = "ENLACE";
            // 
            // BANCO
            // 
            this.BANCO.HeaderText = "BANCO";
            this.BANCO.Name = "BANCO";
            // 
            // CUENTA
            // 
            this.CUENTA.HeaderText = "CUENTA";
            this.CUENTA.Name = "CUENTA";
            // 
            // CLIENTE
            // 
            this.CLIENTE.HeaderText = "CLIENTE";
            this.CLIENTE.Name = "CLIENTE";
            // 
            // TIPO
            // 
            this.TIPO.HeaderText = "TIPO PAGO";
            this.TIPO.Name = "TIPO";
            // 
            // PATRON
            // 
            this.PATRON.HeaderText = "PATRON";
            this.PATRON.Name = "PATRON";
            // 
            // IMPORTE
            // 
            this.IMPORTE.HeaderText = "IMPORTE";
            this.IMPORTE.Name = "IMPORTE";
            // 
            // IVA
            // 
            this.IVA.HeaderText = "IVA";
            this.IVA.Name = "IVA";
            // 
            // CONCEPTO
            // 
            this.CONCEPTO.HeaderText = "CONCEPTO";
            this.CONCEPTO.Name = "CONCEPTO";
            // 
            // FACTURA
            // 
            this.FACTURA.HeaderText = "FACTURA";
            this.FACTURA.Name = "FACTURA";
            // 
            // Modificar_pago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1464, 481);
            this.Controls.Add(this.BT_limpiar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BT_eliminar);
            this.Controls.Add(this.BT_modificar);
            this.Controls.Add(this.BT_buscar);
            this.Controls.Add(this.DG_tabla);
            this.Name = "Modificar_pago";
            this.Text = "Modificar_pago";
            this.Load += new System.EventHandler(this.Modificar_pago_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_tabla)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DG_tabla;
        private System.Windows.Forms.DateTimePicker DT_fecha;
        private System.Windows.Forms.ComboBox CB_proveedores;
        private System.Windows.Forms.RadioButton RB_prov_merc;
        private System.Windows.Forms.RadioButton RB_prov_serv;
        private System.Windows.Forms.Button BT_buscar;
        private System.Windows.Forms.Button BT_modificar;
        private System.Windows.Forms.Button BT_eliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_fecha_venc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_fecha_prog;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TB_factura;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TB_concepto;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TB_importe;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TB_patron;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TB_tipo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox TB_cliente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TB_cuenta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TB_banco;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TB_enlace;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TB_compra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TB_rfc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_sucursal;
        private System.Windows.Forms.Button BT_limpiar;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox TB_registro;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox TB_iva;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_PRO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_VEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUCURSAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn RFC;
        private System.Windows.Forms.DataGridViewTextBoxColumn COMPRA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ENLACE;
        private System.Windows.Forms.DataGridViewTextBoxColumn BANCO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUENTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PATRON;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMPORTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn IVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CONCEPTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FACTURA;
    }
}