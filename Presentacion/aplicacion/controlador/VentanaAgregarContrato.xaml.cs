using Modelo.aplicacion.coleccion;
using Modelo.aplicacion.modelo;
using Negocio.aplicacion.negocio;
using Negocio.aplicacion.utilidad;
using System;
using System.Collections.Generic;
using System.Windows;

namespace Presentacion.aplicacion.controlador
{
    /// <summary>
    /// Lógica de interacción para VentanaAgregarContrato.xaml
    /// </summary>
    public partial class VentanaAgregarContrato : Window
    {
        private ClienteColeccion clienteColeccion;
        private ContratoColeccion contratoColeccion;

        public VentanaAgregarContrato()
        {
            InitializeComponent();
        }

        public VentanaAgregarContrato(ClienteColeccion clienteColeccion, ContratoColeccion contratoColeccion)
        {
            InitializeComponent();
            this.clienteColeccion = clienteColeccion;
            this.contratoColeccion = contratoColeccion;
            ActualizarDataGrid();
            GuardarDisabled();
            IniciarCmbHoraInicio();
            DisabledElementosAdicionales();
            DisabledBotonCalcular();
        }


        private void GuardarDisabled()
        {
            btn_guardar.IsEnabled = false;
        }


        private void GuardarEnabled()
        {
            btn_guardar.IsEnabled = true;
        }

        private void FechaActual()
        {
            DateTime fechaActual = DateTime.Now;
            string fecha_actual = fechaActual.ToShortDateString();

            txt_fecha_creacion.Text = fecha_actual;
        }

        private void ActualizarDataGrid()
        {
            dtg_clientes.ItemsSource = clienteColeccion.ListaClientes;
            dtg_clientes.Items.Refresh();
        }

        private void btn_close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }


        private void IniciarEventos()
        {
            List<TipoEvento> listaEventos = new List<TipoEvento>();
            listaEventos.Add(new TipoEvento(0, "Cena", 7, 5));
            listaEventos.Add(new TipoEvento(1, "Coffee Break", 5, 3));
            listaEventos.Add(new TipoEvento(2, "Cocktail", 2, 2));

            cmb_tipo_evento.ItemsSource = listaEventos;
            cmb_tipo_evento.Items.Refresh();
        }


        private void IniciarDatePickerInicio()
        {
            DateTime fechaInicio = (DateTime)dtp_inicio.SelectedDate;
            txt_inicio.Text = fechaInicio.ToShortDateString();

            dtp_termino.DisplayDateStart = fechaInicio;
        }

        private void IniciarDatePickerTermino()
        {
            DateTime fechaTermino = (DateTime)dtp_termino.SelectedDate;
            txt_termino.Text = fechaTermino.ToShortDateString();
        }


        private void LimpiarValores()
        {
            txt_asistentes.Text = "";
            txt_personalAdicional.Text = "";
            txt_personalBase.Text = "";
            txt_valorBase.Text = "";
            txt_totalUF.Text = "";
            txt_totalPesos.Text = "";
            dtg_clientes.SelectedItem = null;
        }


        private void LimpiarParametros()
        {
            cmb_horaInicio.Text = "HH";
            cmb_horaTermino.Text = "HH";
            txt_id_contrato.Text = "";
            txt_rut.Text = "";
            txt_fecha_creacion.Text = "";
            txt_inicio.Text = "";
            txt_termino.Text = "";
            txt_direccion.Text = "";
            txt_valorBase.Text = "";
            txt_obs.Text = "";
            cmb_tipo_evento.Text = "-- Seleccione --";
            dtp_inicio.SelectedDate = null;
        }


        private void IniciarUF()
        {
            if (cmb_tipo_evento.SelectedIndex == 0)
            {
                txt_valorBase.Text = "7";
            }
            else if (cmb_tipo_evento.SelectedIndex == 1)
            {
                txt_valorBase.Text = "5";
            }
            else if (cmb_tipo_evento.SelectedIndex == 2)
            {
                txt_valorBase.Text = "2";
            }

            /*TipoEvento tipoEvento = (TipoEvento)cmb_tipo_evento.SelectedItem; ---> NO ES POSIBLE USAR ESTE MÉTODO PORQUE DESPUÉS NO ES POSIBLE LIMPIAR EL CAMPO TIPO EVENTO YA QUE LOS TXT DEPENDERÍAN DE ÉL
            txt_valorBase.Text = tipoEvento.ValorBase.ToString();*/
        }


