using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBlock._11._7._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введи своё имя ");

            var name = Console.ReadLine();

            Console.WriteLine("Введи свой возраст ");

            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Тебя зовут {0} и тебе годиков {1} ", name, age);

            Console.Write("Какой твой любимый недельных день? ");

            var day = Console.ReadLine();

            Console.WriteLine("Твой любимый день {0}", day);

            Console.Write("Когда у тебя день рождение? ");

            var Dnuha = Console.ReadLine();

            Console.WriteLine("Твоё денб рождение этого числа, йоу {0}", Dnuha);

            Console.ReadLine();
        }
    }
}
