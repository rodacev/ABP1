using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.aplicacion.regla
{
    public class VacioRegla
    {
        public void ValidarCampoVacio(string value, string nombreCampo)
        {
            if (value == null || value.Count() == 0)
            {
                throw new Exception("EL CAMPO ' " + nombreCampo + " ' NO PUEDE ESTAR VACÍO");
            }
        }


        public void ValidarItemVacio(object objecto, string nombreItem)
        {
            if (objecto == null)
            {
                throw new Exception("DEBE SELECCIONAR " + nombreItem);
            }
        }

        public void MetodoGit()
        {

        }









    }
}