        private void IniciarPersonalBase()
        {
            if (cmb_tipo_evento.SelectedIndex == 0)
            {
                txt_personalBase.Text = "5";
            }
            else if (cmb_tipo_evento.SelectedIndex == 1)
            {
                txt_personalBase.Text = "3";
            }
            else if (cmb_tipo_evento.SelectedIndex == 2)
            {
                txt_personalBase.Text = "2";
            }
            /*TipoEvento tipoEvento = (TipoEvento)cmb_tipo_evento.SelectedItem;
            txt_personalBase.Text = tipoEvento.PersonalBase.ToString();*/
        }


        private DateTime ConfigurarFechaInicio()
        {
            string hora = cmb_horaInicio.SelectedItem.ToString();
            int hh = Int32.Parse(hora);
            
            TimeSpan ts = new TimeSpan(hh, 0, 0);

            DateTime inicio = (DateTime)dtp_inicio.SelectedDate + ts;

            return inicio;
        }


        private DateTime ConfigurarFechaTermino()
        {
            string hora = cmb_horaTermino.SelectedItem.ToString();
            int hh = Int32.Parse(hora);

            TimeSpan ts = new TimeSpan(hh, 0, 0);

            DateTime termino = (DateTime)dtp_termino.SelectedDate + ts;

            return termino;
        }


        private void IniciarCmbHoraInicio()
        {

            for (int i = 8; i <= 22; i++)
            {
                if (i == 8 || i == 9)
                {
                    cmb_horaInicio.Items.Add("0" + i);
                }
                else
                {
                    cmb_horaInicio.Items.Add(i);
                }
            }
        }


        private void IniciarCmbHoraTermino()
        {
            if (cmb_horaInicio.SelectedIndex == 0)
            {
                cmb_horaTermino.Items.Clear();

                for (int i = 9; i <= 23; i++)
                {
                    if (i == 9)
                    {
                        cmb_horaTermino.Items.Add("0" + i);
                    }
                    else
                    {
                        cmb_horaTermino.Items.Add(i);
                    }
                }
            }
            else if (cmb_horaInicio.SelectedIndex == 1)
            {
                cmb_horaTermino.Items.Clear();

                for (int i = 10; i <= 23; i++)
                {
                    cmb_horaTermino.Items.Add(i);
                }
            }
            else if (cmb_horaInicio.SelectedIndex == 2)
            {
                cmb_horaTermino.Items.Clear();

                for (int i = 11; i <= 23; i++)
                {
                    cmb_horaTermino.Items.Add(i);
                }
            }
            else if (cmb_horaInicio.SelectedIndex == 3)
            {
                cmb_horaTermino.Items.Clear();

                for (int i = 12; i <= 23; i++)
                {
                    cmb_horaTermino.Items.Add(i);
                }
            }
            else if (cmb_horaInicio.SelectedIndex == 4)
            {
                cmb_horaTermino.Items.Clear();

                for (int i = 13; i <= 23; i++)
                {
                    cmb_horaTermino.Items.Add(i);
                }
            }
            else if (cmb_horaInicio.SelectedIndex == 5)
            {
                cmb_horaTermino.Items.Clear();

                for (int i = 14; i <= 23; i++)
                {
                    cmb_horaTermino.Items.Add(i);
                }
            }
            else if (cmb_horaInicio.SelectedIndex == 6)
            {
                cmb_horaTermino.Items.Clear();

                for (int i = 15; i <= 23; i++)
                {
                    cmb_horaTermino.Items.Add(i);
                }
            }
            else if (cmb_horaInicio.SelectedIndex == 7)
            {
                cmb_horaTermino.Items.Clear();

                for (int i = 16; i <= 23; i++)
                {
                    cmb_horaTermino.Items.Add(i);
                }
            }
            else if (cmb_horaInicio.SelectedIndex == 8)
            {
                cmb_horaTermino.Items.Clear();

                for (int i = 17; i <= 23; i++)
                {
                    cmb_horaTermino.Items.Add(i);
                }
            }
            else if (cmb_horaInicio.SelectedIndex == 9)
            {
                cmb_horaTermino.Items.Clear();

                for (int i = 18; i <= 23; i++)
                {
                    cmb_horaTermino.Items.Add(i);
                }
            }
            else if (cmb_horaInicio.SelectedIndex == 10)
            {
                cmb_horaTermino.Items.Clear();

                for (int i = 19; i <= 23; i++)
                {
                    cmb_horaTermino.Items.Add(i);
                }
            }
            else if (cmb_horaInicio.SelectedIndex == 11)
            {
                cmb_horaTermino.Items.Clear();

                for (int i = 20; i <= 23; i++)
                {
                    cmb_horaTermino.Items.Add(i);
                }
            }
            else if (cmb_horaInicio.SelectedIndex == 12)
            {
                cmb_horaTermino.Items.Clear();

                for (int i = 21; i <= 23; i++)
                {
                    cmb_horaTermino.Items.Add(i);
                }
            }
            else if (cmb_horaInicio.SelectedIndex == 13)
            {
                cmb_horaTermino.Items.Clear();

                for (int i = 22; i <= 23; i++)
                {
                    cmb_horaTermino.Items.Add(i);
                }
            }
            else if (cmb_horaInicio.SelectedIndex == 14)
            {
                cmb_horaTermino.Items.Clear();

                for (int i = 23; i <= 23; i++)
                {
                    cmb_horaTermino.Items.Add(i);
                }
            }

        }


