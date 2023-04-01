namespace appSugerencias
{
    partial class IntercambioMercancia
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
            this.CB_lineas = new System.Windows.Forms.ComboBox();
            this.BT_buscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BT_verificar = new System.Windows.Forms.Button();
            this.TB_buscar = new System.Windows.Forms.TextBox();
            this.Label19 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DG_vallarta = new System.Windows.Forms.DataGridView();
            this.FECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MOVIMIENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DG_rena = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DG_velazquez = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.DG_coloso = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GRB_traspasos = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TB_co = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TB_ve = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TB_re = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TB_va = new System.Windows.Forms.TextBox();
            this.CB_sucursal = new System.Windows.Forms.ComboBox();
            this.BT_pasar = new System.Windows.Forms.Button();
            this.BT_formato = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DG_tabla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_vallarta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_rena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_velazquez)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_coloso)).BeginInit();
            this.GRB_traspasos.SuspendLayout();
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
            this.DG_tabla.Location = new System.Drawing.Point(12, 93);
            this.DG_tabla.Name = "DG_tabla";
            this.DG_tabla.Size = new System.Drawing.Size(989, 303);
            this.DG_tabla.TabIndex = 0;
            this.DG_tabla.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_tabla_CellDoubleClick);
            // 
            // CB_lineas
            // 
            this.CB_lineas.FormattingEnabled = true;
            this.CB_lineas.Location = new System.Drawing.Point(13, 42);
            this.CB_lineas.Name = "CB_lineas";
            this.CB_lineas.Size = new System.Drawing.Size(155, 21);
            this.CB_lineas.TabIndex = 1;
            // 
            // BT_buscar
            // 
            this.BT_buscar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_buscar.ForeColor = System.Drawing.Color.White;
            this.BT_buscar.Location = new System.Drawing.Point(180, 25);
            this.BT_buscar.Name = "BT_buscar";
            this.BT_buscar.Size = new System.Drawing.Size(117, 54);
            this.BT_buscar.TabIndex = 2;
            this.BT_buscar.Text = "BUSCAR";
            this.BT_buscar.UseVisualStyleBackColor = false;
            this.BT_buscar.Click += new System.EventHandler(this.BT_buscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "LINEAS";
            // 
            // BT_verificar
            // 
            this.BT_verificar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_verificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_verificar.ForeColor = System.Drawing.Color.White;
            this.BT_verificar.Location = new System.Drawing.Point(303, 25);
            this.BT_verificar.Name = "BT_verificar";
            this.BT_verificar.Size = new System.Drawing.Size(117, 54);
            this.BT_verificar.TabIndex = 4;
            this.BT_verificar.Text = "VERIFICAR SALIDA ENTRADA";
            this.BT_verificar.UseVisualStyleBackColor = false;
            this.BT_verificar.Click += new System.EventHandler(this.BT_verificar_Click);
            // 
            // TB_buscar
            // 
            this.TB_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_buscar.Location = new System.Drawing.Point(787, 67);
            this.TB_buscar.Name = "TB_buscar";
            this.TB_buscar.Size = new System.Drawing.Size(214, 20);
            this.TB_buscar.TabIndex = 5;
            this.TB_buscar.TextChanged += new System.EventHandler(this.TB_buscar_TextChanged);
            // 
            // Label19
            // 
            this.Label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label19.AutoSize = true;
            this.Label19.Location = new System.Drawing.Point(784, 51);
            this.Label19.Name = "Label19";
            this.Label19.Size = new System.Drawing.Size(61, 13);
            this.Label19.TabIndex = 6;
            this.Label19.Text = "ARTICULO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "VALLARTA";
            // 
            // DG_vallarta
            // 
            this.DG_vallarta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_vallarta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FECHA,
            this.MOVIMIENTO});
            this.DG_vallarta.Location = new System.Drawing.Point(8, 42);
            this.DG_vallarta.Name = "DG_vallarta";
            this.DG_vallarta.Size = new System.Drawing.Size(244, 110);
            this.DG_vallarta.TabIndex = 7;
            // 
            // FECHA
            // 
            this.FECHA.HeaderText = "FECHA";
            this.FECHA.Name = "FECHA";
            // 
            // MOVIMIENTO
            // 
            this.MOVIMIENTO.HeaderText = "MOVIMIENTO";
            this.MOVIMIENTO.Name = "MOVIMIENTO";
            // 
            // DG_rena
            // 
            this.DG_rena.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_rena.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.DG_rena.Location = new System.Drawing.Point(256, 42);
            this.DG_rena.Name = "DG_rena";
            this.DG_rena.Size = new System.Drawing.Size(244, 110);
            this.DG_rena.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "FECHA";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "MOVIMIENTO";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "RENA";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(601, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "VELAZQUEZ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // DG_velazquez
            // 
            this.DG_velazquez.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DG_velazquez.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_velazquez.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.DG_velazquez.Location = new System.Drawing.Point(506, 42);
            this.DG_velazquez.Name = "DG_velazquez";
            this.DG_velazquez.Size = new System.Drawing.Size(244, 110);
            this.DG_velazquez.TabIndex = 11;
            this.DG_velazquez.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_velazquez_CellContentClick);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "FECHA";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "MOVIMIENTO";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(851, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "COLOSO";
            // 
            // DG_coloso
            // 
            this.DG_coloso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DG_coloso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_coloso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.DG_coloso.Location = new System.Drawing.Point(756, 42);
            this.DG_coloso.Name = "DG_coloso";
            this.DG_coloso.Size = new System.Drawing.Size(244, 110);
            this.DG_coloso.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "FECHA";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "MOVIMIENTO";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // GRB_traspasos
            // 
            this.GRB_traspasos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GRB_traspasos.Controls.Add(this.label10);
            this.GRB_traspasos.Controls.Add(this.TB_co);
            this.GRB_traspasos.Controls.Add(this.label9);
            this.GRB_traspasos.Controls.Add(this.TB_ve);
            this.GRB_traspasos.Controls.Add(this.label8);
            this.GRB_traspasos.Controls.Add(this.TB_re);
            this.GRB_traspasos.Controls.Add(this.label7);
            this.GRB_traspasos.Controls.Add(this.label6);
            this.GRB_traspasos.Controls.Add(this.TB_va);
            this.GRB_traspasos.Controls.Add(this.CB_sucursal);
            this.GRB_traspasos.Controls.Add(this.BT_pasar);
            this.GRB_traspasos.Controls.Add(this.DG_vallarta);
            this.GRB_traspasos.Controls.Add(this.label2);
            this.GRB_traspasos.Controls.Add(this.DG_rena);
            this.GRB_traspasos.Controls.Add(this.label5);
            this.GRB_traspasos.Controls.Add(this.label3);
            this.GRB_traspasos.Controls.Add(this.DG_coloso);
            this.GRB_traspasos.Controls.Add(this.DG_velazquez);
            this.GRB_traspasos.Controls.Add(this.label4);
            this.GRB_traspasos.Location = new System.Drawing.Point(12, 418);
            this.GRB_traspasos.Name = "GRB_traspasos";
            this.GRB_traspasos.Size = new System.Drawing.Size(1008, 207);
            this.GRB_traspasos.TabIndex = 21;
            this.GRB_traspasos.TabStop = false;
            this.GRB_traspasos.Text = "TRASPASOS";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(412, 169);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "CO";
            // 
            // TB_co
            // 
            this.TB_co.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TB_co.Location = new System.Drawing.Point(396, 185);
            this.TB_co.Name = "TB_co";
            this.TB_co.Size = new System.Drawing.Size(58, 20);
            this.TB_co.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(346, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "VE";
            // 
            // TB_ve
            // 
            this.TB_ve.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TB_ve.Location = new System.Drawing.Point(326, 185);
            this.TB_ve.Name = "TB_ve";
            this.TB_ve.Size = new System.Drawing.Size(58, 20);
            this.TB_ve.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(274, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "RE";
            // 
            // TB_re
            // 
            this.TB_re.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TB_re.Location = new System.Drawing.Point(256, 185);
            this.TB_re.Name = "TB_re";
            this.TB_re.Size = new System.Drawing.Size(58, 20);
            this.TB_re.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(205, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "VA";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "TIENDA QUE ENVÍA";
            // 
            // TB_va
            // 
            this.TB_va.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TB_va.Location = new System.Drawing.Point(187, 185);
            this.TB_va.Name = "TB_va";
            this.TB_va.Size = new System.Drawing.Size(58, 20);
            this.TB_va.TabIndex = 23;
            // 
            // CB_sucursal
            // 
            this.CB_sucursal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CB_sucursal.FormattingEnabled = true;
            this.CB_sucursal.Items.AddRange(new object[] {
            "VALLARTA",
            "RENA",
            "VELAZQUEZ",
            "COLOSO"});
            this.CB_sucursal.Location = new System.Drawing.Point(9, 184);
            this.CB_sucursal.Name = "CB_sucursal";
            this.CB_sucursal.Size = new System.Drawing.Size(155, 21);
            this.CB_sucursal.TabIndex = 23;
            // 
            // BT_pasar
            // 
            this.BT_pasar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_pasar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_pasar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_pasar.ForeColor = System.Drawing.Color.White;
            this.BT_pasar.Location = new System.Drawing.Point(872, 157);
            this.BT_pasar.Name = "BT_pasar";
            this.BT_pasar.Size = new System.Drawing.Size(117, 40);
            this.BT_pasar.TabIndex = 22;
            this.BT_pasar.Text = "PASAR ARTICULO";
            this.BT_pasar.UseVisualStyleBackColor = false;
            this.BT_pasar.Click += new System.EventHandler(this.BT_pasar_Click);
            // 
            // BT_formato
            // 
            this.BT_formato.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_formato.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_formato.ForeColor = System.Drawing.Color.White;
            this.BT_formato.Location = new System.Drawing.Point(426, 25);
            this.BT_formato.Name = "BT_formato";
            this.BT_formato.Size = new System.Drawing.Size(117, 54);
            this.BT_formato.TabIndex = 22;
            this.BT_formato.Text = "ABRIR FORMATO";
            this.BT_formato.UseVisualStyleBackColor = false;
            this.BT_formato.Click += new System.EventHandler(this.BT_formato_Click);
            // 
            // IntercambioMercancia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1013, 637);
            this.Controls.Add(this.BT_formato);
            this.Controls.Add(this.GRB_traspasos);
            this.Controls.Add(this.Label19);
            this.Controls.Add(this.TB_buscar);
            this.Controls.Add(this.BT_verificar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BT_buscar);
            this.Controls.Add(this.CB_lineas);
            this.Controls.Add(this.DG_tabla);
            this.Name = "IntercambioMercancia";
            this.Text = "IntercambioMercancia";
            this.Load += new System.EventHandler(this.IntercambioMercancia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_tabla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_vallarta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_rena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_velazquez)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_coloso)).EndInit();
            this.GRB_traspasos.ResumeLayout(false);
            this.GRB_traspasos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DG_tabla;
        private System.Windows.Forms.ComboBox CB_lineas;
        private System.Windows.Forms.Button BT_buscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BT_verificar;
        private System.Windows.Forms.TextBox TB_buscar;
        private System.Windows.Forms.Label Label19;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DG_vallarta;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA;
        private System.Windows.Forms.DataGridViewTextBoxColumn MOVIMIENTO;
        private System.Windows.Forms.DataGridView DG_rena;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DG_velazquez;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView DG_coloso;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.GroupBox GRB_traspasos;
        private System.Windows.Forms.Button BT_pasar;
        private System.Windows.Forms.Button BT_formato;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TB_co;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TB_ve;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TB_re;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TB_va;
        private System.Windows.Forms.ComboBox CB_sucursal;
    }
}