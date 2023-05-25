using Griasdi.Mvvms.ViewModels;
using GriasdiWinFormApp.MVVMS.VIEWS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GriasdiWinFormApp.MVVMS.VIEWMODELS
{
    public class GriasdiAppMainViewModel:ViewModelBase
    {
        public GriasdiAppMainViewModel()
        {
        }

        public override void Build()
        {
            var view = new GriasdiAppMainView();
            view.Build();
            this.SetView(view);
        }
    }
}
