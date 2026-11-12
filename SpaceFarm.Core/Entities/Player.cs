using SpaceFarm.World;

namespace SpaceFarm.Entities;

public class Player
{
    private string Name;
    private string Gender;
    private int Money;
    private int X;
    private int Y;
    private  SpaceFarm.World.World World { get; }
    public SpaceFarm.Inventory.Inventory Inventory { get; }

    public Player(string Name, string Gender, World.World World, Inventory.Inventory Inventory)
    {
        this.Name = Name;
        this.Gender = Gender;
        this.Money = 100;
        this.X = 0;
        this.Y = 0;
        this.World = World;
        this.Inventory = Inventory;
    }
    
    public string GetName() { return Name; }

    public string GetGender()  { return Gender; }

    public int GetMoney() { return Money; }

    public int GetX()  { return X; }
    public int GetY()  { return Y; }
    
    public void AddMoney(int amount)
    {
        if (amount > 0)
        {
            this.Money += amount;
        }
    }
    
    public bool SpendMoney(int amount)
    {
        if(amount > 0 && this.Money >= amount)
        {
            this.Money -= amount;
            return true;
        }

        return false;
    }

    public bool Move(Direction direction)
    {
        switch (direction)
        {
            case Direction.Up:
                if(World.CanMoveTo(X, Y-1))
                {
                    this.Y -= 1;
                    return true;
                }
                else
                {
                    return false;
                }
            case Direction.Down:
                if(World.CanMoveTo(X, Y+1))
                {
                    this.Y += 1;
                    return true;
                }
                else
                {
                    return false;
                }
            case Direction.Left:
                if (World.CanMoveTo(X-1, Y))
                {
                    this.X -= 1;
                    return true;
                }
                else
                {
                    return false;
                }
            case Direction.Right:
                if (World.CanMoveTo(X+1, Y))
                {
                    this.X += 1;
                    return true;
                }
                else
                {
                    return false;
                }
            default:
                return false;
            
            
        }
    }
}