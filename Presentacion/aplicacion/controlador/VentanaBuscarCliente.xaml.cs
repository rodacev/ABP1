using Modelo.aplicacion.coleccion;
using Modelo.aplicacion.modelo;
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
    /// Lógica de interacción para VentanaBuscarCliente.xaml
    /// </summary>
    public partial class VentanaBuscarCliente : Window
    {
        ClienteColeccion coleccion;
        ContratoColeccion contratoColeccion;
        public VentanaBuscarCliente()
        {
            InitializeComponent();
        }

        public VentanaBuscarCliente(ClienteColeccion coleccion, ContratoColeccion contratoColeccion)
        {
            InitializeComponent();
            this.coleccion = coleccion;
            this.contratoColeccion = contratoColeccion;
            ActualizarDataGrid();
            IniciarActividad();
            IniciarTipo();
            ActivarRadioButtonRut();
            IniciarDataContrato();
            
        }

        private void ActualizarDataGrid()
        {
            dtg_clientes.ItemsSource = coleccion.ListaClientes;
            dtg_clientes.Items.Refresh();
        }


        private void IniciarActividad()
        {
            List<ActividadEmpresa> listaActividades = new List<ActividadEmpresa>();

            listaActividades.Add(new ActividadEmpresa(1, "Agropecuaria"));
            listaActividades.Add(new ActividadEmpresa(2, "Minería"));
            listaActividades.Add(new ActividadEmpresa(3, "Manufactura"));
            listaActividades.Add(new ActividadEmpresa(4, "Comercio"));
            listaActividades.Add(new ActividadEmpresa(5, "Hotelería"));
            listaActividades.Add(new ActividadEmpresa(6, "Alimentos"));
            listaActividades.Add(new ActividadEmpresa(7, "Transporte"));
            listaActividades.Add(new ActividadEmpresa(8, "Servicios"));

            cmb_actividad.ItemsSource = listaActividades;
            cmb_actividad.Items.Refresh();
        }

        private void IniciarTipo()
        {
            List<TipoEmpresa> listaTipos = new List<TipoEmpresa>();

            listaTipos.Add(new TipoEmpresa(1,"SPA"));
            listaTipos.Add(new TipoEmpresa(2, "EIRL"));
            listaTipos.Add(new TipoEmpresa(3, "LTDA"));
            listaTipos.Add(new TipoEmpresa(4, "SA"));

            cmb_tipo.ItemsSource = listaTipos;
            cmb_tipo.Items.Refresh();
        }

        private void btn_close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }


        public void ActivarRadioButtonRut()
        {
            rb_rut.IsChecked = true;
            txt_rut.IsEnabled = true;
            //Desactivar RadioButton + ComboBox
            rb_actividad.IsChecked = false;
            cmb_actividad.IsEnabled = false;
            rb_tipo.IsChecked = false;
            cmb_tipo.IsEnabled = false;
            cmb_actividad.Text = "-- Seleccione --";
            cmb_tipo.Text = "-- Seleccione --";
               
        }


        public void ActivarRadioButtonActividad()
        {
            //Activar RadioButton + Combobox
            rb_actividad.IsChecked = true;
            cmb_actividad.IsEnabled = true;
            //Desactivar RadioButton + ComboBox + TextBox
            rb_rut.IsChecked = false;
            txt_rut.IsEnabled = false;
            rb_tipo.IsChecked = false;
            cmb_tipo.IsEnabled = false;
            cmb_tipo.Text = "-- Seleccione --";
            txt_rut.Text = "";
        }

        public void ActivarRadioButtonTipo()
        {
            //Activar RadioButton + Combobox
            rb_tipo.IsChecked = true;
            cmb_tipo.IsEnabled = true;
            //Desactivar RadioButton + ComboBox + TextBox
            rb_rut.IsChecked = false;
            txt_rut.IsEnabled = false;
            rb_actividad.IsChecked = false;
            cmb_actividad.IsEnabled = false;
            cmb_actividad.Text = "-- Seleccione --";
            txt_rut.Text = "";
        }


        private void IniciarDataContrato()
        {
            dtg_contrato.ItemsSource = new List<Contrato>();
            dtg_contrato.Items.Refresh();
        }

        private void rb_rut_Checked(object sender, RoutedEventArgs e)
        {
            ActivarRadioButtonRut();
        }

        private void rb_actividad_Checked(object sender, RoutedEventArgs e)
        {
            ActivarRadioButtonActividad();
        }

        private void rb_tipo_Checked(object sender, RoutedEventArgs e)
        {
            ActivarRadioButtonTipo();
        }


        private void btn_buscar_Click(object sender, RoutedEventArgs e)
        {
            if (rb_rut.IsChecked == true)
            {
                string rut = txt_rut.Text;

                if (rut != null && rut.Length > 0)
                {
                    try
                    {
                        Cliente cliente = coleccion.BuscarClienteRut(rut);
                        List<Cliente> listaTemp = new List<Cliente>();
                        listaTemp.Add(cliente);
                        dtg_clientes.ItemsSource = listaTemp;
                        dtg_clientes.Items.Refresh();
                        dtg_contrato.ItemsSource = new List<Contrato>();
                        dtg_contrato.Items.Refresh();
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message);
                    }
                }
                else
                {
                    MessageBox.Show("INGRESE UN RUT");
                }
            }


            else if (rb_actividad.IsChecked == true)
            {
                string actividad = cmb_actividad.Text;

                if (actividad != "-- Seleccione --")
                {
                    try
                    {
                        List<Cliente> ListaTemp = coleccion.BuscarClienteActividad(actividad);
                        dtg_clientes.ItemsSource = ListaTemp;
                        dtg_clientes.Items.Refresh();
                        dtg_contrato.ItemsSource = new List<Contrato>();
                        dtg_contrato.Items.Refresh();

                    }
                    catch(Exception err)
                    {
                        dtg_clientes.ItemsSource = new List<Cliente>();
                        dtg_clientes.Items.Refresh();
                        MessageBox.Show(err.Message);
                    }
                }
                else
                {
                    MessageBox.Show("DEBE SELECCIONAR UNA ACTIVIDAD");
                }
            }


            if (rb_tipo.IsChecked == true)
            {
                string tipo = cmb_tipo.Text;

                if (tipo != "-- Seleccione --")
                {
                    try
                    {
                        List<Cliente> ListaTemp = coleccion.BuscarClienteTipo(tipo);
                        dtg_clientes.ItemsSource = ListaTemp;
                        dtg_clientes.Items.Refresh();
                        dtg_contrato.ItemsSource = new List<Contrato>();
                        dtg_contrato.Items.Refresh();
                    }
                    catch(Exception err)
                    {
                        dtg_clientes.ItemsSource = new List<Cliente>();
                        dtg_clientes.Items.Refresh();
                        MessageBox.Show(err.Message);
                    }
                }
                else
                {
                    MessageBox.Show("DEBE SELECCIONAR UN TIPO");
                }
            }
        }

        private void btn_contratos_Click(object sender, RoutedEventArgs e)
        {
            object fila = dtg_clientes.SelectedItem;
            

            if (fila != null)
            {
                Cliente cliente = (Cliente)fila;

                List<Contrato> listaContratos = contratoColeccion.ListaContratos;
                List<Contrato> listaMuestra = new List<Contrato>();

                foreach (Contrato x in listaContratos)
                {
                    if (x.Cliente.Rut == (cliente.Rut))
                    {
                        listaMuestra.Add(x);
                    }
                }
                dtg_contrato.ItemsSource = listaMuestra;
                dtg_contrato.Items.Refresh();
                
                if (listaMuestra.Count == 0)
                {
                    MessageBox.Show("NO EXISTEN CONTRATOS ASOCIADOS A ESTE CLIENTE");
                }
            }
            else
            {
                MessageBox.Show("DEBE SELECCIONAR UN REGISTRO");
            }
        }












    }
}
