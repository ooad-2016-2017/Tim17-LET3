﻿using ProjekatMyPub.ViewModel;
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
    public sealed partial class KorisnikRezervacija : Page
    {
        public KorisnikRezervacija()
        {
            this.InitializeComponent();
            NavigationCacheMode = NavigationCacheMode.Required;
        }

        private void PrikaziMeni_Click(object sender, RoutedEventArgs e)
        {
            MojSplitView1.IsPaneOpen = !MojSplitView1.IsPaneOpen;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {

            DataContext = (ViewModel3)e.Parameter;

            var currentView = SystemNavigationManager.GetForCurrentView();

            currentView.AppViewBackButtonVisibility = AppViewBackButtonVisibility.Collapsed;

        }

        private void MeniStavkeListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            String kliknuta = e.AddedItems[0].ToString();
            if (kliknuta.Equals("Meni"))
            {
                this.Frame.Navigate(typeof(KorisnikPregledMenija), this.DataContext);
            }
            if (kliknuta.Equals("Jukebox"))
            {
                this.Frame.Navigate(typeof(KorisnikJukebox), this.DataContext);
            }
            if (kliknuta.Equals("Log Out"))
            {
                this.Frame.Navigate(typeof(Login), new LogInVM());
            }
        }
    }
}
