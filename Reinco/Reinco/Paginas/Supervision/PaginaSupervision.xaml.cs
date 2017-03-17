﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Reinco.Paginas.Supervision
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaSupervision : ContentPage
    {
        public PaginaSupervision()
        {
            InitializeComponent();
            continuar.Clicked += Continuar_Clicked;
        }

        private void Continuar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NotasSupervision());
        }
    }
}
