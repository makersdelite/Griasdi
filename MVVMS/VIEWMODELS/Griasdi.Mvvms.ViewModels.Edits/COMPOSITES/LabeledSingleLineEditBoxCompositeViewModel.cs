using Griasdi.Mvvms.ViewModels.Buttons.PRIMITIVES;
using Griasdi.Mvvms.ViewModels.Edits.PRIMITIVES;
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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Griasdi.Mvvms.ViewModels.Edits.COMPOSITES
{
    public class LabeledSingleLineEditBoxCompositeViewModel : EditBoxViewModel
    {
        #region properties
        public EditBoxViewModel EditBox { get; set; }
        public ButtonViewModel Button { get; set; }
        public EditBoxViewModel Label { get; set; }
        #endregion


        public LabeledSingleLineEditBoxCompositeViewModel() 
        {
        }

        public override void Build()
        {
            var vm = new ThreePanelViewModel();
            vm.SetHeight(22);
            vm.Build();
            this.Add("THREE-PANEL-VIEW-MODEL",vm);

            var label = new SingleLineEditBoxViewModel();
            label.Build();
            label.SetValue("Label");
            label.SetLocked();
            label.SetBorderHidden();
            this.Label = label;

            vm.SetPanel0Top(1);
            vm.SetPanel0Left(0);
            vm.SetPanel0Width(200);
            vm.SetPanel0Height(22);
            vm.SetPanel0(label);

            var editBox = new SingleLineEditBoxViewModel();
            editBox.Build();
            this.EditBox = editBox;

            vm.SetPanel1Top(1);
            vm.SetPanel1Left(vm.Panel0.GetLeft() + vm.Panel0.GetWidth());
            vm.SetPanel1Width(275);
            vm.SetPanel1Height(22);
            vm.SetPanel1(editBox);

            var button = new StandardButtonViewModel();
            button.Build();
            button.SetValue("...");
            this.Button = button;

            vm.SetPanel2Top(0);
            vm.SetPanel2Left(vm.Panel1.GetLeft()+vm.Panel1.GetWidth());
            vm.SetPanel2Width(50);
            vm.SetPanel2Height(24);
            vm.SetPanel2(button);

            var view = vm.View as ThreePanelViewControl;
            this.SetView(view);
        }

        public override void SetValue(string value)
        {
            var vm = this.EditBox;
            if(vm == null)
            {
                return;
            }

            var view = vm.View as SingleLineEditBoxViewControl;
            if(view == null)
            {
                return;
            }
            view.SetValue(value);
        }

        public override void SetCaption(string value)
        {
            var vm = this.Label;
            if (vm == null)
            {
                return;
            }

            var view = vm.View as SingleLineEditBoxViewControl;
            if (view == null)
            {
                return;
            }
            view.SetValue(value);
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


                var vmpv = vm.View as ViewControlBase;
                var vmpvx = vmpv.NativeViewControl;

                var vmpvxPanel = vmpvx as Panel;
                vmpvxPanel.BorderStyle = BorderStyle.None;

                if (vm.Children == null)
                {
                    continue;
                }
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
                    if (vmtx is MultiLineEditBoxViewModel)
                    {
                        vx.SetWidth(vmpv.GetWidth() -1);
                        vx.SetHeight(125);
                    }
                    else
                    {
                        if (vmtx is SingleLineEditBoxViewModel)
                        {
                            vx.SetWidth(vmpv.GetWidth() - 0);
                            //vx.SetHeight(20);
                        }
                        if (vmtx is ButtonViewModel)
                        {
                            vx.SetWidth(vmpv.GetWidth() - 5);
                            vx.SetHeight(vmpv.GetHeight()-0);
                        }
                    }
                    vmpvx.Controls.Add(vxNative);
                }
                //vm.Render();
            }
        }
        
    }
}
