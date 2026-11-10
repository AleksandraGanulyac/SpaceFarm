using System;
using SpaceFarm.Entities;
using SpaceFarm.World;

namespace SpaceFarm;

public class Program
{
    public static void Main()
    {
        SpaceFarm.World.World world = new SpaceFarm.World.World();

        Console.WriteLine(world.GetTileAt(0, 0).Type);   // Grass
        Console.WriteLine(world.GetTileAt(4, 2).Type);   // Water
        Console.WriteLine(world.GetTileAt(14, 3).Type);  // Stone
        Console.WriteLine(world.GetTileAt(5, 7).Type);   // Soil
        Console.WriteLine(world.GetTileAt(19, 14).Type); // Grass
        

    }
}