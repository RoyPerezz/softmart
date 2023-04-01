
namespace appSugerencias.Gastos_Externos.Vistas
{
    partial class ReporteGastosExternos
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
            this.BT_buscar = new System.Windows.Forms.Button();
            this.DT_inicio = new System.Windows.Forms.DateTimePicker();
            this.DT_fin = new System.Windows.Forms.DateTimePicker();
            this.BT_exportar = new System.Windows.Forms.Button();
            this.cbGastos = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CB_concepto_gral = new System.Windows.Forms.ComboBox();
            this.CB_sucursal = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPOGASTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CONCEPTOGRAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CONCEPTODETALLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMPORTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REFERENCIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RB_general_todos = new System.Windows.Forms.RadioButton();
            this.RB_tienda_todos = new System.Windows.Forms.RadioButton();
            this.RB_todos = new System.Windows.Forms.RadioButton();
            this.RB_tienda = new System.Windows.Forms.RadioButton();
            this.RB_general = new System.Windows.Forms.RadioButton();
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
            this.ID,
            this.TIPOGASTO,
            this.CONCEPTOGRAL,
            this.CONCEPTODETALLE,
            this.IMPORTE,
            this.REFERENCIA,
            this.FECHA});
            this.DG_tabla.Location = new System.Drawing.Point(1, 160);
            this.DG_tabla.Name = "DG_tabla";
            this.DG_tabla.Size = new System.Drawing.Size(1018, 291);
            this.DG_tabla.TabIndex = 0;
            // 
            // BT_buscar
            // 
            this.BT_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_buscar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_buscar.ForeColor = System.Drawing.Color.White;
            this.BT_buscar.Location = new System.Drawing.Point(807, 101);
            this.BT_buscar.Name = "BT_buscar";
            this.BT_buscar.Size = new System.Drawing.Size(95, 53);
            this.BT_buscar.TabIndex = 1;
            this.BT_buscar.Text = "Buscar";
            this.BT_buscar.UseVisualStyleBackColor = false;
            this.BT_buscar.Click += new System.EventHandler(this.BT_buscar_Click);
            // 
            // DT_inicio
            // 
            this.DT_inicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DT_inicio.Location = new System.Drawing.Point(807, 22);
            this.DT_inicio.Name = "DT_inicio";
            this.DT_inicio.Size = new System.Drawing.Size(200, 20);
            this.DT_inicio.TabIndex = 2;
            // 
            // DT_fin
            // 
            this.DT_fin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DT_fin.Location = new System.Drawing.Point(807, 53);
            this.DT_fin.Name = "DT_fin";
            this.DT_fin.Size = new System.Drawing.Size(200, 20);
            this.DT_fin.TabIndex = 3;
            // 
            // BT_exportar
            // 
            this.BT_exportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_exportar.BackColor = System.Drawing.Color.CadetBlue;
            this.BT_exportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_exportar.ForeColor = System.Drawing.Color.White;
            this.BT_exportar.Location = new System.Drawing.Point(912, 101);
            this.BT_exportar.Name = "BT_exportar";
            this.BT_exportar.Size = new System.Drawing.Size(95, 53);
            this.BT_exportar.TabIndex = 5;
            this.BT_exportar.Text = "Exportar";
            this.BT_exportar.UseVisualStyleBackColor = false;
            this.BT_exportar.Click += new System.EventHandler(this.BT_exportar_Click);
            // 
            // cbGastos
            // 
            this.cbGastos.FormattingEnabled = true;
            this.cbGastos.Location = new System.Drawing.Point(133, 120);
            this.cbGastos.Name = "cbGastos";
            this.cbGastos.Size = new System.Drawing.Size(232, 21);
            this.cbGastos.TabIndex = 69;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 76;
            this.label3.Text = "SUCURSAL";
            // 
            // CB_concepto_gral
            // 
            this.CB_concepto_gral.FormattingEnabled = true;
            this.CB_concepto_gral.Location = new System.Drawing.Point(133, 76);
            this.CB_concepto_gral.Name = "CB_concepto_gral";
            this.CB_concepto_gral.Size = new System.Drawing.Size(232, 21);
            this.CB_concepto_gral.TabIndex = 70;
            this.CB_concepto_gral.SelectedIndexChanged += new System.EventHandler(this.CB_concepto_gral_SelectedIndexChanged);
            // 
            // CB_sucursal
            // 
            this.CB_sucursal.FormattingEnabled = true;
            this.CB_sucursal.Items.AddRange(new object[] {
            "CEDIS",
            "VALLARTA",
            "RENA",
            "VELAZQUEZ",
            "COLOSO"});
            this.CB_sucursal.Location = new System.Drawing.Point(133, 30);
            this.CB_sucursal.Name = "CB_sucursal";
            this.CB_sucursal.Size = new System.Drawing.Size(232, 21);
            this.CB_sucursal.TabIndex = 75;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 74;
            this.label2.Text = "CONCEPTO DETALLE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 73;
            this.label1.Text = "CONCEPTO GRAL";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(765, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 77;
            this.label4.Text = "INICIO";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(780, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 78;
            this.label5.Text = "FIN";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // TIPOGASTO
            // 
            this.TIPOGASTO.HeaderText = "TIPO GASTO";
            this.TIPOGASTO.Name = "TIPOGASTO";
            // 
            // CONCEPTOGRAL
            // 
            this.CONCEPTOGRAL.HeaderText = "CONCEPTO GRAL.";
            this.CONCEPTOGRAL.Name = "CONCEPTOGRAL";
            // 
            // CONCEPTODETALLE
            // 
            this.CONCEPTODETALLE.HeaderText = "CONCEPTO DETALLE";
            this.CONCEPTODETALLE.Name = "CONCEPTODETALLE";
            // 
            // IMPORTE
            // 
            this.IMPORTE.HeaderText = "IMPORTE";
            this.IMPORTE.Name = "IMPORTE";
            // 
            // REFERENCIA
            // 
            this.REFERENCIA.HeaderText = "REFERENCIA";
            this.REFERENCIA.Name = "REFERENCIA";
            // 
            // FECHA
            // 
            this.FECHA.HeaderText = "FECHA";
            this.FECHA.Name = "FECHA";
            // 
            // RB_general_todos
            // 
            this.RB_general_todos.AutoSize = true;
            this.RB_general_todos.Location = new System.Drawing.Point(371, 124);
            this.RB_general_todos.Name = "RB_general_todos";
            this.RB_general_todos.Size = new System.Drawing.Size(202, 17);
            this.RB_general_todos.TabIndex = 84;
            this.RB_general_todos.TabStop = true;
            this.RB_general_todos.Text = "TODOS LOS GASTOS GENERALES";
            this.RB_general_todos.UseVisualStyleBackColor = true;
            // 
            // RB_tienda_todos
            // 
            this.RB_tienda_todos.AutoSize = true;
            this.RB_tienda_todos.Location = new System.Drawing.Point(371, 101);
            this.RB_tienda_todos.Name = "RB_tienda_todos";
            this.RB_tienda_todos.Size = new System.Drawing.Size(195, 17);
            this.RB_tienda_todos.TabIndex = 83;
            this.RB_tienda_todos.TabStop = true;
            this.RB_tienda_todos.Text = "TODOS LOS GASTOS DE TIENDA";
            this.RB_tienda_todos.UseVisualStyleBackColor = true;
            // 
            // RB_todos
            // 
            this.RB_todos.AutoSize = true;
            this.RB_todos.Location = new System.Drawing.Point(371, 29);
            this.RB_todos.Name = "RB_todos";
            this.RB_todos.Size = new System.Drawing.Size(63, 17);
            this.RB_todos.TabIndex = 82;
            this.RB_todos.TabStop = true;
            this.RB_todos.Text = "TODOS";
            this.RB_todos.UseVisualStyleBackColor = true;
            // 
            // RB_tienda
            // 
            this.RB_tienda.AutoSize = true;
            this.RB_tienda.Location = new System.Drawing.Point(371, 53);
            this.RB_tienda.Name = "RB_tienda";
            this.RB_tienda.Size = new System.Drawing.Size(65, 17);
            this.RB_tienda.TabIndex = 80;
            this.RB_tienda.TabStop = true;
            this.RB_tienda.Text = "TIENDA";
            this.RB_tienda.UseVisualStyleBackColor = true;
            this.RB_tienda.CheckedChanged += new System.EventHandler(this.RB_tienda_CheckedChanged);
            // 
            // RB_general
            // 
            this.RB_general.AutoSize = true;
            this.RB_general.Location = new System.Drawing.Point(371, 78);
            this.RB_general.Name = "RB_general";
            this.RB_general.Size = new System.Drawing.Size(76, 17);
            this.RB_general.TabIndex = 81;
            this.RB_general.TabStop = true;
            this.RB_general.Text = "GENERAL";
            this.RB_general.UseVisualStyleBackColor = true;
            this.RB_general.CheckedChanged += new System.EventHandler(this.RB_general_CheckedChanged);
            // 
            // ReporteGastosExternos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1019, 450);
            this.Controls.Add(this.RB_general_todos);
            this.Controls.Add(this.RB_tienda_todos);
            this.Controls.Add(this.RB_todos);
            this.Controls.Add(this.RB_tienda);
            this.Controls.Add(this.RB_general);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbGastos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CB_concepto_gral);
            this.Controls.Add(this.CB_sucursal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BT_exportar);
            this.Controls.Add(this.DT_fin);
            this.Controls.Add(this.DT_inicio);
            this.Controls.Add(this.BT_buscar);
            this.Controls.Add(this.DG_tabla);
            this.Name = "ReporteGastosExternos";
            this.Text = "ReporteGastosExternos";
            this.Load += new System.EventHandler(this.ReporteGastosExternos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_tabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DG_tabla;
        private System.Windows.Forms.Button BT_buscar;
        private System.Windows.Forms.DateTimePicker DT_inicio;
        private System.Windows.Forms.DateTimePicker DT_fin;
        private System.Windows.Forms.Button BT_exportar;
        private System.Windows.Forms.ComboBox cbGastos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CB_concepto_gral;
        private System.Windows.Forms.ComboBox CB_sucursal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPOGASTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CONCEPTOGRAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn CONCEPTODETALLE;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMPORTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn REFERENCIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA;
        private System.Windows.Forms.RadioButton RB_general_todos;
        private System.Windows.Forms.RadioButton RB_tienda_todos;
        private System.Windows.Forms.RadioButton RB_todos;
        private System.Windows.Forms.RadioButton RB_tienda;
        private System.Windows.Forms.RadioButton RB_general;
    }
}