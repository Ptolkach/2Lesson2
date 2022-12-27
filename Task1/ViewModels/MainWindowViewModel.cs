using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using Task1.Models;
using Figure = Task1.Models.Figure;

namespace Task1.ViewModels
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string PropertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }

        public string result;

        public string Result
        {
            get => result;
            set
            {
                result = value;
                OnPropertyChanged();
            }
        }

        public double firstValue;
        public double secondValue;
        public string oper;

        public ICommand PlusCommand { get; }

        private void OnPlusCommandExecute(object p)
        {
            oper = "+";
            firstValue = Convert.ToDouble(Result);
            Result = "";
        }

        private bool CanPlusCommandExecuted(object p)
        {
            if (Result != null)
                return true;
            else
            {
                return false;
            }
        }


        public ICommand MinusCommand { get; }
        private void OnMinusCommandExecute(object p)
        {
            oper = "-";
            firstValue = Convert.ToDouble(Result);
            Result = "";
        }

        private bool CanMinusCommandExecuted(object p)
        {
            if (Result != null)
                return true;
            else
            {
                return false;
            }
        }

        public ICommand MultCommand { get; }
        private void OnMultCommandExecute(object p)
        {
            oper = "*";
            firstValue = Convert.ToDouble(Result);
            Result = "";
        }

        private bool CanMultCommandExecuted(object p)
        {
            if (Result != null)
                return true;
            else
            {
                return false;
            }
        }

        public ICommand DivCommand { get; }
        private void OnDivCommandExecute(object p)
        {
            oper = "/";
            firstValue = Convert.ToDouble(Result);
            Result = "";
        }

        private bool CanDivCommandExecuted(object p)
        {
            if (Result != null)
                return true;
            else
            {
                return false;
            }
        }

        public ICommand SignCommand { get; }
        private void OnSignCommandExecute(object p)
        {
            oper = "+-";
            firstValue = Convert.ToDouble(Result);
            Result = Convert.ToString(firstValue*(-1));
        }

        private bool CanSignCommandExecuted(object p)
        {
            if (Result != null)
                return true;
            else
            {
                return false;
            }
        }

        public ICommand OneDivCommand { get; }
        private void OnOneDivCommandExecute(object p)
        {
            oper = "1/x";
            firstValue = Convert.ToDouble(Result);
            Result = Convert.ToString(1/firstValue);
        }

        private bool CanOneDivCommandExecuted(object p)
        {
            if (Result != null)
                return true;
            else
            {
                return false;
            }
        }

        public ICommand SquarCommand { get; }
        private void OnSquarCommandExecute(object p)
        {
            oper = "x²";
            firstValue = Convert.ToDouble(Result);
            Result = Convert.ToString(firstValue* firstValue);
        }

        private bool CanSquarCommandExecuted(object p)
        {
            if (Result != null)
                return true;
            else
            {
                return false;
            }
        }

        public ICommand SqrtCommand { get; }
        private void OnSqrtCommandExecute(object p)
        {
            oper = "√x";
            firstValue = Convert.ToDouble(Result);
            Result = Convert.ToString(Math.Sqrt(firstValue));
        }

        private bool CanSqrtCommandExecuted(object p)
        {
            if (Result != null)
                return true;
            else
            {
                return false;
            }
        }


        public ICommand EqCommand { get; }
        private void OnEqCommandExecute(object p)
        {
            secondValue = Convert.ToDouble(Result);
            Result = Convert.ToString(Figure.Operation(firstValue,secondValue,oper));
            oper = "";
        }

        private bool CanEqCommandExecuted(object p)
        {
            if (Result != null)
                return true;
            else
            {
                return false;
            }
        }

        public ICommand EqProcCommand { get; }
        private void OnEqProcCommandExecute(object p)
        {
            secondValue = Convert.ToDouble(Result);
            Result = Convert.ToString(Figure.OperationProc(firstValue, secondValue, oper));
            oper = "";
        }

        private bool CanEqProcCommandExecuted(object p)
        {
            if (Result != null)
                return true;
            else
            {
                return false;
            }
        }



        public ICommand StartCommand { get; }
        private void OnStartCommandExecute(object p)
        {
            Result = "";
        }

        private bool CanStartCommandExecuted(object p)
        {
            return true;
        }


        public ICommand OffCommand { get; }
        private void OnOffCommandExecute(object p)
        {
            Result = null;
        }

        private bool CanOffCommandExecuted(object p)
        {
            return true;
        }

        public ICommand BackCommand { get; }
        private void OnBackCommandExecute(object p)
        {
            if (Result.Length > 0)
            {
                int c = Result.Length - 1;
                Result = Result.Remove(c);
            }
        }

        private bool CanBackCommandExecuted(object p)
        {
            return true;
        }



        public ICommand AddZeroFigureCommand { get; }

        private void OnAddZeroFigureExecute(object p)
        {
            Result = Figure.Add(Result, "0");
        }

        private bool CanAddZeroFigureExecuted(object p)
        {
            if (Result != null)
                return true;
            else
            {
                return false;
            }
        }

        public ICommand AddOneFigureCommand { get; }

        private void OnAddOneFigureExecute(object p)
        {
            Result = Figure.Add(Result, "1");
        }

        private bool CanAddOneFigureExecuted(object p)
        {
            if (Result != null)
                return true;
            else
            {
                return false;
            }
        }

        public ICommand AddTwoFigureCommand { get; }

        private void OnAddTwoFigureExecute(object p)
        {
            Result = Figure.Add(Result, "2");
        }

        private bool CanAddTwoFigureExecuted(object p)
        {
            if (Result != null)
                return true;
            else
            {
                return false;
            }
        }

        public ICommand AddThreeFigureCommand { get; }

        private void OnAddThreeFigureExecute(object p)
        {
            Result = Figure.Add(Result, "3");
        }

        private bool CanAddThreeFigureExecuted(object p)
        {
            if (Result != null)
                return true;
            else
            {
                return false;
            }
        }

        public ICommand AddFourFigureCommand { get; }

        private void OnAddFourFigureExecute(object p)
        {
            Result = Figure.Add(Result, "4");
        }

        private bool CanAddFourFigureExecuted(object p)
        {
            if (Result != null)
                return true;
            else
            {
                return false;
            }
        }

        public ICommand AddFiveFigureCommand { get; }

        private void OnAddFiveFigureExecute(object p)
        {
            Result = Figure.Add(Result, "5");
        }

        private bool CanAddFiveFigureExecuted(object p)
        {
            if (Result != null)
                return true;
            else
            {
                return false;
            }
        }

        public ICommand AddSixFigureCommand { get; }

        private void OnAddSixFigureExecute(object p)
        {
            Result = Figure.Add(Result, "6");
        }

        private bool CanAddSixFigureExecuted(object p)
        {
            if (Result != null)
                return true;
            else
            {
                return false;
            }
        }


        public ICommand AddSevenFigureCommand { get; }

        private void OnAddSevenFigureExecute(object p)
        {
            Result =Figure.Add(Result, "7");
        }

        private bool CanAddSevenFigureExecuted(object p)
        {
            if (Result != null)
                return true;
            else
            {
                return false;
            }
        }

        public ICommand AddEightFigureCommand { get; }

        private void OnAddEightFigureExecute(object p)
        {
            Result = Figure.Add(Result, "8");
        }

        private bool CanAddEightFigureExecuted(object p)
        {
            if (Result != null)
                return true;
            else
            {
                return false;
            }
        }

        public ICommand AddNineFigureCommand { get; }

        private void OnAddNineFigureExecute(object p)
        {
            Result = Figure.Add(Result, "9");
        }

        private bool CanAddNineFigureExecuted(object p)
        {
            if (Result != null)
                return true;
            else
            {
                return false;
            }
        }

        public ICommand AddDotFigureCommand { get; }

        private void OnAddDotFigureExecute(object p)
        {
            if (!Result.Contains(","))
                Result = Figure.Add(Result, ",");
        }

        private bool CanAddDotFigureExecuted(object p)
        {
            if (Result != null)
                return true;
            else
            {
                return false;
            }
        }

        public MainWindowViewModel()
        {
            AddZeroFigureCommand = new RelayCommand(OnAddZeroFigureExecute, CanAddZeroFigureExecuted);
            AddOneFigureCommand = new RelayCommand(OnAddOneFigureExecute, CanAddOneFigureExecuted);
            AddTwoFigureCommand = new RelayCommand(OnAddTwoFigureExecute, CanAddTwoFigureExecuted);
            AddThreeFigureCommand = new RelayCommand(OnAddThreeFigureExecute, CanAddThreeFigureExecuted);
            AddFourFigureCommand = new RelayCommand(OnAddFourFigureExecute, CanAddFourFigureExecuted);
            AddFiveFigureCommand = new RelayCommand(OnAddFiveFigureExecute, CanAddFiveFigureExecuted);
            AddSixFigureCommand = new RelayCommand(OnAddSixFigureExecute, CanAddSixFigureExecuted);
            AddSevenFigureCommand = new RelayCommand(OnAddSevenFigureExecute, CanAddSevenFigureExecuted);
            AddEightFigureCommand = new RelayCommand(OnAddEightFigureExecute, CanAddEightFigureExecuted);
            AddNineFigureCommand = new RelayCommand(OnAddNineFigureExecute, CanAddNineFigureExecuted);
            AddDotFigureCommand = new RelayCommand(OnAddDotFigureExecute, CanAddDotFigureExecuted);

            StartCommand= new RelayCommand(OnStartCommandExecute, CanStartCommandExecuted);
            OffCommand = new RelayCommand(OnOffCommandExecute, CanOffCommandExecuted);
            BackCommand = new RelayCommand(OnBackCommandExecute, CanBackCommandExecuted);

            PlusCommand = new RelayCommand(OnPlusCommandExecute, CanPlusCommandExecuted);
            MinusCommand = new RelayCommand(OnMinusCommandExecute, CanMinusCommandExecuted);
            MultCommand = new RelayCommand(OnMultCommandExecute, CanMultCommandExecuted);
            DivCommand = new RelayCommand(OnDivCommandExecute, CanDivCommandExecuted);
            SignCommand = new RelayCommand(OnSignCommandExecute, CanSignCommandExecuted);
            OneDivCommand = new RelayCommand(OnOneDivCommandExecute, CanOneDivCommandExecuted);
            SquarCommand = new RelayCommand(OnSquarCommandExecute, CanSquarCommandExecuted);
            SqrtCommand = new RelayCommand(OnSqrtCommandExecute, CanSqrtCommandExecuted);

            EqCommand = new RelayCommand(OnEqCommandExecute, CanEqCommandExecuted);
            EqProcCommand = new RelayCommand(OnEqProcCommandExecute, CanEqProcCommandExecuted);
        }


    }
}
