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

        #region event handler
        private void View_ViewControlClicked(object sender, Events.GriasdiEventArgs e)
        {
            this.RaiseViewModelClickEvent(e);
        }
        #endregion
    }
}
