﻿using System;
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
}

}


