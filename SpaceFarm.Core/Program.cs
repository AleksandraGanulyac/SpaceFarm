using System;
using SpaceFarm.Entities;
using SpaceFarm.Inventory;
using SpaceFarm.World;

namespace SpaceFarm;

public class Program
{
    public static void Main()
    {
        SpaceFarm.World.World World = new SpaceFarm.World.World();
        SpaceFarm.Inventory.Inventory Inventory1 = new SpaceFarm.Inventory.Inventory();
        SpaceFarm.Inventory.Inventory Inventory2 = new SpaceFarm.Inventory.Inventory();
        SpaceFarm.Entities.Player Player1= new Player("pppp", "woman", World, Inventory1);
        SpaceFarm.Entities.Player Player2= new Player("pppp", "woman", World, Inventory2);

        Player1.Inventory.AddItem(ItemID.Wood, 8);
        Player2.Inventory.AddItem(ItemID.Wood, 10);
        
        Player1.Inventory.enter();
        Player2.Inventory.enter();


    }
}