namespace appSugerencias
{
    partial class frm_pedido_almacen
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
            this.dgvReportes = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PEDIDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TITULO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LINK = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ALMACEN = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PISO_VENTA = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.REPORTE = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReportes
            // 
            this.dgvReportes.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvReportes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.PEDIDO,
            this.TITULO,
            this.LINK,
            this.ALMACEN,
            this.PISO_VENTA,
            this.REPORTE});
            this.dgvReportes.Location = new System.Drawing.Point(12, 59);
            this.dgvReportes.Name = "dgvReportes";
            this.dgvReportes.Size = new System.Drawing.Size(1067, 595);
            this.dgvReportes.TabIndex = 0;
            this.dgvReportes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReportes_CellContentClick);
            this.dgvReportes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReportes_CellDoubleClick);
            this.dgvReportes.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvReportes_CellMouseClick);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // PEDIDO
            // 
            this.PEDIDO.HeaderText = "PEDIDO";
            this.PEDIDO.Name = "PEDIDO";
            this.PEDIDO.Width = 90;
            // 
            // TITULO
            // 
            this.TITULO.HeaderText = "TITULO";
            this.TITULO.Name = "TITULO";
            this.TITULO.ReadOnly = true;
            this.TITULO.Width = 300;
            // 
            // LINK
            // 
            this.LINK.HeaderText = "LINK";
            this.LINK.Name = "LINK";
            this.LINK.ReadOnly = true;
            this.LINK.Width = 180;
            // 
            // ALMACEN
            // 
            this.ALMACEN.HeaderText = "PRODUCTO EN ALMACEN";
            this.ALMACEN.Name = "ALMACEN";
            this.ALMACEN.Width = 150;
            // 
            // PISO_VENTA
            // 
            this.PISO_VENTA.HeaderText = "EN PISO DE VENTA";
            this.PISO_VENTA.Name = "PISO_VENTA";
            this.PISO_VENTA.Width = 150;
            // 
            // REPORTE
            // 
            this.REPORTE.HeaderText = "REPORTE COMPLETADO";
            this.REPORTE.Name = "REPORTE";
            this.REPORTE.Width = 150;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(923, 660);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 64);
            this.button1.TabIndex = 1;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seguimiento de Pedidos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frm_pedido_almacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1102, 736);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvReportes);
            this.Name = "frm_pedido_almacen";
            this.Text = "Pedidos";
            this.Load += new System.EventHandler(this.frm_pedido_almacen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReportes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn PEDIDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TITULO;
        private System.Windows.Forms.DataGridViewLinkColumn LINK;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ALMACEN;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PISO_VENTA;
        private System.Windows.Forms.DataGridViewCheckBoxColumn REPORTE;
    }
}