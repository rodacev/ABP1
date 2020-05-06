using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.aplicacion.utilidad
{
    public class CalculoContrato
    {

        public double RecargaAsistentesUF(int cantidadAsistente)
        {
            double recargoEnUF = 0;

            if (cantidadAsistente >= 1 && cantidadAsistente <= 20)
            {
                recargoEnUF = 3;
            }
            else if (cantidadAsistente >= 21 && cantidadAsistente <= 50)
            {
                recargoEnUF = 5;
            }
            else if (cantidadAsistente > 50)
            {
                recargoEnUF = 2;
            }
            return recargoEnUF;
        }


        public double RecargoPersonalExtraUF(int personalAdicional)
        {
            double recargoEnUF = 0;

            if (personalAdicional == 2)
            {
                recargoEnUF = 2;
            }
            else if (personalAdicional == 3)
            {
                recargoEnUF = 3;
            }
            else if (personalAdicional == 4)
            {
                recargoEnUF = 3.5;
            }
            else if (personalAdicional > 4)
            {
                int diferencia = personalAdicional - 4;
                recargoEnUF = 3.5 + 0.5 * diferencia;
            }
            else{
                recargoEnUF = 0;
            }
            return recargoEnUF;
        }





























    }
}
