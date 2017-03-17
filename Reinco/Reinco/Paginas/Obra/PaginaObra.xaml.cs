﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Reinco.Paginas.Obra
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaObra : ContentPage
    {
        public PaginaObra()
        {
            InitializeComponent();
            agregarObra.Clicked += AgregarObra_Clicked;
        }

        private void AgregarObra_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AgregarObra());
        }
    }
}
