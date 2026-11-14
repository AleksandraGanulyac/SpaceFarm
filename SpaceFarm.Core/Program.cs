using System;
using System.Diagnostics;
using SpaceFarm.Entities;
using SpaceFarm.Farming;
using SpaceFarm.Inventory;
using SpaceFarm.World;

namespace SpaceFarm;

public class Program
{
    public static void Main()
    {
        PlantCatalog plantCatalog = new PlantCatalog();
        Stopwatch watch = Stopwatch.StartNew();
        Timer Timer = new Timer(plantCatalog);
        Timer.checkTimer();
        SpaceFarm.World.World World = new SpaceFarm.World.World();
        SpaceFarm.Inventory.Inventory Inventory1 = new SpaceFarm.Inventory.Inventory();
        SpaceFarm.Inventory.Inventory Inventory2 = new SpaceFarm.Inventory.Inventory();
        SpaceFarm.Farming.FarmingSystem FarmingSystem1 = new FarmingSystem(watch, plantCatalog);
        SpaceFarm.Farming.FarmingSystem FarmingSystem2 = new FarmingSystem(watch, plantCatalog);
        SpaceFarm.Entities.Player Player1= new Player("pppp", "woman", World, Inventory1, FarmingSystem1);
        SpaceFarm.Entities.Player Player2= new Player("pppp", "woman", World, Inventory2, FarmingSystem2);
        FarmingSystem1.Player = Player1;
        FarmingSystem2.Player = Player2;

        

        

    }
}