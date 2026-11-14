using SpaceFarm.Inventory;

namespace SpaceFarm.World;

public class World //игровая карта
{
    private const string StrWorld = "GGGGGGGGGGGGGGGGGGGG" +
                                     "GGGGGGGGGGGGGGGGGGGG" +
                                     "GGGGWWWWGGGGGGGGGGGG" +
                                     "GGGGWWWWGGGGGGSSGGGG" +
                                     "GGGGWWWWGGGGGGSSSGGG" +
                                     "GGGGGGGGGGGGGGSSSGGG" +
                                     "GGGGGGGGGGGGGGGGGGGG" +
                                     "GGGGGDDDDDDGGGGGGGGG" +
                                     "GGGGGDDDDDDGGGGGGGGG" +
                                     "GGGGGDDDDDDGGGGGGGGG" +
                                     "GGGGGDDDDDDGGGGGGGGG" +
                                     "GGGGGGGGGGGGGGGGGGGG" +
                                     "GGGGGGGGGGGGGGGGGGGG" +
                                     "GGGGGGGGGGGGGGGGGGGG" +
                                     "GGGGGGGGGGGGGGGGGGGG";
    public const int WIDTH = 20;
    public const int HEIGHT = 15;
    public static object[,] Tiles { get;  } = EnterTiles(StrWorld);

    private static object[,] EnterTiles(string StrWorld)
    {
        object[,] Tiles = new object[WIDTH, HEIGHT];
        int symb = 0;
        for (int i = 0; i < HEIGHT; i++)
        {
            for (int j = 0; j < WIDTH; j++)
            {
                    switch (StrWorld[symb])
                    {
                        case 'G':
                            Tiles[j, i] = new Tile(TileType.Grass);
                            symb++;
                            break;
                        case 'W':
                            Tiles[j, i] = new Tile(TileType.Water);
                            symb++;
                            break;
                        case 'S':
                            Tiles[j, i] = new Tile(TileType.Stone);
                            symb++;
                            break;
                        case 'D':
                            Tiles[j, i] = new Tile(TileType.Soil);
                            symb++;
                            break;
                        default:
                            symb++;
                            break;
                    
                }
            }
        }
        return Tiles;
    }
    
    public object GetTileAt(int x, int y)
    {
        return Tiles[x, y];
    }

    private bool IsInsideMap(int x, int y)
    {
        if (x < WIDTH && y < HEIGHT && x >= 0 && y >= 0)
        {
            return true;
        }

        return false;
    }

    public bool CanMoveTo(int x, int y)
    {
        if (IsInsideMap(x, y))
        {
            if (Tiles[x, y] is Farming.Plant)
            {
                return true;
            }
            else if (Tiles[x, y] is Tile tile/*переменная*/)
            {
                return tile.IsWalkable;
            }
        }
        
        return  false;
    }
    
}