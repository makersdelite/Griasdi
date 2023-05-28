using Griasdi.Mvvms.ViewModels;
using Griasdi.Mvvms.ViewModels.Buttons.PRIMITIVES;
using Griasdi.Mvvms.ViewModels.Edits.PRIMITIVES;
using Griasdi.Mvvms.ViewModels.Factories;
using Griasdi.Mvvms.ViewModels.Panels.PRIMITIVES;
using Griasdi.Mvvms.Views;
using Griasdi.Mvvms.Views.NativeViews.PanelViewControls;
using Griasdi.Mvvms.Views.Panels.PRIMITIVES;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Griasdi.Apps.GreetingTranslatorApps.MVVMS.VIEWMODELS
{
    public class GreetingTranslatorOverviewViewModel: ViewControlViewModelBase
    {
        public GreetingTranslatorOverviewViewModel() 
        {
        }

        public override void Build()
        {
            var vmInfoPart = new StandardPanelViewModel();
            vmInfoPart.Build();
            this.Add("INFO-PART-PANEL",vmInfoPart);


            var view = vmInfoPart.View as StandardPanelViewControl;
            if (view == null)
            {
                return;
            }
            this.View = view;

            var sleb0 = ViewModelFactory.GetSingleLineEditBox("GREETING-ITALIAN-EDIT-BOX","Ciao");
            vmInfoPart.Add(sleb0);

            var sleb1 = ViewModelFactory.GetSingleLineEditBox("GREETING-BAVARIAN-EDIT-BOX", "Griasdi");
            vmInfoPart.Add(sleb1);

            var sleb2 = ViewModelFactory.GetSingleLineEditBox("GREETING-NORTHERN-DE-HAMBURG-EDIT-BOX", "Moin");
            vmInfoPart.Add(sleb2);

            var sleb3 = ViewModelFactory.GetSingleLineEditBox("GREETING-NORTHERN-DE-HAMBURG-CHATTY-EDIT-BOX", "Moin Moin");
            vmInfoPart.Add(sleb3);
        }

        public override void Render()
        {
            #region method exit strategy
            if (this.Children == null)
            {
                return;
            }


            var vmInfoPart = this.Children["INFO-PART-PANEL"] as ViewModelBase;
            if(vmInfoPart == null)
            {
                return;
            }

            var view = vmInfoPart.View as StandardPanelViewControl;
            if(view==null)
            {
                return;
            }
            var nativeView = view.NativeViewControl as PanelNativeViewControl;
            if(nativeView==null)
            {
                return;
            }
            #endregion
            nativeView.Dock = System.Windows.Forms.DockStyle.None;
            nativeView.BackColor = Color.White;

            var vmTopOffset = 10;
            var vmRunningTop = vmTopOffset;
            foreach (var childVm in vmInfoPart.Children)
            {
                var vm = childVm.Value as ViewControlViewModelBase;
                if (vm == null)
                {
                    continue;
                }

                var vx = vm.View as ViewControlBase;
                var vxNative = vx.NativeViewControl;
                vxNative.SetTop(vmRunningTop);
                vxNative.SetLeft(10);
                vxNative.SetWidth(300);


                if (vm is MultiLineEditBoxViewModel)
                {
                    vxNative.SetHeight(125);
                }
                else
                {
                    if (vm is SingleLineEditBoxViewModel)
                    {
                        vxNative.SetHeight(22);
                    }
                    if (vm is ButtonViewModel)
                    {
                        vxNative.SetHeight(50);
                    }
                }



                nativeView.GetPanel().Controls.Add(vxNative);
                vmRunningTop += vxNative.Height + 5;
            }

        }
    }
}
