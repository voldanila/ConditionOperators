using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelcomeSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текущее время");
            int hours = int.Parse(Console.ReadLine());

            if (hours >= 5 && hours < 12)
            {
                Console.WriteLine("Доброе утро");
            }
            else if (hours >= 12 && hours < 17)
            {
                Console.WriteLine("Добрый день");
            }
            else if (hours >= 17 && hours < 24)
            {
                Console.WriteLine("Добрый вечер");
            }
            else if (hours >= 0 && hours < 5)
            {
                Console.WriteLine("Доброй ночи");
            }
            else
            {
                Console.WriteLine("Некорректное время");
            }

            Console.ReadLine();
        }
    }
}
