using QtMvvm.WPF.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace ViewModelAutoWired
{
    class MainWindowViewModel : ViewModelBase
    {
        public string Number
        {
            private set => SetProperty(ref m_Number, value);
            get => m_Number;
        }
        private string m_Number = "";

        private DispatcherTimer m_NumberTimer = null;

        public MainWindowViewModel()
        {
            m_NumberTimer = new DispatcherTimer()
            {
                Interval = TimeSpan.FromMilliseconds(500),
            };
            m_NumberTimer.Tick += M_NumberTimer_Tick;

            m_NumberTimer.Start();
        }

        private void M_NumberTimer_Tick(object sender, EventArgs e)
        {
            Number = new Random().Next(1, 1000).ToString();
        }
    }
}
