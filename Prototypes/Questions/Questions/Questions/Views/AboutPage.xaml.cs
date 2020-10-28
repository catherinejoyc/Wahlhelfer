using Questions.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Questions.Views
{
    public partial class AboutPage : ContentPage
    {
        public IList<Item> Items { get; private set; }

        public AboutPage()
        {
            InitializeComponent();

            Items = new List<Item>();
            Items.Add(new Item
            {
                Text = "Zu jedem Vollmond"
            });

            Items.Add(new Item
            {
                Text = "Alle 2 Jahre"
            });

            BindingContext = this;
        }
    }
}