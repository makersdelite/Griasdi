using Griasdi.Apps.OcrEngineApps.MVVMS.VIEWMODELS;
using Griasdi.Mvvms.ViewModels;
using Griasdi.Tradefairs.Exhibitors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Griasdi.Apps.OcrEngineApps
{
    public class OcrEngineApp : ExhibitorAppBase
    {
        public ViewModelBase ViewModel { get; set; }

        public OcrEngineApp()
        {
            
        }

        public override void Build()
        {
            var vm = new OcrEngineAppViewModel();
            vm.Build();
            this.ViewModel = vm;

        }

    }
}
