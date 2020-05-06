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
    /// Lógica de interacción para VentanaDetalleContrato.xaml
    /// </summary>
    public partial class VentanaDetalleContrato : Window
    {

        ContratoColeccion contratoColeccion;
        TipoEvento tipoEvento;
        public VentanaDetalleContrato()
        {
            InitializeComponent();
        }

        public VentanaDetalleContrato(ContratoColeccion contratoColeccion, TipoEvento tipoEvento)
        {
            InitializeComponent();
            this.contratoColeccion = contratoColeccion;
            this.tipoEvento = tipoEvento;
        }



    }
}
