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
            this.Panel0.Build();
            this.Panel0.View = view.GetPanel0();
            this.Add("PANEL-0", this.Panel0);

            this.Panel1 = new PanelViewModel();
            this.Panel1.Build();
            this.Panel1.View = view.GetPanel1();
            this.Add("PANEL-1", this.Panel1);
            
            this.Panel2 = new PanelViewModel();
            this.Panel2.Build();
            this.Panel2.View = view.GetPanel2();
            this.Add("PANEL-2", this.Panel2);

            this.RegisterEvents();
        }

        public virtual void SetPanel0Left(int value)
        {
            this.Panel0.SetLeft(value);
        }
        public virtual void SetPanel0Width(int value)
        {
            this.Panel0.SetWidth(value);
        }


        public virtual void SetPanel0(ViewModelBase childVm)
        {
            this.Panel0.Add(childVm);
        }


        public virtual void SetPanel1Left(int value)
        {
            this.Panel1.SetLeft(value);
        }
        public virtual void SetPanel1Width(int value)
        {
            this.Panel1.SetWidth(value);
        }
        public virtual void SetPanel1(ViewModelBase childVm)
        {
            this.Panel1.Add(childVm);
        }


        public virtual void SetPanel2Left(int value)
        {
            this.Panel2.SetLeft(value);
        }
        public virtual void SetPanel2Width(int value)
        {
            this.Panel2.SetWidth(value);
        }
        public virtual void SetPanel2(ViewModelBase childVm)
        {
            this.Panel2.Add(childVm);
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
