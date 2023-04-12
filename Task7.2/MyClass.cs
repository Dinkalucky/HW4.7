using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7._2
{
    public class MyClass
    {
        [Obsolete("Old method")]
        public void Method1()
        {
            Console.WriteLine("Method1");
        }

        [Obsolete("Old method",true)]
        public void Method2()
        {
            Console.WriteLine("Method2");
        }
    }
}
