using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7._5
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int level;
            Console.WriteLine("Введіть свою посаду: " +
                              "\n1 - Менеджер" +
                              "\n2 - Програміст" +
                              "\n3 - Директор");

            Int32.TryParse(Console.ReadLine(), out level);

            switch (level)
            {
                case 1:
                    Manager manager = new Manager();
                    manager.Access();
                    break;
                case 2:
                    Programmer programmer = new Programmer();
                    programmer.Access();
                    break;
                case 3:
                    Director director = new Director();
                    director.Access();
                    break;
            }
            Console.ReadKey();
        }
    }
}
