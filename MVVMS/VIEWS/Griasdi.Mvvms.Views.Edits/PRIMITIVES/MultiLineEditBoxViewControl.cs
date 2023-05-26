using Griasdi.Mvvms.Views.NativeViews;
using Griasdi.Mvvms.Views.NativeViews.EditViewControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Griasdi.Mvvms.Views.Edits.PRIMITIVES
{
    public class MultiLineEditBoxViewControl : EditBoxViewControl
    {
        public MultiLineEditBoxViewControl()
        {
        }

        public override void Build()
        {
            var nativeViewControl = new MultiLineEditBoxNativeViewControl();
            nativeViewControl.Build();
            this.SetViewControl(nativeViewControl);
        }
    }
}
