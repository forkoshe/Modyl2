using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("виберiть спосiб для авторизацiї:\n1)логiн i пароль\n2)спочатку логiн та пароль, потiм код СМС повiдомлення:\n3)Google\n:");
                int namber = Convert.ToInt32(Console.ReadLine());
                Authorization aut = new Authorization();
                aut.Vivod(namber);
            }
            catch (Exception)
            {
                Console.WriteLine("Вводiть 1 або 2 або 3");
                Console.Write("виберiть спосiб для авторизацiї:\n1)логiн i пароль\n2)спочатку логiн та пароль, потiм код СМС повiдомлення:\n3)Google\n:");
                int namber = Convert.ToInt32(Console.ReadLine());
                Authorization aut = new Authorization();
                aut.Vivod(namber);
            }
            
        }
    }
}
