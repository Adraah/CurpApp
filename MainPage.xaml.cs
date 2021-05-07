using System;
using Xamarin.Forms;

namespace Act14
{
    public partial class MainPage : ContentPage
    {
        string curp;
        public MainPage()
        {
            InitializeComponent();
        }

        void OnAceptar(object sender, EventArgs e)
        {
            curp = Core.GeneradorCurp.Generar(Nombre.Text, ApellidoP.Text, ApellidoM.Text,Fecha.Text,Estado.Text,Sexo.Text);
            if (!string.IsNullOrWhiteSpace(curp))
            {
                Curp.Text = curp;
            }
            else
            {
                Curp.Text = " ";
            }
        }
    }
}
