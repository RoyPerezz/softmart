namespace appSugerencias
{
    partial class StockLineaProv
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
            this.CB_proveedor = new System.Windows.Forms.ComboBox();
            this.CB_linea = new System.Windows.Forms.ComboBox();
            this.BT_buscar = new System.Windows.Forms.Button();
            this.DG_tabla = new System.Windows.Forms.DataGridView();
            this.BT_exportar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ARTICULO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAXCE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEDIS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PEDCE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAXVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALLARTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PEDVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAXRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RENA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PEDRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAXVE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VELAZQUEZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PEDVE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAXCO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COLOSO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PEDCO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DG_tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // CB_proveedor
            // 
            this.CB_proveedor.FormattingEnabled = true;
            this.CB_proveedor.Location = new System.Drawing.Point(12, 35);
            this.CB_proveedor.Name = "CB_proveedor";
            this.CB_proveedor.Size = new System.Drawing.Size(325, 21);
            this.CB_proveedor.TabIndex = 0;
            // 
            // CB_linea
            // 
            this.CB_linea.FormattingEnabled = true;
            this.CB_linea.Location = new System.Drawing.Point(384, 35);
            this.CB_linea.Name = "CB_linea";
            this.CB_linea.Size = new System.Drawing.Size(214, 21);
            this.CB_linea.TabIndex = 1;
            // 
            // BT_buscar
            // 
            this.BT_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_buscar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_buscar.ForeColor = System.Drawing.Color.White;
            this.BT_buscar.Location = new System.Drawing.Point(1091, 23);
            this.BT_buscar.Name = "BT_buscar";
            this.BT_buscar.Size = new System.Drawing.Size(93, 43);
            this.BT_buscar.TabIndex = 2;
            this.BT_buscar.Text = "BUSCAR";
            this.BT_buscar.UseVisualStyleBackColor = false;
            this.BT_buscar.Click += new System.EventHandler(this.BT_buscar_Click);
            // 
            // DG_tabla
            // 
            this.DG_tabla.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DG_tabla.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DG_tabla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DG_tabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DG_tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ARTICULO,
            this.DESCRIPCION,
            this.MAXCE,
            this.CEDIS,
            this.PEDCE,
            this.MAXVA,
            this.VALLARTA,
            this.PEDVA,
            this.MAXRE,
            this.RENA,
            this.PEDRE,
            this.MAXVE,
            this.VELAZQUEZ,
            this.PEDVE,
            this.MAXCO,
            this.COLOSO,
            this.PEDCO});
            this.DG_tabla.Location = new System.Drawing.Point(2, 85);
            this.DG_tabla.Name = "DG_tabla";
            this.DG_tabla.Size = new System.Drawing.Size(1294, 353);
            this.DG_tabla.TabIndex = 3;
            // 
            // BT_exportar
            // 
            this.BT_exportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_exportar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_exportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_exportar.ForeColor = System.Drawing.Color.White;
            this.BT_exportar.Location = new System.Drawing.Point(1190, 23);
            this.BT_exportar.Name = "BT_exportar";
            this.BT_exportar.Size = new System.Drawing.Size(93, 43);
            this.BT_exportar.TabIndex = 4;
            this.BT_exportar.Text = "EXPORTAR";
            this.BT_exportar.UseVisualStyleBackColor = false;
            this.BT_exportar.Click += new System.EventHandler(this.BT_exportar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "PROVEEDOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(381, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "LINEA";
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
            // MAXCE
            // 
            this.MAXCE.HeaderText = "MAX CE";
            this.MAXCE.Name = "MAXCE";
            // 
            // CEDIS
            // 
            this.CEDIS.HeaderText = "CEDIS";
            this.CEDIS.Name = "CEDIS";
            // 
            // PEDCE
            // 
            this.PEDCE.HeaderText = "PED CE";
            this.PEDCE.Name = "PEDCE";
            // 
            // MAXVA
            // 
            this.MAXVA.HeaderText = "MAX VA";
            this.MAXVA.Name = "MAXVA";
            // 
            // VALLARTA
            // 
            this.VALLARTA.HeaderText = "VALLARTA";
            this.VALLARTA.Name = "VALLARTA";
            // 
            // PEDVA
            // 
            this.PEDVA.HeaderText = "PED VA";
            this.PEDVA.Name = "PEDVA";
            // 
            // MAXRE
            // 
            this.MAXRE.HeaderText = "MAX RE";
            this.MAXRE.Name = "MAXRE";
            // 
            // RENA
            // 
            this.RENA.HeaderText = "RENA";
            this.RENA.Name = "RENA";
            // 
            // PEDRE
            // 
            this.PEDRE.HeaderText = "PED RE";
            this.PEDRE.Name = "PEDRE";
            // 
            // MAXVE
            // 
            this.MAXVE.HeaderText = "MAX VE";
            this.MAXVE.Name = "MAXVE";
            // 
            // VELAZQUEZ
            // 
            this.VELAZQUEZ.HeaderText = "VELAZQUEZ";
            this.VELAZQUEZ.Name = "VELAZQUEZ";
            // 
            // PEDVE
            // 
            this.PEDVE.HeaderText = "PED VE";
            this.PEDVE.Name = "PEDVE";
            // 
            // MAXCO
            // 
            this.MAXCO.HeaderText = "MAX CO";
            this.MAXCO.Name = "MAXCO";
            // 
            // COLOSO
            // 
            this.COLOSO.HeaderText = "COLOSO";
            this.COLOSO.Name = "COLOSO";
            // 
            // PEDCO
            // 
            this.PEDCO.HeaderText = "PED CO";
            this.PEDCO.Name = "PEDCO";
            // 
            // StockLineaProv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1295, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BT_exportar);
            this.Controls.Add(this.DG_tabla);
            this.Controls.Add(this.BT_buscar);
            this.Controls.Add(this.CB_linea);
            this.Controls.Add(this.CB_proveedor);
            this.Name = "StockLineaProv";
            this.Text = "STOCK DE LINEAS POR PROVEEDOR";
            this.Load += new System.EventHandler(this.StockLineaProv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_tabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CB_proveedor;
        private System.Windows.Forms.ComboBox CB_linea;
        private System.Windows.Forms.Button BT_buscar;
        private System.Windows.Forms.DataGridView DG_tabla;
        private System.Windows.Forms.Button BT_exportar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ARTICULO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAXCE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEDIS;
        private System.Windows.Forms.DataGridViewTextBoxColumn PEDCE;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAXVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALLARTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PEDVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAXRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn RENA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PEDRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAXVE;
        private System.Windows.Forms.DataGridViewTextBoxColumn VELAZQUEZ;
        private System.Windows.Forms.DataGridViewTextBoxColumn PEDVE;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAXCO;
        private System.Windows.Forms.DataGridViewTextBoxColumn COLOSO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PEDCO;
    }
}