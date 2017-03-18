﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Reinco.Paginas.Propietario
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaPropietario : ContentPage
    {
        public PaginaPropietario()
        {
            InitializeComponent();
            agregarPropietario.Clicked += AgregarPropietario_Clicked;
        }

        private void AgregarPropietario_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AgregarPropietario());
        }
    }
}