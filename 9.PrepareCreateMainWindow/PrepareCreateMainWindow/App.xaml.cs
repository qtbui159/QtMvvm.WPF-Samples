using Module.Login;
using QtMvvm.WPF.App;
using QtMvvm.WPF.Dialog;
using QtMvvm.WPF.Module;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using ViewStorage;

namespace PrepareCreateMainWindow
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : QtApplication
    {
        protected override Window CreateMainWindow()
        {
            return new MainWindow();
        }

        protected override bool PrepareCreateMainWindow()
        {
            DialogRequest dialogRequest = DialogManager.Build(IDCollection.LoginView, true);
            dialogRequest.Raise();

            return dialogRequest.DialogInformation.Confirm == true;
        }

        protected override void RegisterModule()
        {
            ModuleManager.Add<ModuleLogin>();
        }
    }
}
