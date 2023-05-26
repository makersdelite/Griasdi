using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Griasdi.Helpers.StringHelpers
{
    public static class StringHelper
    {
        public static string GetGuid()
        {
            string retVal = null;
            retVal = Guid.NewGuid().ToString().Replace("-", "").Trim().ToUpper();
            return retVal;
        }
    }
}