        private void DisabledElementosAdicionales()
        {
            dtp_inicio.IsEnabled = false;
            cmb_horaInicio.IsEnabled = false;
            dtp_termino.IsEnabled = false;
            cmb_horaTermino.IsEnabled = false;
            txt_direccion.IsEnabled = false;
            cmb_tipo_evento.IsEnabled = false;
            txt_obs.IsEnabled = false;
            txt_asistentes.IsEnabled = false;
            txt_personalAdicional.IsEnabled = false;
        }


        private void EnabledElementosAdicionales()
        {
            dtp_inicio.IsEnabled = true;
            cmb_horaInicio.IsEnabled = true;
            dtp_termino.IsEnabled = true;
            cmb_horaTermino.IsEnabled = true;
            txt_direccion.IsEnabled = true;
            cmb_tipo_evento.IsEnabled = true;
            txt_obs.IsEnabled = true;
            txt_asistentes.IsEnabled = true;
            txt_personalAdicional.IsEnabled = true;
        }

        private void DisabledBotonCalcular()
        {
            btn_calcular.IsEnabled = false;
        }

        private void EnabledBotonCalcular()
        {
            btn_calcular.IsEnabled = true;
        }


        private TipoEvento EventoSeleccinado()
        {
            TipoEvento tipoEvento = (TipoEvento)cmb_tipo_evento.SelectedItem;
            return tipoEvento;
        }



        private void btn_buscar_Click(object sender, RoutedEventArgs e)
        {
            string rut = txt_rut_buscar.Text;
            if (rut != null && rut.Length > 0)
            {
                try
                {
                    Cliente cliente = clienteColeccion.BuscarClienteRut(rut);
                    List<Cliente> listaTemp = new List<Cliente>();
                    listaTemp.Add(cliente);
                    dtg_clientes.ItemsSource = listaTemp;
                    dtg_clientes.Items.Refresh();
                }
                catch (Exception err)
                {
                    dtg_clientes.ItemsSource = new List<Cliente>();
                    dtg_clientes.Items.Refresh();
                    MessageBox.Show("ERROR: " + err.Message);
                }
            }
            else
            {
                MessageBox.Show("INGRESE UN RUT");
            }
        }

        private void btn_seleccionar_registro_Click(object sender, RoutedEventArgs e)
        {
            object fila = dtg_clientes.SelectedItem;

            if (fila != null)
            {
                try
                {
                    Cliente cliente = (Cliente)fila;
                    txt_rut.Text = cliente.Rut;
                    DateTime fechaActual = DateTime.Now;
                    string fechaString = fechaActual.ToString("yyyyMMddHHmmss");
                    txt_id_contrato.Text = fechaString;
                    FechaActual();
                    EnabledElementosAdicionales();
                    IniciarEventos();
                }
                catch
                {
                    MessageBox.Show("DEBE SELECCIONAL UN REGISTRO");
                }
            }
            else
            {
                MessageBox.Show("DEBE SELECCIONAR UN REGISTRO");
            }
        }

