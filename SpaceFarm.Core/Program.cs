using System;
using SpaceFarm.Entities;
using SpaceFarm.World;

namespace SpaceFarm;

public class Program
{
    public static void Main()
    {
        SpaceFarm.World.World World = new SpaceFarm.World.World();
        SpaceFarm.Entities.Player player1= new Player("pppp", "woman", World);

        player1.GetX();
        player1.GetY();

        player1.Move(Direction.Right);
        player1.Move(Direction.Right);
        player1.Move(Direction.Right);
        player1.Move(Direction.Right);
        player1.Move(Direction.Right);
        player1.Move(Direction.Right);
        player1.Move(Direction.Right);
        player1.Move(Direction.Right);
        player1.Move(Direction.Right);
        player1.Move(Direction.Right);
        player1.Move(Direction.Right);
        player1.Move(Direction.Right);
        player1.Move(Direction.Right);
        player1.Move(Direction.Right);
        player1.Move(Direction.Right);
        player1.Move(Direction.Right);
        player1.Move(Direction.Right);
        player1.Move(Direction.Right);
        player1.Move(Direction.Right);
        player1.Move(Direction.Right);
        player1.Move(Direction.Right);
        player1.Move(Direction.Right);
        Console.WriteLine(player1.GetX() + "|" + player1.GetY());
        
        player1.Move(Direction.Down);
        player1.Move(Direction.Down);
        player1.Move(Direction.Down);
        player1.Move(Direction.Down);
        player1.Move(Direction.Down);
        player1.Move(Direction.Down);
        player1.Move(Direction.Down);
        player1.Move(Direction.Down);
        player1.Move(Direction.Down);
        player1.Move(Direction.Down);
        player1.Move(Direction.Down);
        player1.Move(Direction.Down);
        player1.Move(Direction.Down);
        player1.Move(Direction.Down);
        player1.Move(Direction.Down);
        player1.Move(Direction.Down);
        player1.Move(Direction.Down);
        player1.Move(Direction.Down);
        Console.WriteLine(player1.GetX() + "|" + player1.GetY());

    }
}