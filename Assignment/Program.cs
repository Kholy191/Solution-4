﻿using System;
using System.Text;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q13 Write a program to allow the user to enter a string and print the REVERSE of it.
            //string str;
            //str = Console.ReadLine() ?? "Default value";

            //StringBuilder Rstr;
            //Rstr = new StringBuilder();

            //for (int i = 0; i < str.Length; i++)
            //{
            //    Rstr.Append(str[str.Length - i - 1]);
            //}

            //Console.WriteLine(Rstr);
            #endregion

            #region Q14 Write a program to allow the user to enter int and print the REVERSED of it.
            //int Num = 0;
            //int.TryParse(Console.ReadLine(), out Num); // converted to int to avoid entering chars

            //int reversed = 0;

            //while (Num != 0)
            //{
            //    int Digit = Num % 10;
            //    reversed = reversed * 10 + Digit;
            //    Num = Num / 10;
            //}

            //Console.WriteLine(reversed);


            #endregion

            #region Q15 Write a program in C# Sharp to find prime numbers within a range of numbers.
            //int StartNum = 0;
            //int EndNum = 0;
            //Console.WriteLine("Input starting number of range:");
            //int.TryParse(Console.ReadLine(), out StartNum);
            //Console.WriteLine("Input ending number of range :");
            //int.TryParse(Console.ReadLine(), out EndNum);

            //for (int Num = StartNum; Num <= EndNum; Num++)
            //{
            //    Boolean Flag = true;
            //    for (int i = 2; i < Num; i++)
            //    {
            //        if ((Num % i) == 0)
            //        {
            //            Flag = false;
            //            break;
            //        }

            //        else
            //        {
            //            Flag = true;
            //        }
            //    }
            //    if (Flag == true && Num != 0 && Num != 1)
            //    {
            //        Console.WriteLine(Num);
            //    }
            //}
            #endregion

        }
    }
}
