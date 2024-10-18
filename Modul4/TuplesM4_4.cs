using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul4
{
    internal class TuplesM4_4
    {
        
        public static void Createtupl()
        {
            (string name, int age) tupl;
            Console.Write("Введите имя: ");
            tupl.name = Console.ReadLine();
            Console.Write("Введите возраст с цифрами: ");
            tupl.age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ваше имя: {0}", tupl.name);
            Console.WriteLine("Ваш возраст: {0}", tupl.age);
        }
    }
}
