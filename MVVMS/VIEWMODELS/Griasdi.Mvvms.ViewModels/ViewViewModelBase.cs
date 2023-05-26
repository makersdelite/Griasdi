using Griasdi.Commons;
using Griasdi.Events;
using Griasdi.Mvvms.Views;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Griasdi.Mvvms.ViewModels
{
    public class ViewViewModelBase:ViewModelBase
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
            var ea = new GriasdiViewModelEventArgs();
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
            var ea = new GriasdiViewModelEventArgs();
            ea.Add("CLOSED-EVENT-ARGS", e);
            this.OnClosing(ea);
        }
        #endregion


        #endregion

        public ViewViewModelBase()
        {
        }
        
        public override void RegisterEvents() 
        {
            var view = this.View as ViewBase;
            if(view == null)
            {
                return;
            }
            view.Closed += View_Closed;
            view.Closing += View_Closing;
        }

        private void View_Closing(object sender, GriasdiEventArgs e)
        {
            this.RaiseClosingEvent(e);
        }

        private void View_Closed(object sender, GriasdiEventArgs e)
        {
            this.RaiseCloseEvent(e);
        }

        public override void Show()
        {
            var view = this.View as ViewBase;
            if (view == null)
            {
                return;
            }
            view.Show();
        }
    }
}
