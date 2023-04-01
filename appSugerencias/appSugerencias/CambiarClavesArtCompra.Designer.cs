namespace appSugerencias
{
    partial class CambiarClavesArtCompra
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
            this.DG_cambioClave = new System.Windows.Forms.DataGridView();
            this.DG_articulos = new System.Windows.Forms.DataGridView();
            this.CLAVE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BT_actualizar = new System.Windows.Forms.Button();
            this.TB_compra = new System.Windows.Forms.TextBox();
            this.LB_compra = new System.Windows.Forms.Label();
            this.ARTICULO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLAVE_NUEVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DG_cambioClave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_articulos)).BeginInit();
            this.SuspendLayout();
            // 
            // DG_cambioClave
            // 
            this.DG_cambioClave.AllowUserToAddRows = false;
            this.DG_cambioClave.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DG_cambioClave.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_cambioClave.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ARTICULO,
            this.DESCRIP,
            this.CLAVE_NUEVA});
            this.DG_cambioClave.Location = new System.Drawing.Point(466, 49);
            this.DG_cambioClave.Name = "DG_cambioClave";
            this.DG_cambioClave.Size = new System.Drawing.Size(677, 418);
            this.DG_cambioClave.TabIndex = 0;
            // 
            // DG_articulos
            // 
            this.DG_articulos.AllowUserToAddRows = false;
            this.DG_articulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DG_articulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_articulos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CLAVE,
            this.DESCRIPCION});
            this.DG_articulos.Location = new System.Drawing.Point(1, 49);
            this.DG_articulos.Name = "DG_articulos";
            this.DG_articulos.Size = new System.Drawing.Size(468, 418);
            this.DG_articulos.TabIndex = 1;
            this.DG_articulos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_articulos_CellContentDoubleClick);
            // 
            // CLAVE
            // 
            this.CLAVE.HeaderText = "CLAVE";
            this.CLAVE.Name = "CLAVE";
            // 
            // DESCRIPCION
            // 
            this.DESCRIPCION.HeaderText = "DESCRIPCION";
            this.DESCRIPCION.Name = "DESCRIPCION";
            // 
            // BT_actualizar
            // 
            this.BT_actualizar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_actualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_actualizar.ForeColor = System.Drawing.Color.White;
            this.BT_actualizar.Location = new System.Drawing.Point(1026, 473);
            this.BT_actualizar.Name = "BT_actualizar";
            this.BT_actualizar.Size = new System.Drawing.Size(117, 63);
            this.BT_actualizar.TabIndex = 2;
            this.BT_actualizar.Text = "CAMBIAR CLAVES";
            this.BT_actualizar.UseVisualStyleBackColor = false;
            this.BT_actualizar.Click += new System.EventHandler(this.BT_actualizar_Click);
            // 
            // TB_compra
            // 
            this.TB_compra.Location = new System.Drawing.Point(90, 12);
            this.TB_compra.Name = "TB_compra";
            this.TB_compra.Size = new System.Drawing.Size(100, 20);
            this.TB_compra.TabIndex = 3;
            // 
            // LB_compra
            // 
            this.LB_compra.AutoSize = true;
            this.LB_compra.Location = new System.Drawing.Point(31, 15);
            this.LB_compra.Name = "LB_compra";
            this.LB_compra.Size = new System.Drawing.Size(53, 13);
            this.LB_compra.TabIndex = 4;
            this.LB_compra.Text = "COMPRA";
            // 
            // ARTICULO
            // 
            this.ARTICULO.HeaderText = "ARTICULO";
            this.ARTICULO.Name = "ARTICULO";
            // 
            // DESCRIP
            // 
            this.DESCRIP.HeaderText = "DESCRIPCION";
            this.DESCRIP.Name = "DESCRIP";
            // 
            // CLAVE_NUEVA
            // 
            this.CLAVE_NUEVA.HeaderText = "CLAVE NUEVA";
            this.CLAVE_NUEVA.Name = "CLAVE_NUEVA";
            // 
            // CambiarClavesArtCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1146, 558);
            this.Controls.Add(this.LB_compra);
            this.Controls.Add(this.TB_compra);
            this.Controls.Add(this.BT_actualizar);
            this.Controls.Add(this.DG_articulos);
            this.Controls.Add(this.DG_cambioClave);
            this.Name = "CambiarClavesArtCompra";
            this.Text = "CambiarClavesArtCompra";
            this.Load += new System.EventHandler(this.CambiarClavesArtCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_cambioClave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_articulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DG_cambioClave;
        private System.Windows.Forms.DataGridView DG_articulos;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLAVE;
        private System.Windows.Forms.Button BT_actualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        public System.Windows.Forms.TextBox TB_compra;
        private System.Windows.Forms.Label LB_compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn ARTICULO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIP;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLAVE_NUEVA;
    }
}