using Griasdi.Commons;
using Griasdi.Events;
using Griasdi.Mvvms.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Griasdi.Mvvms.ViewModels
{
    public class ViewModelBase:GriasdiBase
    {
         public object View { get; set; }

        public virtual void SetView(object view)
        {
            this.View = view;

            if(this.View == null)
            {
                return;
            }
        }
        public virtual void Show()
        {
           
        }
    }
}
