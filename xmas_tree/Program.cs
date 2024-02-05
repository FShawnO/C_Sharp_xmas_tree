using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace xmas_tree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = 9;
            for (int i = 0; i <= width / 2; i++)
            {
                int ubound = 2 * i + 1;
                int pading = width / 2 - i;
                int temp = pading + ubound;
                string star = "";
                //for (int j = 1; j <= ubound; j++)
                for (int j = 1; j <= temp; j++)
                {
                    if (j > pading) star += "*";
                    else star += " ";
                }
                //star = star.PadLeft(pading + ubound, ' ');
                Console.WriteLine(star);
            }
            Console.WriteLine();
        }
    }
}
