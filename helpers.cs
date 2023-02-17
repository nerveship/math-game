using MathGame.Models;

namespace MathGame
{
    internal class helpers
    {
        internal static List<Game> games = new List<Game>();

        internal static int[] GetDivisionNumbers()
        {
            Random random = new Random();
            int firstNumber = random.Next(0, 99);
            int secondNumber = random.Next(0, 99);

            var result = new int[2];

            while (firstNumber % secondNumber != 0)
            {
                firstNumber = random.Next(1, 99);
                secondNumber = random.Next(1, 99);
            }

            result[0] = firstNumber;
            result[1] = secondNumber;

            return result;
        }

        internal static void AddToHistory(int gameScore, int questions, GameType gameType)
        {
            games.Add(new Game
            {
                Date = DateTime.Now,
                Score = gameScore,
                Type = gameType,
                MaxQuestions = questions
            });
        }

        internal static void GetGames()
        {

            Console.Clear();
            Console.WriteLine("Game History");
            Console.WriteLine("-----------------------------------");

            foreach (var game in games)
            {
                Console.WriteLine($"{game.Date} - {game.Type} - {game.Score}/{game.MaxQuestions}");
            }

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Press any key to return to the main menu");
            Console.ReadLine();
            Console.Clear();
        }

    }
}
