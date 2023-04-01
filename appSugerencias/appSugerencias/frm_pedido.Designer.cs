namespace appSugerencias
{
    partial class frm_pedido
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
            this.button1 = new System.Windows.Forms.Button();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.cBoxArea = new System.Windows.Forms.CheckBox();
            this.cbFiltro = new System.Windows.Forms.ComboBox();
            this.cbFiltro2 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.id_pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.link = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cotiz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compro_pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "Nuevo Pedido";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvPedidos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_pedido,
            this.titulo,
            this.fecha,
            this.periodo,
            this.Column1,
            this.proveedor,
            this.link,
            this.estatus,
            this.cotiz,
            this.nota,
            this.guia,
            this.compro_pago,
            this.forma,
            this.tipo_pago,
            this.observaciones});
            this.dgvPedidos.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvPedidos.Location = new System.Drawing.Point(12, 75);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedidos.Size = new System.Drawing.Size(1551, 535);
            this.dgvPedidos.TabIndex = 1;
            this.dgvPedidos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPedidos_CellDoubleClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(169, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 47);
            this.button2.TabIndex = 2;
            this.button2.Text = "Actualizar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cBoxArea
            // 
            this.cBoxArea.AutoSize = true;
            this.cBoxArea.Location = new System.Drawing.Point(12, 630);
            this.cBoxArea.Name = "cBoxArea";
            this.cBoxArea.Size = new System.Drawing.Size(48, 17);
            this.cBoxArea.TabIndex = 4;
            this.cBoxArea.Text = "Area";
            this.cBoxArea.UseVisualStyleBackColor = true;
            this.cBoxArea.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // cbFiltro
            // 
            this.cbFiltro.FormattingEnabled = true;
            this.cbFiltro.Items.AddRange(new object[] {
            "ESTADO",
            "PROVEEDOR",
            "AREA"});
            this.cbFiltro.Location = new System.Drawing.Point(892, 26);
            this.cbFiltro.Name = "cbFiltro";
            this.cbFiltro.Size = new System.Drawing.Size(121, 21);
            this.cbFiltro.TabIndex = 5;
            this.cbFiltro.TextChanged += new System.EventHandler(this.cbFiltro_TextChanged);
            // 
            // cbFiltro2
            // 
            this.cbFiltro2.FormattingEnabled = true;
            this.cbFiltro2.Location = new System.Drawing.Point(1033, 26);
            this.cbFiltro2.Name = "cbFiltro2";
            this.cbFiltro2.Size = new System.Drawing.Size(378, 21);
            this.cbFiltro2.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DodgerBlue;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(1426, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(137, 47);
            this.button3.TabIndex = 8;
            this.button3.Text = "Buscar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // id_pedido
            // 
            this.id_pedido.HeaderText = "Id Pedido";
            this.id_pedido.Name = "id_pedido";
            this.id_pedido.ReadOnly = true;
            this.id_pedido.Width = 50;
            // 
            // titulo
            // 
            this.titulo.HeaderText = "Titulo";
            this.titulo.Name = "titulo";
            this.titulo.ReadOnly = true;
            this.titulo.Width = 200;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.Width = 80;
            // 
            // periodo
            // 
            this.periodo.HeaderText = "Periodo";
            this.periodo.Name = "periodo";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Area";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // proveedor
            // 
            this.proveedor.HeaderText = "Proveedor";
            this.proveedor.Name = "proveedor";
            this.proveedor.Width = 200;
            // 
            // link
            // 
            this.link.HeaderText = "Enlace de Pedido";
            this.link.Name = "link";
            this.link.Width = 120;
            // 
            // estatus
            // 
            this.estatus.HeaderText = "Estatus";
            this.estatus.Name = "estatus";
            this.estatus.Width = 150;
            // 
            // cotiz
            // 
            this.cotiz.HeaderText = "Cotizacion";
            this.cotiz.Name = "cotiz";
            // 
            // nota
            // 
            this.nota.HeaderText = "Nota";
            this.nota.Name = "nota";
            this.nota.Width = 70;
            // 
            // guia
            // 
            this.guia.HeaderText = "Guia";
            this.guia.Name = "guia";
            this.guia.Width = 70;
            // 
            // compro_pago
            // 
            this.compro_pago.HeaderText = "Comprobante Pago";
            this.compro_pago.Name = "compro_pago";
            this.compro_pago.Width = 70;
            // 
            // forma
            // 
            this.forma.HeaderText = "Forma Pago";
            this.forma.Name = "forma";
            // 
            // tipo_pago
            // 
            this.tipo_pago.HeaderText = "Tipo Pago";
            this.tipo_pago.Name = "tipo_pago";
            // 
            // observaciones
            // 
            this.observaciones.HeaderText = "Observaciones";
            this.observaciones.Name = "observaciones";
            // 
            // frm_pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1617, 659);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.cbFiltro2);
            this.Controls.Add(this.cbFiltro);
            this.Controls.Add(this.cBoxArea);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgvPedidos);
            this.Controls.Add(this.button1);
            this.Name = "frm_pedido";
            this.Text = "frm_pedido";
            this.Load += new System.EventHandler(this.frm_pedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox cBoxArea;
        private System.Windows.Forms.ComboBox cbFiltro;
        private System.Windows.Forms.ComboBox cbFiltro2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn link;
        private System.Windows.Forms.DataGridViewTextBoxColumn estatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn cotiz;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota;
        private System.Windows.Forms.DataGridViewTextBoxColumn guia;
        private System.Windows.Forms.DataGridViewTextBoxColumn compro_pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn forma;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn observaciones;
    }
}