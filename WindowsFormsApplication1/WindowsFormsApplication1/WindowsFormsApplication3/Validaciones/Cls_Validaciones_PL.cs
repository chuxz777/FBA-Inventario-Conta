using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FBA_Inventario.Validaciones
{
    class Cls_Validaciones_PL
    {
        /// <summary>
        /// Evalua la tecla presionada, para permitir solo numeros, las teclas de borrar y los tab (para pasarse de textbox)
        /// </summary>
        /// <param name="e">Los eventos de la tecla presionada</param>
        /// <returns>Un verdadero o falso, para ver si se deja ejecutar el evento de la tecla o no</returns>
        public Boolean evaluar_Key_NumerosEnteros(KeyPressEventArgs e, ref string sMensajeError)
        {
            try
            {
                // Si el texto ingresado no es un numero Y si es diferente de un (Borrar/Tab), entonces envia un mensaje indicandolo
                if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Tab))
                {
                    e.Handled = true; // Este indica que SI es manejado el evento y ademas se cancela el evento
                    sMensajeError = "No se pueden incluir letras, solo numeros enteros positivos";
                }
                else
                {
                    e.Handled = false; // Este indica que NO es manejado el evento y ademas NO se cancela el evento
                }

                return e.Handled;
            }
            catch (Exception ex)
            {
                sMensajeError = ex.Message;

                return e.Handled = true;
            }
        }

        /// <summary>
        /// Evalua la tecla presionada, para permitir solo numeros, las teclas de borrar, los tab (para pasarse de textbox)
        /// y tambien permite incluir el signo decimal
        /// </summary>
        /// <param name="e">Los eventos de la tecla presionada</param>
        /// <returns>Un verdadero o falso, para ver si se deja ejecutar el evento de la tecla o no</returns>
        public Boolean evaluar_Key_NumerosDecimales(KeyPressEventArgs e, string sMensajeError)
        {
            try
            {
                // Si el texto ingresado no es un numero Y si es diferente de un (Borrar/Tab/,), entonces envia un mensaje indicandolo
                if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Tab) && (e.KeyChar != '.'))
                {
                    e.Handled = true; // Este indica que SI es manejado el evento y ademas se cancela el evento

                    sMensajeError = "Solo se pueden incluir numeros y un signo decimal (.)";
                }
                else
                {
                    e.Handled = false; // Este indica que NO es manejado el evento, NO se cancela el evento
                }

                return e.Handled;
            }
            catch (Exception ex)
            {
                sMensajeError = ex.Message;

                return e.Handled = true;
            }
        }


        /// <summary>
        /// Evalua la tecla presionada, para permitir solo Letras, las teclas de borrar, los tab (para pasarse de textbox)
        /// </summary>
        /// <param name="e">Los eventos de la tecla presionada</param>
        /// <returns>Un verdadero o falso, para ver si se deja ejecutar el evento de la tecla o no</returns>

        public Boolean Evaluar_Letras(KeyPressEventArgs e, ref string sMensajeError)
        {
            try
            {
                if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Tab) && (e.KeyChar != (char)Keys.Space))
                {
                    e.Handled = true; // Este indica que SI es manejado el evento y ademas se cancela el evento
                    sMensajeError = "Solo se pueden incluir letras";
                }
                else
                {
                    e.Handled = false;
                }

                return e.Handled;
            }
            catch (Exception ex)
            {
                sMensajeError = ex.Message;
                return e.Handled = true;
            }
        }

        public Boolean No_Simbolos(KeyPressEventArgs e, ref string sMensajeError)
        {
            try
            {

                if (!(char.IsLetterOrDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Tab) && (e.KeyChar != (char)Keys.Space))
                {

                    e.Handled = true; // Este indica que SI es manejado el evento y ademas se cancela el evento
                    sMensajeError = "Solo se pueden incluir letras";

                }
                else
                {
                    e.Handled = false;
                }

                return e.Handled;
            }
            catch (Exception ex)
            {
                sMensajeError = ex.Message;
                return e.Handled = true;
            }
        }
    }
}
