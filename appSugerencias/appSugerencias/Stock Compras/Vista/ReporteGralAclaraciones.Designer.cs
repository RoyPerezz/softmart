
namespace appSugerencias.Stock_Compras.Vista
{
    partial class ReporteGralAclaraciones
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
            this.DESCRIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PZXPAQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COSTO_PAQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COSTO_PZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FALTA_VA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MEDO_VA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOBRA_VA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMPORTE_VA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FALTA_RE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MEDO_RE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOBRA_RE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMPORTE_RE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FALTA_VE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MEDO_VE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOBRA_VE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMPORTE_VE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FALTA_CO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MEDO_CO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOBRA_CO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMPORTE_CO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL_FALTANTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL_SOBRANTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMPORTE_TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CB_stock = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CB_proveedor = new System.Windows.Forms.ComboBox();
            this.TB_id = new System.Windows.Forms.TextBox();
            this.BT_buscar = new System.Windows.Forms.Button();
            this.TB_idStock = new System.Windows.Forms.TextBox();
            this.BT_guardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DG_tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // DG_tabla
            // 
            this.DG_tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.MODELO,
            this.CLAVE,
            this.DESCRIP,
            this.PZXPAQ,
            this.COSTO_PAQ,
            this.COSTO_PZ,
            this.FALTA_VA,
            this.MEDO_VA,
            this.SOBRA_VA,
            this.IMPORTE_VA,
            this.FALTA_RE,
            this.MEDO_RE,
            this.SOBRA_RE,
            this.IMPORTE_RE,
            this.FALTA_VE,
            this.MEDO_VE,
            this.SOBRA_VE,
            this.IMPORTE_VE,
            this.FALTA_CO,
            this.MEDO_CO,
            this.SOBRA_CO,
            this.IMPORTE_CO,
            this.TOTAL_FALTANTE,
            this.TOTAL_SOBRANTE,
            this.IMPORTE_TOTAL});
            this.DG_tabla.Location = new System.Drawing.Point(1, 82);
            this.DG_tabla.Name = "DG_tabla";
            this.DG_tabla.Size = new System.Drawing.Size(2643, 356);
            this.DG_tabla.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
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
            // DESCRIP
            // 
            this.DESCRIP.HeaderText = "DESCRIPCION";
            this.DESCRIP.Name = "DESCRIP";
            // 
            // PZXPAQ
            // 
            this.PZXPAQ.HeaderText = "PZ X PAQ";
            this.PZXPAQ.Name = "PZXPAQ";
            // 
            // COSTO_PAQ
            // 
            this.COSTO_PAQ.HeaderText = "COSTO X PAQ";
            this.COSTO_PAQ.Name = "COSTO_PAQ";
            // 
            // COSTO_PZ
            // 
            this.COSTO_PZ.HeaderText = "COSTO X PZ";
            this.COSTO_PZ.Name = "COSTO_PZ";
            // 
            // FALTA_VA
            // 
            this.FALTA_VA.HeaderText = "FALTA VA";
            this.FALTA_VA.Name = "FALTA_VA";
            // 
            // MEDO_VA
            // 
            this.MEDO_VA.HeaderText = "M EDO VA";
            this.MEDO_VA.Name = "MEDO_VA";
            // 
            // SOBRA_VA
            // 
            this.SOBRA_VA.HeaderText = "SOBRA VA";
            this.SOBRA_VA.Name = "SOBRA_VA";
            // 
            // IMPORTE_VA
            // 
            this.IMPORTE_VA.HeaderText = "IMPORTE VA";
            this.IMPORTE_VA.Name = "IMPORTE_VA";
            // 
            // FALTA_RE
            // 
            this.FALTA_RE.HeaderText = "FALTA RE";
            this.FALTA_RE.Name = "FALTA_RE";
            // 
            // MEDO_RE
            // 
            this.MEDO_RE.HeaderText = "M EDO RE";
            this.MEDO_RE.Name = "MEDO_RE";
            // 
            // SOBRA_RE
            // 
            this.SOBRA_RE.HeaderText = "SOBRA RE";
            this.SOBRA_RE.Name = "SOBRA_RE";
            // 
            // IMPORTE_RE
            // 
            this.IMPORTE_RE.HeaderText = "IMPORTE RE";
            this.IMPORTE_RE.Name = "IMPORTE_RE";
            // 
            // FALTA_VE
            // 
            this.FALTA_VE.HeaderText = "FALTA VE";
            this.FALTA_VE.Name = "FALTA_VE";
            // 
            // MEDO_VE
            // 
            this.MEDO_VE.HeaderText = "M EDO VE";
            this.MEDO_VE.Name = "MEDO_VE";
            // 
            // SOBRA_VE
            // 
            this.SOBRA_VE.HeaderText = "SOBRA VE";
            this.SOBRA_VE.Name = "SOBRA_VE";
            // 
            // IMPORTE_VE
            // 
            this.IMPORTE_VE.HeaderText = "IMPORTE VE";
            this.IMPORTE_VE.Name = "IMPORTE_VE";
            // 
            // FALTA_CO
            // 
            this.FALTA_CO.HeaderText = "FALTA CO";
            this.FALTA_CO.Name = "FALTA_CO";
            // 
            // MEDO_CO
            // 
            this.MEDO_CO.HeaderText = "M EDO CO";
            this.MEDO_CO.Name = "MEDO_CO";
            // 
            // SOBRA_CO
            // 
            this.SOBRA_CO.HeaderText = "SOBRA CO";
            this.SOBRA_CO.Name = "SOBRA_CO";
            // 
            // IMPORTE_CO
            // 
            this.IMPORTE_CO.HeaderText = "IMPORTE CO";
            this.IMPORTE_CO.Name = "IMPORTE_CO";
            // 
            // TOTAL_FALTANTE
            // 
            this.TOTAL_FALTANTE.HeaderText = "TOTAL FALTANTE";
            this.TOTAL_FALTANTE.Name = "TOTAL_FALTANTE";
            // 
            // TOTAL_SOBRANTE
            // 
            this.TOTAL_SOBRANTE.HeaderText = "TOTAL SOBRANTE";
            this.TOTAL_SOBRANTE.Name = "TOTAL_SOBRANTE";
            // 
            // IMPORTE_TOTAL
            // 
            this.IMPORTE_TOTAL.HeaderText = "IMPORTE TOTAL";
            this.IMPORTE_TOTAL.Name = "IMPORTE_TOTAL";
            // 
            // CB_stock
            // 
            this.CB_stock.FormattingEnabled = true;
            this.CB_stock.Location = new System.Drawing.Point(104, 40);
            this.CB_stock.Name = "CB_stock";
            this.CB_stock.Size = new System.Drawing.Size(310, 21);
            this.CB_stock.TabIndex = 1;
            this.CB_stock.SelectedIndexChanged += new System.EventHandler(this.CB_stock_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Stock";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Proveedor";
            // 
            // CB_proveedor
            // 
            this.CB_proveedor.FormattingEnabled = true;
            this.CB_proveedor.Location = new System.Drawing.Point(104, 12);
            this.CB_proveedor.Name = "CB_proveedor";
            this.CB_proveedor.Size = new System.Drawing.Size(310, 21);
            this.CB_proveedor.TabIndex = 3;
            this.CB_proveedor.SelectedIndexChanged += new System.EventHandler(this.CB_proveedor_SelectedIndexChanged);
            this.CB_proveedor.TextUpdate += new System.EventHandler(this.CB_proveedor_TextUpdate);
            this.CB_proveedor.DisplayMemberChanged += new System.EventHandler(this.CB_proveedor_DisplayMemberChanged);
            // 
            // TB_id
            // 
            this.TB_id.Location = new System.Drawing.Point(420, 12);
            this.TB_id.Name = "TB_id";
            this.TB_id.Size = new System.Drawing.Size(71, 20);
            this.TB_id.TabIndex = 5;
            // 
            // BT_buscar
            // 
            this.BT_buscar.Location = new System.Drawing.Point(497, 10);
            this.BT_buscar.Name = "BT_buscar";
            this.BT_buscar.Size = new System.Drawing.Size(110, 50);
            this.BT_buscar.TabIndex = 6;
            this.BT_buscar.Text = "Buscar";
            this.BT_buscar.UseVisualStyleBackColor = true;
            this.BT_buscar.Click += new System.EventHandler(this.BT_buscar_Click);
            // 
            // TB_idStock
            // 
            this.TB_idStock.Location = new System.Drawing.Point(420, 40);
            this.TB_idStock.Name = "TB_idStock";
            this.TB_idStock.Size = new System.Drawing.Size(71, 20);
            this.TB_idStock.TabIndex = 7;
            // 
            // BT_guardar
            // 
            this.BT_guardar.Location = new System.Drawing.Point(622, 10);
            this.BT_guardar.Name = "BT_guardar";
            this.BT_guardar.Size = new System.Drawing.Size(110, 50);
            this.BT_guardar.TabIndex = 8;
            this.BT_guardar.Text = "Guardar";
            this.BT_guardar.UseVisualStyleBackColor = true;
            // 
            // ReporteGralAclaraciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2636, 450);
            this.Controls.Add(this.BT_guardar);
            this.Controls.Add(this.TB_idStock);
            this.Controls.Add(this.BT_buscar);
            this.Controls.Add(this.TB_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CB_proveedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CB_stock);
            this.Controls.Add(this.DG_tabla);
            this.Name = "ReporteGralAclaraciones";
            this.Text = "ReporteGralAclaraciones";
            this.Load += new System.EventHandler(this.ReporteGralAclaraciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_tabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DG_tabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MODELO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLAVE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIP;
        private System.Windows.Forms.DataGridViewTextBoxColumn PZXPAQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn COSTO_PAQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn COSTO_PZ;
        private System.Windows.Forms.DataGridViewTextBoxColumn FALTA_VA;
        private System.Windows.Forms.DataGridViewTextBoxColumn MEDO_VA;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOBRA_VA;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMPORTE_VA;
        private System.Windows.Forms.DataGridViewTextBoxColumn FALTA_RE;
        private System.Windows.Forms.DataGridViewTextBoxColumn MEDO_RE;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOBRA_RE;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMPORTE_RE;
        private System.Windows.Forms.DataGridViewTextBoxColumn FALTA_VE;
        private System.Windows.Forms.DataGridViewTextBoxColumn MEDO_VE;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOBRA_VE;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMPORTE_VE;
        private System.Windows.Forms.DataGridViewTextBoxColumn FALTA_CO;
        private System.Windows.Forms.DataGridViewTextBoxColumn MEDO_CO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOBRA_CO;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMPORTE_CO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL_FALTANTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL_SOBRANTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMPORTE_TOTAL;
        private System.Windows.Forms.ComboBox CB_stock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CB_proveedor;
        private System.Windows.Forms.TextBox TB_id;
        private System.Windows.Forms.Button BT_buscar;
        private System.Windows.Forms.TextBox TB_idStock;
        private System.Windows.Forms.Button BT_guardar;
    }
}