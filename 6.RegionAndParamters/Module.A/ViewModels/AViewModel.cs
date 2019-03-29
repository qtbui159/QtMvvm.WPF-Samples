using QtMvvm.WPF.Region;
using QtMvvm.WPF.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.A.ViewModels
{
   public class AViewModel:ViewModelBase,INavigationAware<string>
    {
        private string m_Title;
        public string Title
        {
            get
            {
                return m_Title;
            }
            set
            {
                SetProperty(ref m_Title, value);
            }
        }

        public AViewModel()
        {
            Title = "ViewA";
        }

        public void GetNavigationParameter(string parameter)
        {
           Title=parameter;
        }

        public bool SaveViewModel()
        {
            return true;
        }
    }
}
