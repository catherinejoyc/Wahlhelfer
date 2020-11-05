using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Questions2
{
    public partial class MainPage : ContentPage
    {
        public Color StandardButtonColor { get; set; }

        public string Answer1Text { get; private set; }
        public Color Answer1BGColor { get; private set; }
        public string Answer2Text { get; private set; }
        public Color Answer2BGColor { get; private set; }

        public string DetailedAnswer { get; private set; }

        public ICommand ShowAnswersCommand { get; private set; }
        void ShowAnswers()
        {
            Answer1BGColor = Color.DarkGreen;
            Answer2BGColor = Color.DarkRed;

            DetailedAnswer = "Die nächste Hochschülerschaftswahl findet 2021 statt.";

            InitializeComponent();
        }

        public MainPage()
        {
            StandardButtonColor = Color.LightSeaGreen;
            Answer1BGColor = StandardButtonColor;
            Answer2BGColor = StandardButtonColor;

            Answer1Text = "Alle zwei Jahre";
            Answer2Text = "Zu jedem Vollmond";

            ShowAnswersCommand = new Command(ShowAnswers);

            DetailedAnswer = "";

            InitializeComponent();

            BindingContext = this;
        }
    }
}
