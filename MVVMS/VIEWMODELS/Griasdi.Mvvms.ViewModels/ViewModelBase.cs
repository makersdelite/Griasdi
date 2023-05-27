﻿using Griasdi.Commons;
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
    }
}
