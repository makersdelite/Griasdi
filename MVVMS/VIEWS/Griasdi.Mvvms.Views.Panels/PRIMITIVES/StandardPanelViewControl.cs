using Griasdi.Events;
using Griasdi.Mvvms.Views.NativeViews;
using Griasdi.Mvvms.Views.NativeViews.PanelViewControls;
using Griasdi.Mvvms.Views.NativeViews.PanelViewControls.PRIMITIVES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Griasdi.Mvvms.Views.Panels.PRIMITIVES
{
    public class StandardPanelViewControl:PanelViewControl
    {
        public StandardPanelViewControl() 
        {
        }

        public override void Build()
        {
            var nativeViewControl = new PanelNativeViewControl();
            nativeViewControl.Build();
            this.SetViewControl(nativeViewControl);
        }
        public virtual void SetValue(string value)
        {
            
            var nativeView = this.NativeViewControl as PanelNativeViewControl;
            if (nativeView == null)
            {
                return;
            }
            nativeView.SetValue(value);
        }

        public override void SetWidth(int value)
        {

            var nativeView = this.NativeViewControl as PanelNativeViewControl;
            if (nativeView == null)
            {
                return;
            }
            nativeView.SetWidth(value);
        }

    }
}
