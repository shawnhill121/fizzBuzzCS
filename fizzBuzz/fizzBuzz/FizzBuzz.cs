using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzApplication
{
    class FizzBuzz
    {
        public void RunFizzBuzz()
        {
            for (int count = 1; count <= 100; count++)
            {
                if (count % 3 == 0 && count % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz!!!");
                }
                else if (count % 3 == 0)
                {
                    Console.WriteLine("Fizz!");
                }
                else if (count % 5 == 0)
                {
                    Console.WriteLine("Buzz!");
                }
                else
                {
                    Console.WriteLine($"{count}");
                }
            }
        }
    }
}
