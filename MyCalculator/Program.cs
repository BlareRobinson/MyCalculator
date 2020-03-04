using System;
using static System.Console;
namespace MyCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            string Input1_String, Input2_String, Operator;
            int Input1_Num, Input2_Num;
            double result = 0;

            Console.Write("Please enter your number 1:");
            Input1_String = Console.ReadLine();
            Input1_Num = Convert.ToInt16(Input1_String);

            Console.Write("Please enter your number 2:");
            Input2_String = Console.ReadLine();
            Input2_Num = Convert.ToInt16(Input2_String);

            Console.Write("Please enter operator you want to perform: (+,-,*,/):)");
            Operator = Console.ReadLine();

            if (Operator == "+")
                result = Input1_Num + Input2_Num;
            else if (Operator == "-")
                result = Input1_Num - Input2_Num;

            else if (Operator == "/")
                result = (double)Input1_Num / Input2_Num;

            else if (Operator == "*") 
                result = Input1_Num * Input2_Num;

            Console.WriteLine("{0} {1} {2} = {3}", Input1_Num, Operator, Input2_Num, result);
            Console.ReadLine();

        }
    }
}
