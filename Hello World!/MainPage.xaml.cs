using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows;
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
using Windows.UI.Text;


//Szablon elementu Pusta strona jest udokumentowany na stronie https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x415

namespace Hello_World_
{
    /// <summary>
    /// Pusta strona, która może być używana samodzielnie lub do której można nawigować wewnątrz ramki.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            this.settingsDisabler.Visibility = Visibility.Collapsed;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            var fonts = Microsoft.Graphics.Canvas.Text.CanvasTextFormat.GetSystemFontFamilies();
            comboFonts.ItemsSource = fonts;
        }

        private void workyoustupidass(object sender, RoutedEventArgs e)
        {
            bitch.Visibility = Visibility.Collapsed;
            this.settingsActivator.Visibility = Visibility.Collapsed;
            this.settingsDisabler.Visibility = Visibility.Visible;
        }

        private void workyoustupidass2(object sender, RoutedEventArgs e)
        {
            bitch.Visibility = Visibility.Visible;
            this.settingsDisabler.Visibility = Visibility.Collapsed;
            this.settingsActivator.Visibility = Visibility.Visible;
        }

        private void Default_FontSelected(object sender, RoutedEventArgs e)
        {
            padding.FontWeight = FontWeights.Normal;
            padding.FontStyle = FontStyle.Normal;
        }

        private void Italic_FontSelected(object sender, RoutedEventArgs e)
        {
            padding.FontStyle = FontStyle.Italic;
            padding.FontWeight = FontWeights.Normal;
        }

        private void Bold_FontSelected(object sender, RoutedEventArgs e)
        {
            padding.FontWeight = FontWeights.Bold;
            padding.FontStyle = FontStyle.Normal;
        }

        private void BoldandItalic_FontSelected(object sender, RoutedEventArgs e)
        {
            padding.FontWeight = FontWeights.Bold;
            padding.FontStyle = FontStyle.Italic;
        }

        private void SliderRozmiar_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {

        }
    }
}