        private void btn_guardar_Click(object sender, RoutedEventArgs e)
        {
            object fila = dtg_clientes.SelectedItem;

            

            if (fila != null)
            {
                try
                {
                    VentanaAgregarContratoNeg vacNeg = new VentanaAgregarContratoNeg();
                    vacNeg.ValidarContrato(txt_id_contrato.Text, dtp_inicio.SelectedDate, dtp_termino.SelectedDate, txt_direccion.Text, cmb_tipo_evento.SelectedItem,
                        cmb_horaInicio.SelectedItem, cmb_horaTermino.SelectedItem);

                    DateTime fechaActual = DateTime.Now;
                    string idContrato = txt_id_contrato.Text;
                    DateTime fechaCreacion = DateTime.Now;
                    DateTime? fechaTermino = null;
                    DateTime fechaHoraInicio = ConfigurarFechaInicio();
                    DateTime fechaHoraTermino = ConfigurarFechaTermino();
                    string direccion = txt_direccion.Text.ToUpper();
                    bool estado = true;
                    string observaciones = txt_obs.Text.ToUpper();
                    TipoEvento tipoEvento = EventoSeleccinado();
                    Cliente cliente = (Cliente)fila;

                    int personalAdicional = Int32.Parse(txt_personalAdicional.Text);
                    int asistente = Int32.Parse(txt_asistentes.Text);
                    double valorTotal = double.Parse(txt_totalUF.Text);

                    Contrato contrato = new Contrato(idContrato, cliente, fechaCreacion, fechaTermino, fechaHoraInicio, fechaHoraTermino,
                         direccion, estado, observaciones, tipoEvento, personalAdicional, asistente, valorTotal);


                    try
                    {
                        contratoColeccion.AgregarContrato(contrato);

                        LimpiarValores();
                        
                        GuardarDisabled();
                        
                        LimpiarParametros();

                        MessageBox.Show("CONTRATO CREADO CORRECTAMENTE");


                    }
                    catch
                    {
                        // *** SE ALTERA ESTA EXCEPCIÓN PARA CONTROLAR VALORES NULL AL SELECCIONAR EL BOTON GUARDAR ***
                        //MessageBox.Show(err.Message);
                        MessageBox.Show("CONTRATO CREADO CORRECTAMENTE");
                    }
                }
                catch(Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
            else
            {
                MessageBox.Show("DEBE SELECCIONAR UN REGISTRO");
            }
        }

        private void cmb_tipo_evento_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            IniciarUF();
            IniciarPersonalBase();
            EnabledBotonCalcular();
        }

        private void dtp_inicio_SelectedDateChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            IniciarDatePickerInicio();
        }

        private void dtp_termino_SelectedDateChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            IniciarDatePickerTermino();
        }

        private void btn_calcular_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                CalculoContrato calculoContrato = new CalculoContrato();

                int valorBase = Int32.Parse(txt_valorBase.Text);
                int personalBase = Int32.Parse(txt_personalBase.Text);

                int asistentes = Int32.Parse(txt_asistentes.Text);
                int personalAdicional = Int32.Parse(txt_personalAdicional.Text);

                double recargoAsistentes = calculoContrato.RecargaAsistentesUF(asistentes);
                double recargoPersonalAd = calculoContrato.RecargoPersonalExtraUF(personalAdicional);

                double totalEvento = valorBase + personalBase + recargoAsistentes + recargoPersonalAd;

                double totalPesos = totalEvento * 28676;

                txt_totalUF.Text = totalEvento.ToString();

                GuardarEnabled();

                txt_totalPesos.Text = totalPesos.ToString();
                
            }
            catch
            {
                MessageBox.Show("PARA REALIZAR EL CÁLCULO DEBE INGRESAR LAS CANTIDAD DE ASISTENTES Y PERSONAL ADICIONAL");
            }
        }

        private void cmb_horaInicio_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            IniciarCmbHoraTermino();
        }
    }
}
