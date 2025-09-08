namespace Exercism_Exercises.Exercises.CalculatorConundrum
{
    public static class SimpleCalculator
    {
        public static string Calculate(int operand1, int operand2, string? operation)
        {
            string calculationHistory = $"{operand1} {operation} {operand2} = ";

            switch (operation)
            {
                case "+":
                    return calculationHistory + SimpleOperation.Addition(operand1, operand2).ToString();

                case "*":
                    return calculationHistory + SimpleOperation.Multiplication(operand1, operand2).ToString();

                case "/":
                    if (operand2 == 0)
                        return "Division by zero is not allowed.";
                    else
                        return calculationHistory +  SimpleOperation.Division(operand1, operand2).ToString();

                case "":
                    throw new ArgumentException(nameof(operation));

                case null:
                    throw new ArgumentNullException(nameof(operation));

                default:
                    throw new ArgumentOutOfRangeException(nameof(operation));

            }
        }
    }

    public static class SimpleOperation
    {
        public static int Division(int operand1, int operand2)
        { 
            return operand1 / operand2;
        }

        public static int Multiplication(int operand1, int operand2)
        {
            return operand1 * operand2;
        }

        public static int Addition(int operand1, int operand2)
        {
            return operand1 + operand2;
        }
    }
}
