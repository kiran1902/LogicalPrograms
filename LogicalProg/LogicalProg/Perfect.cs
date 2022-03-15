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
            int Reverse = 0;//Local Variable 

            //User Input
            Console.WriteLine("Enter a number to reverse");
            int Number = int.Parse(Console.ReadLine());
            
            //Conditional Statement
            while (Number > 0)
            {
                int remainder = Number % 10;
                Reverse = (Reverse * 10) + remainder;
                Number = Number / 10;
            }
            Console.WriteLine("Reversed number is {0}", + Reverse);
            Console.ReadLine();
        }
    }
}
 

