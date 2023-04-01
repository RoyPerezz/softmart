namespace appSugerencias
{
    partial class FechaLlegada
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DG_tabla = new System.Windows.Forms.DataGridView();
            this.ARTICULO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EX_CEDIS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_COMPRA_CE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANT_COMP_CE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EXISTENCIA_VA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_COMPRA_VA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANT_COMP_VA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EX_RE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_COMPRA_RE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANT_COMP_RE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EX_VE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_COMPRA_VE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANT_COMP_VE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EX_CO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_COMPRA_CO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANT_COMP_CO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROVEEDOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CB_lineas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BT_buscar = new System.Windows.Forms.Button();
            this.LB_va = new System.Windows.Forms.Label();
            this.LB_re = new System.Windows.Forms.Label();
            this.LB_ve = new System.Windows.Forms.Label();
            this.LB_co = new System.Windows.Forms.Label();
            this.LB_cedis = new System.Windows.Forms.Label();
            this.LB_mensaje = new System.Windows.Forms.Label();
            this.BT_exportar = new System.Windows.Forms.Button();
            this.BT_eliminarFilas = new System.Windows.Forms.Button();
            this.DT_inicio = new System.Windows.Forms.DateTimePicker();
            this.DT_fin = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BT_existencia = new System.Windows.Forms.Button();
            this.SUCURSAL = new System.Windows.Forms.Label();
            this.CB_sucursal = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PB_progreso = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.DG_tabla)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.DG_tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ARTICULO,
            this.DESCRIPCION,
            this.EX_CEDIS,
            this.FECHA_COMPRA_CE,
            this.CANT_COMP_CE,
            this.EXISTENCIA_VA,
            this.FECHA_COMPRA_VA,
            this.CANT_COMP_VA,
            this.EX_RE,
            this.FECHA_COMPRA_RE,
            this.CANT_COMP_RE,
            this.EX_VE,
            this.FECHA_COMPRA_VE,
            this.CANT_COMP_VE,
            this.EX_CO,
            this.FECHA_COMPRA_CO,
            this.CANT_COMP_CO,
            this.PROVEEDOR});
            this.DG_tabla.Location = new System.Drawing.Point(0, 151);
            this.DG_tabla.Name = "DG_tabla";
            this.DG_tabla.Size = new System.Drawing.Size(1380, 298);
            this.DG_tabla.TabIndex = 0;
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
            // EX_CEDIS
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.EX_CEDIS.DefaultCellStyle = dataGridViewCellStyle1;
            this.EX_CEDIS.HeaderText = "EX CEDIS";
            this.EX_CEDIS.Name = "EX_CEDIS";
            // 
            // FECHA_COMPRA_CE
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.FECHA_COMPRA_CE.DefaultCellStyle = dataGridViewCellStyle2;
            this.FECHA_COMPRA_CE.HeaderText = "FECHA COMPRA CE";
            this.FECHA_COMPRA_CE.Name = "FECHA_COMPRA_CE";
            // 
            // CANT_COMP_CE
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.CANT_COMP_CE.DefaultCellStyle = dataGridViewCellStyle3;
            this.CANT_COMP_CE.HeaderText = "CANTIDAD COMPRA CE";
            this.CANT_COMP_CE.Name = "CANT_COMP_CE";
            // 
            // EXISTENCIA_VA
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.EXISTENCIA_VA.DefaultCellStyle = dataGridViewCellStyle4;
            this.EXISTENCIA_VA.HeaderText = "EX VA";
            this.EXISTENCIA_VA.Name = "EXISTENCIA_VA";
            // 
            // FECHA_COMPRA_VA
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.FECHA_COMPRA_VA.DefaultCellStyle = dataGridViewCellStyle5;
            this.FECHA_COMPRA_VA.HeaderText = "FECHA COMPRA VA";
            this.FECHA_COMPRA_VA.Name = "FECHA_COMPRA_VA";
            // 
            // CANT_COMP_VA
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CANT_COMP_VA.DefaultCellStyle = dataGridViewCellStyle6;
            this.CANT_COMP_VA.HeaderText = "CANTIDAD COMPRA VA";
            this.CANT_COMP_VA.Name = "CANT_COMP_VA";
            // 
            // EX_RE
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.EX_RE.DefaultCellStyle = dataGridViewCellStyle7;
            this.EX_RE.HeaderText = "EX RE";
            this.EX_RE.Name = "EX_RE";
            // 
            // FECHA_COMPRA_RE
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.FECHA_COMPRA_RE.DefaultCellStyle = dataGridViewCellStyle8;
            this.FECHA_COMPRA_RE.HeaderText = "FECHA COMPRA RE";
            this.FECHA_COMPRA_RE.Name = "FECHA_COMPRA_RE";
            // 
            // CANT_COMP_RE
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.CANT_COMP_RE.DefaultCellStyle = dataGridViewCellStyle9;
            this.CANT_COMP_RE.HeaderText = "CANTIDAD COMPRA RE";
            this.CANT_COMP_RE.Name = "CANT_COMP_RE";
            // 
            // EX_VE
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Yellow;
            this.EX_VE.DefaultCellStyle = dataGridViewCellStyle10;
            this.EX_VE.HeaderText = "EX VE";
            this.EX_VE.Name = "EX_VE";
            // 
            // FECHA_COMPRA_VE
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Yellow;
            this.FECHA_COMPRA_VE.DefaultCellStyle = dataGridViewCellStyle11;
            this.FECHA_COMPRA_VE.HeaderText = "FECHA COMPRA VE";
            this.FECHA_COMPRA_VE.Name = "FECHA_COMPRA_VE";
            // 
            // CANT_COMP_VE
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.Yellow;
            this.CANT_COMP_VE.DefaultCellStyle = dataGridViewCellStyle12;
            this.CANT_COMP_VE.HeaderText = "CANTIDAD COMPRA VE";
            this.CANT_COMP_VE.Name = "CANT_COMP_VE";
            // 
            // EX_CO
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.EX_CO.DefaultCellStyle = dataGridViewCellStyle13;
            this.EX_CO.HeaderText = "EX CO";
            this.EX_CO.Name = "EX_CO";
            // 
            // FECHA_COMPRA_CO
            // 
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.FECHA_COMPRA_CO.DefaultCellStyle = dataGridViewCellStyle14;
            this.FECHA_COMPRA_CO.HeaderText = "FECHA COMPRA CO";
            this.FECHA_COMPRA_CO.Name = "FECHA_COMPRA_CO";
            // 
            // CANT_COMP_CO
            // 
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.CANT_COMP_CO.DefaultCellStyle = dataGridViewCellStyle15;
            this.CANT_COMP_CO.HeaderText = "CANTIDAD COMPRA CO";
            this.CANT_COMP_CO.Name = "CANT_COMP_CO";
            // 
            // PROVEEDOR
            // 
            this.PROVEEDOR.HeaderText = "PROVEEDOR";
            this.PROVEEDOR.Name = "PROVEEDOR";
            // 
            // CB_lineas
            // 
            this.CB_lineas.FormattingEnabled = true;
            this.CB_lineas.Location = new System.Drawing.Point(51, 19);
            this.CB_lineas.Name = "CB_lineas";
            this.CB_lineas.Size = new System.Drawing.Size(139, 21);
            this.CB_lineas.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "LINEA";
            // 
            // BT_buscar
            // 
            this.BT_buscar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_buscar.ForeColor = System.Drawing.Color.White;
            this.BT_buscar.Location = new System.Drawing.Point(474, 16);
            this.BT_buscar.Name = "BT_buscar";
            this.BT_buscar.Size = new System.Drawing.Size(115, 34);
            this.BT_buscar.TabIndex = 3;
            this.BT_buscar.Text = "BUSCAR";
            this.BT_buscar.UseVisualStyleBackColor = false;
            this.BT_buscar.Click += new System.EventHandler(this.BT_buscar_Click);
            // 
            // LB_va
            // 
            this.LB_va.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LB_va.AutoSize = true;
            this.LB_va.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_va.Location = new System.Drawing.Point(1039, 9);
            this.LB_va.Name = "LB_va";
            this.LB_va.Size = new System.Drawing.Size(70, 13);
            this.LB_va.TabIndex = 4;
            this.LB_va.Text = "VALLARTA";
            // 
            // LB_re
            // 
            this.LB_re.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LB_re.AutoSize = true;
            this.LB_re.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_re.Location = new System.Drawing.Point(1137, 9);
            this.LB_re.Name = "LB_re";
            this.LB_re.Size = new System.Drawing.Size(41, 13);
            this.LB_re.TabIndex = 5;
            this.LB_re.Text = "RENA";
            // 
            // LB_ve
            // 
            this.LB_ve.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LB_ve.AutoSize = true;
            this.LB_ve.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_ve.Location = new System.Drawing.Point(1203, 9);
            this.LB_ve.Name = "LB_ve";
            this.LB_ve.Size = new System.Drawing.Size(80, 13);
            this.LB_ve.TabIndex = 6;
            this.LB_ve.Text = "VELAZQUEZ";
            // 
            // LB_co
            // 
            this.LB_co.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LB_co.AutoSize = true;
            this.LB_co.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_co.Location = new System.Drawing.Point(1311, 9);
            this.LB_co.Name = "LB_co";
            this.LB_co.Size = new System.Drawing.Size(57, 13);
            this.LB_co.TabIndex = 7;
            this.LB_co.Text = "COLOSO";
            // 
            // LB_cedis
            // 
            this.LB_cedis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LB_cedis.AutoSize = true;
            this.LB_cedis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_cedis.Location = new System.Drawing.Point(953, 9);
            this.LB_cedis.Name = "LB_cedis";
            this.LB_cedis.Size = new System.Drawing.Size(44, 13);
            this.LB_cedis.TabIndex = 8;
            this.LB_cedis.Text = "CEDIS";
            // 
            // LB_mensaje
            // 
            this.LB_mensaje.AutoSize = true;
            this.LB_mensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_mensaje.Location = new System.Drawing.Point(607, 30);
            this.LB_mensaje.Name = "LB_mensaje";
            this.LB_mensaje.Size = new System.Drawing.Size(0, 16);
            this.LB_mensaje.TabIndex = 9;
            // 
            // BT_exportar
            // 
            this.BT_exportar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_exportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_exportar.ForeColor = System.Drawing.Color.White;
            this.BT_exportar.Location = new System.Drawing.Point(474, 89);
            this.BT_exportar.Name = "BT_exportar";
            this.BT_exportar.Size = new System.Drawing.Size(115, 33);
            this.BT_exportar.TabIndex = 10;
            this.BT_exportar.Text = "EXPORTAR";
            this.BT_exportar.UseVisualStyleBackColor = false;
            this.BT_exportar.Click += new System.EventHandler(this.BT_exportar_Click);
            // 
            // BT_eliminarFilas
            // 
            this.BT_eliminarFilas.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_eliminarFilas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_eliminarFilas.ForeColor = System.Drawing.Color.White;
            this.BT_eliminarFilas.Location = new System.Drawing.Point(474, 52);
            this.BT_eliminarFilas.Name = "BT_eliminarFilas";
            this.BT_eliminarFilas.Size = new System.Drawing.Size(115, 34);
            this.BT_eliminarFilas.TabIndex = 11;
            this.BT_eliminarFilas.Text = "ELIMINAR";
            this.BT_eliminarFilas.UseVisualStyleBackColor = false;
            this.BT_eliminarFilas.Click += new System.EventHandler(this.BT_eliminarFilas_Click);
            // 
            // DT_inicio
            // 
            this.DT_inicio.Location = new System.Drawing.Point(268, 42);
            this.DT_inicio.Name = "DT_inicio";
            this.DT_inicio.Size = new System.Drawing.Size(200, 20);
            this.DT_inicio.TabIndex = 12;
            // 
            // DT_fin
            // 
            this.DT_fin.Location = new System.Drawing.Point(268, 75);
            this.DT_fin.Name = "DT_fin";
            this.DT_fin.Size = new System.Drawing.Size(200, 20);
            this.DT_fin.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "INICIO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "FIN";
            // 
            // BT_existencia
            // 
            this.BT_existencia.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_existencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_existencia.ForeColor = System.Drawing.Color.White;
            this.BT_existencia.Location = new System.Drawing.Point(35, 46);
            this.BT_existencia.Name = "BT_existencia";
            this.BT_existencia.Size = new System.Drawing.Size(139, 53);
            this.BT_existencia.TabIndex = 16;
            this.BT_existencia.Text = "BUSCAR EXISTENCIA";
            this.BT_existencia.UseVisualStyleBackColor = false;
            this.BT_existencia.Click += new System.EventHandler(this.BT_existencia_Click);
            // 
            // SUCURSAL
            // 
            this.SUCURSAL.AutoSize = true;
            this.SUCURSAL.Location = new System.Drawing.Point(711, 22);
            this.SUCURSAL.Name = "SUCURSAL";
            this.SUCURSAL.Size = new System.Drawing.Size(38, 13);
            this.SUCURSAL.TabIndex = 18;
            this.SUCURSAL.Text = "LINEA";
            // 
            // CB_sucursal
            // 
            this.CB_sucursal.FormattingEnabled = true;
            this.CB_sucursal.Location = new System.Drawing.Point(35, 19);
            this.CB_sucursal.Name = "CB_sucursal";
            this.CB_sucursal.Size = new System.Drawing.Size(139, 21);
            this.CB_sucursal.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CB_lineas);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BT_eliminarFilas);
            this.groupBox1.Controls.Add(this.BT_buscar);
            this.groupBox1.Controls.Add(this.BT_exportar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.DT_inicio);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.DT_fin);
            this.groupBox1.Location = new System.Drawing.Point(0, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(595, 136);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar fecha de llegada";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PB_progreso);
            this.groupBox2.Controls.Add(this.BT_existencia);
            this.groupBox2.Controls.Add(this.CB_sucursal);
            this.groupBox2.Location = new System.Drawing.Point(596, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 136);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Solo existencia";
            // 
            // PB_progreso
            // 
            this.PB_progreso.Location = new System.Drawing.Point(6, 105);
            this.PB_progreso.Name = "PB_progreso";
            this.PB_progreso.Size = new System.Drawing.Size(188, 23);
            this.PB_progreso.TabIndex = 18;
            // 
            // FechaLlegada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1380, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SUCURSAL);
            this.Controls.Add(this.LB_mensaje);
            this.Controls.Add(this.LB_cedis);
            this.Controls.Add(this.LB_co);
            this.Controls.Add(this.LB_ve);
            this.Controls.Add(this.LB_re);
            this.Controls.Add(this.LB_va);
            this.Controls.Add(this.DG_tabla);
            this.Name = "FechaLlegada";
            this.Text = "FechaLlegada";
            this.Load += new System.EventHandler(this.FechaLlegada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_tabla)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DG_tabla;
        private System.Windows.Forms.ComboBox CB_lineas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BT_buscar;
        private System.Windows.Forms.Label LB_va;
        private System.Windows.Forms.Label LB_re;
        private System.Windows.Forms.Label LB_ve;
        private System.Windows.Forms.Label LB_co;
        private System.Windows.Forms.Label LB_cedis;
        private System.Windows.Forms.Label LB_mensaje;
        private System.Windows.Forms.Button BT_exportar;
        private System.Windows.Forms.Button BT_eliminarFilas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ARTICULO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn EX_CEDIS;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_COMPRA_CE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANT_COMP_CE;
        private System.Windows.Forms.DataGridViewTextBoxColumn EXISTENCIA_VA;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_COMPRA_VA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANT_COMP_VA;
        private System.Windows.Forms.DataGridViewTextBoxColumn EX_RE;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_COMPRA_RE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANT_COMP_RE;
        private System.Windows.Forms.DataGridViewTextBoxColumn EX_VE;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_COMPRA_VE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANT_COMP_VE;
        private System.Windows.Forms.DataGridViewTextBoxColumn EX_CO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_COMPRA_CO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANT_COMP_CO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROVEEDOR;
        private System.Windows.Forms.DateTimePicker DT_inicio;
        private System.Windows.Forms.DateTimePicker DT_fin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BT_existencia;
        private System.Windows.Forms.Label SUCURSAL;
        private System.Windows.Forms.ComboBox CB_sucursal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ProgressBar PB_progreso;
    }
}