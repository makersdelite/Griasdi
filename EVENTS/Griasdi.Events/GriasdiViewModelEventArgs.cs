using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Griasdi.Events
{
    public class GriasdiViewModelEventArgs:GriasdiEventArgs
    {
        public GriasdiViewModelEventArgs() 
        {
        }
        public virtual void Cancel()
        {
            foreach (var eventArg in this.EventArgsDictionary)
            {
                var viewEventArg = eventArg.Value as GriasdiViewEventArgs;
                if(viewEventArg == null)
                {
                    continue;
                }
                viewEventArg.Cancel();
            }
        }
    }
}
