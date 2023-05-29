using Griasdi.Mvvms.ViewModels.Buttons.PRIMITIVES;
using Griasdi.Mvvms.ViewModels.Panels.COMPOSITES;
using Griasdi.Mvvms.ViewModels.Panels.PRIMITIVES;
using Griasdi.Mvvms.Views;
using Griasdi.Mvvms.Views.Edits.PRIMITIVES;
using Griasdi.Mvvms.Views.NativeViews.EditViewControls.PRIMITIVES;
using Griasdi.Mvvms.Views.Panels.COMPOSITES;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Griasdi.Mvvms.ViewModels.Edits.PRIMITIVES
{
    public class LabeledDeepSingleLineEditBoxViewModel : EditBoxViewModel
    {
        public LabeledDeepSingleLineEditBoxViewModel() 
        {
        }

        public override void Build()
        {
            var vm = new ThreePanelViewModel();
            vm.Build();
            this.Add("THREE-PANEL-VIEW-MODEL",vm);

            vm.SetPanel0Left(0);
            vm.SetPanel0Width(25);

            var editBox = new SingleLineEditBoxViewModel();
            editBox.Build();
            
            vm.SetPanel1Left(vm.Panel0.GetLeft() + vm.Panel0.GetWidth());
            vm.SetPanel1Width(225);
            vm.SetPanel1(editBox);

            var button = new StandardButtonViewModel();
            button.Build();

            vm.SetPanel2Left(0);
            vm.SetPanel2Width(50);
            vm.SetPanel2(button);


            var view = vm.View as ThreePanelViewControl;
            this.SetView(view);
        }

        public override void SetValue(string value)
        {
            //var view = this.View as SingleLineEditBoxViewControl;
            //if(view == null)
            //{
            //    return;
            //}
            //view.SetValue(value);
            
        }

        public override void Render()
        {
            var vmt = this.Children["THREE-PANEL-VIEW-MODEL"];
            if(vmt == null)
            {
                return;
            }
            foreach (var childVm in vmt.Children)
            {
                var vm = childVm.Value as PanelViewModel;
                #region loop continue strategy
                if (vm == null)
                {
                    continue;
                }
                if(vm.Children == null)
                {
                    continue;
                }

                var vmpv = vm.View as ViewControlBase;
                var vmpvx = vmpv.NativeViewControl;

                #endregion
                foreach (var childPanel in vm.Children)
                {
                    var vmtx = childPanel.Value as ViewControlViewModelBase;
                    #region loop continue strategy
                    if (vmtx == null)
                    {
                        continue;
                    }
                    #endregion
                    vmtx.Render();
                    var vx = vmtx.View as ViewControlBase;
                    var vxNative = vx.NativeViewControl;
                    vx.SetTop(0);
                    vx.SetLeft(0);
                    vx.SetWidth(300);


                    if (vmtx is MultiLineEditBoxViewModel)
                    {
                        vx.SetHeight(125);
                    }
                    else
                    {
                        if (vmtx is SingleLineEditBoxViewModel)
                        {
                            vx.SetHeight(22);
                        }
                        if (vmtx is ButtonViewModel)
                        {
                            vx.SetHeight(50);
                        }
                    }
                    var vmpvxPanel = vmpvx as Panel;
                    vmpvxPanel.BackColor = Color.White;
                    vmpvxPanel.BorderStyle = BorderStyle.None;
                    vmpvx.Controls.Add(vxNative);
                }
                //vm.Render();
            }
        }
        
    }
}
