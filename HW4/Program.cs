using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    
        class Program
        {
            static void Main(string[] args)
            {
            PrintColor printColor = new PrintColor();
            Human owner = new Human("Ivan", "Ivanov", 18);
            Animal dog = new Animal("Killer", "bulldog", 13, owner);
            Console.WriteLine("Object: Human");
            printColor.ColorPrint(owner);
            Console.WriteLine();
            Console.WriteLine("Object: Animal");
            printColor.ColorPrint(dog);
            Console.WriteLine();
            Console.ReadLine();
            }
        }
    
}
