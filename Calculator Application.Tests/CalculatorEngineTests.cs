using Calculator_Application;
using Xunit;

namespace Calculator_Application.Tests
{
    public class CalculatorEngineTests
    {
        #region Basic Arithmetic Tests

        [Theory]
        [InlineData(5, 3, "Add", 8)]
        [InlineData(-5, 3, "Add", -2)]
        [InlineData(0, 0, "Add", 0)]
        [InlineData(1.5, 2.5, "Add", 4.0)]
        public void PerformOperation_Add_ReturnsCorrectResult(double op1, double op2, string op, double expected)
        {
            double result = CalculatorEngine.PerformOperation(op1, op2, op);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(5, 3, "Subtract", 2)]
        [InlineData(-5, 3, "Subtract", -8)]
        [InlineData(0, 0, "Subtract", 0)]
        [InlineData(1.5, 2.5, "Subtract", -1.0)]
        public void PerformOperation_Subtract_ReturnsCorrectResult(double op1, double op2, string op, double expected)
        {
            double result = CalculatorEngine.PerformOperation(op1, op2, op);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(5, 3, "Multiply", 15)]
        [InlineData(-5, 3, "Multiply", -15)]
        [InlineData(0, 5, "Multiply", 0)]
        [InlineData(1.5, 2.0, "Multiply", 3.0)]
        public void PerformOperation_Multiply_ReturnsCorrectResult(double op1, double op2, string op, double expected)
        {
            double result = CalculatorEngine.PerformOperation(op1, op2, op);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(6, 3, "Divide", 2)]
        [InlineData(-6, 3, "Divide", -2)]
        [InlineData(1.5, 0.5, "Divide", 3.0)]
        [InlineData(5, 2, "Divide", 2.5)]
        public void PerformOperation_Divide_ReturnsCorrectResult(double op1, double op2, string op, double expected)
        {
            double result = CalculatorEngine.PerformOperation(op1, op2, op);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void PerformOperation_DivideByZero_ThrowsDivideByZeroException()
        {
            Assert.Throws<DivideByZeroException>(() => CalculatorEngine.PerformOperation(5, 0, "Divide"));
        }

        [Theory]
        [InlineData(2, 3, "Power", 8)]
        [InlineData(2, 0, "Power", 1)]
        [InlineData(2, -1, "Power", 0.5)]
        [InlineData(4, 0.5, "Power", 2)]
        public void PerformOperation_Power_ReturnsCorrectResult(double op1, double op2, string op, double expected)
        {
            double result = CalculatorEngine.PerformOperation(op1, op2, op);
            Assert.Equal(expected, result, 10);
        }

        [Fact]
        public void PerformOperation_UnknownOperation_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => CalculatorEngine.PerformOperation(5, 3, "Unknown"));
        }

        #endregion

        #region Square Root Tests

