using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul
{
    class Authorization
    {
        public List<string> Login = new List<string>() { "Dasha234", "danil3000" };
        public List<string> Parol = new List<string>() { "00000000", "Ao11111" };
        public List<string> NumberTel = new List<string>() { "+380504588123", "+380876588169", "+380704538222" };
        public List<string> ParolTel = new List<string>() { "11111111","22222222","asdqwezxc" };
        public List<string> Mail = new List<string>() { "@anto.mail","masha@mail.com","rader@mail.com" };
        public string one_factor(string logo,string parol,List<string> Login,List<string> Parol)
        {
            string rezalt = "wrong login or password";
            for (int i = 0; i < Login.Count;i++)
            {
                if (Login[i].ToString() == logo.ToString() || Parol[i]==parol)
                {
                    rezalt = "Authorization was successful";
                    i = Login.Count + 3;
                }
                
            }
            return rezalt;
        }
        public string one_factor(string logo,List<string> Login)
        {

            string rezalt = "wrong login";
            for (int i = 0; i < Login.Count; i++)
            {
                if (Login[i].ToString() == logo.ToString())
                {
                    rezalt = "Authorization was successful";
                    i = Login.Count + 3;
                }

            }
            return rezalt;
        }

        public string Phone(string Tel,string parol)
        {
            
            string rezalt = one_factor(Tel,parol,NumberTel,ParolTel);
            if (rezalt == "Authorization was successful")
            {
                Random rnd = new Random();
                int SMS = rnd.Next(10000, 99999);
                return SMS.ToString();
            }
            else
            {
                return rezalt;
            }
        }
        public string Googl(string mail)
        {
            string rezalt= one_factor(mail, Mail);
            if (rezalt == "Authorization was successful")
            {
                Random rnd = new Random();
                int meseng = rnd.Next(10000, 99999);
                return meseng.ToString();
            }
            else
            {
                return rezalt;
            }
        }
        public string two_factor(string Code,string code)
        {
            if (Code == code)
            {
                return "Authorization was successful";
            }
            else
            {
                return "wrong authorization code";
            }
        }
        public void Vivod(int namber)
        {
            if (namber != 1 && namber != 2 && namber != 3)
            {
                try
                {
                    Console.Write("виберiть спосiб для авторизацiї:\n1)логiн i пароль\n2)спочатку логiн та пароль, потiм код СМС повiдомлення:\n3)Google\n:");
                    namber = Convert.ToInt32(Console.ReadLine());
                    Vivod(namber);
                }
                catch(Exception)
                {
                    Console.WriteLine("Вводiть 1 або 2 або 3");
                    Console.Write("виберiть спосiб для авторизацiї:\n1)логiн i пароль\n2)спочатку логiн та пароль, потiм код СМС повiдомлення:\n3)Google\n:");
                    namber = Convert.ToInt32(Console.ReadLine());
                    Vivod(namber);
                }
            }
            if (namber == 1)
            {
                Console.Write("Login:");
                string login = Console.ReadLine();
                Console.Write("Parol:");
                string parol = Console.ReadLine();
                Console.WriteLine(one_factor(login,parol,Login,Parol));
            }
            if(namber==2)
            {
                Console.Write("Phone number: ");
                string login = Console.ReadLine();
                Console.Write("Parol:");
                string parol = Console.ReadLine();
                string SMS = Phone(login, parol);
                Console.WriteLine(SMS);
                if (SMS != "wrong login or password")
                {
                    Console.Write("sms parol:");
                    string sms = Console.ReadLine();
                    Console.WriteLine(two_factor(SMS, sms));
                }
            }
            if (namber == 3)
            {
                Console.Write("Mail: ");
                string login = Console.ReadLine();
                string Meseng = Googl(login);
                Console.WriteLine(Meseng);
                if (Meseng != "wrong login")
                {
                    Console.Write("cod:");
                    string meseng = Console.ReadLine();
                    Console.WriteLine(two_factor(Meseng, meseng));
                }
            }
            Console.ReadLine();
        }
    }
}
