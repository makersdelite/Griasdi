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
        public virtual string GetValue()
        {
            string retVal = null;
            var nativeView = this.NativeViewControl as EditBoxNativeViewControl;
            if (nativeView == null)
            {
                return retVal;
            }
            retVal = nativeView.GetValue();
            return retVal;
        }

        public override void SetEnabled()
        {
            var nativeView = this.NativeViewControl as EditBoxNativeViewControl;
            if (nativeView == null)
            {
                return;
            }
            nativeView.SetEnabled();
        }
        public override void SetDisabled()
        {
            var nativeView = this.NativeViewControl as EditBoxNativeViewControl;
            if (nativeView == null)
            {
                return;
            }
            nativeView.SetDisabled();
        }
        public override void SetLocked()
        {
            var nativeView = this.NativeViewControl as EditBoxNativeViewControl;
            if (nativeView == null)
            {
                return;
            }
            nativeView.SetLocked();
        }
        public override void SetUnlocked()
        {
            var nativeView = this.NativeViewControl as EditBoxNativeViewControl;
            if (nativeView == null)
            {
                return;
            }
            nativeView.SetUnlocked();
        }

        public override void SetBorderVisible()
        {
            var nativeView = this.NativeViewControl as EditBoxNativeViewControl;
            if (nativeView == null)
            {
                return;
            }
            nativeView.SetBorderVisible();
        }

        public override void SetBorderHidden()
        {
            var nativeView = this.NativeViewControl as EditBoxNativeViewControl;
            if (nativeView == null)
            {
                return;
            }
            nativeView.SetBorderHidden();
        }

    }
}
