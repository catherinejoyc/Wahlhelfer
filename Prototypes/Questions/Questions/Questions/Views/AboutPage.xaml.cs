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

        public IList<Button> Answers { get; private set; }

        public string Answer1 { get; private set; }
        public string Answer2 { get; private set; }

        public AboutPage()
        {
            Answer1 = "Zu jedem Vollmond";
            Answer2 = "Alle 2 Jahre";

            BindingContext = this;

            //Items = new List<Item>();
            //Items.Add(new Item
            //{
            //    Text = "Zu jedem Vollmond"
            //});

            //Items.Add(new Item
            //{
            //    Text = "Alle 2 Jahre"
            //});

            //Answers = new List<Button>();
            //Answers.Add(new Button
            //{
            //    Text = "Zu jedem Vollmond"
            //});

            //Answers.Add(new Button
            //{
            //    Text = "Alle zwei Jahre"
            //});

            //BindingContext = this;
            InitializeComponent();
        }

        bool button1Clicked = false;
        private void Button_Clicked_1(object sender, EventArgs e)
        {
            //switch ((sender as Button).Text)
            //{
            //    case "Zu jedem Vollmond":
            //        break;
            //    case "Alle zwei Jahre":
            //        break;
            //    default:
            //        break;
            //}

            //Load new page - AboutPageAnswer
            //Navigation.PushAsync(new AboutPageAnswer());

            (sender as Button).Text = "FALSCH";
            button1Clicked = true;

            if (!button2Clicked)
            {
                
            }
        }

        bool button2Clicked = false;
        private void Button_Clicked_2(object sender, EventArgs e)
        {
            //switch ((sender as Button).Text)
            //{
            //    case "Zu jedem Vollmond":
            //        break;
            //    case "Alle zwei Jahre":
            //        break;
            //    default:
            //        break;
            //}

            //Load new page - AboutPageAnswer
            //Navigation.PushAsync(new AboutPageAnswer());

            (sender as Button).Text = "RICHTIG";
            button2Clicked = true;

            if (!button1Clicked)
            {
                
            }
        }
    }
}