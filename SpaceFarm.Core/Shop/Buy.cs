using SpaceFarm.Inventory;

namespace SpaceFarm.Shop;

public class Buy
{
    public SpaceFarm.Entities.Player Player { get; set; }

    private bool MoneyCheck(int price)
    {
        if (Player.GetMoney() >= price)
        {
            return true;
        }
        return false;
    }

    public void BuyGoods(ItemID goods, int  quantity)
    {
        int price = ItemCatalog.GetBuyPrice(goods) * quantity;
        if (MoneyCheck(price))
        {
            Player.SpendMoney(price);
            Player.Inventory.AddItem(goods,  quantity);
        }
    }
}