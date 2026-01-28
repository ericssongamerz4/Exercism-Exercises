public class CalculationException : Exception
{
    public CalculationException(int operand1, int operand2, string message, Exception inner) : base(message, inner)
    {
        Operand1 = operand1;
        Operand2 = operand2;
    }
    public int Operand1 { get; }
    public int Operand2 { get; }
}

public class CalculatorTestHarness
{
    private Calculator calculator;
    public CalculatorTestHarness(Calculator calculator)
    {
        this.calculator = calculator;
    }

    public string TestMultiplication(int x, int y)
    {
        try
        {
            Multiply(x, y);
        }
        catch (CalculationException ex) when (ex.Message == "Multiply failed for negative operands. ")
        {
            return ex.Message + "Arithmetic operation resulted in an overflow.";

        }
        catch (CalculationException ex) when (ex.Message == $"Multiply failed for mixed or positive operands. ")
        {
            return ex.Message + "Arithmetic operation resulted in an overflow.";
        }
        catch (CalculationException ex)
        {
            return $"Multiply failed for mixed or positive operands. Arithmetic operation resulted in an overflow.";
        }

        return "Multiply succeeded";
    }

    public void Multiply(int x, int y)
    {
        try
        {
            if (x < 0 && y < 0)
                throw new CalculationException(x, y, $"Multiply failed for negative operands. ", new OverflowException());

            if ((x > 0 && y < 0) || (x < 0 && y > 0))
                throw new CalculationException(x, y, $"Multiply failed for mixed or positive operands. ", new OverflowException());

            calculator.Multiply(x, y);
        }
        catch (OverflowException ex)
        {
            throw new CalculationException(x, y, ex.Message, ex);
        }
    }
}

// Please do not modify the code below.
// If there is an overflow in the multiplication operation
// then a System.OverflowException is thrown.
public class Calculator
{
    public int Multiply(int x, int y)
    {
        checked
        {
            return x * y;
        }
    }
}

//Made by ericssonGamerz4
