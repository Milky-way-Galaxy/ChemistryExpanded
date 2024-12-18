using BepInEx;
using LDBTool;
using UnityEngine;

namespace ChemistryExpanded
{
    [BepInPlugin("com.milkyway.ChemistryExpanded", "Chemistry Expanded", "1.0.0")]
    public class WaterElectrolysis : BaseUnityPlugin
    {
        // The recipe for Water Electrolysis (Water -> Hydrogen)
        void Start()
        {
            // Create the recipe for Water Electrolysis
            RecipeProto waterElectrolysisRecipe = new RecipeProto
            {
                ID = 1001, // Choose a unique ID for the recipe
                Name = "Water Electrolysis",
                Icon = "WaterElectrolysis.png", // Use the image file for the recipe icon
                TimeCost = 1.0f, // Set processing time (1 second for simplicity)
                InputItems = new[]
                {
                    new ItemProto
                    {
                        ID = 1, // Water ID (this might need to be adjusted)
                        Amount = 1
                    }
                },
                OutputItems = new[]
                {
                    new ItemProto
                    {
                        ID = 2, // Hydrogen ID (adjust this accordingly)
                        Amount = 1
                    }
                }
            };

            // Register the recipe
            LDBTool.RegisterRecipe(waterElectrolysisRecipe);
            
            // Log that the mod has started
            Logger.LogInfo("ChemistryExpanded Mod Loaded - Water Electrolysis Added!");
        }

        // Other methods can go here if you want to add more chemical processes
    }
}
