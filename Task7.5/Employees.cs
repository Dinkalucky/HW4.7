using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7._5
{
    public class Manager
    {
        [AccessLevel(1)]
        public void Access()
        {
            Console.WriteLine("Доступ для менеджера");
        }
    }
    public class Programmer
    {
        [AccessLevel(2)]
        public void Access()
        {
            Console.WriteLine("Доступ для програміста");
        }
    }
    public class Director
    {
        [AccessLevel(3)]
        public void Access()
        {
            Console.WriteLine("Доступ для директора");
        }
    }
}
