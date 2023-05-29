using Griasdi.Apps.GreetingTranslatorApps;
using Griasdi.Apps.OcrEngineApps;
using Griasdi.Events;
using Griasdi.Mvvms.ViewModels;
using Griasdi.Mvvms.ViewModels.Buttons.PRIMITIVES;
using Griasdi.Mvvms.ViewModels.Edits.PRIMITIVES;
using Griasdi.Mvvms.ViewModels.Factories;
using Griasdi.Mvvms.Views;
using GriasdiWinFormApp.MVVMS.VIEWS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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


            #region very first try to "inject" an external app logic of type "exhibitor" following tradefair idea to the mvvm platform
            var exhibitor0 = new GreetingTranslatorApp();
            exhibitor0.Build();
            var vmExhibitor0 = exhibitor0.ViewModel;
            this.Add(vmExhibitor0);

            var exhibitor1 = new OcrEngineApp();
            exhibitor1.Build();
            var vmExhibitor1 = exhibitor1.ViewModel;
            this.Add(vmExhibitor1);
            #endregion


            //temp render section
            if (this.Children == null)
            {
                return;
            }
            var vmTopOffset = 10;
            var vmRunningTop = vmTopOffset;
            foreach (var childVm in this.Children)
            {
                var vm = childVm.Value as ViewControlViewModelBase;
                if(vm == null)
                {
                    continue;
                }


                #region run specific Render() - method of viewmodel in scope
                vm.Render();
                #endregion


                var vx = vm.View as ViewControlBase;
                var vxNative = vx.NativeViewControl;
                vx.SetTop(vmRunningTop);
                vx.SetLeft(10);
                //vxNative.SetWidth(750);


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
                    if(vm is ButtonViewModel) 
                    {
                        vx.SetHeight(50);
                    }
                }             
                view.NativeView.Controls.Add(vxNative);
                vmRunningTop += vxNative.Height + 5;
            }
            

        }

        public EditBoxViewModel AddSingleLineEditBox(string name, string caption)
        {
            EditBoxViewModel retVal = null;
            var vm = ViewModelFactory.GetSingleLineEditBox(name, caption);
            this.Add(vm);
            retVal = vm;
            return retVal;
        }
        public EditBoxViewModel AddMultiLineEditBox(string name, string caption)
        {
            EditBoxViewModel retVal = null;
            var vm = ViewModelFactory.GetMultiLineEditBox(name, caption);
            this.Add(vm);
            retVal = vm;
            return retVal;
        }


        public ButtonViewModel AddButton(string name, string caption)
        {
            ButtonViewModel retVal = null;
            var vm = ViewModelFactory.GetButton(name, caption);
            this.Add(vm);
            retVal = vm;
            return retVal;
        }

        public async Task<bool> SaveThisStuffAsync()
        {
            bool retVal = false;
            await Task.Delay(0);
            return retVal;
        }

        private void ButtonViewModelClicked(object sender, GriasdiEventArgs e)
        {
            var vm = sender as ViewModelBase;
            if(vm == null)
            {
                return;
            }
            MessageBox.Show("ViewModel (resp. underlying native control) name: " + vm.Name + " text: " + vm.Caption +  " uid: " + vm.Uid + " type: " + vm.ToString() + " has been clicked.");
        }
    }
}
