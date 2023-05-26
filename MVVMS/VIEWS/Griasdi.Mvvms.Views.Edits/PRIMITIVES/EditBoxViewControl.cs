using Griasdi.Events;
using Griasdi.Mvvms.Views.NativeViews;
using Griasdi.Mvvms.Views.NativeViews.EditViewControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Griasdi.Mvvms.Views.Edits.PRIMITIVES
{
    public class EditBoxViewControl:EditViewControl
    {
        public EditBoxViewControl() 
        {
        }

        public override void RegisterEvents()
        {
            var nativeView = this.NativeViewControl as EditBoxNativeViewControl;
            if(nativeView == null)
            {
                return;
            }
            nativeView.ValueChanged += this.NativeView_ValueChanged;
        }

        private void NativeView_ValueChanged(object sender, GriasdiEventArgs e)
        {
            this.RaiseValueChangeEvent(e);   
        }

        public virtual void SetValue(string value)
        {
            var nativeView = this.NativeViewControl as EditBoxNativeViewControl;
            if (nativeView == null)
            {
                return;
            }
            nativeView.SetValue(value);
        }
    }
}
