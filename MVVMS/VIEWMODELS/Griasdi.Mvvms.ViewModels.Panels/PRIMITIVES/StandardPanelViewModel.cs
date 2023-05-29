using Griasdi.Mvvms.Views.Panels.PRIMITIVES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Griasdi.Mvvms.ViewModels.Panels.PRIMITIVES
{
    public class StandardPanelViewModel : PanelViewModel
    {
        public StandardPanelViewModel() 
        {
        }

        public override void Build()
        {
            var view = new StandardPanelViewControl();
            view.Build();
            this.SetView(view);
            this.RegisterEvents();
        }

        public override void SetValue(string value)
        {
            base.SetValue(value);
            var view = this.View as StandardPanelViewControl;
            if(view == null)
            {
                return;
            }
            view.SetValue(value);
            
        }

        public override void SetWidth(int value)
        {
            base.SetWidth(value);
            var view = this.View as StandardPanelViewControl;
            if (view == null)
            {
                return;
            }
            view.SetWidth(value);
        }
    }
}
