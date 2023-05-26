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
    public class ViewBase:GriasdiBase
    {

        #region event section
        #region close
        public event EventHandler<GriasdiEventArgs> Closed;
        public void OnClosed(GriasdiEventArgs e)
        {
            EventHandler<GriasdiEventArgs> handler = Closed;
            if (handler != null)
            {
                handler(this, e);
            }
        }
        public void RaiseCloseEvent(EventArgs e)
        {
            var ea = new GriasdiViewEventArgs();
            ea.Add("CLOSED-EVENT-ARGS", e);
            this.OnClosed(ea);
        }
        #endregion

        #region closing
        public event EventHandler<GriasdiEventArgs> Closing;
        public void OnClosing(GriasdiEventArgs e)
        {
            EventHandler<GriasdiEventArgs> handler = Closing;
            if (handler != null)
            {
                handler(this, e);
            }
        }
        public void RaiseClosingEvent(EventArgs e)
        {
            var ea = new GriasdiViewEventArgs();
            ea.Add("CLOSING-EVENT-ARGS",e);
            this.OnClosing(ea);
        }
        #endregion

        #endregion



        public NativeViewBase NativeView{ get; set; }

        public virtual void SetView(NativeViewBase nativeView)
        {
            this.NativeView = nativeView;

            if(this.NativeView == null)
            {
                return;
            }
            this.RegisterEvents();
        }

        public override void RegisterEvents()
        {
            this.NativeView.FormClosed += View_FormClosed;
            this.NativeView.FormClosing += View_FormClosing;
        }

        private void View_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.RaiseClosingEvent(e);
        }

        private void View_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.RaiseCloseEvent(e);
        }

        public virtual void Show()
        {
            #region method exit strategy
            if (this.NativeView == null)
            {
                return;
            }
            #endregion
            this.NativeView.Show();
        }
        public virtual void Close()
        {
            #region method exit strategy
            if (this.NativeView == null)
            {
                return;
            }
            #endregion
            this.NativeView.Close();
        }
    }
}
