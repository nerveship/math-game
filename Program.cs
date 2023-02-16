Console.WriteLine("Please type your name");

var date = DateTime.Now;
string name = Console.ReadLine();

MainMenu(date, name);

static void MainMenu(DateTime date, string name)
{
    Console.WriteLine("-----------------------------------");
    Console.WriteLine($"Hello {name.ToUpper()}");
    Console.WriteLine($"Today's date is {date}, I hope today is going well!");
    Console.WriteLine("What game would you like to play today? Select an option from the numbers below:\n" +
        "1. Addition\n" +
        "2. Subtraction\n" +
        "3. Multiplication\n" +
        "4. Division\n" +
        "5. Quit the program");
    Console.WriteLine("-----------------------------------");
    SelectGame();
}
static void SelectGame()
{
    int gameSelected = Convert.ToInt32(Console.ReadLine());
    switch (gameSelected)
    {
        case 0:
            Console.WriteLine("Addition game selected");
            break;

        case 1:
            Console.WriteLine("Subtraction game selected");
            break;

        case 2:
            Console.WriteLine("Multiplication game selected");
            break;

        case 3:
            Console.WriteLine("Division game selected");
            break;

        case 4:
            Console.WriteLine("Quit selected");
            break;
    }
}