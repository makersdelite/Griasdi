﻿using Griasdi.Mvvms.Views.Edits.PRIMITIVES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Griasdi.Mvvms.ViewModels.Edits.PRIMITIVES
{
    public class EditBoxViewModel:EditViewControlViewModel
    {
        public EditBoxViewModel() 
        {
        }
        
        public virtual void SetValue(string value)
        {
        }

        public virtual string GetValue()
        {
            string retVal = null;
            return retVal;
        }
        public virtual void SetCaption(string value)
        {
        }
    }
}
