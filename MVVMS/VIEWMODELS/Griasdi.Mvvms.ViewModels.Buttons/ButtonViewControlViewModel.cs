using Griasdi.Mvvms.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Griasdi.Mvvms.ViewModels.Buttons
{
    public class ButtonViewControlViewModel : ViewControlViewModelBase
    {
        public ButtonViewControlViewModel() 
        {
        }
        public virtual void SetValue(string value)
        {
            this.Caption = value;
        }

    }
}
