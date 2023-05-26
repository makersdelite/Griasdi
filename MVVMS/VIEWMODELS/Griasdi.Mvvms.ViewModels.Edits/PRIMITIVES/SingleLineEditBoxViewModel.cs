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
    }
}
