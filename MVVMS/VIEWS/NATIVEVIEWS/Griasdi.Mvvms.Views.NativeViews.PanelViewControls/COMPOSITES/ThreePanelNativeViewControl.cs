using Griasdi.Events;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Griasdi.Mvvms.Views.NativeViews.PanelViewControls.COMPOSITES
{
    public partial class ThreePanelNativeViewControl : PanelNativeViewControlBase
    {
        public ThreePanelNativeViewControl()
        {
            InitializeComponent();
        }

        public override void Build()
        {
            this.Dock = DockStyle.None;
        }
               
        public Control GetPanel0()
        {
            this.Panel0.BackColor = Color.Orange;
            return this.Panel0;
        }

        public Control GetPanel1()
        {
            this.Panel1.BackColor = Color.Orange;
            return this.Panel1;
        }

        public Control GetPanel2()
        {
            this.Panel2.BackColor = Color.Orange;
            return this.Panel2;
        }
    }
}
