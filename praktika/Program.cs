using System;

namespace praktika
{
    internal class Program
    {
        static void Main2(string[] args)
        {
            int a = 1; 
            int b = 10;

            int sum = 0;
            for (int i = a;i <= b; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);
          
        }
        static void Main(string[] args)
        {
           int a = 1, b = 5;
            int sum = 0;
            for(int i = a;i <= b;i++)
            {
                sum = 21 / i;
                Console.WriteLine(sum);
                
            }

        }
    }
}
