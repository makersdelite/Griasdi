using Griasdi.Mvvms.Views;
using GriasdiWinFormApp.MVVMS.VIEWS.NATIVEVIEWS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GriasdiWinFormApp.MVVMS.VIEWS
{
    public class GriasdiAppMainView:ViewBase
    {
        public GriasdiAppMainView() 
        {
        }

        public override void Build()
        {
            var winView = new MainView();
            winView.Text = "GriasdiAppMainView";
            winView.WindowState = FormWindowState.Maximized;
            this.SetView(winView);
        }
    }
}
