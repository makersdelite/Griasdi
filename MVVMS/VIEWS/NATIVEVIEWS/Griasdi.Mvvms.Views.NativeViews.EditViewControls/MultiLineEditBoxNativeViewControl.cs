using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Griasdi.Mvvms.Views.NativeViews.EditViewControls
{
    public partial class MultiLineEditBoxNativeViewControl : EditBoxNativeViewControl
    {
        public MultiLineEditBoxNativeViewControl()
        {
            InitializeComponent();
        }

        public override void Build()
        {
            base.SetMultiline(true);
        }
    }
}
