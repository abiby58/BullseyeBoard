﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BullseyeBoard
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RulesPage : ContentPage
    {
        public RulesPage()
        {
            InitializeComponent();
        }

        private void BackButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GameTypePage());
        }
    }
}