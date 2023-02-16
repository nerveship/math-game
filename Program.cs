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
        case 1:
            AdditionGame("Addition game");
            Environment.Exit(1);
            break;

        case 2:
            SubtractionGame("Subtraction game");
            Environment.Exit(1);
            break;

        case 3:
            MultiplicationGame("Multiplication game");
            Environment.Exit(1);
            break;

        case 4:
            DivisionGame("Division game");
            Environment.Exit(1);
            break;

        case 5:
            Quit("Quit game");
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

    //End screen
    Console.WriteLine($"Congrats, you got {correct} out of {userQuestions} right!");
}

void SubtractionGame(string message)
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

    //End screen
    Console.WriteLine($"Congrats, you got {correct} out of {userQuestions} right!");
}

void MultiplicationGame(string message)
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

    //End screen
    Console.WriteLine($"Congrats, you got {correct} out of {userQuestions} right!");
}

void DivisionGame(string message)
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
        var divisionNumbers = GetDivisionNumbers();
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
    //End screen
    Console.WriteLine($"Congrats, you got {correct} out of {userQuestions} right!");
}

void Quit(string message)
{
    Console.WriteLine(message);
}

int[] GetDivisionNumbers()
{
    Random random= new Random();
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