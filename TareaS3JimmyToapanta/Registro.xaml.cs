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
                DisplayAlert("Error en el ingreso", "Los valores no pueden ser mayor a 10", "Cerrar");


            }
            else if (nseguimiento<1)
            {
                

            }
          
        }

        private void txtNexamen1_TextChanged(object sender, TextChangedEventArgs e)
        {
            int Nexamen1 = 0;//declaramos al textbox con valor 0
            int.TryParse(txtNexamen1.Text, out Nexamen1);//en esta linea indicamos que si el valor es borrado o da valor nulo la app no se cuelgue y le asigne el valor 0


            if (Nexamen1 > 10)
            {
                DisplayAlert("Error en el ingreso", "Los valores no pueden ser mayor a 10", "Cerrar");
            }
            else if (Nexamen1 < 1)
            {


            }


        }

        private void btnParciaL1_Clicked(object sender, EventArgs e)
        {

            double nseguimiento1 = Convert.ToDouble(txtSeguimiento1.Text);
            double nexamen1 = Convert.ToDouble(txtNexamen1.Text);
            double a = 0.3;
            double b = 0.2;
            double nsegA1;
            double nexamB1;
            
            double parcial1;
            nsegA1 = nseguimiento1 * a;
            nexamB1 = nexamen1 * b;

            parcial1 = nsegA1 + nexamB1;
            
            if (parcial1 > 5)
            {

                DisplayAlert("Error en el ingreso", "Los valores ingresados son incorrectos ", "Cerrar");
                
            }

            else
            {
                notaP1.Text = parcial1.ToString();
            }
                

        }

        private void txtSeguimiento2_TextChanged(object sender, TextChangedEventArgs e)
        {

            int nseguimiento2 = 0;//declaramos al textbox con valor 0
            int.TryParse(txtSeguimiento2.Text, out nseguimiento2);//en esta linea indicamos que si el valor es borrado o da valor nulo la app no se cuelgue y le asigne el valor 0


            if (nseguimiento2 > 10)
            {
                DisplayAlert("Error en el ingreso", "Los valores no pueden ser mayor a 10", "Cerrar");


            }
            else if (nseguimiento2 < 1)
            {


            }

        }

        private void txtNexamen2_TextChanged(object sender, TextChangedEventArgs e)
        {
            int Nexamen2 = 0;//declaramos al textbox con valor 0
            int.TryParse(txtNexamen2.Text, out Nexamen2);//en esta linea indicamos que si el valor es borrado o da valor nulo la app no se cuelgue y le asigne el valor 0


            if (Nexamen2 > 10)
            {
                DisplayAlert("Error en el ingreso", "Los valores no pueden ser mayor a 10", "Cerrar");
            }
            else if (Nexamen2 < 1)
            {


            }


        }

        private void btnParciaL2_Clicked(object sender, EventArgs e)
        {
            double nseguimiento2 = Convert.ToDouble(txtSeguimiento2.Text);
            double nexamen2 = Convert.ToDouble(txtNexamen2.Text);
            double a = 0.3;
            double b = 0.2;
            double nsegA2;
            double nexamB2;

            double parcial2;
            nsegA2 = nseguimiento2 * a;
            nexamB2 = nexamen2 * b;

            parcial2 = nsegA2 + nexamB2;

            if (parcial2 > 5)
            {

                DisplayAlert("Error en el ingreso", "Los valores ingresados son incorrectos ", "Cerrar");

            }

            else
            {
                notaP2.Text = parcial2.ToString();
            }



        }

        private void btnInformacion_Clicked(object sender, EventArgs e)
        {

            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string carrera = txtCarrera.Text;
            double identificacion = Convert.ToDouble(txtIdentificacion.Text);
            double nseguimiento1 = Convert.ToDouble(txtSeguimiento1.Text);
            double nexamen1 = Convert.ToDouble(txtNexamen1.Text);
            double nseguimiento2 = Convert.ToDouble(txtSeguimiento2.Text);
            double nexamen2 = Convert.ToDouble(txtNexamen2.Text);
            double a = 0.3;
            double b = 0.2;
            double nsegA1;
            double nexamB1;
            double nsegA2;
            double nexamB2;
            double parcial1;
            double parcial2;
            double nfinal;

            nsegA1 = nseguimiento1 * a;
            nexamB1 = nexamen1 * b;
            nsegA2 = nseguimiento2 * a;
            nexamB2 = nexamen2 * b;
            parcial1 = nsegA1 + nexamB1;
            parcial2 = nsegA2 + nexamB2;
            nfinal = parcial1 + parcial2;

            if (nfinal >= 7)
            {
                DisplayAlert("Registro de Notas", "Tu nombre es : " + nombre + " " + apellido + "\nCarrera: " + carrera + "\nIdentificacion: " + identificacion + "\nAprobado Con " + nfinal, "Cerrar");
            }
            else if (nfinal >= 5 && nfinal <= 6.9)
            {
                DisplayAlert("Registro de Notas", "Tu nombre es : " + nombre + " " + apellido + "\nCarrera: " + carrera + "\nIdentificacion: " + identificacion + "\nComplementario Con " + nfinal, "Cerrar");
            }
            else if (nfinal < 5)
            {
                DisplayAlert("Registro de Notas", "Tu nombre es : " + nombre + " " + apellido + "\nCarrera: " + carrera + "\nIdentificacion: " + identificacion + "\nReprobado Con " + nfinal, "Cerrar");
            }
            else if (nfinal > 10)
            {
                DisplayAlert("Error en el ingreso", "Los Valores ingresados son incorrectos", "Cerrar");
            }

        }
    }
}