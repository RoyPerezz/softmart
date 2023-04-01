
namespace appSugerencias.GastosCedis.Vistas
{
    partial class ListadoGastosCedis
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
            this.BT_buscar = new System.Windows.Forms.Button();
            this.DT_inicio = new System.Windows.Forms.DateTimePicker();
            this.DT_fin = new System.Windows.Forms.DateTimePicker();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CONCEPTOGRAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CONCEPTODETALLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMPORTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FOLIOSALIDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMAGEN1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBREFOTO1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMAGEN2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBREFOTO2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADOREVISION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADOAPROBACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COMREVISION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COMAPROBACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LB_mensaje = new System.Windows.Forms.Label();
            this.LK_label = new System.Windows.Forms.LinkLabel();
            this.LK_label2 = new System.Windows.Forms.LinkLabel();
            this.LB_mensaje2 = new System.Windows.Forms.Label();
            this.NUMAPROBACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DG_tabla)).BeginInit();
            this.SuspendLayout();
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
            this.CONCEPTOGRAL,
            this.CONCEPTODETALLE,
            this.DESCRIPCION,
            this.IMPORTE,
            this.FOLIOSALIDA,
            this.FECHA,
            this.IMAGEN1,
            this.NOMBREFOTO1,
            this.IMAGEN2,
            this.NOMBREFOTO2,
            this.ESTADOREVISION,
            this.ESTADOAPROBACION,
            this.COMREVISION,
            this.COMAPROBACION,
            this.NUMAPROBACION});
            this.DG_tabla.Location = new System.Drawing.Point(2, 114);
            this.DG_tabla.Name = "DG_tabla";
            this.DG_tabla.Size = new System.Drawing.Size(1245, 475);
            this.DG_tabla.TabIndex = 0;
            this.DG_tabla.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_tabla_CellContentDoubleClick);
            // 
            // BT_buscar
            // 
            this.BT_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_buscar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_buscar.ForeColor = System.Drawing.Color.White;
            this.BT_buscar.Location = new System.Drawing.Point(1140, 23);
            this.BT_buscar.Name = "BT_buscar";
            this.BT_buscar.Size = new System.Drawing.Size(99, 54);
            this.BT_buscar.TabIndex = 1;
            this.BT_buscar.Text = "Buscar";
            this.BT_buscar.UseVisualStyleBackColor = false;
            this.BT_buscar.Click += new System.EventHandler(this.BT_buscar_Click);
            // 
            // DT_inicio
            // 
            this.DT_inicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DT_inicio.Location = new System.Drawing.Point(934, 26);
            this.DT_inicio.Name = "DT_inicio";
            this.DT_inicio.Size = new System.Drawing.Size(200, 20);
            this.DT_inicio.TabIndex = 2;
            // 
            // DT_fin
            // 
            this.DT_fin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DT_fin.Location = new System.Drawing.Point(934, 57);
            this.DT_fin.Name = "DT_fin";
            this.DT_fin.Size = new System.Drawing.Size(200, 20);
            this.DT_fin.TabIndex = 3;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // CONCEPTOGRAL
            // 
            this.CONCEPTOGRAL.HeaderText = "CONCEPTO GRAL.";
            this.CONCEPTOGRAL.Name = "CONCEPTOGRAL";
            // 
            // CONCEPTODETALLE
            // 
            this.CONCEPTODETALLE.HeaderText = "CONCEPTO DETALLE";
            this.CONCEPTODETALLE.Name = "CONCEPTODETALLE";
            // 
            // DESCRIPCION
            // 
            this.DESCRIPCION.HeaderText = "DESCRIPCION";
            this.DESCRIPCION.Name = "DESCRIPCION";
            // 
            // IMPORTE
            // 
            this.IMPORTE.HeaderText = "IMPORTE";
            this.IMPORTE.Name = "IMPORTE";
            // 
            // FOLIOSALIDA
            // 
            this.FOLIOSALIDA.HeaderText = "FOLIO SALIDA";
            this.FOLIOSALIDA.Name = "FOLIOSALIDA";
            // 
            // FECHA
            // 
            this.FECHA.HeaderText = "FECHA";
            this.FECHA.Name = "FECHA";
            // 
            // IMAGEN1
            // 
            this.IMAGEN1.HeaderText = "IMAGEN1";
            this.IMAGEN1.Name = "IMAGEN1";
            this.IMAGEN1.Visible = false;
            // 
            // NOMBREFOTO1
            // 
            this.NOMBREFOTO1.HeaderText = "NOMBRE FOTO1";
            this.NOMBREFOTO1.Name = "NOMBREFOTO1";
            this.NOMBREFOTO1.Visible = false;
            // 
            // IMAGEN2
            // 
            this.IMAGEN2.HeaderText = "IMAGEN2";
            this.IMAGEN2.Name = "IMAGEN2";
            this.IMAGEN2.Visible = false;
            // 
            // NOMBREFOTO2
            // 
            this.NOMBREFOTO2.HeaderText = "NOMBRE FOTO2";
            this.NOMBREFOTO2.Name = "NOMBREFOTO2";
            this.NOMBREFOTO2.Visible = false;
            // 
            // ESTADOREVISION
            // 
            this.ESTADOREVISION.HeaderText = "ESTADO REVISION";
            this.ESTADOREVISION.Name = "ESTADOREVISION";
            // 
            // ESTADOAPROBACION
            // 
            this.ESTADOAPROBACION.HeaderText = "ESTADO APROBACION";
            this.ESTADOAPROBACION.Name = "ESTADOAPROBACION";
            // 
            // COMREVISION
            // 
            this.COMREVISION.HeaderText = "COM. REVISION";
            this.COMREVISION.Name = "COMREVISION";
            // 
            // COMAPROBACION
            // 
            this.COMAPROBACION.HeaderText = "COM. APROBACION";
            this.COMAPROBACION.Name = "COMAPROBACION";
            // 
            // LB_mensaje
            // 
            this.LB_mensaje.AutoSize = true;
            this.LB_mensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_mensaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LB_mensaje.Location = new System.Drawing.Point(-1, 57);
            this.LB_mensaje.Name = "LB_mensaje";
            this.LB_mensaje.Size = new System.Drawing.Size(279, 18);
            this.LB_mensaje.TabIndex = 5;
            this.LB_mensaje.Text = "Tiene gastos por corregir, presione ";
            this.LB_mensaje.Visible = false;
            // 
            // LK_label
            // 
            this.LK_label.AutoSize = true;
            this.LK_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LK_label.Location = new System.Drawing.Point(277, 57);
            this.LK_label.Name = "LK_label";
            this.LK_label.Size = new System.Drawing.Size(35, 18);
            this.LK_label.TabIndex = 6;
            this.LK_label.TabStop = true;
            this.LK_label.Text = "aquí";
            this.LK_label.Visible = false;
            this.LK_label.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LK_label_LinkClicked);
            // 
            // LK_label2
            // 
            this.LK_label2.AutoSize = true;
            this.LK_label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LK_label2.Location = new System.Drawing.Point(277, 87);
            this.LK_label2.Name = "LK_label2";
            this.LK_label2.Size = new System.Drawing.Size(35, 18);
            this.LK_label2.TabIndex = 8;
            this.LK_label2.TabStop = true;
            this.LK_label2.Text = "aquí";
            this.LK_label2.Visible = false;
            this.LK_label2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LK_label2_LinkClicked);
            // 
            // LB_mensaje2
            // 
            this.LB_mensaje2.AutoSize = true;
            this.LB_mensaje2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_mensaje2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LB_mensaje2.Location = new System.Drawing.Point(-1, 87);
            this.LB_mensaje2.Name = "LB_mensaje2";
            this.LB_mensaje2.Size = new System.Drawing.Size(273, 18);
            this.LB_mensaje2.TabIndex = 7;
            this.LB_mensaje2.Text = "Tiene gastos rechazados presione ";
            this.LB_mensaje2.Visible = false;
            // 
            // NUMAPROBACION
            // 
            this.NUMAPROBACION.HeaderText = "NUM. APROBACION";
            this.NUMAPROBACION.Name = "NUMAPROBACION";
            // 
            // ListadoGastosCedis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1251, 590);
            this.Controls.Add(this.LK_label2);
            this.Controls.Add(this.LB_mensaje2);
            this.Controls.Add(this.LK_label);
            this.Controls.Add(this.LB_mensaje);
            this.Controls.Add(this.DG_tabla);
            this.Controls.Add(this.DT_fin);
            this.Controls.Add(this.DT_inicio);
            this.Controls.Add(this.BT_buscar);
            this.Name = "ListadoGastosCedis";
            this.Text = "ListadoGastosCedis";
            this.Load += new System.EventHandler(this.ListadoGastosCedis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_tabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DG_tabla;
        private System.Windows.Forms.Button BT_buscar;
        private System.Windows.Forms.DateTimePicker DT_inicio;
        private System.Windows.Forms.DateTimePicker DT_fin;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CONCEPTOGRAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn CONCEPTODETALLE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMPORTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn FOLIOSALIDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMAGEN1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBREFOTO1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMAGEN2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBREFOTO2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADOREVISION;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADOAPROBACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn COMREVISION;
        private System.Windows.Forms.DataGridViewTextBoxColumn COMAPROBACION;
        private System.Windows.Forms.Label LB_mensaje;
        private System.Windows.Forms.LinkLabel LK_label;
        private System.Windows.Forms.LinkLabel LK_label2;
        private System.Windows.Forms.Label LB_mensaje2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMAPROBACION;
    }
}