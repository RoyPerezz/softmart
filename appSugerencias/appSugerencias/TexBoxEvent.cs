using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace appSugerencias
{
    class TexBoxEvent
    {

        public static void textKeyPress(KeyPressEventArgs e)
        {
            //Condicion que nos permite ingresar datos de tipo texto
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;

            }
            //Condicion que no permite salto de linea
            else if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;

            }
            //condicion que permite utilizar la tecla backspace
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;

            }
            //Condicion que permite utilizar espacio
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }

        public static void numberKeyPress(KeyPressEventArgs e)
        {
            //Condicion que nos permite ingresar datos de tipo texto
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;

            }
            //Condicion que no permite salto de linea
            else if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;

            }
            //condicion que no permite ingresar datos de tipo texto
            else if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;

            }
            //condicion que permite utilizar la tecla backspace
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;

            }
            //Condicion que permite utilizar espacio
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }

        }

        public static void moneyKeyPress(KeyPressEventArgs e)
        {
            //Condicion que nos permite ingresar datos de tipo texto
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;

            }
            //Condicion que no permite salto de linea
            else if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;

            }
            //Condicion que no permite salto de linea
            else if (e.KeyChar == '.')
            {
                e.Handled = false;

            }
            //condicion que no permite ingresar datos de tipo texto
            else if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;

            }
            //condicion que permite utilizar la tecla backspace
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;

            }
            //Condicion que permite utilizar espacio
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }

        }
    }
}
