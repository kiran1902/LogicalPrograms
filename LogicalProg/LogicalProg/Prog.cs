using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace LogicalProg
{
    public class Prog
    {
        public void Test()
        {
            Console.WriteLine("Enter the number of Five Digits : ");
            int n = int.Parse(Console.ReadLine());
            int[] arrOfCoupons = new int[n];

            int countOfLoops=0,
                numOfCoupons = 0;

            while(numOfCoupons < n)
            {
                Random random = new Random();
                int result = random.Next(10000 , 100000);

                while (result == n)
                {
                    numOfCoupons++;
                    Console.WriteLine("Result Does not Exist");
                    n = arrOfCoupons[result];
                }
                countOfLoops++;
            }
            Console.WriteLine("The Number of coupouns is :", numOfCoupons);
            Console.WriteLine("The number of time loops was executed", countOfLoops);
        }

    }

           
}




