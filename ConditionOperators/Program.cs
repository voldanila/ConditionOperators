using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            const string adminPassword = "123";
            const string adminLogin = "admin";

            const string guestPassword = "555";
            const string guestLogin = "guest";

            Console.WriteLine("Введите логин");
            string userLogin = Console.ReadLine();

            Console.WriteLine("Введите пароль");
            string userPassword = Console.ReadLine();

            //переделать условие чтобы выводилось Добро пожаловать админ или гость (идентифицировал)
            if (userLogin == adminLogin && adminPassword == userPassword ||
                userLogin == guestLogin && guestPassword == userPassword)
            {
                Console.WriteLine("Добро пожаловать");
            }
            else
            {
                Console.WriteLine("Неверный логин или пароль");
            }

            Console.ReadKey();
        }
    }
}
