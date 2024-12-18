using BepInEx;
using LDBTool;
using UnityEngine;

[BepInPlugin("com.example.chemistryexpanded", "Chemistry Expanded", "1.0.0")]
[BepInDependency("me.xiaoye97.LDBTool", BepInDependency.DependencyFlags.HardDependency)]
public class ChemistryExpanded : BaseUnityPlugin
{
    void Start()
    {
        LDBTool.PreAddDataAction += AddCatalyticElectrolysisRecipe;
    }

    void AddCatalyticElectrolysisRecipe()
    {
        // Define a unique ID for the new item
        int newItemId = 9500; // Ensure this ID is unique and does not conflict with other mods

        // Create the new item
        var newItem = new ItemProto
        {
            ID = newItemId,
            Name = "Catalyst",
            Description = "A catalyst used in the electrolysis process.",
            GridIndex = 1801,
            IconPath = "BepInEx/plugins/ChemistryExpanded/icon.png",
            // Additional item properties...
        };

        // Add the new item to the game's item database
        LDB.items.dataArray = LDB.items.dataArray.AddToArray(newItem);

        // Define a unique ID for the new recipe
        int newRecipeId = 10500; // Ensure this ID is unique and does not conflict with other mods

        // Create the new recipe
        var newRecipe = new RecipeProto
        {
            ID = newRecipeId,
            Name = "Catalytic Electrolysis",
            GridIndex = 1802,
            IconPath = "BepInEx/plugins/ChemistryExpanded/icon.png",
            Description = "Produces oxygen and hydrogen using a catalyst.",
            Items = new int[] { LDB.items.Select(1000).ID, newItemId }, // Example: Water and Catalyst
            ItemCounts = new int[] { 1, 1 },
            Results = new int[] { LDB.items.Select(1100).ID, LDB.items.Select(1200).ID }, // Example: Oxygen and Hydrogen
            ResultCounts = new int[] { 1, 2 },
            TimeSpend = 1f,
            // Additional recipe properties...
        };

        // Add the new recipe to the game's recipe database
        LDB.recipes.dataArray = LDB.recipes.dataArray.AddToArray(newRecipe);
    }
}
