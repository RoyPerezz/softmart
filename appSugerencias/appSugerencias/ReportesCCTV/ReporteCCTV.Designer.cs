namespace appSugerencias.ReportesCCTV
{
    partial class ReporteCCTV
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
            this.DT_inicio = new System.Windows.Forms.DateTimePicker();
            this.DT_fin = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BT_exportar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.LB_usuario = new System.Windows.Forms.Label();
            this.DG_tabla2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DG_tabla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_tabla2)).BeginInit();
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
            this.DG_tabla.Location = new System.Drawing.Point(63, 229);
            this.DG_tabla.Name = "DG_tabla";
            this.DG_tabla.Size = new System.Drawing.Size(227, 0);
            this.DG_tabla.TabIndex = 0;
            this.DG_tabla.Visible = false;
            // 
            // DT_inicio
            // 
            this.DT_inicio.Location = new System.Drawing.Point(62, 72);
            this.DT_inicio.Name = "DT_inicio";
            this.DT_inicio.Size = new System.Drawing.Size(228, 20);
            this.DT_inicio.TabIndex = 1;
            // 
            // DT_fin
            // 
            this.DT_fin.Location = new System.Drawing.Point(62, 107);
            this.DT_fin.Name = "DT_fin";
            this.DT_fin.Size = new System.Drawing.Size(228, 20);
            this.DT_fin.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "INICIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "FIN";
            // 
            // BT_exportar
            // 
            this.BT_exportar.Location = new System.Drawing.Point(63, 148);
            this.BT_exportar.Name = "BT_exportar";
            this.BT_exportar.Size = new System.Drawing.Size(227, 55);
            this.BT_exportar.TabIndex = 6;
            this.BT_exportar.Text = "GENERAR REPORTE EN EXCEL";
            this.BT_exportar.UseVisualStyleBackColor = true;
            this.BT_exportar.Click += new System.EventHandler(this.BT_exportar_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "USUARIO";
            // 
            // LB_usuario
            // 
            this.LB_usuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LB_usuario.AutoSize = true;
            this.LB_usuario.Location = new System.Drawing.Point(122, 27);
            this.LB_usuario.Name = "LB_usuario";
            this.LB_usuario.Size = new System.Drawing.Size(0, 13);
            this.LB_usuario.TabIndex = 8;
            // 
            // DG_tabla2
            // 
            this.DG_tabla2.AllowUserToAddRows = false;
            this.DG_tabla2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DG_tabla2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DG_tabla2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_tabla2.Location = new System.Drawing.Point(62, 209);
            this.DG_tabla2.Name = "DG_tabla2";
            this.DG_tabla2.Size = new System.Drawing.Size(227, 0);
            this.DG_tabla2.TabIndex = 9;
            this.DG_tabla2.Visible = false;
            // 
            // ReporteCCTV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 221);
            this.Controls.Add(this.DG_tabla2);
            this.Controls.Add(this.LB_usuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BT_exportar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DT_fin);
            this.Controls.Add(this.DT_inicio);
            this.Controls.Add(this.DG_tabla);
            this.Name = "ReporteCCTV";
            this.Text = "ReporteCCTV";
            this.Load += new System.EventHandler(this.ReporteCCTV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_tabla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_tabla2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DG_tabla;
        private System.Windows.Forms.DateTimePicker DT_inicio;
        private System.Windows.Forms.DateTimePicker DT_fin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BT_exportar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LB_usuario;
        private System.Windows.Forms.DataGridView DG_tabla2;
    }
}