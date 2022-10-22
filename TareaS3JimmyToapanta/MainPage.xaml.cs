using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TareaS3JimmyToapanta
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnIniciar_Clicked(object sender, EventArgs e)
        {

            string usuario = "estudiante2022";
            string contraseña = "uisrael2022";

            string tUsuario = txtUsuario.Text;
            string tContraseña = txtContraseña.Text;

            if (usuario == tUsuario & contraseña == tContraseña)
            {

                DisplayAlert("Registro de Notas", "Bienvenido :)", "Cerrar");

                Navigation.PushAsync(new Registro());//instancia entre ventanas de navegacion
            }
            else

            {

                DisplayAlert("Alerta", "Usuario No existe!!", "Cerrar");

            }


        }

    }
}
