using System;
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

            #region Q16 Write a program in C# Sharp to convert a decimal number into binary without using an array.
            //int Num = 0;
            //Console.WriteLine("Enter a number to convert :");
            //int.TryParse(Console.ReadLine(), out Num);

            //StringBuilder sb = new StringBuilder();
            //int Power = 0;
            ////Finding Number of power of 2
            //while ((Math.Pow(2, Power)) < Num)
            //{
            //    Power++;
            //}
            //Power--;
            //sb.Append("1");
            //Num = Num - (int)Math.Pow(2, Power);
            //for (int i = (Power - 1); i >= 0; i--)
            //{
            //    if ((int)Math.Pow(2, i) <= Num)
            //    {
            //        sb.Append("1");
            //        Num = Num - (int)Math.Pow(2, i);
            //    }
            //    else
            //    {
            //        sb.Append("0");
            //    }
            //}

            //Console.WriteLine(sb);
            #endregion
        }
    }
}
