using System;
using System.Linq.Expressions;
using System.Text;
using System.Threading;


namespace MyCalculator
{
    public class Calculator
    {
        public string numberofCups { get; private set; }

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


            result = Add(Operator, Input1_Num, Input2_Num, result);
            result = Subtract(Operator, Input1_Num, Input2_Num, result);
            result = Divide(Operator, Input1_Num, Input2_Num, result);
            result = Multiply(Operator, Input1_Num, Input2_Num, result);


            Console.WriteLine("{0} {1} {2} = {3}", Input1_Num, Operator, Input2_Num, result + "\nHow many cups would you like to turn into ounces?");
            
        }


        public static double Add(string Operator, double Input1_Num, double Input2_Num, double result)
        {
            if (Operator == "+")
            {
                result = Input1_Num + Input2_Num;
            }

            return result;
        }

        public static double Subtract(string Operator, double Input1_Num, double Input2_Num, double result)
        {
            if (Operator == "-")
            {
                result = Input1_Num - Input2_Num;
            }

            return result;
        }

        public static double Divide(string Operator, double Input1_Num, double Input2_Num, double result)
        {
            if (Operator == "/")
            {
                result = Input1_Num / Input2_Num;
            }

            return result;
        }

        public static double Multiply(string Operator, double Input1_Num, double Input2_Num, double result)
        {
            if (Operator == "*")
            {
                result = Input1_Num * Input2_Num;
            }

            return result;
        }

        public static double ConvertCupsToOunces(double numberofCups)
        {
            double ouncesConverted = numberofCups * 8;
            return ouncesConverted;
        }

    }


}
