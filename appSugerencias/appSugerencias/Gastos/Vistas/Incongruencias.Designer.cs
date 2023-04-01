
namespace appSugerencias.Gastos.Vistas
{
    partial class Incongruencias
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DG_tabla = new System.Windows.Forms.DataGridView();
            this.DT_inicio = new System.Windows.Forms.DateTimePicker();
            this.DT_fin = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BT_buscar = new System.Windows.Forms.Button();
            this.CB_concepto_gral = new System.Windows.Forms.ComboBox();
            this.RB_tienda = new System.Windows.Forms.RadioButton();
            this.RB_general = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CB_concepto_detalle = new System.Windows.Forms.ComboBox();
            this.BT_agregar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CB_sucursal = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CBX_respaldo = new System.Windows.Forms.CheckBox();
            this.BT_exportar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DG_tabla)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DG_tabla
            // 
            this.DG_tabla.AllowUserToAddRows = false;
            this.DG_tabla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DG_tabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_tabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DG_tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_tabla.Location = new System.Drawing.Point(1, 150);
            this.DG_tabla.Name = "DG_tabla";
            this.DG_tabla.Size = new System.Drawing.Size(1164, 300);
            this.DG_tabla.TabIndex = 0;
            // 
            // DT_inicio
            // 
            this.DT_inicio.Location = new System.Drawing.Point(82, 64);
            this.DT_inicio.Name = "DT_inicio";
            this.DT_inicio.Size = new System.Drawing.Size(200, 20);
            this.DT_inicio.TabIndex = 1;
            // 
            // DT_fin
            // 
            this.DT_fin.Location = new System.Drawing.Point(82, 90);
            this.DT_fin.Name = "DT_fin";
            this.DT_fin.Size = new System.Drawing.Size(200, 20);
            this.DT_fin.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Inicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fin";
            // 
            // BT_buscar
            // 
            this.BT_buscar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_buscar.ForeColor = System.Drawing.Color.White;
            this.BT_buscar.Location = new System.Drawing.Point(288, 64);
            this.BT_buscar.Name = "BT_buscar";
            this.BT_buscar.Size = new System.Drawing.Size(105, 46);
            this.BT_buscar.TabIndex = 5;
            this.BT_buscar.Text = "Buscar";
            this.BT_buscar.UseVisualStyleBackColor = false;
            this.BT_buscar.Click += new System.EventHandler(this.BT_buscar_Click);
            // 
            // CB_concepto_gral
            // 
            this.CB_concepto_gral.FormattingEnabled = true;
            this.CB_concepto_gral.Location = new System.Drawing.Point(124, 50);
            this.CB_concepto_gral.Name = "CB_concepto_gral";
            this.CB_concepto_gral.Size = new System.Drawing.Size(251, 21);
            this.CB_concepto_gral.TabIndex = 6;
            this.CB_concepto_gral.SelectedIndexChanged += new System.EventHandler(this.CB_concepto_gral_SelectedIndexChanged);
            // 
            // RB_tienda
            // 
            this.RB_tienda.AutoSize = true;
            this.RB_tienda.Location = new System.Drawing.Point(124, 23);
            this.RB_tienda.Name = "RB_tienda";
            this.RB_tienda.Size = new System.Drawing.Size(58, 17);
            this.RB_tienda.TabIndex = 7;
            this.RB_tienda.TabStop = true;
            this.RB_tienda.Text = "Tienda";
            this.RB_tienda.UseVisualStyleBackColor = true;
            this.RB_tienda.CheckedChanged += new System.EventHandler(this.RB_tienda_CheckedChanged);
            // 
            // RB_general
            // 
            this.RB_general.AutoSize = true;
            this.RB_general.Location = new System.Drawing.Point(313, 23);
            this.RB_general.Name = "RB_general";
            this.RB_general.Size = new System.Drawing.Size(62, 17);
            this.RB_general.TabIndex = 8;
            this.RB_general.TabStop = true;
            this.RB_general.Text = "General";
            this.RB_general.UseVisualStyleBackColor = true;
            this.RB_general.CheckedChanged += new System.EventHandler(this.RB_general_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Concepto general";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Concepto detalle";
            // 
            // CB_concepto_detalle
            // 
            this.CB_concepto_detalle.FormattingEnabled = true;
            this.CB_concepto_detalle.Location = new System.Drawing.Point(124, 77);
            this.CB_concepto_detalle.Name = "CB_concepto_detalle";
            this.CB_concepto_detalle.Size = new System.Drawing.Size(251, 21);
            this.CB_concepto_detalle.TabIndex = 10;
            this.CB_concepto_detalle.SelectedIndexChanged += new System.EventHandler(this.CB_concepto_detalle_SelectedIndexChanged);
            // 
            // BT_agregar
            // 
            this.BT_agregar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_agregar.ForeColor = System.Drawing.Color.White;
            this.BT_agregar.Location = new System.Drawing.Point(381, 50);
            this.BT_agregar.Name = "BT_agregar";
            this.BT_agregar.Size = new System.Drawing.Size(105, 46);
            this.BT_agregar.TabIndex = 12;
            this.BT_agregar.Text = "Agregar";
            this.BT_agregar.UseVisualStyleBackColor = false;
            this.BT_agregar.Click += new System.EventHandler(this.BT_agregar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BT_exportar);
            this.groupBox1.Controls.Add(this.CBX_respaldo);
            this.groupBox1.Controls.Add(this.CB_sucursal);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.BT_buscar);
            this.groupBox1.Controls.Add(this.DT_inicio);
            this.groupBox1.Controls.Add(this.DT_fin);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(1, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(536, 143);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda por fechas";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BT_agregar);
            this.groupBox2.Controls.Add(this.CB_concepto_gral);
            this.groupBox2.Controls.Add(this.RB_tienda);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.RB_general);
            this.groupBox2.Controls.Add(this.CB_concepto_detalle);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(543, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(622, 143);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Agregar concepto";
            // 
            // CB_sucursal
            // 
            this.CB_sucursal.FormattingEnabled = true;
            this.CB_sucursal.Items.AddRange(new object[] {
            "VALLARTA",
            "RENA",
            "VELAZQUEZ",
            "COLOSO"});
            this.CB_sucursal.Location = new System.Drawing.Point(82, 38);
            this.CB_sucursal.Name = "CB_sucursal";
            this.CB_sucursal.Size = new System.Drawing.Size(200, 21);
            this.CB_sucursal.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Sucursal";
            // 
            // CBX_respaldo
            // 
            this.CBX_respaldo.AutoSize = true;
            this.CBX_respaldo.Location = new System.Drawing.Point(289, 38);
            this.CBX_respaldo.Name = "CBX_respaldo";
            this.CBX_respaldo.Size = new System.Drawing.Size(71, 17);
            this.CBX_respaldo.TabIndex = 15;
            this.CBX_respaldo.Text = "Respaldo";
            this.CBX_respaldo.UseVisualStyleBackColor = true;
            // 
            // BT_exportar
            // 
            this.BT_exportar.BackColor = System.Drawing.Color.SeaGreen;
            this.BT_exportar.ForeColor = System.Drawing.Color.White;
            this.BT_exportar.Location = new System.Drawing.Point(399, 63);
            this.BT_exportar.Name = "BT_exportar";
            this.BT_exportar.Size = new System.Drawing.Size(105, 46);
            this.BT_exportar.TabIndex = 16;
            this.BT_exportar.Text = "Exportar";
            this.BT_exportar.UseVisualStyleBackColor = false;
            this.BT_exportar.Click += new System.EventHandler(this.BT_exportar_Click);
            // 
            // Incongruencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1167, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DG_tabla);
            this.Name = "Incongruencias";
            this.Text = "Incongruencias";
            this.Load += new System.EventHandler(this.Incongruencias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_tabla)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DG_tabla;
        private System.Windows.Forms.DateTimePicker DT_inicio;
        private System.Windows.Forms.DateTimePicker DT_fin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BT_buscar;
        private System.Windows.Forms.ComboBox CB_concepto_gral;
        private System.Windows.Forms.RadioButton RB_tienda;
        private System.Windows.Forms.RadioButton RB_general;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CB_concepto_detalle;
        private System.Windows.Forms.Button BT_agregar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CB_sucursal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox CBX_respaldo;
        private System.Windows.Forms.Button BT_exportar;
    }
}