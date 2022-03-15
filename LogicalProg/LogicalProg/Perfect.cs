using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProg
{
    class Perfect
    {
        public void Test()
        {
            int num = 0, flag = 0; //local variables

            //user input
            Console.Write("Enter the Number to check Prime: ");
            int n = int.Parse(Console.ReadLine());
            num = n / 2;

            //for loop
            for (int i = 2; i <= num; i++)
            {
                if (n % i == 0)
                {
                    Console.Write(n + " is not Prime Number");
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
                Console.Write(n + " is Prime Number.");
        }
    }
}

