using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Tarea2_1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void btnsegunda_Clicked(object sender, EventArgs e)
        {
            var persona = new Models.Persona
            {
                id = 1, nombre = txtnombre.Text, apellidos = txtapellido.Text, edad = txtedad.Text, correo = txtcorreo.Text
            };

            var pagetwo = new Views.PageTwo();
            pagetwo.BindingContext = persona;
            await Navigation.PushModalAsync(pagetwo);

        }
  
    }
}
