namespace appSugerencias
{
    partial class FormatoIntercambio
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
            this.ORIGEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALLARTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RENA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VELAZQUEZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COLOSO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LINEA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DT_inicio = new System.Windows.Forms.DateTimePicker();
            this.BT_buscar = new System.Windows.Forms.Button();
            this.BT_exportar = new System.Windows.Forms.Button();
            this.DT_fin = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.DG_tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // DG_tabla
            // 
            this.DG_tabla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DG_tabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DG_tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ARTICULO,
            this.DESCRIPCION,
            this.ORIGEN,
            this.VALLARTA,
            this.RENA,
            this.VELAZQUEZ,
            this.COLOSO,
            this.LINEA});
            this.DG_tabla.Location = new System.Drawing.Point(0, 119);
            this.DG_tabla.Name = "DG_tabla";
            this.DG_tabla.Size = new System.Drawing.Size(1035, 331);
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
            // ORIGEN
            // 
            this.ORIGEN.HeaderText = "TIENDA QUE ENVIA";
            this.ORIGEN.Name = "ORIGEN";
            this.ORIGEN.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // VALLARTA
            // 
            this.VALLARTA.HeaderText = "VALLARTA";
            this.VALLARTA.Name = "VALLARTA";
            // 
            // RENA
            // 
            this.RENA.HeaderText = "RENA";
            this.RENA.Name = "RENA";
            // 
            // VELAZQUEZ
            // 
            this.VELAZQUEZ.HeaderText = "VELAZQUEZ";
            this.VELAZQUEZ.Name = "VELAZQUEZ";
            // 
            // COLOSO
            // 
            this.COLOSO.HeaderText = "COLOSO";
            this.COLOSO.Name = "COLOSO";
            // 
            // LINEA
            // 
            this.LINEA.HeaderText = "LINEA";
            this.LINEA.Name = "LINEA";
            // 
            // DT_inicio
            // 
            this.DT_inicio.Location = new System.Drawing.Point(12, 22);
            this.DT_inicio.Name = "DT_inicio";
            this.DT_inicio.Size = new System.Drawing.Size(200, 20);
            this.DT_inicio.TabIndex = 1;
            // 
            // BT_buscar
            // 
            this.BT_buscar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_buscar.ForeColor = System.Drawing.Color.White;
            this.BT_buscar.Location = new System.Drawing.Point(249, 22);
            this.BT_buscar.Name = "BT_buscar";
            this.BT_buscar.Size = new System.Drawing.Size(84, 47);
            this.BT_buscar.TabIndex = 2;
            this.BT_buscar.Text = "Buscar";
            this.BT_buscar.UseVisualStyleBackColor = false;
            this.BT_buscar.Click += new System.EventHandler(this.BT_buscar_Click);
            // 
            // BT_exportar
            // 
            this.BT_exportar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_exportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_exportar.ForeColor = System.Drawing.Color.White;
            this.BT_exportar.Location = new System.Drawing.Point(339, 22);
            this.BT_exportar.Name = "BT_exportar";
            this.BT_exportar.Size = new System.Drawing.Size(84, 47);
            this.BT_exportar.TabIndex = 3;
            this.BT_exportar.Text = "EXPORTAR";
            this.BT_exportar.UseVisualStyleBackColor = false;
            this.BT_exportar.Click += new System.EventHandler(this.BT_exportar_Click);
            // 
            // DT_fin
            // 
            this.DT_fin.Location = new System.Drawing.Point(12, 61);
            this.DT_fin.Name = "DT_fin";
            this.DT_fin.Size = new System.Drawing.Size(200, 20);
            this.DT_fin.TabIndex = 4;
            // 
            // FormatoIntercambio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1036, 449);
            this.Controls.Add(this.DT_fin);
            this.Controls.Add(this.BT_exportar);
            this.Controls.Add(this.BT_buscar);
            this.Controls.Add(this.DT_inicio);
            this.Controls.Add(this.DG_tabla);
            this.Name = "FormatoIntercambio";
            this.Text = "Formato de Intercambio";
            this.Load += new System.EventHandler(this.VerificarEntradaSalida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_tabla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView DG_tabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn ARTICULO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn ORIGEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALLARTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn RENA;
        private System.Windows.Forms.DataGridViewTextBoxColumn VELAZQUEZ;
        private System.Windows.Forms.DataGridViewTextBoxColumn COLOSO;
        private System.Windows.Forms.DataGridViewTextBoxColumn LINEA;
        private System.Windows.Forms.DateTimePicker DT_inicio;
        private System.Windows.Forms.Button BT_buscar;
        private System.Windows.Forms.Button BT_exportar;
        private System.Windows.Forms.DateTimePicker DT_fin;
    }
}