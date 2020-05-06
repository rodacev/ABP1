using Modelo.aplicacion.coleccion;
using Modelo.aplicacion.modelo;
using Negocio.aplicacion.negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Presentacion.aplicacion.controlador
{
    /// <summary>
    /// Lógica de interacción para VentanaAgregarCliente.xaml
    /// </summary>
    public partial class VentanaAgregarCliente : Window
    {
        private ClienteColeccion coleccion;
        private ContratoColeccion contratoColeccion;
        public VentanaAgregarCliente()
        {
            InitializeComponent();
            IniciarActividades();
            IniciarTipoEmpresas();
          
        }

        public VentanaAgregarCliente(ClienteColeccion coleccion, ContratoColeccion contratoColeccion)
        {
            InitializeComponent();
            IniciarActividades();
            IniciarTipoEmpresas();
            this.coleccion = coleccion;
            this.contratoColeccion = contratoColeccion;
            ActualizarDataGrid();
            ActualizarDisabled();
            IniciarModificar();
        }

        private void Limpiar()
        {
            txt_rut.Text = "";
            txt_razonSocial.Text = "";
            txt_nombreContacto.Text = "";
            txt_mailContacto.Text = "";
            txt_direccion.Text = "";
            txt_telefono.Text = "";
            cmb_actividad.Text = "-- Seleccione --";
            cmb_tipoEmpresa.Text = "-- Seleccione --";
        }

        private void IniciarActividades()
        {
            List<ActividadEmpresa> listaActividad = new List<ActividadEmpresa>();

            listaActividad.Add(new ActividadEmpresa(0, "Agropecuaria"));
            listaActividad.Add(new ActividadEmpresa(1, "Minería"));
            listaActividad.Add(new ActividadEmpresa(2, "Manufactura"));
            listaActividad.Add(new ActividadEmpresa(3, "Comercio"));
            listaActividad.Add(new ActividadEmpresa(4, "Hotelería"));
            listaActividad.Add(new ActividadEmpresa(5, "Alimentos"));
            listaActividad.Add(new ActividadEmpresa(6, "Transporte"));
            listaActividad.Add(new ActividadEmpresa(7, "Servicios"));

            cmb_actividad.ItemsSource = listaActividad;
            cmb_actividad.Items.Refresh();
        }

        private void IniciarTipoEmpresas()
        {
            List<TipoEmpresa> listaTipoEmpresa = new List<TipoEmpresa>();

            listaTipoEmpresa.Add(new TipoEmpresa(0, "SPA"));
            listaTipoEmpresa.Add(new TipoEmpresa(1, "EIRL"));
            listaTipoEmpresa.Add(new TipoEmpresa(2, "LTDA"));
            listaTipoEmpresa.Add(new TipoEmpresa(3, "SA"));

            cmb_tipoEmpresa.ItemsSource = listaTipoEmpresa;
            cmb_tipoEmpresa.Items.Refresh();
        }

        private void btn_limpiar_Click(object sender, RoutedEventArgs e)
        {
            Limpiar();
        }

        private void btn_close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ActualizarDisabled()
        {
            btn_actualizar.IsEnabled = false;
            btn_modificar.IsEnabled = true;
            txt_rut.IsEnabled = true;
            btn_guardar.IsEnabled = true;
            btn_borrar.IsEnabled = true;
            btn_limpiar.IsEnabled = true;
        }

        private void ActualizarEnabled()
        {
            txt_rut.IsEnabled = false;
            btn_actualizar.IsEnabled = true;
            btn_guardar.IsEnabled = false;
            btn_modificar.IsEnabled = false;
            btn_limpiar.IsEnabled = false;
            btn_borrar.IsEnabled = false;
        }

        private void IniciarModificar()
        {
            if (dtg_clientes.Items.Count == 0)
            {
                btn_modificar.IsEnabled = false;
            }
            else
            {
                btn_modificar.IsEnabled = true;
            }
        }

        private void ActualizarDataGrid()
        {
            dtg_clientes.ItemsSource = coleccion.ListaClientes;
            dtg_clientes.Items.Refresh();
        }

        private void btn_guardar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                VentanaAgregarClienteNeg vacNeg = new VentanaAgregarClienteNeg();
                vacNeg.ValidarCliente(txt_rut.Text, txt_razonSocial.Text, txt_nombreContacto.Text, txt_mailContacto.Text, txt_direccion.Text, txt_telefono.Text,
                    cmb_actividad.SelectedItem, cmb_tipoEmpresa.SelectedItem);

                string rut = txt_rut.Text.ToUpper();
                rut = rut.Replace(".", "");
                rut = rut.Replace("-", "");
                string razonSocial = txt_razonSocial.Text.ToUpper();
                string nombreContacto = txt_nombreContacto.Text.ToUpper();
                string mailContacto = txt_mailContacto.Text.ToUpper();
                string direccion = txt_direccion.Text.ToUpper();
                string telefono = txt_telefono.Text.ToUpper();
                ActividadEmpresa actividad = (ActividadEmpresa)cmb_actividad.SelectedItem;
                TipoEmpresa tipo = (TipoEmpresa)cmb_tipoEmpresa.SelectedItem;

                Cliente cliente = new Cliente(rut, razonSocial, nombreContacto, mailContacto, direccion, telefono,
                    actividad, tipo);

                try
                {
                    coleccion.AgregarCliente(cliente);
                    ActualizarDataGrid();
                    Limpiar();
                    IniciarModificar();
                    MessageBox.Show("CLIENTE AGREGADO CORRECTAMENTE");
                }

                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }


        private void btn_borrar_Click(object sender, RoutedEventArgs e)
        {
            List<Contrato> listaTempContrato = contratoColeccion.ListaContratos;
            object fila = dtg_clientes.SelectedItem;

            if (fila != null)
            {
                if (fila.GetType() == typeof(Cliente))
                {
                    try
                    {
                        Cliente cliente = (Cliente)fila;
                        bool validador = false;

                        foreach (Contrato x in listaTempContrato)
                        {
                            if (x.Cliente.Rut.Equals(cliente.Rut))
                            {
                                validador = true;
                                break;
                            }
                        }
                        if (validador)
                        {
                            MessageBox.Show("NO ES POSIBLE ELIMINAR UN CLIENTE CON CONTRATOS ASOCIADOS");
                        }
                        else
                        {
                            coleccion.EliminarCliente(cliente);
                            ActualizarDataGrid();
                            MessageBox.Show("CLIENTE ELIMINADO CORRECTAMENTE");
                            IniciarModificar();
                        }
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Error: " + err.Message);
                    }
                 }
            }
        }


        private void btn_modificar_Click(object sender, RoutedEventArgs e)
        {
            object fila = dtg_clientes.SelectedItem;

            if (fila != null)
            {
                try
                {
                    Cliente cliente = (Cliente)fila;
                    ActualizarFormulario(cliente);
                    ActualizarEnabled();

                }
                catch
                {
                    MessageBox.Show("DEBE SELECCIONAR UN REGISTRO VÁLIDO");
                }
            }
        }

        private void ActualizarFormulario(Cliente cliente)
        {
            txt_rut.Text = cliente.Rut;
            txt_razonSocial.Text = cliente.RazonSocial;
            txt_nombreContacto.Text = cliente.NombreContacto;
            txt_mailContacto.Text = cliente.MailContacto;
            txt_direccion.Text = cliente.Direccion;
            txt_telefono.Text = cliente.Telefono;
            cmb_actividad.SelectedIndex = cliente.ActividadEmpresa.IdActividadEmpresa;
            cmb_tipoEmpresa.SelectedIndex = cliente.TipoEmpresa.IdTipoActividad;

        }

        private void btn_actualizar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                VentanaAgregarClienteNeg vacNeg = new VentanaAgregarClienteNeg();
                vacNeg.ValidarCliente(txt_rut.Text, txt_razonSocial.Text, txt_nombreContacto.Text, txt_mailContacto.Text, txt_direccion.Text, txt_telefono.Text,
                    cmb_actividad.SelectedItem, cmb_tipoEmpresa.SelectedItem);

                string rut = txt_rut.Text;
                string razonSocial = txt_razonSocial.Text;
                string nombreContacto = txt_nombreContacto.Text;
                string mailContacto = txt_mailContacto.Text;
                string direccion = txt_direccion.Text;
                string telefono = txt_telefono.Text;
                ActividadEmpresa actividadEmpresa = (ActividadEmpresa)cmb_actividad.SelectedItem;
                TipoEmpresa tipoEmpresa = (TipoEmpresa)cmb_tipoEmpresa.SelectedItem;

                Cliente cliente = new Cliente(rut, razonSocial, nombreContacto, mailContacto, direccion, telefono, actividadEmpresa, tipoEmpresa);

                try
                {
                    coleccion.ModificarCliente(cliente);
                    ActualizarDataGrid();
                    Limpiar();
                    ActualizarDisabled();
                    MessageBox.Show("CLIENTE ACTUALIZADO CORRECTAMENTE");
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}


    