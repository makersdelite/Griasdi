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
