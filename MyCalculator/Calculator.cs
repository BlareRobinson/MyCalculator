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

            Console.Write("Which would you like to do, calculate, convert or exit?");
            var option = Console.ReadLine();

            if (option.ToLower() == "calculate")
            {
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


                Console.WriteLine("{0} {1} {2} = {3}", Input1_Num, Operator, Input2_Num, result);
                Console.ReadLine();
            }
            else
            {
                Console.Write("Which would you like to do, calculate, convert or exit?");
                Console.ReadLine();
            }

            if (option.ToLower() == "convert")
            {
                Console.Write("How many cups would you like to convert to ounces?");
                var cupsToConvertString = Console.ReadLine();
                var cupsToConvertDouble = Convert.ToDouble(cupsToConvertString);
                result = ConvertCupsToOunces(cupsToConvertDouble);
                Console.WriteLine(result);

            }

            if (option.ToLower() == "exit")
                {
                Console.Write("Goodbye!");
                Environment.Exit(0);

                }
        }



            static double Add(string Operator, double Input1_Num, double Input2_Num, double result)
            {
                if (Operator == "+")
                {
                    result = Input1_Num + Input2_Num;
                }

                return result;

            }

            static double Subtract(string Operator, double Input1_Num, double Input2_Num, double result)
            {
                if (Operator == "-")
                {
                    result = Input1_Num - Input2_Num;
                }

                return result;
            }

            static double Divide(string Operator, double Input1_Num, double Input2_Num, double result)
            {
                if (Operator == "/")
                {
                    result = Input1_Num / Input2_Num;
                }

                return result;
            }

            static double Multiply(string Operator, double Input1_Num, double Input2_Num, double result)
            {
                if (Operator == "*")
                {
                    result = Input1_Num * Input2_Num;
                }

                return result;
            }

        static double ConvertCupsToOunces(double numberofCups)
        {
            double ouncesConverted = numberofCups * 8;
            return ouncesConverted;
        }



    }


    }
