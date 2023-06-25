using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Контроль_выхода
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            while (true)
            {
                Console.WriteLine("Введите exit, чтобы выйти.");
                input = Console.ReadLine();
                if(input == "exit")
                {
                    break;
                }
            }
            Console.WriteLine("Вы вышли из программы.");
        }
    }
}
