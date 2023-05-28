using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Griasdi.Mvvms.Views.NativeViews.PanelViewControls
{
    public class PanelNativeViewControlBase : NativeViewControlBase
    {
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // PanelNativeViewControlBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Name = "PanelNativeViewControlBase";
            this.Size = new System.Drawing.Size(388, 230);
            this.ResumeLayout(false);

        }
    }
}
