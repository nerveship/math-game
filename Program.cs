Console.WriteLine("Please type your name");

var date = DateTime.Now;
string name = Console.ReadLine();

MainMenu(date, name);

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
    Console.WriteLine(message);
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