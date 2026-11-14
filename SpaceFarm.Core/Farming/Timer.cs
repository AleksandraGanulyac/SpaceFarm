using SpaceFarm.Farming;

namespace SpaceFarm;

public class Timer
{
    private Farming.PlantCatalog _plantCatalog;

    public Timer(Farming.PlantCatalog plantCatalog)
    {
        _plantCatalog = plantCatalog;
    }
    public async Task checkTimer()
    {
        using var timer = new PeriodicTimer(TimeSpan.FromSeconds(2));
        while (await timer.WaitForNextTickAsync())
        {
            //TimeCounter
            foreach (var GrowPlant in _plantCatalog.GrowingPlants)
            {
                var keyPart1 = GrowPlant.Key.Item1;
                var keyPart2 = GrowPlant.Key.Item2;
                if (SpaceFarm.World.World.Tiles[keyPart1, keyPart2] is Plant Plant)
                {
                    Plant.TimeCounter();
                    Plant.ChangeStage();
                }
            }
        }
    }
}