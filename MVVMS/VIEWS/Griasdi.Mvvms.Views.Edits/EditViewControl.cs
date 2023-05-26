using Griasdi.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Griasdi.Mvvms.Views.Edits
{
    public class EditViewControl:ViewControlBase
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
    }
}
