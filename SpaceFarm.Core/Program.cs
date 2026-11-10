using SpaceFarm.Entities;

namespace SpaceFarm;

public class Program
{
    public static void Main()
    {
        Player player1 = new Player("Alexandra", "woman");

        Console.WriteLine(player1.GetX());
        Console.WriteLine(player1.GetY());
        
        player1.Move(Direction.Right);
        player1.Move(Direction.Right);
        player1.Move(Direction.Up);
        Console.WriteLine(player1.GetX());
        Console.WriteLine(player1.GetY());
        
        player1.Move(Direction.Left);
        player1.Move(Direction.Left);
        player1.Move(Direction.Down);
        Console.WriteLine(player1.GetX());
        Console.WriteLine(player1.GetY());

    }
}