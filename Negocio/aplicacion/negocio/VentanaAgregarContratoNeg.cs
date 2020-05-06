using Negocio.aplicacion.regla;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.aplicacion.negocio
{
    public class VentanaAgregarContratoNeg
    {

        public void ValidarContrato(string idContrato, object fechaInicio, object fechaTermino, string direccion, object tipo, object hhI,
            object hhT)
        {
            VacioRegla vr = new VacioRegla();

            vr.ValidarCampoVacio(idContrato, "NRO. CONTRATO");
            vr.ValidarItemVacio(fechaInicio, "FECHA INICIO");
            vr.ValidarItemVacio(fechaTermino, "FECHA TERMINO");
            vr.ValidarCampoVacio(direccion, "DIRECCIÓN");
            vr.ValidarItemVacio(tipo, "TIPO EVENTO");
            vr.ValidarItemVacio(hhI, "HORA INICIO");
            vr.ValidarItemVacio(hhT, "HORA TÉRMINO");
        }
    }
}