        [Theory]
        [InlineData(4, 2)]
        [InlineData(9, 3)]
        [InlineData(16, 4)]
        [InlineData(0, 0)]
        [InlineData(2.25, 1.5)]
        public void SquareRoot_ValidInput_ReturnsCorrectResult(double value, double expected)
        {
            double result = CalculatorEngine.SquareRoot(value);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void SquareRoot_NegativeInput_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => CalculatorEngine.SquareRoot(-1));
        }

        #endregion

        #region Square Tests

        [Theory]
        [InlineData(2, 4)]
        [InlineData(-3, 9)]
        [InlineData(0, 0)]
        [InlineData(1.5, 2.25)]
        public void Square_ValidInput_ReturnsCorrectResult(double value, double expected)
        {
            double result = CalculatorEngine.Square(value);
            Assert.Equal(expected, result);
        }

        #endregion

        #region Factorial Tests

        [Theory]
        [InlineData(0, 1)]
        [InlineData(1, 1)]
        [InlineData(2, 2)]
        [InlineData(3, 6)]
        [InlineData(4, 24)]
        [InlineData(5, 120)]
        [InlineData(10, 3628800)]
        public void Factorial_ValidInput_ReturnsCorrectResult(int n, double expected)
        {
            double result = CalculatorEngine.Factorial(n);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Factorial_NegativeInput_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => CalculatorEngine.Factorial(-1));
        }

        [Fact]
        public void Factorial_TooLarge_ThrowsOverflowException()
        {
            Assert.Throws<OverflowException>(() => CalculatorEngine.Factorial(171));
        }

        #endregion

        #region Logarithm Tests

        [Theory]
        [InlineData(1, 0)]
        [InlineData(10, 1)]
        [InlineData(100, 2)]
        [InlineData(1000, 3)]
        public void Log10_ValidInput_ReturnsCorrectResult(double value, double expected)
        {
            double result = CalculatorEngine.Log10(value);
            Assert.Equal(expected, result, 10);
        }

        [Fact]
        public void Log10_ZeroOrNegative_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => CalculatorEngine.Log10(0));
            Assert.Throws<ArgumentException>(() => CalculatorEngine.Log10(-1));
        }

        [Theory]
        [InlineData(Math.E, 1)]
        [InlineData(1, 0)]
        public void Ln_ValidInput_ReturnsCorrectResult(double value, double expected)
        {
            double result = CalculatorEngine.Ln(value);
            Assert.Equal(expected, result, 10);
        }

        [Fact]
        public void Ln_ZeroOrNegative_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => CalculatorEngine.Ln(0));
            Assert.Throws<ArgumentException>(() => CalculatorEngine.Ln(-1));
        }

        #endregion

        #region Trigonometric Tests

        [Theory]
        [InlineData(0, false, 0)]
        [InlineData(Math.PI / 2, false, 1)]
        [InlineData(Math.PI, false, 0)]
        [InlineData(30, true, 0.5)]
        [InlineData(90, true, 1)]
        public void Sin_ValidInput_ReturnsCorrectResult(double angle, bool isDegree, double expected)
        {
            double result = CalculatorEngine.Sin(angle, isDegree);
            Assert.Equal(expected, result, 5);
        }

        [Theory]
        [InlineData(0, false, 1)]
        [InlineData(Math.PI / 2, false, 0)]
        [InlineData(Math.PI, false, -1)]
        [InlineData(60, true, 0.5)]
        [InlineData(0, true, 1)]
        public void Cos_ValidInput_ReturnsCorrectResult(double angle, bool isDegree, double expected)
        {
            double result = CalculatorEngine.Cos(angle, isDegree);
            Assert.Equal(expected, result, 5);
        }

        [Theory]
        [InlineData(0, false, 0)]
        [InlineData(Math.PI / 4, false, 1)]
        [InlineData(45, true, 1)]
        public void Tan_ValidInput_ReturnsCorrectResult(double angle, bool isDegree, double expected)
        {
            double result = CalculatorEngine.Tan(angle, isDegree);
            Assert.Equal(expected, result, 5);
        }

        [Theory]
        [InlineData(0, false, 0)]
        [InlineData(1, false, Math.PI / 2)]
        [InlineData(0.5, true, 30)]
        public void ArcSin_ValidInput_ReturnsCorrectResult(double value, bool isDegree, double expected)
        {
            double result = CalculatorEngine.ArcSin(value, isDegree);
            Assert.Equal(expected, result, 5);
        }

        [Fact]
        public void ArcSin_OutOfRange_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => CalculatorEngine.ArcSin(2, false));
            Assert.Throws<ArgumentException>(() => CalculatorEngine.ArcSin(-2, false));
        }

        [Theory]
        [InlineData(1, false, 0)]
        [InlineData(0, false, Math.PI / 2)]
        [InlineData(0.5, true, 60)]
        public void ArcCos_ValidInput_ReturnsCorrectResult(double value, bool isDegree, double expected)
        {
            double result = CalculatorEngine.ArcCos(value, isDegree);
            Assert.Equal(expected, result, 5);
        }

        [Fact]
        public void ArcCos_OutOfRange_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => CalculatorEngine.ArcCos(2, false));
        }

        [Theory]
        [InlineData(0, false, 0)]
        [InlineData(1, false, Math.PI / 4)]
        [InlineData(1, true, 45)]
        public void ArcTan_ValidInput_ReturnsCorrectResult(double value, bool isDegree, double expected)
        {
            double result = CalculatorEngine.ArcTan(value, isDegree);
            Assert.Equal(expected, result, 5);
        }

        #endregion

        #region Reciprocal Tests

        [Theory]
        [InlineData(2, 0.5)]
        [InlineData(4, 0.25)]
        [InlineData(-2, -0.5)]
        [InlineData(0.5, 2)]
        public void Reciprocal_ValidInput_ReturnsCorrectResult(double value, double expected)
        {
            double result = CalculatorEngine.Reciprocal(value);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Reciprocal_Zero_ThrowsDivideByZeroException()
        {
            Assert.Throws<DivideByZeroException>(() => CalculatorEngine.Reciprocal(0));
        }

        #endregion

        #region Root Tests

        [Theory]
        [InlineData(8, 2)]
        [InlineData(27, 3)]
        [InlineData(-8, -2)]
        [InlineData(0, 0)]
        public void CubeRoot_ValidInput_ReturnsCorrectResult(double value, double expected)
        {
            double result = CalculatorEngine.CubeRoot(value);
            Assert.Equal(expected, result, 5);
        }

        [Theory]
        [InlineData(16, 4, 2)]
        [InlineData(27, 3, 3)]
        [InlineData(81, 3, 4)]
        [InlineData(32, 2, 5)]
        public void NthRoot_ValidInput_ReturnsCorrectResult(double value, double expected, int rootOrder)
        {
            double result = CalculatorEngine.NthRoot(value, rootOrder);
            Assert.Equal(expected, result, 5);
        }

        [Fact]
        public void NthRoot_InvalidOrder_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => CalculatorEngine.NthRoot(16, 0));
            Assert.Throws<ArgumentException>(() => CalculatorEngine.NthRoot(16, -1));
        }

        [Fact]
        public void NthRoot_EvenRootOfNegative_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => CalculatorEngine.NthRoot(-16, 2));
        }

        #endregion

        #region Percentage Tests

        [Theory]
        [InlineData(100, 10, "Add", 110)]
        [InlineData(100, 10, "Subtract", 90)]
        [InlineData(100, 10, "Multiply", 10)]
        [InlineData(100, 10, "Divide", 1000)]
        public void CalculatePercentage_ValidInput_ReturnsCorrectResult(double baseValue, double percentage, string operation, double expected)
        {
            double result = CalculatorEngine.CalculatePercentage(baseValue, percentage, operation);
            Assert.Equal(expected, result);
        }

        #endregion

        #region Format Number Tests

        [Theory]
        [InlineData("5.0", "5")]
        [InlineData("5.00", "5")]
        [InlineData("0.0", "0")]
        [InlineData("123.456", "123.456")]
        [InlineData("1000", "1,000")]
        [InlineData("1000000", "1,000,000")]
        [InlineData("0.00001", "1.000000E-05")]
        public void FormatNumber_ValidInput_ReturnsFormattedResult(string input, string expected)
        {
            string result = CalculatorEngine.FormatNumber(input);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("Error", "Error")]
        [InlineData("", "")]
        [InlineData(null, null)]
        public void FormatNumber_InvalidInput_ReturnsOriginal(string input, string expected)
        {
            string result = CalculatorEngine.FormatNumber(input);
            Assert.Equal(expected, result);
        }

        #endregion
    }
}

