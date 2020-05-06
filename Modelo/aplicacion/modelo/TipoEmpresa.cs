using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.aplicacion.modelo
{
    public class TipoEmpresa
    {
        private int idTipoActividad;
        private string descripcion;

        public TipoEmpresa()
        {
            this.idTipoActividad = 0;
            this.descripcion = "";
        }

        public TipoEmpresa(int idTipoActividad, string descripcion)
        {
            this.IdTipoActividad = idTipoActividad;
            this.Descripcion = descripcion;
        }

        public int IdTipoActividad { get => idTipoActividad; set => idTipoActividad = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

        public override string ToString()
        {
            return descripcion.ToString();
        }
    }
}
