using System;
using System.Diagnostics;
using SpaceFarm.Entities;
using SpaceFarm.Inventory;
using SpaceFarm.World;

namespace SpaceFarm.Farming;

public class FarmingSystem
{
    private PlantCatalog _plantCatalog;
    private readonly Stopwatch _watch;
    public SpaceFarm.Entities.Player Player { get; set; }

    public FarmingSystem(Stopwatch watch, PlantCatalog plantCatalog)
    {
        _watch = watch;
        _plantCatalog = plantCatalog;
    }
    /*
     * Вскопать
     * Посадить
     * Полить
     * Собрать
     */

    public bool PickUp(int x, int y)
    {
        if (Player.Inventory.PlayerInventory.ContainsKey(ItemID.PickAxe))
        {
            if (World.World.Tiles[x, y] is Tile tile)
            {
                if (tile.Type == TileType.Stone)
                {
                    World.World.Tiles[x, y] = new Tile(TileType.Grass);
                    return true;
                }
            }
        }

        return false;
    }

    public bool DigUp(int x, int y)
    {
        if (Player.Inventory.PlayerInventory.ContainsKey(ItemID.Hoe))
        {
            if (World.World.Tiles[x, y] is Tile tile)
            {
                if (tile.IsDigUp)
                {
                    World.World.Tiles[x, y] = new Tile(TileType.Soil);
                    return true;
                }
            }
        }
        return false;
    }

    public bool PlayerPlant(int x, int y, ItemID Plant)
    {
        if (Player.Inventory.PlayerInventory.ContainsKey(Plant))
        {
            if (World.World.Tiles[x,y] is Tile tile)
            {
                if (tile.Type == TileType.Soil)
                {
                    World.World.Tiles[x, y] = new Plant(Plant, _watch);
                    Player.Inventory.RemoveItem(Plant, 1);
                    _plantCatalog.GrowingPlants.Add((x, y), Plant);
                    return true;
                }
            }
        }
        return false;
    }

    public void Water(int x, int y)
    {
        if (Player.Inventory.PlayerInventory.ContainsKey(ItemID.WateringCan))
        {
            if (World.World.Tiles[x, y] is Plant Plant)
            {
                Plant.Water();
            }
        }
    }
    
    public void PlayerCollect(int x, int y)
    {
        Random rnd = new Random();
        if (Player.Inventory.PlayerInventory.ContainsKey(ItemID.HarvestingTool))
        {
            if (World.World.Tiles[x, y] is Plant Plant)
            {
                if (Plant.CanHarvest())
                {
                    ItemID HarvestID = PlantCatalog.Plants[Plant.Type].HarvestID;
                    Player.Inventory.AddItem(HarvestID, rnd.Next(PlantCatalog.Plants[Plant.Type].MinHarvest, PlantCatalog.Plants[Plant.Type].MaxHarvest + 1));
                    World.World.Tiles[x, y] = new Tile(TileType.Grass);
                    _plantCatalog.GrowingPlants.Remove((x, y));
                }
            }
        }
    }
    
    //Для проверки
    public void Ready(int x, int y)
    {
        if (World.World.Tiles[x, y] is Plant Plant)
        {
            Plant.Stage = 5;
        }
    }
}