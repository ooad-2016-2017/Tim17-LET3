using ProjekatMyPub.Helper;
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
    public sealed partial class NarudzbenicaForma : Page
    {
        public NarudzbenicaForma()
        {

            this.InitializeComponent();

            var currentView = SystemNavigationManager.GetForCurrentView();
            currentView.AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;
            SystemNavigationManager.GetForCurrentView().BackRequested += ThisPage_BackRequested;

        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            this.DataContext = (ViewModel1)e.Parameter;
        }

        private void ThisPage_BackRequested(object sender, BackRequestedEventArgs e)
        {

            INavigationService navigate = new NavigationService();
            navigate.Navigate(typeof(MenadzerNarudzba), this.DataContext);
        }
    }
}
