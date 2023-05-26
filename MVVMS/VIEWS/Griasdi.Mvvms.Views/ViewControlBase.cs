using Griasdi.Commons;
using Griasdi.Events;
using Griasdi.Mvvms.Views.NativeViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Griasdi.Mvvms.Views
{
    public class ViewControlBase : GriasdiBase
    {
        public NativeViewControlBase NativeViewControl{ get; set; }

        public virtual void SetViewControl(NativeViewControlBase nativeView)
        {
            this.NativeViewControl = nativeView;

            if(this.NativeViewControl == null)
            {
                return;
            }
            this.RegisterEvents();
        }
       
    }
}
