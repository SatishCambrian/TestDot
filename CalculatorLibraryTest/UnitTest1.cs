using CalculatorLibrary;

namespace calcLibraryTest;

[TestClass]
public class calcUnitTest
{
    CalcClass calc = new CalcClass();

    [TestInitialize]
    public void TestInit()
    {
        //reinitializes the calc field, 
        //ensuring a fresh instance of calcCL before each test.
        calc = new CalcClass();//
    }
    [TestMethod]
    public void Add_BothNumbersPositive_ReturnsPositive()
    {
        string result = calc.Add(1.0m, 2.0m);

        Assert.AreEqual("Sum of 1.0 and 2.0 is 3.", result);
    }

    public void Add_BothNumbersNegative_ReturnsNegative()
    {
        string result = calc.Add(-1.0m, -2.0m);

        Assert.AreEqual("Sum of -1.0 and -2.0 is -3.", result);
    }

    public void Add_ZeroWithOtherNumber_ReturnsOtherNumber()
    {
        string result = calc.Add(0, 2.0m);

        Assert.AreEqual("Sum of 0 and 2.0 is 2.", result);
    }

    public void Add_FirstNumberPositiveSecondNumberNegative_ReturnsResult()
    {
        string result = calc.Add(1.0m, -2.0m);
        Assert.AreEqual("Sum of 1.0 and -2.0 is -1.", result);
    }

    public void Add_FirstNumberLarge_ReturnsResult()
    {
        string result = calc.Add(1999999999999999999999999999.5m, 2.0m);
        Assert.AreEqual("Sum of 1999999999999999999999999999.5 and 2.0 is 200000000000000000000000000000.5.", result);

    }

    // Subtract Unit Test 
    [TestMethod]
    public void Subtract_FirstNumberBig_ReturnPositive()
    {
        decimal result = calc.Subtract(4.5m, 3.2m);


        Assert.IsTrue(result > 0, $"positive value- {result}");
    }

    [TestMethod]
    public void Subtract_BothNumbersNegative_ReturnsOppositeSignedResultBigNumber()
    {

        decimal result = calc.Subtract(-1m, -3m);
        decimal result1 = calc.Subtract(-5m, -2m);



        Assert.IsTrue(result > 0, $"Returns a positive value,  Result {result}");


        Assert.IsFalse(result1 > 0, $"Returns a negative value,  Result {result1}");
    }

    [TestMethod]
    public void Subtract_SecondNumberisBig_ReturnNegative()
    {
        decimal result = calc.Subtract(5m, 10m);

        Assert.IsTrue(result < 0, $"Expected a positive value,  Result {result}");

    }

    [TestMethod]
    public void Subtract_ResultIn_Fail()
    {
        decimal result = calc.Subtract(10m, 5m);

        Assert.IsFalse(result == 2m, $"Expected result different from 2---{result}");
    }
    [TestMethod]
    public void Subtract_IdenticalNumberSubtracted_ReturnZero()
    {
        decimal number = 9.5m;

        decimal result = calc.Subtract(number, number);


        Assert.AreEqual(0m, result);
    }

    /*  Multiply Unit test method */

    [TestMethod]
    public void Multiply_BothNumbersArePositive_ReturnPositiveResult()
    {
        decimal num1 = 2m;
        decimal num2 = 3m;

        decimal result = calc.Multiply(num1, num2);


        Assert.AreEqual(6m, result);
        Assert.IsTrue(result > 0, $"Expected a positive value,  Result {result}");
    }

    [TestMethod]
    public void Multiply_BothNumbersAreNegative_ReturnPositiveResult()
    {
        decimal num1 = -2m;
        decimal num2 = -3m;

        decimal result = calc.Multiply(num1, num2);

        Assert.AreEqual(6m, result);
        Assert.IsTrue(result > 0, $"Expected a positive value,  Result {result}");
    }

    [TestMethod]
    public void Multiply_OneNumberZero_ReturnZero()
    {

        decimal num1 = 0m;
        decimal num2 = 5.5m;

        decimal result1 = calc.Multiply(num1, num2);

        Assert.AreEqual(0m, result1);
    }

    [TestMethod]
    public void Multiply_FirstNumberPositiveAndSecondNegative_ReturnNegativeResult()
    {
        decimal num1 = 6m;
        decimal num2 = -5m;

        decimal result = calc.Multiply(num1, num2);

        Assert.AreEqual(-30m, result);
        Assert.IsTrue(result < 0);
    }

    [TestMethod]
    public void Multiply_NumbersLarge_ReturnResult()
    {
        decimal num1 = 2000000000000000000000000.6m;
        decimal num2 = 5m;

        decimal result = calc.Multiply(num1, num2);

        Assert.AreEqual(2000000000000000000000000m, result);
    }


    // Divide Unit test method

    [TestMethod]
    public void Divide_DivisionByPositiveNumber_ReturnPositiveResult()
    {
        decimal numerator = 20m;
        decimal denominator = 2m;

        decimal result = calc.Divide(denominator, numerator);

        Assert.AreEqual(10m, result);
        Assert.IsTrue(result > 0);
    }

    [TestMethod]
    public void Divide_DivisionByNegativeNumber_ReturnNegativeResult()
    {
        decimal numerator = 18m;
        decimal denominator = -6m;

        decimal result = calc.Divide(denominator, numerator);

        Assert.AreEqual(-3m, result);
        Assert.IsTrue(result < 0);
    }

    [TestMethod]
    public void Divide_DivisionLargeNumberBySmallNumber_ReturnVeryLargeResult()
    {
        decimal numerator = 88888888888888.9m;
        decimal denominator = 0.1m;

        decimal result = calc.Divide(denominator, numerator);

        Assert.AreEqual(88888888888888m, result);
    }
    [TestMethod]
    public void Divide_DivisionByZero_Throw_DivideByZeroException()
    {
        decimal numerator = 8m;
        decimal denominator = 0m;

        Assert.ThrowsException<DivideByZeroException>(() => calc.Divide(denominator, numerator));
    }

    [TestMethod]
    public void Divide_Division_ZeroByAnyNumber_ReturnZero()
    {
        decimal numerator = 0m;
        decimal denominator = 7m;

        decimal result = calc.Divide(denominator, numerator);

        // Assert result is Zero => 0 / 7 = 0
        Assert.AreEqual(0m, result);
    }


}

