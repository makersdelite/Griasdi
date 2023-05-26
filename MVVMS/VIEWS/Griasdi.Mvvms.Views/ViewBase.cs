using Griasdi.Commons;
using Griasdi.Events;
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



        public Form View { get; set; }

        public virtual void SetView(Form view)
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
            this.View.FormClosed += View_FormClosed;
            this.View.FormClosing += View_FormClosing;
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
            if (this.View == null)
            {
                return;
            }
            #endregion
            this.View.Show();
        }
        public virtual void Close()
        {
            #region method exit strategy
            if (this.View == null)
            {
                return;
            }
            #endregion
            this.View.Close();
        }
    }
}
