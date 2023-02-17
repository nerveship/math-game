using MathGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MathGame
{
    internal class helpers
    {
        internal static List<Game> games = new List<Game>
        {
            new Game {Date = DateTime.Now.AddDays(1), Type = GameType.Addition, Score = 5, MaxQuestions = 5},
            new Game {Date = DateTime.Now.AddDays(2), Type = GameType.Multiplication, Score = 4, MaxQuestions = 6},
            new Game {Date = DateTime.Now.AddDays(3), Type = GameType.Division, Score = 4, MaxQuestions = 10},
            new Game {Date = DateTime.Now.AddDays(4), Type = GameType.Subtraction, Score = 3, MaxQuestions = 5},
            new Game {Date = DateTime.Now.AddDays(5), Type = GameType.Addition, Score = 1, MaxQuestions = 2},
            new Game {Date = DateTime.Now.AddDays(6), Type = GameType.Multiplication, Score = 2, MaxQuestions = 4},
            new Game {Date = DateTime.Now.AddDays(7), Type = GameType.Division, Score = 3, MaxQuestions = 10},
            new Game {Date = DateTime.Now.AddDays(8), Type = GameType.Subtraction, Score = 4, MaxQuestions = 7},
            new Game {Date = DateTime.Now.AddDays(9), Type = GameType.Addition, Score = 4, MaxQuestions = 7},
            new Game {Date = DateTime.Now.AddDays(10), Type = GameType.Multiplication, Score = 1, MaxQuestions = 1},
            new Game {Date = DateTime.Now.AddDays(11), Type = GameType.Subtraction, Score = 0, MaxQuestions = 5},
            new Game {Date = DateTime.Now.AddDays(12), Type = GameType.Division, Score = 5, MaxQuestions = 8},
            new Game {Date = DateTime.Now.AddDays(13), Type = GameType.Subtraction, Score = 5, MaxQuestions = 5}
        };
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
