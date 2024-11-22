namespace Mathgame
{
    public class Game
    {
        public List<string> History = new List<string>();
        public static int Score { get; set; }

        public void DisplayMenu()
        {
            Console.WriteLine("Choose one of the following operators: '+', '-', '*', '/', or enter 'History' to view your Game history.");
        }

        public void ShowHistory()
        {
            foreach (string item in History)
            {
                Console.WriteLine(item);
            }
        }

        public void PerformOperation(int operand1, int operand2, string operationType)
        {
            Operation operation = new Operation();
            operation.PerformOperation(operand1, operand2, operationType, this);
        }

        public static void UpdateScore()
        {
            Score++;
        }
    }
}