using Module.Login.Views;
using QtMvvm.WPF.Module;
using QtMvvm.WPF.Region;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewStorage;

namespace Module.Login
{
    public class ModuleLogin : IModule
    {
        public void Register()
        {
            RegionManager.Register<LoginView>(IDCollection.LoginView);
        }
    }
}
