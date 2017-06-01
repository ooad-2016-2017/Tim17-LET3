using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProjekatMyPub.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ZaposlenikPlaylista : Page
    {
        public ZaposlenikPlaylista()
        {
            this.InitializeComponent();
           // DataContext = new ViewModel2();

            String Stolovi = "Stolovi";
            String Playliste = "Playliste";
            MeniZaposlenikListView.Items.Add(Stolovi);
            MeniZaposlenikListView.Items.Add(Playliste);

            NavigationCacheMode = NavigationCacheMode.Required;
        }

        private void ZaposlenikPlaylistaHamburger_Click(object sender, RoutedEventArgs e)
        {
            ZaposlenikSplitView.IsPaneOpen = !ZaposlenikSplitView.IsPaneOpen;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            var currentView = SystemNavigationManager.GetForCurrentView();
            currentView.AppViewBackButtonVisibility = AppViewBackButtonVisibility.Collapsed;
        }

    
        private void MeniZaposlenikListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            String kliknuta = e.AddedItems[0].ToString();
            if (kliknuta.Equals("Stolovi"))
            {
                this.Frame.Navigate(typeof(ZaposlenikStolovi));
            }

        }

    }
}
