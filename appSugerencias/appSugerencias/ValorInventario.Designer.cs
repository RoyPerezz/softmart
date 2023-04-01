namespace appSugerencias
{
    partial class ValorInventario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BT_buscar = new System.Windows.Forms.Button();
            this.DG_tabla = new System.Windows.Forms.DataGridView();
            this.SUCURSAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO_M = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COSTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BT_exportar = new System.Windows.Forms.Button();
            this.LB_va = new System.Windows.Forms.Label();
            this.LB_rena = new System.Windows.Forms.Label();
            this.LB_velazquez = new System.Windows.Forms.Label();
            this.LB_coloso = new System.Windows.Forms.Label();
            this.LB_cedis = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DG_tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // BT_buscar
            // 
            this.BT_buscar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_buscar.ForeColor = System.Drawing.Color.White;
            this.BT_buscar.Location = new System.Drawing.Point(629, 42);
            this.BT_buscar.Name = "BT_buscar";
            this.BT_buscar.Size = new System.Drawing.Size(152, 59);
            this.BT_buscar.TabIndex = 1;
            this.BT_buscar.Text = "Valor del Inventario";
            this.BT_buscar.UseVisualStyleBackColor = false;
            this.BT_buscar.Click += new System.EventHandler(this.BT_buscar_Click);
            // 
            // DG_tabla
            // 
            this.DG_tabla.AllowUserToAddRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.DG_tabla.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DG_tabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DG_tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SUCURSAL,
            this.PRECIO_M,
            this.COSTO});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DG_tabla.DefaultCellStyle = dataGridViewCellStyle8;
            this.DG_tabla.Location = new System.Drawing.Point(1, 42);
            this.DG_tabla.Name = "DG_tabla";
            this.DG_tabla.Size = new System.Drawing.Size(622, 190);
            this.DG_tabla.TabIndex = 2;
            // 
            // SUCURSAL
            // 
            this.SUCURSAL.HeaderText = "SUCURSAL";
            this.SUCURSAL.Name = "SUCURSAL";
            // 
            // PRECIO_M
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.PRECIO_M.DefaultCellStyle = dataGridViewCellStyle6;
            this.PRECIO_M.HeaderText = "PRECIO MAYOREO";
            this.PRECIO_M.Name = "PRECIO_M";
            // 
            // COSTO
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.COSTO.DefaultCellStyle = dataGridViewCellStyle7;
            this.COSTO.HeaderText = "COSTO";
            this.COSTO.Name = "COSTO";
            // 
            // BT_exportar
            // 
            this.BT_exportar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_exportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_exportar.ForeColor = System.Drawing.Color.White;
            this.BT_exportar.Location = new System.Drawing.Point(629, 173);
            this.BT_exportar.Name = "BT_exportar";
            this.BT_exportar.Size = new System.Drawing.Size(152, 59);
            this.BT_exportar.TabIndex = 3;
            this.BT_exportar.Text = "Exportar";
            this.BT_exportar.UseVisualStyleBackColor = false;
            this.BT_exportar.Click += new System.EventHandler(this.BT_exportar_Click);
            // 
            // LB_va
            // 
            this.LB_va.AutoSize = true;
            this.LB_va.ForeColor = System.Drawing.Color.DarkGray;
            this.LB_va.Location = new System.Drawing.Point(165, 9);
            this.LB_va.Name = "LB_va";
            this.LB_va.Size = new System.Drawing.Size(62, 13);
            this.LB_va.TabIndex = 4;
            this.LB_va.Text = "VALLARTA";
            // 
            // LB_rena
            // 
            this.LB_rena.AutoSize = true;
            this.LB_rena.ForeColor = System.Drawing.Color.DarkGray;
            this.LB_rena.Location = new System.Drawing.Point(258, 9);
            this.LB_rena.Name = "LB_rena";
            this.LB_rena.Size = new System.Drawing.Size(37, 13);
            this.LB_rena.TabIndex = 5;
            this.LB_rena.Text = "RENA";
            // 
            // LB_velazquez
            // 
            this.LB_velazquez.AutoSize = true;
            this.LB_velazquez.ForeColor = System.Drawing.Color.DarkGray;
            this.LB_velazquez.Location = new System.Drawing.Point(331, 9);
            this.LB_velazquez.Name = "LB_velazquez";
            this.LB_velazquez.Size = new System.Drawing.Size(71, 13);
            this.LB_velazquez.TabIndex = 6;
            this.LB_velazquez.Text = "VELAZQUEZ";
            // 
            // LB_coloso
            // 
            this.LB_coloso.AutoSize = true;
            this.LB_coloso.ForeColor = System.Drawing.Color.DarkGray;
            this.LB_coloso.Location = new System.Drawing.Point(425, 9);
            this.LB_coloso.Name = "LB_coloso";
            this.LB_coloso.Size = new System.Drawing.Size(51, 13);
            this.LB_coloso.TabIndex = 7;
            this.LB_coloso.Text = "COLOSO";
            // 
            // LB_cedis
            // 
            this.LB_cedis.AutoSize = true;
            this.LB_cedis.ForeColor = System.Drawing.Color.DarkGray;
            this.LB_cedis.Location = new System.Drawing.Point(105, 9);
            this.LB_cedis.Name = "LB_cedis";
            this.LB_cedis.Size = new System.Drawing.Size(39, 13);
            this.LB_cedis.TabIndex = 8;
            this.LB_cedis.Text = "CEDIS";
            // 
            // ValorInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(788, 249);
            this.Controls.Add(this.LB_cedis);
            this.Controls.Add(this.LB_coloso);
            this.Controls.Add(this.LB_velazquez);
            this.Controls.Add(this.LB_rena);
            this.Controls.Add(this.LB_va);
            this.Controls.Add(this.BT_exportar);
            this.Controls.Add(this.DG_tabla);
            this.Controls.Add(this.BT_buscar);
            this.Name = "ValorInventario";
            this.Text = "ValorInventario";
            this.Load += new System.EventHandler(this.ValorInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_tabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BT_buscar;
        private System.Windows.Forms.DataGridView DG_tabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUCURSAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO_M;
        private System.Windows.Forms.DataGridViewTextBoxColumn COSTO;
        private System.Windows.Forms.Button BT_exportar;
        private System.Windows.Forms.Label LB_va;
        private System.Windows.Forms.Label LB_rena;
        private System.Windows.Forms.Label LB_velazquez;
        private System.Windows.Forms.Label LB_coloso;
        private System.Windows.Forms.Label LB_cedis;
    }
}