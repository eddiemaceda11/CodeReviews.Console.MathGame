namespace Mathgame
{
    public class Operation
    {
        public void PerformOperation(int operand1, int operand2, string operation, List<string> History)
        {
            switch (operation)
            {
                case "+":
                    Console.WriteLine(operand1 + operand2);
                    History.Add($"{operand1} + {operand2} = {operand1 + operand2}");
                    break;
                case "-":
                    Console.WriteLine(operand1 - operand2);
                    History.Add($"{operand1} - {operand2} = {operand1 - operand2}");
                    break;
                case "*":
                    Console.WriteLine(operand1 * operand2);
                    History.Add($"{operand1} * {operand2} = {operand1 * operand2}");
                    break;
                case "/":
                    if (operand1 % operand2 != 0)
                    {
                        Console.WriteLine("Invalid Division attempt");
                    }
                    else
                    {
                        Console.WriteLine(operand1 / operand2);
                        History.Add($"{operand1} / {operand2} = {operand1 / operand2}");
                    }
                    break;
                default:
                    Console.WriteLine("Not a valid operation");
                    break;
            }
        }
    }
}