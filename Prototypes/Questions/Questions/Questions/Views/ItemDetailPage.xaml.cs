using System.ComponentModel;
using Xamarin.Forms;
using Questions.ViewModels;

namespace Questions.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}