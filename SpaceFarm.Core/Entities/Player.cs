namespace SpaceFarm.Entities;

public class Player
{
    private string name;
    private string gender;
    private int money;
    private int x;
    private int y;

    public Player(string name, string gender)
    {
        this.name = name;
        this.gender = gender;
        this.money = 100;
        this.x = 0;
        this.y = 0;
    }
    
    public string GetName() { return name; }

    public string GetGender()  { return gender; }

    public int GetMoney() { return money; }

    public int GetX()  { return x; }
    public int GetY()  { return y; }
    
    public void AddMoney(int amount)
    {
        if (amount > 0)
        {
            this.money += amount;
        }
    }
    
    public bool SpendMoney(int amount)
    {
        if(amount > 0 && this.money >= amount)
        {
            this.money -= amount;
            return true;
        }

        return false;
    }

    public bool Move(Direction direction)
    {
        switch (direction)
        {
            case Direction.Up:
                this.y -= 1;
                return true;
            case Direction.Down:
                this.y += 1;
                return true;
            case Direction.Left:
                this.x -= 1;
                return true;
            case Direction.Right:
                this.x += 1;
                return true;
            default:
                return false;
            
            
        }
    }
}