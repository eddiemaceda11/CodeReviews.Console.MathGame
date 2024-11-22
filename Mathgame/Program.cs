using Mathgame;

Game game = new Game();
Random random = new Random();
int round = 1;

while (round <= 5)
{
  Console.WriteLine("Current Round: " + round);
  game.DisplayMenu();
  string? input = Console.ReadLine();

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
    round++;
  }
}

if (round > 5)
{
  Console.WriteLine("Final score: " + Game.Score);
}






