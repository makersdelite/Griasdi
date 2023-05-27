using Griasdi.Events;
using Griasdi.Mvvms.Views.NativeViews;
using Griasdi.Mvvms.Views.NativeViews.ButtonViewControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Griasdi.Mvvms.Views.Buttons.PRIMITIVES
{
    public class StandardButtonViewControl:ButtonViewControl
    {
        public StandardButtonViewControl() 
        {
        }

        public override void Build()
        {
            var nativeViewControl = new ButtonNativeViewControl();
            nativeViewControl.Build();
            this.SetViewControl(nativeViewControl);
        }
        public virtual void SetValue(string value)
        {
            
            var nativeView = this.NativeViewControl as ButtonNativeViewControl;
            if (nativeView == null)
            {
                return;
            }
            nativeView.SetValue(value);
        }
    }
}
