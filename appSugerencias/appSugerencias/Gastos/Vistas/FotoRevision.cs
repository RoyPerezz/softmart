using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace appSugerencias.Gastos.Vistas
{
    public partial class FotoRevision : Form
    {

        string ruta = "",comentario ="",ruta2="",ruta3="",comRevision, comRevision2="";
        int mes=0,año = 0;

        private void BT_ampliar3_Click(object sender, EventArgs e)
        {
            ImagenAmpliada ia = new ImagenAmpliada(pictureBox3.Image,3);
            ia.Show();
        }

        private void TB_revision2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ImagenAmpliadaDoble ImagenDoble = new ImagenAmpliadaDoble(pictureBox1.Image,pictureBox2.Image);
            ImagenDoble.Show();
        }

        private void BT_ampliar2_Click(object sender, EventArgs e)
        {
            ImagenAmpliada ia = new ImagenAmpliada(pictureBox2.Image,2);
            ia.Show();
        }

        private void BT_ampliar_Click(object sender, EventArgs e)
        {
            ImagenAmpliada ia = new ImagenAmpliada(pictureBox1.Image,1);
            ia.Show();
        }

        private void FotoRevision_MaximumSizeChanged(object sender, EventArgs e)
        {
                    
        }

        public FotoRevision(string ruta,string comentario,string ruta2,string ruta3,string comRevision,string comRevision2,int mes,int año)
        {
            this.ruta = ruta;
            this.ruta2 = ruta2;
            this.ruta3 = ruta3;
            this.comentario = comentario;
            this.mes = mes;
            this.año = año;
            this.comRevision = comRevision;
            this.comRevision2 = comRevision2;
            InitializeComponent();
        }

        private void FotoRevision_Load(object sender, EventArgs e)
        {

            string cadena1 = "",cadena2="",rutaCompleta="",caracter="";
            int contarSlash = 0;
            if (!ruta.Equals(""))
            {
                if (mes==1||mes==2||mes==3||mes==4||mes==5||mes==6||mes==7)
                {
                    if (año==2023)
                    {
                        rutaCompleta = ruta;
                      


                        for (int i = 0; i < rutaCompleta.Length; i++)
                        {

                            caracter = rutaCompleta[i].ToString();
                            if (caracter.Equals("\\"))
                            {
                                contarSlash++;
                            }
                            else { break; }

                        }

                        cadena1 = ruta.Substring(contarSlash+11);
                        cadena2 = ruta.Substring(12);
                        ruta = cadena1;
                        pictureBox1.Image = Image.FromFile("\\\\192.168.5.2" + ruta);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        contarSlash = 0;
                    }
                }
                else
                {
                    pictureBox1.Image = Image.FromFile(ruta);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
               
               
            }

            if (!ruta2.Equals(""))
            {
                if (mes == 1 || mes == 2 || mes == 3 || mes == 4 || mes == 5 || mes == 6 || mes == 7)
                {
                    if (año==2023)
                    {
                        rutaCompleta = ruta2;



                        for (int i = 0; i < rutaCompleta.Length; i++)
                        {

                            caracter = rutaCompleta[i].ToString();
                            if (caracter.Equals("\\"))
                            {
                                contarSlash++;
                            }
                            else { break; }

                        }

                        cadena1 = ruta2.Substring(contarSlash + 11);
                        cadena2 = ruta2.Substring(12);
                        ruta2 = cadena1;
                        pictureBox2.Image = Image.FromFile("\\\\192.168.5.2" + ruta2);
                        pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                        contarSlash = 0;
                    }
                }
                else
                {
                    pictureBox2.Image = Image.FromFile(ruta2);
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                    
            }

            if (!ruta3.Equals(""))
            {
               
                if (mes == 1 || mes == 2 || mes == 3 || mes == 4 || mes == 5 || mes == 6 || mes == 7)
                {
                    if (año==2023)
                    {
                        rutaCompleta = ruta3;



                        for (int i = 0; i < rutaCompleta.Length; i++)
                        {

                            caracter = rutaCompleta[i].ToString();
                            if (caracter.Equals("\\"))
                            {
                                contarSlash++;
                            }
                            else { break; }

                        }

                        cadena1 = ruta3.Substring(contarSlash + 11);
                        cadena2 = ruta3.Substring(12);
                        ruta3 = cadena1;
                        pictureBox3.Image = Image.FromFile("\\\\192.168.5.2" + ruta3);
                        pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                        contarSlash = 0;
                    }
                }
                else
                {
                    pictureBox3.Image = Image.FromFile(ruta3);
                    pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                    
            }
           

           
            TB_detalle.Text = comentario;
           
            TB_revision.Text = comRevision;
            TB_revision2.Text = comRevision2;
        }
    }
}
