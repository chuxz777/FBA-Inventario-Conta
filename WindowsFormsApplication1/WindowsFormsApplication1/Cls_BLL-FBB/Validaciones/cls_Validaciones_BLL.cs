using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cls_BLL_FBB.Validaciones
{
    class cls_Validaciones_BLL
    {
        /// <summary>
        /// Evalua que la cifra sea un numero entero y positivo
        /// </summary>
        /// <param name="sNumero">El numero a evaluar</param>
        /// <param name="sMensajeError">El mensaje del error en caso de que exista</param>
        /// <returns>True si se logro convertir, false en caso contrario</returns>
        public bool EvaluarNumerosEnterosPositivos(string sNumero, ref string sMensajeError)
        {
            try
            {
                if (Convert.ToInt32(sNumero) < 1)
                {
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                sMensajeError = ex.Message;

                return false;
            }
        }

    }
}
