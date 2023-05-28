using Griasdi.Mvvms.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Griasdi.Mvvms.ViewModels.Panels
{
    public class PanelViewControlViewModel : ViewControlViewModelBase
    {
        public PanelViewControlViewModel() 
        {
        }
        public virtual void SetValue(string value)
        {
            this.Caption = value;
        }

    }
}
