using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.aplicacion.regla
{
    public class RutRegla
    {

        public void validarRut(string rut)
        {
            if (!FormatoRut(rut))
            {
                throw new Exception("RUT INVÁLIDO");
            }
        }


        public bool FormatoRut(string rut)
        {

            bool validador = false;
            try
            {
                rut = rut.ToUpper();
                rut = rut.Replace(".", "");
                rut = rut.Replace("-", "");
                int rutAux = int.Parse(rut.Substring(0, rut.Length - 1));

                char dv = char.Parse(rut.Substring(rut.Length - 1, 1));

                int m = 0, s = 1;
                for (; rutAux != 0; rutAux /= 10)
                {
                    s = (s + rutAux % 10 * (9 - m++ % 6)) % 11;
                }
                if (dv == (char)(s != 0 ? s + 47 : 75))
                {
                    validador = true;
                }
            }
            catch (Exception)
            {
            }
            return validador;
        }
    }
}
