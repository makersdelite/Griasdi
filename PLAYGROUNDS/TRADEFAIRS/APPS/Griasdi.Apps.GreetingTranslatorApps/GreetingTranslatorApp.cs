using Griasdi.Apps.GreetingTranslatorApps.MVVMS.VIEWMODELS;
using Griasdi.Mvvms.ViewModels;
using Griasdi.Tradefairs.Exhibitors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Griasdi.Apps.GreetingTranslatorApps
{
    public class GreetingTranslatorApp:ExhibitorAppBase
    {
        public ViewModelBase ViewModel { get; set; }

        public GreetingTranslatorApp()
        {
            
        }

        public override void Build()
        {
            var vm = new GreetingTranslatorAppViewModel();
            vm.Build();
            this.ViewModel = vm;

        }

    }
}
