namespace appSugerencias
{
    partial class KardexArticulos
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
            this.DG_Tabla = new System.Windows.Forms.DataGridView();
            this.BT_kardex = new System.Windows.Forms.Button();
            this.TB_articulo = new System.Windows.Forms.TextBox();
            this.DT_inicio = new System.Windows.Forms.DateTimePicker();
            this.DT_fin = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CB_sucursal = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LB_descripcion = new System.Windows.Forms.Label();
            this.BT_exportar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // DG_Tabla
            // 
            this.DG_Tabla.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DG_Tabla.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DG_Tabla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DG_Tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Tabla.Location = new System.Drawing.Point(1, 92);
            this.DG_Tabla.Name = "DG_Tabla";
            this.DG_Tabla.Size = new System.Drawing.Size(1096, 358);
            this.DG_Tabla.TabIndex = 0;
            // 
            // BT_kardex
            // 
            this.BT_kardex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_kardex.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_kardex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_kardex.ForeColor = System.Drawing.Color.White;
            this.BT_kardex.Location = new System.Drawing.Point(867, 18);
            this.BT_kardex.Name = "BT_kardex";
            this.BT_kardex.Size = new System.Drawing.Size(94, 47);
            this.BT_kardex.TabIndex = 1;
            this.BT_kardex.Text = "KARDEX";
            this.BT_kardex.UseVisualStyleBackColor = false;
            this.BT_kardex.Click += new System.EventHandler(this.BT_kardex_Click);
            // 
            // TB_articulo
            // 
            this.TB_articulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_articulo.Location = new System.Drawing.Point(182, 36);
            this.TB_articulo.Name = "TB_articulo";
            this.TB_articulo.Size = new System.Drawing.Size(197, 26);
            this.TB_articulo.TabIndex = 2;
            // 
            // DT_inicio
            // 
            this.DT_inicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DT_inicio.Location = new System.Drawing.Point(661, 18);
            this.DT_inicio.Name = "DT_inicio";
            this.DT_inicio.Size = new System.Drawing.Size(200, 20);
            this.DT_inicio.TabIndex = 3;
            // 
            // DT_fin
            // 
            this.DT_fin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DT_fin.Location = new System.Drawing.Point(661, 45);
            this.DT_fin.Name = "DT_fin";
            this.DT_fin.Size = new System.Drawing.Size(200, 20);
            this.DT_fin.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "CAPTURA EL CÓDIGO DEL ARTÍCULO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(622, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "INICIO";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(631, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "FIN";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CB_sucursal
            // 
            this.CB_sucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_sucursal.FormattingEnabled = true;
            this.CB_sucursal.Location = new System.Drawing.Point(12, 36);
            this.CB_sucursal.Name = "CB_sucursal";
            this.CB_sucursal.Size = new System.Drawing.Size(142, 28);
            this.CB_sucursal.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "SUCURSAL";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LB_descripcion
            // 
            this.LB_descripcion.AutoSize = true;
            this.LB_descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_descripcion.Location = new System.Drawing.Point(385, 39);
            this.LB_descripcion.Name = "LB_descripcion";
            this.LB_descripcion.Size = new System.Drawing.Size(0, 20);
            this.LB_descripcion.TabIndex = 10;
            this.LB_descripcion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BT_exportar
            // 
            this.BT_exportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_exportar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_exportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_exportar.ForeColor = System.Drawing.Color.White;
            this.BT_exportar.Location = new System.Drawing.Point(979, 18);
            this.BT_exportar.Name = "BT_exportar";
            this.BT_exportar.Size = new System.Drawing.Size(94, 47);
            this.BT_exportar.TabIndex = 11;
            this.BT_exportar.Text = "EXPORTAR";
            this.BT_exportar.UseVisualStyleBackColor = false;
            this.BT_exportar.Click += new System.EventHandler(this.BT_exportar_Click);
            // 
            // KardexArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1100, 450);
            this.Controls.Add(this.BT_exportar);
            this.Controls.Add(this.LB_descripcion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CB_sucursal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DT_fin);
            this.Controls.Add(this.DT_inicio);
            this.Controls.Add(this.TB_articulo);
            this.Controls.Add(this.BT_kardex);
            this.Controls.Add(this.DG_Tabla);
            this.Name = "KardexArticulos";
            this.Text = "KardexArticulos";
            this.Load += new System.EventHandler(this.KardexArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_Tabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DG_Tabla;
        private System.Windows.Forms.Button BT_kardex;
        private System.Windows.Forms.TextBox TB_articulo;
        private System.Windows.Forms.DateTimePicker DT_inicio;
        private System.Windows.Forms.DateTimePicker DT_fin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CB_sucursal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LB_descripcion;
        private System.Windows.Forms.Button BT_exportar;
    }
}