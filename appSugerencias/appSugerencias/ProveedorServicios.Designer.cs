namespace appSugerencias
{
    partial class ProveedorServicios
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
            this.TB_nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CB_banco = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_cuenta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_rfc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_beneficiario = new System.Windows.Forms.TextBox();
            this.DG_tabla = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RFC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BT_agregar = new System.Windows.Forms.Button();
            this.BT_buscar = new System.Windows.Forms.Button();
            this.BT_modificar = new System.Windows.Forms.Button();
            this.BT_eliminar = new System.Windows.Forms.Button();
            this.TB_id = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CB_proveedor = new System.Windows.Forms.ComboBox();
            this.TB_proveedor = new System.Windows.Forms.TextBox();
            this.BT_cuenta = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TB_idreg = new System.Windows.Forms.TextBox();
            this.BT_eliminar_cuenta = new System.Windows.Forms.Button();
            this.BT_modificar_cuenta = new System.Windows.Forms.Button();
            this.BT_buscar_cuenta = new System.Windows.Forms.Button();
            this.DG_cuentas = new System.Windows.Forms.DataGridView();
            this.IDREG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROVEEDOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BANCO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUENTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BENEFICIARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DG_tabla)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_cuentas)).BeginInit();
            this.SuspendLayout();
            // 
            // TB_nombre
            // 
            this.TB_nombre.Location = new System.Drawing.Point(59, 30);
            this.TB_nombre.Name = "TB_nombre";
            this.TB_nombre.Size = new System.Drawing.Size(788, 20);
            this.TB_nombre.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // CB_banco
            // 
            this.CB_banco.FormattingEnabled = true;
            this.CB_banco.Location = new System.Drawing.Point(71, 54);
            this.CB_banco.Name = "CB_banco";
            this.CB_banco.Size = new System.Drawing.Size(179, 21);
            this.CB_banco.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Banco";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(572, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cuenta bancaria";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // TB_cuenta
            // 
            this.TB_cuenta.Location = new System.Drawing.Point(663, 54);
            this.TB_cuenta.Name = "TB_cuenta";
            this.TB_cuenta.Size = new System.Drawing.Size(184, 20);
            this.TB_cuenta.TabIndex = 4;
            this.TB_cuenta.TextChanged += new System.EventHandler(this.TB_cuenta_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "RFC";
            // 
            // TB_rfc
            // 
            this.TB_rfc.Location = new System.Drawing.Point(59, 56);
            this.TB_rfc.Name = "TB_rfc";
            this.TB_rfc.Size = new System.Drawing.Size(184, 20);
            this.TB_rfc.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "beneficiario";
            // 
            // TB_beneficiario
            // 
            this.TB_beneficiario.Location = new System.Drawing.Point(72, 84);
            this.TB_beneficiario.Name = "TB_beneficiario";
            this.TB_beneficiario.Size = new System.Drawing.Size(776, 20);
            this.TB_beneficiario.TabIndex = 8;
            // 
            // DG_tabla
            // 
            this.DG_tabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DG_tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NOMBRE,
            this.RFC});
            this.DG_tabla.Location = new System.Drawing.Point(22, 165);
            this.DG_tabla.Name = "DG_tabla";
            this.DG_tabla.Size = new System.Drawing.Size(942, 121);
            this.DG_tabla.TabIndex = 10;
            this.DG_tabla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_tabla_CellContentClick);
            this.DG_tabla.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_tabla_CellContentDoubleClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // NOMBRE
            // 
            this.NOMBRE.HeaderText = "NOMBRE";
            this.NOMBRE.Name = "NOMBRE";
            // 
            // RFC
            // 
            this.RFC.HeaderText = "RFC";
            this.RFC.Name = "RFC";
            // 
            // BT_agregar
            // 
            this.BT_agregar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_agregar.ForeColor = System.Drawing.Color.White;
            this.BT_agregar.Location = new System.Drawing.Point(851, 101);
            this.BT_agregar.Name = "BT_agregar";
            this.BT_agregar.Size = new System.Drawing.Size(76, 40);
            this.BT_agregar.TabIndex = 11;
            this.BT_agregar.Text = "Agregar";
            this.BT_agregar.UseVisualStyleBackColor = false;
            this.BT_agregar.Click += new System.EventHandler(this.BT_agregar_Click);
            // 
            // BT_buscar
            // 
            this.BT_buscar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_buscar.ForeColor = System.Drawing.Color.White;
            this.BT_buscar.Location = new System.Drawing.Point(718, 292);
            this.BT_buscar.Name = "BT_buscar";
            this.BT_buscar.Size = new System.Drawing.Size(75, 36);
            this.BT_buscar.TabIndex = 12;
            this.BT_buscar.Text = "Buscar";
            this.BT_buscar.UseVisualStyleBackColor = false;
            this.BT_buscar.Click += new System.EventHandler(this.BT_buscar_Click);
            // 
            // BT_modificar
            // 
            this.BT_modificar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_modificar.ForeColor = System.Drawing.Color.White;
            this.BT_modificar.Location = new System.Drawing.Point(799, 292);
            this.BT_modificar.Name = "BT_modificar";
            this.BT_modificar.Size = new System.Drawing.Size(75, 36);
            this.BT_modificar.TabIndex = 13;
            this.BT_modificar.Text = "modificar";
            this.BT_modificar.UseVisualStyleBackColor = false;
            this.BT_modificar.Click += new System.EventHandler(this.BT_modificar_Click);
            // 
            // BT_eliminar
            // 
            this.BT_eliminar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_eliminar.ForeColor = System.Drawing.Color.White;
            this.BT_eliminar.Location = new System.Drawing.Point(889, 292);
            this.BT_eliminar.Name = "BT_eliminar";
            this.BT_eliminar.Size = new System.Drawing.Size(75, 36);
            this.BT_eliminar.TabIndex = 14;
            this.BT_eliminar.Text = "Eliminar";
            this.BT_eliminar.UseVisualStyleBackColor = false;
            this.BT_eliminar.Click += new System.EventHandler(this.BT_eliminar_Click);
            // 
            // TB_id
            // 
            this.TB_id.Location = new System.Drawing.Point(880, 30);
            this.TB_id.Name = "TB_id";
            this.TB_id.Size = new System.Drawing.Size(38, 20);
            this.TB_id.TabIndex = 15;
            this.TB_id.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Proveedor";
            // 
            // CB_proveedor
            // 
            this.CB_proveedor.FormattingEnabled = true;
            this.CB_proveedor.Location = new System.Drawing.Point(72, 19);
            this.CB_proveedor.Name = "CB_proveedor";
            this.CB_proveedor.Size = new System.Drawing.Size(775, 21);
            this.CB_proveedor.TabIndex = 16;
            this.CB_proveedor.SelectedIndexChanged += new System.EventHandler(this.CB_proveedor_SelectedIndexChanged);
            // 
            // TB_proveedor
            // 
            this.TB_proveedor.Location = new System.Drawing.Point(867, 19);
            this.TB_proveedor.Name = "TB_proveedor";
            this.TB_proveedor.Size = new System.Drawing.Size(38, 20);
            this.TB_proveedor.TabIndex = 18;
            // 
            // BT_cuenta
            // 
            this.BT_cuenta.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_cuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_cuenta.ForeColor = System.Drawing.Color.White;
            this.BT_cuenta.Location = new System.Drawing.Point(840, 130);
            this.BT_cuenta.Name = "BT_cuenta";
            this.BT_cuenta.Size = new System.Drawing.Size(87, 42);
            this.BT_cuenta.TabIndex = 19;
            this.BT_cuenta.Text = "Agregar Cuenta";
            this.BT_cuenta.UseVisualStyleBackColor = false;
            this.BT_cuenta.Click += new System.EventHandler(this.BT_cuenta_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TB_nombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TB_rfc);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.BT_agregar);
            this.groupBox1.Controls.Add(this.TB_id);
            this.groupBox1.Location = new System.Drawing.Point(22, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(942, 147);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS DEL PROVEEDOR";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TB_idreg);
            this.groupBox2.Controls.Add(this.CB_proveedor);
            this.groupBox2.Controls.Add(this.BT_cuenta);
            this.groupBox2.Controls.Add(this.CB_banco);
            this.groupBox2.Controls.Add(this.TB_proveedor);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.TB_cuenta);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.TB_beneficiario);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(22, 342);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(942, 178);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DATOS DE LA CUENTA";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // TB_idreg
            // 
            this.TB_idreg.Location = new System.Drawing.Point(777, 142);
            this.TB_idreg.Name = "TB_idreg";
            this.TB_idreg.Size = new System.Drawing.Size(38, 20);
            this.TB_idreg.TabIndex = 20;
            // 
            // BT_eliminar_cuenta
            // 
            this.BT_eliminar_cuenta.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_eliminar_cuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_eliminar_cuenta.ForeColor = System.Drawing.Color.White;
            this.BT_eliminar_cuenta.Location = new System.Drawing.Point(889, 653);
            this.BT_eliminar_cuenta.Name = "BT_eliminar_cuenta";
            this.BT_eliminar_cuenta.Size = new System.Drawing.Size(75, 36);
            this.BT_eliminar_cuenta.TabIndex = 25;
            this.BT_eliminar_cuenta.Text = "Eliminar";
            this.BT_eliminar_cuenta.UseVisualStyleBackColor = false;
            this.BT_eliminar_cuenta.Click += new System.EventHandler(this.BT_eliminar_cuenta_Click);
            // 
            // BT_modificar_cuenta
            // 
            this.BT_modificar_cuenta.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_modificar_cuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_modificar_cuenta.ForeColor = System.Drawing.Color.White;
            this.BT_modificar_cuenta.Location = new System.Drawing.Point(799, 653);
            this.BT_modificar_cuenta.Name = "BT_modificar_cuenta";
            this.BT_modificar_cuenta.Size = new System.Drawing.Size(75, 36);
            this.BT_modificar_cuenta.TabIndex = 24;
            this.BT_modificar_cuenta.Text = "modificar";
            this.BT_modificar_cuenta.UseVisualStyleBackColor = false;
            this.BT_modificar_cuenta.Click += new System.EventHandler(this.BT_modificar_cuenta_Click);
            // 
            // BT_buscar_cuenta
            // 
            this.BT_buscar_cuenta.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_buscar_cuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_buscar_cuenta.ForeColor = System.Drawing.Color.White;
            this.BT_buscar_cuenta.Location = new System.Drawing.Point(718, 653);
            this.BT_buscar_cuenta.Name = "BT_buscar_cuenta";
            this.BT_buscar_cuenta.Size = new System.Drawing.Size(75, 36);
            this.BT_buscar_cuenta.TabIndex = 23;
            this.BT_buscar_cuenta.Text = "Buscar";
            this.BT_buscar_cuenta.UseVisualStyleBackColor = false;
            this.BT_buscar_cuenta.Click += new System.EventHandler(this.BT_buscar_cuenta_Click);
            // 
            // DG_cuentas
            // 
            this.DG_cuentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DG_cuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_cuentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDREG,
            this.PROVEEDOR,
            this.BANCO,
            this.CUENTA,
            this.BENEFICIARIO});
            this.DG_cuentas.Location = new System.Drawing.Point(22, 526);
            this.DG_cuentas.Name = "DG_cuentas";
            this.DG_cuentas.Size = new System.Drawing.Size(942, 121);
            this.DG_cuentas.TabIndex = 22;
            this.DG_cuentas.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_cuentas_CellContentDoubleClick);
            // 
            // IDREG
            // 
            this.IDREG.HeaderText = "IDREG";
            this.IDREG.Name = "IDREG";
            this.IDREG.Visible = false;
            // 
            // PROVEEDOR
            // 
            this.PROVEEDOR.HeaderText = "PROVEEDOR";
            this.PROVEEDOR.Name = "PROVEEDOR";
            // 
            // BANCO
            // 
            this.BANCO.HeaderText = "BANCO";
            this.BANCO.Name = "BANCO";
            // 
            // CUENTA
            // 
            this.CUENTA.HeaderText = "CUENTA";
            this.CUENTA.Name = "CUENTA";
            // 
            // BENEFICIARIO
            // 
            this.BENEFICIARIO.HeaderText = "BENEFICIARIO";
            this.BENEFICIARIO.Name = "BENEFICIARIO";
            // 
            // ProveedorServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(982, 689);
            this.Controls.Add(this.BT_eliminar_cuenta);
            this.Controls.Add(this.BT_modificar_cuenta);
            this.Controls.Add(this.BT_buscar_cuenta);
            this.Controls.Add(this.DG_cuentas);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BT_eliminar);
            this.Controls.Add(this.BT_modificar);
            this.Controls.Add(this.BT_buscar);
            this.Controls.Add(this.DG_tabla);
            this.Name = "ProveedorServicios";
            this.Text = "Registrar Proveedor de Servicios";
            this.Load += new System.EventHandler(this.ProveedorServicios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_tabla)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_cuentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TB_nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CB_banco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_cuenta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_rfc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_beneficiario;
        private System.Windows.Forms.DataGridView DG_tabla;
        private System.Windows.Forms.Button BT_agregar;
        private System.Windows.Forms.Button BT_buscar;
        private System.Windows.Forms.Button BT_modificar;
        private System.Windows.Forms.Button BT_eliminar;
        private System.Windows.Forms.TextBox TB_id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CB_proveedor;
        private System.Windows.Forms.TextBox TB_proveedor;
        private System.Windows.Forms.Button BT_cuenta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn RFC;
        private System.Windows.Forms.Button BT_eliminar_cuenta;
        private System.Windows.Forms.Button BT_modificar_cuenta;
        private System.Windows.Forms.Button BT_buscar_cuenta;
        private System.Windows.Forms.DataGridView DG_cuentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDREG;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROVEEDOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn BANCO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUENTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn BENEFICIARIO;
        private System.Windows.Forms.TextBox TB_idreg;
    }
}