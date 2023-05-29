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
        #region click
        public event EventHandler<GriasdiEventArgs> ViewModelClicked;
        public void OnViewModelClicked(GriasdiEventArgs e)
        {
            EventHandler<GriasdiEventArgs> handler = ViewModelClicked;
            if (handler != null)
            {
                handler(this, e);
            }
        }
        public void RaiseViewModelClickEvent(EventArgs e)
        {
            var ea = new GriasdiViewEventArgs();
            ea.Add("CLICKED-EVENT-ARGS", e);
            this.OnViewModelClicked(ea);
        }
        #endregion
        #endregion



        public object View { get; set; }

        public virtual void SetView(object view)
        {
            this.View = view;

            if(this.View == null)
            {
                return;
            }
        }
        public virtual void Show()
        {
        }

        public virtual void SetEnabled()
        {

        }
        public virtual void SetDisabled()
        {

        }
        public virtual void SetLocked()
        {

        }
        public virtual void SetUnlocked()
        {

        }

        public virtual void SetLeft(int value)
        {
        }
        public virtual void SetTop(int value)
        {
        }
        public virtual void SetWidth(int value)
        {
        }
        public virtual void SetHeight(int value)
        {
        }


        public virtual int GetLeft()
        {
            int retVal = 0;
            return retVal;
        }
        public virtual int GetTop()
        {
            int retVal = 0;
            return retVal;
        }
        public virtual int GetWidth()
        {
            int retVal = 0;
            return retVal;
        }
        public virtual int GetHeight()
        {
            int retVal = 0;
            return retVal;
        }



        public virtual void Render()
        {
            if(this.Children == null)
            {
                return;
            }
            foreach (var child in this.Children)
            {
                var vm = child.Value as ViewModelBase;
                if(vm == null)
                {
                    continue;
                }
                vm.Render();
            }
        }
    }
}
