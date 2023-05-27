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

namespace Griasdi.Mvvms.Views.NativeViews
{
    public partial class NativeViewControlBase : UserControl
    {

        #region event section
        #region click
        public event EventHandler<GriasdiEventArgs> NativeViewControlClicked;
        public void OnNativeViewControlClicked(GriasdiEventArgs e)
        {
            EventHandler<GriasdiEventArgs> handler = NativeViewControlClicked;
            if (handler != null)
            {
                handler(this, e);
            }
        }
        public void RaiseNativeViewControlClickEvent(EventArgs e)
        {
            var ea = new GriasdiViewEventArgs();
            ea.Add("CLICKED-EVENT-ARGS", e);
            this.OnNativeViewControlClicked(ea);
        }
        #endregion
        #endregion



        public NativeViewControlBase()
        {
            InitializeComponent();
        }

        public virtual void Build()
        {
        }

        public virtual void RegisterEvents()
        {
        }

        public virtual void SetHeight(int value)
        {
            this.Height = value;
        }
        public virtual void SetWidth(int value)
        {
            this.Width = value;
        }
        public virtual void SetTop(int value) 
        {
            this.Top = value;
        }
        public virtual void SetLeft(int value) 
        {
            this.Left = value;
        }
    }
}
