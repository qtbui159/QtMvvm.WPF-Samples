using Module.A.Views;
using QtMvvm.WPF.Command;
using QtMvvm.WPF.Module;
using QtMvvm.WPF.Region;
using QtMvvm.WPF.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleAndRegion
{
   public class MainWindowViewModel:ViewModelBase
    {
        public RelayCommand<string> NavigateCommand { get; private set; }

        public MainWindowViewModel()
        {
            NavigateCommand = new RelayCommand<string>(Navigate);
        }

        private void Navigate(string obj)
        {
            if (obj != null)
            {
                RegionManager.Navigate("myRegion", nameof(AView));
            }
        }
    }
}
