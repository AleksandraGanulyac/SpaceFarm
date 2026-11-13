using System;
using SpaceFarm.Inventory;

namespace SpaceFarm.Farming;

public class Plant
{
    private ItemID Type;
    private int Stage;
    private TimeSpan PastTense;//Сколько времени прошло на текущей стадии
//Сколько поливов должно быть
    private int IrrigationStatus; //Сколько поливов прошло

    public Plant(ItemID Type, TimeSpan PastTense, int IrrigationStatus)
    {
        this.Type = Type;
        Stage = 0;
        this.PastTense = PastTense;
        this.IrrigationStatus = IrrigationStatus;
    }

    public bool CanChangeStage()
    {
        if (Stage < 6)
        {
            if (IrrigationStatus == PlantCatalog.Plants[Type].WaterPerStage && Time())
            {
                return true;
            }
        }

        return false;
    }

    public bool Water()
    {
        if (IrrigationStatus < PlantCatalog.Plants[Type].WaterPerStage)
        {
            IrrigationStatus++;
            return true;
        }
        return false;
    }

    public bool Time()
    {
        if (PastTense >= PlantCatalog.Plants[Type].StageGrowthTime[Stage])
        {
            return true;
        }
        return false;
    }

    public void ChangeStage()
    {
        if (CanChangeStage())
        {
            Stage++;
            PastTense = TimeSpan.Zero;
            IrrigationStatus = 0;
        }
    }

    public bool CanHarvest()
    {
        if (Stage == 5)
        {
            return true;
        }

        return false;
    }
}
