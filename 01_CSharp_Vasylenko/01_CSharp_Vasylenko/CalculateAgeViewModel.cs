using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace _01_CSharp_Vasylenko
{
    class CalculateAgeViewModel : INotifyPropertyChanged
    {
        private DateTime _date;
        private string _age;
        private string _wSign;
        private string _cSign;
        private bool _canExecute;

        private RelayCommand _calculateAgeCommand;

        private readonly Action<bool> _showLoaderAction;

        private readonly Action _closeAction;

        public bool CanExecute
        {
            get { return _canExecute; }
            private set
            {
                _canExecute = value;
                OnPropertyChanged();
            }
        }

        public CalculateAgeViewModel(Action close, Action<bool> showLoader)
        {
            _closeAction = close;
            _showLoaderAction = showLoader;
            CanExecute = true;
        }

        public DateTime Date
        {
            get { return _date; }

            set
            {
                _date = value;
                OnPropertyChanged();
            }
        }

        public string Age
        {
            get { return _age; }

            set
            {
                _age = value;
                OnPropertyChanged();
            }
        }
        public string WesternSign
        {
            get { return _wSign; }

            set
            {
                _wSign = value;
                OnPropertyChanged();
            }
        }
        public string ChineseSign
        {
            get { return _cSign; }

            set
            {
                _cSign = value;
                OnPropertyChanged();
            }
        }

        public RelayCommand CalculateAgeCommand
        {
            get
            {
                return _calculateAgeCommand ?? (_calculateAgeCommand = new RelayCommand(CalcAgeImpl));
            }
        }

        private async void CalcAgeImpl(object o)
        {
            _showLoaderAction.Invoke(true);
            Preparation();
            await Task.Run((() =>
            {
                StationManager.CurrentUser = CalcAgeAdapter.CreateUser(_date);
                Thread.Sleep(3000);
            }));

            if (StationManager.CurrentUser == null)
                MessageBox.Show($"Entered date - {_date} is invalid.");
            else
            {
                if (_date.DayOfYear == DateTime.Today.DayOfYear)
                    MessageBox.Show($"Happy Birthday to You!");
                Age = "" + StationManager.CurrentUser.Age;
                WesternSign = "" + StationManager.CurrentUser.WesternSign;
                ChineseSign = "" + StationManager.CurrentUser.ChineseSign;
                _closeAction.Invoke();
            }
            CanExecute = true;
            _showLoaderAction.Invoke(false);
        }

        private void Preparation()
        {
            CanExecute = false;
            Age = "";
            WesternSign = "";
            ChineseSign = "";
        }

        #region Implementation

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
