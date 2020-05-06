using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.aplicacion.modelo
{
    public class ActividadEmpresa
    {
        private int idActividadEmpresa;
        private string descripcion;

        public ActividadEmpresa()
        {
            this.idActividadEmpresa = 0;
            this.descripcion = "";
        }

        public ActividadEmpresa(int idActividadEmpresa, string descripcion)
        {
            this.IdActividadEmpresa = idActividadEmpresa;
            this.Descripcion = descripcion;
        }

        public int IdActividadEmpresa { get => idActividadEmpresa; set => idActividadEmpresa = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

        public override string ToString()
        {
            return descripcion.ToString();
        }
    }
}
