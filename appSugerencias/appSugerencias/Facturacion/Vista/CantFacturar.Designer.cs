
namespace appSugerencias
{
    partial class CantFacturar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DG_tabla = new System.Windows.Forms.DataGridView();
            this.FECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL_VENTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DEPOSITO_VENTANILLA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DEPOSITO_CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DEPOSITO_PANA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DEPOSITADO = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.FACT_EFE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FACT_TAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL_FACTURADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VENTAS_EFECTIVO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BAUCHER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FACTURA_GLOBAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIFERENCIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EFECTIVO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TARJETA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FACTURA_ELABORADA = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.RB_co = new System.Windows.Forms.RadioButton();
            this.RB_ve = new System.Windows.Forms.RadioButton();
            this.RB_re = new System.Windows.Forms.RadioButton();
            this.RB_va = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.CBX_mes_anterior = new System.Windows.Forms.CheckBox();
            this.BT_guardar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LB_patron = new System.Windows.Forms.Label();
            this.CB_año = new System.Windows.Forms.ComboBox();
            this.CB_mes = new System.Windows.Forms.ComboBox();
            this.BT_buscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DG_tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // DG_tabla
            // 
            this.DG_tabla.AllowUserToAddRows = false;
            this.DG_tabla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DG_tabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_tabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DG_tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FECHA,
            this.TOTAL_VENTA,
            this.DEPOSITO_VENTANILLA,
            this.DEPOSITO_CLIENTE,
            this.DEPOSITO_PANA,
            this.DEPOSITADO,
            this.FACT_EFE,
            this.FACT_TAR,
            this.TOTAL_FACTURADO,
            this.VENTAS_EFECTIVO,
            this.BAUCHER,
            this.FACTURA_GLOBAL,
            this.DIFERENCIA,
            this.EFECTIVO,
            this.TARJETA,
            this.FACTURA_ELABORADA});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DG_tabla.DefaultCellStyle = dataGridViewCellStyle14;
            this.DG_tabla.Location = new System.Drawing.Point(1, 128);
            this.DG_tabla.Name = "DG_tabla";
            this.DG_tabla.Size = new System.Drawing.Size(1542, 374);
            this.DG_tabla.TabIndex = 0;
            this.DG_tabla.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_tabla_CellValueChanged);
            // 
            // FECHA
            // 
            this.FECHA.HeaderText = "FECHA";
            this.FECHA.Name = "FECHA";
            // 
            // TOTAL_VENTA
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.TOTAL_VENTA.DefaultCellStyle = dataGridViewCellStyle2;
            this.TOTAL_VENTA.HeaderText = "TOTAL VENTA";
            this.TOTAL_VENTA.Name = "TOTAL_VENTA";
            // 
            // DEPOSITO_VENTANILLA
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.DEPOSITO_VENTANILLA.DefaultCellStyle = dataGridViewCellStyle3;
            this.DEPOSITO_VENTANILLA.HeaderText = "DEP. VENTANILLA";
            this.DEPOSITO_VENTANILLA.Name = "DEPOSITO_VENTANILLA";
            // 
            // DEPOSITO_CLIENTE
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.DEPOSITO_CLIENTE.DefaultCellStyle = dataGridViewCellStyle4;
            this.DEPOSITO_CLIENTE.HeaderText = "DEP. CLIENTE";
            this.DEPOSITO_CLIENTE.Name = "DEPOSITO_CLIENTE";
            // 
            // DEPOSITO_PANA
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.DEPOSITO_PANA.DefaultCellStyle = dataGridViewCellStyle5;
            this.DEPOSITO_PANA.HeaderText = "DEP. PANA";
            this.DEPOSITO_PANA.Name = "DEPOSITO_PANA";
            // 
            // DEPOSITADO
            // 
            this.DEPOSITADO.HeaderText = "DEPOSITADO";
            this.DEPOSITADO.Name = "DEPOSITADO";
            // 
            // FACT_EFE
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.FACT_EFE.DefaultCellStyle = dataGridViewCellStyle6;
            this.FACT_EFE.HeaderText = "FACT. EFE";
            this.FACT_EFE.Name = "FACT_EFE";
            this.FACT_EFE.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.FACT_EFE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FACT_TAR
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.FACT_TAR.DefaultCellStyle = dataGridViewCellStyle7;
            this.FACT_TAR.HeaderText = "FACT. TAR";
            this.FACT_TAR.Name = "FACT_TAR";
            this.FACT_TAR.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.FACT_TAR.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TOTAL_FACTURADO
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.TOTAL_FACTURADO.DefaultCellStyle = dataGridViewCellStyle8;
            this.TOTAL_FACTURADO.HeaderText = "TOTAL FACTURA DE CLIENTE";
            this.TOTAL_FACTURADO.Name = "TOTAL_FACTURADO";
            // 
            // VENTAS_EFECTIVO
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.VENTAS_EFECTIVO.DefaultCellStyle = dataGridViewCellStyle9;
            this.VENTAS_EFECTIVO.HeaderText = "VENTAS EFECTIVO";
            this.VENTAS_EFECTIVO.Name = "VENTAS_EFECTIVO";
            // 
            // BAUCHER
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.BAUCHER.DefaultCellStyle = dataGridViewCellStyle10;
            this.BAUCHER.HeaderText = "BAUCHER";
            this.BAUCHER.Name = "BAUCHER";
            // 
            // FACTURA_GLOBAL
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.FACTURA_GLOBAL.DefaultCellStyle = dataGridViewCellStyle11;
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
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.EFECTIVO.DefaultCellStyle = dataGridViewCellStyle12;
            this.EFECTIVO.HeaderText = "EFECTIVO";
            this.EFECTIVO.Name = "EFECTIVO";
            // 
            // TARJETA
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.TARJETA.DefaultCellStyle = dataGridViewCellStyle13;
            this.TARJETA.HeaderText = "TARJETA";
            this.TARJETA.Name = "TARJETA";
            // 
            // FACTURA_ELABORADA
            // 
            this.FACTURA_ELABORADA.HeaderText = "FACTURA ELABORADA";
            this.FACTURA_ELABORADA.Name = "FACTURA_ELABORADA";
            // 
            // RB_co
            // 
            this.RB_co.AutoSize = true;
            this.RB_co.Location = new System.Drawing.Point(7, 92);
            this.RB_co.Name = "RB_co";
            this.RB_co.Size = new System.Drawing.Size(69, 17);
            this.RB_co.TabIndex = 33;
            this.RB_co.TabStop = true;
            this.RB_co.Text = "COLOSO";
            this.RB_co.UseVisualStyleBackColor = true;
            this.RB_co.CheckedChanged += new System.EventHandler(this.RB_co_CheckedChanged);
            // 
            // RB_ve
            // 
            this.RB_ve.AutoSize = true;
            this.RB_ve.Location = new System.Drawing.Point(7, 70);
            this.RB_ve.Name = "RB_ve";
            this.RB_ve.Size = new System.Drawing.Size(89, 17);
            this.RB_ve.TabIndex = 32;
            this.RB_ve.TabStop = true;
            this.RB_ve.Text = "VELAZQUEZ";
            this.RB_ve.UseVisualStyleBackColor = true;
            this.RB_ve.CheckedChanged += new System.EventHandler(this.RB_ve_CheckedChanged);
            // 
            // RB_re
            // 
            this.RB_re.AutoSize = true;
            this.RB_re.Location = new System.Drawing.Point(7, 49);
            this.RB_re.Name = "RB_re";
            this.RB_re.Size = new System.Drawing.Size(55, 17);
            this.RB_re.TabIndex = 31;
            this.RB_re.TabStop = true;
            this.RB_re.Text = "RENA";
            this.RB_re.UseVisualStyleBackColor = true;
            this.RB_re.CheckedChanged += new System.EventHandler(this.RB_re_CheckedChanged);
            // 
            // RB_va
            // 
            this.RB_va.AutoSize = true;
            this.RB_va.Location = new System.Drawing.Point(7, 26);
            this.RB_va.Name = "RB_va";
            this.RB_va.Size = new System.Drawing.Size(80, 17);
            this.RB_va.TabIndex = 30;
            this.RB_va.TabStop = true;
            this.RB_va.Text = "VALLARTA";
            this.RB_va.UseVisualStyleBackColor = true;
            this.RB_va.CheckedChanged += new System.EventHandler(this.RB_va_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1435, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 58);
            this.button1.TabIndex = 29;
            this.button1.Text = "Exportar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // CBX_mes_anterior
            // 
            this.CBX_mes_anterior.AutoSize = true;
            this.CBX_mes_anterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBX_mes_anterior.Location = new System.Drawing.Point(231, 43);
            this.CBX_mes_anterior.Name = "CBX_mes_anterior";
            this.CBX_mes_anterior.Size = new System.Drawing.Size(148, 35);
            this.CBX_mes_anterior.TabIndex = 28;
            this.CBX_mes_anterior.Text = "Respaldo";
            this.CBX_mes_anterior.UseVisualStyleBackColor = true;
            // 
            // BT_guardar
            // 
            this.BT_guardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_guardar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_guardar.ForeColor = System.Drawing.Color.White;
            this.BT_guardar.Location = new System.Drawing.Point(1313, 28);
            this.BT_guardar.Name = "BT_guardar";
            this.BT_guardar.Size = new System.Drawing.Size(99, 58);
            this.BT_guardar.TabIndex = 27;
            this.BT_guardar.Text = "Guardar";
            this.BT_guardar.UseVisualStyleBackColor = false;
            this.BT_guardar.Click += new System.EventHandler(this.BT_guardar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(629, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 31);
            this.label3.TabIndex = 26;
            this.label3.Text = "AÑO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(449, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 31);
            this.label2.TabIndex = 25;
            this.label2.Text = "MES";
            // 
            // LB_patron
            // 
            this.LB_patron.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LB_patron.AutoSize = true;
            this.LB_patron.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_patron.Location = new System.Drawing.Point(860, 41);
            this.LB_patron.Name = "LB_patron";
            this.LB_patron.Size = new System.Drawing.Size(0, 31);
            this.LB_patron.TabIndex = 24;
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
            this.CB_año.Location = new System.Drawing.Point(594, 43);
            this.CB_año.Name = "CB_año";
            this.CB_año.Size = new System.Drawing.Size(149, 39);
            this.CB_año.TabIndex = 23;
            this.CB_año.SelectedIndexChanged += new System.EventHandler(this.CB_año_SelectedIndexChanged);
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
            this.CB_mes.Location = new System.Drawing.Point(385, 43);
            this.CB_mes.Name = "CB_mes";
            this.CB_mes.Size = new System.Drawing.Size(203, 39);
            this.CB_mes.TabIndex = 22;
            this.CB_mes.SelectedIndexChanged += new System.EventHandler(this.CB_mes_SelectedIndexChanged);
            // 
            // BT_buscar
            // 
            this.BT_buscar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_buscar.ForeColor = System.Drawing.Color.White;
            this.BT_buscar.Location = new System.Drawing.Point(749, 28);
            this.BT_buscar.Name = "BT_buscar";
            this.BT_buscar.Size = new System.Drawing.Size(99, 58);
            this.BT_buscar.TabIndex = 21;
            this.BT_buscar.Text = "BUSCAR";
            this.BT_buscar.UseVisualStyleBackColor = false;
            this.BT_buscar.Click += new System.EventHandler(this.BT_buscar_Click);
            // 
            // CantFacturar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1546, 504);
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
            this.Name = "CantFacturar";
            this.Text = "CantFacturar";
            this.Load += new System.EventHandler(this.CantFacturar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_tabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DG_tabla;
        private System.Windows.Forms.RadioButton RB_co;
        private System.Windows.Forms.RadioButton RB_ve;
        private System.Windows.Forms.RadioButton RB_re;
        private System.Windows.Forms.RadioButton RB_va;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox CBX_mes_anterior;
        private System.Windows.Forms.Button BT_guardar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LB_patron;
        private System.Windows.Forms.ComboBox CB_año;
        private System.Windows.Forms.ComboBox CB_mes;
        private System.Windows.Forms.Button BT_buscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL_VENTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DEPOSITO_VENTANILLA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DEPOSITO_CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DEPOSITO_PANA;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DEPOSITADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FACT_EFE;
        private System.Windows.Forms.DataGridViewTextBoxColumn FACT_TAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL_FACTURADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn VENTAS_EFECTIVO;
        private System.Windows.Forms.DataGridViewTextBoxColumn BAUCHER;
        private System.Windows.Forms.DataGridViewTextBoxColumn FACTURA_GLOBAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIFERENCIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn EFECTIVO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TARJETA;
        private System.Windows.Forms.DataGridViewCheckBoxColumn FACTURA_ELABORADA;
    }
}