using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.aplicacion.modelo
{
    public class Contrato
    {
        private string idContrato;
        private Cliente cliente;
        private DateTime fechaCreacion;
        private DateTime? fechaTermino;
        private DateTime fechaHoraInicio;
        private DateTime fechaHoraTermino;
        private string direccion;
        private bool estado;
        private string observaciones;
        private TipoEvento tipoEvento;
        private int personalAdicional;
        private int asistente;
        private double valorTotal;

        public Contrato()
        {
        }

        public Contrato(string idContrato, Cliente cliente, DateTime fechaCreacion, DateTime? fechaTermino, DateTime fechaHoraInicio, 
            DateTime fechaHoraTermino, string direccion, bool estado, string observaciones, TipoEvento tipoEvento, int personalAdicional,
            int asistente, double valorTotal)
        {
            this.IdContrato = idContrato;
            this.FechaCreacion = fechaCreacion;
            this.FechaTermino = fechaTermino;
            this.FechaHoraInicio = fechaHoraInicio;
            this.FechaHoraTermino = fechaHoraTermino;
            this.Direccion = direccion;
            this.Estado = estado;
            this.Observaciones = observaciones;
            this.TipoEvento = tipoEvento;
            this.Cliente = cliente;
            this.PersonalAdicional = personalAdicional;
            this.Asistente = asistente;
            this.ValorTotal = valorTotal;
        }

        public string IdContrato { get => idContrato; set => idContrato = value; }
        public DateTime FechaCreacion { get => fechaCreacion; set => fechaCreacion = value; }
        public DateTime? FechaTermino { get => fechaTermino; set => fechaTermino = value; }
        public DateTime FechaHoraInicio { get => fechaHoraInicio; set => fechaHoraInicio = value; }
        public DateTime FechaHoraTermino { get => fechaHoraTermino; set => fechaHoraTermino = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public bool Estado { get => estado; set => estado = value; }
        public string Observaciones { get => observaciones; set => observaciones = value; }
        public TipoEvento TipoEvento { get => tipoEvento; set => tipoEvento = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }
        public int PersonalAdicional { get => personalAdicional; set => personalAdicional = value; }
        public int Asistente { get => asistente; set => asistente = value; }
        public double ValorTotal { get => valorTotal; set => valorTotal = value; }
    }
}
