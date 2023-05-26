using Griasdi.Helpers.StringHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Griasdi.Commons
{
    public class GriasdiBase
    {
        #region properties
        public string Uid { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public GriasdiBase Parent { get; set; }
        public Dictionary<string, GriasdiBase> Children { get; set; }
        #endregion

        public GriasdiBase()
        {
            this.Uid = StringHelper.GetGuid();
        }


        public virtual void RegisterEvents()
        {
        }

        public virtual void Build()
        {

        }

        public virtual void Add(GriasdiBase child)
        {
            if (child == null)
            {
                return;
            }

            if (this.Children == null)
            {
                this.Children = new Dictionary<string, GriasdiBase>();
            }

            child.Parent = this;
            this.Children.Add(child.Uid, child);
        }

        public virtual void Add(string keyName, GriasdiBase child)
        {
            #region method exit strategy
            if (keyName == null)
            {
                return;
            }
            if (keyName.Trim().Length == 0)
            {
                return;
            }

            if (child == null)
            {
                return;
            }
            #endregion

            if (this.Children == null)
            {
                this.Children = new Dictionary<string, GriasdiBase>();
            }
            child.Parent = this;
            var keyNameRefined = keyName.Trim().ToUpper();
            this.Children.Add(keyNameRefined, child);
        }
        public virtual GriasdiBase Clone()
        {
            return null;
        }
    }
}
