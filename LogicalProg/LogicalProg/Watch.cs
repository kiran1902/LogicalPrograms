using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProg
{
    public class Watch
    {
            public void Test()
            {
                Stopwatch stopwatch = new Stopwatch();

                //start stopwatch
                stopwatch.Start();

                //for loop
                for (int i = 0; i < 1000; i++)
                {
                    Thread.Sleep(1000);
                }
                stopwatch.Stop(); //stopping the stopwatch

                //output
                Console.WriteLine("Time Elapsed: {0}", stopwatch.Elapsed);
                Console.ReadLine();
            }
    }
}



