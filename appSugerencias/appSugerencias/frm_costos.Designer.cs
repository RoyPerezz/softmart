﻿namespace appSugerencias
{
    partial class frm_costos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_costos));
            this.cbMeses = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.cbTienda = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblGastosInternos = new System.Windows.Forms.Label();
            this.lblinventario = new System.Windows.Forms.Label();
            this.lblCostoVentas = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lblentradaCosto = new System.Windows.Forms.Label();
            this.dgvCosto = new System.Windows.Forms.DataGridView();
            this.TIENDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VENTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COSTO_VENTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GASTOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GASTOEXT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UTILIDAD_NETA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INVENTARIO_COSTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ENTRADAS_COSTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PERIODO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BT_exportar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblVentas = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblUtilidadNeta = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.lblGastosExternos = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.lblBruta = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblGastosTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCosto)).BeginInit();
            this.SuspendLayout();
            // 
            // cbMeses
            // 
            this.cbMeses.FormattingEnabled = true;
            this.cbMeses.Items.AddRange(new object[] {
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
            this.cbMeses.Location = new System.Drawing.Point(174, 40);
            this.cbMeses.Name = "cbMeses";
            this.cbMeses.Size = new System.Drawing.Size(121, 21);
            this.cbMeses.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1172, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 51);
            this.button1.TabIndex = 1;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbYear
            // 
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Location = new System.Drawing.Point(341, 40);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(74, 21);
            this.cbYear.TabIndex = 2;
            // 
            // cbTienda
            // 
            this.cbTienda.FormattingEnabled = true;
            this.cbTienda.Items.AddRange(new object[] {
            "VALLARTA",
            "RENA",
            "VELAZQUEZ",
            "COLOSO",
            "PREGOT"});
            this.cbTienda.Location = new System.Drawing.Point(19, 40);
            this.cbTienda.Name = "cbTienda";
            this.cbTienda.Size = new System.Drawing.Size(121, 21);
            this.cbTienda.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(182, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Costo de Ventas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(977, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Gastos Internos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(964, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Inventario al Costo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1144, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Entradas al Costo";
            // 
            // lblGastosInternos
            // 
            this.lblGastosInternos.AutoSize = true;
            this.lblGastosInternos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGastosInternos.ForeColor = System.Drawing.Color.Red;
            this.lblGastosInternos.Location = new System.Drawing.Point(990, 273);
            this.lblGastosInternos.Name = "lblGastosInternos";
            this.lblGastosInternos.Size = new System.Drawing.Size(23, 16);
            this.lblGastosInternos.TabIndex = 8;
            this.lblGastosInternos.Text = "---";
            this.lblGastosInternos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblinventario
            // 
            this.lblinventario.AutoSize = true;
            this.lblinventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinventario.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lblinventario.Location = new System.Drawing.Point(977, 166);
            this.lblinventario.Name = "lblinventario";
            this.lblinventario.Size = new System.Drawing.Size(23, 16);
            this.lblinventario.TabIndex = 9;
            this.lblinventario.Text = "---";
            // 
            // lblCostoVentas
            // 
            this.lblCostoVentas.AutoSize = true;
            this.lblCostoVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostoVentas.ForeColor = System.Drawing.Color.Red;
            this.lblCostoVentas.Location = new System.Drawing.Point(193, 166);
            this.lblCostoVentas.Name = "lblCostoVentas";
            this.lblCostoVentas.Size = new System.Drawing.Size(23, 16);
            this.lblCostoVentas.TabIndex = 10;
            this.lblCostoVentas.Text = "---";
            this.lblCostoVentas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(1161, 387);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 51);
            this.button2.TabIndex = 11;
            this.button2.Text = "Agregar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblentradaCosto
            // 
            this.lblentradaCosto.AutoSize = true;
            this.lblentradaCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblentradaCosto.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lblentradaCosto.Location = new System.Drawing.Point(1152, 166);
            this.lblentradaCosto.Name = "lblentradaCosto";
            this.lblentradaCosto.Size = new System.Drawing.Size(23, 16);
            this.lblentradaCosto.TabIndex = 12;
            this.lblentradaCosto.Text = "---";
            // 
            // dgvCosto
            // 
            this.dgvCosto.AllowUserToAddRows = false;
            this.dgvCosto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCosto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TIENDA,
            this.VENTA,
            this.COSTO_VENTA,
            this.GASTOS,
            this.GASTOEXT,
            this.UTILIDAD_NETA,
            this.INVENTARIO_COSTO,
            this.ENTRADAS_COSTO,
            this.PERIODO});
            this.dgvCosto.Location = new System.Drawing.Point(8, 228);
            this.dgvCosto.Name = "dgvCosto";
            this.dgvCosto.Size = new System.Drawing.Size(943, 210);
            this.dgvCosto.TabIndex = 13;
            // 
            // TIENDA
            // 
            this.TIENDA.HeaderText = "TIENDA";
            this.TIENDA.Name = "TIENDA";
            this.TIENDA.ReadOnly = true;
            // 
            // VENTA
            // 
            this.VENTA.HeaderText = "VENTA";
            this.VENTA.Name = "VENTA";
            // 
            // COSTO_VENTA
            // 
            this.COSTO_VENTA.HeaderText = "COSTO DE VENTA";
            this.COSTO_VENTA.Name = "COSTO_VENTA";
            this.COSTO_VENTA.ReadOnly = true;
            // 
            // GASTOS
            // 
            this.GASTOS.HeaderText = "GASTOS";
            this.GASTOS.Name = "GASTOS";
            this.GASTOS.ReadOnly = true;
            // 
            // GASTOEXT
            // 
            this.GASTOEXT.HeaderText = "GASTO EXT";
            this.GASTOEXT.Name = "GASTOEXT";
            // 
            // UTILIDAD_NETA
            // 
            this.UTILIDAD_NETA.HeaderText = "UTILIDAD NETA";
            this.UTILIDAD_NETA.Name = "UTILIDAD_NETA";
            // 
            // INVENTARIO_COSTO
            // 
            this.INVENTARIO_COSTO.HeaderText = "INVENTARIO AL COSTO";
            this.INVENTARIO_COSTO.Name = "INVENTARIO_COSTO";
            this.INVENTARIO_COSTO.ReadOnly = true;
            // 
            // ENTRADAS_COSTO
            // 
            this.ENTRADAS_COSTO.HeaderText = "ENTRADAS AL COSTO";
            this.ENTRADAS_COSTO.Name = "ENTRADAS_COSTO";
            this.ENTRADAS_COSTO.ReadOnly = true;
            // 
            // PERIODO
            // 
            this.PERIODO.HeaderText = "PERIODO";
            this.PERIODO.Name = "PERIODO";
            this.PERIODO.ReadOnly = true;
            // 
            // BT_exportar
            // 
            this.BT_exportar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_exportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_exportar.ForeColor = System.Drawing.Color.White;
            this.BT_exportar.Image = ((System.Drawing.Image)(resources.GetObject("BT_exportar.Image")));
            this.BT_exportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_exportar.Location = new System.Drawing.Point(1028, 387);
            this.BT_exportar.Name = "BT_exportar";
            this.BT_exportar.Size = new System.Drawing.Size(112, 51);
            this.BT_exportar.TabIndex = 15;
            this.BT_exportar.Text = "Exportar";
            this.BT_exportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BT_exportar.UseVisualStyleBackColor = false;
            this.BT_exportar.Click += new System.EventHandler(this.BT_exportar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Tienda";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(208, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Mes";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(350, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Año";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(66, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "Ventas";
            // 
            // lblVentas
            // 
            this.lblVentas.AutoSize = true;
            this.lblVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentas.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lblVentas.Location = new System.Drawing.Point(49, 166);
            this.lblVentas.Name = "lblVentas";
            this.lblVentas.Size = new System.Drawing.Size(23, 16);
            this.lblVentas.TabIndex = 20;
            this.lblVentas.Text = "---";
            this.lblVentas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(667, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 16);
            this.label9.TabIndex = 21;
            this.label9.Text = "Utilidad Neta";
            // 
            // lblUtilidadNeta
            // 
            this.lblUtilidadNeta.AutoSize = true;
            this.lblUtilidadNeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUtilidadNeta.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lblUtilidadNeta.Location = new System.Drawing.Point(684, 166);
            this.lblUtilidadNeta.Name = "lblUtilidadNeta";
            this.lblUtilidadNeta.Size = new System.Drawing.Size(23, 16);
            this.lblUtilidadNeta.TabIndex = 22;
            this.lblUtilidadNeta.Text = "---";
            this.lblUtilidadNeta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DodgerBlue;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(923, 24);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 51);
            this.button3.TabIndex = 23;
            this.button3.Text = "Reporte Gastos";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_2);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1136, 228);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 16);
            this.label10.TabIndex = 24;
            this.label10.Text = "Gastos Externos";
            // 
            // lblGastosExternos
            // 
            this.lblGastosExternos.AutoSize = true;
            this.lblGastosExternos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGastosExternos.ForeColor = System.Drawing.Color.Red;
            this.lblGastosExternos.Location = new System.Drawing.Point(1148, 274);
            this.lblGastosExternos.Name = "lblGastosExternos";
            this.lblGastosExternos.Size = new System.Drawing.Size(23, 16);
            this.lblGastosExternos.TabIndex = 25;
            this.lblGastosExternos.Text = "---";
            this.lblGastosExternos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DodgerBlue;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(1053, 24);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(99, 51);
            this.button4.TabIndex = 26;
            this.button4.Text = "Reporte Gastos Externos";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(384, 123);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 16);
            this.label11.TabIndex = 27;
            this.label11.Text = "Utilidad Bruta";
            // 
            // lblBruta
            // 
            this.lblBruta.AutoSize = true;
            this.lblBruta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBruta.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lblBruta.Location = new System.Drawing.Point(392, 166);
            this.lblBruta.Name = "lblBruta";
            this.lblBruta.Size = new System.Drawing.Size(23, 16);
            this.lblBruta.TabIndex = 28;
            this.lblBruta.Text = "---";
            this.lblBruta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(533, 123);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 16);
            this.label12.TabIndex = 29;
            this.label12.Text = "Gastos Total";
            // 
            // lblGastosTotal
            // 
            this.lblGastosTotal.AutoSize = true;
            this.lblGastosTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGastosTotal.ForeColor = System.Drawing.Color.Red;
            this.lblGastosTotal.Location = new System.Drawing.Point(546, 166);
            this.lblGastosTotal.Name = "lblGastosTotal";
            this.lblGastosTotal.Size = new System.Drawing.Size(23, 16);
            this.lblGastosTotal.TabIndex = 30;
            this.lblGastosTotal.Text = "---";
            this.lblGastosTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_costos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1295, 456);
            this.Controls.Add(this.lblGastosTotal);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblBruta);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.lblGastosExternos);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lblUtilidadNeta);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblVentas);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BT_exportar);
            this.Controls.Add(this.dgvCosto);
            this.Controls.Add(this.lblentradaCosto);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblCostoVentas);
            this.Controls.Add(this.lblinventario);
            this.Controls.Add(this.lblGastosInternos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTienda);
            this.Controls.Add(this.cbYear);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbMeses);
            this.Name = "frm_costos";
            this.Text = "Consulta de Gastos";
            this.Load += new System.EventHandler(this.frm_costos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCosto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMeses;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbYear;
        private System.Windows.Forms.ComboBox cbTienda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblGastosInternos;
        private System.Windows.Forms.Label lblinventario;
        private System.Windows.Forms.Label lblCostoVentas;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblentradaCosto;
        private System.Windows.Forms.DataGridView dgvCosto;
        private System.Windows.Forms.Button BT_exportar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblVentas;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblUtilidadNeta;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblGastosExternos;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblBruta;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblGastosTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIENDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn VENTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn COSTO_VENTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn GASTOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn GASTOEXT;
        private System.Windows.Forms.DataGridViewTextBoxColumn UTILIDAD_NETA;
        private System.Windows.Forms.DataGridViewTextBoxColumn INVENTARIO_COSTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ENTRADAS_COSTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PERIODO;
    }
}