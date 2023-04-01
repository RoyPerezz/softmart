namespace appSugerencias
{
    partial class BuscarCortez
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
            this.CB_sucursal = new System.Windows.Forms.ComboBox();
            this.DT_inicio = new System.Windows.Forms.DateTimePicker();
            this.CB_caja = new System.Windows.Forms.ComboBox();
            this.DG_tabla = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FOLIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HORA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PAGOEFE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PAGOTARJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTALING = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTALEGR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTALCAJA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUMCL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BT_buscarTicket = new System.Windows.Forms.Button();
            this.DT_fin = new System.Windows.Forms.DateTimePicker();
            this.INICIO = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DG_tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // CB_sucursal
            // 
            this.CB_sucursal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CB_sucursal.FormattingEnabled = true;
            this.CB_sucursal.Items.AddRange(new object[] {
            "VALLARTA",
            "RENA",
            "VELAZQUEZ",
            "COLOSO",
            "PREGOT"});
            this.CB_sucursal.Location = new System.Drawing.Point(716, 12);
            this.CB_sucursal.Name = "CB_sucursal";
            this.CB_sucursal.Size = new System.Drawing.Size(121, 21);
            this.CB_sucursal.TabIndex = 0;
            // 
            // DT_inicio
            // 
            this.DT_inicio.Location = new System.Drawing.Point(56, 16);
            this.DT_inicio.Name = "DT_inicio";
            this.DT_inicio.Size = new System.Drawing.Size(200, 20);
            this.DT_inicio.TabIndex = 1;
            // 
            // CB_caja
            // 
            this.CB_caja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.CB_caja.Location = new System.Drawing.Point(716, 43);
            this.CB_caja.Name = "CB_caja";
            this.CB_caja.Size = new System.Drawing.Size(121, 21);
            this.CB_caja.TabIndex = 2;
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
            this.ID,
            this.FOLIO,
            this.ESTACION,
            this.FECHA,
            this.HORA,
            this.PAGOEFE,
            this.PAGOTARJ,
            this.TOTALING,
            this.TOTALEGR,
            this.TOTALCAJA,
            this.NUMCL});
            this.DG_tabla.Location = new System.Drawing.Point(14, 92);
            this.DG_tabla.Name = "DG_tabla";
            this.DG_tabla.Size = new System.Drawing.Size(944, 346);
            this.DG_tabla.TabIndex = 3;
            this.DG_tabla.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_tabla_CellDoubleClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // FOLIO
            // 
            this.FOLIO.HeaderText = "FOLIO";
            this.FOLIO.Name = "FOLIO";
            // 
            // ESTACION
            // 
            this.ESTACION.HeaderText = "ESTACION";
            this.ESTACION.Name = "ESTACION";
            // 
            // FECHA
            // 
            this.FECHA.HeaderText = "FECHA";
            this.FECHA.Name = "FECHA";
            // 
            // HORA
            // 
            this.HORA.HeaderText = "HORA";
            this.HORA.Name = "HORA";
            // 
            // PAGOEFE
            // 
            this.PAGOEFE.HeaderText = "PAGO EN EFE";
            this.PAGOEFE.Name = "PAGOEFE";
            // 
            // PAGOTARJ
            // 
            this.PAGOTARJ.HeaderText = "PAGO EN TARJ";
            this.PAGOTARJ.Name = "PAGOTARJ";
            // 
            // TOTALING
            // 
            this.TOTALING.HeaderText = "TOTAL INGRESO";
            this.TOTALING.Name = "TOTALING";
            // 
            // TOTALEGR
            // 
            this.TOTALEGR.HeaderText = "TOTAL EGRESO";
            this.TOTALEGR.Name = "TOTALEGR";
            // 
            // TOTALCAJA
            // 
            this.TOTALCAJA.HeaderText = "TOTAL EN CAJA";
            this.TOTALCAJA.Name = "TOTALCAJA";
            // 
            // NUMCL
            // 
            this.NUMCL.HeaderText = "NUM. CLIENTES";
            this.NUMCL.Name = "NUMCL";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(648, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "SUCURSAL";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(677, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "CAJA";
            // 
            // BT_buscarTicket
            // 
            this.BT_buscarTicket.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_buscarTicket.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_buscarTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_buscarTicket.ForeColor = System.Drawing.Color.White;
            this.BT_buscarTicket.Location = new System.Drawing.Point(860, 12);
            this.BT_buscarTicket.Name = "BT_buscarTicket";
            this.BT_buscarTicket.Size = new System.Drawing.Size(98, 52);
            this.BT_buscarTicket.TabIndex = 6;
            this.BT_buscarTicket.Text = "Buscar Corte";
            this.BT_buscarTicket.UseVisualStyleBackColor = false;
            this.BT_buscarTicket.Click += new System.EventHandler(this.BT_buscarTicket_Click);
            // 
            // DT_fin
            // 
            this.DT_fin.Location = new System.Drawing.Point(56, 46);
            this.DT_fin.Name = "DT_fin";
            this.DT_fin.Size = new System.Drawing.Size(200, 20);
            this.DT_fin.TabIndex = 7;
            // 
            // INICIO
            // 
            this.INICIO.AutoSize = true;
            this.INICIO.Location = new System.Drawing.Point(15, 18);
            this.INICIO.Name = "INICIO";
            this.INICIO.Size = new System.Drawing.Size(39, 13);
            this.INICIO.TabIndex = 8;
            this.INICIO.Text = "INICIO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "FIN";
            // 
            // BuscarCortez
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(970, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.INICIO);
            this.Controls.Add(this.DT_fin);
            this.Controls.Add(this.BT_buscarTicket);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DG_tabla);
            this.Controls.Add(this.CB_caja);
            this.Controls.Add(this.DT_inicio);
            this.Controls.Add(this.CB_sucursal);
            this.Name = "BuscarCortez";
            this.Text = "BuscarCortez";
            ((System.ComponentModel.ISupportInitialize)(this.DG_tabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CB_sucursal;
        private System.Windows.Forms.DateTimePicker DT_inicio;
        private System.Windows.Forms.ComboBox CB_caja;
        private System.Windows.Forms.DataGridView DG_tabla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BT_buscarTicket;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FOLIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PAGOEFE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PAGOTARJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTALING;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTALEGR;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTALCAJA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMCL;
        private System.Windows.Forms.DateTimePicker DT_fin;
        private System.Windows.Forms.Label INICIO;
        private System.Windows.Forms.Label label3;
    }
}