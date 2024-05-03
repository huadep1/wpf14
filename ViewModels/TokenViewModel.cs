using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using WpfApp14.Models;

namespace WpfApp14.ViewModels
{
    public class TokenViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private Token _token;

        public Token Token
        {
            get { return _token; }
            set
            {
                _token = value;
                OnPropertyChanged(nameof(Token));
            }
        }

        public ICommand StartCommand { get; }
        public ICommand StopCommand { get; }
        public ICommand DeleteCommand { get; }
        public ICommand ViewCommand { get; }

        public TokenViewModel(Token token)
        {
            _token = token;

            // Initialize commands
            StartCommand = new RelayCommand(Start);
            StopCommand = new RelayCommand(Stop);
            DeleteCommand = new RelayCommand(Delete);
            ViewCommand = new RelayCommand(View);
        }

        private void Start(object parameter)
        {
            // Implement Start command logic here
        }

        private void Stop(object parameter)
        {
            // Implement Stop command logic here
        }

        private void Delete(object parameter)
        {
            // Implement Delete command logic here
        }

        private void View(object parameter)
        {
            // Implement View command logic here
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
