namespace appSugerencias
{
    partial class Rep_comisiones_gtes
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
            this.DG_tabla = new System.Windows.Forms.DataGridView();
            this.ASPECTOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALLARTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RENA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VELAZQUEZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COLOSO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.T_VALLARTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.T_RENA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.T_VELAZQUEZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.T_COLOSO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DT_inicio = new System.Windows.Forms.DateTimePicker();
            this.DT_fin = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BT_exportar = new System.Windows.Forms.Button();
            this.BT_buscar = new System.Windows.Forms.Button();
            this.TB_gte_va = new System.Windows.Forms.TextBox();
            this.TB_gte_re = new System.Windows.Forms.TextBox();
            this.TB_gte_ve = new System.Windows.Forms.TextBox();
            this.TB_gte_co = new System.Windows.Forms.TextBox();
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
            this.DG_tabla.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DG_tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ASPECTOS,
            this.VALOR,
            this.VALLARTA,
            this.RENA,
            this.VELAZQUEZ,
            this.COLOSO,
            this.T_VALLARTA,
            this.T_RENA,
            this.T_VELAZQUEZ,
            this.T_COLOSO});
            this.DG_tabla.Location = new System.Drawing.Point(0, 121);
            this.DG_tabla.Name = "DG_tabla";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DG_tabla.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DG_tabla.Size = new System.Drawing.Size(1337, 201);
            this.DG_tabla.TabIndex = 23;
            // 
            // ASPECTOS
            // 
            this.ASPECTOS.HeaderText = "ASPECTOS A CALIFICAR";
            this.ASPECTOS.Name = "ASPECTOS";
            // 
            // VALOR
            // 
            this.VALOR.HeaderText = "VALOR";
            this.VALOR.Name = "VALOR";
            // 
            // VALLARTA
            // 
            this.VALLARTA.HeaderText = "VALLARTA";
            this.VALLARTA.Name = "VALLARTA";
            // 
            // RENA
            // 
            this.RENA.HeaderText = "RENA";
            this.RENA.Name = "RENA";
            // 
            // VELAZQUEZ
            // 
            this.VELAZQUEZ.HeaderText = "VELAZQUEZ";
            this.VELAZQUEZ.Name = "VELAZQUEZ";
            // 
            // COLOSO
            // 
            this.COLOSO.HeaderText = "COLOSO";
            this.COLOSO.Name = "COLOSO";
            // 
            // T_VALLARTA
            // 
            this.T_VALLARTA.HeaderText = "TOTAL VALLARTA";
            this.T_VALLARTA.Name = "T_VALLARTA";
            // 
            // T_RENA
            // 
            this.T_RENA.HeaderText = "TOTAL RENA";
            this.T_RENA.Name = "T_RENA";
            // 
            // T_VELAZQUEZ
            // 
            this.T_VELAZQUEZ.HeaderText = "TOTAL VELAZQUEZ";
            this.T_VELAZQUEZ.Name = "T_VELAZQUEZ";
            // 
            // T_COLOSO
            // 
            this.T_COLOSO.HeaderText = "TOTAL COLOSO";
            this.T_COLOSO.Name = "T_COLOSO";
            // 
            // DT_inicio
            // 
            this.DT_inicio.Location = new System.Drawing.Point(90, 31);
            this.DT_inicio.Name = "DT_inicio";
            this.DT_inicio.Size = new System.Drawing.Size(200, 20);
            this.DT_inicio.TabIndex = 24;
            // 
            // DT_fin
            // 
            this.DT_fin.Location = new System.Drawing.Point(327, 31);
            this.DT_fin.Name = "DT_fin";
            this.DT_fin.Size = new System.Drawing.Size(200, 20);
            this.DT_fin.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "SEMANA DEL ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "AL";
            // 
            // BT_exportar
            // 
            this.BT_exportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_exportar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_exportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_exportar.ForeColor = System.Drawing.Color.White;
            this.BT_exportar.Location = new System.Drawing.Point(1236, 21);
            this.BT_exportar.Name = "BT_exportar";
            this.BT_exportar.Size = new System.Drawing.Size(91, 39);
            this.BT_exportar.TabIndex = 30;
            this.BT_exportar.Text = "EXPORTAR";
            this.BT_exportar.UseVisualStyleBackColor = false;
            this.BT_exportar.Click += new System.EventHandler(this.BT_exportar_Click);
            // 
            // BT_buscar
            // 
            this.BT_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_buscar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_buscar.ForeColor = System.Drawing.Color.White;
            this.BT_buscar.Location = new System.Drawing.Point(1139, 21);
            this.BT_buscar.Name = "BT_buscar";
            this.BT_buscar.Size = new System.Drawing.Size(91, 39);
            this.BT_buscar.TabIndex = 31;
            this.BT_buscar.Text = "BUSCAR";
            this.BT_buscar.UseVisualStyleBackColor = false;
            this.BT_buscar.Click += new System.EventHandler(this.BT_buscar_Click);
            // 
            // TB_gte_va
            // 
            this.TB_gte_va.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_gte_va.Location = new System.Drawing.Point(824, 95);
            this.TB_gte_va.Name = "TB_gte_va";
            this.TB_gte_va.Size = new System.Drawing.Size(112, 20);
            this.TB_gte_va.TabIndex = 32;
            this.TB_gte_va.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TB_gte_re
            // 
            this.TB_gte_re.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_gte_re.Location = new System.Drawing.Point(955, 95);
            this.TB_gte_re.Name = "TB_gte_re";
            this.TB_gte_re.Size = new System.Drawing.Size(112, 20);
            this.TB_gte_re.TabIndex = 33;
            this.TB_gte_re.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TB_gte_ve
            // 
            this.TB_gte_ve.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_gte_ve.Location = new System.Drawing.Point(1084, 95);
            this.TB_gte_ve.Name = "TB_gte_ve";
            this.TB_gte_ve.Size = new System.Drawing.Size(112, 20);
            this.TB_gte_ve.TabIndex = 34;
            this.TB_gte_ve.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TB_gte_co
            // 
            this.TB_gte_co.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_gte_co.Location = new System.Drawing.Point(1215, 95);
            this.TB_gte_co.Name = "TB_gte_co";
            this.TB_gte_co.Size = new System.Drawing.Size(112, 20);
            this.TB_gte_co.TabIndex = 35;
            this.TB_gte_co.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Rep_comisiones_gtes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1339, 545);
            this.Controls.Add(this.TB_gte_co);
            this.Controls.Add(this.TB_gte_ve);
            this.Controls.Add(this.TB_gte_re);
            this.Controls.Add(this.TB_gte_va);
            this.Controls.Add(this.BT_buscar);
            this.Controls.Add(this.BT_exportar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DT_fin);
            this.Controls.Add(this.DT_inicio);
            this.Controls.Add(this.DG_tabla);
            this.Name = "Rep_comisiones_gtes";
            this.Text = "Reporte de comisiones Gerentes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ComisionesJefes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_tabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DG_tabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn ASPECTOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALLARTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn RENA;
        private System.Windows.Forms.DataGridViewTextBoxColumn VELAZQUEZ;
        private System.Windows.Forms.DataGridViewTextBoxColumn COLOSO;
        private System.Windows.Forms.DataGridViewTextBoxColumn T_VALLARTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn T_RENA;
        private System.Windows.Forms.DataGridViewTextBoxColumn T_VELAZQUEZ;
        private System.Windows.Forms.DataGridViewTextBoxColumn T_COLOSO;
        private System.Windows.Forms.DateTimePicker DT_inicio;
        private System.Windows.Forms.DateTimePicker DT_fin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BT_exportar;
        private System.Windows.Forms.Button BT_buscar;
        private System.Windows.Forms.TextBox TB_gte_va;
        private System.Windows.Forms.TextBox TB_gte_re;
        private System.Windows.Forms.TextBox TB_gte_ve;
        private System.Windows.Forms.TextBox TB_gte_co;
    }
}