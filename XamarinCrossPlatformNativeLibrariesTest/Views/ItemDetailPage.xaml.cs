using System.ComponentModel;
using Xamarin.Forms;
using XamarinCrossPlatformNativeLibrariesTest.ViewModels;

namespace XamarinCrossPlatformNativeLibrariesTest.Views
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