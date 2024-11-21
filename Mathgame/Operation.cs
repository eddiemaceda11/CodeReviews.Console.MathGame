namespace Mathgame
{
    public class Operation
    {
        public void checkAnswer(int gameAnswer)
        {
            Console.WriteLine("Enter your answer: ");
            int? answer = Convert.ToInt32(Console.ReadLine());

            if (answer == gameAnswer)
            {
                Console.WriteLine("Your answer was correct! Press a key to play the next round");
                Game.UpdateScore();
                Console.WriteLine("Score from checkAnswer is: " + Game.Score);
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
                    checkAnswer(operand1 + operand2);
                    game.History.Add($"{operand1} + {operand2} = {operand1 + operand2}");
                    break;
                case "-":
                    Console.WriteLine($"{operand1} - {operand2}");
                    checkAnswer(operand1 - operand2);
                    game.History.Add($"{operand1} - {operand2} = {operand1 - operand2}");
                    break;
                case "*":
                    Console.WriteLine($"{operand1} * {operand2}");
                    checkAnswer(operand1 * operand2);
                    game.History.Add($"{operand1} * {operand2} = {operand1 * operand2}");
                    break;
                case "/":
                    if (operand1 % operand2 != 0)
                    {
                        Console.WriteLine("Invalid Division attempt");
                    }
                    else
                    {
                        Console.WriteLine($"{operand1} / {operand2}");
                        checkAnswer(operand1 / operand2);
                        game.History.Add($"{operand1} / {operand2} = {operand1 / operand2}");
                    }
                    break;
                default:
                    Console.WriteLine("Not a valid operation");
                    break;
            }
        }
    }
}