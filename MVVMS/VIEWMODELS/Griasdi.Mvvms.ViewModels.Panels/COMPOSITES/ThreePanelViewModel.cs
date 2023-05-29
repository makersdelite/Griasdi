using Griasdi.Mvvms.ViewModels.Panels.PRIMITIVES;
using Griasdi.Mvvms.Views.Panels.COMPOSITES;
using Griasdi.Mvvms.Views.Panels.PRIMITIVES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Griasdi.Mvvms.ViewModels.Panels.COMPOSITES
{
    public class ThreePanelViewModel : PanelViewModel
    {
        #region properties
        public PanelViewModel Panel0 { get; set; }
        public PanelViewModel Panel1 { get; set; }
        public PanelViewModel Panel2 { get; set; }
        #endregion

        public ThreePanelViewModel() 
        {
        }

        public override void Build()
        {
           
            var view = new ThreePanelViewControl();
            view.Build();
            this.SetView(view);

            this.Panel0 = new PanelViewModel();
            this.Panel0.View = view.GetPanel0();
            this.Add("PANEL-0", this.Panel0);

            this.Panel1 = new PanelViewModel();
            this.Panel1.View = view.GetPanel1();
            this.Add("PANEL-1", this.Panel1);
            
            this.Panel2 = new PanelViewModel();
            this.Panel2.View = view.GetPanel2();
            this.Add("PANEL-2", this.Panel2);

            this.RegisterEvents();
        }

        //public override void SetValue(string value)
        //{
        //    base.SetValue(value);
        //    var view = this.View as ThreePanelViewControl;
        //    if(view == null)
        //    {
        //        return;
        //    }
            
        //}

    }
}
