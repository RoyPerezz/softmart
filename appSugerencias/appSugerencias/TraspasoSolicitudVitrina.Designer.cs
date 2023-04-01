namespace appSugerencias
{
    partial class TraspasoSolicitudVitrina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TraspasoSolicitudVitrina));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label5 = new System.Windows.Forms.Label();
            this.LB_filas = new System.Windows.Forms.Label();
            this.BT_guardar = new System.Windows.Forms.Button();
            this.BT_quitar = new System.Windows.Forms.Button();
            this.BT_agregar = new System.Windows.Forms.Button();
            this.TB_articulo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CB_destino = new System.Windows.Forms.ComboBox();
            this.TB_origen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_motivo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DG_datos = new System.Windows.Forms.DataGridView();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EXIST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DT_fecha = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.DG_datos)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(571, 382);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "productos";
            // 
            // LB_filas
            // 
            this.LB_filas.AutoSize = true;
            this.LB_filas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_filas.Location = new System.Drawing.Point(533, 383);
            this.LB_filas.Name = "LB_filas";
            this.LB_filas.Size = new System.Drawing.Size(19, 20);
            this.LB_filas.TabIndex = 28;
            this.LB_filas.Text = "0";
            // 
            // BT_guardar
            // 
            this.BT_guardar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_guardar.ForeColor = System.Drawing.SystemColors.Control;
            this.BT_guardar.Image = ((System.Drawing.Image)(resources.GetObject("BT_guardar.Image")));
            this.BT_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_guardar.Location = new System.Drawing.Point(667, 323);
            this.BT_guardar.Name = "BT_guardar";
            this.BT_guardar.Size = new System.Drawing.Size(136, 56);
            this.BT_guardar.TabIndex = 27;
            this.BT_guardar.Text = "Guardar";
            this.BT_guardar.UseVisualStyleBackColor = false;
            this.BT_guardar.Click += new System.EventHandler(this.BT_guardar_Click);
            // 
            // BT_quitar
            // 
            this.BT_quitar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_quitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_quitar.ForeColor = System.Drawing.SystemColors.Control;
            this.BT_quitar.Image = ((System.Drawing.Image)(resources.GetObject("BT_quitar.Image")));
            this.BT_quitar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_quitar.Location = new System.Drawing.Point(667, 242);
            this.BT_quitar.Name = "BT_quitar";
            this.BT_quitar.Size = new System.Drawing.Size(136, 56);
            this.BT_quitar.TabIndex = 26;
            this.BT_quitar.Text = "Quitar";
            this.BT_quitar.UseVisualStyleBackColor = false;
            this.BT_quitar.Click += new System.EventHandler(this.BT_quitar_Click);
            // 
            // BT_agregar
            // 
            this.BT_agregar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_agregar.ForeColor = System.Drawing.SystemColors.Control;
            this.BT_agregar.Image = ((System.Drawing.Image)(resources.GetObject("BT_agregar.Image")));
            this.BT_agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_agregar.Location = new System.Drawing.Point(667, 161);
            this.BT_agregar.Name = "BT_agregar";
            this.BT_agregar.Size = new System.Drawing.Size(136, 56);
            this.BT_agregar.TabIndex = 25;
            this.BT_agregar.Text = "Agregar";
            this.BT_agregar.UseVisualStyleBackColor = false;
            this.BT_agregar.Click += new System.EventHandler(this.BT_agregar_Click);
            // 
            // TB_articulo
            // 
            this.TB_articulo.Location = new System.Drawing.Point(74, 130);
            this.TB_articulo.Name = "TB_articulo";
            this.TB_articulo.Size = new System.Drawing.Size(587, 20);
            this.TB_articulo.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 18);
            this.label4.TabIndex = 23;
            this.label4.Text = "Artículo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(468, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 18);
            this.label3.TabIndex = 22;
            this.label3.Text = "Destino";
            // 
            // CB_destino
            // 
            this.CB_destino.FormattingEnabled = true;
            this.CB_destino.Items.AddRange(new object[] {
            "BO",
            "CO",
            "RE",
            "VA",
            "VE",
            "PREGOT"});
            this.CB_destino.Location = new System.Drawing.Point(540, 55);
            this.CB_destino.Name = "CB_destino";
            this.CB_destino.Size = new System.Drawing.Size(121, 21);
            this.CB_destino.TabIndex = 21;
            // 
            // TB_origen
            // 
            this.TB_origen.Enabled = false;
            this.TB_origen.Location = new System.Drawing.Point(73, 58);
            this.TB_origen.Name = "TB_origen";
            this.TB_origen.Size = new System.Drawing.Size(121, 20);
            this.TB_origen.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "Origen";
            // 
            // TB_motivo
            // 
            this.TB_motivo.Location = new System.Drawing.Point(73, 84);
            this.TB_motivo.Name = "TB_motivo";
            this.TB_motivo.Size = new System.Drawing.Size(588, 20);
            this.TB_motivo.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "Motivo";
            // 
            // DG_datos
            // 
            this.DG_datos.AllowUserToAddRows = false;
            this.DG_datos.AllowUserToOrderColumns = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.DG_datos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DG_datos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DG_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_datos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGO,
            this.DESCRIP,
            this.EXIST,
            this.CANT});
            this.DG_datos.Location = new System.Drawing.Point(12, 161);
            this.DG_datos.Name = "DG_datos";
            this.DG_datos.Size = new System.Drawing.Size(649, 218);
            this.DG_datos.TabIndex = 16;
            // 
            // CODIGO
            // 
            this.CODIGO.HeaderText = "CÓDIGO";
            this.CODIGO.Name = "CODIGO";
            // 
            // DESCRIP
            // 
            this.DESCRIP.HeaderText = "DESCRIPCION";
            this.DESCRIP.Name = "DESCRIP";
            // 
            // EXIST
            // 
            this.EXIST.HeaderText = "EXISTENCIA";
            this.EXIST.Name = "EXIST";
            // 
            // CANT
            // 
            this.CANT.HeaderText = "CANTIDAD";
            this.CANT.Name = "CANT";
            // 
            // DT_fecha
            // 
            this.DT_fecha.Enabled = false;
            this.DT_fecha.Location = new System.Drawing.Point(262, 16);
            this.DT_fecha.Name = "DT_fecha";
            this.DT_fecha.Size = new System.Drawing.Size(200, 20);
            this.DT_fecha.TabIndex = 15;
            // 
            // TraspasoSolicitudVitrina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 421);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LB_filas);
            this.Controls.Add(this.BT_guardar);
            this.Controls.Add(this.BT_quitar);
            this.Controls.Add(this.BT_agregar);
            this.Controls.Add(this.TB_articulo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CB_destino);
            this.Controls.Add(this.TB_origen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_motivo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DG_datos);
            this.Controls.Add(this.DT_fecha);
            this.Name = "TraspasoSolicitudVitrina";
            this.Text = "TraspasoSolicitudVitrina";
            this.Load += new System.EventHandler(this.TraspasoSolicitudVitrina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LB_filas;
        private System.Windows.Forms.Button BT_guardar;
        private System.Windows.Forms.Button BT_quitar;
        private System.Windows.Forms.Button BT_agregar;
        private System.Windows.Forms.TextBox TB_articulo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CB_destino;
        private System.Windows.Forms.TextBox TB_origen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_motivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DG_datos;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIP;
        private System.Windows.Forms.DataGridViewTextBoxColumn EXIST;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANT;
        private System.Windows.Forms.DateTimePicker DT_fecha;
    }
}