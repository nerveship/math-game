namespace MathGame
{
    internal class selectGame
    {
        GameEngine gameEngine = new();
        internal void SelectGame()
        {
            int gameSelected;
            string userInput = Console.ReadLine();

            while (!int.TryParse(userInput, out gameSelected))
            {
                Console.WriteLine("Invalid input");
                userInput = Console.ReadLine();
            }

            switch (gameSelected)
            {
                case 1:
                    gameEngine.AdditionGame("Addition game");
                    break;

                case 2:
                    gameEngine.SubtractionGame("Subtraction game");
                    break;

                case 3:
                    gameEngine.MultiplicationGame("Multiplication game");
                    break;

                case 4:
                    gameEngine.DivisionGame("Division game");
                    break;

                case 5:
                    helpers.GetGames();
                    break;

                case 6:
                    Environment.Exit(1);
                    break;

                default:
                    Console.WriteLine("Invalid input.");
                    Environment.Exit(1);
                    break;
            }
        }
    }
}
