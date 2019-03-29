using QtMvvm.WPF.Command;
using QtMvvm.WPF.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EventToCommand
{
    class MainWindowViewModel:ViewModelBase
    {
        public string Position
        {
            private set => SetProperty(ref m_Position, value);
            get => m_Position;
        }
        private string m_Position = "";

        public RelayCommand<MouseEventArgs> MouseMoveCommand { private set; get; }

        public MainWindowViewModel()
        {
            MouseMoveCommand = new RelayCommand<MouseEventArgs>(MouseMoveCommandProc);
        }

        private void MouseMoveCommandProc(MouseEventArgs e)
        {
            var position = e.MouseDevice.GetPosition(e.Device.Target);
            Position = $"X:{position.X}  Y:{position.Y}";
        }
    }
}
