using Griasdi.Mvvms.ViewModels;
using Griasdi.Mvvms.ViewModels.Buttons.PRIMITIVES;
using Griasdi.Mvvms.ViewModels.Edits.PRIMITIVES;
using Griasdi.Mvvms.ViewModels.Factories;
using Griasdi.Mvvms.ViewModels.Panels.PRIMITIVES;
using Griasdi.Mvvms.Views;
using Griasdi.Mvvms.Views.NativeViews.PanelViewControls;
using Griasdi.Mvvms.Views.NativeViews.PanelViewControls.PRIMITIVES;
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
            vmInfoPart.SetWidth(600);
            this.Add("INFO-PART-PANEL",vmInfoPart);


            var view = vmInfoPart.View as StandardPanelViewControl;
            if (view == null)
            {
                return;
            }
            this.View = view;

            var sleb4 = ViewModelFactory.GetLabeledSingleLineEditBoxComposite("GREETING-EN-US-EDIT-BOX", "English", "Hi");
            vmInfoPart.Add(sleb4);

            var sleb0 = ViewModelFactory.GetLabeledSingleLineEditBoxComposite("GREETING-ITALIAN-EDIT-BOX","Italian","Ciao");
            vmInfoPart.Add(sleb0);

            var sleb1 = ViewModelFactory.GetLabeledSingleLineEditBoxComposite("GREETING-BAVARIAN-EDIT-BOX", "Germany, Southern, Bavarian","Griasdi");
            vmInfoPart.Add(sleb1);

            var sleb2 = ViewModelFactory.GetLabeledSingleLineEditBoxComposite("GREETING-NORTHERN-DE-HAMBURG-EDIT-BOX","Germany, Northern, e.g. Hamburg", "Moin");
            vmInfoPart.Add(sleb2);

            var sleb3 = ViewModelFactory.GetLabeledSingleLineEditBoxComposite("GREETING-NORTHERN-DE-HAMBURG-CHATTY-EDIT-BOX", "Germany, Northern, chatty style", "Moin Moin");
            vmInfoPart.Add(sleb3);

            var webBox0 = ViewModelFactory.GetWebUrlBox("WEB-URL-WIKI-ENGLISH-LANGUAGE", "Wikipedia about english language", "https://en.wikipedia.org/wiki/English_language");
            vmInfoPart.Add(webBox0);
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

                vm.Render();

                var vx = vm.View as ViewControlBase;
                var vxNative = vx.NativeViewControl;
                vx.SetTop(vmRunningTop);
                vx.SetLeft(10);
                vx.SetWidth(600);
                vx.SetHeight(25);

                if (vm is MultiLineEditBoxViewModel)
                {
                    vx.SetHeight(125);
                }
                else
                {
                    if (vm is SingleLineEditBoxViewModel)
                    {
                        vx.SetHeight(22);
                    }
                    if (vm is ButtonViewModel)
                    {
                        vx.SetHeight(50);
                    }
                }



                nativeView.GetPanel().Controls.Add(vxNative);
                vmRunningTop += vxNative.Height + 5;
            }

        }
    }
}
