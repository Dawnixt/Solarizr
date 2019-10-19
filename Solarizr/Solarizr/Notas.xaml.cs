﻿using System;
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
    public sealed partial class Notas : Page
    {
        public Notas() {
            this.InitializeComponent();
        }

        #region NavigationView event handlers
        private void myNavigation_Loaded(object sender, RoutedEventArgs e) {

            foreach (NavigationViewItemBase item in myNavigation.MenuItems)
            {
                if (item is NavigationViewItem && item.Tag.ToString() == "Notas")
                {

                    myNavigation.SelectedItem = item;
                    break;

                }
            }

            contentFrame.Navigate(typeof(Notas));
        }

        private void myNavigation_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args) {
        }

        private void myNavigation_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args) {
            if (args.IsSettingsInvoked)
            {
                contentFrame.Navigate(typeof(Notas));
            }
            else
            {
                TextBlock ItemContent = args.InvokedItem as TextBlock;
                if (ItemContent != null)
                {
                    switch (ItemContent.Tag)
                    {

                        case "Nav_Citas":
                            contentFrame.Navigate(typeof(MainCitas));
                            break;

                        case "Nav_Notas":
                            contentFrame.Navigate(typeof(Notas));
                            break;

                        case "Nav_Setting":
                            contentFrame.Navigate(typeof(MainCitas));
                            break;

                        case "Nav_Acerca":
                            contentFrame.Navigate(typeof(MainCitas));
                            break;

                        case "Nav_Out":
                            contentFrame.Navigate(typeof(MainPage));
                            break;
                    }

                }
            }
        }
        #endregion
    }
}
