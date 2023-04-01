
namespace appSugerencias.Gastos.Vistas
{
    partial class DesgloseEgresos
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
            this.LB_etiqueta_tipoEgreso = new System.Windows.Forms.Label();
            this.LB_tipoEgreso = new System.Windows.Forms.Label();
            this.LB_gral = new System.Windows.Forms.Label();
            this.LB_etiqueta_conceptoGral = new System.Windows.Forms.Label();
            this.LB_detalle = new System.Windows.Forms.Label();
            this.LB_etiqueta_conceptoDetalle = new System.Windows.Forms.Label();
            this.LB_total = new System.Windows.Forms.Label();
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
            this.DG_tabla.Location = new System.Drawing.Point(12, 93);
            this.DG_tabla.Name = "DG_tabla";
            this.DG_tabla.Size = new System.Drawing.Size(776, 313);
            this.DG_tabla.TabIndex = 0;
            // 
            // LB_etiqueta_tipoEgreso
            // 
            this.LB_etiqueta_tipoEgreso.AutoSize = true;
            this.LB_etiqueta_tipoEgreso.Location = new System.Drawing.Point(31, 29);
            this.LB_etiqueta_tipoEgreso.Name = "LB_etiqueta_tipoEgreso";
            this.LB_etiqueta_tipoEgreso.Size = new System.Drawing.Size(67, 13);
            this.LB_etiqueta_tipoEgreso.TabIndex = 1;
            this.LB_etiqueta_tipoEgreso.Text = "Tipo Egreso:";
            // 
            // LB_tipoEgreso
            // 
            this.LB_tipoEgreso.AutoSize = true;
            this.LB_tipoEgreso.Location = new System.Drawing.Point(109, 33);
            this.LB_tipoEgreso.Name = "LB_tipoEgreso";
            this.LB_tipoEgreso.Size = new System.Drawing.Size(0, 13);
            this.LB_tipoEgreso.TabIndex = 2;
            // 
            // LB_gral
            // 
            this.LB_gral.AutoSize = true;
            this.LB_gral.Location = new System.Drawing.Point(109, 55);
            this.LB_gral.Name = "LB_gral";
            this.LB_gral.Size = new System.Drawing.Size(0, 13);
            this.LB_gral.TabIndex = 4;
            // 
            // LB_etiqueta_conceptoGral
            // 
            this.LB_etiqueta_conceptoGral.AutoSize = true;
            this.LB_etiqueta_conceptoGral.Location = new System.Drawing.Point(22, 51);
            this.LB_etiqueta_conceptoGral.Name = "LB_etiqueta_conceptoGral";
            this.LB_etiqueta_conceptoGral.Size = new System.Drawing.Size(76, 13);
            this.LB_etiqueta_conceptoGral.TabIndex = 3;
            this.LB_etiqueta_conceptoGral.Text = "Concepto gral:";
            // 
            // LB_detalle
            // 
            this.LB_detalle.AutoSize = true;
            this.LB_detalle.Location = new System.Drawing.Point(110, 75);
            this.LB_detalle.Name = "LB_detalle";
            this.LB_detalle.Size = new System.Drawing.Size(0, 13);
            this.LB_detalle.TabIndex = 6;
            // 
            // LB_etiqueta_conceptoDetalle
            // 
            this.LB_etiqueta_conceptoDetalle.AutoSize = true;
            this.LB_etiqueta_conceptoDetalle.Location = new System.Drawing.Point(8, 74);
            this.LB_etiqueta_conceptoDetalle.Name = "LB_etiqueta_conceptoDetalle";
            this.LB_etiqueta_conceptoDetalle.Size = new System.Drawing.Size(90, 13);
            this.LB_etiqueta_conceptoDetalle.TabIndex = 5;
            this.LB_etiqueta_conceptoDetalle.Text = "Concepto detalle:";
            // 
            // LB_total
            // 
            this.LB_total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LB_total.AutoSize = true;
            this.LB_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_total.ForeColor = System.Drawing.Color.Green;
            this.LB_total.Location = new System.Drawing.Point(666, 64);
            this.LB_total.Name = "LB_total";
            this.LB_total.Size = new System.Drawing.Size(119, 24);
            this.LB_total.TabIndex = 7;
            this.LB_total.Text = "Tipo Egreso:";
            // 
            // DesgloseEgresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LB_total);
            this.Controls.Add(this.LB_detalle);
            this.Controls.Add(this.LB_etiqueta_conceptoDetalle);
            this.Controls.Add(this.LB_gral);
            this.Controls.Add(this.LB_etiqueta_conceptoGral);
            this.Controls.Add(this.LB_tipoEgreso);
            this.Controls.Add(this.LB_etiqueta_tipoEgreso);
            this.Controls.Add(this.DG_tabla);
            this.Name = "DesgloseEgresos";
            this.Text = "DesgloseEgresos";
            this.Load += new System.EventHandler(this.DesgloseEgresos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_tabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DG_tabla;
        private System.Windows.Forms.Label LB_etiqueta_tipoEgreso;
        private System.Windows.Forms.Label LB_tipoEgreso;
        private System.Windows.Forms.Label LB_gral;
        private System.Windows.Forms.Label LB_etiqueta_conceptoGral;
        private System.Windows.Forms.Label LB_detalle;
        private System.Windows.Forms.Label LB_etiqueta_conceptoDetalle;
        private System.Windows.Forms.Label LB_total;
    }
}