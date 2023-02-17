namespace MathGame.Models;
internal class Game
{
    public DateTime Date { get; set; }
    public int Score { get; set; }
    public GameType Type { get; set; }
    public int MaxQuestions { get; set; }
}

internal enum GameType
{
    Addition,
    Subtraction,
    Division,
    Multiplication
}