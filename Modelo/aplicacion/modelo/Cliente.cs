using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.aplicacion.modelo
{
    public class Cliente
    {
        private string rut;
        private string razonSocial;
        private string nombreContacto;
        private string mailContacto;
        private string direccion;
        private string telefono;
        private ActividadEmpresa actividadEmpresa;
        private TipoEmpresa tipoEmpresa;

        public Cliente()
        {
           
        }

        public Cliente(string rut, string razonSocial, string nombreContacto, 
            string mailContacto, string direccion, string telefono, ActividadEmpresa actividadEmpresa, 
            TipoEmpresa tipoEmpresa)
        {
            this.Rut = rut;
            this.RazonSocial = razonSocial;
            this.NombreContacto = nombreContacto;
            this.MailContacto = mailContacto;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.ActividadEmpresa = actividadEmpresa;
            this.TipoEmpresa = tipoEmpresa;
        }

        public string Rut { get => rut; set => rut = value; }
        public string RazonSocial { get => razonSocial; set => razonSocial = value; }
        public string NombreContacto { get => nombreContacto; set => nombreContacto = value; }
        public string MailContacto { get => mailContacto; set => mailContacto = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public ActividadEmpresa ActividadEmpresa { get => actividadEmpresa; set => actividadEmpresa = value; }
        public TipoEmpresa TipoEmpresa { get => tipoEmpresa; set => tipoEmpresa = value; }


        public override string ToString()
        {
            return rut.ToString();
        }

    }
}
