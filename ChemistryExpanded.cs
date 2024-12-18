using BepInEx;
using CommonAPI;
using System;

namespace ChemistryExpanded
{
    [BepInPlugin("com.milkyway.chemistryexpanded", "Chemistry Expanded", "1.0.0")]
    public class ChemistryExpandedPlugin : BaseUnityPlugin
    {
        public void Awake()
        {
            Logger.LogInfo("Chemistry Expanded Mod Loaded");

            // Add the electrolysis recipe when the mod is loaded
            AddElectrolysisRecipe();
        }

        private void AddElectrolysisRecipe()
        {
            // Creating a new recipe for Water Electrolysis
            RecipeProto electrolysisRecipe = new RecipeProto
            {
                Name = "Water Electrolysis",  // Recipe name
                Id = 1001,  // Recipe ID (you can choose a free ID in your game)
                Time = 1f,  // 1 second for the electrolysis reaction
                Icon = IconManager.GetIcon("icon"),  // Set the recipe icon (from the file named "icon.png")
                Description = "Electrolyze water to obtain hydrogen.", // Description
                // Inputs and outputs of the recipe
                Ingredients = new RecipeIngredient[]
                {
                    new RecipeIngredient { ItemId = 1000, Amount = 10 }  // 1 water (ID of water in the game)
                },
                Products = new RecipeProduct[]
                {
                    new RecipeProduct { ItemId = 1001, Amount = 10 }  // 1 hydrogen (ID of hydrogen in the game)
                }
            };

            // Add the recipe to the game
            LDBTool.AddRecipe(electrolysisRecipe);

            // Here, you would typically set the energy value of hydrogen
            // For simplicity, we'll set a static energy value for now.
            float hydrogenEnergyValue = 440000f;  // Energy value in Joules (for example, 440kJ = 440,000 J)

            // Calculate energy produced (for now just for simplicity as fixed value)
            // The energy calculation can be placed in a more dynamic way depending on the game mechanics.
            float producedEnergy = hydrogenEnergyValue;  // Energy produced per hydrogen (in Joules)
            Logger.LogInfo($"Energy produced per hydrogen: {producedEnergy} Joules");
        }
    }
}
