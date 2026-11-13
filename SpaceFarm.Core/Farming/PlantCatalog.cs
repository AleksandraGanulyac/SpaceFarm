using System;
using System.Collections.Generic;
using System.Net.Http;
using SpaceFarm.Inventory;

namespace SpaceFarm.Farming;

public class PlantCatalog
{
    
    public static IReadOnlyDictionary<ItemID, (ItemID HarvestID, TimeSpan[] StageGrowthTime, int WaterPerStage, int MinHarvest, int MaxHarvest)> Plants { get; } =
        new Dictionary<ItemID, (ItemID HarvestID, TimeSpan[] StageGrowthTime, int WaterPerStage, int MinHarvest, int MaxHarvest)>
        {
            [ItemID.MoonPumpkinSeed] = (ItemID.MoonPumpkin, new[]
                {
                    TimeSpan.FromMinutes(15),
                    TimeSpan.FromMinutes(20),
                    TimeSpan.FromMinutes(20),
                    TimeSpan.FromMinutes(25),
                    TimeSpan.FromMinutes(25),
                    TimeSpan.FromMinutes(15)
                }, 2, 3, 5),
            [ItemID.CrystalCarrotSeed] = (ItemID.CrystalCarrot, new[]
                {
                    TimeSpan.FromMinutes(8),
                    TimeSpan.FromMinutes(10),
                    TimeSpan.FromMinutes(10),
                    TimeSpan.FromMinutes(12),
                    TimeSpan.FromMinutes(12),
                    TimeSpan.FromMinutes(8)
                }, 1, 2, 4),
            [ItemID.StarBerrySeed] = (ItemID.StarBerry, new[]
                {
                    TimeSpan.FromMinutes(12),
                    TimeSpan.FromMinutes(15),
                    TimeSpan.FromMinutes(15),
                    TimeSpan.FromMinutes(18),
                    TimeSpan.FromMinutes(18),
                    TimeSpan.FromMinutes(12)
                }, 2, 4, 6),
            [ItemID.NovaNutSeed]= (ItemID.NovaNut, new[]
            {
                TimeSpan.FromMinutes(25),
                TimeSpan.FromMinutes(30),
                TimeSpan.FromMinutes(30),
                TimeSpan.FromMinutes(35),
                TimeSpan.FromMinutes(35),
                TimeSpan.FromMinutes(25)
            }, 2, 2, 3),
            [ItemID.FrostCometSeed]= (ItemID.FrostComet, new[]
            {
                TimeSpan.FromMinutes(20),
                TimeSpan.FromMinutes(25),
                TimeSpan.FromMinutes(25),
                TimeSpan.FromMinutes(30),
                TimeSpan.FromMinutes(30),
                TimeSpan.FromMinutes(20)
            }, 2, 3, 4),
            [ItemID.PlasmaPeaSeed] = (ItemID.PlasmaPea, new[]
            {
                TimeSpan.FromMinutes(10),
                TimeSpan.FromMinutes(12),
                TimeSpan.FromMinutes(12),
                TimeSpan.FromMinutes(15),
                TimeSpan.FromMinutes(16),
                TimeSpan.FromMinutes(10)
            }, 1, 4, 7),   
            [ItemID.MoonveilLotusSeed] = (ItemID.MoonveilLotus, new[]
            {
                TimeSpan.FromMinutes(40),
                TimeSpan.FromMinutes(50),
                TimeSpan.FromMinutes(50),
                TimeSpan.FromMinutes(60),
                TimeSpan.FromMinutes(60),
                TimeSpan.FromMinutes(40)
            }, 3, 1, 2),
            [ItemID.NebulaBloomSeed] = (ItemID.NebulaBloom, new[]
            {
                TimeSpan.FromMinutes(30),
                TimeSpan.FromMinutes(40),
                TimeSpan.FromMinutes(40),
                TimeSpan.FromMinutes(50),
                TimeSpan.FromMinutes(50),
                TimeSpan.FromMinutes(30)
            }, 2, 2, 3),  
            [ItemID.GravityGourdSeed] = (ItemID.GravityGourd, new[]
            {
                TimeSpan.FromMinutes(25),
                TimeSpan.FromMinutes(35),
                TimeSpan.FromMinutes(35),
                TimeSpan.FromMinutes(40),
                TimeSpan.FromMinutes(40),
                TimeSpan.FromMinutes(25)
            }, 2, 2, 4),   
            [ItemID.VoidvineSeed] = (ItemID.Voidvine, new[]
            {
                TimeSpan.FromMinutes(45),
                TimeSpan.FromMinutes(60),
                TimeSpan.FromMinutes(60),
                TimeSpan.FromMinutes(75),
                TimeSpan.FromMinutes(75),
                TimeSpan.FromMinutes(45)
            }, 3, 2, 3),
            [ItemID.StarseedFruitSeed]= (ItemID.StarseedFruit, new[]
            {
                TimeSpan.FromMinutes(40),
                TimeSpan.FromMinutes(55),
                TimeSpan.FromMinutes(55),
                TimeSpan.FromMinutes(65),
                TimeSpan.FromMinutes(65),
                TimeSpan.FromMinutes(40)
            }, 3, 2, 4),    
            [ItemID.QuasarCitrusSeed]= (ItemID.QuasarCitrus, new[]
            {
                TimeSpan.FromMinutes(35),
                TimeSpan.FromMinutes(45),
                TimeSpan.FromMinutes(45),
                TimeSpan.FromMinutes(55),
                TimeSpan.FromMinutes(55),
                TimeSpan.FromMinutes(35)
            }, 2, 3, 4),
            [ItemID.AuroraAppleSeed] = (ItemID.AuroraApple, new[]
            {
                TimeSpan.FromMinutes(20),
                TimeSpan.FromMinutes(25),
                TimeSpan.FromMinutes(25),
                TimeSpan.FromMinutes(30),
                TimeSpan.FromMinutes(30),
                TimeSpan.FromMinutes(20)
            }, 2, 3, 5), 
            [ItemID.CometCoralSeed] = (ItemID.CometCoral, new[]
            {
                TimeSpan.FromMinutes(30),
                TimeSpan.FromMinutes(40),
                TimeSpan.FromMinutes(40),
                TimeSpan.FromMinutes(45),
                TimeSpan.FromMinutes(45),
                TimeSpan.FromMinutes(40)
            }, 3, 1, 3), 
            [ItemID.StarlightSpinachSeed] = (ItemID.StarlightSpinach, new[]
            {
                TimeSpan.FromMinutes(12),
                TimeSpan.FromMinutes(18),
                TimeSpan.FromMinutes(18),
                TimeSpan.FromMinutes(20),
                TimeSpan.FromMinutes(22),
                TimeSpan.FromMinutes(15)
            }, 1, 4, 6),   
        };
}