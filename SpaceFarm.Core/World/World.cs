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
    private const int WIDTH = 20;
    private const int HEIGHT = 15;
    private Tile[,] Tiles { get;  } = EnterTiles(StrWorld);

    private static Tile[,] EnterTiles(string StrWorld)
    {
        Tile[,] Tiles = new Tile[HEIGHT, WIDTH];
        int symb = 0;
        for (int i = 0; i < HEIGHT; i++)
        {
            for (int j = 0; j < WIDTH; j++)
            {
                    switch (StrWorld[symb])
                    {
                        case 'G':
                            Tiles[i, j] = new Tile(TileType.Grass);
                            symb++;
                            break;
                        case 'W':
                            Tiles[i, j] = new Tile(TileType.Water);
                            symb++;
                            break;
                        case 'S':
                            Tiles[i, j] = new Tile(TileType.Stone);
                            symb++;
                            break;
                        case 'D':
                            Tiles[i, j] = new Tile(TileType.Soil);
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
    
    public Tile GetTileAt(int x, int y)
    {
        return Tiles[y, x];
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
        if (IsInsideMap(x, y) && Tiles[y, x].IsWalkable)
        {
            return true;
        }
        return  false;
    }
    
}