using Griasdi.Mvvms.ViewModels;
using Griasdi.Mvvms.ViewModels.Edits.PRIMITIVES;
using Griasdi.Mvvms.ViewModels.Factories;
using Griasdi.Mvvms.Views;
using GriasdiWinFormApp.MVVMS.VIEWS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GriasdiWinFormApp.MVVMS.VIEWMODELS
{
    public class GriasdiAppMainViewModel:ViewViewModelBase
    {
        public GriasdiAppMainViewModel()
        {
        }

        public override void Build()
        {

            var sleb0 = ViewModelFactory.Get("SINGLE-LINE-EDIT-BOX") as EditBoxViewModel;
            sleb0.SetValue("Moinsen");
            this.Add(sleb0);


            var sleb1 = ViewModelFactory.Get("SINGLE-LINE-EDIT-BOX") as EditBoxViewModel;
            sleb1.SetValue("Griasdi");
            this.Add(sleb1);

            var sleb2 = ViewModelFactory.Get("SINGLE-LINE-EDIT-BOX") as EditBoxViewModel;
            sleb2.SetValue("Hi");
            this.Add(sleb2);

            var view = new GriasdiAppMainView();
            view.Build();
            this.SetView(view);

            //temp render section
            var vmTopOffset = 200;
            var vmRunningTop = vmTopOffset;
            foreach (var childVm in this.Children)
            {
                var vm = childVm.Value as EditBoxViewModel;
                if(vm == null)
                {
                    continue;
                }

                var vx = vm.View as ViewControlBase;
                var vxNative = vx.NativeViewControl;
                vxNative.Top = vmRunningTop;
                vxNative.Left = 10;
                vxNative.Width = 300;
                vxNative.Height = 25;
                view.NativeView.Controls.Add(vxNative);

                vmRunningTop += vxNative.Height;
            }
            

        }
    }
}
