namespace appSugerencias
{
    partial class VentasEnCajas
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
            this.lb = new System.Windows.Forms.Label();
            this.CB_sucursal = new System.Windows.Forms.ComboBox();
            this.DT_fecha = new System.Windows.Forms.DateTimePicker();
            this.DG_tabla = new System.Windows.Forms.DataGridView();
            this.ESTACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL_VENTAS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EGRESO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL_EFECTIVO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VOUCHER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RETIRO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOBRANTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DEVOLUCIONES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OTROS_EFECTIVOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VENTAS_NETAS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIFERENCIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GB_datos = new System.Windows.Forms.GroupBox();
            this.BT_CambiarConcepto = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.RETIROS = new System.Windows.Forms.Label();
            this.DG_egresos = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HORAEGRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHECK2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DG_retiros = new System.Windows.Forms.DataGridView();
            this.NUM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMPORTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HORA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USUARIO_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHECK = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.LB_usuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CHK_respaldo = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DG_diferencia = new System.Windows.Forms.DataGridView();
            this.DIFERENCIA_VTA_TARJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DG_tarjeg = new System.Windows.Forms.DataGridView();
            this.DG_tarjin = new System.Windows.Forms.DataGridView();
            this.CHK_egTarj = new System.Windows.Forms.CheckBox();
            this.CHK_inTarj = new System.Windows.Forms.CheckBox();
            this.CHK_egresos = new System.Windows.Forms.CheckBox();
            this.CHK_retiros = new System.Windows.Forms.CheckBox();
            this.CHK_ventas = new System.Windows.Forms.CheckBox();
            this.BT_excel = new System.Windows.Forms.Button();
            this.BT_Aceptar = new System.Windows.Forms.Button();
            this.DG_ventasCaja = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TB_buscarTicket = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DG_tabla)).BeginInit();
            this.GB_datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_egresos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_retiros)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_diferencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_tarjeg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_tarjin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_ventasCaja)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.Location = new System.Drawing.Point(11, 26);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(81, 16);
            this.lb.TabIndex = 0;
            this.lb.Text = "SUCURSAL";
            // 
            // CB_sucursal
            // 
            this.CB_sucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_sucursal.FormattingEnabled = true;
            this.CB_sucursal.Location = new System.Drawing.Point(93, 21);
            this.CB_sucursal.Name = "CB_sucursal";
            this.CB_sucursal.Size = new System.Drawing.Size(121, 24);
            this.CB_sucursal.TabIndex = 1;
            this.CB_sucursal.SelectedIndexChanged += new System.EventHandler(this.CB_sucursal_SelectedIndexChanged);
            // 
            // DT_fecha
            // 
            this.DT_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DT_fecha.Location = new System.Drawing.Point(422, 23);
            this.DT_fecha.Name = "DT_fecha";
            this.DT_fecha.Size = new System.Drawing.Size(256, 22);
            this.DT_fecha.TabIndex = 23;
            // 
            // DG_tabla
            // 
            this.DG_tabla.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DG_tabla.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DG_tabla.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DG_tabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_tabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DG_tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ESTACION,
            this.TOTAL_VENTAS,
            this.EGRESO,
            this.TOTAL_EFECTIVO,
            this.VOUCHER,
            this.RETIRO,
            this.SOBRANTE,
            this.DEVOLUCIONES,
            this.OTROS_EFECTIVOS,
            this.VENTAS_NETAS,
            this.DIFERENCIA});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DG_tabla.DefaultCellStyle = dataGridViewCellStyle3;
            this.DG_tabla.Location = new System.Drawing.Point(12, 67);
            this.DG_tabla.Name = "DG_tabla";
            this.DG_tabla.Size = new System.Drawing.Size(962, 287);
            this.DG_tabla.TabIndex = 26;
            this.DG_tabla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_tabla_CellContentClick);
            this.DG_tabla.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_tabla_CellDoubleClick);
            // 
            // ESTACION
            // 
            this.ESTACION.HeaderText = "ESTACION";
            this.ESTACION.Name = "ESTACION";
            // 
            // TOTAL_VENTAS
            // 
            this.TOTAL_VENTAS.HeaderText = "TOTAL VENTAS";
            this.TOTAL_VENTAS.Name = "TOTAL_VENTAS";
            // 
            // EGRESO
            // 
            this.EGRESO.HeaderText = "EGRESO";
            this.EGRESO.Name = "EGRESO";
            // 
            // TOTAL_EFECTIVO
            // 
            this.TOTAL_EFECTIVO.HeaderText = "TOTAL EFECTIVO";
            this.TOTAL_EFECTIVO.Name = "TOTAL_EFECTIVO";
            // 
            // VOUCHER
            // 
            this.VOUCHER.HeaderText = "VOUCHER";
            this.VOUCHER.Name = "VOUCHER";
            // 
            // RETIRO
            // 
            this.RETIRO.HeaderText = "RETIRO";
            this.RETIRO.Name = "RETIRO";
            // 
            // SOBRANTE
            // 
            this.SOBRANTE.HeaderText = "SOBRANTE";
            this.SOBRANTE.Name = "SOBRANTE";
            // 
            // DEVOLUCIONES
            // 
            this.DEVOLUCIONES.HeaderText = "DEVOLUCIONES";
            this.DEVOLUCIONES.Name = "DEVOLUCIONES";
            // 
            // OTROS_EFECTIVOS
            // 
            this.OTROS_EFECTIVOS.HeaderText = "OTROS EFECTIVOS";
            this.OTROS_EFECTIVOS.Name = "OTROS_EFECTIVOS";
            // 
            // VENTAS_NETAS
            // 
            this.VENTAS_NETAS.HeaderText = "VENTAS NETAS";
            this.VENTAS_NETAS.Name = "VENTAS_NETAS";
            // 
            // DIFERENCIA
            // 
            this.DIFERENCIA.HeaderText = "DIFERENCIA";
            this.DIFERENCIA.Name = "DIFERENCIA";
            // 
            // GB_datos
            // 
            this.GB_datos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GB_datos.Controls.Add(this.BT_CambiarConcepto);
            this.GB_datos.Controls.Add(this.label4);
            this.GB_datos.Controls.Add(this.RETIROS);
            this.GB_datos.Controls.Add(this.DG_egresos);
            this.GB_datos.Controls.Add(this.DG_retiros);
            this.GB_datos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_datos.Location = new System.Drawing.Point(11, 360);
            this.GB_datos.Name = "GB_datos";
            this.GB_datos.Size = new System.Drawing.Size(963, 387);
            this.GB_datos.TabIndex = 27;
            this.GB_datos.TabStop = false;
            this.GB_datos.Text = "ESTACION";
            this.GB_datos.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // BT_CambiarConcepto
            // 
            this.BT_CambiarConcepto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_CambiarConcepto.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_CambiarConcepto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_CambiarConcepto.ForeColor = System.Drawing.Color.White;
            this.BT_CambiarConcepto.Location = new System.Drawing.Point(718, 13);
            this.BT_CambiarConcepto.Name = "BT_CambiarConcepto";
            this.BT_CambiarConcepto.Size = new System.Drawing.Size(230, 30);
            this.BT_CambiarConcepto.TabIndex = 51;
            this.BT_CambiarConcepto.Text = "Cambiar Concepto de egreso";
            this.BT_CambiarConcepto.UseVisualStyleBackColor = false;
            this.BT_CambiarConcepto.Click += new System.EventHandler(this.BT_CambiarConcepto_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(591, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "EGRESOS";
            // 
            // RETIROS
            // 
            this.RETIROS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.RETIROS.AutoSize = true;
            this.RETIROS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RETIROS.Location = new System.Drawing.Point(181, 20);
            this.RETIROS.Name = "RETIROS";
            this.RETIROS.Size = new System.Drawing.Size(88, 20);
            this.RETIROS.TabIndex = 30;
            this.RETIROS.Text = "RETIROS";
            // 
            // DG_egresos
            // 
            this.DG_egresos.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DG_egresos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DG_egresos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DG_egresos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DG_egresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_egresos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.HORAEGRE,
            this.USER,
            this.CHECK2});
            this.DG_egresos.Location = new System.Drawing.Point(331, 49);
            this.DG_egresos.Name = "DG_egresos";
            this.DG_egresos.Size = new System.Drawing.Size(617, 308);
            this.DG_egresos.TabIndex = 29;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "CONCEPTO";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "IMPORTE";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // HORAEGRE
            // 
            this.HORAEGRE.HeaderText = "HORA";
            this.HORAEGRE.Name = "HORAEGRE";
            // 
            // USER
            // 
            this.USER.HeaderText = "USUARIO";
            this.USER.Name = "USER";
            // 
            // CHECK2
            // 
            this.CHECK2.HeaderText = "CHECK";
            this.CHECK2.Name = "CHECK2";
            this.CHECK2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CHECK2.Visible = false;
            // 
            // DG_retiros
            // 
            this.DG_retiros.AllowUserToAddRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DG_retiros.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DG_retiros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DG_retiros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DG_retiros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_retiros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NUM,
            this.IMPORTE,
            this.HORA,
            this.USUARIO_,
            this.CHECK});
            this.DG_retiros.Location = new System.Drawing.Point(6, 49);
            this.DG_retiros.Name = "DG_retiros";
            this.DG_retiros.Size = new System.Drawing.Size(445, 308);
            this.DG_retiros.TabIndex = 28;
            // 
            // NUM
            // 
            this.NUM.HeaderText = "RETIRO";
            this.NUM.Name = "NUM";
            // 
            // IMPORTE
            // 
            this.IMPORTE.HeaderText = "IMPORTE";
            this.IMPORTE.Name = "IMPORTE";
            // 
            // HORA
            // 
            this.HORA.HeaderText = "HORA";
            this.HORA.Name = "HORA";
            // 
            // USUARIO_
            // 
            this.USUARIO_.HeaderText = "USUARIO";
            this.USUARIO_.Name = "USUARIO_";
            // 
            // CHECK
            // 
            this.CHECK.HeaderText = "CHECK";
            this.CHECK.Name = "CHECK";
            this.CHECK.Visible = false;
            // 
            // LB_usuario
            // 
            this.LB_usuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LB_usuario.AutoSize = true;
            this.LB_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_usuario.Location = new System.Drawing.Point(912, 45);
            this.LB_usuario.Name = "LB_usuario";
            this.LB_usuario.Size = new System.Drawing.Size(62, 16);
            this.LB_usuario.TabIndex = 34;
            this.LB_usuario.Text = "Usuario";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(797, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 33;
            this.label1.Text = "Revisado por:";
            // 
            // CHK_respaldo
            // 
            this.CHK_respaldo.AutoSize = true;
            this.CHK_respaldo.Location = new System.Drawing.Point(684, 27);
            this.CHK_respaldo.Name = "CHK_respaldo";
            this.CHK_respaldo.Size = new System.Drawing.Size(84, 17);
            this.CHK_respaldo.TabIndex = 28;
            this.CHK_respaldo.Text = "RESPALDO";
            this.CHK_respaldo.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.DG_diferencia);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.DG_tarjeg);
            this.groupBox1.Controls.Add(this.DG_tarjin);
            this.groupBox1.Location = new System.Drawing.Point(980, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(759, 424);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COBRO CON TARJETA";
            // 
            // DG_diferencia
            // 
            this.DG_diferencia.AllowUserToAddRows = false;
            this.DG_diferencia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DG_diferencia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DG_diferencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_diferencia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DIFERENCIA_VTA_TARJ});
            this.DG_diferencia.Location = new System.Drawing.Point(630, 40);
            this.DG_diferencia.Name = "DG_diferencia";
            this.DG_diferencia.Size = new System.Drawing.Size(123, 377);
            this.DG_diferencia.TabIndex = 43;
            // 
            // DIFERENCIA_VTA_TARJ
            // 
            this.DIFERENCIA_VTA_TARJ.HeaderText = "DIFERENCIA";
            this.DIFERENCIA_VTA_TARJ.Name = "DIFERENCIA_VTA_TARJ";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(396, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 42;
            this.label3.Text = "EGRESOS";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(95, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 41;
            this.label2.Text = "INGRESOS";
            // 
            // DG_tarjeg
            // 
            this.DG_tarjeg.AllowUserToAddRows = false;
            this.DG_tarjeg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DG_tarjeg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DG_tarjeg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_tarjeg.Location = new System.Drawing.Point(318, 41);
            this.DG_tarjeg.Name = "DG_tarjeg";
            this.DG_tarjeg.Size = new System.Drawing.Size(308, 377);
            this.DG_tarjeg.TabIndex = 40;
            // 
            // DG_tarjin
            // 
            this.DG_tarjin.AllowUserToAddRows = false;
            this.DG_tarjin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DG_tarjin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DG_tarjin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_tarjin.Location = new System.Drawing.Point(5, 41);
            this.DG_tarjin.Name = "DG_tarjin";
            this.DG_tarjin.Size = new System.Drawing.Size(308, 377);
            this.DG_tarjin.TabIndex = 39;
            // 
            // CHK_egTarj
            // 
            this.CHK_egTarj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CHK_egTarj.AutoSize = true;
            this.CHK_egTarj.Location = new System.Drawing.Point(245, 783);
            this.CHK_egTarj.Name = "CHK_egTarj";
            this.CHK_egTarj.Size = new System.Drawing.Size(99, 17);
            this.CHK_egTarj.TabIndex = 47;
            this.CHK_egTarj.Text = "EG TARJETAS";
            this.CHK_egTarj.UseVisualStyleBackColor = true;
            // 
            // CHK_inTarj
            // 
            this.CHK_inTarj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CHK_inTarj.AutoSize = true;
            this.CHK_inTarj.Location = new System.Drawing.Point(245, 758);
            this.CHK_inTarj.Name = "CHK_inTarj";
            this.CHK_inTarj.Size = new System.Drawing.Size(103, 17);
            this.CHK_inTarj.TabIndex = 46;
            this.CHK_inTarj.Text = "ING TARJETAS";
            this.CHK_inTarj.UseVisualStyleBackColor = true;
            // 
            // CHK_egresos
            // 
            this.CHK_egresos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CHK_egresos.AutoSize = true;
            this.CHK_egresos.Location = new System.Drawing.Point(138, 810);
            this.CHK_egresos.Name = "CHK_egresos";
            this.CHK_egresos.Size = new System.Drawing.Size(78, 17);
            this.CHK_egresos.TabIndex = 45;
            this.CHK_egresos.Text = "EGRESOS";
            this.CHK_egresos.UseVisualStyleBackColor = true;
            // 
            // CHK_retiros
            // 
            this.CHK_retiros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CHK_retiros.AutoSize = true;
            this.CHK_retiros.Location = new System.Drawing.Point(138, 783);
            this.CHK_retiros.Name = "CHK_retiros";
            this.CHK_retiros.Size = new System.Drawing.Size(74, 17);
            this.CHK_retiros.TabIndex = 44;
            this.CHK_retiros.Text = "RETIROS";
            this.CHK_retiros.UseVisualStyleBackColor = true;
            // 
            // CHK_ventas
            // 
            this.CHK_ventas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CHK_ventas.AutoSize = true;
            this.CHK_ventas.Location = new System.Drawing.Point(138, 758);
            this.CHK_ventas.Name = "CHK_ventas";
            this.CHK_ventas.Size = new System.Drawing.Size(69, 17);
            this.CHK_ventas.TabIndex = 43;
            this.CHK_ventas.Text = "VENTAS";
            this.CHK_ventas.UseVisualStyleBackColor = true;
            // 
            // BT_excel
            // 
            this.BT_excel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BT_excel.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_excel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_excel.ForeColor = System.Drawing.Color.White;
            this.BT_excel.Location = new System.Drawing.Point(11, 755);
            this.BT_excel.Name = "BT_excel";
            this.BT_excel.Size = new System.Drawing.Size(121, 70);
            this.BT_excel.TabIndex = 42;
            this.BT_excel.Text = "Exportar";
            this.BT_excel.UseVisualStyleBackColor = false;
            // 
            // BT_Aceptar
            // 
            this.BT_Aceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_Aceptar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_Aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Aceptar.ForeColor = System.Drawing.Color.White;
            this.BT_Aceptar.Location = new System.Drawing.Point(1610, 758);
            this.BT_Aceptar.Name = "BT_Aceptar";
            this.BT_Aceptar.Size = new System.Drawing.Size(121, 71);
            this.BT_Aceptar.TabIndex = 41;
            this.BT_Aceptar.Text = "Aceptar";
            this.BT_Aceptar.UseVisualStyleBackColor = false;
            this.BT_Aceptar.Click += new System.EventHandler(this.BT_Aceptar_Click_1);
            // 
            // DG_ventasCaja
            // 
            this.DG_ventasCaja.AllowUserToAddRows = false;
            this.DG_ventasCaja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DG_ventasCaja.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DG_ventasCaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_ventasCaja.Location = new System.Drawing.Point(6, 19);
            this.DG_ventasCaja.Name = "DG_ventasCaja";
            this.DG_ventasCaja.Size = new System.Drawing.Size(743, 197);
            this.DG_ventasCaja.TabIndex = 44;
            this.DG_ventasCaja.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_ventasCaja_CellContentClick);
            this.DG_ventasCaja.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_ventasCaja_CellContentDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.DG_ventasCaja);
            this.groupBox2.Location = new System.Drawing.Point(981, 525);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(758, 222);
            this.groupBox2.TabIndex = 49;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ventas de la caja";
            // 
            // TB_buscarTicket
            // 
            this.TB_buscarTicket.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_buscarTicket.Location = new System.Drawing.Point(1031, 497);
            this.TB_buscarTicket.Name = "TB_buscarTicket";
            this.TB_buscarTicket.Size = new System.Drawing.Size(132, 20);
            this.TB_buscarTicket.TabIndex = 50;
            this.TB_buscarTicket.TextChanged += new System.EventHandler(this.TB_buscarTicket_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(984, 498);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 44;
            this.label5.Text = "ticket";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // VentasEnCajas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1742, 837);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TB_buscarTicket);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.CHK_egTarj);
            this.Controls.Add(this.CHK_inTarj);
            this.Controls.Add(this.CHK_egresos);
            this.Controls.Add(this.CHK_retiros);
            this.Controls.Add(this.CHK_ventas);
            this.Controls.Add(this.BT_excel);
            this.Controls.Add(this.BT_Aceptar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CHK_respaldo);
            this.Controls.Add(this.GB_datos);
            this.Controls.Add(this.DG_tabla);
            this.Controls.Add(this.LB_usuario);
            this.Controls.Add(this.DT_fecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CB_sucursal);
            this.Controls.Add(this.lb);
            this.Name = "VentasEnCajas";
            this.Text = "VentasEnCajas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.VentasEnCajas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_tabla)).EndInit();
            this.GB_datos.ResumeLayout(false);
            this.GB_datos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_egresos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_retiros)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_diferencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_tarjeg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_tarjin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_ventasCaja)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.ComboBox CB_sucursal;
        private System.Windows.Forms.DateTimePicker DT_fecha;
        private System.Windows.Forms.DataGridView DG_tabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL_VENTAS;
        private System.Windows.Forms.DataGridViewTextBoxColumn EGRESO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL_EFECTIVO;
        private System.Windows.Forms.DataGridViewTextBoxColumn VOUCHER;
        private System.Windows.Forms.DataGridViewTextBoxColumn RETIRO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOBRANTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DEVOLUCIONES;
        private System.Windows.Forms.DataGridViewTextBoxColumn OTROS_EFECTIVOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn VENTAS_NETAS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIFERENCIA;
        private System.Windows.Forms.GroupBox GB_datos;
        private System.Windows.Forms.DataGridView DG_egresos;
        private System.Windows.Forms.DataGridView DG_retiros;
        private System.Windows.Forms.CheckBox CHK_respaldo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label RETIROS;
        private System.Windows.Forms.Label LB_usuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORAEGRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn USER;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CHECK2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUM;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMPORTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORA;
        private System.Windows.Forms.DataGridViewTextBoxColumn USUARIO_;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CHECK;
        private System.Windows.Forms.DataGridView DG_diferencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIFERENCIA_VTA_TARJ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DG_tarjeg;
        private System.Windows.Forms.DataGridView DG_tarjin;
        private System.Windows.Forms.CheckBox CHK_egTarj;
        private System.Windows.Forms.CheckBox CHK_inTarj;
        private System.Windows.Forms.CheckBox CHK_egresos;
        private System.Windows.Forms.CheckBox CHK_retiros;
        private System.Windows.Forms.CheckBox CHK_ventas;
        private System.Windows.Forms.Button BT_excel;
        private System.Windows.Forms.Button BT_Aceptar;
        private System.Windows.Forms.DataGridView DG_ventasCaja;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TB_buscarTicket;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BT_CambiarConcepto;
    }
}