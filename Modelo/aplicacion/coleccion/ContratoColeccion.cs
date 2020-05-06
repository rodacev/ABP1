using Modelo.aplicacion.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.aplicacion.coleccion
{
    public class ContratoColeccion
    {
        List<Contrato> listaContratos = new List<Contrato>();

        public ContratoColeccion()
        {
            this.listaContratos = new List<Contrato>();
        }

        public ContratoColeccion(List<Contrato> listaContratos)
        {
            this.ListaContratos = listaContratos;
        }

        public List<Contrato> ListaContratos { get => listaContratos; set => listaContratos = value; }



        public void AgregarContrato(Contrato contrato)
        {
            bool validador = false;

            foreach (Contrato x in listaContratos)
            {
                if (x.IdContrato.Equals(contrato.IdContrato))
                {
                    validador = true;
                    break;
                }
            }

            if (!validador)
            {
                listaContratos.Add(contrato);
            }
            else
            {
                throw new Exception("EL NÚMERO DE CONTRATO YA EXISTE");
            }
        }


        public Contrato BuscarContratoId(string id)
        {
            bool validador = false;
            int indice = 0;

            for (int i = 0; i < listaContratos.Count; i++)
            {
                if (listaContratos[i].IdContrato.Equals(id))
                {
                    validador = true;
                    indice = i;
                    break;
                }
            }
            if (validador)
            {
                return listaContratos[indice];
            }
            else
            {
                throw new Exception("NO SE ENCONTRARON RESULTADOS PARA SU BÚSQUEDA");
            }
        }


        public List<Contrato> BuscarContratoRut(string rut)
        {
            List<Contrato> listaTemp = new List<Contrato>();

            for (int i = 0; i < listaContratos.Count; i++)
            {
                if (listaContratos[i].Cliente.Rut == rut)
                {
                    listaTemp.Add(listaContratos[i]);
                }
            }
            if (listaTemp.Count == 0)
            {
                throw new Exception("NO SE ENCONTRARON RESULTADOS PARA SU BÚSQUEDA");
            }
            return listaTemp;
        }


        public List<Contrato> BuscarContratoTipo(string tipo)
        {
            List<Contrato> listaTemp = new List<Contrato>();
                
            foreach (Contrato x in listaContratos)
            {
                if (x.TipoEvento.Nombre == tipo)
                {
                    listaTemp.Add(x);
                }
            }
            if (listaTemp.Count == 0)
            {
                throw new Exception("NO SE ENCONTRARON RESULTADOS PARA SU BÚSQUEDA");
            }

            return listaTemp;
        }
















    }
}
