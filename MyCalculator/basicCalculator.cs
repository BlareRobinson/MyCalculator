using System;
namespace MyCalculator
{
    public class basicCalculator : Calculator
    {
        public basicCalculator()
        {
            string Input1_String, Input2_String, Operator;
            int Input1_Num, Input2_Num;
            int result = 0;

            Console.Write("Please enter your first number:");
            Input1_String = Console.ReadLine();
            Input1_Num = Convert.ToInt32(Input1_String);

            Console.Write("Please enter your second number:");
            Input2_String = Console.ReadLine();
            Input2_Num = Convert.ToInt32(Input2_String);

            Console.Write("Please enter operator you want to perform: (+,-,*,/):)");
            Operator = Console.ReadLine();


            result = Add(Operator, Input1_Num, Input2_Num, result);
            result = Subtract(Operator, Input1_Num, Input2_Num, result);
            result = Divide(Operator, Input1_Num, Input2_Num, result);
            result = Multiply(Operator, Input1_Num, Input2_Num, result);

            Console.WriteLine("{0} {1} {2} = {3}", Input1_Num, Operator, Input2_Num, result);
            Console.ReadLine();
        }

        public static int Add(string Operator, int Input1_Num, int Input2_Num, int result)
        {
            if (Operator == "+")
            {
                result = Input1_Num + Input2_Num;
            }

            return result;
        }

        public static int Subtract(string Operator, int Input1_Num, int Input2_Num, int result)
        {
            if (Operator == "-")
            {
                result = Input1_Num - Input2_Num;
            }

            return result;
        }

        public static int Divide(string Operator, int Input1_Num, int Input2_Num, int result)
        {
            if (Operator == "/")
            {
                result = Input1_Num / Input2_Num;
            }

            return result;
        }

        public static int Multiply(string Operator, int Input1_Num, int Input2_Num, int result)
        {
            if (Operator == "*")
            {
                result = Input1_Num * Input2_Num;
            }

            return result;
        }


    }
}

