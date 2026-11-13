using SpaceFarm.Farming;
using SpaceFarm.Inventory;

namespace SpaceFarm.World;

public class Tile //отдельная клетка карты
{
    
    public Tile(TileType Type)
    {
        this.Type = Type;
    }
    public TileType Type { get; private set;}

    public bool IsWalkable
    {
        get
        {
            return Type switch
            {
                TileType.Grass => true,
                TileType.Soil => true,
                TileType.Stone => false,
                TileType.Water => false,
                _ => false
            };
            //можно ли по блоку ходить?
        }
    }

    public bool IsDigUp //Можно ли блок вскопать
    {
        get
        {
            return Type switch
            {
                TileType.Grass => true,
                _ => false
            };
        }
    }
}