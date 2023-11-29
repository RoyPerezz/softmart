
namespace appSugerencias.Stock_Compras.Vista
{
    partial class FormatoAclaracionesTiendas
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
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MODELO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLAVE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PZXPAQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COSTO_OPAQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COSTO_PZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FALTANTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MEDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOBRANTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMPORTE_TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SURTIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CB_proveedor = new System.Windows.Forms.ComboBox();
            this.TB_id_proveedor = new System.Windows.Forms.TextBox();
            this.TB_id_stock = new System.Windows.Forms.TextBox();
            this.CB_stock = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BT_buscar = new System.Windows.Forms.Button();
            this.PB_imagen2 = new System.Windows.Forms.PictureBox();
            this.PB_imagen1 = new System.Windows.Forms.PictureBox();
            this.BT_guardar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BT_eliminar_img2 = new System.Windows.Forms.Button();
            this.BT_eliminar_img1 = new System.Windows.Forms.Button();
            this.BT_imagen2 = new System.Windows.Forms.Button();
            this.BT_img1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BT_calcular = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LB_sucursal = new System.Windows.Forms.Label();
            this.CB_sucursal = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DG_tabla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_imagen2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_imagen1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DG_tabla
            // 
            this.DG_tabla.AllowUserToAddRows = false;
            this.DG_tabla.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DG_tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.MODELO,
            this.CLAVE,
            this.DESCRIPCION,
            this.PZXPAQ,
            this.COSTO_OPAQ,
            this.COSTO_PZ,
            this.FALTANTE,
            this.MEDO,
            this.SOBRANTE,
            this.IMPORTE_TOTAL,
            this.SURTIO});
            this.DG_tabla.Location = new System.Drawing.Point(6, 93);
            this.DG_tabla.Name = "DG_tabla";
            this.DG_tabla.Size = new System.Drawing.Size(1142, 557);
            this.DG_tabla.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // MODELO
            // 
            this.MODELO.HeaderText = "MODELO";
            this.MODELO.Name = "MODELO";
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
            // PZXPAQ
            // 
            this.PZXPAQ.HeaderText = "PZ X PAQ";
            this.PZXPAQ.Name = "PZXPAQ";
            // 
            // COSTO_OPAQ
            // 
            this.COSTO_OPAQ.HeaderText = "COSTO X PAQ";
            this.COSTO_OPAQ.Name = "COSTO_OPAQ";
            // 
            // COSTO_PZ
            // 
            this.COSTO_PZ.HeaderText = "COSTO X PZ";
            this.COSTO_PZ.Name = "COSTO_PZ";
            // 
            // FALTANTE
            // 
            this.FALTANTE.HeaderText = "FALTANTE";
            this.FALTANTE.Name = "FALTANTE";
            // 
            // MEDO
            // 
            this.MEDO.HeaderText = "MAL EDO.";
            this.MEDO.Name = "MEDO";
            // 
            // SOBRANTE
            // 
            this.SOBRANTE.HeaderText = "SOBRANTE";
            this.SOBRANTE.Name = "SOBRANTE";
            // 
            // IMPORTE_TOTAL
            // 
            this.IMPORTE_TOTAL.HeaderText = "IMPORTE";
            this.IMPORTE_TOTAL.Name = "IMPORTE_TOTAL";
            // 
            // SURTIO
            // 
            this.SURTIO.HeaderText = "SURTIO";
            this.SURTIO.Name = "SURTIO";
            // 
            // CB_proveedor
            // 
            this.CB_proveedor.FormattingEnabled = true;
            this.CB_proveedor.Location = new System.Drawing.Point(111, 22);
            this.CB_proveedor.Name = "CB_proveedor";
            this.CB_proveedor.Size = new System.Drawing.Size(291, 21);
            this.CB_proveedor.TabIndex = 1;
            this.CB_proveedor.SelectedIndexChanged += new System.EventHandler(this.CB_proveedor_SelectedIndexChanged);
            // 
            // TB_id_proveedor
            // 
            this.TB_id_proveedor.Location = new System.Drawing.Point(408, 23);
            this.TB_id_proveedor.Name = "TB_id_proveedor";
            this.TB_id_proveedor.Size = new System.Drawing.Size(61, 20);
            this.TB_id_proveedor.TabIndex = 2;
            // 
            // TB_id_stock
            // 
            this.TB_id_stock.Location = new System.Drawing.Point(408, 50);
            this.TB_id_stock.Name = "TB_id_stock";
            this.TB_id_stock.Size = new System.Drawing.Size(61, 20);
            this.TB_id_stock.TabIndex = 4;
            // 
            // CB_stock
            // 
            this.CB_stock.FormattingEnabled = true;
            this.CB_stock.Location = new System.Drawing.Point(111, 49);
            this.CB_stock.Name = "CB_stock";
            this.CB_stock.Size = new System.Drawing.Size(291, 21);
            this.CB_stock.TabIndex = 3;
            this.CB_stock.SelectedIndexChanged += new System.EventHandler(this.CB_stock_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-361, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "PROVEEDOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-329, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "STOCK";
            // 
            // BT_buscar
            // 
            this.BT_buscar.Location = new System.Drawing.Point(485, 23);
            this.BT_buscar.Name = "BT_buscar";
            this.BT_buscar.Size = new System.Drawing.Size(104, 45);
            this.BT_buscar.TabIndex = 7;
            this.BT_buscar.Text = "Buscar";
            this.BT_buscar.UseVisualStyleBackColor = true;
            this.BT_buscar.Click += new System.EventHandler(this.BT_buscar_Click);
            // 
            // PB_imagen2
            // 
            this.PB_imagen2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PB_imagen2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.PB_imagen2.Location = new System.Drawing.Point(291, 352);
            this.PB_imagen2.Name = "PB_imagen2";
            this.PB_imagen2.Size = new System.Drawing.Size(430, 315);
            this.PB_imagen2.TabIndex = 8;
            this.PB_imagen2.TabStop = false;
            // 
            // PB_imagen1
            // 
            this.PB_imagen1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PB_imagen1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.PB_imagen1.Location = new System.Drawing.Point(6, 19);
            this.PB_imagen1.Name = "PB_imagen1";
            this.PB_imagen1.Size = new System.Drawing.Size(715, 327);
            this.PB_imagen1.TabIndex = 9;
            this.PB_imagen1.TabStop = false;
            // 
            // BT_guardar
            // 
            this.BT_guardar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BT_guardar.Location = new System.Drawing.Point(705, 23);
            this.BT_guardar.Name = "BT_guardar";
            this.BT_guardar.Size = new System.Drawing.Size(104, 45);
            this.BT_guardar.TabIndex = 10;
            this.BT_guardar.Text = "Guardar";
            this.BT_guardar.UseVisualStyleBackColor = false;
            this.BT_guardar.Click += new System.EventHandler(this.BT_guardar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.BT_eliminar_img2);
            this.groupBox1.Controls.Add(this.BT_eliminar_img1);
            this.groupBox1.Controls.Add(this.BT_imagen2);
            this.groupBox1.Controls.Add(this.BT_img1);
            this.groupBox1.Controls.Add(this.PB_imagen1);
            this.groupBox1.Controls.Add(this.PB_imagen2);
            this.groupBox1.Location = new System.Drawing.Point(1172, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(727, 673);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Imagenes";
            // 
            // BT_eliminar_img2
            // 
            this.BT_eliminar_img2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_eliminar_img2.Location = new System.Drawing.Point(124, 632);
            this.BT_eliminar_img2.Name = "BT_eliminar_img2";
            this.BT_eliminar_img2.Size = new System.Drawing.Size(149, 35);
            this.BT_eliminar_img2.TabIndex = 16;
            this.BT_eliminar_img2.Text = "Eliminar imagen 2";
            this.BT_eliminar_img2.UseVisualStyleBackColor = true;
            this.BT_eliminar_img2.Click += new System.EventHandler(this.BT_eliminar_img2_Click);
            // 
            // BT_eliminar_img1
            // 
            this.BT_eliminar_img1.Location = new System.Drawing.Point(6, 393);
            this.BT_eliminar_img1.Name = "BT_eliminar_img1";
            this.BT_eliminar_img1.Size = new System.Drawing.Size(149, 35);
            this.BT_eliminar_img1.TabIndex = 15;
            this.BT_eliminar_img1.Text = "Eliminar imagen 1";
            this.BT_eliminar_img1.UseVisualStyleBackColor = true;
            this.BT_eliminar_img1.Click += new System.EventHandler(this.BT_eliminar_img1_Click);
            // 
            // BT_imagen2
            // 
            this.BT_imagen2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_imagen2.Location = new System.Drawing.Point(125, 592);
            this.BT_imagen2.Name = "BT_imagen2";
            this.BT_imagen2.Size = new System.Drawing.Size(149, 35);
            this.BT_imagen2.TabIndex = 14;
            this.BT_imagen2.Text = "Imagen2";
            this.BT_imagen2.UseVisualStyleBackColor = true;
            this.BT_imagen2.Click += new System.EventHandler(this.BT_imagen2_Click);
            // 
            // BT_img1
            // 
            this.BT_img1.Location = new System.Drawing.Point(6, 352);
            this.BT_img1.Name = "BT_img1";
            this.BT_img1.Size = new System.Drawing.Size(149, 35);
            this.BT_img1.TabIndex = 13;
            this.BT_img1.Text = "Imagen1";
            this.BT_img1.UseVisualStyleBackColor = true;
            this.BT_img1.Click += new System.EventHandler(this.BT_img1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.LB_sucursal);
            this.groupBox2.Controls.Add(this.CB_sucursal);
            this.groupBox2.Controls.Add(this.BT_calcular);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.BT_guardar);
            this.groupBox2.Controls.Add(this.DG_tabla);
            this.groupBox2.Controls.Add(this.CB_proveedor);
            this.groupBox2.Controls.Add(this.BT_buscar);
            this.groupBox2.Controls.Add(this.TB_id_proveedor);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.CB_stock);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.TB_id_stock);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1154, 673);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reporte";
            // 
            // BT_calcular
            // 
            this.BT_calcular.Location = new System.Drawing.Point(595, 23);
            this.BT_calcular.Name = "BT_calcular";
            this.BT_calcular.Size = new System.Drawing.Size(104, 45);
            this.BT_calcular.TabIndex = 13;
            this.BT_calcular.Text = "Calcular";
            this.BT_calcular.UseVisualStyleBackColor = true;
            this.BT_calcular.Click += new System.EventHandler(this.BT_calcular_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "STOCK";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "PROVEEDOR";
            // 
            // LB_sucursal
            // 
            this.LB_sucursal.AutoSize = true;
            this.LB_sucursal.Location = new System.Drawing.Point(883, 27);
            this.LB_sucursal.Name = "LB_sucursal";
            this.LB_sucursal.Size = new System.Drawing.Size(65, 13);
            this.LB_sucursal.TabIndex = 15;
            this.LB_sucursal.Text = "SUCURSAL";
            this.LB_sucursal.Visible = false;
            // 
            // CB_sucursal
            // 
            this.CB_sucursal.FormattingEnabled = true;
            this.CB_sucursal.Items.AddRange(new object[] {
            "CEDIS",
            "VALLARTA",
            "RENA",
            "VELAZQUEZ",
            "COLOSO"});
            this.CB_sucursal.Location = new System.Drawing.Point(963, 23);
            this.CB_sucursal.Name = "CB_sucursal";
            this.CB_sucursal.Size = new System.Drawing.Size(185, 21);
            this.CB_sucursal.TabIndex = 14;
            this.CB_sucursal.Visible = false;
            // 
            // FormatoAclaracionesTiendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1911, 697);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormatoAclaracionesTiendas";
            this.Text = "FormatoAclaracionesAlmace";
            this.Load += new System.EventHandler(this.FormatoAclaracionesTiendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_tabla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_imagen2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_imagen1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DG_tabla;
        private System.Windows.Forms.ComboBox CB_proveedor;
        private System.Windows.Forms.TextBox TB_id_proveedor;
        private System.Windows.Forms.TextBox TB_id_stock;
        private System.Windows.Forms.ComboBox CB_stock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BT_buscar;
        private System.Windows.Forms.PictureBox PB_imagen2;
        private System.Windows.Forms.PictureBox PB_imagen1;
        private System.Windows.Forms.Button BT_guardar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BT_eliminar_img2;
        private System.Windows.Forms.Button BT_eliminar_img1;
        private System.Windows.Forms.Button BT_imagen2;
        private System.Windows.Forms.Button BT_img1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BT_calcular;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MODELO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLAVE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn PZXPAQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn COSTO_OPAQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn COSTO_PZ;
        private System.Windows.Forms.DataGridViewTextBoxColumn FALTANTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn MEDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOBRANTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMPORTE_TOTAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn SURTIO;
        private System.Windows.Forms.Label LB_sucursal;
        private System.Windows.Forms.ComboBox CB_sucursal;
    }
}