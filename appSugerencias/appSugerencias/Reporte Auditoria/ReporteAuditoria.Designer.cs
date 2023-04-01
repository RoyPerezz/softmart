
namespace appSugerencias
{
    partial class ReporteAuditoria
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
            this.CB_modulo = new System.Windows.Forms.ComboBox();
            this.DT_inicio = new System.Windows.Forms.DateTimePicker();
            this.DT_fin = new System.Windows.Forms.DateTimePicker();
            this.BT_reporte = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DG_tabla = new System.Windows.Forms.DataGridView();
            this.BT_exportar = new System.Windows.Forms.Button();
            this.CB_sucursales = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DG_tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // CB_modulo
            // 
            this.CB_modulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_modulo.FormattingEnabled = true;
            this.CB_modulo.Location = new System.Drawing.Point(12, 38);
            this.CB_modulo.Name = "CB_modulo";
            this.CB_modulo.Size = new System.Drawing.Size(574, 33);
            this.CB_modulo.TabIndex = 0;
            this.CB_modulo.SelectedIndexChanged += new System.EventHandler(this.CB_modulo_SelectedIndexChanged);
            // 
            // DT_inicio
            // 
            this.DT_inicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DT_inicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DT_inicio.Location = new System.Drawing.Point(1015, 6);
            this.DT_inicio.Name = "DT_inicio";
            this.DT_inicio.Size = new System.Drawing.Size(330, 26);
            this.DT_inicio.TabIndex = 1;
            // 
            // DT_fin
            // 
            this.DT_fin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DT_fin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DT_fin.Location = new System.Drawing.Point(1015, 38);
            this.DT_fin.Name = "DT_fin";
            this.DT_fin.Size = new System.Drawing.Size(330, 26);
            this.DT_fin.TabIndex = 2;
            // 
            // BT_reporte
            // 
            this.BT_reporte.Location = new System.Drawing.Point(12, 82);
            this.BT_reporte.Name = "BT_reporte";
            this.BT_reporte.Size = new System.Drawing.Size(97, 40);
            this.BT_reporte.TabIndex = 3;
            this.BT_reporte.Text = "Generar Reporte";
            this.BT_reporte.UseVisualStyleBackColor = true;
            this.BT_reporte.Click += new System.EventHandler(this.BT_reporte_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(974, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "INICIO";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(988, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "FIN";
            // 
            // DG_tabla
            // 
            this.DG_tabla.AllowUserToAddRows = false;
            this.DG_tabla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DG_tabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DG_tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_tabla.Location = new System.Drawing.Point(12, 128);
            this.DG_tabla.Name = "DG_tabla";
            this.DG_tabla.Size = new System.Drawing.Size(1333, 441);
            this.DG_tabla.TabIndex = 6;
            this.DG_tabla.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_tabla_CellContentDoubleClick);
            // 
            // BT_exportar
            // 
            this.BT_exportar.Location = new System.Drawing.Point(115, 82);
            this.BT_exportar.Name = "BT_exportar";
            this.BT_exportar.Size = new System.Drawing.Size(97, 40);
            this.BT_exportar.TabIndex = 7;
            this.BT_exportar.Text = "Exportar";
            this.BT_exportar.UseVisualStyleBackColor = true;
            this.BT_exportar.Click += new System.EventHandler(this.BT_exportar_Click);
            // 
            // CB_sucursales
            // 
            this.CB_sucursales.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_sucursales.FormattingEnabled = true;
            this.CB_sucursales.Location = new System.Drawing.Point(592, 38);
            this.CB_sucursales.Name = "CB_sucursales";
            this.CB_sucursales.Size = new System.Drawing.Size(195, 33);
            this.CB_sucursales.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "MODULO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(592, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "SUCURSAL";
            // 
            // ReporteAuditoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 581);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CB_sucursales);
            this.Controls.Add(this.BT_exportar);
            this.Controls.Add(this.DG_tabla);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BT_reporte);
            this.Controls.Add(this.DT_fin);
            this.Controls.Add(this.DT_inicio);
            this.Controls.Add(this.CB_modulo);
            this.Name = "ReporteAuditoria";
            this.Text = "ReporteAuditoria";
            this.Load += new System.EventHandler(this.ReporteAuditoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_tabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CB_modulo;
        private System.Windows.Forms.DateTimePicker DT_inicio;
        private System.Windows.Forms.DateTimePicker DT_fin;
        private System.Windows.Forms.Button BT_reporte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DG_tabla;
        private System.Windows.Forms.Button BT_exportar;
        private System.Windows.Forms.ComboBox CB_sucursales;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}