namespace appSugerencias
{
    partial class ReporteCorteZ
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DG_tabla = new System.Windows.Forms.DataGridView();
            this.FECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMPORTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMPUESTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BT_caja = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DT_inicio = new System.Windows.Forms.DateTimePicker();
            this.CBX_mes_anterior = new System.Windows.Forms.CheckBox();
            this.CB_sucursal = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BT_pdf = new System.Windows.Forms.Button();
            this.DT_fin = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
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
            this.DG_tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FECHA,
            this.DESCRIPCION,
            this.IMPORTE,
            this.IMPUESTO,
            this.TOTAL});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DG_tabla.DefaultCellStyle = dataGridViewCellStyle12;
            this.DG_tabla.Location = new System.Drawing.Point(0, 116);
            this.DG_tabla.Name = "DG_tabla";
            this.DG_tabla.Size = new System.Drawing.Size(909, 333);
            this.DG_tabla.TabIndex = 0;
            // 
            // FECHA
            // 
            this.FECHA.HeaderText = "FECHA";
            this.FECHA.Name = "FECHA";
            // 
            // DESCRIPCION
            // 
            this.DESCRIPCION.HeaderText = "DESCRIPCION";
            this.DESCRIPCION.Name = "DESCRIPCION";
            // 
            // IMPORTE
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.IMPORTE.DefaultCellStyle = dataGridViewCellStyle9;
            this.IMPORTE.HeaderText = "IMPORTE";
            this.IMPORTE.Name = "IMPORTE";
            // 
            // IMPUESTO
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.IMPUESTO.DefaultCellStyle = dataGridViewCellStyle10;
            this.IMPUESTO.HeaderText = "IMPUESTO";
            this.IMPUESTO.Name = "IMPUESTO";
            // 
            // TOTAL
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.TOTAL.DefaultCellStyle = dataGridViewCellStyle11;
            this.TOTAL.HeaderText = "TOTAL";
            this.TOTAL.Name = "TOTAL";
            // 
            // BT_caja
            // 
            this.BT_caja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_caja.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_caja.ForeColor = System.Drawing.Color.White;
            this.BT_caja.Location = new System.Drawing.Point(798, 3);
            this.BT_caja.Name = "BT_caja";
            this.BT_caja.Size = new System.Drawing.Size(99, 55);
            this.BT_caja.TabIndex = 1;
            this.BT_caja.Text = "Buscar";
            this.BT_caja.UseVisualStyleBackColor = false;
            this.BT_caja.Click += new System.EventHandler(this.BT_caja_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Inicio";
            // 
            // DT_inicio
            // 
            this.DT_inicio.Location = new System.Drawing.Point(64, 53);
            this.DT_inicio.Name = "DT_inicio";
            this.DT_inicio.Size = new System.Drawing.Size(371, 20);
            this.DT_inicio.TabIndex = 8;
            // 
            // CBX_mes_anterior
            // 
            this.CBX_mes_anterior.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CBX_mes_anterior.AutoSize = true;
            this.CBX_mes_anterior.Location = new System.Drawing.Point(726, 29);
            this.CBX_mes_anterior.Name = "CBX_mes_anterior";
            this.CBX_mes_anterior.Size = new System.Drawing.Size(71, 17);
            this.CBX_mes_anterior.TabIndex = 9;
            this.CBX_mes_anterior.Text = "Respaldo";
            this.CBX_mes_anterior.UseVisualStyleBackColor = true;
            // 
            // CB_sucursal
            // 
            this.CB_sucursal.FormattingEnabled = true;
            this.CB_sucursal.Items.AddRange(new object[] {
            "VALLARTA",
            "RENA",
            "VELAZQUEZ",
            "COLOSO"});
            this.CB_sucursal.Location = new System.Drawing.Point(64, 26);
            this.CB_sucursal.Name = "CB_sucursal";
            this.CB_sucursal.Size = new System.Drawing.Size(200, 21);
            this.CB_sucursal.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Sucursal";
            // 
            // BT_pdf
            // 
            this.BT_pdf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_pdf.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_pdf.ForeColor = System.Drawing.Color.White;
            this.BT_pdf.Location = new System.Drawing.Point(798, 64);
            this.BT_pdf.Name = "BT_pdf";
            this.BT_pdf.Size = new System.Drawing.Size(99, 46);
            this.BT_pdf.TabIndex = 13;
            this.BT_pdf.Text = "PDF";
            this.BT_pdf.UseVisualStyleBackColor = false;
            this.BT_pdf.Click += new System.EventHandler(this.BT_pdf_Click);
            // 
            // DT_fin
            // 
            this.DT_fin.Location = new System.Drawing.Point(64, 79);
            this.DT_fin.Name = "DT_fin";
            this.DT_fin.Size = new System.Drawing.Size(371, 20);
            this.DT_fin.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Fin";
            // 
            // ReporteCorteZ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(909, 450);
            this.Controls.Add(this.DT_fin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BT_pdf);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CB_sucursal);
            this.Controls.Add(this.CBX_mes_anterior);
            this.Controls.Add(this.DT_inicio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BT_caja);
            this.Controls.Add(this.DG_tabla);
            this.Name = "ReporteCorteZ";
            this.Text = "ReporteCorteZ";
            this.Load += new System.EventHandler(this.ReporteCorteZ_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_tabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DG_tabla;
        private System.Windows.Forms.Button BT_caja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DT_inicio;
        private System.Windows.Forms.CheckBox CBX_mes_anterior;
        private System.Windows.Forms.ComboBox CB_sucursal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BT_pdf;
        private System.Windows.Forms.DateTimePicker DT_fin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMPORTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMPUESTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL;
    }
}