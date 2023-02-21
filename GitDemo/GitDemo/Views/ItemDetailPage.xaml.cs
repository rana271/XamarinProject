using GitDemo.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace GitDemo.Views
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