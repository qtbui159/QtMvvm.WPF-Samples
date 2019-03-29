using QtMvvm.WPF.Command;
using QtMvvm.WPF.Dialog;
using QtMvvm.WPF.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.Dialog.ViewModels
{
   public class DialogViewModel:ViewModelBase,IDialogAware
    {
        private string m_Param;
        public string Param
        {
            get
            {
                return m_Param;
            }
            set
            {
                SetProperty(ref m_Param, value);
            }
        }


        public RelayCommand LoadedCommand { get; private set; }

        public RelayCommand<string> ConfirmCommand { get; private set; }

        public DialogViewModel()
        {
            LoadedCommand = new RelayCommand(Loaded);
            ConfirmCommand = new RelayCommand<string>(Confirm);
        }

        private void Confirm(string obj)
        {
            if (obj != null)
            {
                DialogInfomation.Confirm = obj == "Yes" ? true : false;
                DialogFinish?.Invoke();
            }
        }

        private void Loaded()
        {
            Param = (DialogInfomation as CustomDialogInfo).Parameter;
        }

        public Action DialogFinish { get; set; }
        public DialogInformation DialogInfomation { get; set; }
    }
}
