namespace appSugerencias
{
    partial class CorteZ
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
            this.BT_crearTicket = new System.Windows.Forms.Button();
            this.DG_ingresos = new System.Windows.Forms.DataGridView();
            this.CLAVE = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.IMPORTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CB_sucursal = new System.Windows.Forms.ComboBox();
            this.DG_egresos = new System.Windows.Forms.DataGridView();
            this.CODIGO = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.IMPORTE_EGRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DT_fecha = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CBX_respaldo = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CB_caja = new System.Windows.Forms.ComboBox();
            this.BT_ventasTarj = new System.Windows.Forms.Button();
            this.TB_numClientes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DG_ingresos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_egresos)).BeginInit();
            this.SuspendLayout();
            // 
            // BT_crearTicket
            // 
            this.BT_crearTicket.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_crearTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_crearTicket.ForeColor = System.Drawing.Color.White;
            this.BT_crearTicket.Location = new System.Drawing.Point(560, 436);
            this.BT_crearTicket.Name = "BT_crearTicket";
            this.BT_crearTicket.Size = new System.Drawing.Size(93, 40);
            this.BT_crearTicket.TabIndex = 0;
            this.BT_crearTicket.Text = "Crear Ticket";
            this.BT_crearTicket.UseVisualStyleBackColor = false;
            this.BT_crearTicket.Click += new System.EventHandler(this.button1_Click);
            // 
            // DG_ingresos
            // 
            this.DG_ingresos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DG_ingresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_ingresos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CLAVE,
            this.IMPORTE});
            this.DG_ingresos.Location = new System.Drawing.Point(38, 114);
            this.DG_ingresos.Name = "DG_ingresos";
            this.DG_ingresos.Size = new System.Drawing.Size(615, 132);
            this.DG_ingresos.TabIndex = 1;
            this.DG_ingresos.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_ingresos_CellEndEdit);
            // 
            // CLAVE
            // 
            this.CLAVE.HeaderText = "CONCEPTO";
            this.CLAVE.Items.AddRange(new object[] {
            "EFE Pago de clientes",
            "TAR Pago de clientes"});
            this.CLAVE.Name = "CLAVE";
            this.CLAVE.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CLAVE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // IMPORTE
            // 
            this.IMPORTE.HeaderText = "IMPORTE";
            this.IMPORTE.Name = "IMPORTE";
            // 
            // CB_sucursal
            // 
            this.CB_sucursal.FormattingEnabled = true;
            this.CB_sucursal.Items.AddRange(new object[] {
            "VALLARTA",
            "RENA",
            "COLOSO",
            "VELAZQUEZ",
            "PREGOT"});
            this.CB_sucursal.Location = new System.Drawing.Point(35, 28);
            this.CB_sucursal.Name = "CB_sucursal";
            this.CB_sucursal.Size = new System.Drawing.Size(121, 21);
            this.CB_sucursal.TabIndex = 2;
            // 
            // DG_egresos
            // 
            this.DG_egresos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DG_egresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_egresos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGO,
            this.IMPORTE_EGRE});
            this.DG_egresos.Location = new System.Drawing.Point(38, 270);
            this.DG_egresos.Name = "DG_egresos";
            this.DG_egresos.Size = new System.Drawing.Size(615, 150);
            this.DG_egresos.TabIndex = 3;
            // 
            // CODIGO
            // 
            this.CODIGO.HeaderText = "CONCEPTO";
            this.CODIGO.Items.AddRange(new object[] {
            "TARJ 6300 TARJETAS",
            "RETIR 6400 RETIRO DE EFECTIVO"});
            this.CODIGO.Name = "CODIGO";
            this.CODIGO.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CODIGO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // IMPORTE_EGRE
            // 
            this.IMPORTE_EGRE.HeaderText = "IMPORTE";
            this.IMPORTE_EGRE.Name = "IMPORTE_EGRE";
            // 
            // DT_fecha
            // 
            this.DT_fecha.Location = new System.Drawing.Point(450, 14);
            this.DT_fecha.Name = "DT_fecha";
            this.DT_fecha.Size = new System.Drawing.Size(200, 20);
            this.DT_fecha.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "INGRESOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "EGRESOS";
            // 
            // CBX_respaldo
            // 
            this.CBX_respaldo.AutoSize = true;
            this.CBX_respaldo.Location = new System.Drawing.Point(373, 17);
            this.CBX_respaldo.Name = "CBX_respaldo";
            this.CBX_respaldo.Size = new System.Drawing.Size(71, 17);
            this.CBX_respaldo.TabIndex = 7;
            this.CBX_respaldo.Text = "Respaldo";
            this.CBX_respaldo.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "SUCURSAL";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(188, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "CAJA";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CB_caja
            // 
            this.CB_caja.FormattingEnabled = true;
            this.CB_caja.Items.AddRange(new object[] {
            "CAJA1",
            "CAJA2",
            "CAJA3",
            "CAJA4",
            "CAJA5",
            "CAJA6",
            "CAJA7",
            "CAJA8"});
            this.CB_caja.Location = new System.Drawing.Point(188, 28);
            this.CB_caja.Name = "CB_caja";
            this.CB_caja.Size = new System.Drawing.Size(121, 21);
            this.CB_caja.TabIndex = 9;
            // 
            // BT_ventasTarj
            // 
            this.BT_ventasTarj.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_ventasTarj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_ventasTarj.ForeColor = System.Drawing.Color.White;
            this.BT_ventasTarj.Location = new System.Drawing.Point(560, 68);
            this.BT_ventasTarj.Name = "BT_ventasTarj";
            this.BT_ventasTarj.Size = new System.Drawing.Size(93, 40);
            this.BT_ventasTarj.TabIndex = 11;
            this.BT_ventasTarj.Text = "Total Venta Tarjetas";
            this.BT_ventasTarj.UseVisualStyleBackColor = false;
            this.BT_ventasTarj.Click += new System.EventHandler(this.BT_ventasTarj_Click);
            // 
            // TB_numClientes
            // 
            this.TB_numClientes.Location = new System.Drawing.Point(138, 436);
            this.TB_numClientes.Name = "TB_numClientes";
            this.TB_numClientes.Size = new System.Drawing.Size(59, 20);
            this.TB_numClientes.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 439);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Clientes atendidos";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CorteZ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(674, 488);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TB_numClientes);
            this.Controls.Add(this.BT_ventasTarj);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CB_caja);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CBX_respaldo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DT_fecha);
            this.Controls.Add(this.DG_egresos);
            this.Controls.Add(this.CB_sucursal);
            this.Controls.Add(this.DG_ingresos);
            this.Controls.Add(this.BT_crearTicket);
            this.Name = "CorteZ";
            this.Text = "CorteZ";
            this.Load += new System.EventHandler(this.CorteZ_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_ingresos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_egresos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_crearTicket;
        private System.Windows.Forms.DataGridView DG_ingresos;
        private System.Windows.Forms.ComboBox CB_sucursal;
        private System.Windows.Forms.DataGridView DG_egresos;
        private System.Windows.Forms.DateTimePicker DT_fecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewComboBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMPORTE_EGRE;
        private System.Windows.Forms.CheckBox CBX_respaldo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CB_caja;
        private System.Windows.Forms.Button BT_ventasTarj;
        private System.Windows.Forms.DataGridViewComboBoxColumn CLAVE;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMPORTE;
        private System.Windows.Forms.TextBox TB_numClientes;
        private System.Windows.Forms.Label label5;
    }
}