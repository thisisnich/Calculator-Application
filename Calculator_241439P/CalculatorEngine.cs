using System;

namespace Calculator_241439P
{
    /// <summary>
    /// Core calculation engine for the calculator application.
    /// This class contains pure calculation logic that can be tested independently.
    /// </summary>
    public static class CalculatorEngine
    {
        /// <summary>
        /// Performs basic arithmetic operations
        /// </summary>
        public static double PerformOperation(double operand1, double operand2, string operation)
        {
            return operation switch
            {
                "Add" => operand1 + operand2,
                "Subtract" => operand1 - operand2,
                "Multiply" => operand1 * operand2,
                "Divide" => operand2 == 0 ? throw new DivideByZeroException("Cannot divide by zero") : operand1 / operand2,
                "Power" => Math.Pow(operand1, operand2),
                _ => throw new ArgumentException($"Unknown operation: {operation}")
            };
        }

        /// <summary>
        /// Calculates square root
        /// </summary>
        public static double SquareRoot(double value)
        {
            if (value < 0)
                throw new ArgumentException("Cannot calculate square root of negative number");
            return Math.Sqrt(value);
        }

        /// <summary>
        /// Calculates square
        /// </summary>
        public static double Square(double value)
        {
            return value * value;
        }

        /// <summary>
        /// Calculates factorial
        /// </summary>
        public static double Factorial(int n)
        {
            if (n < 0)
                throw new ArgumentException("Factorial is not defined for negative numbers");
            if (n != Math.Floor((double)n))
                throw new ArgumentException("Factorial is only defined for integers");
            if (n > 170)
                throw new OverflowException("Factorial result too large");

            if (n == 0 || n == 1)
                return 1;

            double result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }

        /// <summary>
        /// Calculates logarithm base 10
        /// </summary>
        public static double Log10(double value)
        {
            if (value <= 0)
                throw new ArgumentException("Logarithm is not defined for non-positive numbers");
            return Math.Log10(value);
        }

        /// <summary>
        /// Calculates natural logarithm
        /// </summary>
        public static double Ln(double value)
        {
            if (value <= 0)
                throw new ArgumentException("Logarithm is not defined for non-positive numbers");
            return Math.Log(value);
        }

        /// <summary>
        /// Calculates sine
        /// </summary>
        public static double Sin(double angle, bool isDegreeMode)
        {
            double radians = isDegreeMode ? angle * Math.PI / 180.0 : angle;
            return Math.Sin(radians);
        }

        /// <summary>
        /// Calculates cosine
        /// </summary>
        public static double Cos(double angle, bool isDegreeMode)
        {
            double radians = isDegreeMode ? angle * Math.PI / 180.0 : angle;
            return Math.Cos(radians);
        }

        /// <summary>
        /// Calculates tangent
        /// </summary>
        public static double Tan(double angle, bool isDegreeMode)
        {
            double radians = isDegreeMode ? angle * Math.PI / 180.0 : angle;
            return Math.Tan(radians);
        }

        /// <summary>
        /// Calculates arcsine
        /// </summary>
        public static double ArcSin(double value, bool isDegreeMode)
        {
            if (value < -1 || value > 1)
                throw new ArgumentException("Arcsin input must be between -1 and 1");
            double result = Math.Asin(value);
            return isDegreeMode ? result * 180.0 / Math.PI : result;
        }

        /// <summary>
        /// Calculates arccosine
        /// </summary>
        public static double ArcCos(double value, bool isDegreeMode)
        {
            if (value < -1 || value > 1)
                throw new ArgumentException("Arccos input must be between -1 and 1");
            double result = Math.Acos(value);
            return isDegreeMode ? result * 180.0 / Math.PI : result;
        }

        /// <summary>
        /// Calculates arctangent
        /// </summary>
        public static double ArcTan(double value, bool isDegreeMode)
        {
            double result = Math.Atan(value);
            return isDegreeMode ? result * 180.0 / Math.PI : result;
        }

        /// <summary>
        /// Calculates reciprocal (1/x)
        /// </summary>
        public static double Reciprocal(double value)
        {
            if (value == 0)
                throw new DivideByZeroException("Cannot calculate reciprocal of zero");
            return 1.0 / value;
        }

        /// <summary>
        /// Calculates cube root
        /// </summary>
        public static double CubeRoot(double value)
        {
            if (value < 0)
                return -Math.Pow(-value, 1.0 / 3.0);
            return Math.Pow(value, 1.0 / 3.0);
        }

        /// <summary>
        /// Calculates nth root
        /// </summary>
        public static double NthRoot(double value, int rootOrder)
        {
            if (rootOrder <= 0)
                throw new ArgumentException("Root order must be positive");
            if (rootOrder % 2 == 0 && value < 0)
                throw new ArgumentException("Cannot calculate even root of negative number");

            if (value < 0)
                return -Math.Pow(-value, 1.0 / rootOrder);
            return Math.Pow(value, 1.0 / rootOrder);
        }

        /// <summary>
        /// Calculates percentage
        /// </summary>
        public static double CalculatePercentage(double baseValue, double percentage, string operation)
        {
            double percentageValue = percentage / 100.0;
            return operation switch
            {
                "Add" => baseValue + (baseValue * percentageValue),
                "Subtract" => baseValue - (baseValue * percentageValue),
                "Multiply" => baseValue * percentageValue,
                "Divide" => percentageValue == 0 ? throw new DivideByZeroException("Cannot divide by zero") : baseValue / percentageValue,
                _ => percentageValue
            };
        }

        /// <summary>
        /// Formats a number string, removing trailing zeros
        /// </summary>
        public static string FormatNumber(string numberStr)
        {
            if (string.IsNullOrEmpty(numberStr) || numberStr == "Error") 
                return numberStr;

            if (double.TryParse(numberStr, out double value))
            {
                if (numberStr.Contains('.'))
                {
                    numberStr = numberStr.TrimEnd('0').TrimEnd('.');
                    if (string.IsNullOrEmpty(numberStr)) 
                        numberStr = "0";
                }

                if (Math.Abs(value) >= 1000)
                {
                    return value.ToString("N0");
                }
                else if (Math.Abs(value) >= 1000000 || (Math.Abs(value) < 0.0001 && value != 0))
                {
                    return value.ToString("E6").Replace("E+0", "E+").Replace("E-0", "E-");
                }

                return numberStr;
            }
            return numberStr;
        }
    }
}

