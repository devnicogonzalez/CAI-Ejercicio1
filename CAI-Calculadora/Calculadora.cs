using System;
namespace CAICalculadora
{
    public class Calculadora
    {

        public static double Operar(double num1, double num2, string op)
        {
            double result = double.NaN;

            switch (op)
            {
                case "s":
                    result = num1 + num2;
                    break;
                case "r":
                    result = num1 - num2;
                    break;
                case "m":
                    result = num1 * num2;
                    break;
                case "d":
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    break;
                default:
                    break;
            }
            return result;
        }

    }
}
