using Modelo.aplicacion.coleccion;
using Modelo.aplicacion.modelo;
using Presentacion.aplicacion.controlador;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Presentacion
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ClienteColeccion coleccion;
        private ContratoColeccion contratoColeccion;
        public MainWindow()
        {
            InitializeComponent();
            coleccion = new ClienteColeccion();
            contratoColeccion = new ContratoColeccion();
        }

        private void btn_agregarCliente_Click(object sender, RoutedEventArgs e)
        {
            VentanaAgregarCliente vac = new VentanaAgregarCliente(coleccion, contratoColeccion);

            vac.Owner = this;
            vac.ShowDialog();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            VentanaBuscarCliente vbc = new VentanaBuscarCliente(coleccion, contratoColeccion);

            if (coleccion.ListaClientes.Count == 0)
            {
                MessageBox.Show("PRIMERO DEBE CREAR UN CLIENTE");
            }
            else
            {
                vbc.Owner = this;
                vbc.ShowDialog();
            }
        }


        private void btn_close_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }


        private void btn_agregarContrato_Click(object sender, RoutedEventArgs e)
        {
            VentanaAgregarContrato vac = new VentanaAgregarContrato(coleccion, contratoColeccion);

            if (coleccion.ListaClientes.Count == 0)
            {
                MessageBox.Show("PRIMERO DEBE CREAR UN CLIENTE");
            }
            else
            {
                vac.Owner = this;
                vac.ShowDialog();
            }
        }

        private void btn_buscarContrato_Click(object sender, RoutedEventArgs e)
        {
            VentanaBuscarContrato vbc = new VentanaBuscarContrato(contratoColeccion);

            if (contratoColeccion.ListaContratos.Count == 0)
            {
                MessageBox.Show("PRIMERO DEBE CREAR UN CONTRATO");
            }
            else
            {
                vbc.Owner = this;
                vbc.ShowDialog();
            }
        }

        private void btn_minus_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }




























    }
}
