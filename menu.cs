namespace MathGame
{
    internal class menu
    {
        GameEngine gameEngine = new();
        selectGame selectGame = new();

        internal void MainMenu(string name, DateTime date)
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"Hello {name.ToUpper()}");
            Console.WriteLine($"Today's date and time is {date}, I hope your day is going well!");

            bool isGameRunning = true;

            do
            {
                Console.WriteLine("What game would you like to play today? Select an option from the numbers below:\n" +
                "1. Addition\n" +
                "2. Subtraction\n" +
                "3. Multiplication\n" +
                "4. Division\n" +
                "5. View previous games\n" +
                "6. Quit the program");
                Console.WriteLine("-----------------------------------");
                selectGame.SelectGame();
            }
            while (isGameRunning);
        }
    }
}
