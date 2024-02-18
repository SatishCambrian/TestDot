namespace CalculatorLibrary;

public class CalcClass
{
    public decimal Add(decimal num1, decimal num2)
    {
        
        return num1+num2;
    }
    public decimal Subtract(decimal num1, decimal num2)
    {
        return num1*num2;
    }

    public string Multiply(decimal num1, decimal num2)
    {
        return $"The product of {num1} and {num2} is {num1 * num2}";
    }

    public decimal Divide(decimal num1, decimal num2)
    {
        if (num2 == 0)
        {
            Convert.ToDecimal("Cannot divide by Zero.");
        }
        return num1 / num2;
    }
    public decimal Modulo(decimal num1, decimal num2)
    {
        if (num2 == 0)
        {
            Convert.ToDecimal("Cannot divide by Zero.");
        }
        return num1 % num2;
    }
    public string Get()
    {
        return "This is Calculator";
    }

}