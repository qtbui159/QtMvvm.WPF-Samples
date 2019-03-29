using QtMvvm.WPF.Command;
using QtMvvm.WPF.Dialog;
using QtMvvm.WPF.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.Login.ViewModels
{
    class LoginViewModel : ViewModelBase, IDialogAware
    {
        public const string CORRECT_KEY = "123456";

        public string Key { get; set; }
        public RelayCommand LoginCommand { private set; get; }

        public Action DialogFinish { get; set; }
        public DialogInformation DialogInfomation { get; set; }

        public LoginViewModel()
        {
            LoginCommand = new RelayCommand(LoginCommandProc);
        }

        private void LoginCommandProc()
        {
            if (CORRECT_KEY != Key)
            {
                return;
            }

            DialogInfomation.Confirm = true;
            DialogFinish.Invoke();
        }
    }
}
