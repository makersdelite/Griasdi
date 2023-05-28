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

namespace Griasdi.Mvvms.Views.NativeViews.PanelViewControls
{
    public partial class PanelNativeViewControl : PanelNativeViewControlBase
    {
        public PanelNativeViewControl()
        {
            InitializeComponent();
        }

        public override void Build()
        {

            this.Dock = DockStyle.None;
            this.Panel.Left = 0;
            this.Panel.Top = 0;
            this.Panel.Dock = DockStyle.Fill;
            this.RegisterEvents();
        }

        public override void RegisterEvents()
        {
            var ctl = this.Panel;
            if (ctl == null)
            {
                return;
            }
            ctl.Click += Ctl_Click;
        }

        #region event handler
        private void Ctl_Click(object sender, EventArgs e)
        {
            this.RaiseNativeViewControlClickEvent(e);
        }
        #endregion

        public Control GetPanel()
        {
            return this.Panel;
        }
        public void SetValue(string value)
        {
            this.Panel.Text = value;
        }

        public string GetValue()
        {
            return this.Panel.Text;
        }

        public override void SetTop(int value)
        {
            base.SetTop(value);
            this.Panel.Top = 0;
        }

        public override void SetLeft(int value)
        {
            base.SetLeft(value);
            this.Panel.Left = 0;
        }

        public override void SetHeight(int value)
        {
            base.SetHeight(value);
            this.Panel.Height = value;
        }
                public override void SetWidth(int value)
        {
            base.SetWidth(value);
            this.Panel.Width = value;
        }
    }
}
