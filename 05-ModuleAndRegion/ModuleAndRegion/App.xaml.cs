using Module.A;
using QtMvvm.WPF.App;
using QtMvvm.WPF.Module;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace ModuleAndRegion
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

        protected override void RegisterModule()
        {
            ModuleManager.Add<ModuleA>();
        }

        protected override bool PrepareCreateMainWindow()
        {
            return true;
        }

    }
}
