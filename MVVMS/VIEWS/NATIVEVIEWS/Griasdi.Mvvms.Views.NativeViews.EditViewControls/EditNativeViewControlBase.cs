using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Griasdi.Mvvms.Views.NativeViews.EditViewControls
{
    public class EditNativeViewControlBase:NativeViewControlBase
    {
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // EditNativeViewControlBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Name = "EditNativeViewControlBase";
            this.Size = new System.Drawing.Size(392, 49);
            this.ResumeLayout(false);
        }
    }
}
