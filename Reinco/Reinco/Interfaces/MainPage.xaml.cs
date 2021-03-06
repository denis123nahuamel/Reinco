﻿using Reinco.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Reinco.Interfaces
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : MasterDetailPage
    {
        
        public MainPage()
        {
            InitializeComponent();
            paginaMenu.menuListView.ItemSelected += MenuListView_ItemSelected;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            App.Navigator = this;
        }

        private void MenuListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MenuPrincipalItem;
            if(item != null)
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
                paginaMenu.menuListView.SelectedItem = null;
                IsPresented = false;    
            }

        }
    }
}
