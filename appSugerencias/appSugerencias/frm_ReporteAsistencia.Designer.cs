namespace appSugerencias
{
    partial class frm_ReporteAsistencia
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
            this.Busqueda = new System.Windows.Forms.GroupBox();
            this.Tie = new System.Windows.Forms.TabControl();
            this.Tiendaa = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbTienda = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.cbPatron = new System.Windows.Forms.ComboBox();
            this.lblFalta = new System.Windows.Forms.Label();
            this.lblPermiso = new System.Windows.Forms.Label();
            this.lblIncapacidad = new System.Windows.Forms.Label();
            this.lblVaca = new System.Windows.Forms.Label();
            this.lblDescanso = new System.Windows.Forms.Label();
            this.lblAsistencia = new System.Windows.Forms.Label();
            this.lblBodega = new System.Windows.Forms.Label();
            this.lblPisoVenta = new System.Windows.Forms.Label();
            this.lblCajas = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtFin = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbFiltro = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lblAma = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblApa = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.dgvReporte = new System.Windows.Forms.DataGridView();
            this.FECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APELLIDO_PA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APELLIDO_MA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIENDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AREA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.Busqueda.SuspendLayout();
            this.Tie.SuspendLayout();
            this.Tiendaa.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte)).BeginInit();
            this.SuspendLayout();
            // 
            // Busqueda
            // 
            this.Busqueda.Controls.Add(this.Tie);
            this.Busqueda.Location = new System.Drawing.Point(17, 149);
            this.Busqueda.Name = "Busqueda";
            this.Busqueda.Size = new System.Drawing.Size(261, 128);
            this.Busqueda.TabIndex = 86;
            this.Busqueda.TabStop = false;
            this.Busqueda.Text = "Busqueda";
            // 
            // Tie
            // 
            this.Tie.Controls.Add(this.Tiendaa);
            this.Tie.Controls.Add(this.tabPage2);
            this.Tie.Controls.Add(this.tabPage1);
            this.Tie.Location = new System.Drawing.Point(11, 19);
            this.Tie.Name = "Tie";
            this.Tie.SelectedIndex = 0;
            this.Tie.Size = new System.Drawing.Size(244, 100);
            this.Tie.TabIndex = 62;
            // 
            // Tiendaa
            // 
            this.Tiendaa.Controls.Add(this.button4);
            this.Tiendaa.Location = new System.Drawing.Point(4, 22);
            this.Tiendaa.Name = "Tiendaa";
            this.Tiendaa.Padding = new System.Windows.Forms.Padding(3);
            this.Tiendaa.Size = new System.Drawing.Size(236, 74);
            this.Tiendaa.TabIndex = 0;
            this.Tiendaa.Text = "Todos";
            this.Tiendaa.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(155, 45);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 41;
            this.button4.Text = "Consultar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cbTienda);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(236, 74);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tienda";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cbTienda
            // 
            this.cbTienda.FormattingEnabled = true;
            this.cbTienda.Location = new System.Drawing.Point(6, 6);
            this.cbTienda.Name = "cbTienda";
            this.cbTienda.Size = new System.Drawing.Size(121, 21);
            this.cbTienda.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(155, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.cbPatron);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(236, 74);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Patron";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(155, 45);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Consultar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cbPatron
            // 
            this.cbPatron.FormattingEnabled = true;
            this.cbPatron.Location = new System.Drawing.Point(6, 6);
            this.cbPatron.Name = "cbPatron";
            this.cbPatron.Size = new System.Drawing.Size(227, 21);
            this.cbPatron.TabIndex = 6;
            // 
            // lblFalta
            // 
            this.lblFalta.AutoSize = true;
            this.lblFalta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFalta.ForeColor = System.Drawing.Color.Blue;
            this.lblFalta.Location = new System.Drawing.Point(1145, 382);
            this.lblFalta.Name = "lblFalta";
            this.lblFalta.Size = new System.Drawing.Size(27, 20);
            this.lblFalta.TabIndex = 85;
            this.lblFalta.Text = "---";
            // 
            // lblPermiso
            // 
            this.lblPermiso.AutoSize = true;
            this.lblPermiso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPermiso.ForeColor = System.Drawing.Color.Blue;
            this.lblPermiso.Location = new System.Drawing.Point(1145, 343);
            this.lblPermiso.Name = "lblPermiso";
            this.lblPermiso.Size = new System.Drawing.Size(27, 20);
            this.lblPermiso.TabIndex = 84;
            this.lblPermiso.Text = "---";
            // 
            // lblIncapacidad
            // 
            this.lblIncapacidad.AutoSize = true;
            this.lblIncapacidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncapacidad.ForeColor = System.Drawing.Color.Blue;
            this.lblIncapacidad.Location = new System.Drawing.Point(1145, 305);
            this.lblIncapacidad.Name = "lblIncapacidad";
            this.lblIncapacidad.Size = new System.Drawing.Size(27, 20);
            this.lblIncapacidad.TabIndex = 83;
            this.lblIncapacidad.Text = "---";
            // 
            // lblVaca
            // 
            this.lblVaca.AutoSize = true;
            this.lblVaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVaca.ForeColor = System.Drawing.Color.Blue;
            this.lblVaca.Location = new System.Drawing.Point(1145, 265);
            this.lblVaca.Name = "lblVaca";
            this.lblVaca.Size = new System.Drawing.Size(27, 20);
            this.lblVaca.TabIndex = 82;
            this.lblVaca.Text = "---";
            // 
            // lblDescanso
            // 
            this.lblDescanso.AutoSize = true;
            this.lblDescanso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescanso.ForeColor = System.Drawing.Color.Blue;
            this.lblDescanso.Location = new System.Drawing.Point(1145, 227);
            this.lblDescanso.Name = "lblDescanso";
            this.lblDescanso.Size = new System.Drawing.Size(27, 20);
            this.lblDescanso.TabIndex = 81;
            this.lblDescanso.Text = "---";
            // 
            // lblAsistencia
            // 
            this.lblAsistencia.AutoSize = true;
            this.lblAsistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsistencia.ForeColor = System.Drawing.Color.Blue;
            this.lblAsistencia.Location = new System.Drawing.Point(1145, 188);
            this.lblAsistencia.Name = "lblAsistencia";
            this.lblAsistencia.Size = new System.Drawing.Size(27, 20);
            this.lblAsistencia.TabIndex = 80;
            this.lblAsistencia.Text = "---";
            // 
            // lblBodega
            // 
            this.lblBodega.AutoSize = true;
            this.lblBodega.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBodega.ForeColor = System.Drawing.Color.Blue;
            this.lblBodega.Location = new System.Drawing.Point(1109, 89);
            this.lblBodega.Name = "lblBodega";
            this.lblBodega.Size = new System.Drawing.Size(27, 20);
            this.lblBodega.TabIndex = 79;
            this.lblBodega.Text = "---";
            // 
            // lblPisoVenta
            // 
            this.lblPisoVenta.AutoSize = true;
            this.lblPisoVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPisoVenta.ForeColor = System.Drawing.Color.Blue;
            this.lblPisoVenta.Location = new System.Drawing.Point(1109, 53);
            this.lblPisoVenta.Name = "lblPisoVenta";
            this.lblPisoVenta.Size = new System.Drawing.Size(27, 20);
            this.lblPisoVenta.TabIndex = 78;
            this.lblPisoVenta.Text = "---";
            // 
            // lblCajas
            // 
            this.lblCajas.AutoSize = true;
            this.lblCajas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCajas.ForeColor = System.Drawing.Color.Blue;
            this.lblCajas.Location = new System.Drawing.Point(1109, 23);
            this.lblCajas.Name = "lblCajas";
            this.lblCajas.Size = new System.Drawing.Size(27, 20);
            this.lblCajas.TabIndex = 77;
            this.lblCajas.Text = "---";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(956, 379);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 24);
            this.label14.TabIndex = 76;
            this.label14.Text = "Falta:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(956, 340);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 24);
            this.label13.TabIndex = 75;
            this.label13.Text = "Permiso:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(956, 301);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(151, 24);
            this.label12.TabIndex = 74;
            this.label12.Text = "Incapacidades:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(956, 262);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 24);
            this.label11.TabIndex = 73;
            this.label11.Text = "Vacaciones:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(956, 223);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 24);
            this.label10.TabIndex = 72;
            this.label10.Text = "Descanso:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(956, 184);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 24);
            this.label9.TabIndex = 71;
            this.label9.Text = "Asistencia:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(956, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 24);
            this.label8.TabIndex = 70;
            this.label8.Text = "Bodega:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(956, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 24);
            this.label7.TabIndex = 69;
            this.label7.Text = "Piso Venta:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(956, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 24);
            this.label6.TabIndex = 68;
            this.label6.Text = "Cajas:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtInicio);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dtFin);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(17, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(267, 122);
            this.groupBox2.TabIndex = 67;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fechas";
            // 
            // dtInicio
            // 
            this.dtInicio.Location = new System.Drawing.Point(61, 42);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(200, 20);
            this.dtInicio.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Fin";
            // 
            // dtFin
            // 
            this.dtFin.Location = new System.Drawing.Point(61, 84);
            this.dtFin.Name = "dtFin";
            this.dtFin.Size = new System.Drawing.Size(200, 20);
            this.dtFin.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Inicio";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbFiltro);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.lblAma);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dgvEmpleados);
            this.groupBox1.Controls.Add(this.lblApa);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Location = new System.Drawing.Point(290, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(511, 267);
            this.groupBox1.TabIndex = 66;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda por Empleado";
            // 
            // tbFiltro
            // 
            this.tbFiltro.Location = new System.Drawing.Point(17, 45);
            this.tbFiltro.Name = "tbFiltro";
            this.tbFiltro.Size = new System.Drawing.Size(238, 20);
            this.tbFiltro.TabIndex = 29;
            this.tbFiltro.TextChanged += new System.EventHandler(this.tbFiltro_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(421, 238);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Consultar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblAma
            // 
            this.lblAma.AutoSize = true;
            this.lblAma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAma.Location = new System.Drawing.Point(355, 74);
            this.lblAma.Name = "lblAma";
            this.lblAma.Size = new System.Drawing.Size(23, 16);
            this.lblAma.TabIndex = 40;
            this.lblAma.Text = "---";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Nombre del Empleado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Resultado";
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.AllowUserToAddRows = false;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14});
            this.dgvEmpleados.Location = new System.Drawing.Point(17, 108);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.Size = new System.Drawing.Size(479, 118);
            this.dgvEmpleados.TabIndex = 32;
            this.dgvEmpleados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleados_CellDoubleClick);
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Id";
            this.Column11.Name = "Column11";
            this.Column11.Visible = false;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Nombre";
            this.Column12.Name = "Column12";
            this.Column12.Width = 120;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Apellido Paterno";
            this.Column13.Name = "Column13";
            this.Column13.Width = 150;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "Apellido Materno";
            this.Column14.Name = "Column14";
            this.Column14.Width = 150;
            // 
            // lblApa
            // 
            this.lblApa.AutoSize = true;
            this.lblApa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApa.Location = new System.Drawing.Point(355, 54);
            this.lblApa.Name = "lblApa";
            this.lblApa.Size = new System.Drawing.Size(23, 16);
            this.lblApa.TabIndex = 39;
            this.lblApa.Text = "---";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(355, 34);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(23, 16);
            this.lblNombre.TabIndex = 38;
            this.lblNombre.Text = "---";
            // 
            // dgvReporte
            // 
            this.dgvReporte.AllowUserToAddRows = false;
            this.dgvReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReporte.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FECHA,
            this.ESTADO,
            this.NOMBRE,
            this.APELLIDO_PA,
            this.APELLIDO_MA,
            this.TIENDA,
            this.AREA});
            this.dgvReporte.Location = new System.Drawing.Point(8, 298);
            this.dgvReporte.Name = "dgvReporte";
            this.dgvReporte.Size = new System.Drawing.Size(877, 551);
            this.dgvReporte.TabIndex = 65;
            // 
            // FECHA
            // 
            this.FECHA.HeaderText = "Fecha";
            this.FECHA.Name = "FECHA";
            // 
            // ESTADO
            // 
            this.ESTADO.HeaderText = "Estado";
            this.ESTADO.Name = "ESTADO";
            this.ESTADO.Width = 50;
            // 
            // NOMBRE
            // 
            this.NOMBRE.HeaderText = "Nombre";
            this.NOMBRE.Name = "NOMBRE";
            this.NOMBRE.Width = 180;
            // 
            // APELLIDO_PA
            // 
            this.APELLIDO_PA.HeaderText = "Apellido Paterno";
            this.APELLIDO_PA.Name = "APELLIDO_PA";
            this.APELLIDO_PA.Width = 150;
            // 
            // APELLIDO_MA
            // 
            this.APELLIDO_MA.HeaderText = "Apellido Materno";
            this.APELLIDO_MA.Name = "APELLIDO_MA";
            this.APELLIDO_MA.Width = 150;
            // 
            // TIENDA
            // 
            this.TIENDA.HeaderText = "Tienda";
            this.TIENDA.Name = "TIENDA";
            this.TIENDA.ReadOnly = true;
            // 
            // AREA
            // 
            this.AREA.HeaderText = "Area";
            this.AREA.Name = "AREA";
            this.AREA.ReadOnly = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1026, 789);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(130, 46);
            this.button5.TabIndex = 41;
            this.button5.Text = "Consultar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(825, 24);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(93, 41);
            this.button6.TabIndex = 87;
            this.button6.Text = "Distribucion de Areas";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // frm_ReporteAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1211, 861);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.Busqueda);
            this.Controls.Add(this.lblFalta);
            this.Controls.Add(this.lblPermiso);
            this.Controls.Add(this.lblIncapacidad);
            this.Controls.Add(this.lblVaca);
            this.Controls.Add(this.lblDescanso);
            this.Controls.Add(this.lblAsistencia);
            this.Controls.Add(this.lblBodega);
            this.Controls.Add(this.lblPisoVenta);
            this.Controls.Add(this.lblCajas);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvReporte);
            this.Name = "frm_ReporteAsistencia";
            this.Text = "frm_ReporteAsistencia";
            this.Load += new System.EventHandler(this.frm_ReporteAsistencia_Load);
            this.Busqueda.ResumeLayout(false);
            this.Tie.ResumeLayout(false);
            this.Tiendaa.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Busqueda;
        private System.Windows.Forms.TabControl Tie;
        private System.Windows.Forms.TabPage Tiendaa;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cbTienda;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox cbPatron;
        private System.Windows.Forms.Label lblFalta;
        private System.Windows.Forms.Label lblPermiso;
        private System.Windows.Forms.Label lblIncapacidad;
        private System.Windows.Forms.Label lblVaca;
        private System.Windows.Forms.Label lblDescanso;
        private System.Windows.Forms.Label lblAsistencia;
        private System.Windows.Forms.Label lblBodega;
        private System.Windows.Forms.Label lblPisoVenta;
        private System.Windows.Forms.Label lblCajas;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtFin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbFiltro;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblAma;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.Label lblApa;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DataGridView dgvReporte;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn APELLIDO_PA;
        private System.Windows.Forms.DataGridViewTextBoxColumn APELLIDO_MA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIENDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn AREA;
        private System.Windows.Forms.Button button6;
    }
}