using Module.Dialog.Views;
using QtMvvm.WPF.Module;
using QtMvvm.WPF.Region;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.Dialog
{
    public class ModuleDialog : IModule
    {
        public void Register()
        {
            RegionManager.Register<DialogView>(nameof(DialogView));
        }
    }
}
