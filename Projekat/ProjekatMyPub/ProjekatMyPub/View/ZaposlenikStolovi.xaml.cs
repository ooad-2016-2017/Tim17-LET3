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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace ProjekatMyPub.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ZaposlenikStolovi : Page
    {
        public ZaposlenikStolovi()
        {
            this.InitializeComponent();
        }

        private void PrikaziMeni_Click(object sender, RoutedEventArgs e)
        {
            ZaposlenikStoloviSplitView.IsPaneOpen = !ZaposlenikStoloviSplitView.IsPaneOpen;
        }

        private void MeniZaposlenikStoloviListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            /*
            String kliknuta = e.AddedItems[0].ToString();
            if (kliknuta.Equals("Narudzba"))
            {
                this.Frame.Navigate(typeof(MenadzerNarudzba), korisnik);
            }
            */

        }
    }
}
