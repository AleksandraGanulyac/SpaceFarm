namespace SpaceFarm.Inventory;

public class ItemCatalog
{
    public static IReadOnlyDictionary<ItemID, (string Name, int BuyPrice, int SellPrice)> Items { get; } =
        new Dictionary<ItemID, (string Name, int BuyPrice, int SellPrice)>
    {
        //семена
        [ItemID.MoonPumpkinSeed] = ("Moon Pumpkin Seed", 20, 8),
        [ItemID.CrystalCarrotSeed] = ("Crystal Carrot Seed", 35, 14),
        [ItemID.StarBerrySeed]  = ("Star Berry Seed", 80, 32),
        [ItemID.NovaNutSeed]  = ("Nova Nut Seed", 100, 40),
        [ItemID.FrostCometSeed]  = ("Frost Comet Seed", 120, 48),
        [ItemID.PlasmaPeaSeed]  = ("Plasma Pea Seed", 150, 60),
        [ItemID.MoonveilLotusSeed]  = ("Moonveil Lotus Seed", 180, 72),
        [ItemID.NebulaBloomSeed]  = ("Nebula Bloom Seed", 220, 88),
        [ItemID.GravityGourdSeed]  = ("Gravity Gourd Seed", 260, 104),
        [ItemID.VoidvineSeed]  = ("Voidvine Seed", 300, 120),
        [ItemID.StarseedFruitSeed]  = ("Starseed Fruit Seed", 350, 140),
        [ItemID.QuasarCitrusSeed]  = ("Quasar Citrus Seed", 400, 160),
        [ItemID.AuroraAppleSeed]  = ("Aurora Apple Seed", 450, 180),
        [ItemID.CometCoralSeed]  = ("Comet Coral Seed", 500, 200),
        [ItemID.StarlightSpinachSeed]  = ("Starlight Spinach Seed", 600, 240),
            
        //Урожай
        [ItemID.MoonPumpkin] = ("Moon Pumpkin", 65, 50),
        [ItemID.CrystalCarrot] = ("Crystal Carrot", 130, 100),
        [ItemID.StarBerry] = ("Star Berry", 340, 260),
        [ItemID.NovaNut] = ("Nova Nut", 420, 320),
        [ItemID.FrostComet] = ("Frost Comet", 500, 380),
        [ItemID.PlasmaPea] = ("Plasma Pea", 620, 470),
        [ItemID.MoonveilLotus] = ("Moonveil Lotus", 750, 570),
        [ItemID.NebulaBloom] = ("Nebula Bloom", 920, 700),
        [ItemID.GravityGourd] = ("Gravity Gourd", 1100, 830),
        [ItemID.Voidvine] = ("Voidvine", 1300, 980),
        [ItemID.StarseedFruit] = ("Starseed Fruit", 1500, 1130),
        [ItemID.QuasarCitrus] = ("Quasar Citrus", 1700, 1280),
        [ItemID.AuroraApple] = ("Aurora Apple", 1900, 1430),
        [ItemID.CometCoral] = ("Comet Coral", 2100, 1580),
        [ItemID.StarlightSpinach] = ("Starlight Spinach", 2500, 1880),
        
        //Ресурсы
        [ItemID.Wood] = ("Wood", 15, 5),
        [ItemID.Stone] = ("Stone", 20, 7),
        [ItemID.Crystal] = ("Crystal", 100, 35),
        
        //Инструменты
        [ItemID.Hoe] = ("Hoe", 100, 30),
        [ItemID.WateringCan] = ("Watering Can", 120, 36),
        [ItemID.HarvestingTool] = ("Harvesting Tool", 150, 45),
    };

    public static string GetName(ItemID id)
    {
        return Items[id].Name;
    }
    
    public static int GetBuyPrice(ItemID id)
    {
        return Items[id].BuyPrice;
    }

    public static int GetSellPrice(ItemID id)
    {
        return Items[id].SellPrice;
    }
}