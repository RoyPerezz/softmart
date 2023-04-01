
namespace appSugerencias.Reporte_Auditoria
{
    partial class Rep_aux_auditoria
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
            this.LB_sucursal = new System.Windows.Forms.Label();
            this.LB_usuario = new System.Windows.Forms.Label();
            this.LB_ip = new System.Windows.Forms.Label();
            this.LB_equipo = new System.Windows.Forms.Label();
            this.LB_hora = new System.Windows.Forms.Label();
            this.LB_fecha = new System.Windows.Forms.Label();
            this.DG_articulos = new System.Windows.Forms.DataGridView();
            this.BT_exportar = new System.Windows.Forms.Button();
            this.List_datos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DG_articulos)).BeginInit();
            this.SuspendLayout();
            // 
            // LB_sucursal
            // 
            this.LB_sucursal.AutoSize = true;
            this.LB_sucursal.Location = new System.Drawing.Point(66, 9);
            this.LB_sucursal.Name = "LB_sucursal";
            this.LB_sucursal.Size = new System.Drawing.Size(0, 13);
            this.LB_sucursal.TabIndex = 0;
            // 
            // LB_usuario
            // 
            this.LB_usuario.AutoSize = true;
            this.LB_usuario.Location = new System.Drawing.Point(192, 9);
            this.LB_usuario.Name = "LB_usuario";
            this.LB_usuario.Size = new System.Drawing.Size(0, 13);
            this.LB_usuario.TabIndex = 1;
            // 
            // LB_ip
            // 
            this.LB_ip.AutoSize = true;
            this.LB_ip.Location = new System.Drawing.Point(360, 9);
            this.LB_ip.Name = "LB_ip";
            this.LB_ip.Size = new System.Drawing.Size(0, 13);
            this.LB_ip.TabIndex = 3;
            // 
            // LB_equipo
            // 
            this.LB_equipo.AutoSize = true;
            this.LB_equipo.Location = new System.Drawing.Point(59, 33);
            this.LB_equipo.Name = "LB_equipo";
            this.LB_equipo.Size = new System.Drawing.Size(0, 13);
            this.LB_equipo.TabIndex = 2;
            // 
            // LB_hora
            // 
            this.LB_hora.AutoSize = true;
            this.LB_hora.Location = new System.Drawing.Point(738, 9);
            this.LB_hora.Name = "LB_hora";
            this.LB_hora.Size = new System.Drawing.Size(0, 13);
            this.LB_hora.TabIndex = 5;
            // 
            // LB_fecha
            // 
            this.LB_fecha.AutoSize = true;
            this.LB_fecha.Location = new System.Drawing.Point(546, 9);
            this.LB_fecha.Name = "LB_fecha";
            this.LB_fecha.Size = new System.Drawing.Size(0, 13);
            this.LB_fecha.TabIndex = 4;
            // 
            // DG_articulos
            // 
            this.DG_articulos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DG_articulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DG_articulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_articulos.Location = new System.Drawing.Point(12, 171);
            this.DG_articulos.Name = "DG_articulos";
            this.DG_articulos.Size = new System.Drawing.Size(776, 267);
            this.DG_articulos.TabIndex = 9;
            // 
            // BT_exportar
            // 
            this.BT_exportar.Location = new System.Drawing.Point(697, 126);
            this.BT_exportar.Name = "BT_exportar";
            this.BT_exportar.Size = new System.Drawing.Size(91, 34);
            this.BT_exportar.TabIndex = 10;
            this.BT_exportar.Text = "Exportar";
            this.BT_exportar.UseVisualStyleBackColor = true;
            this.BT_exportar.Click += new System.EventHandler(this.BT_exportar_Click);
            // 
            // List_datos
            // 
            this.List_datos.BackColor = System.Drawing.SystemColors.Control;
            this.List_datos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.List_datos.FormattingEnabled = true;
            this.List_datos.Location = new System.Drawing.Point(12, 58);
            this.List_datos.Name = "List_datos";
            this.List_datos.Size = new System.Drawing.Size(360, 104);
            this.List_datos.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "sucursal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "equipo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(339, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "ip";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(504, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "fecha";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(704, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "hora";
            // 
            // Rep_aux_auditoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.List_datos);
            this.Controls.Add(this.BT_exportar);
            this.Controls.Add(this.DG_articulos);
            this.Controls.Add(this.LB_hora);
            this.Controls.Add(this.LB_fecha);
            this.Controls.Add(this.LB_ip);
            this.Controls.Add(this.LB_equipo);
            this.Controls.Add(this.LB_usuario);
            this.Controls.Add(this.LB_sucursal);
            this.Name = "Rep_aux_auditoria";
            this.Text = "Rep_aux_auditoria";
            this.Load += new System.EventHandler(this.Rep_aux_auditoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_articulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_sucursal;
        private System.Windows.Forms.Label LB_usuario;
        private System.Windows.Forms.Label LB_ip;
        private System.Windows.Forms.Label LB_equipo;
        private System.Windows.Forms.Label LB_hora;
        private System.Windows.Forms.Label LB_fecha;
        private System.Windows.Forms.DataGridView DG_articulos;
        private System.Windows.Forms.Button BT_exportar;
        private System.Windows.Forms.ListBox List_datos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}