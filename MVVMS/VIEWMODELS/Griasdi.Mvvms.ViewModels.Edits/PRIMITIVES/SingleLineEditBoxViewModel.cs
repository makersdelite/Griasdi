using Griasdi.Mvvms.Views.Edits.PRIMITIVES;
using Griasdi.Mvvms.Views.NativeViews.EditViewControls.PRIMITIVES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Griasdi.Mvvms.ViewModels.Edits.PRIMITIVES
{
    public class SingleLineEditBoxViewModel:EditBoxViewModel
    {
        public SingleLineEditBoxViewModel() 
        {
        }

        public override void Build()
        {
            var view = new SingleLineEditBoxViewControl();
            view.Build();
            this.SetView(view);
        }

        public override void SetValue(string value)
        {
            var view = this.View as SingleLineEditBoxViewControl;
            if(view == null)
            {
                return;
            }
            view.SetValue(value);
        }

        public override string GetValue()
        {
            string retVal = null;
            var view = this.View as SingleLineEditBoxViewControl;
            if (view == null)
            {
                return retVal;
            }
            retVal = view.GetValue();
            return retVal;
        }

        public override void SetLocked()
        {
            var view = this.View as SingleLineEditBoxViewControl;
            if (view == null)
            {
                return;
            }
            view.SetLocked();
        }
        public override void SetUnlocked()
        {
            var view = this.View as SingleLineEditBoxViewControl;
            if (view == null)
            {
                return;
            }
            view.SetUnlocked();
        }
        public override void SetEnabled()
        {
            var view = this.View as SingleLineEditBoxViewControl;
            if (view == null)
            {
                return;
            }
            view.SetEnabled();
        }
        public override void SetDisabled()
        {
            var view = this.View as SingleLineEditBoxViewControl;
            if (view == null)
            {
                return;
            }
            view.SetDisabled();
        }

        public override void SetBorderVisible()
        {
            var view = this.View as SingleLineEditBoxViewControl;
            if (view == null)
            {
                return;
            }
            view.SetBorderVisible();
        }
        public override void SetBorderHidden()
        {
            var view = this.View as SingleLineEditBoxViewControl;
            if (view == null)
            {
                return;
            }
            view.SetBorderHidden();
        }
    }
}
