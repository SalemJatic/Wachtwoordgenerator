using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wachtwoord_generator
{
    class Genereer
    {
        private static Random _rand;

        static Genereer()
        {

            _rand = new Random((int)DateTime.Now.Ticks);
        }

        public static string GetRandomWachtwoord(int WachtwoordLength, string template)
        {
            char[] wachtwoord = new char[WachtwoordLength];
            char[] chars = template.ToArray().OrderBy(s => (_rand.Next(2) % 2) == 0).ToArray();

            for (int i = 0; i < WachtwoordLength; i++)
            {
                wachtwoord[i] = chars[_rand.Next(0, chars.Length)];
            }
            return new string(wachtwoord);
        }

       
    }
}
