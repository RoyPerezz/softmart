namespace appSugerencias
{
    partial class CantidadFacturar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DG_tabla = new System.Windows.Forms.DataGridView();
            this.FECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL_VENTAS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DEPOSITO_VENTANILLA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DEPOSITOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DEPOSITO_PANA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DEPOSITADO_ = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.FAC_EFE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FAC_TAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.T_FAC_CLIENTES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VENTAS_EFE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BAUCHER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FACTURA_GLOBAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIFERENCIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EFECTIVO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TARJETA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FACTURA_ELABORADA = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.BT_buscar = new System.Windows.Forms.Button();
            this.CB_mes = new System.Windows.Forms.ComboBox();
            this.CB_año = new System.Windows.Forms.ComboBox();
            this.LB_patron = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BT_guardar = new System.Windows.Forms.Button();
            this.CBX_mes_anterior = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.RB_va = new System.Windows.Forms.RadioButton();
            this.RB_re = new System.Windows.Forms.RadioButton();
            this.RB_ve = new System.Windows.Forms.RadioButton();
            this.RB_co = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.DG_tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // DG_tabla
            // 
            this.DG_tabla.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DG_tabla.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DG_tabla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DG_tabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DG_tabla.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_tabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DG_tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FECHA,
            this.TOTAL_VENTAS,
            this.DEPOSITO_VENTANILLA,
            this.DEPOSITOS,
            this.DEPOSITO_PANA,
            this.DEPOSITADO_,
            this.FAC_EFE,
            this.FAC_TAR,
            this.T_FAC_CLIENTES,
            this.VENTAS_EFE,
            this.BAUCHER,
            this.FACTURA_GLOBAL,
            this.DIFERENCIA,
            this.EFECTIVO,
            this.TARJETA,
            this.FACTURA_ELABORADA});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DG_tabla.DefaultCellStyle = dataGridViewCellStyle13;
            this.DG_tabla.Location = new System.Drawing.Point(-1, 154);
            this.DG_tabla.Name = "DG_tabla";
            this.DG_tabla.RowHeadersVisible = false;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DG_tabla.RowsDefaultCellStyle = dataGridViewCellStyle14;
            this.DG_tabla.Size = new System.Drawing.Size(1637, 294);
            this.DG_tabla.TabIndex = 0;
            this.DG_tabla.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_tabla_CellValueChanged);
            // 
            // FECHA
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FECHA.DefaultCellStyle = dataGridViewCellStyle3;
            this.FECHA.HeaderText = "FECHA";
            this.FECHA.Name = "FECHA";
            // 
            // TOTAL_VENTAS
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TOTAL_VENTAS.DefaultCellStyle = dataGridViewCellStyle4;
            this.TOTAL_VENTAS.HeaderText = "TOTAL DE VENTAS";
            this.TOTAL_VENTAS.Name = "TOTAL_VENTAS";
            // 
            // DEPOSITO_VENTANILLA
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DEPOSITO_VENTANILLA.DefaultCellStyle = dataGridViewCellStyle5;
            this.DEPOSITO_VENTANILLA.HeaderText = "DEPOSITO EN VENTANILLA";
            this.DEPOSITO_VENTANILLA.Name = "DEPOSITO_VENTANILLA";
            // 
            // DEPOSITOS
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DEPOSITOS.DefaultCellStyle = dataGridViewCellStyle6;
            this.DEPOSITOS.HeaderText = "DEPOSITO DE CLIENTE";
            this.DEPOSITOS.Name = "DEPOSITOS";
            // 
            // DEPOSITO_PANA
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DEPOSITO_PANA.DefaultCellStyle = dataGridViewCellStyle7;
            this.DEPOSITO_PANA.HeaderText = "DEPOSITO PANA";
            this.DEPOSITO_PANA.Name = "DEPOSITO_PANA";
            // 
            // DEPOSITADO_
            // 
            this.DEPOSITADO_.HeaderText = "DEPOSITADO";
            this.DEPOSITADO_.Name = "DEPOSITADO_";
            // 
            // FAC_EFE
            // 
            this.FAC_EFE.HeaderText = "FACT. EFE";
            this.FAC_EFE.Name = "FAC_EFE";
            // 
            // FAC_TAR
            // 
            this.FAC_TAR.HeaderText = "FACT. TAR";
            this.FAC_TAR.Name = "FAC_TAR";
            // 
            // T_FAC_CLIENTES
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_FAC_CLIENTES.DefaultCellStyle = dataGridViewCellStyle8;
            this.T_FAC_CLIENTES.HeaderText = "TOTAL FACTURAS DE CLIENTES";
            this.T_FAC_CLIENTES.Name = "T_FAC_CLIENTES";
            // 
            // VENTAS_EFE
            // 
            this.VENTAS_EFE.HeaderText = "VENTAS EFECTIVO";
            this.VENTAS_EFE.Name = "VENTAS_EFE";
            // 
            // BAUCHER
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAUCHER.DefaultCellStyle = dataGridViewCellStyle9;
            this.BAUCHER.HeaderText = "BAUCHER";
            this.BAUCHER.Name = "BAUCHER";
            // 
            // FACTURA_GLOBAL
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FACTURA_GLOBAL.DefaultCellStyle = dataGridViewCellStyle10;
            this.FACTURA_GLOBAL.HeaderText = "FACTURA GLOBAL";
            this.FACTURA_GLOBAL.Name = "FACTURA_GLOBAL";
            // 
            // DIFERENCIA
            // 
            this.DIFERENCIA.HeaderText = "DIFERENCIA";
            this.DIFERENCIA.Name = "DIFERENCIA";
            this.DIFERENCIA.Visible = false;
            // 
            // EFECTIVO
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EFECTIVO.DefaultCellStyle = dataGridViewCellStyle11;
            this.EFECTIVO.HeaderText = "EFECTIVO";
            this.EFECTIVO.Name = "EFECTIVO";
            // 
            // TARJETA
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TARJETA.DefaultCellStyle = dataGridViewCellStyle12;
            this.TARJETA.HeaderText = "TARJETA";
            this.TARJETA.Name = "TARJETA";
            // 
            // FACTURA_ELABORADA
            // 
            this.FACTURA_ELABORADA.HeaderText = "FACTURA ELABORADA";
            this.FACTURA_ELABORADA.Name = "FACTURA_ELABORADA";
            this.FACTURA_ELABORADA.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.FACTURA_ELABORADA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // BT_buscar
            // 
            this.BT_buscar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_buscar.ForeColor = System.Drawing.Color.White;
            this.BT_buscar.Location = new System.Drawing.Point(754, 28);
            this.BT_buscar.Name = "BT_buscar";
            this.BT_buscar.Size = new System.Drawing.Size(99, 58);
            this.BT_buscar.TabIndex = 1;
            this.BT_buscar.Text = "BUSCAR";
            this.BT_buscar.UseVisualStyleBackColor = false;
            this.BT_buscar.Click += new System.EventHandler(this.BT_buscar_Click);
            // 
            // CB_mes
            // 
            this.CB_mes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_mes.FormattingEnabled = true;
            this.CB_mes.Items.AddRange(new object[] {
            "ENERO",
            "FEBRERO",
            "MARZO",
            "ABRIL",
            "MAYO",
            "JUNIO",
            "JULIO",
            "AGOSTO",
            "SEPTIEMBRE",
            "OCTUBRE",
            "NOVIEMBRE",
            "DICIEMBRE"});
            this.CB_mes.Location = new System.Drawing.Point(390, 43);
            this.CB_mes.Name = "CB_mes";
            this.CB_mes.Size = new System.Drawing.Size(203, 39);
            this.CB_mes.TabIndex = 6;
            // 
            // CB_año
            // 
            this.CB_año.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_año.FormattingEnabled = true;
            this.CB_año.Items.AddRange(new object[] {
            "2022",
            "2023",
            "2024",
            "2025"});
            this.CB_año.Location = new System.Drawing.Point(599, 43);
            this.CB_año.Name = "CB_año";
            this.CB_año.Size = new System.Drawing.Size(149, 39);
            this.CB_año.TabIndex = 7;
            // 
            // LB_patron
            // 
            this.LB_patron.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LB_patron.AutoSize = true;
            this.LB_patron.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_patron.Location = new System.Drawing.Point(874, 47);
            this.LB_patron.Name = "LB_patron";
            this.LB_patron.Size = new System.Drawing.Size(0, 31);
            this.LB_patron.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(454, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 31);
            this.label2.TabIndex = 10;
            this.label2.Text = "MES";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(634, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 31);
            this.label3.TabIndex = 11;
            this.label3.Text = "AÑO";
            // 
            // BT_guardar
            // 
            this.BT_guardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_guardar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_guardar.ForeColor = System.Drawing.Color.White;
            this.BT_guardar.Location = new System.Drawing.Point(1403, 23);
            this.BT_guardar.Name = "BT_guardar";
            this.BT_guardar.Size = new System.Drawing.Size(99, 58);
            this.BT_guardar.TabIndex = 12;
            this.BT_guardar.Text = "Guardar";
            this.BT_guardar.UseVisualStyleBackColor = false;
            this.BT_guardar.Click += new System.EventHandler(this.BT_guardar_Click);
            // 
            // CBX_mes_anterior
            // 
            this.CBX_mes_anterior.AutoSize = true;
            this.CBX_mes_anterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBX_mes_anterior.Location = new System.Drawing.Point(236, 43);
            this.CBX_mes_anterior.Name = "CBX_mes_anterior";
            this.CBX_mes_anterior.Size = new System.Drawing.Size(148, 35);
            this.CBX_mes_anterior.TabIndex = 13;
            this.CBX_mes_anterior.Text = "Respaldo";
            this.CBX_mes_anterior.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1525, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 58);
            this.button1.TabIndex = 16;
            this.button1.Text = "Exportar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RB_va
            // 
            this.RB_va.AutoSize = true;
            this.RB_va.Location = new System.Drawing.Point(12, 26);
            this.RB_va.Name = "RB_va";
            this.RB_va.Size = new System.Drawing.Size(80, 17);
            this.RB_va.TabIndex = 17;
            this.RB_va.TabStop = true;
            this.RB_va.Text = "VALLARTA";
            this.RB_va.UseVisualStyleBackColor = true;
            // 
            // RB_re
            // 
            this.RB_re.AutoSize = true;
            this.RB_re.Location = new System.Drawing.Point(12, 49);
            this.RB_re.Name = "RB_re";
            this.RB_re.Size = new System.Drawing.Size(55, 17);
            this.RB_re.TabIndex = 18;
            this.RB_re.TabStop = true;
            this.RB_re.Text = "RENA";
            this.RB_re.UseVisualStyleBackColor = true;
            // 
            // RB_ve
            // 
            this.RB_ve.AutoSize = true;
            this.RB_ve.Location = new System.Drawing.Point(12, 70);
            this.RB_ve.Name = "RB_ve";
            this.RB_ve.Size = new System.Drawing.Size(89, 17);
            this.RB_ve.TabIndex = 19;
            this.RB_ve.TabStop = true;
            this.RB_ve.Text = "VELAZQUEZ";
            this.RB_ve.UseVisualStyleBackColor = true;
            // 
            // RB_co
            // 
            this.RB_co.AutoSize = true;
            this.RB_co.Location = new System.Drawing.Point(12, 92);
            this.RB_co.Name = "RB_co";
            this.RB_co.Size = new System.Drawing.Size(69, 17);
            this.RB_co.TabIndex = 20;
            this.RB_co.TabStop = true;
            this.RB_co.Text = "COLOSO";
            this.RB_co.UseVisualStyleBackColor = true;
            // 
            // CantidadFacturar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1636, 450);
            this.Controls.Add(this.RB_co);
            this.Controls.Add(this.RB_ve);
            this.Controls.Add(this.RB_re);
            this.Controls.Add(this.RB_va);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CBX_mes_anterior);
            this.Controls.Add(this.BT_guardar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LB_patron);
            this.Controls.Add(this.CB_año);
            this.Controls.Add(this.CB_mes);
            this.Controls.Add(this.BT_buscar);
            this.Controls.Add(this.DG_tabla);
            this.Name = "CantidadFacturar";
            this.Text = "Cantidad para facturación";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CantidadFacturar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_tabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DG_tabla;
        private System.Windows.Forms.Button BT_buscar;
        private System.Windows.Forms.ComboBox CB_mes;
        private System.Windows.Forms.ComboBox CB_año;
        private System.Windows.Forms.Label LB_patron;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BT_guardar;
        private System.Windows.Forms.CheckBox CBX_mes_anterior;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL_VENTAS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DEPOSITO_VENTANILLA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DEPOSITOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DEPOSITO_PANA;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DEPOSITADO_;
        private System.Windows.Forms.DataGridViewTextBoxColumn FAC_EFE;
        private System.Windows.Forms.DataGridViewTextBoxColumn FAC_TAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn T_FAC_CLIENTES;
        private System.Windows.Forms.DataGridViewTextBoxColumn VENTAS_EFE;
        private System.Windows.Forms.DataGridViewTextBoxColumn BAUCHER;
        private System.Windows.Forms.DataGridViewTextBoxColumn FACTURA_GLOBAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIFERENCIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn EFECTIVO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TARJETA;
        private System.Windows.Forms.DataGridViewCheckBoxColumn FACTURA_ELABORADA;
        private System.Windows.Forms.RadioButton RB_va;
        private System.Windows.Forms.RadioButton RB_re;
        private System.Windows.Forms.RadioButton RB_ve;
        private System.Windows.Forms.RadioButton RB_co;
    }
}