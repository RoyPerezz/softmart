
namespace appSugerencias.Cajas.Enc_Cajas.Vista
{
    partial class AmpliarFotoIncidenciaEtiqueta
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
            this.PB_imagen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PB_imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // PB_imagen
            // 
            this.PB_imagen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PB_imagen.Location = new System.Drawing.Point(0, 0);
            this.PB_imagen.Name = "PB_imagen";
            this.PB_imagen.Size = new System.Drawing.Size(295, 453);
            this.PB_imagen.TabIndex = 0;
            this.PB_imagen.TabStop = false;
            // 
            // AmpliarFotoIncidenciaEtiqueta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PB_imagen);
            this.Name = "AmpliarFotoIncidenciaEtiqueta";
            this.Text = "AmpliarFotoIncidenciaEtiqueta";
            this.Load += new System.EventHandler(this.AmpliarFotoIncidenciaEtiqueta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PB_imagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PB_imagen;
    }
}