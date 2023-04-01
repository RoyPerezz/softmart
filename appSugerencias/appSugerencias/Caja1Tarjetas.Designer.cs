namespace appSugerencias
{
    partial class Caja1Tarjetas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.DG_tabla = new System.Windows.Forms.DataGridView();
            this.CB_mes = new System.Windows.Forms.ComboBox();
            this.BT_buscar = new System.Windows.Forms.Button();
            this.CB_sucursal = new System.Windows.Forms.ComboBox();
            this.BT_exportar = new System.Windows.Forms.Button();
            this.CB_año = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LB_mes = new System.Windows.Forms.Label();
            this.LB_año = new System.Windows.Forms.Label();
            this.LB_items = new System.Windows.Forms.Label();
            this.CBX_respaldo = new System.Windows.Forms.CheckBox();
            this.PB_barra = new System.Windows.Forms.ProgressBar();
            this.RB_mes = new System.Windows.Forms.RadioButton();
            this.RB_dia = new System.Windows.Forms.RadioButton();
            this.DT_fecha = new System.Windows.Forms.DateTimePicker();
            this.LB_fecha = new System.Windows.Forms.Label();
            this.LB_total = new System.Windows.Forms.Label();
            this.TICKET = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMPORTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HORA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CONCEPTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DG_tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(2171, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // DG_tabla
            // 
            this.DG_tabla.AllowUserToAddRows = false;
            this.DG_tabla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DG_tabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DG_tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TICKET,
            this.IMPORTE,
            this.FECHA,
            this.HORA,
            this.ESTACION,
            this.CONCEPTO,
            this.NOTA});
            this.DG_tabla.Location = new System.Drawing.Point(1, 145);
            this.DG_tabla.Name = "DG_tabla";
            this.DG_tabla.Size = new System.Drawing.Size(933, 366);
            this.DG_tabla.TabIndex = 1;
            // 
            // CB_mes
            // 
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
            this.CB_mes.Location = new System.Drawing.Point(349, 20);
            this.CB_mes.Name = "CB_mes";
            this.CB_mes.Size = new System.Drawing.Size(121, 21);
            this.CB_mes.TabIndex = 2;
            // 
            // BT_buscar
            // 
            this.BT_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_buscar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_buscar.ForeColor = System.Drawing.Color.White;
            this.BT_buscar.Location = new System.Drawing.Point(800, 7);
            this.BT_buscar.Name = "BT_buscar";
            this.BT_buscar.Size = new System.Drawing.Size(121, 33);
            this.BT_buscar.TabIndex = 3;
            this.BT_buscar.Text = "Buscar";
            this.BT_buscar.UseVisualStyleBackColor = false;
            this.BT_buscar.Click += new System.EventHandler(this.BT_buscar_Click);
            // 
            // CB_sucursal
            // 
            this.CB_sucursal.FormattingEnabled = true;
            this.CB_sucursal.Items.AddRange(new object[] {
            "VALLARTA",
            "RENA",
            "VELAZQUEZ",
            "COLOSO"});
            this.CB_sucursal.Location = new System.Drawing.Point(62, 37);
            this.CB_sucursal.Name = "CB_sucursal";
            this.CB_sucursal.Size = new System.Drawing.Size(121, 21);
            this.CB_sucursal.TabIndex = 4;
            // 
            // BT_exportar
            // 
            this.BT_exportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_exportar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_exportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_exportar.ForeColor = System.Drawing.Color.White;
            this.BT_exportar.Location = new System.Drawing.Point(800, 47);
            this.BT_exportar.Name = "BT_exportar";
            this.BT_exportar.Size = new System.Drawing.Size(121, 33);
            this.BT_exportar.TabIndex = 6;
            this.BT_exportar.Text = "Exportar";
            this.BT_exportar.UseVisualStyleBackColor = false;
            this.BT_exportar.Click += new System.EventHandler(this.BT_exportar_Click);
            // 
            // CB_año
            // 
            this.CB_año.FormattingEnabled = true;
            this.CB_año.Items.AddRange(new object[] {
            "2022",
            "2023",
            "2024",
            "2025"});
            this.CB_año.Location = new System.Drawing.Point(349, 47);
            this.CB_año.Name = "CB_año";
            this.CB_año.Size = new System.Drawing.Size(121, 21);
            this.CB_año.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Sucursal";
            // 
            // LB_mes
            // 
            this.LB_mes.AutoSize = true;
            this.LB_mes.Location = new System.Drawing.Point(316, 23);
            this.LB_mes.Name = "LB_mes";
            this.LB_mes.Size = new System.Drawing.Size(27, 13);
            this.LB_mes.TabIndex = 9;
            this.LB_mes.Text = "Mes";
            // 
            // LB_año
            // 
            this.LB_año.AutoSize = true;
            this.LB_año.Location = new System.Drawing.Point(316, 50);
            this.LB_año.Name = "LB_año";
            this.LB_año.Size = new System.Drawing.Size(26, 13);
            this.LB_año.TabIndex = 10;
            this.LB_año.Text = "Año";
            // 
            // LB_items
            // 
            this.LB_items.AutoSize = true;
            this.LB_items.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_items.Location = new System.Drawing.Point(13, 116);
            this.LB_items.Name = "LB_items";
            this.LB_items.Size = new System.Drawing.Size(0, 13);
            this.LB_items.TabIndex = 11;
            // 
            // CBX_respaldo
            // 
            this.CBX_respaldo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CBX_respaldo.AutoSize = true;
            this.CBX_respaldo.Location = new System.Drawing.Point(723, 16);
            this.CBX_respaldo.Name = "CBX_respaldo";
            this.CBX_respaldo.Size = new System.Drawing.Size(71, 17);
            this.CBX_respaldo.TabIndex = 12;
            this.CBX_respaldo.Text = "Respaldo";
            this.CBX_respaldo.UseVisualStyleBackColor = true;
            this.CBX_respaldo.CheckedChanged += new System.EventHandler(this.CBX_respaldo_CheckedChanged);
            // 
            // PB_barra
            // 
            this.PB_barra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PB_barra.Location = new System.Drawing.Point(12, 86);
            this.PB_barra.Name = "PB_barra";
            this.PB_barra.Size = new System.Drawing.Size(909, 23);
            this.PB_barra.TabIndex = 13;
            // 
            // RB_mes
            // 
            this.RB_mes.AutoSize = true;
            this.RB_mes.Location = new System.Drawing.Point(251, 24);
            this.RB_mes.Name = "RB_mes";
            this.RB_mes.Size = new System.Drawing.Size(45, 17);
            this.RB_mes.TabIndex = 14;
            this.RB_mes.TabStop = true;
            this.RB_mes.Text = "Mes";
            this.RB_mes.UseVisualStyleBackColor = true;
            this.RB_mes.CheckedChanged += new System.EventHandler(this.RB_mes_CheckedChanged);
            // 
            // RB_dia
            // 
            this.RB_dia.AutoSize = true;
            this.RB_dia.Location = new System.Drawing.Point(251, 47);
            this.RB_dia.Name = "RB_dia";
            this.RB_dia.Size = new System.Drawing.Size(43, 17);
            this.RB_dia.TabIndex = 15;
            this.RB_dia.TabStop = true;
            this.RB_dia.Text = "Día";
            this.RB_dia.UseVisualStyleBackColor = true;
            this.RB_dia.CheckedChanged += new System.EventHandler(this.RB_dia_CheckedChanged);
            // 
            // DT_fecha
            // 
            this.DT_fecha.Location = new System.Drawing.Point(349, 34);
            this.DT_fecha.Name = "DT_fecha";
            this.DT_fecha.Size = new System.Drawing.Size(200, 20);
            this.DT_fecha.TabIndex = 16;
            // 
            // LB_fecha
            // 
            this.LB_fecha.AutoSize = true;
            this.LB_fecha.Location = new System.Drawing.Point(309, 37);
            this.LB_fecha.Name = "LB_fecha";
            this.LB_fecha.Size = new System.Drawing.Size(37, 13);
            this.LB_fecha.TabIndex = 18;
            this.LB_fecha.Text = "Fecha";
            // 
            // LB_total
            // 
            this.LB_total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LB_total.AutoSize = true;
            this.LB_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_total.Location = new System.Drawing.Point(809, 114);
            this.LB_total.Name = "LB_total";
            this.LB_total.Size = new System.Drawing.Size(0, 13);
            this.LB_total.TabIndex = 19;
            // 
            // TICKET
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TICKET.DefaultCellStyle = dataGridViewCellStyle13;
            this.TICKET.HeaderText = "TICKET";
            this.TICKET.Name = "TICKET";
            // 
            // IMPORTE
            // 
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.IMPORTE.DefaultCellStyle = dataGridViewCellStyle14;
            this.IMPORTE.HeaderText = "IMPORTE";
            this.IMPORTE.Name = "IMPORTE";
            // 
            // FECHA
            // 
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.FECHA.DefaultCellStyle = dataGridViewCellStyle15;
            this.FECHA.HeaderText = "FECHA";
            this.FECHA.Name = "FECHA";
            // 
            // HORA
            // 
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.HORA.DefaultCellStyle = dataGridViewCellStyle16;
            this.HORA.HeaderText = "HORA";
            this.HORA.Name = "HORA";
            // 
            // ESTACION
            // 
            this.ESTACION.HeaderText = "ESTACION";
            this.ESTACION.Name = "ESTACION";
            // 
            // CONCEPTO
            // 
            this.CONCEPTO.HeaderText = "CONCEPTO";
            this.CONCEPTO.Name = "CONCEPTO";
            // 
            // NOTA
            // 
            this.NOTA.HeaderText = "DEVOLUCION";
            this.NOTA.Name = "NOTA";
            // 
            // Caja1Tarjetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(933, 512);
            this.Controls.Add(this.LB_total);
            this.Controls.Add(this.LB_fecha);
            this.Controls.Add(this.DT_fecha);
            this.Controls.Add(this.RB_dia);
            this.Controls.Add(this.RB_mes);
            this.Controls.Add(this.PB_barra);
            this.Controls.Add(this.CBX_respaldo);
            this.Controls.Add(this.LB_items);
            this.Controls.Add(this.LB_año);
            this.Controls.Add(this.LB_mes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CB_año);
            this.Controls.Add(this.BT_exportar);
            this.Controls.Add(this.CB_sucursal);
            this.Controls.Add(this.BT_buscar);
            this.Controls.Add(this.CB_mes);
            this.Controls.Add(this.DG_tabla);
            this.Controls.Add(this.button1);
            this.Name = "Caja1Tarjetas";
            this.Text = "Reporte de Tickets de ventas con tarjetas";
            this.Load += new System.EventHandler(this.Caja1Tarjetas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_tabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView DG_tabla;
        private System.Windows.Forms.ComboBox CB_mes;
        private System.Windows.Forms.Button BT_buscar;
        private System.Windows.Forms.ComboBox CB_sucursal;
        private System.Windows.Forms.Button BT_exportar;
        private System.Windows.Forms.ComboBox CB_año;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LB_mes;
        private System.Windows.Forms.Label LB_año;
        private System.Windows.Forms.Label LB_items;
        private System.Windows.Forms.CheckBox CBX_respaldo;
        private System.Windows.Forms.ProgressBar PB_barra;
        private System.Windows.Forms.RadioButton RB_mes;
        private System.Windows.Forms.RadioButton RB_dia;
        private System.Windows.Forms.DateTimePicker DT_fecha;
        private System.Windows.Forms.Label LB_fecha;
        private System.Windows.Forms.Label LB_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn TICKET;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMPORTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn CONCEPTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOTA;
    }
}