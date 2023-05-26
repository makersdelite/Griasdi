using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Griasdi.Events
{
    public class GriasdiEventArgs:EventArgs
    {
        public Dictionary<string,EventArgs> EventArgsDictionary { get; set; }

        public GriasdiEventArgs() 
        {
        }

        public void Add(string key,EventArgs e)
        {
            if(this.EventArgsDictionary==null)
            {
                this.EventArgsDictionary=new Dictionary<string,EventArgs>();
            }
            this.EventArgsDictionary.Add(key, e);
        }

        
    }
}
