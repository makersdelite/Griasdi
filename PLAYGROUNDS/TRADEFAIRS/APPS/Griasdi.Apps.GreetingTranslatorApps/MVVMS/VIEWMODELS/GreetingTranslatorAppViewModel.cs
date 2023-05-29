using Griasdi.Mvvms.ViewModels;
using Griasdi.Mvvms.Views;
using Griasdi.Mvvms.Views.NativeViews.PanelViewControls;
using Griasdi.Mvvms.Views.NativeViews.PanelViewControls.PRIMITIVES;
using Griasdi.Tradefairs.Exhibitors;
using Griasdi.Tradefairs.Exhibitors.MVVMS.VIEWMODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Griasdi.Apps.GreetingTranslatorApps.MVVMS.VIEWMODELS
{
    public class GreetingTranslatorAppViewModel:ExhibitorAppViewModelBase
    {
        public GreetingTranslatorAppViewModel()
        {
        }

        public override void Build()
        {
            base.Build();
            var vm = new GreetingTranslatorOverviewViewModel();
            vm.Build();
            this.Add(vm);
        }

        public override void Render()
        {
                if(this.Children == null)
                {   
                    return;
                }

                foreach(var child in this.Children) 
                {
                var vm = child.Value as ViewControlViewModelBase;
                if(vm == null)
                {
                    continue;
                }
                vm.Render();
                var view = vm.View as ViewControlBase;
                if(view == null)
                {
                    return;
                }
                var nativeView = view.NativeViewControl;


                var parentView = this.View as ViewControlBase;
                if(parentView == null)
                {
                    return;
                }
                var parentPanel = parentView.NativeViewControl as PanelNativeViewControl;
                parentPanel.GetPanel().Controls.Add(nativeView);
                }
        }
    }
}
