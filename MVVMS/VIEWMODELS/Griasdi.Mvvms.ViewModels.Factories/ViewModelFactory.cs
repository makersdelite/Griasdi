using Griasdi.Events;
using Griasdi.Mvvms.ViewModels.Buttons.PRIMITIVES;
using Griasdi.Mvvms.ViewModels.Edits.PRIMITIVES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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
                case "MULTI-LINE-EDIT-BOX":
                    retVal = new MultiLineEditBoxViewModel();
                    break;
                case "STANDARD-BUTTON":
                    retVal = new StandardButtonViewModel();
                    break;
                default:
                    break;
            }
            retVal.Build();
            return retVal;
        }

        #region simplified methods for human implementers
        public static ButtonViewModel GetButton(string caption)
        {
            ButtonViewModel retVal = null;
            #region method exit strategy
            if (caption == null)
            {
                return retVal;
            }
            if(caption.Trim().Length == 0)
            {
                return retVal;
            }
            #endregion
            var name = caption.ToUpper() + "-BUTTON";
            return ViewModelFactory.GetButton(name, caption);
        }
        public static ButtonViewModel GetButton(string name, string caption)
        {
            ButtonViewModel retVal = null;
            #region method exit strategy
            if (name == null)
            {
                return retVal;
            }
            if (name.Trim().Length == 0)
            {
                return retVal;
            }
            if (caption == null)
            {
                return retVal;
            }
            if (caption.Trim().Length == 0)
            {
                return retVal;
            }
            #endregion
            var vm = ViewModelFactory.Get("STANDARD-BUTTON") as ButtonViewModel;
            vm.Name = name.Trim().ToUpper();
            vm.SetValue(caption);
            retVal = vm;
            return retVal;
        }
      
        public static EditBoxViewModel GetSingleLineEditBox(string name, string value)
        {
            EditBoxViewModel retVal = null;
            #region method exit strategy
            if (name == null)
            {
                return retVal;
            }
            if (name.Trim().Length == 0)
            {
                return retVal;
            }
            #endregion
            var vm = ViewModelFactory.Get("SINGLE-LINE-EDIT-BOX") as EditBoxViewModel;
            vm.Name = name.Trim().ToUpper();
            vm.SetValue(value);
            retVal = vm;
            return retVal;
        }
        public static EditBoxViewModel GetMultiLineEditBox(string name, string value)
        {
            EditBoxViewModel retVal = null;
            #region method exit strategy
            if (name == null)
            {
                return retVal;
            }
            if (name.Trim().Length == 0)
            {
                return retVal;
            }
            #endregion
            var vm = ViewModelFactory.Get("MULTI-LINE-EDIT-BOX") as EditBoxViewModel;
            vm.Name = name.Trim().ToUpper();
            vm.SetValue(value);
            retVal = vm;
            return retVal;
        }
        #endregion
    }
}
