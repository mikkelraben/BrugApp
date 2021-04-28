using System.ComponentModel;
using Xamarin.Forms;
using BrugApp.ViewModels;

namespace BrugApp.Views
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