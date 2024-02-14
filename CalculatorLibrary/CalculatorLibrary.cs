namespace CalculatorLibrary;

public class CalcClass
{
    public string Add(decimal num1, decimal num2)
        {
            // String Interpolation
            return $"Sum of {num1} and {num2} is {num1+num2}.";
        }
        public string Subtract(decimal num1, decimal num2)
        {
            return $"Subtraction between {num1} and {num2} is {num1-num2}.";
        }

        public string Multiply(decimal num1, decimal num2)
        {
            return $"Multiplication of {num1} and {num2} is {num1*num2}.";
        }

        public string Divide(decimal num1, decimal num2)
        {
            if(num2==0){
                return "Cannot divide by Zero.";
            }
            return $"Division of {num1} by {num2} is {num1/num2}.";
        }
        public string Modulo(decimal num1, decimal num2)
        {
            if(num2==0){
                return "Cannot divide by Zero.";
            }
            return $"Remainder after Division of {num1} by {num2} is {num1%num2}.";
        }
        public string Get()
        {
            return "This is Calculator";
        }
    }
}
