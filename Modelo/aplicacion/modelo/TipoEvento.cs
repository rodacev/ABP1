using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.aplicacion.modelo
{
    public class TipoEvento
    {
        private int idTipoEvento;
        private string nombre;
        private double valorBase;
        private int personalBase;


        public TipoEvento()
        {
            this.IdTipoEvento = 0;
            this.Nombre = "";
            this.ValorBase = 0;
            this.PersonalBase = 0;
        }

        public TipoEvento(int idTipoEvento, string nombre, double valorBase, int personalBase)
        {
            this.IdTipoEvento = idTipoEvento;
            this.Nombre = nombre;
            this.ValorBase = valorBase;
            this.PersonalBase = personalBase;
        }

        public int IdTipoEvento { get => idTipoEvento; set => idTipoEvento = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public double ValorBase { get => valorBase; set => valorBase = value; }
        public int PersonalBase { get => personalBase; set => personalBase = value; }

        public override string ToString()
        {
            return nombre.ToString();
        }





    }
}
