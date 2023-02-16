var date = DateTime.Now;
string name = GetName();

MainMenu(date, name);
string GetName()
{
    Console.WriteLine("Please tell me your name");
    string name = Console.ReadLine();
    return name;
}
void MainMenu(DateTime date, string name)
{
    Console.Clear();
    Console.WriteLine("-----------------------------------");
    Console.WriteLine($"Hello {name.ToUpper()}");
    Console.WriteLine($"Today's date and time is {date}, I hope your day is going well!");
    Console.WriteLine("What game would you like to play today? Select an option from the numbers below:\n" +
        "1. Addition\n" +
        "2. Subtraction\n" +
        "3. Multiplication\n" +
        "4. Division\n" +
        "5. Quit the program");
    Console.WriteLine("-----------------------------------");
    SelectGame();
}
void SelectGame()
{
    int gameSelected;
    string userInput = Console.ReadLine();

    while(!int.TryParse(userInput, out gameSelected))
    {
        Console.WriteLine("Invalid input");
        userInput = Console.ReadLine();
    }

    switch (gameSelected)
    {
        case 0:
            AdditionGame("Addition game selected");
            Environment.Exit(1);
            break;

        case 1:
            SubtractionGame("Subtraction game selected");
            Environment.Exit(1);
            break;

        case 2:
            MultiplicationGame("Multiplication game selected");
            Environment.Exit(1);
            break;

        case 3:
            DivisionGame("Division game selected");
            Environment.Exit(1);
            break;

        case 4:
            Quit("Quit game selected");
            Environment.Exit(1);
            break;

        default:
            Console.WriteLine("Invalid input.");
            Environment.Exit(1);
            break;
    }
}

void AdditionGame(string message)
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
        secondNumber= rnd.Next(0, 20);

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
            Console.WriteLine("Unfortunately, that is incorrect");
        }
        else
        {
            Console.WriteLine("Congrats, that is correct!");
            correct++;
        }
    }

    //End screen
    Console.WriteLine($"Congrats, you got {correct} out of {userQuestions} right!");
}

void SubtractionGame(string message)
{
    Console.WriteLine(message);
}

void MultiplicationGame(string message)
{
    Console.WriteLine(message);
}

void DivisionGame(string message)
{
    Console.WriteLine(message);
}

void Quit(string message)
{
    Console.WriteLine(message);
}