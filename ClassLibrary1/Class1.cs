using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public abstract class Class
    {
        string classString;
        [NewProperty("MyClassProperty")]
        public string ClassProperty { get; set; }
        [NewProperty("MyClassMethod")]
        public abstract void Method();
    }
    public class Class1:Class
    {
        [NewProperty("MyClass1Property")]
        public string Class1Property { get; set; }
        [NewProperty("MyClass1Method")]
        public override void Method()
        {
            Console.WriteLine("Class1");
        }
    }
    public class Class2 : Class
    {
        [NewProperty("MyClass2Property")]
        private string Class2Property { get; set; }
        [NewProperty("MyClass2Method")]
        public override void Method()
        {
            Console.WriteLine("Class2");
        }
    }
}
