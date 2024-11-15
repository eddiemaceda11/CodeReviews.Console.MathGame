using Mathgame;

Game game = new Game();
Random random = new Random();

while (true)
{
  game.DisplayMenu();
  game.DisplayMenu(); string? input = Console.ReadLine();

  int firstNumber = random.Next(0, 100);
  int secondNumber = random.Next(0, 100);

  if (input == "History")
  {
    game.ShowHistory();
    continue;
  }

  if (input != null)
  {
    game.PerformOperation(firstNumber, secondNumber, input);
  }
}






