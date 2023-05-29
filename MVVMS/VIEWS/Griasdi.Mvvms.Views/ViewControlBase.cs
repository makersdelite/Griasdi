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


        public Control NativeViewControl{ get; set; }

        public virtual void SetViewControl(NativeViewControlBase nativeView)
        {
            this.NativeViewControl = nativeView;

            if(this.NativeViewControl == null)
            {
                return;
            }
            this.RegisterEvents();
        }

        public virtual void SetViewControl(Control nativeView)
        {
            this.NativeViewControl = nativeView;

            if (this.NativeViewControl == null)
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

            if(this.NativeViewControl is NativeViewControlBase)
            {
                var ctl = this.NativeViewControl as NativeViewControlBase;
                ctl.NativeViewControlClicked += NativeViewControl_NativeViewControlClicked;
            }
        }

        #region event handler
        private void NativeViewControl_NativeViewControlClicked(object sender, GriasdiEventArgs e)
        {
            this.RaiseViewControlClickEvent(e);
        }
        #endregion



        public virtual void SetHeight(int value)
        {
            var uc = this.NativeViewControl as NativeViewControlBase;
            if(uc != null)
            {
                uc.SetHeight(value);
                return;
            }
            this.NativeViewControl.Height= value;
        }
        public virtual void SetWidth(int value)
        {
            var uc = this.NativeViewControl as NativeViewControlBase;
            if (uc != null)
            {
                uc.SetWidth(value);
                return;
            }
            this.NativeViewControl.Width = value;
        }
        public virtual void SetTop(int value)
        {
            var uc = this.NativeViewControl as NativeViewControlBase;
            if (uc != null)
            {
                uc.SetTop(value);
                return;
            }
            this.NativeViewControl.Top = value;
        }
        public virtual void SetLeft(int value)
        {
            var uc = this.NativeViewControl as NativeViewControlBase;
            if (uc != null)
            {
                uc.SetLeft(value);
                return;
            }
            this.NativeViewControl.Left = value;
        }


        public virtual int GetLeft()
        {
            int retVal = 0;
            var uc = this.NativeViewControl as NativeViewControlBase;
            if (uc != null)
            {
                retVal = uc.Left;
                return retVal;
            }
            retVal = this.NativeViewControl.Left;
            return retVal;
        }

        public virtual int GetTop()
        {
            int retVal = 0;
            var uc = this.NativeViewControl as NativeViewControlBase;
            if (uc != null)
            {
                retVal = uc.Left;
                return retVal;
            }
            retVal = this.NativeViewControl.Top;
            return retVal;
        }

        public virtual int GetWidth()
        {
            int retVal = 0;
            var uc = this.NativeViewControl as NativeViewControlBase;
            if (uc != null)
            {
                retVal = uc.Width;
                return retVal;
            }
            retVal = this.NativeViewControl.Width;
            return retVal;
        }

        public virtual int GetHeight()
        {
            int retVal = 0;
            var uc = this.NativeViewControl as NativeViewControlBase;
            if (uc != null)
            {
                retVal = uc.Height;
                return retVal;
            }
            retVal = this.NativeViewControl.Height;
            return retVal;
        }


    }
}
