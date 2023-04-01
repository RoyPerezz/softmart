namespace appSugerencias
{
    partial class CalificarGte
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
            this.DG_tabla = new System.Windows.Forms.DataGridView();
            this.ASPECTOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CALIFICACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BT_guardar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DT_fin = new System.Windows.Forms.DateTimePicker();
            this.DT_inicio = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.CB_SUCURSAL = new System.Windows.Forms.ComboBox();
            this.CB_gerente = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BT_calcular = new System.Windows.Forms.Button();
            this.LB_totalPagar = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LB_totaldesc = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TB_puesto = new System.Windows.Forms.TextBox();
            this.TB_apellidos = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_tabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DG_tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ASPECTOS,
            this.PRECIO,
            this.CALIFICACION,
            this.TOTAL});
            this.DG_tabla.Location = new System.Drawing.Point(-1, 96);
            this.DG_tabla.Name = "DG_tabla";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DG_tabla.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DG_tabla.Size = new System.Drawing.Size(1018, 297);
            this.DG_tabla.TabIndex = 0;
            // 
            // ASPECTOS
            // 
            this.ASPECTOS.HeaderText = "ASPECTOS A CALIFICAR";
            this.ASPECTOS.Name = "ASPECTOS";
            // 
            // PRECIO
            // 
            this.PRECIO.HeaderText = "PRECIO";
            this.PRECIO.Name = "PRECIO";
            // 
            // CALIFICACION
            // 
            this.CALIFICACION.HeaderText = "CALIFICACION";
            this.CALIFICACION.Name = "CALIFICACION";
            // 
            // TOTAL
            // 
            this.TOTAL.HeaderText = "TOTAL";
            this.TOTAL.Name = "TOTAL";
            // 
            // BT_guardar
            // 
            this.BT_guardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_guardar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_guardar.ForeColor = System.Drawing.Color.White;
            this.BT_guardar.Location = new System.Drawing.Point(929, 39);
            this.BT_guardar.Name = "BT_guardar";
            this.BT_guardar.Size = new System.Drawing.Size(88, 40);
            this.BT_guardar.TabIndex = 1;
            this.BT_guardar.Text = "GUARDAR";
            this.BT_guardar.UseVisualStyleBackColor = false;
            this.BT_guardar.Click += new System.EventHandler(this.BT_guardar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(790, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "AL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(499, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "SEMANA DEL ";
            // 
            // DT_fin
            // 
            this.DT_fin.Location = new System.Drawing.Point(817, 12);
            this.DT_fin.Name = "DT_fin";
            this.DT_fin.Size = new System.Drawing.Size(200, 20);
            this.DT_fin.TabIndex = 29;
            // 
            // DT_inicio
            // 
            this.DT_inicio.Location = new System.Drawing.Point(580, 12);
            this.DT_inicio.Name = "DT_inicio";
            this.DT_inicio.Size = new System.Drawing.Size(200, 20);
            this.DT_inicio.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "SUCURSAL";
            // 
            // CB_SUCURSAL
            // 
            this.CB_SUCURSAL.FormattingEnabled = true;
            this.CB_SUCURSAL.Items.AddRange(new object[] {
            "VALLARTA",
            "RENA",
            "VELAZQUEZ",
            "COLOSO"});
            this.CB_SUCURSAL.Location = new System.Drawing.Point(80, 65);
            this.CB_SUCURSAL.Name = "CB_SUCURSAL";
            this.CB_SUCURSAL.Size = new System.Drawing.Size(121, 21);
            this.CB_SUCURSAL.TabIndex = 33;
            this.CB_SUCURSAL.SelectedIndexChanged += new System.EventHandler(this.CB_SUCURSAL_SelectedIndexChanged);
            // 
            // CB_gerente
            // 
            this.CB_gerente.FormattingEnabled = true;
            this.CB_gerente.Location = new System.Drawing.Point(80, 8);
            this.CB_gerente.Name = "CB_gerente";
            this.CB_gerente.Size = new System.Drawing.Size(172, 21);
            this.CB_gerente.TabIndex = 35;
            this.CB_gerente.SelectedIndexChanged += new System.EventHandler(this.CB_gerente_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "GERENTE";
            // 
            // BT_calcular
            // 
            this.BT_calcular.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_calcular.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_calcular.ForeColor = System.Drawing.Color.White;
            this.BT_calcular.Location = new System.Drawing.Point(842, 39);
            this.BT_calcular.Name = "BT_calcular";
            this.BT_calcular.Size = new System.Drawing.Size(88, 40);
            this.BT_calcular.TabIndex = 36;
            this.BT_calcular.Text = "CALCULAR";
            this.BT_calcular.UseVisualStyleBackColor = false;
            this.BT_calcular.Click += new System.EventHandler(this.BT_calcular_Click);
            // 
            // LB_totalPagar
            // 
            this.LB_totalPagar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LB_totalPagar.AutoSize = true;
            this.LB_totalPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_totalPagar.Location = new System.Drawing.Point(846, 461);
            this.LB_totalPagar.Name = "LB_totalPagar";
            this.LB_totalPagar.Size = new System.Drawing.Size(0, 24);
            this.LB_totalPagar.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(833, 461);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 24);
            this.label6.TabIndex = 41;
            this.label6.Text = "$";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(661, 461);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 24);
            this.label5.TabIndex = 40;
            this.label5.Text = "TOTAL A PAGAR";
            // 
            // LB_totaldesc
            // 
            this.LB_totaldesc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LB_totaldesc.AutoSize = true;
            this.LB_totaldesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_totaldesc.Location = new System.Drawing.Point(846, 414);
            this.LB_totaldesc.Name = "LB_totaldesc";
            this.LB_totaldesc.Size = new System.Drawing.Size(0, 24);
            this.LB_totaldesc.TabIndex = 45;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(831, 414);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 24);
            this.label8.TabIndex = 44;
            this.label8.Text = "$";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(661, 414);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 24);
            this.label9.TabIndex = 43;
            this.label9.Text = "TOTAL A DESC.";
            // 
            // TB_puesto
            // 
            this.TB_puesto.Location = new System.Drawing.Point(80, 39);
            this.TB_puesto.Name = "TB_puesto";
            this.TB_puesto.Size = new System.Drawing.Size(350, 20);
            this.TB_puesto.TabIndex = 46;
            // 
            // TB_apellidos
            // 
            this.TB_apellidos.Location = new System.Drawing.Point(258, 8);
            this.TB_apellidos.Name = "TB_apellidos";
            this.TB_apellidos.Size = new System.Drawing.Size(172, 20);
            this.TB_apellidos.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 48;
            this.label7.Text = "CARGO";
            // 
            // CalificarGte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1018, 496);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TB_apellidos);
            this.Controls.Add(this.TB_puesto);
            this.Controls.Add(this.LB_totaldesc);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.LB_totalPagar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BT_calcular);
            this.Controls.Add(this.CB_gerente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CB_SUCURSAL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DT_fin);
            this.Controls.Add(this.DT_inicio);
            this.Controls.Add(this.BT_guardar);
            this.Controls.Add(this.DG_tabla);
            this.Name = "CalificarGte";
            this.Text = "Calificar Gerente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CalificarGte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_tabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DG_tabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn ASPECTOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CALIFICACION;
        private System.Windows.Forms.Button BT_guardar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DT_fin;
        private System.Windows.Forms.DateTimePicker DT_inicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CB_SUCURSAL;
        private System.Windows.Forms.ComboBox CB_gerente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL;
        private System.Windows.Forms.Button BT_calcular;
        private System.Windows.Forms.Label LB_totalPagar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LB_totaldesc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TB_puesto;
        private System.Windows.Forms.TextBox TB_apellidos;
        private System.Windows.Forms.Label label7;
    }
}