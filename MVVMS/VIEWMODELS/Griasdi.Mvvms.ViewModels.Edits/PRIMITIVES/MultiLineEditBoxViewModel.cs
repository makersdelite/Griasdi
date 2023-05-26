using Griasdi.Mvvms.Views.Edits.PRIMITIVES;
using Griasdi.Mvvms.Views.NativeViews.EditViewControls.PRIMITIVES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Griasdi.Mvvms.ViewModels.Edits.PRIMITIVES
{
    public class MultiLineEditBoxViewModel : EditBoxViewModel
    {
        public MultiLineEditBoxViewModel() 
        {
        }

        public override void Build()
        {
            var view = new MultiLineEditBoxViewControl();
            view.Build();
            this.SetView(view);
        }

        public override void SetValue(string value)
        {
            var view = this.View as MultiLineEditBoxViewControl;
            if(view == null)
            {
                return;
            }
            view.SetValue(value);
            
        }
    }
}
