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

            #region add edit boxes
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

            var sleb3 = ViewModelFactory.GetSingleLineEditBox("GREETING-ITALIAN-EDIT-BOX","Ciao");
            this.Add(sleb3);
            #endregion

            #region add buttons
            var sb0 = ViewModelFactory.Get("STANDARD-BUTTON") as ButtonViewModel;
            sb0.SetValue("Info");
            sb0.ViewModelClicked += ButtonViewModelClicked;
            this.Add("INFO-BUTTON", sb0);
            #endregion
            #region add buttons
            var sb1 = ViewModelFactory.Get("STANDARD-BUTTON") as ButtonViewModel;
            sb1.SetValue("Help");
            sb1.ViewModelClicked += ButtonViewModelClicked;
            this.Add("HELP-BUTTON", sb1);
            #endregion
            #region add buttons
            var sb2 = ViewModelFactory.Get("STANDARD-BUTTON") as ButtonViewModel;
            sb2.SetValue("Settings");
            sb2.ViewModelClicked += ButtonViewModelClicked;
            this.Add("SETTINGS-BUTTON",sb2);
            #endregion
            #region add buttons
            var sb3 = ViewModelFactory.Get("STANDARD-BUTTON") as ButtonViewModel;
            sb3.SetValue("Print");
            sb3.ViewModelClicked += ButtonViewModelClicked;
            this.Add("PRINT-BUTTON",sb3);
            #endregion
            #region add buttons
            var sb4 = ViewModelFactory.GetButton("New");
            sb4.ViewModelClicked += ButtonViewModelClicked;
            this.Add(sb4);

            var sb5 = ViewModelFactory.GetButton("SAVE-BUTTON", "Save");
            sb5.ViewModelClicked += ButtonViewModelClicked;
            this.Add(sb5);

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
                    if(vm is ButtonViewModel) 
                    {
                        vxNative.SetHeight(50);
                    }
                }

                view.NativeView.Controls.Add(vxNative);
                vmRunningTop += vxNative.Height + 5;
            }
            

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
