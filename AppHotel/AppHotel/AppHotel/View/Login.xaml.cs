using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppHotel.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        App PropiedadesApp;
        public Login()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);

            PropiedadesApp = (App)Application.Current;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            string usuario = txt_usuario.Text;
            string senha = txt_senha.Text;
            string usuario_correto = "Usuario";
            string senha_correta = "etec";

            if (usuario == usuario_correto && senha == senha_correta)
            {
                App.Current.Properties.Add("usuario_logado", usuario);
                App.Current.MainPage = new ContratacaoHospedagem();
            }
            else
                DisplayAlert("Ops!", "Usuário ou senha incorretos", "OK");
        }
    }//Fecha classe
}//Fecha namespace