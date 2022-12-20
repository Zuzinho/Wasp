using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace WaspMaui.ViewModel
{
    public class CalculatorViewModel : INotifyPropertyChanged
    {
        public string DisplayLabelValue
        {
            get
            {
                return _displayLabelValue;
            }
            set
            {
                _displayLabelValue = value;
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private string _displayLabelValue = "";
        private char _action;
        private double? _previousValue;

        private void _numberClicked(string value)
        {
            DisplayLabelValue += value;
            OnPropertyChanged(nameof(DisplayLabelValue));
        }

        private void _actionClicked(string action)
        {
            _action = action[0];
            if (_previousValue != null) return;
            try
            {
                _previousValue = Convert.ToDouble(DisplayLabelValue);
            }
            catch (FormatException)
            {
                throw new FormatException("Incorrect format of number");
            }
            DisplayLabelValue += '\n';
            OnPropertyChanged(nameof(DisplayLabelValue));
        }

        private void _equalsClicked(string exp = null)
        {
            string[] expression = DisplayLabelValue.Split('\n');
            double newValue;
            double result;
            try
            {
                newValue = Convert.ToDouble(expression[1]);
            }
            catch (FormatException)
            {
                throw new FormatException("Incorrect format of number");
            }
            catch (IndexOutOfRangeException)
            {
                throw new IndexOutOfRangeException("Not enough numbers for operation");
            }
            switch (_action)
            {
                case '+':
                    {
                        result = (double)(_previousValue + newValue);
                        break;
                    }
                case '-':
                    {
                        result = (double)(_previousValue - newValue);
                        break;
                    }
                case '*':
                    {
                        result = (double)(_previousValue * newValue);
                        break;
                    }
                case '/':
                    {
                        result = (double)(_previousValue / newValue);
                        break;
                    }
                default:
                    {
                        throw new NotImplementedException("This operation was not implemented");
                    }
            }
            _previousValue = null;
            DisplayLabelValue = result.ToString();
            OnPropertyChanged(nameof(DisplayLabelValue));
        }

        private void _clearClicked(string clear = null)
        {
            DisplayLabelValue = "";
            _previousValue = null;
            OnPropertyChanged(nameof(DisplayLabelValue));
        }


        public ICommand NumberClicked => new Command<string>(_numberClicked);

        public ICommand ActionClicked => new Command<string>(_actionClicked);

        public ICommand EqualsClicked => new Command<string>(_equalsClicked);

        public ICommand ClearClicked => new Command<string>(_clearClicked);

        public void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
