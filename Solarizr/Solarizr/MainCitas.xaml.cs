using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.ViewManagement;
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
    public sealed partial class MainCitas : Page
    {
        public MainCitas()
        {
            this.InitializeComponent();
            ApplicationView.PreferredLaunchViewSize = new Size(600, 800);
            ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.PreferredLaunchViewSize;
            ApplicationView.GetForCurrentView().SetPreferredMinSize(new Size { Width = 600, Height = 800 });
        }
        /// <summary>
        /// Evento asociado al click en la lista. Te lleva a la pagina de cotas,
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Lista_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            this.Frame.Navigate(typeof(citas));
        }

        /// <summary>
        /// Evento asociado al boton. Te lleva a la pagina MainPage
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Close_Click(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(MainPage));
        }
    }
}
