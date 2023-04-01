namespace appSugerencias
{
    partial class DepurarKardex
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
            this.BT_buscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_articulo = new System.Windows.Forms.TextBox();
            this.TB_descripcion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DG_tabla = new System.Windows.Forms.DataGridView();
            this.SUCURSAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EXISTENCIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_MOV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MOVIMIENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BT_eliminar = new System.Windows.Forms.Button();
            this.BT_cargar_excel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DG_tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // BT_buscar
            // 
            this.BT_buscar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_buscar.ForeColor = System.Drawing.Color.White;
            this.BT_buscar.Location = new System.Drawing.Point(484, 63);
            this.BT_buscar.Name = "BT_buscar";
            this.BT_buscar.Size = new System.Drawing.Size(88, 56);
            this.BT_buscar.TabIndex = 0;
            this.BT_buscar.Text = "Buscar";
            this.BT_buscar.UseVisualStyleBackColor = false;
            this.BT_buscar.Click += new System.EventHandler(this.BT_buscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Introduce el artículo";
            // 
            // TB_articulo
            // 
            this.TB_articulo.Location = new System.Drawing.Point(124, 18);
            this.TB_articulo.Name = "TB_articulo";
            this.TB_articulo.Size = new System.Drawing.Size(243, 20);
            this.TB_articulo.TabIndex = 3;
            this.TB_articulo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_articulo_KeyDown_1);
            // 
            // TB_descripcion
            // 
            this.TB_descripcion.Location = new System.Drawing.Point(124, 56);
            this.TB_descripcion.Name = "TB_descripcion";
            this.TB_descripcion.Size = new System.Drawing.Size(243, 20);
            this.TB_descripcion.TabIndex = 15;
            this.TB_descripcion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_descripcion_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Descripción";
            // 
            // DG_tabla
            // 
            this.DG_tabla.AllowUserToAddRows = false;
            this.DG_tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SUCURSAL,
            this.EXISTENCIA,
            this.FECHA_MOV,
            this.MOVIMIENTO});
            this.DG_tabla.Location = new System.Drawing.Point(23, 86);
            this.DG_tabla.Name = "DG_tabla";
            this.DG_tabla.Size = new System.Drawing.Size(446, 161);
            this.DG_tabla.TabIndex = 16;
            // 
            // SUCURSAL
            // 
            this.SUCURSAL.HeaderText = "SUCURSAL";
            this.SUCURSAL.Name = "SUCURSAL";
            // 
            // EXISTENCIA
            // 
            this.EXISTENCIA.HeaderText = "EXISTENCIA";
            this.EXISTENCIA.Name = "EXISTENCIA";
            // 
            // FECHA_MOV
            // 
            this.FECHA_MOV.HeaderText = "ULTIMO MOV";
            this.FECHA_MOV.Name = "FECHA_MOV";
            // 
            // MOVIMIENTO
            // 
            this.MOVIMIENTO.HeaderText = "MOV";
            this.MOVIMIENTO.Name = "MOVIMIENTO";
            // 
            // BT_eliminar
            // 
            this.BT_eliminar.BackColor = System.Drawing.Color.Red;
            this.BT_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_eliminar.ForeColor = System.Drawing.Color.White;
            this.BT_eliminar.Location = new System.Drawing.Point(484, 129);
            this.BT_eliminar.Name = "BT_eliminar";
            this.BT_eliminar.Size = new System.Drawing.Size(88, 56);
            this.BT_eliminar.TabIndex = 17;
            this.BT_eliminar.Text = "Eliminar";
            this.BT_eliminar.UseVisualStyleBackColor = false;
            this.BT_eliminar.Click += new System.EventHandler(this.BT_eliminar_Click);
            // 
            // BT_cargar_excel
            // 
            this.BT_cargar_excel.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.BT_cargar_excel.Enabled = false;
            this.BT_cargar_excel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_cargar_excel.ForeColor = System.Drawing.Color.White;
            this.BT_cargar_excel.Location = new System.Drawing.Point(483, 191);
            this.BT_cargar_excel.Name = "BT_cargar_excel";
            this.BT_cargar_excel.Size = new System.Drawing.Size(88, 56);
            this.BT_cargar_excel.TabIndex = 18;
            this.BT_cargar_excel.Text = "Cargar excel";
            this.BT_cargar_excel.UseVisualStyleBackColor = false;
            this.BT_cargar_excel.Click += new System.EventHandler(this.BT_cargar_excel_Click);
            // 
            // DepurarKardex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(606, 273);
            this.Controls.Add(this.BT_cargar_excel);
            this.Controls.Add(this.BT_eliminar);
            this.Controls.Add(this.DG_tabla);
            this.Controls.Add(this.TB_descripcion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TB_articulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BT_buscar);
            this.Name = "DepurarKardex";
            this.Text = "DepurarKardex";
            this.Load += new System.EventHandler(this.DepurarKardex_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DepurarKardex_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.DG_tabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_buscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_descripcion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView DG_tabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUCURSAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn EXISTENCIA;
        private System.Windows.Forms.Button BT_eliminar;
        public System.Windows.Forms.TextBox TB_articulo;
        private System.Windows.Forms.Button BT_cargar_excel;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_MOV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MOVIMIENTO;
    }
}