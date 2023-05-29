using Griasdi.Events;
using Griasdi.Mvvms.Views.NativeViews;
using Griasdi.Mvvms.Views.NativeViews.PanelViewControls;
using Griasdi.Mvvms.Views.NativeViews.PanelViewControls.COMPOSITES;
using Griasdi.Mvvms.Views.NativeViews.PanelViewControls.PRIMITIVES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Griasdi.Mvvms.Views.Panels.COMPOSITES
{
    public class ThreePanelViewControl : PanelViewControl
    {
        public PanelViewControl Panel0 { get; set; }
        public PanelViewControl Panel1 { get; set; }
        public PanelViewControl Panel2 { get; set; }

        public ThreePanelViewControl() 
        {
        }

        public override void Build()
        {
            var nativeViewControl = new ThreePanelNativeViewControl();
            nativeViewControl.Build();
            this.SetViewControl(nativeViewControl);

            this.Panel0 = new PanelViewControl();
            this.Panel1 = new PanelViewControl();
            this.Panel2 = new PanelViewControl();
        }

        public PanelViewControl GetPanel0()
        {
            return this.Panel0;
        }
        public PanelViewControl GetPanel1()
        {
            return this.Panel1;
        }
        public PanelViewControl GetPanel2()
        {
            return this.Panel2;
        }

        public virtual void SetPanel0(ViewControlBase childView)
        {
            
            var nativeView = this.NativeViewControl as ThreePanelNativeViewControl;
            if (nativeView == null)
            {
                return;
            }
            
        }
        public virtual void SetPanel1(ViewControlBase childView)
        {

            var nativeView = this.NativeViewControl as ThreePanelNativeViewControl;
            if (nativeView == null)
            {
                return;
            }

        }
        public virtual void SetPanel2(ViewControlBase childView)
        {

            var nativeView = this.NativeViewControl as ThreePanelNativeViewControl;
            if (nativeView == null)
            {
                return;
            }

        }
    }
}
