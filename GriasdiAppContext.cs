using Griasdi.Events;
using Griasdi.Mvvms.ViewModels;
using GriasdiWinFormApp.MVVMS.VIEWMODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GriasdiWinFormApp
{
    //source: https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.applicationcontext?view=windowsdesktop-7.0
    public class GriasdiAppContext: ApplicationContext
    {
        public ViewViewModelBase ViewModel { get; set; }

        public GriasdiAppContext()
        {
        }

        public virtual void RegisterEvents()
        {
            Application.ApplicationExit += Application_ApplicationExit;
            this.ViewModel.Closed += ViewModel_Closed;
            this.ViewModel.Closing += ViewModel_Closing;
        }

        #region event handler
        private void ViewModel_Closing(object sender, GriasdiEventArgs e)
        {
            //source: https://stackoverflow.com/questions/12409529/how-to-prevent-or-block-closing-a-winforms-window
            var ea = e as GriasdiViewModelEventArgs;
            if(ea == null)
            {
                return;
            }
            var window = MessageBox.Show("Do you really want to quit application ?", "Decision", MessageBoxButtons.YesNo);
            if(window == DialogResult.No)
            {
                ea.Cancel();
            }
        }

        private void ViewModel_Closed(object sender, GriasdiEventArgs e)
        {
            Application.Exit();
        }
        #endregion

        public virtual void Build()
        {
            

            var vm = new GriasdiAppMainViewModel();
            vm.Build();
            this.ViewModel = vm;

            this.RegisterEvents();
        }

        #region event handler
        private void Application_ApplicationExit(object sender, EventArgs e)
        {
            //tbd
        }
        #endregion

        public void Perform()
        {
            if(this.ViewModel == null)
            {
                return;
            }
            this.ViewModel.Show();
        }
    }
}
