﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Final_Project_UI_Demo
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage ()
        {
            InitializeComponent();
        }

        private void moreInfoBtn_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Alert", "This will go to the more info page", "OK");
        }
    }
}
