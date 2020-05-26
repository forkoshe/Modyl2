using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul
{
    interface IAuthorization
    {
        string one_factor(string logo, string parol, List<string> Login, List<string> Parol);
        string one_factor(string logo, List<string> Login);
        string Phone(string Tel, string parol);
        string Googl(string mail);
        string two_factor(string Code, string code);
        void Vivod(int namber);
    }
}
