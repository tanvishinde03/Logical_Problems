using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Problems
{
    public class Logical_Problems
    {
        public void CheckEvenOrOdd()
        {
            int Number;
            Console.Write("Enter The Number: ");
            Number = int.Parse(Console.ReadLine());
            if (Number % 2 == 0)
            {
                Console.Write("Entered Number is an Even Number");
            }
            else
            {
                Console.Write("Entered Number is an Odd Number");
            }
            Console.Read();
        }

        public void  SwapNumber()
    {
        int num1, num2, temp;

        Console.WriteLine("Enter first number");
        num1 = 100;
        Console.ReadLine();

        Console.WriteLine("Enter second number");

        num2 = 200;
        Console.ReadLine();

        Console.WriteLine("Values before swapping: num1=" + num1 + " and num2=" + num2);

        temp = num1;

        num1 = num2;

        num2 = temp;

        Console.WriteLine("Values after swapping: num1=" + num1 + " and num2=" + num2);



        Console.ReadLine();
    }
        public void CheckLargestNumber()
        {
            int num1, num2;

            Console.WriteLine("Find the largest of two numbers:");
            Console.WriteLine("Input the 1st number :");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the  2nd number :");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
              Console.WriteLine("The 1st Number is the greatest among two.");
             }
             else
                {
                 Console.WriteLine("The 2rd Number is the greatest among two.");
                }
            }
        public void ReverseNumber()
        {
            int n, reverse = 0, rem;
            Console.WriteLine("Enter a number");
            n = Convert.ToInt32(Console.ReadLine());

            while (n != 0)
            {
                rem = n % 10;
                reverse = reverse * 10 + rem;
                n = n / 10;
            }
            Console.WriteLine("Reversed Number " + reverse);
        }

        public void CheckPositiveorNegative()
        { 
        Console.WriteLine("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number > 0)
        {
            Console.WriteLine("Number is positive");
        }
        else
        {
        Console.WriteLine("Number is negative");
        }
        Console.ReadLine();
    }
        public void PrintOddNumber()
        {
            Console.WriteLine("Odd numbers from 1 to 99 are.");
            for (int n = 1; n < (99 + 1); n++)
            {
                if (n % 2 != 0)
                {
                    Console.WriteLine(n.ToString());
                }
            }
        }
       public void DivisibleBy2()
        {
            int num;
            Console.WriteLine("Enter a number: ");
            num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("Divisible by 2 ");
            }
            else
            {
                Console.WriteLine("Not divisible by 2");
            }
            Console.ReadLine();
        }
        public void CheckSumDigit()
        {
            int n, sum = 0, m;
            Console.Write("Enter a number: ");
            n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                m = n % 10;
                sum = sum + m;
                n = n / 10;
            }
            Console.Write("Sum is= " + sum);
        }
        public void FindMultiplesOf3And5(int n)
        {

            int sum =0;
            for (int i = 0; i < n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    sum +=i;
            }
            Console.WriteLine("Sum of multiples of 3 and 5 are: " + sum);
            Console.ReadLine();
        }
    }
}
    


    
    






