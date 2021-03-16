using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3_MayorNumero
{
    class Calculo
    {
        public string Mayor (int num1, int num2, int num3)
        {
            string resultado = "";
            if ((num1 > num2) && (num1 > 3))
            {
                resultado = "El " + num1 + " es el mayor";
            }
            if ((num2 > num1) && (num2 > 3))
            {
                resultado = "El " + num2 + " es el mayor";
            }
            if ((num3 > num1) && (num3 > 2))
            {
                resultado = "El " + num3 + " es el mayor";
            }
            return (resultado);
        }
        
    }
}
