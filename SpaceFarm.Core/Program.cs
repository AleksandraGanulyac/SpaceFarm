using System;
using SpaceFarm.Entities;
using SpaceFarm.World;

namespace SpaceFarm;

public class Program
{
    public static void Main()
    {
        SpaceFarm.World.World world = new SpaceFarm.World.World();

        Console.WriteLine(world.CanMoveTo(0, 0));    // True
        Console.WriteLine(world.CanMoveTo(4, 2));    // False — вода
        Console.WriteLine(world.CanMoveTo(14, 3));   // False — камень
        Console.WriteLine(world.CanMoveTo(5, 7));    // True — почва
        Console.WriteLine(world.CanMoveTo(-1, 0));   // False
        Console.WriteLine(world.CanMoveTo(20, 5));  // False
        

    }
}