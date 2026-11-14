using System;
using System.Diagnostics;
using SpaceFarm.Inventory;

namespace SpaceFarm.Farming;

public class Plant
{
    private readonly Stopwatch _watch;
 
    public ItemID Type { get;}
    public int Stage;
    private TimeSpan PastTense;//Сколько времени прошло на текущей стадии

    private TimeSpan LastCheck;
//Сколько поливов должно быть
    private int IrrigationStatus; //Сколько поливов прошло
    public Plant(ItemID Type, Stopwatch watch)
    {
        _watch = watch;
        this.Type = Type;
        Stage = 0;
        LastCheck = _watch.Elapsed;
        PastTense = TimeSpan.Zero;
        IrrigationStatus = 0;
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
            Console.WriteLine("Irrigation status: {0}", IrrigationStatus);
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

    public TimeSpan TimeCounter()
    {
        PastTense += _watch.Elapsed - LastCheck;
        LastCheck =  _watch.Elapsed;
        return  PastTense;
    }
    
}
