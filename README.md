# ChemistryExpanded

**ChemistryExpanded** is a mod for **Dyson Sphere Program** that adds several new chemical processes, including water electrolysis for hydrogen production, sulfuric acid decomposition, and more.

## Features

- **Water Electrolysis**: Convert water into hydrogen.
  - Formula: 1 Water -> 1 Hydrogen (1 second)
  - Hydrogen heat value adjusted to 440 kJ for balance.

- **Sulfuric Acid to Sulfur and Oxygen**: Decompose sulfuric acid into sulfur and oxygen.
  - Process: 1 Sulfuric Acid -> 1 Sulfur + 1 Oxygen (time and energy calculation to be added)

- **Boronene**: Added as a new chemical product. (Further details coming soon)

## Installation

1. Install BepInEx framework.
2. Install **CommonAPI** and **LDBTool**.
3. Place `ChemistryExpanded.dll` into the `Dyson Sphere Program/BepInEx/plugins/` folder.

## Mod Configuration

- You can adjust the mod's balancing via the config file. To disable the hydrogen heat value adjustment, set `"BalanceAdjustment"` to `false` in the configuration file.

## Compatibility

- This mod may conflict with other mods that use the following RecipeProto.ID or GridIndex:
  - **RecipeProto.ID**: 443
  - **GridIndex**: 1810

## Changelog

### v1.0.0
- Initial release with water electrolysis and hydrogen production.

## License

Distributed under the MIT License. See `LICENSE` for more information.
