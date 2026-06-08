using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp
{
    internal class U_New_Words
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine().ToLower();

            int e = 0, g = 0, y = 0, p = 0, t = 0;

            foreach (char ch in s)
            {
                if (ch == 'e') e++;
                else if (ch == 'g') g++;
                else if (ch == 'y') y++;
                else if (ch == 'p') p++;
                else if (ch == 't') t++;
            }

            int[] counts = { e, g, y, p, t };
            int result = counts.Min();

            Console.WriteLine(result);
        }
    }
}
