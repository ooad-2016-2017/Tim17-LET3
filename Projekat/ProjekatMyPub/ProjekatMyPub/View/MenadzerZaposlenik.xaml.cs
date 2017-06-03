using ProjekatMyPub.ViewModel;
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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace ProjekatMyPub.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MenadzerZaposlenik : Page
    {
        public MenadzerZaposlenik()
        {
            this.InitializeComponent();

            NavigationCacheMode = NavigationCacheMode.Required;
        }

        private void PrikaziMeni_Click(object sender, RoutedEventArgs e)
        {
            MojSplitView.IsPaneOpen = !MojSplitView.IsPaneOpen;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {

            DataContext = (ViewModel1)e.Parameter;

            var currentView = SystemNavigationManager.GetForCurrentView();

            currentView.AppViewBackButtonVisibility = AppViewBackButtonVisibility.Collapsed;

        }

        private void MeniStavkeListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
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
