namespace SpaceFarm.World;

public class Tile //отдельная клетка карты
{
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
    public Tile(TileType type)
    {
        this.Type = type;
    }
}