using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Griasdi.Helpers.ProcessHelpers
{
    public static class ProcessHelper
    {
        public static void OpenUrlWithEdgeBrowser(string url)
        {
            //https://stackoverflow.com/questions/71660608/open-edge-in-a-new-process-and-kill-it-again
            #region method exit strategy
            if (url == null)
            {
                return;
            }
            if (url != null && url.Trim().Length == 0)
            {
                return;
            }
            #endregion
            try
            {
                Process p = new Process();
                var argumentsPattern = @"--new-window ###url###";
                var argumentsFinal = argumentsPattern.Replace("###url###", url);
                p.StartInfo.FileName = @"C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe";
                p.StartInfo.Arguments = argumentsFinal;
                p.Start();
            }
            catch (Exception ex)
            {
                //Todo: appropriate exception handling
            }
        }
    }
}
