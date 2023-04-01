namespace appSugerencias
{
    partial class DevolucionesCompras
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
            this.label1 = new System.Windows.Forms.Label();
            this.CB_sucursal = new System.Windows.Forms.ComboBox();
            this.CB_proveedores = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_proveedor = new System.Windows.Forms.TextBox();
            this.CB_compra = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_factura = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TB_importe = new System.Windows.Forms.TextBox();
            this.DG_tabla = new System.Windows.Forms.DataGridView();
            this.BT_quitar = new System.Windows.Forms.Button();
            this.BT_devolver = new System.Windows.Forms.Button();
            this.BT_compra = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.TB_dgFiltro = new System.Windows.Forms.TextBox();
            this.DG_devolucion = new System.Windows.Forms.DataGridView();
            this.ARTICULO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COSTO_U = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMPUESTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMPORTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHK_parcial = new System.Windows.Forms.CheckBox();
            this.TB_importeTotal = new System.Windows.Forms.TextBox();
            this.TB_importeTotal2 = new System.Windows.Forms.TextBox();
            this.BT_calcular = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.TB_observacion = new System.Windows.Forms.TextBox();
            this.BT_cambiarClaves = new System.Windows.Forms.Button();
            this.BT_CambiarProveedor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DG_tabla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_devolucion)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "SUCURSAL";
            // 
            // CB_sucursal
            // 
            this.CB_sucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_sucursal.FormattingEnabled = true;
            this.CB_sucursal.Items.AddRange(new object[] {
            "BODEGA",
            "VALLARTA",
            "RENA",
            "VELAZQUEZ",
            "COLOSO",
            "PREGOT"});
            this.CB_sucursal.Location = new System.Drawing.Point(98, 21);
            this.CB_sucursal.Name = "CB_sucursal";
            this.CB_sucursal.Size = new System.Drawing.Size(133, 24);
            this.CB_sucursal.TabIndex = 1;
            this.CB_sucursal.SelectedIndexChanged += new System.EventHandler(this.CB_sucursal_SelectedIndexChanged);
            // 
            // CB_proveedores
            // 
            this.CB_proveedores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CB_proveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_proveedores.FormattingEnabled = true;
            this.CB_proveedores.Location = new System.Drawing.Point(450, 21);
            this.CB_proveedores.Name = "CB_proveedores";
            this.CB_proveedores.Size = new System.Drawing.Size(419, 24);
            this.CB_proveedores.TabIndex = 3;
            this.CB_proveedores.SelectedIndexChanged += new System.EventHandler(this.CB_proveedores_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(350, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "PROVEEDOR";
            // 
            // TB_proveedor
            // 
            this.TB_proveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_proveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_proveedor.Location = new System.Drawing.Point(875, 21);
            this.TB_proveedor.Multiline = true;
            this.TB_proveedor.Name = "TB_proveedor";
            this.TB_proveedor.Size = new System.Drawing.Size(65, 24);
            this.TB_proveedor.TabIndex = 5;
            // 
            // CB_compra
            // 
            this.CB_compra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_compra.FormattingEnabled = true;
            this.CB_compra.Location = new System.Drawing.Point(98, 79);
            this.CB_compra.Name = "CB_compra";
            this.CB_compra.Size = new System.Drawing.Size(133, 24);
            this.CB_compra.TabIndex = 8;
            this.CB_compra.SelectedIndexChanged += new System.EventHandler(this.CB_compra_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "COMPRA";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(301, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "FACTURA";
            // 
            // TB_factura
            // 
            this.TB_factura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_factura.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_factura.Location = new System.Drawing.Point(379, 78);
            this.TB_factura.Multiline = true;
            this.TB_factura.Name = "TB_factura";
            this.TB_factura.Size = new System.Drawing.Size(333, 25);
            this.TB_factura.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(718, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "IMPORTE";
            // 
            // TB_importe
            // 
            this.TB_importe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_importe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_importe.Location = new System.Drawing.Point(794, 78);
            this.TB_importe.Multiline = true;
            this.TB_importe.Name = "TB_importe";
            this.TB_importe.Size = new System.Drawing.Size(146, 25);
            this.TB_importe.TabIndex = 11;
            // 
            // DG_tabla
            // 
            this.DG_tabla.AllowUserToAddRows = false;
            this.DG_tabla.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DG_tabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DG_tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_tabla.Location = new System.Drawing.Point(17, 168);
            this.DG_tabla.Name = "DG_tabla";
            this.DG_tabla.Size = new System.Drawing.Size(926, 237);
            this.DG_tabla.TabIndex = 13;
            this.DG_tabla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_tabla_CellContentClick);
            this.DG_tabla.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_tabla_CellDoubleClick);
            // 
            // BT_quitar
            // 
            this.BT_quitar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BT_quitar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_quitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_quitar.ForeColor = System.Drawing.Color.White;
            this.BT_quitar.Location = new System.Drawing.Point(587, 731);
            this.BT_quitar.Name = "BT_quitar";
            this.BT_quitar.Size = new System.Drawing.Size(157, 46);
            this.BT_quitar.TabIndex = 19;
            this.BT_quitar.Text = "Quitar";
            this.BT_quitar.UseVisualStyleBackColor = false;
            this.BT_quitar.Click += new System.EventHandler(this.BT_quitar_Click);
            // 
            // BT_devolver
            // 
            this.BT_devolver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BT_devolver.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_devolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_devolver.ForeColor = System.Drawing.Color.White;
            this.BT_devolver.Location = new System.Drawing.Point(776, 731);
            this.BT_devolver.Name = "BT_devolver";
            this.BT_devolver.Size = new System.Drawing.Size(162, 46);
            this.BT_devolver.TabIndex = 20;
            this.BT_devolver.Text = "DEVOLVER";
            this.BT_devolver.UseVisualStyleBackColor = false;
            this.BT_devolver.Click += new System.EventHandler(this.BT_devolver_Click);
            // 
            // BT_compra
            // 
            this.BT_compra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_compra.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_compra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_compra.ForeColor = System.Drawing.Color.White;
            this.BT_compra.Location = new System.Drawing.Point(780, 116);
            this.BT_compra.Name = "BT_compra";
            this.BT_compra.Size = new System.Drawing.Size(162, 46);
            this.BT_compra.TabIndex = 21;
            this.BT_compra.Text = "COMPRA";
            this.BT_compra.UseVisualStyleBackColor = false;
            this.BT_compra.Click += new System.EventHandler(this.BT_compra_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 16);
            this.label7.TabIndex = 23;
            this.label7.Text = "FILTRO ARTICULOS";
            // 
            // TB_dgFiltro
            // 
            this.TB_dgFiltro.Location = new System.Drawing.Point(156, 130);
            this.TB_dgFiltro.Multiline = true;
            this.TB_dgFiltro.Name = "TB_dgFiltro";
            this.TB_dgFiltro.Size = new System.Drawing.Size(197, 25);
            this.TB_dgFiltro.TabIndex = 22;
            this.TB_dgFiltro.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // DG_devolucion
            // 
            this.DG_devolucion.AllowUserToAddRows = false;
            this.DG_devolucion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DG_devolucion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DG_devolucion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_devolucion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ARTICULO,
            this.DESCRIPCION,
            this.PRECIO,
            this.COSTO_U,
            this.CANTIDAD,
            this.IMPUESTO,
            this.DESC,
            this.IMPORTE});
            this.DG_devolucion.Enabled = false;
            this.DG_devolucion.Location = new System.Drawing.Point(17, 455);
            this.DG_devolucion.Name = "DG_devolucion";
            this.DG_devolucion.Size = new System.Drawing.Size(923, 200);
            this.DG_devolucion.TabIndex = 24;
            this.DG_devolucion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_devolucion_CellContentClick);
            this.DG_devolucion.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_devolucion_CellEndEdit);
            // 
            // ARTICULO
            // 
            this.ARTICULO.HeaderText = "ARTICULO";
            this.ARTICULO.Name = "ARTICULO";
            // 
            // DESCRIPCION
            // 
            this.DESCRIPCION.HeaderText = "DESCRIPCION";
            this.DESCRIPCION.Name = "DESCRIPCION";
            // 
            // PRECIO
            // 
            this.PRECIO.HeaderText = "PRECIO";
            this.PRECIO.Name = "PRECIO";
            // 
            // COSTO_U
            // 
            this.COSTO_U.HeaderText = "COSTO_U";
            this.COSTO_U.Name = "COSTO_U";
            // 
            // CANTIDAD
            // 
            this.CANTIDAD.HeaderText = "CANTIDAD";
            this.CANTIDAD.Name = "CANTIDAD";
            // 
            // IMPUESTO
            // 
            this.IMPUESTO.HeaderText = "IMPUESTO";
            this.IMPUESTO.Name = "IMPUESTO";
            // 
            // DESC
            // 
            this.DESC.HeaderText = "DESC.";
            this.DESC.Name = "DESC";
            // 
            // IMPORTE
            // 
            this.IMPORTE.HeaderText = "IMPORTE";
            this.IMPORTE.Name = "IMPORTE";
            // 
            // CHK_parcial
            // 
            this.CHK_parcial.AutoSize = true;
            this.CHK_parcial.Location = new System.Drawing.Point(17, 432);
            this.CHK_parcial.Name = "CHK_parcial";
            this.CHK_parcial.Size = new System.Drawing.Size(144, 17);
            this.CHK_parcial.TabIndex = 25;
            this.CHK_parcial.Text = "DEVOLUCIÓN PARCIAL";
            this.CHK_parcial.UseVisualStyleBackColor = true;
            this.CHK_parcial.CheckedChanged += new System.EventHandler(this.CHK_parcial_CheckedChanged);
            // 
            // TB_importeTotal
            // 
            this.TB_importeTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_importeTotal.BackColor = System.Drawing.Color.Black;
            this.TB_importeTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_importeTotal.ForeColor = System.Drawing.Color.Lime;
            this.TB_importeTotal.Location = new System.Drawing.Point(780, 411);
            this.TB_importeTotal.Multiline = true;
            this.TB_importeTotal.Name = "TB_importeTotal";
            this.TB_importeTotal.Size = new System.Drawing.Size(162, 25);
            this.TB_importeTotal.TabIndex = 26;
            this.TB_importeTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TB_importeTotal2
            // 
            this.TB_importeTotal2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_importeTotal2.BackColor = System.Drawing.Color.Black;
            this.TB_importeTotal2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_importeTotal2.ForeColor = System.Drawing.Color.Lime;
            this.TB_importeTotal2.Location = new System.Drawing.Point(778, 660);
            this.TB_importeTotal2.Multiline = true;
            this.TB_importeTotal2.Name = "TB_importeTotal2";
            this.TB_importeTotal2.Size = new System.Drawing.Size(162, 25);
            this.TB_importeTotal2.TabIndex = 27;
            this.TB_importeTotal2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BT_calcular
            // 
            this.BT_calcular.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BT_calcular.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_calcular.ForeColor = System.Drawing.Color.White;
            this.BT_calcular.Location = new System.Drawing.Point(395, 731);
            this.BT_calcular.Name = "BT_calcular";
            this.BT_calcular.Size = new System.Drawing.Size(162, 46);
            this.BT_calcular.TabIndex = 28;
            this.BT_calcular.Text = "CALCULAR";
            this.BT_calcular.UseVisualStyleBackColor = false;
            this.BT_calcular.Click += new System.EventHandler(this.BT_calcular_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1, 699);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 16);
            this.label8.TabIndex = 30;
            this.label8.Text = "OBSERVACION";
            // 
            // TB_observacion
            // 
            this.TB_observacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_observacion.Location = new System.Drawing.Point(112, 694);
            this.TB_observacion.Multiline = true;
            this.TB_observacion.Name = "TB_observacion";
            this.TB_observacion.Size = new System.Drawing.Size(826, 25);
            this.TB_observacion.TabIndex = 29;
            // 
            // BT_cambiarClaves
            // 
            this.BT_cambiarClaves.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_cambiarClaves.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_cambiarClaves.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_cambiarClaves.ForeColor = System.Drawing.Color.White;
            this.BT_cambiarClaves.Location = new System.Drawing.Point(21, 731);
            this.BT_cambiarClaves.Name = "BT_cambiarClaves";
            this.BT_cambiarClaves.Size = new System.Drawing.Size(162, 46);
            this.BT_cambiarClaves.TabIndex = 31;
            this.BT_cambiarClaves.Text = "CAMBIAR CLAVES";
            this.BT_cambiarClaves.UseVisualStyleBackColor = false;
            this.BT_cambiarClaves.Click += new System.EventHandler(this.BT_cambiarClaves_Click);
            // 
            // BT_CambiarProveedor
            // 
            this.BT_CambiarProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_CambiarProveedor.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_CambiarProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_CambiarProveedor.ForeColor = System.Drawing.Color.White;
            this.BT_CambiarProveedor.Location = new System.Drawing.Point(211, 731);
            this.BT_CambiarProveedor.Name = "BT_CambiarProveedor";
            this.BT_CambiarProveedor.Size = new System.Drawing.Size(162, 46);
            this.BT_CambiarProveedor.TabIndex = 32;
            this.BT_CambiarProveedor.Text = "Modificar datos de la devolución";
            this.BT_CambiarProveedor.UseVisualStyleBackColor = false;
            this.BT_CambiarProveedor.Click += new System.EventHandler(this.BT_CambiarProveedor_Click);
            // 
            // DevolucionesCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(958, 786);
            this.Controls.Add(this.BT_CambiarProveedor);
            this.Controls.Add(this.BT_cambiarClaves);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TB_observacion);
            this.Controls.Add(this.BT_calcular);
            this.Controls.Add(this.TB_importeTotal2);
            this.Controls.Add(this.TB_importeTotal);
            this.Controls.Add(this.CHK_parcial);
            this.Controls.Add(this.DG_devolucion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TB_dgFiltro);
            this.Controls.Add(this.BT_compra);
            this.Controls.Add(this.BT_devolver);
            this.Controls.Add(this.BT_quitar);
            this.Controls.Add(this.DG_tabla);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TB_importe);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TB_factura);
            this.Controls.Add(this.CB_compra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TB_proveedor);
            this.Controls.Add(this.CB_proveedores);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CB_sucursal);
            this.Controls.Add(this.label1);
            this.Name = "DevolucionesCompras";
            this.Text = "DevolucionesCompras";
            this.Load += new System.EventHandler(this.DevolucionesCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_tabla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_devolucion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CB_sucursal;
        private System.Windows.Forms.ComboBox CB_proveedores;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_proveedor;
        private System.Windows.Forms.ComboBox CB_compra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_factura;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TB_importe;
        private System.Windows.Forms.DataGridView DG_tabla;
        private System.Windows.Forms.Button BT_quitar;
        private System.Windows.Forms.Button BT_devolver;
        private System.Windows.Forms.Button BT_compra;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TB_dgFiltro;
        private System.Windows.Forms.DataGridView DG_devolucion;
        private System.Windows.Forms.CheckBox CHK_parcial;
        private System.Windows.Forms.TextBox TB_importeTotal;
        private System.Windows.Forms.TextBox TB_importeTotal2;
        private System.Windows.Forms.Button BT_calcular;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TB_observacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ARTICULO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn COSTO_U;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMPUESTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESC;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMPORTE;
        private System.Windows.Forms.Button BT_cambiarClaves;
        private System.Windows.Forms.Button BT_CambiarProveedor;
    }
}