using SpaceFarm.Inventory;

namespace SpaceFarm.Shop;

public class Sell
{
    public SpaceFarm.Entities.Player Player { get; set; }
    
    private bool AvailabilityCheck(ItemID goods, int quantity)//Проверка наличия
    {
        if (Player.Inventory.PlayerInventory.ContainsKey(goods) && 
            Player.Inventory.PlayerInventory[goods] >= quantity)
        {
            return true;
        }
        
        return false;
    }

    public void SellItems(ItemID goods, int quantity)
    {
        int price = ItemCatalog.GetSellPrice(goods) * quantity;
        if (AvailabilityCheck(goods, quantity))
        {
            Player.Inventory.RemoveItem(goods,  quantity);
            Player.AddMoney(price);
        }
    }
    
}