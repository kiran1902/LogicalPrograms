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
            {
                int n, sum = 0; //Declaring Variables
                Console.Write("Enter the Number : ");
                int number = int.Parse(Console.ReadLine());
                n = number;
                
                //for loop
                for (int i = 1; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        sum = sum + i;
                    }
                }
                if (sum == n)
                {
                    Console.WriteLine(number + "  is a perfect number");
                }
                else
                {
                    Console.WriteLine(number + " is not a perfect number");
                }
                Console.ReadLine();
            }
        }
    }
}
