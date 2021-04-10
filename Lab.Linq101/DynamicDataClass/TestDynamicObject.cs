using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Referece:
// https://docs.microsoft.com/en-us/dotnet/api/system.dynamic.dynamicobject?view=net-5.0

namespace Lab.Linq101.DynamicDataClass
{
    public class TestDynamicObject : DynamicObject
    {
        Dictionary<string, object> dictionary     = new Dictionary<string, object>();


        public int Count
        {
            get
            {
                return dictionary.Count;
            }
        }


        public override bool TryGetMember(
            GetMemberBinder binder, out object result)
        {

            string name = binder.Name.ToLower();


            return dictionary.TryGetValue(name, out result);
        }

        public override bool TrySetMember(
            SetMemberBinder binder, object value)
        {

            dictionary[binder.Name.ToLower()] = value;
            return true;
        }
    }
}
