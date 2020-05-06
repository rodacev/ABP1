using Negocio.aplicacion.regla;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.aplicacion.negocio
{
    public class VentanaAgregarClienteNeg
    {

        public void ValidarCliente(string rut, string razonSocial, string nombreContacto, string mailContacto, string direccion, string telefono,
            object actividad, object tipo)
        {
            RutRegla rutRegla = new RutRegla();

            rutRegla.validarRut(rut);

            VacioRegla vr = new VacioRegla();
            vr.ValidarCampoVacio(razonSocial, "RAZÓN SOCIAL");
            vr.ValidarCampoVacio(nombreContacto, "NOMBRE CONTACTO");
            vr.ValidarCampoVacio(mailContacto, "MAIL CONTACTO");
            vr.ValidarCampoVacio(direccion, "DIRECCIÓN");
            vr.ValidarCampoVacio(telefono, "TELÉFONO");

            vr.ValidarItemVacio(actividad, "ACTIVIDAD");
            vr.ValidarItemVacio(tipo, "TIPO");
        }
    }
}
