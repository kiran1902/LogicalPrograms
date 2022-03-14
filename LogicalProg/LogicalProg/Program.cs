namespace LogicalProg
{
    class Fibonacci
    {
        static void Main(String[] args)
        {
            //local variables
            int a = 0;
            int b = 1;
            int c;

            Console.WriteLine("Enter The Number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.Write(a + " " + b + " "); //printing 0 and 1

            //for loop
            for (int i = 0; i < number; i++)
            {
                c = a + b;
                Console.WriteLine(c);

                //swapping a and b
                a = b;
                b = c;
            }
            Console.ReadLine();
        }
    }
}