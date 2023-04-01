namespace appSugerencias
{
    partial class frm_nuevo_pedido
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
            this.tbIdProv = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.link = new System.Windows.Forms.LinkLabel();
            this.button6 = new System.Windows.Forms.Button();
            this.cbLinea = new System.Windows.Forms.ComboBox();
            this.tbProveedor = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbIdPedido = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dtDia = new System.Windows.Forms.DateTimePicker();
            this.btguardar = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.tbObservaciones = new System.Windows.Forms.TextBox();
            this.tbComPago = new System.Windows.Forms.TextBox();
            this.tbNota = new System.Windows.Forms.TextBox();
            this.cBoxUrge = new System.Windows.Forms.CheckBox();
            this.tbGuia = new System.Windows.Forms.TextBox();
            this.tbCotiz = new System.Windows.Forms.TextBox();
            this.cBoxCo = new System.Windows.Forms.CheckBox();
            this.cBoxPm = new System.Windows.Forms.CheckBox();
            this.cBoxVl = new System.Windows.Forms.CheckBox();
            this.cBoxRe = new System.Windows.Forms.CheckBox();
            this.cBoxVa = new System.Windows.Forms.CheckBox();
            this.tbLink = new System.Windows.Forms.TextBox();
            this.cbProveedor = new System.Windows.Forms.ComboBox();
            this.tbArea = new System.Windows.Forms.TextBox();
            this.tbPedido = new System.Windows.Forms.TextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.Pedido = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.gbPagos = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.gbDatosGrl = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cBoxBo = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.dgvReportes = new System.Windows.Forms.DataGridView();
            this.TIENDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ALMACEN = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PISO_VENTA = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.REPORTE = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cbEstadoPedido = new System.Windows.Forms.ComboBox();
            this.tbTitulo2 = new System.Windows.Forms.TextBox();
            this.tbPedido2 = new System.Windows.Forms.TextBox();
            this.cbFormaPago = new System.Windows.Forms.ComboBox();
            this.cbTipoPago = new System.Windows.Forms.ComboBox();
            this.tabControl.SuspendLayout();
            this.Pedido.SuspendLayout();
            this.gbPagos.SuspendLayout();
            this.gbDatosGrl.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportes)).BeginInit();
            this.SuspendLayout();
            // 
            // tbIdProv
            // 
            this.tbIdProv.Enabled = false;
            this.tbIdProv.Location = new System.Drawing.Point(638, 109);
            this.tbIdProv.Name = "tbIdProv";
            this.tbIdProv.Size = new System.Drawing.Size(78, 20);
            this.tbIdProv.TabIndex = 89;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DodgerBlue;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(531, 249);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(79, 28);
            this.button5.TabIndex = 88;
            this.button5.Text = "Abrir";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click_2);
            // 
            // link
            // 
            this.link.AutoSize = true;
            this.link.Location = new System.Drawing.Point(732, 155);
            this.link.Name = "link";
            this.link.Size = new System.Drawing.Size(28, 13);
            this.link.TabIndex = 87;
            this.link.TabStop = true;
            this.link.Text = "Abrir";
            this.link.Visible = false;
            this.link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_LinkClicked_1);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.DodgerBlue;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(460, 66);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(90, 33);
            this.button6.TabIndex = 86;
            this.button6.Text = "Agregar";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // cbLinea
            // 
            this.cbLinea.FormattingEnabled = true;
            this.cbLinea.Location = new System.Drawing.Point(587, 73);
            this.cbLinea.Name = "cbLinea";
            this.cbLinea.Size = new System.Drawing.Size(173, 21);
            this.cbLinea.TabIndex = 85;
            // 
            // tbProveedor
            // 
            this.tbProveedor.Location = new System.Drawing.Point(112, 109);
            this.tbProveedor.Name = "tbProveedor";
            this.tbProveedor.Size = new System.Drawing.Size(491, 20);
            this.tbProveedor.TabIndex = 84;
            this.tbProveedor.Visible = false;
            this.tbProveedor.TextChanged += new System.EventHandler(this.tbProveedor_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(23, 17);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 16);
            this.label15.TabIndex = 83;
            this.label15.Text = "Id Pedido";
            // 
            // tbIdPedido
            // 
            this.tbIdPedido.Location = new System.Drawing.Point(112, 17);
            this.tbIdPedido.Name = "tbIdPedido";
            this.tbIdPedido.Size = new System.Drawing.Size(100, 20);
            this.tbIdPedido.TabIndex = 82;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(434, 249);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 29);
            this.button2.TabIndex = 79;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // dtDia
            // 
            this.dtDia.Enabled = false;
            this.dtDia.Location = new System.Drawing.Point(581, 16);
            this.dtDia.Name = "dtDia";
            this.dtDia.Size = new System.Drawing.Size(200, 20);
            this.dtDia.TabIndex = 78;
            // 
            // btguardar
            // 
            this.btguardar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btguardar.ForeColor = System.Drawing.Color.White;
            this.btguardar.Location = new System.Drawing.Point(667, 611);
            this.btguardar.Name = "btguardar";
            this.btguardar.Size = new System.Drawing.Size(150, 65);
            this.btguardar.TabIndex = 77;
            this.btguardar.Text = "Guardar";
            this.btguardar.UseVisualStyleBackColor = false;
            this.btguardar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(320, 14);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 24);
            this.label14.TabIndex = 76;
            this.label14.Text = "Pedido";
            // 
            // tbObservaciones
            // 
            this.tbObservaciones.Location = new System.Drawing.Point(125, 543);
            this.tbObservaciones.Multiline = true;
            this.tbObservaciones.Name = "tbObservaciones";
            this.tbObservaciones.Size = new System.Drawing.Size(290, 51);
            this.tbObservaciones.TabIndex = 75;
            // 
            // tbComPago
            // 
            this.tbComPago.Enabled = false;
            this.tbComPago.Location = new System.Drawing.Point(103, 22);
            this.tbComPago.Name = "tbComPago";
            this.tbComPago.Size = new System.Drawing.Size(318, 20);
            this.tbComPago.TabIndex = 72;
            // 
            // tbNota
            // 
            this.tbNota.Enabled = false;
            this.tbNota.Location = new System.Drawing.Point(112, 295);
            this.tbNota.Name = "tbNota";
            this.tbNota.Size = new System.Drawing.Size(316, 20);
            this.tbNota.TabIndex = 71;
            // 
            // cBoxUrge
            // 
            this.cBoxUrge.AutoSize = true;
            this.cBoxUrge.Location = new System.Drawing.Point(102, 59);
            this.cBoxUrge.Name = "cBoxUrge";
            this.cBoxUrge.Size = new System.Drawing.Size(36, 17);
            this.cBoxUrge.TabIndex = 67;
            this.cBoxUrge.Text = "SI";
            this.cBoxUrge.UseVisualStyleBackColor = true;
            // 
            // tbGuia
            // 
            this.tbGuia.Enabled = false;
            this.tbGuia.Location = new System.Drawing.Point(109, 256);
            this.tbGuia.Name = "tbGuia";
            this.tbGuia.Size = new System.Drawing.Size(319, 20);
            this.tbGuia.TabIndex = 66;
            // 
            // tbCotiz
            // 
            this.tbCotiz.Location = new System.Drawing.Point(109, 183);
            this.tbCotiz.Name = "tbCotiz";
            this.tbCotiz.Size = new System.Drawing.Size(182, 20);
            this.tbCotiz.TabIndex = 61;
            // 
            // cBoxCo
            // 
            this.cBoxCo.AutoSize = true;
            this.cBoxCo.Location = new System.Drawing.Point(434, 223);
            this.cBoxCo.Name = "cBoxCo";
            this.cBoxCo.Size = new System.Drawing.Size(41, 17);
            this.cBoxCo.TabIndex = 60;
            this.cBoxCo.Text = "CO";
            this.cBoxCo.UseVisualStyleBackColor = true;
            // 
            // cBoxPm
            // 
            this.cBoxPm.AutoSize = true;
            this.cBoxPm.Location = new System.Drawing.Point(520, 223);
            this.cBoxPm.Name = "cBoxPm";
            this.cBoxPm.Size = new System.Drawing.Size(42, 17);
            this.cBoxPm.TabIndex = 59;
            this.cBoxPm.Text = "PM";
            this.cBoxPm.UseVisualStyleBackColor = true;
            // 
            // cBoxVl
            // 
            this.cBoxVl.AutoSize = true;
            this.cBoxVl.Location = new System.Drawing.Point(343, 223);
            this.cBoxVl.Name = "cBoxVl";
            this.cBoxVl.Size = new System.Drawing.Size(39, 17);
            this.cBoxVl.TabIndex = 58;
            this.cBoxVl.Text = "VL";
            this.cBoxVl.UseVisualStyleBackColor = true;
            // 
            // cBoxRe
            // 
            this.cBoxRe.AutoSize = true;
            this.cBoxRe.Location = new System.Drawing.Point(253, 223);
            this.cBoxRe.Name = "cBoxRe";
            this.cBoxRe.Size = new System.Drawing.Size(41, 17);
            this.cBoxRe.TabIndex = 57;
            this.cBoxRe.Text = "RE";
            this.cBoxRe.UseVisualStyleBackColor = true;
            // 
            // cBoxVa
            // 
            this.cBoxVa.AutoSize = true;
            this.cBoxVa.Location = new System.Drawing.Point(167, 223);
            this.cBoxVa.Name = "cBoxVa";
            this.cBoxVa.Size = new System.Drawing.Size(40, 17);
            this.cBoxVa.TabIndex = 56;
            this.cBoxVa.Text = "VA";
            this.cBoxVa.UseVisualStyleBackColor = true;
            // 
            // tbLink
            // 
            this.tbLink.Location = new System.Drawing.Point(109, 148);
            this.tbLink.Name = "tbLink";
            this.tbLink.Size = new System.Drawing.Size(591, 20);
            this.tbLink.TabIndex = 55;
            this.tbLink.TextChanged += new System.EventHandler(this.tbLink_TextChanged_1);
            // 
            // cbProveedor
            // 
            this.cbProveedor.FormattingEnabled = true;
            this.cbProveedor.Location = new System.Drawing.Point(112, 110);
            this.cbProveedor.Name = "cbProveedor";
            this.cbProveedor.Size = new System.Drawing.Size(517, 21);
            this.cbProveedor.TabIndex = 54;
            this.cbProveedor.SelectedIndexChanged += new System.EventHandler(this.cbProveedor_SelectedIndexChanged_1);
            // 
            // tbArea
            // 
            this.tbArea.Location = new System.Drawing.Point(112, 74);
            this.tbArea.Name = "tbArea";
            this.tbArea.Size = new System.Drawing.Size(316, 20);
            this.tbArea.TabIndex = 53;
            // 
            // tbPedido
            // 
            this.tbPedido.Location = new System.Drawing.Point(112, 43);
            this.tbPedido.Name = "tbPedido";
            this.tbPedido.Size = new System.Drawing.Size(316, 20);
            this.tbPedido.TabIndex = 48;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.Pedido);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(12, 4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(842, 708);
            this.tabControl.TabIndex = 90;
            // 
            // Pedido
            // 
            this.Pedido.Controls.Add(this.label13);
            this.Pedido.Controls.Add(this.gbPagos);
            this.Pedido.Controls.Add(this.gbDatosGrl);
            this.Pedido.Controls.Add(this.btguardar);
            this.Pedido.Controls.Add(this.dtDia);
            this.Pedido.Controls.Add(this.label14);
            this.Pedido.Controls.Add(this.tbObservaciones);
            this.Pedido.Location = new System.Drawing.Point(4, 22);
            this.Pedido.Name = "Pedido";
            this.Pedido.Padding = new System.Windows.Forms.Padding(3);
            this.Pedido.Size = new System.Drawing.Size(834, 682);
            this.Pedido.TabIndex = 0;
            this.Pedido.Text = "Pedido";
            this.Pedido.UseVisualStyleBackColor = true;
            this.Pedido.Click += new System.EventHandler(this.Pedido_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(10, 559);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 16);
            this.label13.TabIndex = 106;
            this.label13.Text = "Observaciones";
            // 
            // gbPagos
            // 
            this.gbPagos.Controls.Add(this.cbTipoPago);
            this.gbPagos.Controls.Add(this.cbFormaPago);
            this.gbPagos.Controls.Add(this.label12);
            this.gbPagos.Controls.Add(this.label10);
            this.gbPagos.Controls.Add(this.label9);
            this.gbPagos.Controls.Add(this.label8);
            this.gbPagos.Controls.Add(this.button10);
            this.gbPagos.Controls.Add(this.button11);
            this.gbPagos.Controls.Add(this.tbComPago);
            this.gbPagos.Controls.Add(this.cBoxUrge);
            this.gbPagos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPagos.Location = new System.Drawing.Point(13, 374);
            this.gbPagos.Name = "gbPagos";
            this.gbPagos.Size = new System.Drawing.Size(804, 163);
            this.gbPagos.TabIndex = 91;
            this.gbPagos.TabStop = false;
            this.gbPagos.Text = "Pagos";
            this.gbPagos.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1, 133);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 16);
            this.label12.TabIndex = 105;
            this.label12.Text = "Forma Pago";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(15, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 16);
            this.label10.TabIndex = 104;
            this.label10.Text = "Tipo Pago";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 16);
            this.label9.TabIndex = 103;
            this.label9.Text = "Pago Urge";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 16);
            this.label8.TabIndex = 102;
            this.label8.Text = "Com. Pago";
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.DodgerBlue;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Location = new System.Drawing.Point(524, 23);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(79, 28);
            this.button10.TabIndex = 101;
            this.button10.Text = "Abrir";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.DodgerBlue;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.Color.White;
            this.button11.Location = new System.Drawing.Point(427, 23);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(72, 29);
            this.button11.TabIndex = 100;
            this.button11.Text = "...";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // gbDatosGrl
            // 
            this.gbDatosGrl.Controls.Add(this.label6);
            this.gbDatosGrl.Controls.Add(this.cBoxBo);
            this.gbDatosGrl.Controls.Add(this.label5);
            this.gbDatosGrl.Controls.Add(this.label4);
            this.gbDatosGrl.Controls.Add(this.label7);
            this.gbDatosGrl.Controls.Add(this.label3);
            this.gbDatosGrl.Controls.Add(this.label2);
            this.gbDatosGrl.Controls.Add(this.label1);
            this.gbDatosGrl.Controls.Add(this.button8);
            this.gbDatosGrl.Controls.Add(this.label18);
            this.gbDatosGrl.Controls.Add(this.button9);
            this.gbDatosGrl.Controls.Add(this.tbArea);
            this.gbDatosGrl.Controls.Add(this.cbLinea);
            this.gbDatosGrl.Controls.Add(this.tbNota);
            this.gbDatosGrl.Controls.Add(this.tbCotiz);
            this.gbDatosGrl.Controls.Add(this.cBoxCo);
            this.gbDatosGrl.Controls.Add(this.button5);
            this.gbDatosGrl.Controls.Add(this.cBoxPm);
            this.gbDatosGrl.Controls.Add(this.button2);
            this.gbDatosGrl.Controls.Add(this.tbIdProv);
            this.gbDatosGrl.Controls.Add(this.cBoxVl);
            this.gbDatosGrl.Controls.Add(this.cBoxRe);
            this.gbDatosGrl.Controls.Add(this.cBoxVa);
            this.gbDatosGrl.Controls.Add(this.tbLink);
            this.gbDatosGrl.Controls.Add(this.link);
            this.gbDatosGrl.Controls.Add(this.cbProveedor);
            this.gbDatosGrl.Controls.Add(this.tbPedido);
            this.gbDatosGrl.Controls.Add(this.button6);
            this.gbDatosGrl.Controls.Add(this.tbIdPedido);
            this.gbDatosGrl.Controls.Add(this.tbProveedor);
            this.gbDatosGrl.Controls.Add(this.tbGuia);
            this.gbDatosGrl.Controls.Add(this.label15);
            this.gbDatosGrl.Location = new System.Drawing.Point(13, 41);
            this.gbDatosGrl.Name = "gbDatosGrl";
            this.gbDatosGrl.Size = new System.Drawing.Size(804, 327);
            this.gbDatosGrl.TabIndex = 90;
            this.gbDatosGrl.TabStop = false;
            this.gbDatosGrl.Text = "Datos Generales";
            this.gbDatosGrl.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(57, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 16);
            this.label6.TabIndex = 97;
            this.label6.Text = "Guia";
            // 
            // cBoxBo
            // 
            this.cBoxBo.AutoSize = true;
            this.cBoxBo.Location = new System.Drawing.Point(110, 222);
            this.cBoxBo.Name = "cBoxBo";
            this.cBoxBo.Size = new System.Drawing.Size(41, 17);
            this.cBoxBo.TabIndex = 96;
            this.cBoxBo.Text = "BO";
            this.cBoxBo.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 95;
            this.label5.Text = "Almacenes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 94;
            this.label4.Text = "Cotización";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(57, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 16);
            this.label7.TabIndex = 98;
            this.label7.Text = "Nota";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 93;
            this.label3.Text = "Link Pedido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 92;
            this.label2.Text = "Provedor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 91;
            this.label1.Text = "Area";
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.DodgerBlue;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(531, 293);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(79, 28);
            this.button8.TabIndex = 99;
            this.button8.Text = "Abrir";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(0, 43);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(101, 16);
            this.label18.TabIndex = 90;
            this.label18.Text = "Titulo Pedido";
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.DodgerBlue;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(434, 293);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(72, 29);
            this.button9.TabIndex = 98;
            this.button9.Text = "...";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.button7);
            this.tabPage2.Controls.Add(this.dgvReportes);
            this.tabPage2.Controls.Add(this.cbEstadoPedido);
            this.tabPage2.Controls.Add(this.tbTitulo2);
            this.tabPage2.Controls.Add(this.tbPedido2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(834, 682);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Informacion";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(300, 333);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(243, 16);
            this.label11.TabIndex = 97;
            this.label11.Text = "Progreso de Reportes Por Tienda";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(47, 116);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(57, 16);
            this.label20.TabIndex = 96;
            this.label20.Text = "Estado";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(3, 76);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(101, 16);
            this.label17.TabIndex = 95;
            this.label17.Text = "Titulo Pedido";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(29, 37);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(75, 16);
            this.label16.TabIndex = 94;
            this.label16.Text = "Id Pedido";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.DodgerBlue;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(635, 116);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(150, 65);
            this.button7.TabIndex = 92;
            this.button7.Text = "Guardar";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click_1);
            // 
            // dgvReportes
            // 
            this.dgvReportes.AllowUserToAddRows = false;
            this.dgvReportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TIENDA,
            this.ALMACEN,
            this.PISO_VENTA,
            this.REPORTE});
            this.dgvReportes.Location = new System.Drawing.Point(169, 362);
            this.dgvReportes.Name = "dgvReportes";
            this.dgvReportes.Size = new System.Drawing.Size(498, 172);
            this.dgvReportes.TabIndex = 91;
            // 
            // TIENDA
            // 
            this.TIENDA.HeaderText = "TIENDA";
            this.TIENDA.Name = "TIENDA";
            this.TIENDA.ReadOnly = true;
            // 
            // ALMACEN
            // 
            this.ALMACEN.HeaderText = "ALMACEN";
            this.ALMACEN.Name = "ALMACEN";
            this.ALMACEN.ReadOnly = true;
            this.ALMACEN.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ALMACEN.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // PISO_VENTA
            // 
            this.PISO_VENTA.HeaderText = "PISO DE VENTA";
            this.PISO_VENTA.Name = "PISO_VENTA";
            this.PISO_VENTA.ReadOnly = true;
            this.PISO_VENTA.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PISO_VENTA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.PISO_VENTA.Width = 150;
            // 
            // REPORTE
            // 
            this.REPORTE.HeaderText = "REPORTE";
            this.REPORTE.Name = "REPORTE";
            this.REPORTE.ReadOnly = true;
            this.REPORTE.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.REPORTE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // cbEstadoPedido
            // 
            this.cbEstadoPedido.FormattingEnabled = true;
            this.cbEstadoPedido.Location = new System.Drawing.Point(110, 116);
            this.cbEstadoPedido.Name = "cbEstadoPedido";
            this.cbEstadoPedido.Size = new System.Drawing.Size(174, 21);
            this.cbEstadoPedido.TabIndex = 89;
            // 
            // tbTitulo2
            // 
            this.tbTitulo2.Enabled = false;
            this.tbTitulo2.Location = new System.Drawing.Point(110, 75);
            this.tbTitulo2.Name = "tbTitulo2";
            this.tbTitulo2.Size = new System.Drawing.Size(316, 20);
            this.tbTitulo2.TabIndex = 86;
            // 
            // tbPedido2
            // 
            this.tbPedido2.Enabled = false;
            this.tbPedido2.Location = new System.Drawing.Point(110, 36);
            this.tbPedido2.Name = "tbPedido2";
            this.tbPedido2.Size = new System.Drawing.Size(100, 20);
            this.tbPedido2.TabIndex = 83;
            // 
            // cbFormaPago
            // 
            this.cbFormaPago.FormattingEnabled = true;
            this.cbFormaPago.Items.AddRange(new object[] {
            " ",
            "EFECTIVO",
            "DEP/F",
            "SPEI"});
            this.cbFormaPago.Location = new System.Drawing.Point(103, 132);
            this.cbFormaPago.Name = "cbFormaPago";
            this.cbFormaPago.Size = new System.Drawing.Size(163, 21);
            this.cbFormaPago.TabIndex = 106;
            // 
            // cbTipoPago
            // 
            this.cbTipoPago.FormattingEnabled = true;
            this.cbTipoPago.Items.AddRange(new object[] {
            " ",
            "ANTICIPADO",
            "CONTADO",
            "CREDITO"});
            this.cbTipoPago.Location = new System.Drawing.Point(102, 94);
            this.cbTipoPago.Name = "cbTipoPago";
            this.cbTipoPago.Size = new System.Drawing.Size(163, 21);
            this.cbTipoPago.TabIndex = 107;
            // 
            // frm_nuevo_pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(862, 719);
            this.Controls.Add(this.tabControl);
            this.Name = "frm_nuevo_pedido";
            this.Text = "Crea/Modifica Pedido";
            this.Load += new System.EventHandler(this.frm_nuevo_pedido_Load);
            this.tabControl.ResumeLayout(false);
            this.Pedido.ResumeLayout(false);
            this.Pedido.PerformLayout();
            this.gbPagos.ResumeLayout(false);
            this.gbPagos.PerformLayout();
            this.gbDatosGrl.ResumeLayout(false);
            this.gbDatosGrl.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbIdProv;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.LinkLabel link;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ComboBox cbLinea;
        private System.Windows.Forms.TextBox tbProveedor;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbIdPedido;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dtDia;
        private System.Windows.Forms.Button btguardar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbObservaciones;
        private System.Windows.Forms.TextBox tbComPago;
        private System.Windows.Forms.TextBox tbNota;
        private System.Windows.Forms.CheckBox cBoxUrge;
        private System.Windows.Forms.TextBox tbGuia;
        private System.Windows.Forms.TextBox tbCotiz;
        private System.Windows.Forms.CheckBox cBoxCo;
        private System.Windows.Forms.CheckBox cBoxPm;
        private System.Windows.Forms.CheckBox cBoxVl;
        private System.Windows.Forms.CheckBox cBoxRe;
        private System.Windows.Forms.CheckBox cBoxVa;
        private System.Windows.Forms.TextBox tbLink;
        private System.Windows.Forms.ComboBox cbProveedor;
        private System.Windows.Forms.TextBox tbArea;
        private System.Windows.Forms.TextBox tbPedido;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage Pedido;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tbTitulo2;
        private System.Windows.Forms.TextBox tbPedido2;
        private System.Windows.Forms.ComboBox cbEstadoPedido;
        private System.Windows.Forms.DataGridView dgvReportes;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIENDA;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ALMACEN;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PISO_VENTA;
        private System.Windows.Forms.DataGridViewCheckBoxColumn REPORTE;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.GroupBox gbPagos;
        private System.Windows.Forms.GroupBox gbDatosGrl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.CheckBox cBoxBo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbTipoPago;
        private System.Windows.Forms.ComboBox cbFormaPago;
    }
}