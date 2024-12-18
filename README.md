# ChemistryExpanded

ChemistryExpanded is a mod for Dyson Sphere Program that adds new chemical processes to enhance your gameplay. It introduces various reactions, such as the electrolysis of water to obtain hydrogen.

### Water Electrolysis

- **Recipe:** 1 Water -> 1 Hydrogen (1 second)
- **Unlocks after:** Basic Chemicals Technology in the Chemical Plant

### Features:
- Electrolyze water to obtain hydrogen. This helps in hydrogen production.
- Hydrogen's heat value is adjusted for balance in the game.

### Installation

1. Install [BepInEx](https://github.com/BepInEx/BepInEx) if you haven't already.
2. Install [CommonAPI](https://github.com/xiaoye97/CommonAPI) and [LDBTool](https://github.com/xiaoye97/LDBTool).
3. Place the `WaterElectrolysis.dll` file into your `Dyson Sphere Program/BepInEx/plugins/` directory.

### Mod Conflicts

- RecipeProto.ID: 1001 (Ensure no other mods are using this ID).
- GridIndex: 1810 (This should be unique for your mod to avoid conflicts).

### Changelog

- v1.0.0: Initial release with Water Electrolysis recipe.

### License

This mod is distributed under the [MIT License](https://opensource.org/licenses/MIT).
