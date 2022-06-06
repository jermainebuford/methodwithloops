using System;

namespace methodswithloopsandconditonals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Print Thousand method");
            printThousand();


            Console.WriteLine("Check to see if number is even or odd: ");
            EvenOrOdd(2);
            Console.WriteLine("multiple of 3");
            Three();
            Console.WriteLine("Is 2 equal to 2");
            IsEqual(2, 2);
            Console.WriteLine("is it positive or Negative");
            PositiveOrNegative();
            Console.WriteLine("are you old enough to vote");
            vote()
        }
        public static void printThousand()
        {

            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }

        }
        public static void Three()
        {
            for (int j = 3; j <= 999; j += 3)
            {
                Console.WriteLine(j);
            }
        }
        public static void IsEqual(int a, int b)
        {
            if (a == b)
            {
                Console.WriteLine($"{a} is equal to {b}");
            }
            Console.WriteLine($"{a} is not equal to {b}");
        }
        public static void EvenOrOdd(int a)
        {
            if (a % 2 == 0)
            {
                Console.WriteLine($"{a} is even");
            }
            Console.WriteLine($"{a} is odd");
        }
        public static void PositiveOrNegative(int num);

            if (num > 0)
             
            Console.Writeline("{Num} is positive")
          
              else if (Num < 0)

              Console.WrtieLine("{num} is negative")
        
          




        public static void vote();
       
        

         

         

                  
        
       
    }
}
