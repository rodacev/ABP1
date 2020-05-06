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
    /// Lógica de interacción para VentanaBuscarContrato.xaml
    /// </summary>
    public partial class VentanaBuscarContrato : Window
    {
        ContratoColeccion contratoColeccion;
        public VentanaBuscarContrato()
        {
            InitializeComponent();
        }

        public VentanaBuscarContrato(ContratoColeccion contratoColeccion)
        {
            InitializeComponent();
            this.contratoColeccion = contratoColeccion;
            ActualizarDataGrid();
            IniciarEventos();
            IniciarElementos();
        }
        

        private void btn_close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void ActualizarDataGrid()
        {
            dtg_contratos.ItemsSource = contratoColeccion.ListaContratos;
            dtg_contratos.Items.Refresh();
        }

        private void IniciarEventos()
        {
            List<TipoEvento> listaEventos = new List<TipoEvento>();
            listaEventos.Add(new TipoEvento(1, "Cena", 0, 0));
            listaEventos.Add(new TipoEvento(1, "Coffee Break", 0, 0));
            listaEventos.Add(new TipoEvento(1, "Cocktail", 0, 0));

            cmb_tipo_evento.ItemsSource = listaEventos;
            cmb_tipo_evento.Items.Refresh();
        }



        private void IniciarElementos()
        {
            txt_id_contrato.IsEnabled = false;
            txt_rut_cliente.IsEnabled = false;
            cmb_tipo_evento.IsEnabled = false;
            btn_buscar.IsEnabled = false;
        }


        private void ActivarRadioButtonIdContrato()
        {
            rb_id_contrato.IsChecked = true;
            txt_id_contrato.IsEnabled = true;
            txt_rut_cliente.IsEnabled = false;
            cmb_tipo_evento.IsEnabled = false;
            btn_buscar.IsEnabled = true;
            txt_rut_cliente.Text = "";
            cmb_tipo_evento.Text = "-- Seleccione --";
        }


        private void ActivarRadioButtonRut()
        {
            rb_rut_cliente.IsChecked = true;
            txt_rut_cliente.IsEnabled = true;
            txt_id_contrato.IsEnabled = false;
            cmb_tipo_evento.IsEnabled = false;
            btn_buscar.IsEnabled = true;
            txt_id_contrato.Text = "";
            cmb_tipo_evento.Text = "-- Seleccione --";
        }


        private void ActivarRadioButtonTipo()
        {
            txt_id_contrato.IsEnabled = false;
            txt_rut_cliente.IsEnabled = false;
            cmb_tipo_evento.IsEnabled = true;
            btn_buscar.IsEnabled = true;
            txt_id_contrato.Text = "";
            txt_rut_cliente.Text = "";
        }

        private void btn_finalizar_Click(object sender, RoutedEventArgs e)
        {
            object fila = dtg_contratos.SelectedItem;

            if (fila != null)
            {
                try
                {
                    Contrato contrato = (Contrato)fila;

                    contrato.FechaTermino = DateTime.Now;
                    contrato.Estado = false;
                    ActualizarDataGrid();
                    
                    MessageBox.Show("CONTRATO FINALIZADO CORRECTAMENTE");
                }

                catch
                {
                    MessageBox.Show("DEBE SELECCIONAR UN REGISTRO");
                }
            }
            else
            {
                MessageBox.Show("DEBE SELECCIONAR UN REGISTRO");
            }
        }

        private void rb_id_contrato_Checked(object sender, RoutedEventArgs e)
        {
            ActivarRadioButtonIdContrato();
        }

        private void rb_rut_cliente_Checked(object sender, RoutedEventArgs e)
        {
            ActivarRadioButtonRut();
        }

        private void rb_tipo_evento_Checked(object sender, RoutedEventArgs e)
        {
            ActivarRadioButtonTipo();
        }


        private void btn_buscar_Click(object sender, RoutedEventArgs e)
        {

            if (rb_id_contrato.IsChecked == true)
            {
                string id = txt_id_contrato.Text;

                if (id != null && id.Length > 0)
                {
                    try
                    {
                        Contrato contrato = contratoColeccion.BuscarContratoId(id);
                        List<Contrato> listaTemp = new List<Contrato>();
                        listaTemp.Add(contrato);
                        dtg_contratos.ItemsSource = listaTemp;
                        dtg_contratos.Items.Refresh();
                    }
                    catch(Exception err)
                    {
                        dtg_contratos.ItemsSource = new List<Contrato>();
                        dtg_contratos.Items.Refresh();
                        MessageBox.Show(err.Message);
                    }
                }
            }


            if (rb_rut_cliente.IsChecked == true)
            {
                string rut = txt_rut_cliente.Text;

                if (rut != null && rut.Length > 0)
                {
                    try
                    {
                        List<Contrato> listaTemp = contratoColeccion.BuscarContratoRut(rut);
                        dtg_contratos.ItemsSource = listaTemp;
                        dtg_contratos.Items.Refresh();
                    }
                    catch(Exception err)
                    {
                        dtg_contratos.ItemsSource = new List<Contrato>();
                        dtg_contratos.Items.Refresh();
                        MessageBox.Show(err.Message);
                    }
                }
            }


            if (rb_tipo_evento.IsChecked == true)
            {
                string tipo = cmb_tipo_evento.Text;

                if (tipo != "-- Seleccione --")
                {
                    try
                    {
                        List<Contrato> listaTemp = contratoColeccion.BuscarContratoTipo(tipo);
                        dtg_contratos.ItemsSource = listaTemp;
                        dtg_contratos.Items.Refresh();
                    }
                    catch(Exception err)
                    {
                        dtg_contratos.ItemsSource = new List<Contrato>();
                        dtg_contratos.Items.Refresh();
                        MessageBox.Show(err.Message);
                    }
                }
            }
        }

        















    }
}
