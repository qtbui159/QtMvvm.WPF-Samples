using QtMvvm.WPF.Command;
using QtMvvm.WPF.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QtMvvm.WPF.Dialog;
using Module.Dialog.Views;
using Module.Dialog;
using QtMvvm.WPF.Event;

namespace Dialog
{
    public class MainWindowViewModel:ViewModelBase
    {
        public RelayCommand ShowDialogCommand { get; private set; }

        private string m_DialogResult;

        public string DialogResult
        {
            get
            {
                return m_DialogResult;
            }
            set
            {
                SetProperty(ref m_DialogResult, value);
            }
        }

        public MainWindowViewModel()
        {
            ShowDialogCommand = new RelayCommand(ShowDialog);
        }

        private void ShowDialog()
        {
           var dialogRequest= DialogManager.Build(nameof(DialogView), false,new CustomDialogInfo() {Confirm=true,Parameter="Dialog Parameter" }).SetWidthAndHeight(300,300).SetWindowStartupLocation(System.Windows.WindowStartupLocation.CenterScreen);
            dialogRequest.SetClosedAction(info => 
            {
                if (info.Confirm == true)
                {
                    DialogResult = "Confirm is True";
                }
                else
                {
                    DialogResult = "Confirm is False";
                }
            });
           
            dialogRequest.Raise();
            EventManager.GetEvent<DialogEvent>().Publish(new DialogEventArgs() { Param = "Event Param" });

        }
    }
}
