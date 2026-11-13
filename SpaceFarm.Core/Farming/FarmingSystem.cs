using System;
using SpaceFarm.Entities;
using SpaceFarm.Inventory;
using SpaceFarm.World;

namespace SpaceFarm.Farming;

public class FarmingSystem
{
    public Entities.Player Player;
    /*
     * Вскопать
     * Посадить
     * Полить
     * Собрать
     */

    public bool DigUp(int x, int y)
    {
        if (Player.Inventory.PlayerInventory.ContainsKey(ItemID.Hoe))
        {
            if (World.World.Tiles[y, x] is Tile tile)
            {
                if (tile.IsDigUp)
                {
                    World.World.Tiles[y, x] = new Tile(TileType.Soil);
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
            if (World.World.Tiles[y,x] is Tile tile)
            {
                if (tile.Type == TileType.Soil)
                {
                    World.World.Tiles[y, x] = new Plant(Plant);
                    Player.Inventory.RemoveItem(Plant, 1);
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
            if (World.World.Tiles[y, x] is Plant Plant)
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
            if (World.World.Tiles[y, x] is Plant Plant)
            {
                if (Plant.CanHarvest())
                {
                    ItemID HarvestID = PlantCatalog.Plants[Plant.Type].HarvestID;
                    Player.Inventory.AddItem(HarvestID, rnd.Next(PlantCatalog.Plants[Plant.Type].MinHarvest, PlantCatalog.Plants[Plant.Type].MaxHarvest + 1));
                    World.World.Tiles[y, x] = new Tile(TileType.Grass);
                }
            }
        }
    }
}