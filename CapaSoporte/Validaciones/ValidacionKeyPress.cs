using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace CapaSoporte.Validaciones
{
    public static class ValidacionKeyPress
    {
        public static void Valida_Letras_Delete_Space(KeyPressEventArgs X)
        {
            if (Char.IsLetter(X.KeyChar))
            {
                X.Handled = false;
            }
            else if (X.KeyChar == ' ')
            {
                X.Handled = false;
            }
            else if (X.KeyChar == Convert.ToChar(8))
            {
                X.Handled = false;
            }
            else
            {
                X.Handled = true;
            }
        }

        public static void Valida_Numeros(KeyPressEventArgs X)
        {
            if (X.KeyChar == Convert.ToChar(8))
            {
                X.Handled = false;
            }
            else if (X.KeyChar < '0' || X.KeyChar > '9')
            {
                X.Handled = true;
            }
        }

        //VERSION 1
        //public void Valida_NombreUsuario2(KeyPressEventArgs X)
        //{
        //    if (Char.IsLetter(X.KeyChar))
        //    {
        //        X.Handled = false;
        //    }
        //    else if (Char.IsNumber(X.KeyChar))
        //    {
        //        X.Handled = false;
        //    }
        //    else if (X.KeyChar == Convert.ToChar(8))
        //    {
        //        X.Handled = false;
        //    }
        //    else
        //    {
        //        X.Handled = true;
        //    }
        //}

        //VERSION 2

        public static void Valida_NombreUsuario(KeyPressEventArgs X)
        {
            char acento = '´';

            if (Char.IsLetter(X.KeyChar)) //Permite Letras
            {
                X.Handled = false;
            }
            else if (Char.IsNumber(X.KeyChar)) //Permite Numeros
            {
                X.Handled = false;
            }
            else if (X.KeyChar == Convert.ToChar(95)) // Permite _
            {
                X.Handled = false;
            }
            else if (X.KeyChar == Convert.ToChar(46)) // Permite .
            {
                X.Handled = false;
            }
            else if (X.KeyChar == Convert.ToChar(8)) // Permite DELETE
            {
                X.Handled = false;
            }
            else if (X.KeyChar == Convert.ToChar(Char.ToString(acento)))//No permite ' (ACENTOS)
            {
                X.Handled = true;
            }
            else
            {
                X.Handled = true;
            }
        }

        public static bool Valida_ContrasenaSegura(TextBox contrasena1, TextBox contrasena2, ErrorProvider errorProvider1, ErrorProvider errorProvider2, Label label)
        {
            errorProvider1.Clear();
            errorProvider2.Clear();

            bool mayuscula = false, minuscula = false, numero = false, caracter_especial = false;

            for (int i = 0; i < contrasena1.Text.Length; i++)
            {
                if (char.IsUpper(contrasena1.Text, i))
                {
                    mayuscula = true;
                }
                else if (char.IsLower(contrasena1.Text, i))
                {
                    minuscula = true;
                }
                else if (char.IsDigit(contrasena1.Text, i))
                {
                    numero = true;
                }
                else
                {
                    caracter_especial = true;
                }
            }

            if (mayuscula == true && minuscula == true && numero == true && caracter_especial == true && contrasena1.Text.Length >= 8)
            {

                if (contrasena1.UseSystemPasswordChar == false || contrasena1.UseSystemPasswordChar == true || contrasena2.UseSystemPasswordChar == false || contrasena2.UseSystemPasswordChar == true)
                {
                    if (contrasena1.Text == contrasena2.Text)
                    {
                        return true;
                    }
                    else if (contrasena1.Text != contrasena2.Text)
                    {
                        errorProvider1.SetError(contrasena1, "La contraseña ingresada es debe ser igual en ambos campos");
                        errorProvider2.SetError(contrasena2, "La contraseña ingresada es debe ser igual en ambos campos");
                        return false;
                    }
                }

            }
            else if (mayuscula == false || minuscula == false || numero == false || caracter_especial == false || contrasena1.Text.Length < 8)
            {
                errorProvider1.SetError(contrasena1, "La contraseña debe contener:" +
                                "\n * Al menos 8 caraceteres" +
                                "\n * Una letra mayuscula" +
                                "\n * Una letra minuscula" +
                                "\n * Un numero" +
                                "\n * Un caracter especial");

                return false;
            }

            return false;

        }

        public static void ActualizaLabel_ContrasenaSegura(TextBox contrasena1, Label label)
        {
            bool mayuscula = false, minuscula = false, numero = false, caracter_especial = false;

            for (int i = 0; i < contrasena1.Text.Length; i++)
            {
                if (char.IsUpper(contrasena1.Text, i))
                {
                    mayuscula = true;
                }
                else if (char.IsLower(contrasena1.Text, i))
                {
                    minuscula = true;
                }
                else if (char.IsDigit(contrasena1.Text, i))
                {
                    numero = true;
                }
                else
                {
                    caracter_especial = true;
                }
            }

            if (mayuscula == true && minuscula == true && numero == true && caracter_especial == true && contrasena1.Text.Length >= 8)
            {
                label.Text = "Contraseña Segura";
                label.Visible = true;
                label.ForeColor = Color.Lime;

            }
            else if (mayuscula == false || minuscula == false || numero == false || caracter_especial == false || contrasena1.Text.Length < 8)
            {
                label.Text = "Contraseña Insegura";
                label.Visible = true;
                label.ForeColor = Color.Tomato;
            }

        }

    }
}
