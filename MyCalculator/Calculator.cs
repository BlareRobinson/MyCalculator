using System;

namespace MyCalculator
{
    public class Calculator
    {
        public Calculator()
        {
            string Input1_String, Input2_String, Operator;
            double Input1_Num, Input2_Num;
            double result = 0;

            Console.Write("Please enter your first number:");
            Input1_String = Console.ReadLine();
            Input1_Num = Convert.ToDouble(Input1_String);

            Console.Write("Please enter your second number:");
            Input2_String = Console.ReadLine();
            Input2_Num = Convert.ToDouble(Input2_String);

            Console.Write("Please enter operator you want to perform: (+,-,*,/):)");
            Operator = Console.ReadLine();

            result = Output(Operator, Input1_Num, Input2_Num, result);

            Console.WriteLine("{0} {1} {2} = {3}", Input1_Num, Operator, Input2_Num, result);
            Console.ReadLine();
        }

        public double Add(string Operator, double Input1_Num, double Input2_Num, double result)
        {
            result = Input1_Num + Input2_Num;
            return result;
        }

        public double Subtract(string Operator, double Input1_Num, double Input2_Num, double result)
        {
            result = Input1_Num - Input2_Num;
            return result;
        }

        public double Divide(string Operator, double Input1_Num, double Input2_Num, double result)
        {
            result = Input1_Num / Input2_Num;
            return result;
        }

        public double Multiply(string Operator, double Input1_Num, double Input2_Num, double result)
        {
            result = Input1_Num * Input2_Num;
            return result;
        }

        private static double Output(string Operator, double Input1_Num, double Input2_Num, double result)
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
