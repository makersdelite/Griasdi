using Griasdi.Commons;
using Griasdi.Events;
using Griasdi.Mvvms.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Griasdi.Mvvms.ViewModels
{
    public class ViewModelBase:GriasdiBase
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


        public ViewBase View { get; set; }

        public virtual void SetView(ViewBase view)
        {
            this.View = view;

            if(this.View == null)
            {
                return;
            }

            this.RegisterEvents();
        }

        public override void RegisterEvents() 
        {
            this.View.Closed += View_Closed;
            this.View.Closing += View_Closing;
        }

        private void View_Closing(object sender, GriasdiEventArgs e)
        {
            this.RaiseClosingEvent(e);
        }

        private void View_Closed(object sender, GriasdiEventArgs e)
        {
            this.RaiseCloseEvent(e);
        }

        public virtual void Show()
        {
            if(this.View == null)
            {
                return;
            }
            this.View.Show();
        }
    }
}
