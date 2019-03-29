using QtMvvm.WPF.Command;
using QtMvvm.WPF.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class MainWindowViewModel : ViewModelBase
    {
        public RelayCommand ValueChangeCommand { private set; get; }

        public string Value
        {
            private set => SetProperty(ref m_Value, value);
            get => m_Value;
        }
        private string m_Value = "";

        public MainWindowViewModel()
        {
            ValueChangeCommand = new RelayCommand(ValueChangeCommandProc);
        }

        private void ValueChangeCommandProc()
        {
            Value = new Random().Next(1, 1000).ToString();
        }
    }
}
