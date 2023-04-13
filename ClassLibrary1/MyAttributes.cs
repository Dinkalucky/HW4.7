using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Method, AllowMultiple = true)]
    public class NewPropertyAttribute : Attribute
    {
        public string Name { get; set; }

        public NewPropertyAttribute(string name)
        {
            Name = name;
        }
    }
}
