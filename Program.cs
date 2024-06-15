using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops__for__while_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //For Loop
            int num = 10;
            for (int i = 0; i <num; i++) 
            {
                Console.WriteLine(i);
            }
            //While Loop
            int num1 = 1;
            while (num1 < 10) 
            {
                Console.WriteLine(num1);
                num1++;
            }

        }
    }
}
