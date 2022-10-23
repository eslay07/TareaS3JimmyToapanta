using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;



namespace TareaS3JimmyToapanta
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {


       
        public Registro()

        {
           
            InitializeComponent();
        }

        private void txtSeguimiento1_TextChanged(object sender, TextChangedEventArgs e)

        {
            int nseguimiento = 0;//declaramos al textbox con valor 0
            int.TryParse(txtSeguimiento1.Text, out nseguimiento);//en esta linea indicamos que si el valor es borrado o da valor nulo la app no se cuelgue y le asigne el valor 0
           

            if (nseguimiento > 10)
            {
                DisplayAlert("Error en el ingreso", "El valor no puede ser mayor a 10 ", "Cerrar");


            }
            else if (nseguimiento<1)
            {
                

            }
          
        }

        private void txtNexamen1_TextChanged(object sender, TextChangedEventArgs e)
        {
            

        }

        private void btnParciaL1_Clicked(object sender, EventArgs e)
        {

            


        }

        private void txtSeguimiento2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtNexamen2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnParciaL2_Clicked(object sender, EventArgs e)
        {

        }

        private void btnInformacion_Clicked(object sender, EventArgs e)
        {

        }
    }
}