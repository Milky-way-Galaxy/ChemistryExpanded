using System;
using System.Reflection;
using BepInEx;
using HarmonyLib;
using UnityEngine;
using xiaoye97;

namespace WaterElectrolysis
{
    [BepInDependency("me.xiaoye97.plugin.Dyson.LDBTool", BepInDependency.DependencyFlags.HardDependency)]
    [BepInPlugin("Gnimaerd.DSP.plugin.WaterElectrolysis", "WaterElectrolysis", "1.2")]
    public class WaterElectrolysis : BaseUnityPlugin
    {
        private Sprite icon;

        void Start()
        {
            var ab = AssetBundle.LoadFromStream(Assembly.GetExecutingAssembly().GetManifestResourceStream("Water_electrolysis.waterelecicon"));
            icon = ab.LoadAsset<Sprite>("WaterElec3");

            LDBTool.PreAddDataAction += AddTranslate;
            LDBTool.PostAddDataAction += AddWaterToH;
        }

        void AddWaterToH()
        {
            var ori = LDB.recipes.Select(23);

            var waterele = ori.Copy();
            waterele.ID = 443;
            waterele.Explicit = true;
            waterele.Name = "催化电解";
            waterele.name = "催化电解".Translate();
            waterele.Items = new int[] { 1000 };
            waterele.ItemCounts = new int[] { 1 };
            waterele.Results = new int[] { 1120 };
            waterele.ResultCounts = new int[] { 1 };
            waterele.GridIndex = 1110;
            waterele.SID = "1110";
            waterele.sid = "1110".Translate();
            Traverse.Create(waterele).Field("_iconSprite").SetValue(icon);
            waterele.TimeSpend = 30;
            waterele.Description = "催化电解描述";
            waterele.description = "催化电解描述".Translate();
            waterele.preTech = LDB.techs.Select(1121);

            // Add the recipe to the hydrogen item
            var h = LDB.items.Select(1120);
            h.recipes.Add(waterele);

            LDBTool.PostAddProto(ProtoType.Recipe, waterele);
        }

        void AddTranslate()
        {
            var recipeName = new CustomStringProto(
                id: 28001,
                name: "催化电解",
                zhcn: "催化电解",
                enus: "Water Electrolysis",
                frfr: "Water Electrolysis"
            );

            var desc = new CustomStringProto(
                id: 28002,
                name: "催化电解描述",
                zhcn: "电解水并获取氢气。",
                enus: "Electrolysis of water to produce hydrogen.",
                frfr: "Electrolysis of water to produce hydrogen."
            );

            LDBTool.PreAddProto(ProtoType.String, recipeName);
            LDBTool.PreAddProto(ProtoType.String, desc);
        }

        public class CustomStringProto : Proto
        {
            public string ZHCN; // Chinese translation
            public string ENUS; // English translation
            public string FRFR; // French translation

            public CustomStringProto(int id, string name, string zhcn, string enus, string frfr)
            {
                ID = id;
                Name = name;
                ZHCN = zhcn;
                ENUS = enus;
                FRFR = frfr;
            }

            public string GetTranslation(string languageCode)
            {
                if (languageCode == "ZHCN")
                {
                    return ZHCN;
                }
                else if (languageCode == "ENUS")
                {
                    return ENUS;
                }
                else if (languageCode == "FRFR")
                {
                    return FRFR;
                }
                else
                {
                    return Name; // Default to the Name if the language is unsupported
                }
            }
        }
    }
}   
