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

namespace Griasdi.Mvvms.Views.NativeViews.ButtonViewControls
{
    public partial class ButtonNativeViewControl : ButtonNativeViewControlBase
    {
        public ButtonNativeViewControl()
        {
            InitializeComponent();
        }

        public override void Build()
        {
            this.RegisterEvents();
        }

        public override void RegisterEvents()
        {
            var ctl = this.Button;
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

        public Control GetButton()
        {
            return this.Button;
        }
        public void SetValue(string value)
        {
            this.Button.Text = value;
        }

        public string GetValue()
        {
            return this.Button.Text;
        }

        public override void SetTop(int value)
        {
            base.SetTop(value);
            this.Button.Top = 0;
        }

        public override void SetLeft(int value)
        {
            base.SetLeft(value);
            this.Button.Left = 0;
        }

        public override void SetHeight(int value)
        {
            base.SetHeight(value);
            this.Button.Height = value;
        }
                public override void SetWidth(int value)
        {
            base.SetWidth(value);
            this.Button.Width = value;
        }
    }
}
