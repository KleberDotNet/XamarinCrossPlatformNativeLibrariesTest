using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XamarinCrossPlatformNativeLibrariesTest.Services;
using Kleber.Mylibrary;

[assembly: Xamarin.Forms.Dependency(typeof(XamarinCrossPlatformNativeLibrariesTest.Droid.AndroidNativeCalculator))]
namespace XamarinCrossPlatformNativeLibrariesTest.Droid
{
    public class AndroidNativeCalculator : IAndroidCalculator
    {
        public int Sum(int a, int b)
        {
            Calculator calculator = new Calculator();
            return calculator.Sum(a, b);
        }
    }
}