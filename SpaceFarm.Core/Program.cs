using System;
using System.Diagnostics;
using SpaceFarm.Entities;
using SpaceFarm.Farming;
using SpaceFarm.Inventory;
using SpaceFarm.Shop;
using SpaceFarm.World;

namespace SpaceFarm;

public class Program
{
    public static async Task Main()
    {
        PlantCatalog plantCatalog = new PlantCatalog();
        Stopwatch watch = Stopwatch.StartNew();
        Timer Timer = new Timer(plantCatalog);
        _ = Task.Run(() => Timer.checkTimer());//чтобы не ждать завершения выполнения
        SpaceFarm.World.World World = new SpaceFarm.World.World();
        SpaceFarm.Inventory.Inventory Inventory1 = new SpaceFarm.Inventory.Inventory();
        SpaceFarm.Farming.FarmingSystem FarmingSystem1 = new FarmingSystem(watch, plantCatalog);
        Shop.Buy Buy = new Buy();
        Shop.Sell Sell = new Sell();
        SpaceFarm.Entities.Player Player1= new Player("pppp", "woman", World, Inventory1, FarmingSystem1, Buy, Sell);
        FarmingSystem1.Player = Player1;
        Buy.Player = Player1;
        Sell.Player = Player1;
        
        
        Player1.Buy.BuyGoods(ItemID.MoonPumpkinSeed, 2);
        Console.WriteLine(Player1.GetMoney());
        Inventory1.enter();
        
        Player1.Buy.BuyGoods(ItemID.CometCoralSeed, 2);
        Console.WriteLine(Player1.GetMoney());
        Inventory1.enter();
        
        Player1.Sell.SellItems(ItemID.MoonPumpkinSeed, 1);
        Console.WriteLine(Player1.GetMoney());
        Inventory1.enter();
        
        Player1.Sell.SellItems(ItemID.CometCoralSeed, 1);
        Console.WriteLine(Player1.GetMoney());
        Inventory1.enter();
        
        Player1.Sell.SellItems(ItemID.MoonPumpkinSeed, 10);
        Console.WriteLine(Player1.GetMoney());
        Inventory1.enter();


    }
}