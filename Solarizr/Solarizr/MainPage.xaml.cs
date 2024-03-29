﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0xc0a

namespace Solarizr
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            ApplicationView.PreferredLaunchViewSize = new Size(600, 800);
            ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.PreferredLaunchViewSize;
            ApplicationView.GetForCurrentView().SetPreferredMinSize(new Size { Width = 600, Height = 800 });
        }
        /// <summary>
        /// Evento asociado al click del boton. Te lleva a la pagina MainCitas.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnLogin_Click(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(MainCitas));
        }

        /// <summary>
        /// Evento asociado al click del HyperLink. Te muestra un mensaje en pantalla.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void HyperlinkButton_Click(object sender, RoutedEventArgs e) {
            var dialog = new MessageDialog("La hubieras apuntado, crack.");
            await dialog.ShowAsync();
        }
    }
}
