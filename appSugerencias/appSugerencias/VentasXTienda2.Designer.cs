﻿namespace appSugerencias
{
    partial class VentasXTienda2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentasXTienda2));
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.BT_exportar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.FECHA_VA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALLARTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_RENA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RENA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_VELAZQUEZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VELAZQUEZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_COLOSO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COLOSO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVentas
            // 
            this.dgvVentas.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvVentas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FECHA_VA,
            this.VALLARTA,
            this.FECHA_RENA,
            this.RENA,
            this.FECHA_VELAZQUEZ,
            this.VELAZQUEZ,
            this.FECHA_COLOSO,
            this.COLOSO});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVentas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVentas.Location = new System.Drawing.Point(6, 102);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.Size = new System.Drawing.Size(943, 476);
            this.dgvVentas.TabIndex = 0;
            this.dgvVentas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvVentas_CellFormatting);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Reporte de Ventas  de  Sucursales por Dia";
            // 
            // BT_exportar
            // 
            this.BT_exportar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_exportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_exportar.ForeColor = System.Drawing.Color.White;
            this.BT_exportar.Image = ((System.Drawing.Image)(resources.GetObject("BT_exportar.Image")));
            this.BT_exportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_exportar.Location = new System.Drawing.Point(837, 36);
            this.BT_exportar.Name = "BT_exportar";
            this.BT_exportar.Size = new System.Drawing.Size(112, 51);
            this.BT_exportar.TabIndex = 5;
            this.BT_exportar.Text = "Exportar";
            this.BT_exportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BT_exportar.UseVisualStyleBackColor = false;
            this.BT_exportar.Click += new System.EventHandler(this.BT_exportar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(685, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 51);
            this.button1.TabIndex = 6;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FECHA_VA
            // 
            this.FECHA_VA.HeaderText = "FECHA VALLARTA";
            this.FECHA_VA.Name = "FECHA_VA";
            this.FECHA_VA.ReadOnly = true;
            // 
            // VALLARTA
            // 
            this.VALLARTA.HeaderText = "VALLARTA";
            this.VALLARTA.Name = "VALLARTA";
            this.VALLARTA.ReadOnly = true;
            // 
            // FECHA_RENA
            // 
            this.FECHA_RENA.HeaderText = "FECHA RENA";
            this.FECHA_RENA.Name = "FECHA_RENA";
            this.FECHA_RENA.ReadOnly = true;
            // 
            // RENA
            // 
            this.RENA.HeaderText = "RENA";
            this.RENA.Name = "RENA";
            this.RENA.ReadOnly = true;
            // 
            // FECHA_VELAZQUEZ
            // 
            this.FECHA_VELAZQUEZ.HeaderText = "FECHA VELAZQUEZ";
            this.FECHA_VELAZQUEZ.Name = "FECHA_VELAZQUEZ";
            this.FECHA_VELAZQUEZ.ReadOnly = true;
            // 
            // VELAZQUEZ
            // 
            this.VELAZQUEZ.HeaderText = "VELAZQUEZ";
            this.VELAZQUEZ.Name = "VELAZQUEZ";
            this.VELAZQUEZ.ReadOnly = true;
            // 
            // FECHA_COLOSO
            // 
            this.FECHA_COLOSO.HeaderText = "FECHA COLOSO";
            this.FECHA_COLOSO.Name = "FECHA_COLOSO";
            this.FECHA_COLOSO.ReadOnly = true;
            // 
            // COLOSO
            // 
            this.COLOSO.HeaderText = "COLOSO";
            this.COLOSO.Name = "COLOSO";
            this.COLOSO.ReadOnly = true;
            // 
            // VentasXTienda2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(964, 599);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BT_exportar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvVentas);
            this.Name = "VentasXTienda2";
            this.Text = "VentasXTienda2";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BT_exportar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_VA;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALLARTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_RENA;
        private System.Windows.Forms.DataGridViewTextBoxColumn RENA;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_VELAZQUEZ;
        private System.Windows.Forms.DataGridViewTextBoxColumn VELAZQUEZ;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_COLOSO;
        private System.Windows.Forms.DataGridViewTextBoxColumn COLOSO;
    }
}