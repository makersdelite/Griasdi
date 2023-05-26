using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Griasdi.Mvvms.Views.NativeViews.EditViewControls
{
    public class EditViewControlBase:NativeViewControlBase
    {
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // EditViewControlBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Name = "EditViewControlBase";
            this.Size = new System.Drawing.Size(392, 49);
            this.ResumeLayout(false);

        }
    }
}
