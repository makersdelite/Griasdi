using Griasdi.Mvvms.Views.Buttons.PRIMITIVES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Griasdi.Mvvms.ViewModels.Buttons.PRIMITIVES
{
    public class StandardButtonViewModel : ButtonViewModel
    {
        public StandardButtonViewModel() 
        {
        }

        public override void Build()
        {
            var view = new StandardButtonViewControl();
            view.Build();
            this.SetView(view);
            this.RegisterEvents();
        }

        public override void SetValue(string value)
        {
            base.SetValue(value);
            var view = this.View as StandardButtonViewControl;
            if(view == null)
            {
                return;
            }
            view.SetValue(value);
            
        }
    }
}
