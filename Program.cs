using MathGame;

var date = DateTime.Now;
string name = GetName();
var menu = new menu();

List<string> games = new();

menu.MainMenu(name, date);

string GetName()
{
    Console.WriteLine("Please tell me your name");
    string name = Console.ReadLine();
    return name;
}

void Quit(string message)
{
    Console.WriteLine(message);
}
