using Module.A.Views;
using QtMvvm.WPF.Module;
using QtMvvm.WPF.Region;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.A
{
    public class ModuleA : IModule
    {
        public void Register()
        {
            RegionManager.Register<AView>(nameof(AView));
        }
    }
}
