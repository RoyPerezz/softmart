namespace appSugerencias
{
    partial class Rep_comisionesJefeAlmacen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BT_buscar = new System.Windows.Forms.Button();
            this.BT_exportar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DT_fin = new System.Windows.Forms.DateTimePicker();
            this.DT_inicio = new System.Windows.Forms.DateTimePicker();
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
            ((System.ComponentModel.ISupportInitialize)(this.DG_tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // BT_buscar
            // 
            this.BT_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_buscar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_buscar.ForeColor = System.Drawing.Color.White;
            this.BT_buscar.Location = new System.Drawing.Point(1026, 22);
            this.BT_buscar.Name = "BT_buscar";
            this.BT_buscar.Size = new System.Drawing.Size(91, 39);
            this.BT_buscar.TabIndex = 42;
            this.BT_buscar.Text = "BUSCAR";
            this.BT_buscar.UseVisualStyleBackColor = false;
            this.BT_buscar.Click += new System.EventHandler(this.BT_buscar_Click);
            // 
            // BT_exportar
            // 
            this.BT_exportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_exportar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_exportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_exportar.ForeColor = System.Drawing.Color.White;
            this.BT_exportar.Location = new System.Drawing.Point(1123, 22);
            this.BT_exportar.Name = "BT_exportar";
            this.BT_exportar.Size = new System.Drawing.Size(91, 39);
            this.BT_exportar.TabIndex = 41;
            this.BT_exportar.Text = "EXPORTAR";
            this.BT_exportar.UseVisualStyleBackColor = false;
            this.BT_exportar.Click += new System.EventHandler(this.BT_exportar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "AL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "SEMANA DEL ";
            // 
            // DT_fin
            // 
            this.DT_fin.Location = new System.Drawing.Point(326, 31);
            this.DT_fin.Name = "DT_fin";
            this.DT_fin.Size = new System.Drawing.Size(200, 20);
            this.DT_fin.TabIndex = 38;
            // 
            // DT_inicio
            // 
            this.DT_inicio.Location = new System.Drawing.Point(89, 31);
            this.DT_inicio.Name = "DT_inicio";
            this.DT_inicio.Size = new System.Drawing.Size(200, 20);
            this.DT_inicio.TabIndex = 37;
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
            this.DG_tabla.Location = new System.Drawing.Point(1, 66);
            this.DG_tabla.Name = "DG_tabla";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DG_tabla.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DG_tabla.Size = new System.Drawing.Size(1224, 397);
            this.DG_tabla.TabIndex = 36;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.T_VALLARTA.DefaultCellStyle = dataGridViewCellStyle1;
            this.T_VALLARTA.HeaderText = "TOTAL VALLARTA";
            this.T_VALLARTA.Name = "T_VALLARTA";
            // 
            // T_RENA
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.T_RENA.DefaultCellStyle = dataGridViewCellStyle2;
            this.T_RENA.HeaderText = "TOTAL RENA";
            this.T_RENA.Name = "T_RENA";
            // 
            // T_VELAZQUEZ
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.T_VELAZQUEZ.DefaultCellStyle = dataGridViewCellStyle3;
            this.T_VELAZQUEZ.HeaderText = "TOTAL VELAZQUEZ";
            this.T_VELAZQUEZ.Name = "T_VELAZQUEZ";
            // 
            // T_COLOSO
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.T_COLOSO.DefaultCellStyle = dataGridViewCellStyle4;
            this.T_COLOSO.HeaderText = "TOTAL COLOSO";
            this.T_COLOSO.Name = "T_COLOSO";
            // 
            // Rep_comisionesJefeAlmacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1226, 467);
            this.Controls.Add(this.BT_buscar);
            this.Controls.Add(this.BT_exportar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DT_fin);
            this.Controls.Add(this.DT_inicio);
            this.Controls.Add(this.DG_tabla);
            this.Name = "Rep_comisionesJefeAlmacen";
            this.Text = "Rep_comisionesJefeAlmacen";
            this.Load += new System.EventHandler(this.Rep_comisionesJefeAlmacen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_tabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BT_buscar;
        private System.Windows.Forms.Button BT_exportar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DT_fin;
        private System.Windows.Forms.DateTimePicker DT_inicio;
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
    }
}