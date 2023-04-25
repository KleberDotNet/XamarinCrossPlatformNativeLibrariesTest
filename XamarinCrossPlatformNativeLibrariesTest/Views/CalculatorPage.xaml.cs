using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinCrossPlatformNativeLibrariesTest.ViewModels;

namespace XamarinCrossPlatformNativeLibrariesTest.Views
{
    public partial class CalculatorPage : ContentPage
    {
        public CalculatorPage()
        {
            InitializeComponent();
            BindingContext = new CalculatorViewModel();
        }
    }
}