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

            var view = new GriasdiAppMainView();
            view.Build();
            this.SetView(view);
            this.RegisterEvents();


            var sleb0 = ViewModelFactory.Get("SINGLE-LINE-EDIT-BOX") as EditBoxViewModel;
            sleb0.SetValue("Moinsen");
            this.Add(sleb0);

            var mleb0 = ViewModelFactory.Get("MULTI-LINE-EDIT-BOX") as EditBoxViewModel;
            mleb0.SetValue("'Moinsen' is an advanced northern german flavour to say 'hello'. It derives from 'Moin' resp. 'Moin Moin'. But keep in mind that natives simply identify people as chatty when they say 'Moin Moin'. (https://en.wikipedia.org/wiki/Moin)");
            this.Add(mleb0);


            var sleb1 = ViewModelFactory.Get("SINGLE-LINE-EDIT-BOX") as EditBoxViewModel;
            sleb1.SetValue("Griasdi");
            this.Add(sleb1);

            var sleb2 = ViewModelFactory.Get("SINGLE-LINE-EDIT-BOX") as EditBoxViewModel;
            sleb2.SetValue("Hi");
            this.Add(sleb2);





            //temp render section
            if (this.Children == null)
            {
                return;
            }
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
                vxNative.SetTop(vmRunningTop);
                vxNative.Left = 10;
                vxNative.SetWidth(300);


                if (vm is MultiLineEditBoxViewModel)
                {
                    vxNative.SetHeight(125);
                }
                else
                {
                    vxNative.Height = 22;
                }
                
                view.NativeView.Controls.Add(vxNative);

                vmRunningTop += vxNative.Height + 5;
            }
            

        }
    }
}
