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
    public class ViewControlViewModelBase:ViewModelBase
    {
        public override void RegisterEvents()
        {
            if (this.View == null)
            {
                return;
            }
            var view = this.View as ViewControlBase;
            if (view == null)
            {
                return;
            }
            view.ViewControlClicked += View_ViewControlClicked;
        }




        public override void SetEnabled()
        {
            var view = this.View as ViewControlBase;
            if (view == null)
            {
                return;
            }
            view.SetEnabled();
        }
        public override void SetDisabled()
        {
            var view = this.View as ViewControlBase;
            if (view == null)
            {
                return;
            }
            view.SetDisabled();
        }
        public override void SetLocked()
        {

        }
        public override void SetUnlocked()
        {

        }


        public virtual void SetBorderVisible()
        {

        }
        public virtual void SetBorderHidden()
        {

        }




        public override void SetLeft(int value)
        {
            var view = this.View as ViewControlBase;
            if (view == null)
            {
                return;
            }
            view.SetLeft(value);
        }
        public override void SetTop(int value)
        {
            var view = this.View as ViewControlBase;
            if (view == null)
            {
                return;
            }
            view.SetTop(value);
        }
        public override void SetWidth(int value)
        {
            var view = this.View as ViewControlBase;
            if (view == null)
            {
                return;
            }
            view.SetWidth(value);
        }
        public override void SetHeight(int value)
        {
            var view = this.View as ViewControlBase;
            if (view == null)
            {
                return;
            }
            view.SetHeight(value);
        }


        public override int GetLeft()
        {
            int retVal = 0;
            var view = this.View as ViewControlBase;
            if (view == null)
            {
                return retVal;
            }
            retVal = view.GetLeft();
            return retVal;
        }
        public override int GetTop()
        {
            int retVal = 0;
            var view = this.View as ViewControlBase;
            if (view == null)
            {
                return retVal;
            }
            retVal = view.GetTop();
            return retVal;
        }
        public override int GetWidth()
        {
            int retVal = 0;
            var view = this.View as ViewControlBase;
            if (view == null)
            {
                return retVal;
            }
            retVal = view.GetWidth();
            return retVal;
        }
        public override int GetHeight()
        {
            int retVal = 0;
            var view = this.View as ViewControlBase;
            if (view == null)
            {
                return retVal;
            }
            retVal = view.GetHeight();
            return retVal;
        }


        



        #region event handler
        private void View_ViewControlClicked(object sender, Events.GriasdiEventArgs e)
        {
            this.RaiseViewModelClickEvent(e);
        }
        #endregion
    }
}
