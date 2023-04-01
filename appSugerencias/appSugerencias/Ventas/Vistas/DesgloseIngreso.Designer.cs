
namespace appSugerencias.Ventas.Vistas
{
    partial class DesgloseIngreso
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
            this.label1 = new System.Windows.Forms.Label();
            this.LB_concepto = new System.Windows.Forms.Label();
            this.LB_fecha = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IMPORTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DG_tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // DG_tabla
            // 
            this.DG_tabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DG_tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IMPORTE});
            this.DG_tabla.Location = new System.Drawing.Point(3, 85);
            this.DG_tabla.Name = "DG_tabla";
            this.DG_tabla.Size = new System.Drawing.Size(226, 363);
            this.DG_tabla.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "CONCEPTO";
            // 
            // LB_concepto
            // 
            this.LB_concepto.AutoSize = true;
            this.LB_concepto.Location = new System.Drawing.Point(90, 21);
            this.LB_concepto.Name = "LB_concepto";
            this.LB_concepto.Size = new System.Drawing.Size(0, 13);
            this.LB_concepto.TabIndex = 2;
            // 
            // LB_fecha
            // 
            this.LB_fecha.AutoSize = true;
            this.LB_fecha.Location = new System.Drawing.Point(90, 44);
            this.LB_fecha.Name = "LB_fecha";
            this.LB_fecha.Size = new System.Drawing.Size(0, 13);
            this.LB_fecha.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "FECHA";
            // 
            // IMPORTE
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.IMPORTE.DefaultCellStyle = dataGridViewCellStyle1;
            this.IMPORTE.HeaderText = "IMPORTE";
            this.IMPORTE.Name = "IMPORTE";
            // 
            // DesgloseIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 450);
            this.Controls.Add(this.LB_fecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LB_concepto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DG_tabla);
            this.Name = "DesgloseIngreso";
            this.Text = "DesgloseIngreso";
            this.Load += new System.EventHandler(this.DesgloseIngreso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_tabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DG_tabla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LB_concepto;
        private System.Windows.Forms.Label LB_fecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMPORTE;
    }
}