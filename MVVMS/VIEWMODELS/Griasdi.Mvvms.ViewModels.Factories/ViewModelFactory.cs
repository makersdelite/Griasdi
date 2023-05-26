using Griasdi.Mvvms.ViewModels.Edits.PRIMITIVES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Griasdi.Mvvms.ViewModels.Factories
{
    public static class ViewModelFactory
    {
        public static ViewModelBase Get(string name)
        {
            ViewModelBase retVal = null;
            #region method exit strategy
            if (name == null)
            {
                return retVal;
            }
            if(name.Length == 0)
            {
                return retVal;
            }
            #endregion
            var nameRefined = name.Trim().ToUpper();
            switch (nameRefined)
            {
                case "SINGLE-LINE-EDIT-BOX":
                    retVal = new SingleLineEditBoxViewModel();
                    break;
                default:
                    break;
            }
            retVal.Build();
            return retVal;
        }
    }
}
