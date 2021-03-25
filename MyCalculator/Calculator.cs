using System;
namespace MyCalculator
{
    public class Calculator
    {
        public Calculator()
        {
            string Input1_String, Input2_String, Operator;
            int Input1_Num, Input2_Num;
            double result = 0;

            Console.Write("Please enter your first number:");
            Input1_String = Console.ReadLine();
            Input1_Num = Convert.ToInt16(Input1_String);

            Console.Write("Please enter your second number:");
            Input2_String = Console.ReadLine();
            Input2_Num = Convert.ToInt16(Input2_String);

            Console.Write("Please enter operator you want to perform: (+,-,*,/):)");
            Operator = Console.ReadLine();

            result = Output(Operator, Input1_Num, Input2_Num, result);

            Console.WriteLine("{0} {1} {2} = {3}", Input1_Num, Operator, Input2_Num, result);
            Console.ReadLine();
        }

        private static double Output(string Operator, int Input1_Num, int Input2_Num, double result)
        {
            if (Operator == "+")
                result = Input1_Num + Input2_Num;
            else if (Operator == "-")
                result = Input1_Num - Input2_Num;

            else if (Operator == "/")
                result = (double)Input1_Num / Input2_Num;

            else if (Operator == "*")
                result = Input1_Num * Input2_Num;
            return result;
        }
    }

}
