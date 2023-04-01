namespace appSugerencias
{
    partial class Aux_AgregarArticuloStock
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
            this.ARTICULO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DG_tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // DG_tabla
            // 
            this.DG_tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ARTICULO,
            this.DESCRIPCION});
            this.DG_tabla.Location = new System.Drawing.Point(1, 1);
            this.DG_tabla.Name = "DG_tabla";
            this.DG_tabla.Size = new System.Drawing.Size(403, 447);
            this.DG_tabla.TabIndex = 0;
            this.DG_tabla.CellStateChanged += new System.Windows.Forms.DataGridViewCellStateChangedEventHandler(this.DG_tabla_CellStateChanged);
            this.DG_tabla.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_tabla_RowEnter);
            this.DG_tabla.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DG_tabla_KeyDown);
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
            // Aux_AgregarArticuloStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 450);
            this.Controls.Add(this.DG_tabla);
            this.Name = "Aux_AgregarArticuloStock";
            this.Text = "Aux_AgregarArticuloStock";
            this.Load += new System.EventHandler(this.Aux_AgregarArticuloStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_tabla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DG_tabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn ARTICULO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
    }
}