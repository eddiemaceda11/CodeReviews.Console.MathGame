namespace Mathgame
{
    public class Game
    {
        List<string> History = new List<string>();

        public void DisplayMenu()
        {
            Console.WriteLine("Choose one of the following operators: '+', '-', '*', '/', or enter 'History' to view history.");
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
            operation.PerformOperation(operand1, operand2, operationType, History);
        }
    }
}