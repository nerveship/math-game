using MathGame.Models;

namespace MathGame
{
    internal class GameEngine
    {
        internal void AdditionGame(string message)
        {
            Console.Clear();
            Console.WriteLine(message);

            //Prompt user for No. of questions
            Console.WriteLine("How many questions would you like today?");
            string userNum = Console.ReadLine();
            int userQuestions;

            //Initialise random numbers and correct count
            Random rnd = new Random();
            int firstNumber;
            int secondNumber;
            int correct = 0;

            //Check for numbers in user input
            while (!int.TryParse(userNum, out userQuestions))
            {
                Console.WriteLine("Please input numbers");
            }

            //Game logic
            for (int i = 0; i < userQuestions; i++)
            {
                firstNumber = rnd.Next(0, 20);
                secondNumber = rnd.Next(0, 20);

                Console.WriteLine($"{firstNumber} + {secondNumber}");
                string userInput = Console.ReadLine();
                int userGuess;

                while (!int.TryParse(userInput, out userGuess))
                {
                    Console.WriteLine("Please input numbers");
                    userInput = Console.ReadLine();
                }

                if (userGuess != firstNumber + secondNumber)
                {
                    Console.WriteLine("Unfortunately, that is incorrect. Press any key for the next question");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Congrats, that is correct! Press any key for the next question");
                    Console.ReadKey();
                    correct++;
                }
            }

            helpers.AddToHistory(correct, userQuestions, GameType.Addition);

            //End screen
            Console.Clear();
            Console.WriteLine($"Congrats, you got {correct} out of {userQuestions} right!");
            Console.WriteLine("Press any key to return to the main screen");
            Console.ReadKey();
            Console.Clear();
        }

        internal void SubtractionGame(string message)
        {
            Console.Clear();
            Console.WriteLine(message);

            //Prompt user for No. of questions
            Console.WriteLine("How many questions would you like today?");
            string userNum = Console.ReadLine();
            int userQuestions;

            //Initialise random numbers and correct count
            Random rnd = new Random();
            int firstNumber;
            int secondNumber;
            int correct = 0;

            //Check for numbers in user input
            while (!int.TryParse(userNum, out userQuestions))
            {
                Console.WriteLine("Please input numbers");
            }

            //Game logic
            for (int i = 0; i < userQuestions; i++)
            {
                firstNumber = rnd.Next(0, 20);
                secondNumber = rnd.Next(0, 20);

                Console.WriteLine($"{firstNumber} - {secondNumber}");
                string userInput = Console.ReadLine();
                int userGuess;

                while (!int.TryParse(userInput, out userGuess))
                {
                    Console.WriteLine("Please input numbers");
                    userInput = Console.ReadLine();
                }

                if (userGuess != firstNumber - secondNumber)
                {
                    Console.WriteLine("Unfortunately, that is incorrect");
                }
                else
                {
                    Console.WriteLine("Congrats, that is correct!");
                    correct++;
                }
            }

            helpers.AddToHistory(correct, userQuestions, GameType.Subtraction);

            //End screen
            Console.Clear();
            Console.WriteLine($"Congrats, you got {correct} out of {userQuestions} right!");
            Console.WriteLine("Press any key to return to the main screen");
            Console.ReadKey();
            Console.Clear();
        }

        internal void MultiplicationGame(string message)
        {
            Console.Clear();
            Console.WriteLine(message);

            //Prompt user for No. of questions
            Console.WriteLine("How many questions would you like today?");
            string userNum = Console.ReadLine();
            int userQuestions;

            //Initialise random numbers and correct count
            Random rnd = new Random();
            int firstNumber;
            int secondNumber;
            int correct = 0;

            //Check for numbers in user input
            while (!int.TryParse(userNum, out userQuestions))
            {
                Console.WriteLine("Please input numbers");
                userNum = Console.ReadLine();
            }

            //Game logic
            for (int i = 0; i < userQuestions; i++)
            {
                firstNumber = rnd.Next(0, 20);
                secondNumber = rnd.Next(0, 20);

                Console.WriteLine($"{firstNumber} * {secondNumber}");
                string userInput = Console.ReadLine();
                int userGuess;

                while (!int.TryParse(userInput, out userGuess))
                {
                    Console.WriteLine("Please input numbers");
                    userInput = Console.ReadLine();
                }

                if (userGuess != firstNumber * secondNumber)
                {
                    Console.WriteLine("Unfortunately, that is incorrect");
                }
                else
                {
                    Console.WriteLine("Congrats, that is correct!");
                    correct++;
                }
            }

            helpers.AddToHistory(correct, userQuestions, GameType.Multiplication);

            //End screen
            Console.Clear();
            Console.WriteLine($"Congrats, you got {correct} out of {userQuestions} right!");
            Console.WriteLine("Press any key to return to the main screen");
            Console.ReadKey();
            Console.Clear();
        }

        internal void DivisionGame(string message)
        {
            Console.Clear();
            Console.WriteLine(message);

            //Prompt user for No. of questions
            Console.WriteLine("How many questions would you like today?");
            string userNum = Console.ReadLine();
            int userQuestions;

            int correct = 0;

            //Check for numbers in user input
            while (!int.TryParse(userNum, out userQuestions))
            {
                Console.WriteLine("Please input numbers");
            }

            for (int i = 0; i < userQuestions; i++)
            {
                var divisionNumbers = helpers.GetDivisionNumbers();
                int firstNumber = divisionNumbers[0];
                int secondNumber = divisionNumbers[1];

                Console.WriteLine($"{firstNumber} / {secondNumber}");

                string userInput = Console.ReadLine();
                int userGuess;

                while (!int.TryParse(userInput, out userGuess))
                {
                    Console.WriteLine("Please input numbers");
                    userInput = Console.ReadLine();
                }

                if (userGuess != firstNumber / secondNumber)
                {
                    Console.WriteLine("Unfortunately, that is incorrect");
                }
                else
                {
                    Console.WriteLine("Congrats, that is correct!");
                    correct++;
                }
            }

            helpers.AddToHistory(correct, userQuestions, GameType.Division);

            //End screen
            Console.Clear();
            Console.WriteLine($"Congrats, you got {correct} out of {userQuestions} right!");
            Console.WriteLine("Press any key to return to the main screen");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
