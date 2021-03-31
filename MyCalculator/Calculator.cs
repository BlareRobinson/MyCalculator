using System;
using System.Linq.Expressions;


namespace MyCalculator
{
    public class Calculator
    {
        

        public Calculator()
        {
            string Input1_String, Input2_String, Operator, ouncesConverted;
            double Input1_Num, Input2_Num;
            double result = 0;
            double numberOfCups = 0;


            Console.Write("Please enter your first number:");
            Input1_String = Console.ReadLine();
            Input1_Num = Convert.ToDouble(Input1_String);

            Console.Write("Please enter your second number:");
            Input2_String = Console.ReadLine();
            Input2_Num = Convert.ToDouble(Input2_String);

            Console.Write("Please enter operator you want to perform: (+,-,*,/):)");
            Operator = Console.ReadLine();

            Console.WriteLine("How many cups would you like to convert into ounces?");
            ouncesConverted = Console.ReadLine();



            result = Add(Operator, Input1_Num, Input2_Num, result);
            result = Subtract(Operator, Input1_Num, Input2_Num, result);
            result = Divide(Operator, Input1_Num, Input2_Num, result);
            result = Multiply(Operator, Input1_Num, Input2_Num, result);     
            result = Conversion(numberOfCups);



            Console.WriteLine("{0} {1} {2} = {3}", Input1_Num, Operator, Input2_Num, result);
            Console.ReadLine();

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

        public static double Conversion(double numberOfCups)
        {
            double ouncesConverted = numberOfCups * 8;
            return ouncesConverted;
        }

    }


}
