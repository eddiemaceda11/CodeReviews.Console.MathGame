namespace Mathgame
{
    public class Operation
    {
        public void CheckAnswer(int gameAnswer)
        {
            Console.WriteLine("Enter your answer: ");
            int? answer = Convert.ToInt32(Console.ReadLine());

            if (answer == gameAnswer)
            {
                Console.WriteLine("Your answer was correct! Press a key to play the next round");
                Game.UpdateScore();
                Console.WriteLine("Score: " + Game.Score);
            }
            else
            {
                Console.WriteLine("You answer was incorrect");
                Console.WriteLine("Score: " + Game.Score);
            }

        }
        public void PerformOperation(int operand1, int operand2, string operation, Game game)
        {
            switch (operation)
            {
                case "+":
                    Console.WriteLine($"{operand1} + {operand2}");
                    CheckAnswer(operand1 + operand2);
                    game.History.Add($"{operand1} + {operand2} = {operand1 + operand2}");
                    break;
                case "-":
                    Console.WriteLine($"{operand1} - {operand2}");
                    CheckAnswer(operand1 - operand2);
                    game.History.Add($"{operand1} - {operand2} = {operand1 - operand2}");
                    break;
                case "*":
                    Console.WriteLine($"{operand1} * {operand2}");
                    CheckAnswer(operand1 * operand2);
                    game.History.Add($"{operand1} * {operand2} = {operand1 * operand2}");
                    break;
                case "/":
                    Random random = new Random();
                    int divOperand2 = random.Next(1, 11);
                    int divOperand1 = divOperand2 * random.Next(0, 101 / divOperand2);
                    int result = divOperand1 / divOperand2;

                    Console.WriteLine($"{divOperand1} / {divOperand2}");
                    CheckAnswer(result);
                    game.History.Add($"{divOperand1} / {divOperand2} = {result}");
                    break;
                default:
                    Console.WriteLine("Not a valid operation");
                    break;
            }
        }
    }
}