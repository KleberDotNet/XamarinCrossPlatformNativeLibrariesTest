using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using XamarinCrossPlatformNativeLibrariesTest.Services;

namespace XamarinCrossPlatformNativeLibrariesTest.ViewModels
{
    public class CalculatorViewModel : BaseViewModel
    {

        public CalculatorViewModel()
        {
            Title = "Calculator";
            CalculateSumCommand = new Command(CalculateSum);
            CalculateSumCommandJava = new Command(CalculateSumJava);
        }

        #region C# (Xamarin) Calculator
        private int _firstNumber;
        public int FirstNumber
        {
            get { return _firstNumber; }
            set
            {
                _firstNumber = value;
                OnPropertyChanged(nameof(FirstNumber));
            }
        }

        private int _secondNumber;
        public int SecondNumber
        {
            get { return _secondNumber; }
            set
            {
                _secondNumber = value;
                OnPropertyChanged(nameof(SecondNumber));
            }
        }

        private int _sumResult;
        public int SumResult
        {
            get { return _sumResult; }
            set
            {
                _sumResult = value;
                OnPropertyChanged(nameof(SumResult));
            }
        }

        public ICommand CalculateSumCommand { get; }

        private void CalculateSum()
        {
            SumResult = FirstNumber + SecondNumber;
            Console.WriteLine(SumResult.ToString() + "metodo chamado");
        }
        #endregion


        #region JAVA (Android Native) Calculator
        private int _firstNumberJava;
        public int FirstNumberJava
        {
            get { return _firstNumberJava; }
            set
            {
                _firstNumberJava = value;
                OnPropertyChanged(nameof(FirstNumberJava));
            }
        }

        private int _secondNumberJava;
        public int SecondNumberJava
        {
            get { return _secondNumberJava; }
            set
            {
                _secondNumberJava = value;
                OnPropertyChanged(nameof(SecondNumberJava));
            }
        }

        private int _sumResultJava;
        public int SumResultJava
        {
            get { return _sumResultJava; }
            set
            {
                _sumResultJava = value;
                OnPropertyChanged(nameof(SumResultJava));
            }
        }

        public ICommand CalculateSumCommandJava { get; }

        private IAndroidCalculator calculator = DependencyService.Get<IAndroidCalculator>();

        private void CalculateSumJava()
        {
            SumResultJava = calculator.Sum(FirstNumberJava, SecondNumberJava);
            Console.WriteLine(SumResultJava.ToString() + "JAVA CODE!");
        }

        #endregion
    }
}