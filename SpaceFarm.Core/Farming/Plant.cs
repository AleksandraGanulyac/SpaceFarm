using System;
using SpaceFarm.Inventory;

namespace SpaceFarm.Farming;

public class Plant
{
    private ItemID Type;
    private int Stage;
    private TimeSpan PastTense;
    private int WaterPerStage;
    private int IrrigationStatus;

    public Plant(ItemID Type, int Stage, TimeSpan PastTense, int IrrigationStatus)
    {
        this.Type = Type;
        this.Stage = Stage;
        this.PastTense = PastTense;
        WaterPerStage = PlantCatalog.Plants[Type].WaterPerStage;
        this.IrrigationStatus = IrrigationStatus;
    }
    
    
}