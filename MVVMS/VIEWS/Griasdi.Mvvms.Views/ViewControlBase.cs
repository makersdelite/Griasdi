using Griasdi.Commons;
using Griasdi.Events;
using Griasdi.Mvvms.Views.NativeViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Griasdi.Mvvms.Views
{
    public class ViewControlBase : GriasdiBase
    {

        #region event section
        #region click
        public event EventHandler<GriasdiEventArgs> ViewControlClicked;
        public void OnViewControlClicked(GriasdiEventArgs e)
        {
            EventHandler<GriasdiEventArgs> handler = ViewControlClicked;
            if (handler != null)
            {
                handler(this, e);
            }
        }
        public void RaiseViewControlClickEvent(EventArgs e)
        {
            var ea = new GriasdiViewEventArgs();
            ea.Add("CLICKED-EVENT-ARGS", e);
            this.OnViewControlClicked(ea);
        }
        #endregion
        #endregion


        public NativeViewControlBase NativeViewControl{ get; set; }

        public virtual void SetViewControl(NativeViewControlBase nativeView)
        {
            this.NativeViewControl = nativeView;

            if(this.NativeViewControl == null)
            {
                return;
            }
            this.RegisterEvents();
        }

        public override void RegisterEvents()
        {
            if(this.NativeViewControl == null)
            {
                return;
            }
            this.NativeViewControl.NativeViewControlClicked += NativeViewControl_NativeViewControlClicked;
        }

        #region event handler
        private void NativeViewControl_NativeViewControlClicked(object sender, GriasdiEventArgs e)
        {
            this.RaiseViewControlClickEvent(e);
        }
        #endregion
    }
}
