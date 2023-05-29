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

namespace Griasdi.Mvvms.Views.NativeViews.EditViewControls
{
    public partial class EditBoxNativeViewControl : EditNativeViewControlBase
    {

        #region event section
        #region close
        public event EventHandler<GriasdiEventArgs> ValueChanged;
        public void OnValueChanged(GriasdiEventArgs e)
        {
            EventHandler<GriasdiEventArgs> handler = ValueChanged;
            if (handler != null)
            {
                handler(this, e);
            }
        }
        public void RaiseValueChangeEvent(EventArgs e)
        {
            var ea = new GriasdiViewEventArgs();
            ea.Add("VALUE-CHANGED-EVENT-ARGS", e);
            this.OnValueChanged(ea);
        }
        #endregion
        #endregion

        public EditBoxNativeViewControl()
        {
            InitializeComponent();
        }

        public override void Build()
        {
            this.RegisterEvents();
        }

        public override void RegisterEvents()
        {
            var tbx = this.TextBox;
            if(tbx == null)
            {
                return;
            }
            tbx.TextChanged += Tbx_TextChanged;
        }

        #region event handler
        private void Tbx_TextChanged(object sender, EventArgs e)
        {
            this.RaiseValueChangeEvent(e);
        }
        #endregion

        public Control GetTextBox()
        {
            return this.TextBox;
        }
        public void SetValue(string value)
        {
            this.TextBox.Text = value;
        }
        public string GetValue()
        {
            return this.TextBox.Text;
        }

        public virtual void SetMultiline(bool value)
        {
            var tb = this.TextBox;
            tb.Multiline = value;

            tb.ScrollBars = ScrollBars.Vertical;
            tb.AcceptsReturn = true;
            tb.AcceptsTab = true;
            tb.WordWrap = true;
        }


        public override void SetEnabled()
        {
            base.SetEnabled();
            this.TextBox.Enabled = true;
        }
        public override void SetDisabled()
        {
            base.SetDisabled();
            this.TextBox.Enabled = false;
        }

        public override void SetLocked()
        {
            base.SetLocked();
            this.TextBox.ReadOnly = true;
            this.TextBox.BackColor = Color.White;
        }
        public override void SetUnlocked()
        {
            base.SetUnlocked();
            this.TextBox.ReadOnly = false;
        }


        public override void SetBorderVisible()
        {
            base.SetBorderVisible();
            this.TextBox.BorderStyle = BorderStyle.FixedSingle;
        }
        public override void SetBorderHidden()
        {
            base.SetBorderHidden();
            this.TextBox.BorderStyle = BorderStyle.None;
        }




        public override void SetTop(int value)
        {
            base.SetTop(value);
            this.TextBox.Top = 0;
        }
        public override void SetLeft(int value)
        {
            base.SetLeft(value);
            this.TextBox.Left = 0;
        }

        public override void SetHeight(int value)
        {
            base.SetHeight(value);
            this.TextBox.Height = value;
        }
        

        public override void SetWidth(int value)
        {
            base.SetWidth(value);
            this.TextBox.Width = value;
        }
    }
}
