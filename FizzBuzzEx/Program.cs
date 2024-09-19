using System;


namespace FizzBuzz
{




    class Program
    {
         static void Main(string[] args)
        {
            FizzBuzz();
        }

        public static void FizzBuzz()
        {
            Console.WriteLine("Chooes a number");
            int number = int.Parse(Console.ReadLine());
            if (number % 3 == 0 && number % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }


            // When the number is divisible by 3 return the word fizz
            if (number % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }

            else if (number % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }

            else
            {
                Console.WriteLine("False");
            }

          

        }




    }

}
