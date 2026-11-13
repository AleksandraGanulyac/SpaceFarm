using System;
using System.Collections.Generic;

namespace SpaceFarm.Inventory;

public class Inventory
{
    private Dictionary<ItemID, int> PlayerInventory = new Dictionary<ItemID, int>();

    public void enter()
    {
        foreach (var item in PlayerInventory)
        {
            
            Console.WriteLine($"{item.Key}: {item.Value}");
        }
        Console.WriteLine();
    }

    public bool AddItem(ItemID id, int amount)
    {
        if (amount > 0)
        {
            if (PlayerInventory.ContainsKey(id))
            {
                PlayerInventory[id] += amount;
            }
            else
            {
                PlayerInventory.Add(id, amount);
            }
            return true;
        }
        return false;
    }
    
    public bool RemoveItem(ItemID id, int amount)
    {
        if (PlayerInventory.ContainsKey(id))
        {
            if (amount > 0)
            {
                if (PlayerInventory[id] >= amount)
                {
                    PlayerInventory[id] -= amount;
                    if (PlayerInventory[id] == 0)
                    {
                        PlayerInventory.Remove(id);
                    }
                    return true;
                    
                }
            }
        }
        return false;
    }
    
}