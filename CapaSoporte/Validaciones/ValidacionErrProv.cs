using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaSoporte.Cache;

namespace CapaSoporte.Validaciones
{
    public class ValidacionErrProv
    {

        public bool Valida_Error_NombreUsuario(ErrorProvider errorProvider, TextBox textBoxNombreUsuario)
        {
            errorProvider.Clear();
            if (textBoxNombreUsuario.Text.Length >= 3)
            {
                return true;
            }
            else
            {
                errorProvider.SetError(textBoxNombreUsuario, "Error: Nombre de usuario inválido, debe poseer al menos 3 caracteres");
                return false;
            }
        }


        public bool Valida_Error_DNI(ErrorProvider errorProvider, TextBox textBoxDNI)
        {
            errorProvider.Clear();
            if (textBoxDNI.Text.Trim() != "" && textBoxDNI.Text.Length == 8)
            {
                return true;
            }
            else
            {
                errorProvider.SetError(textBoxDNI, "Error: DNI invalido, debe poseer 8 caracteres");
                return false;
            }
        }

        public bool Valida_CampoVacio(ErrorProvider errorProvider, TextBox textBox)
        {
            errorProvider.Clear();
            if (textBox.Text.Trim() != "")
            {
                return true;
            }
            else
            {
                errorProvider.SetError(textBox, "Error: El campo no puede estar vacío");
                return false;
            }
        }
        public bool Valida_CampoTelefono(ErrorProvider errorProvider, TextBox textBox)
        {
            errorProvider.Clear();
            if (textBox.Text.Trim() != "" && textBox.Text != "Ej: (011) 1010-1010")
            {
                return true;
            }
            else
            {
                errorProvider.SetError(textBox, "Error: Debe ingresar un número de teléfono");
                return false;
            }
        }


        public bool ValidaLongitud_CUIT(ErrorProvider errorProvider, TextBox textBoxCuit1, TextBox textBoxCuit2, TextBox textBoxCuit3)
        {
            errorProvider.Clear();
            if (textBoxCuit1.Text.Length == 2 && textBoxCuit2.Text.Length == 8 && textBoxCuit3.Text.Length == 1)
            {
                return true;
            }
            else
            {
                errorProvider.SetError(textBoxCuit3, "Error: Longitud CUIT invalida");
                return false;
            }
        }


        #region Valida correo electrónico *-------------------------*
        public bool Valida_Error_Email(ErrorProvider errorProvider, TextBox textBoxEmail)
        {
            errorProvider.Clear();
            if (Valida_Email(textBoxEmail.Text) == true)
            {
                return true;
            }
            else
            {
                errorProvider.SetError(textBoxEmail, "Error: Correo Electrónico inválido");
                return false;
            }
        }

