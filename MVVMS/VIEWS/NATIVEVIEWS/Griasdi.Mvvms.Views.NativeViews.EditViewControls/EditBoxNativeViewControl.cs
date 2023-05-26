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
    }
}
