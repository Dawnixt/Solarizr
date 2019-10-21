using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace Solarizr
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class citas : Page
    {
        public citas()
        {
            this.InitializeComponent();
        }
        /// <summary>
        /// Evento asociado al click del boton. Te lleva a la pagina de Notas.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AppBarButton_Click(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(Notas));
        }
        /// <summary>
        /// Evento asociado al click del boton. Te lleva a la paginas de MainCitas.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Back_Click(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(MainCitas));
        }

        /// <summary>
        /// Evento asociado al click del boton. Te lleva a la pagina de Fotos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AppBarButton_Click_1(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(Fotos));
        }
    }
}