        private static bool Valida_Email(string email)
        {
            String validando;
            validando = @"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$";
            if (Regex.IsMatch(email, validando))
            {
                if (Regex.Replace(email, validando, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        #endregion Valida correo electrónico *-------------------------*


        public bool Valida_ItemSeleccionado_Combobox(ErrorProvider errorProvider, ComboBox comboBox)
        {
            errorProvider.Clear();

            if (comboBox.SelectedItem != null)
            {
                return true;
            }
            else
            {
                errorProvider.SetError(comboBox, "Error: Debe seleccionar una opción");
                return false;
            }
        }

        public bool Valida_CampoDistinto_0_o_Vacio(ErrorProvider errorProvider, TextBox textBox)
        {
            errorProvider.Clear();
            #region Verificar que no se ingrese 0
            //La expresión(c => c == '0') es una expresión lambda que representa
            //una función anónima que toma un parámetro c y devuelve true si c es igual a '0',
            //y false en caso contrario.Esta expresión se utiliza comúnmente como un delegado o
            //un predicado para realizar operaciones en colecciones, como filtrar elementos o
            //verificar si todos los elementos cumplen con una condición.

            //Por ejemplo, en el código que te proporcioné anteriormente, esta expresión
            //se utiliza como un predicado para el método All de la clase Enumerable,
            //que verifica si todos los elementos de una colección cumplen con la condición
            //especificada por el predicado. En este caso, estamos verificando si todos
            //los caracteres en el contenido del TextBox son iguales a '0'.
            //            errorProvider.Clear();
            #endregion
            if (string.IsNullOrEmpty(textBox.Text))
            {
                errorProvider.SetError(textBox, "Error: El campo no puede estar vacío");
                return false;
            }
            else if (textBox.Text == "0" || textBox.Text.All(c => c == '0'))
            {
                errorProvider.SetError(textBox, "Error: Debe ingresar un número mayor a 0");
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool Valida_CantidadPorcentaje(ErrorProvider errorProvider, TextBox textBox)
        {
            errorProvider.Clear();
            if (string.IsNullOrEmpty(textBox.Text))
            {
                errorProvider.SetError(textBox, "Error: El campo no puede estar vacío");
                return false;
            }
            else if (Convert.ToInt32(textBox.Text) <= 0)
            {
                errorProvider.SetError(textBox, "Error: El porcentaje de ganancia debe ser entre 1 y 100");
                return false;
            }
            else if (Convert.ToInt32(textBox.Text) > 100)
            {
                errorProvider.SetError(textBox, "Error: El porcentaje de ganancia debe ser entre 1 y 100");
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool Valida_CampoMayorAOtro(ErrorProvider errorProvider, TextBox textBoxMayor, TextBox textBoxMenor)
        {
            errorProvider.Clear();
            if (Convert.ToInt32(textBoxMayor.Text) > Convert.ToInt32(textBoxMenor.Text))
            {
                return true;
            }
            else
            {
                errorProvider.SetError(textBoxMayor, "Error: El campo Stock Máximo debe ser mayor al campo Stock Mínimo");
                return false;
            }
        }

        //Se utilizan en el frmEditarPerfil
        public bool Valida_ContrasenaDoble(ErrorProvider errorProvider, TextBox TextBoxContraNueva, TextBox TextBoxContraNueva2)
        {
            //Verifica que las contraseñas ingresadas sean iguales en ambos campos
            errorProvider.Clear();
            if (TextBoxContraNueva.Text.Trim() != "" && TextBoxContraNueva2.Text.Trim() != "" && TextBoxContraNueva.Text == TextBoxContraNueva2.Text)
            {
                return true;
            }
            else if (TextBoxContraNueva.Text.Trim() == "")
            {
                errorProvider.SetError(TextBoxContraNueva, "Error: No se permite ingresar campos vacios");
                return false;
            }
            else if (TextBoxContraNueva2.Text.Trim() == "")
            {
                errorProvider.SetError(TextBoxContraNueva2, "Error: No se permite ingresar campos vacios");
                return false;
            }
            else
            {
                errorProvider.SetError(TextBoxContraNueva, "La contraseña ingresada no es igual en ambos campos");
                errorProvider.SetError(TextBoxContraNueva2, "La contraseña ingresada no es igual en ambos campos");
                return false;
            }
        }

        //public bool Valida_ContrasenasIguales(ErrorProvider errorProvider1, ErrorProvider errorProvider2, TextBox TextBoxContraNueva, TextBox TextBoxContraNueva2)
        //{
        //    //Verifica que las contraseñas ingresadas sean iguales en ambos campos
        //    errorProvider1.Clear();
        //    errorProvider2.Clear();
        //    if (TextBoxContraNueva.Text.Trim() == TextBoxContraNueva2.Text.Trim())
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        errorProvider1.SetError(TextBoxContraNueva, "La contraseña ingresada no es igual en ambos campos");
        //        errorProvider2.SetError(TextBoxContraNueva2, "La contraseña ingresada no es igual en ambos campos");
        //        return false;
        //    }
        //}

    }
}
