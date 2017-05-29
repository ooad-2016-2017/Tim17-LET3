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
using ProjekatMyPub.DataSource;
using ProjekatMyPub.Model;
using Windows.UI.Popups;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProjekatMyPub.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Login : Page
    {
        public Login()
        {
            this.InitializeComponent();
            DataSource.DataSource init = new DataSource.DataSource();
        }

        private async void buttonNemateRacun_Click(object sender, RoutedEventArgs e)
        {
            
            this.Frame.Navigate(typeof(Registracija));
            
        }

        private async void buttonLogIn_Click(object sender, RoutedEventArgs e)
        {
            String username = textBoxUsername.Text;
            String password = passwordBoxLoginPassword.Password;

            Korisnik uneseni = DataSource.DataSource.DajKorisnikaLogIn(username, password);

            if (uneseni != null && uneseni is Menadzer)
            {
                this.Frame.Navigate(typeof(MenadzerZaposlenik), uneseni);
            }
            else
            {
                var dialog = new MessageDialog("Pogrešno korisničko ime/šifra!", "Neuspješnaprijava");

                await dialog.ShowAsync();
            }
        }
    }
}
