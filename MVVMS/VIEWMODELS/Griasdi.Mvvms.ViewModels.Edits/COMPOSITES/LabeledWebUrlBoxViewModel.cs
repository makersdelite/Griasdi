using Griasdi.Events;
using Griasdi.Helpers.ProcessHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Griasdi.Mvvms.ViewModels.Edits.COMPOSITES
{
    public class LabeledWebUrlBoxViewModel: LabeledSingleLineEditBoxCompositeViewModel
    {
        public LabeledWebUrlBoxViewModel()
        {
        }

        public override void Build()
        {
            base.Build();
            this.Button.SetValue("Go");
            this.Button.ViewModelClicked += this.Button_ViewModelClicked;
        }

        private void Button_ViewModelClicked(object sender, GriasdiEventArgs e)
        {
            var url = this.EditBox.GetValue();
            ProcessHelper.OpenUrlWithEdgeBrowser(url);
        }

       
    }
}
