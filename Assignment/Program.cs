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

            #region Q17 Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3), and determines whether these points lie on a single straight line.
            //Console.WriteLine("Enter P1 Dimentions");
            //int.TryParse(Console.ReadLine(), out int X1);
            //int.TryParse(Console.ReadLine(), out int Y1);

            //Console.WriteLine("Enter P2 Dimentions");
            //int.TryParse(Console.ReadLine(), out int X2);
            //int.TryParse(Console.ReadLine(), out int Y2);

            //Console.WriteLine("Enter P3 Dimentions");
            //int.TryParse(Console.ReadLine(), out int X3);
            //int.TryParse(Console.ReadLine(), out int Y3);

            //double Slope1 = 0;
            //double Slope2 = 0;

            //if (X2 != X1)
            //{
            //    Slope1 = (Y2 - Y1) / (X2 - X1);
            //}
            //else
            //{
            //    Console.WriteLine("These points lie on a vertical straight line.");
            //}

            //if (X3 != X2)
            //{
            //    Slope2 = (Y3 - Y2) / (X3 - X2);
            //}
            //else
            //{
            //    Console.WriteLine("These points lie on a vertical straight line.");
            //}

            //if (Slope1 == Slope2 && (X3 != X2 && X2 != X1))
            //{
            //    Console.WriteLine("these points lie on a single straight line.");
            //}
            //else if (X3 != X2 && X2 != X1)
            //{
            //    Console.WriteLine("these points don't lie on a single straight line.");
            //}

            #endregion

            #region Q18 Title in comment (Too long)
            /**
             * Within a company, the efficiency of workers is evaluated based on the duration required to complete a specific task. A worker's efficiency level is determined as follows: 
                - If the worker completes the job within 2 to 3 hours, they are considered highly efficient. 
                - If the worker takes 3 to 4 hours, they are instructed to increase their speed. 
                - If the worker takes 4 to 5 hours, they are provided with training to enhance their speed. 
                - If the worker takes more than 5 hours, they are required to leave the company. 
               To calculate the efficiency of a worker, the time taken for the task is obtained via user input from the keyboard.
            */

            //Console.WriteLine("Enter the time taken to complete the task (in hours): ");

            //double.TryParse(Console.ReadLine(), out double taskTime);

            //if (taskTime >= 2 && taskTime <= 3)
            //{
            //    Console.WriteLine("The worker is highly efficient.");
            //}
            //else if (taskTime > 3 && taskTime <= 4)
            //{
            //    Console.WriteLine("The worker should increase their speed.");
            //}
            //else if (taskTime > 4 && taskTime <= 5)
            //{
            //    Console.WriteLine("The worker needs training to improve speed.");
            //}
            //else if (taskTime > 5)
            //{
            //    Console.WriteLine("The worker must leave the company.");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Time must be at least 2 hours.");
            //}
            #endregion
        }
    }
}
