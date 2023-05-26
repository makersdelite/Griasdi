using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Griasdi.Events
{
    public class GriasdiViewEventArgs:GriasdiEventArgs
    {
        public GriasdiViewEventArgs() 
        {
        }

 
        public virtual void Cancel()
        {
            foreach (var eventArg in this.EventArgsDictionary)
            {
                var cancelEventArg = eventArg.Value as CancelEventArgs;
                if (cancelEventArg == null)
                {
                    continue;
                }
                cancelEventArg.Cancel = true;
            }
        }
    }
}
