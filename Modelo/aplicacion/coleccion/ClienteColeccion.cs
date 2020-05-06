using Modelo.aplicacion.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.aplicacion.coleccion
{
    public class ClienteColeccion
    {
        private List<Cliente> listaClientes;

        public ClienteColeccion()
        {
            this.ListaClientes = new List<Cliente>();
        }

        public ClienteColeccion(List<Cliente> listaClientes)
        {
            this.ListaClientes = listaClientes;
        }

        public List<Cliente> ListaClientes { get => listaClientes; set => listaClientes = value; }


        public void AgregarCliente(Cliente cliente)
        {
            bool validador = false;

            foreach (Cliente x in listaClientes)
            {
                if (x.Rut.Equals(cliente.Rut))
                {
                    validador = true;
                    break;
                }
            }

            if (!validador)
            {
                listaClientes.Add(cliente);
            }
            else
            {
                throw new Exception("EL CLIENTE YA EXISTE EN NUESTROS REGISTROS");
            }
        }


        public void EliminarCliente(Cliente cliente)
        {
            bool validador = false;
            int indice = 0;

            for (int i = 0; i < listaClientes.Count; i++)
            {
                if (listaClientes[i].Rut.Equals(cliente.Rut))
                {
                    validador = true;
                    indice = i;
                    break;
                }
            }
            if (!validador)
            {
                throw new Exception("EL CLIENTE NO EXISTE");
            }
            else
            {
                listaClientes.RemoveAt(indice);
            }
        }


        public void ModificarCliente(Cliente cliente)
        {
            bool validador = false;
            int indice = 0;

            for (int i = 0; i < listaClientes.Count; i++)
            {
                if (listaClientes[i].Rut.Equals(cliente.Rut))
                {
                    validador = true;
                    indice = i;
                    break;
                }
            }
            if (!validador)
            {
                throw new Exception("EL RUT INGRESADO NO EXISTE");
            }
            else
            {
                listaClientes[indice].RazonSocial = cliente.RazonSocial;
                listaClientes[indice].NombreContacto = cliente.NombreContacto;
                listaClientes[indice].MailContacto = cliente.MailContacto;
                listaClientes[indice].Direccion = cliente.Direccion;
                listaClientes[indice].Telefono = cliente.Telefono;
                listaClientes[indice].ActividadEmpresa = cliente.ActividadEmpresa;
                listaClientes[indice].TipoEmpresa = cliente.TipoEmpresa;

            }
        }


        public Cliente BuscarClienteRut(string rut)
        {
            bool validador = false;
            int indice = 0;

            for (int i = 0; i < listaClientes.Count; i++)
            {
                if (listaClientes[i].Rut.Equals(rut))
                {
                    validador = true;
                    indice = i;
                    break;
                }
            }
            if (validador)
            {
                return listaClientes[indice];
            }
            else
            {
                throw new Exception("CLIENTE NO ENCONTRADO");
            }
        }


        public List<Cliente> BuscarClienteActividad(string actividad)
        {
            List<Cliente> listaTemp = new List<Cliente>();

            foreach (Cliente x in listaClientes)
            {
                if (x.ActividadEmpresa.Descripcion == actividad)
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


        public List<Cliente> BuscarClienteTipo(string tipo)
        {
            List<Cliente> listaTemp = new List<Cliente>();

            foreach (Cliente x in listaClientes)
            {
                if (x.TipoEmpresa.Descripcion == tipo)
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
